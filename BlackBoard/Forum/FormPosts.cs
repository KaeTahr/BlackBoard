using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBoard.Forum
{
    public partial class FormPosts : Form
    {
        string idForum;
        SQLiteConnector con;
        public FormPosts(string idForum)
        {
            InitializeComponent();
            con = new SQLiteConnector();
            this.idForum = idForum;
            GetOP();

        }
        
        private void GetOP()
        {
            con.Open();
            string sql = @"select name, description from Forum where idForum=" + idForum + ";";
            DataRow dr = con.SelectTable(sql).Rows[0];

            string authorSQL = @"select N.firstname as Nombre, N.Lastname as Apellido
                                    from forum f
                                    inner join 
                                        (select a.idaccount, s.firstname, s.lastname from student s 
                                        inner join account a on a.idstudent=s.idstudent
                                        union 
                                        select a.idaccount, p.firstname, p.lastname from professor p
                                        inner join account a on a.idprofessor=p.idprofessor) 
                                    as N 
                                    on N.idaccount=f.idauthor
                                    where f.idForum={0};";
      
            string author = (con.SelectTable(string.Format(authorSQL, idForum)).Rows[0].ItemArray[0].ToString() 
            + " " + (con.SelectTable(string.Format(authorSQL, idForum)).Rows[0].ItemArray[1].ToString()));
            con.Close();

            UCForum op = new UCForum(dr.ItemArray[0].ToString(),author,dr.ItemArray[1].ToString());
            op.Visible = true;
            op.Location = new System.Drawing.Point(8, 8);
            splitContainer1.Panel1.Controls.Add(op);
            

        }
    }
}
