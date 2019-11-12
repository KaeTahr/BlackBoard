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

            string username = textUser.Text;
            string password = textPassword.Text;
            
            if(username=="" || password=="")
            {
                MessageBox.Show("Debe llenar ambos campos.", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = @"select idAccount from Account where username='" + username + "' and password='" + password + "';";
            string idAccount = "";
            try
            {
                con.Open();
                idAccount = con.SelectSingle(sql);
                sql = @"select idProfessor from account where idAccount=" + idAccount;
                int accountType=0;
                if (con.SelectSingle(sql) == "")
                {
                    sql = @"select idStudent from account where idAccount=" + idAccount;
                    if (con.SelectSingle(sql) == "")
                    {
                        accountType = 0;
                    }
                    else
                    {
                        accountType = 2;
                    }
                }
                else
                {
                    accountType = 1;
                }
                con.Close();

                FormMain main = new FormMain(this,idAccount, accountType);
                this.Hide();
                main.Show();
            }
            catch(System.Data.SQLite.SQLiteException err)
            {
                MessageBox.Show(err.Message.ToString());
            }
            catch(System.IndexOutOfRangeException)
            {
                MessageBox.Show("Usuario o contraseña incorrecta","Credenciales Inválidas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally 
            {
                con.Close();
            }

        }

        public void ClearPassword()
        {
            textPassword.Text = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
