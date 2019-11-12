namespace BlackBoard
{
    partial class UCForum
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bottonEnviar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.Mensajes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 531);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 144);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Entre su respuesta";
            // 
            // bottonEnviar
            // 
            this.bottonEnviar.Location = new System.Drawing.Point(372, 681);
            this.bottonEnviar.Name = "bottonEnviar";
            this.bottonEnviar.Size = new System.Drawing.Size(75, 23);
            this.bottonEnviar.TabIndex = 1;
            this.bottonEnviar.Text = "Enviar";
            this.bottonEnviar.UseVisualStyleBackColor = true;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(93, 10);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(35, 13);
            this.Titulo.TabIndex = 2;
            this.Titulo.Text = "Título";
            // 
            // Mensajes
            // 
            this.Mensajes.AutoSize = true;
            this.Mensajes.Location = new System.Drawing.Point(100, 40);
            this.Mensajes.Name = "Mensajes";
            this.Mensajes.Size = new System.Drawing.Size(28, 13);
            this.Mensajes.TabIndex = 3;
            this.Mensajes.Text = "Text";
            // 
            // UCForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Mensajes);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.bottonEnviar);
            this.Controls.Add(this.textBox1);
            this.Name = "UCForum";
            this.Size = new System.Drawing.Size(545, 708);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bottonEnviar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Mensajes;
    }
}
