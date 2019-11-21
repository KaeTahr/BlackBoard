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
        string idForum, idAutor;
        SQLiteConnector con;
        public FormPosts(string idForum, string idAutor)
        {
            InitializeComponent();
            con = new SQLiteConnector();
            this.idForum = idForum;
            this.idAutor = idAutor;
            getTitle();
            GetOP();
            
        }

        private void getTitle()
        {
            con.Open();
            this.Text = "Foro: " + con.SelectSingle(@"select name from Forum where idForum=" + idForum + ";");
            con.Close();
        }
        
        private void GetOP()
        {
            flowLayoutPanel1.Controls.Clear();
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
            flowLayoutPanel1.Controls.Add(op);
            getPost();
        }

        public void getPost()
        {

            con.Open();
            string sql = @"select idpost,text from post where idForum=" + idForum + ";";
            DataTable dt = con.SelectTable(sql);

            string authorSQL = @"select N.firstname as Nombre, N.Lastname as Apellido
                                    from post f
                                    inner join 
                                        (select a.idaccount, s.firstname, s.lastname from student s 
                                        inner join account a on a.idstudent=s.idstudent
                                        union 
                                        select a.idaccount, p.firstname, p.lastname from professor p
                                        inner join account a on a.idprofessor=p.idprofessor) 
                                    as N 
                                    on N.idaccount=f.idauthor
                                    where f.idpost={0};";

            foreach(DataRow r in dt.Rows)
            {
                string author = (con.SelectTable(string.Format(authorSQL, r.ItemArray[0].ToString())).Rows[0].ItemArray[0].ToString()
            + " " + (con.SelectTable(string.Format(authorSQL, r.ItemArray[0].ToString())).Rows[0].ItemArray[1].ToString()));
                

                UCReply post = new UCReply(author, r.ItemArray[1].ToString());
                flowLayoutPanel1.Controls.Add(post);
            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("¿Desea enviar la respuesta?", "Confirmar Envío", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string sql = @"insert into post(idForum,text,idAuthor) values ({0},'{1}',{2});";
                con.Open();
                con.Command(string.Format(sql, idForum, textBox1.Text, idAutor));
                con.Close();
                GetOP();
                textBox1.Text = "";
            }
        }
    }
}
