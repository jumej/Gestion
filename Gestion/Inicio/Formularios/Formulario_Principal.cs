using Gestion.Clases_Generales;
using Gestion.Finanzas.Formularios;
using Gestion.Modulo_Inventario.Formularios;
using Gestion.Ventas.Formulario;
using Gestion.Modulo_RRHH.Formularios;
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
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Formulario_Ventas>().FirstOrDefault();
            Formulario_Ventas moduloVentas = form ?? new Formulario_Ventas();
            moduloVentas.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            moduloVentas.MaximizeBox = true;
            moduloVentas.Dock = DockStyle.Fill;
            Clase_FormDentroDePanel formInPanel = new Clase_FormDentroDePanel(moduloVentas, panelContenedor);
            formInPanel.AgregarFormEnPanel();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Formulario_Clientes>().FirstOrDefault();
            Formulario_Clientes moduloClientes = form ?? new Formulario_Clientes();
            moduloClientes.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            moduloClientes.MaximizeBox = true;
            moduloClientes.Dock = DockStyle.Fill;
            Clase_FormDentroDePanel formInPanel = new Clase_FormDentroDePanel(moduloClientes, panelContenedor);
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

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_Inventario inventario = new Formulario_Inventario();
            inventario.Show();
            this.Close();
        }

        private void recursosHumanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Formulario_Principal_RRHH>().FirstOrDefault();
            Formulario_Principal_RRHH moduloRRHH = form ?? new Formulario_Principal_RRHH();
            moduloRRHH.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            moduloRRHH.MaximizeBox = true;
            moduloRRHH.Dock = DockStyle.Fill;
            Clase_FormDentroDePanel formInPanel = new Clase_FormDentroDePanel(moduloRRHH, panelContenedor);
            formInPanel.AgregarFormEnPanel();
        }
    }
}
