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
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {

        }

        private void InicioDeSesion_Enter(object sender, EventArgs e)
        {
            
        }

        private void btmIngresar_Click(object sender, EventArgs e)
        {
            
            if (txtClave.Text == "123456")
            {
                this.DialogResult = DialogResult.OK;
                Hide();
            }
            else
            {
                this.DialogResult = DialogResult.No;
                Hide();
            }            
        }        
    }
}
