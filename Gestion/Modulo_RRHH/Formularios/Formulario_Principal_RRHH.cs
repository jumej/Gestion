using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.Clases_Generales;

namespace Gestion.Modulo_RRHH.Formularios
{
    public partial class Formulario_Principal_RRHH : Form
    {
        public Formulario_Principal_RRHH()
        {
            InitializeComponent();
        }

        private void reclutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Formulario_Reclutar>().FirstOrDefault();
            Formulario_Reclutar moduloRRHH = form ?? new Formulario_Reclutar();
            Clase_FormDentroDePanel formInPanel = new Clase_FormDentroDePanel(moduloRRHH, panelContenedor);
            formInPanel.AgregarFormEnPanel();
        }

        private void contratolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Formulario_Contratar>().FirstOrDefault();
            Formulario_Contratar moduloRRHH = form ?? new Formulario_Contratar();
            Clase_FormDentroDePanel formInPanel = new Clase_FormDentroDePanel(moduloRRHH, panelContenedor);
            formInPanel.AgregarFormEnPanel();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Formulario_Empleados>().FirstOrDefault();
            Formulario_Empleados moduloRRHH = form ?? new Formulario_Empleados();
            Clase_FormDentroDePanel formInPanel = new Clase_FormDentroDePanel(moduloRRHH, panelContenedor);
            formInPanel.AgregarFormEnPanel();
        }
    }
}
