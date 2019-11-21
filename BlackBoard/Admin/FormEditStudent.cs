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
    }
}
