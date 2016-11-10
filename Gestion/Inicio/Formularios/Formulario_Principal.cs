using Gestion.Clases_Generales;
using Gestion.Finanzas.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Inicio.Formularios
{
    public partial class Formulario_Principal : Form
    {
        public Formulario_Principal()
        {
            InitializeComponent();
        }


        private void finanzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Formulario_Finanzas>().FirstOrDefault();
            Formulario_Finanzas moduloFinanzas = form ?? new Formulario_Finanzas();
            moduloFinanzas.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            moduloFinanzas.MaximizeBox = true;
            moduloFinanzas.Dock = DockStyle.Fill;
            Clase_FormDentroDePanel formInPanel = new Clase_FormDentroDePanel(moduloFinanzas, panelContenedor);
            formInPanel.AgregarFormEnPanel();
        }

        private void Formulario_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formulario_IniciarSesion inicio = Formulario_IniciarSesion.Obtener();
            inicio.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_IniciarSesion inicio = Formulario_IniciarSesion.Obtener();
            inicio.Show();
            this.Close();
        }
    }
}
