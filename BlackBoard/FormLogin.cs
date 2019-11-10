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
            DataSet test = null;
            try
            {
                con.Open();
                test = con.Select("Select idAccount from Account;");
                MessageBox.Show(test.GetXml());
                FormMain main = new FormMain(this);
                this.Hide();
                main.Show();
            }
            catch(System.Data.SQLite.SQLiteException err)
            {
                MessageBox.Show(err.Message.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
