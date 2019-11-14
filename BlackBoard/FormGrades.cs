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
    public partial class FormGrades : Form
    {
        string idStudent;
        SQLiteConnector con;
        FormMainStudent parent;
        public FormGrades(FormMainStudent m, string idStudent)
        {
            InitializeComponent();
            this.MdiParent = m;
            con = new SQLiteConnector();
            this.idStudent = idStudent;
            parent = m;
        }

        private void FormGrades_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.setGradesBool();
        }
    }
}
