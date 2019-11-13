using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBoard
{
    public partial class FormCursos : Form
    {
        string idStudent;
        SQLiteConnector con;
        public FormCursos(FormMainStudent m, string idStudent)
        {
            InitializeComponent();
            this.MdiParent = m;
            con = new SQLiteConnector();
            this.idStudent = idStudent;
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            con.Open();
            string sql = @"select c.name from course c inner join course_student cs on c.idCourse=cs.idCourse
inner  join student s on s.idStudent=cs.idCourse where cs.idStudent= " + idStudent+";";
            dataGridView1.DataSource = con.SelectTable (sql);
            con.Close();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCursos_Load(object sender, EventArgs e)
        {

        }
    }
}
