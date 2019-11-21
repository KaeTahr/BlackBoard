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
    public partial class FormGrades : Form
    {
        string idStudent;
        SQLiteConnector con;
        FormMainStudent parent;
        public FormGrades(FormMainStudent m, string idStudent)
        {
            InitializeComponent();
            this.MdiParent = m;
            con = new SQLiteConnector();
            this.idStudent = idStudent;
            parent = m;
            fillDataGrid();
        }

        private void fillDataGrid()
        {
            string sql = @"select  c.name as Clase,sum(ass.grade) as Nota,sum(a.weight) as Total
                        from student s left join assignment_student ass on s.idStudent=ass.idStudent
                        inner join assignment a on a.idassignment = ass.idassignment
                        inner join course c on c.idcourse=a.idcourse
                        where s.idstudent={0}
                        group by c.idCourse;";
            con.Open();
            dataGridView1.DataSource = con.SelectTable(String.Format(sql, idStudent));
            con.Close();

        
        }

        private void FormGrades_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.setGradesBool();
        }
    }
}
