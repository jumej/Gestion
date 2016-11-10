using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Modulo_Finanzas.Formularios
{
    public partial class Formulario_ActivoFijo : Form
    {
        public Formulario_ActivoFijo()
        {
            InitializeComponent();
        }

        private void Formulario_ActivoFijo_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarActivo_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("VEHICULOS")) {   txtDepreciacion.Text = "25%";   txtTiempoDepreciacion.Text = "4 años";  }
            if (comboBox1.SelectedItem.Equals("EDIFICIOS")) {   txtDepreciacion.Text = "5%";    txtTiempoDepreciacion.Text = "20 años"; }
            if (comboBox1.SelectedItem.Equals("MOBILIARIO Y EQUIPO")) { txtDepreciacion.Text = "10%"; txtTiempoDepreciacion.Text = "10 años"; }
            if (comboBox1.SelectedItem.Equals("EQUIPO DE COMPUTO")) { txtDepreciacion.Text = "33.33%"; txtTiempoDepreciacion.Text = "3 años"; }
            if (comboBox1.SelectedItem.Equals("CRISTALERIA Y MANTELERIA")) { txtDepreciacion.Text = "25%"; txtTiempoDepreciacion.Text = "4 años"; }


        }
    }
}
