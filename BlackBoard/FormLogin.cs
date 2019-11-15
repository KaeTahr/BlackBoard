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
            Login();

        }

        private void Login()
        {
            SQLiteConnector con = new SQLiteConnector();

            string username = textUser.Text.ToUpper();
            string password = textPassword.Text;

            if (username == "" || password == "")
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
                if (con.SelectSingle(sql) == "")
                {
                    sql = @"select idStudent from account where idAccount=" + idAccount;
                    if (con.SelectSingle(sql) == "")
                    {
                        con.Close();
                        FormMainStudent main = new FormMainStudent(this, idAccount); // TODO: implemenent admin screen
                        main.Show();
                    }
                    else
                    {
                        con.Close();
                        FormMainStudent main = new FormMainStudent(this, idAccount);
                        main.Show();
                    }
                }
                else
                {
                    con.Close();
                    FormsProfesor.FormProfessor main = new FormsProfesor.FormProfessor(this, idAccount); // TODO: implemenent teacher screen
                    main.Show();
                }
                con.Close();


                this.Hide();

            }
            catch (System.Data.SQLite.SQLiteException err)
            {
                MessageBox.Show(err.Message.ToString());
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Credenciales Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
                e.Handled = true;
            }
        }
    }
}
