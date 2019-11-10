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
    public partial class FormMain : Form
    {
        FormLogin login;
        string idAccount;
        SQLiteConnector con;
        public FormMain(FormLogin l, string idAccount)
        {
            InitializeComponent();
            con = new SQLiteConnector();
            login = l;
            this.idAccount = idAccount;
            setTitle();
        }

        void setTitle()
        {
            this.Text = "BlackBoard | "+GetUserName();
        }

        string GetUserName()
        {
            string name = "";
            string sql = @" select a.idAccount,b.firstname,b.lastname from account a
                            inner join professor b
                            on a.idProfessor=b.idProfessor 
                            where a.idaccount={0}
                            union
                            select  a.idAccount,b.firstname,b.lastname from account a
                            inner join student b
                            on a.idStudent=b.idStudent
                            where a.idaccount={0};";

            sql = string.Format(sql, idAccount);

            try
            {
                con.Open();
                DataTable dt = con.SelectTable(sql);
                name += dt.Rows[0].ItemArray[1].ToString();
                name += " " + dt.Rows[0].ItemArray[2].ToString();

            }
            catch (System.Data.SQLite.SQLiteException err)
            {
                con.Close();
                MessageBox.Show(err.Message.ToString());
            }
            ///TODO:actually check if a user without a name is an admin
            catch (System.IndexOutOfRangeException)
            {
                con.Close();
                con.Open();
                string isAdmin = con.SelectSingle(string.Format("Select isAdmin from account where idaccount={0}",idAccount));
                con.Close();
                if(isAdmin=="True")
                {
                    name = "Administrador";
                }
                else
                {
                    name = "Usuario sin nombre. (Si esta leyendo esto, regañe al diseñador de base de dato)";
                }

            }
            finally
            {
                con.Close();
            }
            return name;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
            login.ClearPassword();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openCursos();
        }

        void openCursos()
        {
            FormCursos fc = new FormCursos(this);
            fc.Show();
        }
    }
}
