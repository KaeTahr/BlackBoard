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
    public partial class FormEditCourse : Form
    {
        SQLiteConnector con;
        public FormEditCourse()
        {
            InitializeComponent();
            con = new SQLiteConnector(); 
            fillDataGrid();
        }
        void fillDataGrid()
        {
            con.Open();
            dataGridView1.DataSource = con.SelectTable(@"select c.idCourse as ID, c.name as Nombre, c.idProfessor as 'id Professor', p.lastname  as apellido from
                                                        course c inner join professor p on c.idProfessor = p.idProfessor;");
            con.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idCourse = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            FormSendCourse sc = new FormSendCourse(idCourse, name);
            sc.Show();
        }
    }
}
