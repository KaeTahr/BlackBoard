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
    public partial class FormProfessor : Form
    {
        FormLogin login;
        string idAccount;
        SQLiteConnector con;
        string idProfessor;

        public FormProfessor(FormLogin l, string idAccount)
        {
            InitializeComponent();
            con = new SQLiteConnector();
            login = l;
            this.idAccount = idAccount;
            setTitle();
        }
        void setTitle()
        {

            this.Text = "BlackBoard |  "  +GetUserName();
        }
        public string GetUserName()
        {
            string name = "";
            con.Open();
            idProfessor = con.SelectSingle("select idProfessor from account where idAccount =" + idAccount);
            DataTable tmp = con.SelectTable("select firstname, lastname from professor where idProfessor = " +idProfessor);
            name = tmp.Rows[0].ItemArray[0].ToString() + ' ';
            name += tmp.Rows[0].ItemArray[1].ToString();
            con.Close();
            return name;
        }

        private void FormProfessor_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
            login.ClearPassword();
        }


}
