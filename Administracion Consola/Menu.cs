using Proyecto_1;
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
    public partial class Menu : Form
    {
        bool sidebarExpand;
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }          


        private void btmSetting_Click(object sender, EventArgs e)
        {
            
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }      

       

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btmMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 200)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 200;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btmSetting_Click_1(object sender, EventArgs e)
        {

        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirformHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btmAgregar_Click(object sender, EventArgs e)
        {
            AbrirformHija(new frmAgregarEmpleado());
        }

        private void btmBuscar_Click(object sender, EventArgs e)
        {
            AbrirformHija(new Buscar());
        }

        private void btmListar_Click(object sender, EventArgs e)
        {
            AbrirformHija(new Listar());
        }
    }
}
