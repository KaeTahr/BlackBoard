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
    public partial class FormSendCourse : Form
    {
        SQLiteConnector con;
        string idCourse;
        public FormSendCourse(string idCourse, string courseName)
        {
            InitializeComponent();
            con = new SQLiteConnector();
            this.idCourse = idCourse;
            textBox1.Text = courseName;
            fillStudents();
        }

        void fillStudents()
        {
            con.Open();
            dataGridView1.DataSource = con.SelectTable(@"select cs.idStudent as ID, s.lastname as Apellido from course_student cs 
                                                          inner join student s on s.idStudent = cs.idStudent where idCourse = " + idCourse + ";");
            con.Close();
        }

    }
}
