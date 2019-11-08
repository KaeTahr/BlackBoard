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
    public partial class FormMain : Form
    {
        FormLogin login;
        public FormMain(FormLogin l)
        {
            InitializeComponent();
            login = l;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }
    }
}
