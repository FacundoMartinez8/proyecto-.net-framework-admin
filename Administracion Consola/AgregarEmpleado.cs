using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_Consola
{
    public partial class frmAgregarEmpleado : Form
    {
        public frmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmIngresarDatos_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            int edad, antiguedad, sueldo;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios (Nombre, Apellido, DNI).");
                return;
            }

            if (!int.TryParse(txtEdad.Text, out edad) || edad <= 0)
            {
                MessageBox.Show("Por favor, ingresa una edad válida.");
                return;
            }

            string genero = cmbBoxGenero.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(genero))
            {
                MessageBox.Show("Por favor, selecciona un género.");
                return;
            }

            if (!int.TryParse(txtAntiguedad.Text, out antiguedad) || antiguedad < 0)
            {
                MessageBox.Show("Por favor, ingresa una antigüedad válida.");
                return;
            }

            if (!int.TryParse(txtSueldo.Text, out sueldo) || sueldo < 0)
            {
                MessageBox.Show("Por favor, ingresa un sueldo válido.");
                return;
            }

            string puesto = txtPuesto.Text;
            string recursoHumanos = textRH.Text;
            string empleador = txtPuesto.Text;

            Administracion nuevoEmpleado = new Administracion(nombre, apellido, dni, edad, genero, puesto, antiguedad, sueldo, recursoHumanos, empleador);

            nuevoEmpleado.Agregar();

            LimpiarCampos();


            MessageBox.Show("Empleado agregado correctamente al archivo");
        }

        private void btmEliminarEmpleado_Click(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtEdad.Text = "";
            cmbBoxGenero.SelectedIndex = -1;
            txtPuesto.Text = "";
            txtAntiguedad.Text = "";
            txtSueldo.Text = "";
            txtRH.Text = "";
            txtEmpleador.Text = "";
        }
    }
}
