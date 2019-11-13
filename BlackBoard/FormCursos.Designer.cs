namespace BlackBoard
{
    partial class FormCursos
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTareas = new System.Windows.Forms.TabPage();
            this.tabCalificaciones = new System.Windows.Forms.TabPage();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.tabForos = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(832, 454);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(193, 454);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStart);
            this.tabControl1.Controls.Add(this.tabTareas);
            this.tabControl1.Controls.Add(this.tabCalificaciones);
            this.tabControl1.Controls.Add(this.tabForos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTareas
            // 
            this.tabTareas.Location = new System.Drawing.Point(4, 22);
            this.tabTareas.Name = "tabTareas";
            this.tabTareas.Padding = new System.Windows.Forms.Padding(3);
            this.tabTareas.Size = new System.Drawing.Size(627, 428);
            this.tabTareas.TabIndex = 0;
            this.tabTareas.Text = "Tareas";
            this.tabTareas.UseVisualStyleBackColor = true;
            // 
            // tabCalificaciones
            // 
            this.tabCalificaciones.Location = new System.Drawing.Point(4, 22);
            this.tabCalificaciones.Name = "tabCalificaciones";
            this.tabCalificaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalificaciones.Size = new System.Drawing.Size(627, 428);
            this.tabCalificaciones.TabIndex = 1;
            this.tabCalificaciones.Text = "Calificaciones";
            this.tabCalificaciones.UseVisualStyleBackColor = true;
            // 
            // tabStart
            // 
            this.tabStart.Controls.Add(this.label1);
            this.tabStart.Location = new System.Drawing.Point(4, 22);
            this.tabStart.Name = "tabStart";
            this.tabStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabStart.Size = new System.Drawing.Size(627, 428);
            this.tabStart.TabIndex = 2;
            this.tabStart.Text = "Información General";
            this.tabStart.UseVisualStyleBackColor = true;
            // 
            // tabForos
            // 
            this.tabForos.Location = new System.Drawing.Point(4, 22);
            this.tabForos.Name = "tabForos";
            this.tabForos.Padding = new System.Windows.Forms.Padding(3);
            this.tabForos.Size = new System.Drawing.Size(627, 428);
            this.tabForos.TabIndex = 3;
            this.tabForos.Text = "Foros";
            this.tabForos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 454);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormCursos";
            this.Text = "FormCursos";
            this.Load += new System.EventHandler(this.FormCursos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabStart.ResumeLayout(false);
            this.tabStart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabTareas;
        private System.Windows.Forms.TabPage tabCalificaciones;
        private System.Windows.Forms.TabPage tabForos;
    }
}