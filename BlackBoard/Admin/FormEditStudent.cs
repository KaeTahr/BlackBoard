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
    public partial class FormEditStudent : Form
    {
        string idCourse;
        SQLiteConnector con;
        public FormEditStudent(string idCourse)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.idCourse = idCourse;
            numericUpDown1.Maximum = decimal.MaxValue;
            numericUpDown1.Minimum = 1;
            
            con = new SQLiteConnector();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idStudent = numericUpDown1.Value.ToString();

            try
            {
                string sql = @"insert into Course_student (idCourse, idStudent) values (" + idCourse + "," + idStudent + ");";
                con.Open();
                con.Command(sql);
                DataTable dt = con.SelectTable(@"select idAssignment from assignment where idCourse = " + idCourse + ";");
                foreach(DataRow r in dt.Rows)
                {
                    con.Command(@"insert into assignment_student (idStudent, idAssignment) values (" + idStudent + "," + r.ItemArray[0].ToString() + ");");
                }
                MessageBox.Show("Estudiante modificado existosamente", "Modificación Existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch(System.Data.SQLite.SQLiteException error)
            {
                con.Close();
                if(error.Message.Contains("UNIQUE constraint"))
                {
                    MessageBox.Show("Este estudiante ya está inscritio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (error.Message.Contains("FOREIGN KEY"))
                {
                    MessageBox.Show("No existe un estudiante con esta matrícula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(error.Message);
                }
               
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idStudent = numericUpDown1.Value.ToString();

            try
            {
                con.Open();
                DataTable dt = con.SelectTable(@"select * from course_student where idCourse = " + idCourse + " and idStudent = " + idStudent + ";");
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("El estudiante no está inscrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    return;
                }
                dt = con.SelectTable(@" select ass.idAssignment from assignment_student ass
                                               inner join assignment a on ass.idAssignment = a.idAssignment
                                                where a.idCourse = " + idCourse + " and idStudent = " + idStudent + ";");
                foreach(DataRow r in dt.Rows)
                {
                    con.Command(@"delete from assignment_student where idStudent = " + idStudent + " and idAssignment = " + r.ItemArray[0].ToString() + ";");
                }
                con.Command("delete from course_student where idCourse = " + idCourse + " and idStudent = " + idStudent + ";");
                MessageBox.Show("Estudiante eliminado del curso exitosamente", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch(System.Data.SQLite.SQLiteException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
