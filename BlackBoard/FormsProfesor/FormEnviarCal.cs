using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBoard.FormsProfesor
{
    public partial class FormEnviarCal : Form
    {
        SQLiteConnector con;
        string max;
        string idStudent;
        string idAssignment;
        FormRevisar parent;
        public FormEnviarCal(string idStudent, string idAssignment,FormRevisar parent)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            con = new SQLiteConnector();
            this.idAssignment = idAssignment;
            this.idStudent = idStudent;
            this.parent = parent;
            setMax();
        }
        void setMax()
        {
            con.Open();
            max = con.SelectSingle("Select weight from assignment where idassignment = " + idAssignment + ";");
            labelMax.Text = "(Máximo de " + max + ")";
            con.Close();
            numericUpDown1.Maximum = Convert.ToDecimal(max);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
           
            DialogResult dr = MessageBox.Show("¿Desea enviar la siguiente calificación?: " + numericUpDown1.Value.ToString()
                        , "Confirmar Calificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                con.Open();
                string sql = @"update assignment_student set grade={0} where idAssignment ={1} and idStudent={2};";
                con.Command(string.Format(sql, numericUpDown1.Value, idAssignment, idStudent));
                con.Close();
                MessageBox.Show("Se ha guardado la calificación exitosamente.","Entrega Calificada",MessageBoxButtons.OK,MessageBoxIcon.Information);
                parent.fillDataGridTrabajos();
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
