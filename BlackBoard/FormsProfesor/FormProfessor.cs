using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBoard.FormsProfesor
{
    public partial class FormProfessor : Form
    {
        FormLogin login;
        string idAccount;
        SQLiteConnector con;
        string idProfessor;
        Color SelectedCellForeground;
        Color SelectedCellBackground;
        string selectedCourse;
        

        public FormProfessor(FormLogin l, string idAccount)
        {
            InitializeComponent();
            con = new SQLiteConnector();
            login = l;
            this.idAccount = idAccount;
            setTitle();
            FillDataGridView();
            selectedCourse = "";
        }
        void setTitle()
        {

            this.Text = "BlackBoard |  " + GetUserName();
        }
        public string GetUserName()
        {
            string name = "";
            con.Open();
            idProfessor = con.SelectSingle("select idProfessor from account where idAccount =" + idAccount);
            DataTable tmp = con.SelectTable("select firstname, lastname from professor where idProfessor = " + idProfessor);
            name = tmp.Rows[0].ItemArray[0].ToString() + ' ';
            name += tmp.Rows[0].ItemArray[1].ToString();
            con.Close();
            return name;
        }

        private void FormProfessor_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
            login.ClearPassword();
        }

        private void buttonCrear_HW_Click(object sender, EventArgs e)
        {
            if(selectedCourse=="")
            {
                MessageBox.Show("Seleccione un curso.","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            FormCrearTrabajo ct = new FormCrearTrabajo(selectedCourse, this);
            ct.Show();
        }
        private void FillDataGridView()
        {
            con.Open();
            string sql = @"select name, idCourse from course where idProfessor = " + idProfessor + ";";
            dataGridView1.DataSource = con.SelectTable(sql);
            con.Close();
            dataGridView1.Columns[1].Visible = false;
            SelectedCellForeground = dataGridView1.DefaultCellStyle.SelectionForeColor;
            SelectedCellBackground = dataGridView1.DefaultCellStyle.SelectionBackColor;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DefaultCellStyle.SelectionBackColor = SelectedCellBackground;
            dataGridView1.DefaultCellStyle.SelectionForeColor = SelectedCellForeground;
            selectedCourse = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            fillDataGridAssignment();
            labelTitle.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            con.Open();
            textBoxDesc.Text = con.SelectSingle("select description from Course where idCourse = " + selectedCourse + ";").ToString();
            con.Close();
        }

        public void fillDataGridAssignment()
        {
            string sql = "select idAssignment, name as Título from assignment where idCourse = "+ selectedCourse + ";";
            con.Open();
            dataGridAssignments.DataSource = con.SelectTable(sql);
            con.Close();
            dataGridAssignments.Columns[0].Visible = false;

            //TODO: First assignment still appears as selected on start
            //not too bit of a problem since a student selected doesn't really mean anything
            //but may or may not want to fix this
            SelectedCellForeground = dataGridAssignments.DefaultCellStyle.SelectionForeColor;
            SelectedCellBackground = dataGridAssignments.DefaultCellStyle.SelectionBackColor;
            dataGridAssignments.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridAssignments.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
        }

        private void dataGridAssignment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedAssignment = dataGridAssignments.SelectedRows[0].Cells[0].Value.ToString();
            string name = dataGridAssignments.SelectedRows[0].Cells[1].Value.ToString();
            FormRevisar ct = new FormRevisar(selectedAssignment,name, this);
            ct.Show();

        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            con.Open();
            con.Command("update Course set description = '" + textBoxDesc.Text.ToString() + "' where idCourse = " + selectedCourse + ";");
            con.Close();

        }
    }
}
