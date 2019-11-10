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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //TODO: create login logic 
            SQLiteConnector con = new SQLiteConnector();
            con.Open();

            DataSet test = con.Select("Select * from student;");
        

            MessageBox.Show(test.GetXml());

            FormMain main = new FormMain(this);
            this.Hide();
            main.Show();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
