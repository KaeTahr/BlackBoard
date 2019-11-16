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
    public partial class FormCrearTrabajo : Form
    {
        string idCourse;
        SQLiteConnector con;
        public FormCrearTrabajo(string idCourse)
        {
            InitializeComponent();
            this.idCourse = idCourse;
            con = new SQLiteConnector();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string desc = textBoxDesc.Text;
            string val = numericVal.Value.ToString();
            if(title==""||desc==""||val=="")
            {
                MessageBox.Show("Debe llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("Desea crear este trabajo?\nRevise todos los campos antes de confirmar.","Confirmar",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(dr.Equals(DialogResult.OK))
            {
                SendHomework(title,desc,val);
            }
        }

        private void SendHomework(string title,string desc,string val)
        {
            string sql = @"insert into assignment(weight,name,description,idCourse) values({0},'{1}','{2}',{3});";
            sql = String.Format(sql, val, title, desc, idCourse);
            DataTable dt;
            try 
            {
                con.Open();
                con.Command(sql);
                dt = con.SelectTable("select idStudent from course_student where idCourse=" + idCourse + ";");
                string idAss = con.SelectSingle("select idAssignment from assignment where idAssignment=(Select max(idAssignment) from assignment);");
                sql = "insert into assignment_student(idassignment,idstudent) values({0},{1});";

                foreach (DataRow r in dt.Rows)
                {
                    con.Command(string.Format(sql, idAss, r.ItemArray[0].ToString()));
                }

                con.Close();
            }
            catch (System.Data.SQLite.SQLiteException err)
            {
                MessageBox.Show(err.Message.ToString());
            }
            catch (System.IndexOutOfRangeException err)
            {
                MessageBox.Show("Error en el foreach\n"+err.Message);
            }

            finally
            {
                con.Close();
            }
            this.Close();
        }
    }
}
