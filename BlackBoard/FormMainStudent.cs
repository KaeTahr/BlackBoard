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
    public partial class FormMainStudent : Form
    {
        FormLogin login;
        string idAccount;
        SQLiteConnector con;
        string idStudent;
        bool isCursosOpen;
        bool isGradesOpen;
        //bool isAssignmentsOpen;
        FormCursos cursos;
        FormGrades grades;
        //FormAssignments;
        public FormMainStudent(FormLogin l, string idAccount)
        {
            InitializeComponent();
            con = new SQLiteConnector();
            login = l;
            this.idAccount = idAccount;
            isCursosOpen = false;
            isGradesOpen = false;
            //IsAssignmentsOpen = false;
            setTitle();
            cursos = null;
            grades = null;
        }

        void setTitle()
        {

            this.Text = "BlackBoard |  "  +GetUserName();
        }

        //string GetUserName()
        //{
        //    string name = "";
        //    string sql = @" select b.firstname,b.lastname from account a
        //                    inner join professor b
        //                    on a.idProfessor=b.idProfessor 
        //                    where a.idaccount={0}
        //                    union
        //                    select  b.firstname,b.lastname from account a
        //                    inner join student b
        //                    on a.idStudent=b.idStudent
        //                    where a.idaccount={0};";

        //    sql = string.Format(sql, idAccount);

        //    try
        //    {
        //        con.Open();
        //        DataTable dt = con.SelectTable(sql);
        //        name += dt.Rows[0].ItemArray[0].ToString();
        //        name += " " + dt.Rows[0].ItemArray[1].ToString();

        //    }
        //    catch (System.Data.SQLite.SQLiteException err)
        //    {
        //        con.Close();
        //        MessageBox.Show(err.Message.ToString());
        //    }
        //    catch (System.IndexOutOfRangeException)
        //    {
        //        con.Close();
        //        con.Open();
        //        string isAdmin = con.SelectSingle(string.Format("Select isAdmin from account where idaccount={0}",idAccount));
        //        con.Close();
        //        if(isAdmin=="True")
        //        {
        //            name = "Administrador";
        //        }
        //        else
        //        {
        //            name = "Usuario sin nombre. (Si esta leyendo esto, regañe al diseñador de base de dato o el menso del front-end)";
        //        }

        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    return name;
        //}
        public string GetUserName()
        {
            string name = "";
            con.Open();
            idStudent = con.SelectSingle("select idStudent from account where idAccount =" + idAccount);
            DataTable tmp = con.SelectTable("select firstname, lastname from student where idStudent = " + idStudent);
            name = tmp.Rows[0].ItemArray[0].ToString() + ' ';
            name += tmp.Rows[0].ItemArray[1].ToString();
            con.Close();
            return name;
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
            login.ClearPassword();
        }


        public void setCursosBool()
        {
            isCursosOpen = false;
        }
        public void setGradesBool()
        {
            isGradesOpen = false;
        }
        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isCursosOpen)
            {
                cursos = new FormCursos(this, idStudent);
                cursos.Show();
                cursos.WindowState = FormWindowState.Minimized;
                cursos.WindowState = FormWindowState.Maximized;
                isCursosOpen = true;
            }
            else
            {
                cursos.Focus();
            }
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {     

            if (!isGradesOpen)
            {
                grades = new FormGrades(this, idStudent);
                grades.MdiParent = this;
                grades.Show();
                
                grades.WindowState = FormWindowState.Minimized;
                grades.WindowState = FormWindowState.Maximized;
                isGradesOpen = true;
            }
            else
            {
                grades.Focus();
            }
        }

    }
}
