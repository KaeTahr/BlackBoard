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
    public partial class FormCuentas : Form
    {
        SQLiteConnector con;
        public FormCuentas()
        {
            InitializeComponent();
            con = new SQLiteConnector();
        }

        void fillStudents()
        {
            string sql;
            //TODO decide if you will kee working on this thing
        }
    }
}
