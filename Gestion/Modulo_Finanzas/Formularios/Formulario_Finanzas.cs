using Gestion.Clases_Generales;
using Gestion.Modulo_Finanzas.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Finanzas.Formularios
{
    public partial class Formulario_Finanzas : Form
    {
        public Formulario_Finanzas()
        {
            InitializeComponent();
        }


        private void tableroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Formulario_Tablero>().FirstOrDefault();
            Formulario_Tablero moduloFinanzas = form ?? new Formulario_Tablero();
            moduloFinanzas.FormBorderStyle = FormBorderStyle.None;
            moduloFinanzas.MaximizeBox = true;
            moduloFinanzas.Dock = DockStyle.Fill;
            Clase_FormDentroDePanel formInPanel = new Clase_FormDentroDePanel(moduloFinanzas, panelContenedor);
            formInPanel.AgregarFormEnPanel();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Formulario_ListaVentas>().FirstOrDefault();
            Formulario_ListaVentas moduloFinanzas = form ?? new Formulario_ListaVentas();
            moduloFinanzas.FormBorderStyle = FormBorderStyle.None;
            moduloFinanzas.MaximizeBox = true;
            moduloFinanzas.Dock = DockStyle.Fill;
            Clase_FormDentroDePanel formInPanel = new Clase_FormDentroDePanel(moduloFinanzas, panelContenedor);
            formInPanel.AgregarFormEnPanel();
        }
    }
}
