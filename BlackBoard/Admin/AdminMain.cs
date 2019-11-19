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
        bool isCuentasOpen;
        bool isCursosOpen;
        public AdminMain()
        {
            isCuentasOpen = isCursosOpen = false;
            InitializeComponent();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isCuentasOpen)
            {
                isCuentasOpen = true;
                FormCuentas fc = new FormCuentas();
                fc.Show();
            }

        }
    }
}
