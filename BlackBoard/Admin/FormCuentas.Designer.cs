namespace BlackBoard.Admin
{
    partial class FormCuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEstudiantes = new System.Windows.Forms.TabPage();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.tabProfesores = new System.Windows.Forms.TabPage();
            this.dataGridProfessors = new System.Windows.Forms.DataGridView();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabEstudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.tabProfesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfessors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEstudiantes);
            this.tabControl1.Controls.Add(this.tabProfesores);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 513);
            this.tabControl1.TabIndex = 1;
            // 
            // tabEstudiantes
            // 
            this.tabEstudiantes.Controls.Add(this.dataGridStudents);
            this.tabEstudiantes.Location = new System.Drawing.Point(4, 22);
            this.tabEstudiantes.Name = "tabEstudiantes";
            this.tabEstudiantes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstudiantes.Size = new System.Drawing.Size(939, 487);
            this.tabEstudiantes.TabIndex = 0;
            this.tabEstudiantes.Text = "Estudiantes";
            this.tabEstudiantes.UseVisualStyleBackColor = true;
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.AllowUserToAddRows = false;
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridStudents.Location = new System.Drawing.Point(3, 3);
            this.dataGridStudents.MultiSelect = false;
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStudents.Size = new System.Drawing.Size(933, 481);
            this.dataGridStudents.TabIndex = 0;
            this.dataGridStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellDoubleClick);
            // 
            // tabProfesores
            // 
            this.tabProfesores.Controls.Add(this.dataGridProfessors);
            this.tabProfesores.Location = new System.Drawing.Point(4, 22);
            this.tabProfesores.Name = "tabProfesores";
            this.tabProfesores.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfesores.Size = new System.Drawing.Size(939, 487);
            this.tabProfesores.TabIndex = 1;
            this.tabProfesores.Text = "Profesores";
            this.tabProfesores.UseVisualStyleBackColor = true;
            // 
            // dataGridProfessors
            // 
            this.dataGridProfessors.AllowUserToAddRows = false;
            this.dataGridProfessors.AllowUserToDeleteRows = false;
            this.dataGridProfessors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfessors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProfessors.Location = new System.Drawing.Point(3, 3);
            this.dataGridProfessors.Name = "dataGridProfessors";
            this.dataGridProfessors.ReadOnly = true;
            this.dataGridProfessors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProfessors.Size = new System.Drawing.Size(933, 481);
            this.dataGridProfessors.TabIndex = 0;
            this.dataGridProfessors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProfessors_CellDoubleClick);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(7, 12);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(154, 23);
            this.buttonCrear.TabIndex = 1;
            this.buttonCrear.Text = "Crear Cuenta";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCrear);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(947, 577);
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(781, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 577);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormCuentas";
            this.Text = "Cuentas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCuentas_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabEstudiantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.tabProfesores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfessors)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEstudiantes;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.TabPage tabProfesores;
        private System.Windows.Forms.DataGridView dataGridProfessors;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
    }
}