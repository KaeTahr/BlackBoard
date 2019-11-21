using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBoard
{
    public partial class UCReply : UserControl
    {
        public UCReply(string author, string content)
        {
            InitializeComponent();
            AuthorName.Text = author;
            label1.Text = content;
        }
    }
}
