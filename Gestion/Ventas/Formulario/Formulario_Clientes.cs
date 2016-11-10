using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Gestion.Clases_Generales;

namespace Gestion.Ventas.Formulario
{
    public partial class Formulario_Clientes : Form
    {
        public Formulario_Clientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((txtNit.Text != "") && (txtNombre.Text != "") && (txtDireccion.Text != ""))
            {
                int resultado = 0;
                MySqlCommand comando = new MySqlCommand(string.Format("call nuevoCliente('" + txtNit.Text + "','" + txtNombre.Text + "','" +
                    txtDireccion.Text  + "')"), Clase_ConeccionDB.obtenerConeccion());
                resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("¡Bien Hecho! Los datos se han guardado con éxito.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNit.Clear();
                    txtNombre.Clear();
                    txtDireccion.Clear();
                    txtNit.Focus();
                }
                else
                {
                    MessageBox.Show("¡Cuidado! A ocurrido un error al ingresar los datos.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("¡Cuidado! No pueden permanecer campos Vacios.", "",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
