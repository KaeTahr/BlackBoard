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
    public partial class AdminMain : Form
    {
        public bool isCuentasOpen;
        bool isCursosOpen;
        FormLogin login;
        public AdminMain(FormLogin l)
        {
            isCuentasOpen = isCursosOpen = false;
            InitializeComponent();
            login = l;
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isCuentasOpen)
            {
                isCuentasOpen = true;
                FormCuentas fc = new FormCuentas();
                fc.MdiParent = this;
                fc.Show();
            }

        }

        private void AdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
            login.ClearPassword();
        }

        private void verEditarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditCourse ec = new FormEditCourse();
            ec.MdiParent = this;
            ec.Show();
        }
    }
}
