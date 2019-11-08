namespace BlackBoard
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.administraciToolStripMenuItem,
            this.perfilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1162, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosToolStripMenuItem,
            this.calificacionesToolStripMenuItem,
            this.profesoresToolStripMenuItem1,
            this.tareasToolStripMenuItem});
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosToolStripMenuItem1});
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // administraciToolStripMenuItem
            // 
            this.administraciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarCursosToolStripMenuItem,
            this.modificarUsuariosToolStripMenuItem});
            this.administraciToolStripMenuItem.Name = "administraciToolStripMenuItem";
            this.administraciToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.administraciToolStripMenuItem.Text = "Administración";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // calificacionesToolStripMenuItem
            // 
            this.calificacionesToolStripMenuItem.Name = "calificacionesToolStripMenuItem";
            this.calificacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calificacionesToolStripMenuItem.Text = "Calificaciones";
            // 
            // profesoresToolStripMenuItem1
            // 
            this.profesoresToolStripMenuItem1.Name = "profesoresToolStripMenuItem1";
            this.profesoresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.profesoresToolStripMenuItem1.Text = "Profesores";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // cursosToolStripMenuItem1
            // 
            this.cursosToolStripMenuItem1.Name = "cursosToolStripMenuItem1";
            this.cursosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cursosToolStripMenuItem1.Text = "Cursos";
            // 
            // modificarCursosToolStripMenuItem
            // 
            this.modificarCursosToolStripMenuItem.Name = "modificarCursosToolStripMenuItem";
            this.modificarCursosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarCursosToolStripMenuItem.Text = "Modificar Cursos";
            // 
            // modificarUsuariosToolStripMenuItem
            // 
            this.modificarUsuariosToolStripMenuItem.Name = "modificarUsuariosToolStripMenuItem";
            this.modificarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarUsuariosToolStripMenuItem.Text = "Modificar Usuarios";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 573);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "BlackBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administraciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuariosToolStripMenuItem;
    }
}