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
    public partial class FormRevisar : Form
    {
        string idAssignment;
        string AssignmentName;
        SQLiteConnector con;
        FormProfessor parent;
        public FormRevisar(string idAssignment, string AssName, FormProfessor parent)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.idAssignment = idAssignment;
            AssignmentName = AssName;
            setTitle();
            con = new SQLiteConnector();
            fillDataGridTrabajos();
            this.parent = parent;

        }

        public void fillDataGridTrabajos()
        {

            string sql = @"select ass.idStudent as Matricula, s.firstname as Nombre, s.lastname as Apellido, ass.completed as Entregado, ass.grade as Calificación
    from student s inner join assignment_student ass on s.idStudent=ass.idStudent
where idAssignment = " + idAssignment;
            con.Open();
            dataGridView1.DataSource = con.SelectTable(sql);
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["Entregado"].Value) == true)
                {
                    string idStudent = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    FormEnviarCal ec = new FormEnviarCal(idStudent, idAssignment, this);
                    ec.Show();
                }
                else
                {
                    MessageBox.Show("El trabajo no ha sido entregado");
                }
            }
            catch (ArgumentOutOfRangeException) { } //clicked on the header, don't do anything
        }
        void setTitle()
        {

            this.Text = "BlackBoard |  " + AssignmentName;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea eliminar este trabajo?" 
                        , "Confirmar Calificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                con.Open();
                con.Command("delete from assignment_student where idAssignment = " + idAssignment + ";");
                con.Command("delete from Assignment where idAssignment = " + idAssignment + ";");
                con.Close();
                parent.fillDataGridAssignment();
                this.Close();
            }

        }
    }
}
