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

        private void button2_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            txtBusqueda.Enabled = false;
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT  nombre, direccion FROM clientes WHERE nit = '" + txtBusqueda.Text  + "'"), Clase_ConeccionDB.obtenerConeccion());
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                txtNom.Text = reader.GetString(0);
                txtDir.Text = reader.GetString(1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((txtNom.Text != "") && (txtDir.Text != "") )
            {
                int resultado = 0;
                MySqlCommand comando = new MySqlCommand(string.Format("UPDATE clientes SET nombre ='" + txtNom.Text + "', direccion='" +
                    txtDir.Text + "' WHERE nit ='" + txtBusqueda.Text + "';"), Clase_ConeccionDB.obtenerConeccion ());
                resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("¡Bien Hecho! Los datos se han guardado con éxito.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBusqueda.Clear();
                    txtBusqueda.Enabled = true;
                    panel7.Visible = false;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((txtNit.Text != "") && (txtNombre.Text != "") && (txtDireccion.Text != ""))
            {
                int resultado = 0;
                MySqlCommand comando = new MySqlCommand(string.Format("call nuevoCliente('" + txtNit.Text + "','" + txtNombre.Text + "','" +
                    txtDireccion.Text + "')"), Clase_ConeccionDB.obtenerConeccion());
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
