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
    public partial class FormCreateCourse : Form
    {
        SQLiteConnector con;
        public FormCreateCourse()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            con = new SQLiteConnector();
            numericUpDownProf.Maximum = decimal.MaxValue;
            numericUpDownProf.Minimum = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string idProfessor = numericUpDownProf.Value.ToString();

            if (name == "")
            {
                MessageBox.Show("Los cursos deben tener un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string sql = "insert into Course (name, idProfessor) values ('{0}', '{1}');";
                sql = string.Format(sql, name, idProfessor);
                con.Open();
                con.Command(sql);
                con.Close();
                MessageBox.Show("Curso creado correctamente");
                this.Close();
            }
            catch (System.Data.SQLite.SQLiteException error)
            {
                if (error.Message.Contains("KEY constraint"))
                {
                    MessageBox.Show("No existe este profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
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