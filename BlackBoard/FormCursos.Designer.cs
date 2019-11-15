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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.labelProfe = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabTareas = new System.Windows.Forms.TabPage();
            this.dataGridTareas = new System.Windows.Forms.DataGridView();
            this.tabCalificaciones = new System.Windows.Forms.TabPage();
            this.tabForos = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabStart.SuspendLayout();
            this.tabTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTareas)).BeginInit();
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
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(206, 454);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.tabControl1.Size = new System.Drawing.Size(622, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tabStart
            // 
            this.tabStart.Controls.Add(this.labelProfe);
            this.tabStart.Controls.Add(this.labelDesc);
            this.tabStart.Controls.Add(this.labelTitle);
            this.tabStart.Location = new System.Drawing.Point(4, 22);
            this.tabStart.Name = "tabStart";
            this.tabStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabStart.Size = new System.Drawing.Size(614, 428);
            this.tabStart.TabIndex = 2;
            this.tabStart.Text = "Información General";
            this.tabStart.UseVisualStyleBackColor = true;
            // 
            // labelProfe
            // 
            this.labelProfe.AutoSize = true;
            this.labelProfe.Location = new System.Drawing.Point(44, 72);
            this.labelProfe.Name = "labelProfe";
            this.labelProfe.Size = new System.Drawing.Size(10, 13);
            this.labelProfe.TabIndex = 2;
            this.labelProfe.Text = " ";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.Location = new System.Drawing.Point(43, 114);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(305, 20);
            this.labelDesc.TabIndex = 1;
            this.labelDesc.Text = " Información del curso será mostrada aquí";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(40, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(355, 39);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Seleccione un Curso";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // tabTareas
            // 
            this.tabTareas.Controls.Add(this.dataGridTareas);
            this.tabTareas.Location = new System.Drawing.Point(4, 22);
            this.tabTareas.Name = "tabTareas";
            this.tabTareas.Padding = new System.Windows.Forms.Padding(3);
            this.tabTareas.Size = new System.Drawing.Size(614, 428);
            this.tabTareas.TabIndex = 0;
            this.tabTareas.Text = "Tareas";
            this.tabTareas.UseVisualStyleBackColor = true;
            // 
            // dataGridTareas
            // 
            this.dataGridTareas.AllowUserToAddRows = false;
            this.dataGridTareas.AllowUserToDeleteRows = false;
            this.dataGridTareas.AllowUserToResizeColumns = false;
            this.dataGridTareas.AllowUserToResizeRows = false;
            this.dataGridTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridTareas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridTareas.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridTareas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridTareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTareas.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTareas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTareas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridTareas.Location = new System.Drawing.Point(3, 3);
            this.dataGridTareas.Name = "dataGridTareas";
            this.dataGridTareas.ReadOnly = true;
            this.dataGridTareas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridTareas.RowHeadersVisible = false;
            this.dataGridTareas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTareas.Size = new System.Drawing.Size(608, 422);
            this.dataGridTareas.TabIndex = 2;
            // 
            // tabCalificaciones
            // 
            this.tabCalificaciones.Location = new System.Drawing.Point(4, 22);
            this.tabCalificaciones.Name = "tabCalificaciones";
            this.tabCalificaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalificaciones.Size = new System.Drawing.Size(614, 428);
            this.tabCalificaciones.TabIndex = 1;
            this.tabCalificaciones.Text = "Calificaciones";
            this.tabCalificaciones.UseVisualStyleBackColor = true;
            // 
            // tabForos
            // 
            this.tabForos.Location = new System.Drawing.Point(4, 22);
            this.tabForos.Name = "tabForos";
            this.tabForos.Padding = new System.Windows.Forms.Padding(3);
            this.tabForos.Size = new System.Drawing.Size(614, 428);
            this.tabForos.TabIndex = 3;
            this.tabForos.Text = "Foros";
            this.tabForos.UseVisualStyleBackColor = true;
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 454);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormCursos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCursos_FormClosed);
            this.Load += new System.EventHandler(this.FormCursos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabStart.ResumeLayout(false);
            this.tabStart.PerformLayout();
            this.tabTareas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabPage tabTareas;
        private System.Windows.Forms.TabPage tabCalificaciones;
        private System.Windows.Forms.TabPage tabForos;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelProfe;
        private System.Windows.Forms.DataGridView dataGridTareas;
    }
}