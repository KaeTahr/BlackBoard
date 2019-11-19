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
            this.tabProfesores = new System.Windows.Forms.TabPage();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.dataGridProfessors = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabEstudiantes.SuspendLayout();
            this.tabProfesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfessors)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabEstudiantes
            // 
            this.tabEstudiantes.Controls.Add(this.dataGridStudents);
            this.tabEstudiantes.Location = new System.Drawing.Point(4, 22);
            this.tabEstudiantes.Name = "tabEstudiantes";
            this.tabEstudiantes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstudiantes.Size = new System.Drawing.Size(792, 424);
            this.tabEstudiantes.TabIndex = 0;
            this.tabEstudiantes.Text = "Estudiantes";
            this.tabEstudiantes.UseVisualStyleBackColor = true;
            // 
            // tabProfesores
            // 
            this.tabProfesores.Controls.Add(this.dataGridProfessors);
            this.tabProfesores.Location = new System.Drawing.Point(4, 22);
            this.tabProfesores.Name = "tabProfesores";
            this.tabProfesores.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfesores.Size = new System.Drawing.Size(792, 424);
            this.tabProfesores.TabIndex = 1;
            this.tabProfesores.Text = "Profesores";
            this.tabProfesores.UseVisualStyleBackColor = true;
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.AllowUserToAddRows = false;
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridStudents.Location = new System.Drawing.Point(3, 3);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.ReadOnly = true;
            this.dataGridStudents.Size = new System.Drawing.Size(786, 418);
            this.dataGridStudents.TabIndex = 0;
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
            this.dataGridProfessors.Size = new System.Drawing.Size(786, 418);
            this.dataGridProfessors.TabIndex = 0;
            // 
            // FormCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormCuentas";
            this.Text = "Cuentas";
            this.tabControl1.ResumeLayout(false);
            this.tabEstudiantes.ResumeLayout(false);
            this.tabProfesores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfessors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEstudiantes;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.TabPage tabProfesores;
        private System.Windows.Forms.DataGridView dataGridProfessors;
    }
}