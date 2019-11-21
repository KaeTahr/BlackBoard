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
        bool dataGrabbed;
        string idStudent;
        SQLiteConnector con;
        FormMainStudent parent;
        public FormGrades(FormMainStudent m, string idStudent)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.MdiParent = m;
            con = new SQLiteConnector();
            this.idStudent = idStudent;
            parent = m;
            dataGrabbed = false;
            fillDataGrid();
        }

        private void fillDataGrid()
        {
            string sql = @"select  c.name as Clase,sum(ass.grade) as Nota,sum(a.weight) as Total
                        from student s left join assignment_student ass on s.idStudent=ass.idStudent
                        inner join assignment a on a.idassignment = ass.idassignment
                        inner join course c on c.idcourse=a.idcourse
                        where s.idstudent={0}
                        group by c.idCourse;";
            con.Open();
            dataGridView1.DataSource = con.SelectTable(String.Format(sql, idStudent));
            con.Close();

            dataGrabbed = true;
            DataGridViewColumn dc = new DataGridViewColumn()
            {
                Name = "percentGrade",
                Visible = true,
                HeaderText = "Promedio",
                CellTemplate = new DataGridViewTextBoxCell()
            };
            dataGridView1.Columns.Insert(3, dc);
            //setAverages();
        
        }

        private void setAverages()
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                decimal val = Convert.ToDecimal(r.Cells["Nota"].Value);
                decimal total = Convert.ToDecimal(r.Cells["Total"].Value);
                string result;
                try
                {
                    result = ((val / total) * 100).ToString() + "%";
                    Console.WriteLine(result);
                    r.Cells["percentGrade"].Value = result;
                }
                catch(DivideByZeroException e)
                {
                    return;
                }
                
               
            }
        }

        private void FormGrades_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.setGradesBool();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if(dataGrabbed)
                setAverages();
        }
    }
}
