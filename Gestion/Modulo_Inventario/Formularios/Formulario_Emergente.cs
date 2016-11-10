using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Modulo_Inventario.Formularios
{
    public partial class Formulario_Emergente : Form
    {
        public Formulario_Emergente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Hay campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Formulario_Inventario.nombre = txtNombre.Text;
                this.Dispose();
            }
        }
    }
}
