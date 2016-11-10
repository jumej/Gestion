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
using MySql.Data.MySqlClient;

namespace Gestion.Modulo_RRHH.Formularios
{
    public partial class Formulario_Reclutar : Form
    {
        public Formulario_Reclutar()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = Clase_ConeccionDB.obtenerConeccion();
            MySqlCommand cmd = conexion.CreateCommand();
            String nombre = inputFirstname.Text;
            String apellido = inputLastname.Text;
            int telefono = Convert.ToInt32(inputPhone.Text);
            String email = inputEmail.Text;
            String direccion = inputAddress.Text;
            cmd.CommandText = ("INSERT INTO curriculum (Nombre, Apellido, Telefono, Correo_Electronico, Direccion) VALUES('" + nombre + "','" + apellido + "','" + telefono + "','" + email + "','" + direccion + "')");
            cmd.ExecuteNonQuery();
            inputFirstname.Text = "";
            inputLastname.Text = "";
            inputPhone.Text = "";
            inputAddress.Text = "";
            inputEmail.Text = "";
            MessageBox.Show("Persona ingresada correctamente");
        }
    }
}
