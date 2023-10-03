namespace Administracion_Consola
{
    partial class frmAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceso));
            this.InicioDeSesion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.btmAceptar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Acceso = new System.ComponentModel.BackgroundWorker();
            this.InicioDeSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // InicioDeSesion
            // 
            this.InicioDeSesion.BackColor = System.Drawing.Color.Transparent;
            this.InicioDeSesion.Controls.Add(this.label1);
            this.InicioDeSesion.Controls.Add(this.textBox2);
            this.InicioDeSesion.Controls.Add(this.Contraseña);
            this.InicioDeSesion.Controls.Add(this.Usuario);
            this.InicioDeSesion.Controls.Add(this.btmAceptar);
            this.InicioDeSesion.Controls.Add(this.textBox1);
            this.InicioDeSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioDeSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InicioDeSesion.Location = new System.Drawing.Point(47, 82);
            this.InicioDeSesion.Name = "InicioDeSesion";
            this.InicioDeSesion.Size = new System.Drawing.Size(452, 220);
            this.InicioDeSesion.TabIndex = 0;
            this.InicioDeSesion.TabStop = false;
            this.InicioDeSesion.Text = "Inicio de sesiòn";
            this.InicioDeSesion.Enter += new System.EventHandler(this.InicioDeSesion_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inicio de Sesiòn";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(197, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 22);
            this.textBox2.TabIndex = 4;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.BackColor = System.Drawing.Color.Black;
            this.Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(48, 104);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(86, 16);
            this.Contraseña.TabIndex = 3;
            this.Contraseña.Text = "Contraseña";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.BackColor = System.Drawing.Color.Black;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.SystemColors.Control;
            this.Usuario.Location = new System.Drawing.Point(19, 63);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(146, 16);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "Nombre del Usuario";
            // 
            // btmAceptar
            // 
            this.btmAceptar.BackColor = System.Drawing.Color.Black;
            this.btmAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btmAceptar.Location = new System.Drawing.Point(170, 159);
            this.btmAceptar.Name = "btmAceptar";
            this.btmAceptar.Size = new System.Drawing.Size(113, 38);
            this.btmAceptar.TabIndex = 1;
            this.btmAceptar.Text = "INGRESAR";
            this.btmAceptar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(197, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 0;
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 393);
            this.Controls.Add(this.InicioDeSesion);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAcceso";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Contraseña";
            this.Load += new System.EventHandler(this.frmAcceso_Load);
            this.InicioDeSesion.ResumeLayout(false);
            this.InicioDeSesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InicioDeSesion;
        private System.ComponentModel.BackgroundWorker Acceso;
        private System.Windows.Forms.Button btmAceptar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}