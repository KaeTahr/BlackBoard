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
        FormMainStudent parent;
        string selectedCourse;

        public FormCursos(FormMainStudent m, string idStudent)
        {
            InitializeComponent();
            this.MdiParent = m;
            con = new SQLiteConnector();
            this.idStudent = idStudent;
            FillDataGridView();
            parent = m;
        }

        private void FillDataGridView()
        {
            con.Open();
            string sql = @"select c.name as Curso, c.idCourse from course c inner join course_student cs on c.idCourse=cs.idCourse
inner  join student s on s.idStudent=cs.idCourse where cs.idStudent= " + idStudent+";";
            dataGridView1.DataSource = con.SelectTable(sql);

            //Fill Tareas
            con.Close();
            dataGridView1.Columns[1].Visible = false;

            
            
        }

        private void FormCursos_Load(object sender, EventArgs e)
        {

        }

        private void FormCursos_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.setCursosBool();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCourse = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            labelTitle.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
          
            string sql = "select description from course where idcourse =" + selectedCourse +";";
            con.Open();
            labelDesc.Text = con.SelectSingle(sql);
            labelProfe.Text = "Prof. " + con.SelectSingle("select p.lastname from professor p inner join course c on c.idprofessor = p.idprofessor where c.idCourse=" + selectedCourse + ";");
            con.Close();
            

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void dataGridTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
