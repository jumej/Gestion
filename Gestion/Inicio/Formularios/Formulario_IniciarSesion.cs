using Gestion.Clases_Generales;
using MySql.Data.MySqlClient;
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
    public partial class Formulario_IniciarSesion : Form
    {
        private static Formulario_IniciarSesion instance = null;
        private Formulario_IniciarSesion()
        {
            InitializeComponent();
        }

        public static Formulario_IniciarSesion Obtener()
        {
            if (instance == null)
                instance = new Formulario_IniciarSesion();
            return instance;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Clase_ConeccionDB.obtenerConeccion();
            try
            {
                cmd.CommandText = "select count(*) from usuario where nombre ='" + txtUsuario.Text + "'and pass = '" + txtPass.Text + "'and administrador ='1';";
                int valor = int.Parse(cmd.ExecuteScalar().ToString());
                if (valor == 1)
                {  
                        Formulario_Principal f = new Formulario_Principal();
                        f.Show();
                        f.finanzasToolStripMenuItem.Enabled = true;
                        this.Hide();   
                }

                cmd.CommandText = "select count(*) from usuario where nombre ='" + txtUsuario.Text + "'and pass = '" + txtPass.Text + "'and administrador ='0';";
                valor = int.Parse(cmd.ExecuteScalar().ToString());
                if (valor == 1)
                {
                    MessageBox.Show("Ud No es administrador pero puede acceder");   
                }
                cmd.CommandText = "select count(*) from usuario where nombre ='" + txtUsuario.Text + "'and pass = '" + txtPass.Text + "';";
                valor = int.Parse(cmd.ExecuteScalar().ToString());
                if (valor == 0)
                {
                    MessageBox.Show("NO puede acceder");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error en " + ex); }
            Clase_ConeccionDB.obtenerConeccion().Close();
        }
    }
}
