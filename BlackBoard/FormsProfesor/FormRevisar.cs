﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBoard.FormsProfesor
{
    public partial class FormRevisar : Form
    {
        string idAssignment;
        string AssignmentName;
        SQLiteConnector con;
        public FormRevisar(string idAssignment, string AssName)
        {
            InitializeComponent();
            this.idAssignment = idAssignment;
            AssignmentName = AssName;
            setTitle();
            con = new SQLiteConnector();
            fillDataGridTrabajos();
        }

        void fillDataGridTrabajos()
        {

            string sql = @"select ass.idStudent as Matricula, s.firstname as Nombre, s.lastname as Apellido, ass.completed as Entregado, ass.grade as Calificación
    from student s inner join assignment_student ass on s.idStudent=ass.idStudent
where idAssignment = " + idAssignment;
            con.Open();
            dataGridView1.DataSource = con.SelectTable(sql);
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        void setTitle()
        {

            this.Text = "BlackBoard |  " + AssignmentName;
        }

    }
}