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


        private void activoFijoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Formulario_ActivoFijo>().FirstOrDefault();
            Formulario_ActivoFijo moduloFinanzas = form ?? new Formulario_ActivoFijo();
            moduloFinanzas.StartPosition = FormStartPosition.CenterParent;
            //moduloFinanzas.FormBorderStyle = FormBorderStyle.None;
            //moduloFinanzas.MaximizeBox = true;
            //moduloFinanzas.Dock = DockStyle.Fill;
            Clase_FormDentroDePanel formInPanel = new Clase_FormDentroDePanel(moduloFinanzas, panelContenedor);
            formInPanel.AgregarFormEnPanel();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Formulario_Balance>().FirstOrDefault();
            Formulario_Balance moduloFinanzas = form ?? new Formulario_Balance();
            Clase_FormDentroDePanel formInPanel = new Clase_FormDentroDePanel(moduloFinanzas, panelContenedor);
            formInPanel.AgregarFormEnPanel();
        }

        private void diarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Formulario_Diario>().FirstOrDefault();
            Formulario_Diario moduloFinanzas = form ?? new Formulario_Diario();
            Clase_FormDentroDePanel formInPanel = new Clase_FormDentroDePanel(moduloFinanzas, panelContenedor);
            formInPanel.AgregarFormEnPanel();
        }

        private void mayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Formulario_Mayor>().FirstOrDefault();
            Formulario_Mayor moduloFinanzas = form ?? new Formulario_Mayor();
            Clase_FormDentroDePanel formInPanel = new Clase_FormDentroDePanel(moduloFinanzas, panelContenedor);
            formInPanel.AgregarFormEnPanel();
        }

        private void transaccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Formulario_Transaccion>().FirstOrDefault();
            Formulario_Transaccion moduloFinanzas = form ?? new Formulario_Transaccion();
            Clase_FormDentroDePanel formInPanel = new Clase_FormDentroDePanel(moduloFinanzas, panelContenedor);
            formInPanel.AgregarFormEnPanel();
        }
    }
}
