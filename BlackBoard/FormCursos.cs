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
    public partial class FormCursosStudent : Form
    {
        public FormCursosStudent(FormMain m)
        {
            InitializeComponent();
            this.MdiParent = m;
        }
    }
}
