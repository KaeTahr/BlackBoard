using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBoard.Admin
{
    public partial class FormCuentas : Form
    {
        SQLiteConnector con;
        AdminMain parent;
        public FormCuentas(AdminMain parent)
        {
            InitializeComponent();
            con = new SQLiteConnector();
            fillGrids();
            this.parent = parent;
            
        }

        public void fillGrids()
        {
            string sql = @"select s.idStudent as Matrícula, s.firstname as Nombre, s.lastname as Apellido, a.username as Cuenta
    from student s left join Account a on a.idStudent = s.idStudent;";
            con.Open();
            dataGridStudents.DataSource = con.SelectTable(sql);

            sql = @"select s.idProfessor as Matrícula, s.firstname as Nombre, s.lastname as Apellido, a.username as Cuenta
    from professor s left join Account a on a.idProfessor = s.idProfessor;";
            dataGridProfessors.DataSource = con.SelectTable(sql);
            con.Close();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            FormAddAcc ac = new FormAddAcc(this);
            ac.Show();
        }

        private void dataGridProfessors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idProfessor = dataGridProfessors.SelectedRows[0].Cells["Matrícula"].Value.ToString();
            FormAddAcc ac = new FormAddAcc(this, idProfessor, "professor");
            ac.Show();
            
        }

        private void dataGridStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string idStudent = dataGridStudents.SelectedRows[0].Cells["Matrícula"].Value.ToString();
            FormAddAcc ac = new FormAddAcc(this, idStudent, "student");
            ac.Show();
        }

        private void FormCuentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.isCuentasOpen = false;
        }
    }
}
