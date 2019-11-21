using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBoard.Forum
{
    public partial class ForumMenu : UserControl
    {
        SQLiteConnector con;
        string idCourse;
        string sql;
        string idAccount;
        public ForumMenu(string idCourse, string idAccount)
        {
            InitializeComponent();
            con = new SQLiteConnector();
            this.idCourse = idCourse;
            this.idAccount = idAccount;
            sql = @"select f.idForum, f.name as Foro, N.firstname as Nombre, N.Lastname as Apellido
                    from forum f
                    inner join 
                        (select a.idaccount, s.firstname, s.lastname from student s 
                        inner join account a on a.idstudent=s.idstudent
                        union 
                        select a.idaccount, p.firstname, p.lastname from professor p
                        inner join account a on a.idprofessor=p.idprofessor) 
                    as N 
                    on N.idaccount=f.idauthor
                    where f.idCourse={0};";

            FillDataGrid();
        }

        public void FillDataGrid()
        {
            con.Open();
            dataGridView1.DataSource = con.SelectTable(string.Format(sql, idCourse));
            con.Close();
            dataGridView1.Columns["idForum"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: implement forum creation form
            FormForum f = new FormForum(idAccount, idCourse,this);
            f.Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idForum = dataGridView1.Rows[e.RowIndex].Cells["idForum"].Value.ToString();
            FormPosts fp = new FormPosts(idForum,idAccount);
            fp.MdiParent = this.ParentForm.MdiParent;
            fp.Show();
        }
    }
}
