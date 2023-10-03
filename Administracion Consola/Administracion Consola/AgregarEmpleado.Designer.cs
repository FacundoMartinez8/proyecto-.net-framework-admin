namespace Administracion_Consola
{
    partial class frmAgregarEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelPuesto = new System.Windows.Forms.Label();
            this.labelAntiguedad = new System.Windows.Forms.Label();
            this.labelSueldo = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btmCancelarIngreso = new System.Windows.Forms.Button();
            this.btmIngresarDatos = new System.Windows.Forms.Button();
            this.cmbBoxGenero = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.listBoxEmpleados = new System.Windows.Forms.ListBox();
            this.btmEliminarEmpleado = new System.Windows.Forms.Button();
            this.btmSalirSinGuardar = new System.Windows.Forms.Button();
            this.btmGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar nuevo empleado";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(27, 32);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(66, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            this.labelNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.BackColor = System.Drawing.Color.Transparent;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.Color.White;
            this.labelApellido.Location = new System.Drawing.Point(231, 37);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(69, 16);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.ForeColor = System.Drawing.Color.White;
            this.labelDni.Location = new System.Drawing.Point(481, 32);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(34, 16);
            this.labelDni.TabIndex = 3;
            this.labelDni.Text = "Dni:";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.ForeColor = System.Drawing.Color.White;
            this.labelEdad.Location = new System.Drawing.Point(690, 33);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(48, 16);
            this.labelEdad.TabIndex = 4;
            this.labelEdad.Text = "Edad:";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.ForeColor = System.Drawing.Color.White;
            this.labelGenero.Location = new System.Drawing.Point(27, 81);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(62, 16);
            this.labelGenero.TabIndex = 5;
            this.labelGenero.Text = "Genero:";
            // 
            // labelPuesto
            // 
            this.labelPuesto.AutoSize = true;
            this.labelPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuesto.ForeColor = System.Drawing.Color.White;
            this.labelPuesto.Location = new System.Drawing.Point(241, 85);
            this.labelPuesto.Name = "labelPuesto";
            this.labelPuesto.Size = new System.Drawing.Size(59, 16);
            this.labelPuesto.TabIndex = 6;
            this.labelPuesto.Text = "Puesto:";
            // 
            // labelAntiguedad
            // 
            this.labelAntiguedad.AutoSize = true;
            this.labelAntiguedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAntiguedad.ForeColor = System.Drawing.Color.White;
            this.labelAntiguedad.Location = new System.Drawing.Point(465, 89);
            this.labelAntiguedad.Name = "labelAntiguedad";
            this.labelAntiguedad.Size = new System.Drawing.Size(90, 16);
            this.labelAntiguedad.TabIndex = 7;
            this.labelAntiguedad.Text = "Antiguedad:";
            // 
            // labelSueldo
            // 
            this.labelSueldo.AutoSize = true;
            this.labelSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSueldo.ForeColor = System.Drawing.Color.White;
            this.labelSueldo.Location = new System.Drawing.Point(707, 89);
            this.labelSueldo.Name = "labelSueldo";
            this.labelSueldo.Size = new System.Drawing.Size(60, 16);
            this.labelSueldo.TabIndex = 8;
            this.labelSueldo.Text = "Sueldo:";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.Gray;
            this.txtApellido.Location = new System.Drawing.Point(320, 32);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.Gray;
            this.txtDni.Location = new System.Drawing.Point(533, 33);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btmCancelarIngreso);
            this.groupBox1.Controls.Add(this.btmIngresarDatos);
            this.groupBox1.Controls.Add(this.cmbBoxGenero);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtSueldo);
            this.groupBox1.Controls.Add(this.txtAntiguedad);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.txtPuesto);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.labelSueldo);
            this.groupBox1.Controls.Add(this.labelAntiguedad);
            this.groupBox1.Controls.Add(this.labelPuesto);
            this.groupBox1.Controls.Add(this.labelGenero);
            this.groupBox1.Controls.Add(this.labelEdad);
            this.groupBox1.Controls.Add(this.labelDni);
            this.groupBox1.Controls.Add(this.labelApellido);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 195);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btmCancelarIngreso
            // 
            this.btmCancelarIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btmCancelarIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCancelarIngreso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btmCancelarIngreso.Location = new System.Drawing.Point(484, 141);
            this.btmCancelarIngreso.Name = "btmCancelarIngreso";
            this.btmCancelarIngreso.Size = new System.Drawing.Size(165, 35);
            this.btmCancelarIngreso.TabIndex = 17;
            this.btmCancelarIngreso.Text = "CANCELAR INGRESO";
            this.btmCancelarIngreso.UseVisualStyleBackColor = false;
            // 
            // btmIngresarDatos
            // 
            this.btmIngresarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btmIngresarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmIngresarDatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btmIngresarDatos.Location = new System.Drawing.Point(297, 141);
            this.btmIngresarDatos.Name = "btmIngresarDatos";
            this.btmIngresarDatos.Size = new System.Drawing.Size(139, 35);
            this.btmIngresarDatos.TabIndex = 16;
            this.btmIngresarDatos.Text = "INGRESAR DATOS";
            this.btmIngresarDatos.UseVisualStyleBackColor = false;
            // 
            // cmbBoxGenero
            // 
            this.cmbBoxGenero.BackColor = System.Drawing.Color.Gray;
            this.cmbBoxGenero.FormattingEnabled = true;
            this.cmbBoxGenero.Location = new System.Drawing.Point(99, 80);
            this.cmbBoxGenero.Name = "cmbBoxGenero";
            this.cmbBoxGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxGenero.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(99, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // txtSueldo
            // 
            this.txtSueldo.BackColor = System.Drawing.Color.Gray;
            this.txtSueldo.Location = new System.Drawing.Point(786, 89);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 14;
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.BackColor = System.Drawing.Color.Gray;
            this.txtAntiguedad.Location = new System.Drawing.Point(570, 88);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(100, 20);
            this.txtAntiguedad.TabIndex = 13;
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.Gray;
            this.txtEdad.Location = new System.Drawing.Point(755, 33);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 12;
            // 
            // txtPuesto
            // 
            this.txtPuesto.BackColor = System.Drawing.Color.Gray;
            this.txtPuesto.Location = new System.Drawing.Point(320, 85);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(100, 20);
            this.txtPuesto.TabIndex = 11;
            // 
            // listBoxEmpleados
            // 
            this.listBoxEmpleados.BackColor = System.Drawing.Color.Teal;
            this.listBoxEmpleados.FormattingEnabled = true;
            this.listBoxEmpleados.Location = new System.Drawing.Point(13, 226);
            this.listBoxEmpleados.Name = "listBoxEmpleados";
            this.listBoxEmpleados.Size = new System.Drawing.Size(639, 251);
            this.listBoxEmpleados.TabIndex = 12;
            // 
            // btmEliminarEmpleado
            // 
            this.btmEliminarEmpleado.BackColor = System.Drawing.Color.Gray;
            this.btmEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEliminarEmpleado.ForeColor = System.Drawing.SystemColors.Info;
            this.btmEliminarEmpleado.Location = new System.Drawing.Point(696, 241);
            this.btmEliminarEmpleado.Name = "btmEliminarEmpleado";
            this.btmEliminarEmpleado.Size = new System.Drawing.Size(181, 57);
            this.btmEliminarEmpleado.TabIndex = 13;
            this.btmEliminarEmpleado.Text = "Eliminar Empleado";
            this.btmEliminarEmpleado.UseVisualStyleBackColor = false;
            // 
            // btmSalirSinGuardar
            // 
            this.btmSalirSinGuardar.BackColor = System.Drawing.Color.Gray;
            this.btmSalirSinGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSalirSinGuardar.ForeColor = System.Drawing.SystemColors.Info;
            this.btmSalirSinGuardar.Location = new System.Drawing.Point(696, 315);
            this.btmSalirSinGuardar.Name = "btmSalirSinGuardar";
            this.btmSalirSinGuardar.Size = new System.Drawing.Size(181, 56);
            this.btmSalirSinGuardar.TabIndex = 14;
            this.btmSalirSinGuardar.Text = "Salir Sin Guardar";
            this.btmSalirSinGuardar.UseVisualStyleBackColor = false;
            // 
            // btmGuardar
            // 
            this.btmGuardar.BackColor = System.Drawing.Color.Gray;
            this.btmGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmGuardar.ForeColor = System.Drawing.SystemColors.Info;
            this.btmGuardar.Location = new System.Drawing.Point(696, 388);
            this.btmGuardar.Name = "btmGuardar";
            this.btmGuardar.Size = new System.Drawing.Size(181, 54);
            this.btmGuardar.TabIndex = 15;
            this.btmGuardar.Text = "Guardar El Archivo";
            this.btmGuardar.UseVisualStyleBackColor = false;
            // 
            // frmAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(928, 483);
            this.Controls.Add(this.btmGuardar);
            this.Controls.Add(this.btmSalirSinGuardar);
            this.Controls.Add(this.btmEliminarEmpleado);
            this.Controls.Add(this.listBoxEmpleados);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarEmpleado";
            this.Text = "AgregarEmpleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelPuesto;
        private System.Windows.Forms.Label labelAntiguedad;
        private System.Windows.Forms.Label labelSueldo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBoxGenero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Button btmCancelarIngreso;
        private System.Windows.Forms.Button btmIngresarDatos;
        private System.Windows.Forms.ListBox listBoxEmpleados;
        private System.Windows.Forms.Button btmEliminarEmpleado;
        private System.Windows.Forms.Button btmSalirSinGuardar;
        private System.Windows.Forms.Button btmGuardar;
    }
}