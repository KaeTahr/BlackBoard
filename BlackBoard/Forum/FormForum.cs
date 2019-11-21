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
    public partial class FormForum : Form
    {
        SQLiteConnector con;
        ForumMenu parent;
        string idAuthor, idCourse;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FormForum(string idAuthor, string idCourse, ForumMenu parent)
        {
            InitializeComponent();
            this.idAuthor = idAuthor;
            this.idCourse = idCourse;
            con = new SQLiteConnector();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text =="" || textBoxContent.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("¿Desea enviar el foro?", "Confirmar Envío", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                InsertForum();
                parent.FillDataGrid();
                this.Close();
            }
        }

        private void InsertForum()
        {
            string name = textBoxName.Text;
            string content = textBoxContent.Text;
            string sql = @"insert into forum(name, description,idauthor,idcourse) values('{0}','{1}',{2},{3});";
            con.Open();
            con.Command(string.Format(sql, name, content, idAuthor, idCourse));
            con.Close();
        }
    }
}
