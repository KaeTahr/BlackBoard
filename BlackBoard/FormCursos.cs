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
    public partial class FormCursos : Form
    {
        string idStudent;
        SQLiteConnector con;
        FormMainStudent parent;
        string selectedCourse;
        Color SelectedCellForeground;
        Color SelectedCellBackground;

        public FormCursos(FormMainStudent m, string idStudent)
        {
            InitializeComponent();
            this.MdiParent = m;
            con = new SQLiteConnector();
            this.idStudent = idStudent;
            FillDataGridView();
            parent = m;
            selectedCourse = "";
        }

        private void FillDataGridView()
        {
            con.Open();
            string sql = @"select c.name as Curso, c.idCourse from course c inner join course_student cs on c.idCourse=cs.idCourse
inner  join student s on s.idStudent=cs.idCourse where cs.idStudent= " + idStudent+";";
            dataGridView1.DataSource = con.SelectTable(sql);

            //Fill Tareas
            con.Close();
            dataGridView1.Columns[1].Visible = false;

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            SelectedCellForeground = dataGridView1.DefaultCellStyle.SelectionForeColor;
            SelectedCellBackground = dataGridView1.DefaultCellStyle.SelectionBackColor;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;


        }

        private void FillHWDataGridView()
        {
            string sql = @"select a.name as Nombre, a.description as Descripción,ass.grade as Calificación, a.weight as Valor, ass.completed as Entregado, ass.idAssignment from assignment a
                inner join assignment_student ass on ass.idAssignment=a.idAssignment
                where idStudent={0} and a.idCourse={1};";
            con.Open();
            dataGridTareas.DataSource = con.SelectTable(string.Format(sql, idStudent, selectedCourse));
            con.Close();

            dataGridTareas.Columns["idAssignment"].Visible = false;

            dataGridTareas.ReadOnly = false;
            for(int i = 0; i<4;i++)
            {
                dataGridTareas.Columns[i].ReadOnly = true;
            }


            //disable editing on cells that are enabled
            foreach(DataGridViewRow r in dataGridTareas.Rows)
            {
                if(Convert.ToBoolean(r.Cells["Entregado"].Value)==true)
                {
                    r.Cells["Entregado"].ReadOnly = true;
                    if(r.Cells["Calificación"].Value.ToString()=="")
                    {
                        r.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if(r.Cells["Calificación"].Value.ToString()=="0")
                    {
                        r.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        r.DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }


        }

        private void FormCursos_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();         
            dataGridView1.CurrentCell = null;
        }

        private void FormCursos_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.setCursosBool();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView1.DefaultCellStyle.SelectionBackColor = SelectedCellBackground;
            dataGridView1.DefaultCellStyle.SelectionForeColor = SelectedCellForeground;
            selectedCourse = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            labelTitle.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
          
            string sql = "select description from course where idcourse =" + selectedCourse +";";
            con.Open();
            labelDesc.Text = con.SelectSingle(sql);
            labelProfe.Text = "Prof. " + con.SelectSingle("select p.lastname from professor p inner join course c on c.idprofessor = p.idprofessor where c.idCourse=" + selectedCourse + ";");
            con.Close();

            FillHWDataGridView();

        }

        private void dataGridTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.ColumnIndex== 4 && e.RowIndex != -1)
            {
                //DataGridViewCell tmp = dataGridTareas.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridViewCheckBoxCell tmp = (DataGridViewCheckBoxCell) dataGridTareas.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (!Convert.ToBoolean(tmp.Value))
                {
                    DialogResult dr = MessageBox.Show("¿Desea entregar la siguiente tarea?:\n" + dataGridTareas.Rows[e.RowIndex].Cells[0].Value.ToString()
                        , "Confirmar Entrega", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        tmp.ReadOnly = true;
                        MessageBox.Show("Tarea entregada exitosamente.", "Tarea Enviada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //TODO:update db with hw turned in
                        string sql = "update assignment_student set completed = true where idStudent={0} and idAssignment={1};";
                        con.Open();
                        con.Command(String.Format(sql,idStudent,dataGridTareas.Rows[e.RowIndex].Cells["idAssignment"].Value.ToString()));
                        con.Close();



                    }
                    else
                    {
                        MessageBox.Show("Entrega cancelada.");
                    }
                    dataGridTareas.EndEdit();
                    FillHWDataGridView();
                }
            }

        }

        private void DataGridTareas_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
           /* if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                dataGridTareas.EndEdit();
            }*/

        }
    }
}
