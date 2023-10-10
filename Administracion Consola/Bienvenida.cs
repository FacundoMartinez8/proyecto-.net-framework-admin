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
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }        

        private void Bienvenida_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Bienvenida bienvenida = new Bienvenida();
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2;

                label2.Text = progressBar1.Value.ToString() + "%";
                
            }
            else
            {
                timer1.Stop();
                bienvenida.Close();   
                
                menu.Show();
                
            }                   
        }
    }
}
