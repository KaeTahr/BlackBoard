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
        public FormSendCourse(string idCourse, string courseName, string teacherID)
        {
            InitializeComponent();
            con = new SQLiteConnector();
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = decimal.MaxValue;
            this.idCourse = idCourse;
            textBox1.Text = courseName;
            numericUpDown1.Value = Convert.ToDecimal(teacherID);
            fillStudents();
        }

        void fillStudents()
        {
            con.Open();
            dataGridView1.DataSource = con.SelectTable(@"select cs.idStudent as ID, s.lastname as Apellido from course_student cs 
                                                          inner join student s on s.idStudent = cs.idStudent where idCourse = " + idCourse + ";");
            con.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("¿Desea actualizar  este curso?", "Confirmar Envío", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr.Equals(DialogResult.No))
                return;
            try
            {

                con.Open();
                con.Command(@"update course set name = '" + textBox1.Text + "', idProfessor = " + numericUpDown1.Value.ToString() + " where idCourse = " + idCourse + ";");
                con.Close();
            }
            catch(System.Data.SQLite.SQLiteException)
            {
                con.Close();
                MessageBox.Show("ID de profesor no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
