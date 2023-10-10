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
            this.txtClave = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.btmIngresar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Acceso = new System.ComponentModel.BackgroundWorker();
            this.InicioDeSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // InicioDeSesion
            // 
            this.InicioDeSesion.BackColor = System.Drawing.Color.Transparent;
            this.InicioDeSesion.Controls.Add(this.label1);
            this.InicioDeSesion.Controls.Add(this.txtClave);
            this.InicioDeSesion.Controls.Add(this.Contraseña);
            this.InicioDeSesion.Controls.Add(this.Usuario);
            this.InicioDeSesion.Controls.Add(this.btmIngresar);
            this.InicioDeSesion.Controls.Add(this.txtUsuario);
            this.InicioDeSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioDeSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InicioDeSesion.Location = new System.Drawing.Point(47, 82);
            this.InicioDeSesion.Name = "InicioDeSesion";
            this.InicioDeSesion.Size = new System.Drawing.Size(660, 276);
            this.InicioDeSesion.TabIndex = 0;
            this.InicioDeSesion.TabStop = false;
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
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtClave.ForeColor = System.Drawing.SystemColors.Window;
            this.txtClave.Location = new System.Drawing.Point(363, 133);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(185, 22);
            this.txtClave.TabIndex = 4;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.BackColor = System.Drawing.Color.Black;
            this.Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(167, 121);
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
            this.Usuario.Location = new System.Drawing.Point(134, 79);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(146, 16);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "Nombre del Usuario";
            // 
            // btmIngresar
            // 
            this.btmIngresar.BackColor = System.Drawing.Color.Black;
            this.btmIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmIngresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btmIngresar.Location = new System.Drawing.Point(262, 201);
            this.btmIngresar.Name = "btmIngresar";
            this.btmIngresar.Size = new System.Drawing.Size(113, 38);
            this.btmIngresar.TabIndex = 1;
            this.btmIngresar.Text = "INGRESAR";
            this.btmIngresar.UseVisualStyleBackColor = false;
            this.btmIngresar.Click += new System.EventHandler(this.btmIngresar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.Location = new System.Drawing.Point(373, 76);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(185, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(949, 501);
            this.Controls.Add(this.InicioDeSesion);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btmIngresar;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}