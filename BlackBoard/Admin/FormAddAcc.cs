using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBoard.Admin
{
    public partial class FormAddAcc : Form
    {
        FormCuentas parent;
        SQLiteConnector con;
        string idUser;
        bool isEditing;
        string accountType;
        public FormAddAcc(FormCuentas parent)
        {
            InitializeComponent();
            this.parent = parent;
            con = new SQLiteConnector();
            isEditing = false;
        }

        public FormAddAcc(FormCuentas parent, string idUs, string accType)
        {
            InitializeComponent();
            con = new SQLiteConnector();
            idUser = idUs;
            this.parent = parent;
            isEditing = true;
            accountType = accType;
            fillFields();
        }

        private void fillFields()
        {
            con.Open();
            textBoxFirstName.Text = con.SelectSingle("select firstname from " + accountType + " where id" + accountType + " = "  + idUser ).ToString();
            textBoxLastName.Text = con.SelectSingle("select lastname from " + accountType + " where id" + accountType + " = "  + idUser ).ToString();
            textBoxPassword.Text = con.SelectSingle(string.Format(@"select a.password from account a
                                                                    inner join {0} s on a.id{0} = s.id{0}
                                                                    where a.id{0} = {1};", accountType, idUser)).ToString();
            con.Close();
            if (accountType.ToLower() == "professor")
            {
                comboBox1.SelectedIndex = 1;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }
            comboBox1.Enabled = false;
        }
        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                editAcc();
            }
            else
            {
                createNewAcc();
            }
        }

        void editAcc()
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;
            con.Open();
            string idAccount = con.SelectSingle(string.Format(@"Select a.idAccount from account a
                                                inner join {0} u on a.id{0} = u.id{0}
                                                where u.id{0} = {1};", accountType, idUser));
            con.Close();

            if (firstName == "" || lastName == "" || password == "")
            {
                MessageBox.Show("Todos los campos deben llenarse", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("¿Desea editar esta cuenta?", "Confirmar Envío", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr.Equals(DialogResult.No))
                return;

            string sql = string.Format(@"update {2} set firstName='{0}', lastName='{1}' where id{2}={3};", firstName, lastName, accountType, idUser);
            con.Open();
            con.Command(string.Format(sql));

            sql = @"update account set password='{0}' where idaccount={1};";
            con.Command(string.Format(sql, password, idAccount));
            con.Close();
            parent.fillGrids();
            this.Close();
        }
        private void createNewAcc()
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string password = textBoxPassword.Text;
            if (firstName == "" || lastName == "" || password == "")
            {
                MessageBox.Show("Todos los campos deben llenarse", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("¿Desea agregar esta cuenta?", "Confirmar Envío", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr.Equals(DialogResult.No))
                return;

            if (comboBox1.SelectedIndex.Equals(0))
            {
                string sql = @"insert into student (firstName, lastName) values ('{0}','{1}');";
                con.Open();
                con.Command(string.Format(sql, firstName, lastName));
                string idStudent = con.SelectSingle("select idStudent from student where idStudent=(Select max(idStudent) from Student);");
                sql = @"insert into Account (password, username, idStudent) values ('{0}', '{1}', {2});";
                con.Command(string.Format(sql, password, "A" + idStudent, idStudent));
                con.Close();
                parent.fillGrids();
                this.Close();
            }
            else
            {
                string sql = @"insert into professor (firstName, lastName) values ('{0}','{1}');";
                con.Open();
                con.Command(string.Format(sql, firstName, lastName));
                string idProfessor = con.SelectSingle("select idProfessor from professor where idProfessor=(Select max(idProfessor) from Professor);");
                sql = @"insert into Account (password, username, idProfessor) values ('{0}', '{1}', {2});";
                con.Command(string.Format(sql, password, "L" + idProfessor, idProfessor));
                con.Close();
                parent.fillGrids();
                this.Close();
                
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
