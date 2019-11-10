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
            SQLiteConnector con = new SQLiteConnector();
            DataSet test = null;

            string username = textUser.Text;
            string password = textPassword.Text;

            string sql = @"select idAccount from Account where username='" + username + "' and password='" + password + "';";
            string idAccount = "";
            try
            {
                con.Open();

                idAccount = con.Select(sql).Tables[0].Rows[0].ItemArray[0].ToString();

                MessageBox.Show(idAccount);
                FormMain main = new FormMain(this);
                this.Hide();
                main.Show();
            }
            catch(System.Data.SQLite.SQLiteException err)
            {
                MessageBox.Show(err.Message.ToString());
            }
            catch(System.IndexOutOfRangeException err)
            {
                MessageBox.Show("Usuario o contraseña incorrecta","Credenciales Inválidas",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
