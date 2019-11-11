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
        int userType;
        enum USERS { ADMIN, PROFESSOR, STUDENT};
        public FormMain(FormLogin l, string idAccount, int userType)
        {
            InitializeComponent();
            con = new SQLiteConnector();
            login = l;
            this.idAccount = idAccount;
            this.userType = userType;
            setTitle();
            openDefault();
        }

        void setTitle()
        {
            string type;
            switch(userType)
            {
                case (int)USERS.ADMIN:
                    type = "admin";
                    break;
                case (int)USERS.PROFESSOR:
                    type = "Profesor";
                    break;
                case (int)USERS.STUDENT:
                    type = "Alumno";
                    break;
                default:
                    type = "";
                    break;
            }
            this.Text = "BlackBoard | " + type + " "  +GetUserName();
        }

        string GetUserName()
        {
            string name = "";
            string sql = @" select b.firstname,b.lastname from account a
                            inner join professor b
                            on a.idProfessor=b.idProfessor 
                            where a.idaccount={0}
                            union
                            select  b.firstname,b.lastname from account a
                            inner join student b
                            on a.idStudent=b.idStudent
                            where a.idaccount={0};";

            sql = string.Format(sql, idAccount);

            try
            {
                con.Open();
                DataTable dt = con.SelectTable(sql);
                name += dt.Rows[0].ItemArray[0].ToString();
                name += " " + dt.Rows[0].ItemArray[1].ToString();

            }
            catch (System.Data.SQLite.SQLiteException err)
            {
                con.Close();
                MessageBox.Show(err.Message.ToString());
            }
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
                    name = "Usuario sin nombre. (Si esta leyendo esto, regañe al diseñador de base de dato o el menso del front-end)";
                }

            }
            finally
            {
                con.Close();
            }
            return name;
        }

        void openDefault()
        {
            switch(userType)
            {
                case (int)USERS.ADMIN:
                    break;
                case (int)USERS.PROFESSOR:
                    break;
                case (int)USERS.STUDENT:
                    openCursosStudent();
                    break;
            }
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
            login.ClearPassword();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openCursosStudent();
        }

        void openCursosStudent()
        {
            FormCursosStudent fc = new FormCursosStudent(this);
            fc.Show();
        }
    }
}
