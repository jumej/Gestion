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


namespace Gestion.Modulo_Produccion.Formularios
{
    public partial class Formulario_Produccion : Form
    {

        //conexion a la base de datos
        private MySqlConnection conexion;
        private MySqlCommand cmd;
        private MySqlDataReader consultar;
        public static String dat = "server = localhost; database = gestiondb; Uid = root; pwd = 1234;";
        

        public Formulario_Produccion()
        {
            InitializeComponent();
        }

        private MySqlConnection ObtenerConexion()
        {

            conexion = new MySqlConnection();
            conexion.ConnectionString = dat;
            conexion.Open();
            return conexion;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarIngredientes();
            actualizarRecetas();


        }

        //agregar todos los ingredientes al dgv en agregar receta
        public void actualizarIngredientes()
        {
            ObtenerConexion();
            cmd.CommandText = "select nombre, cantidad, descripcion from Ingredientes";
            cmd.Connection = conexion;
            consultar = cmd.ExecuteReader();

            while (consultar.Read())
            {
                dataGridView2.Rows.Add(1);
                String nombre = consultar.GetString(0);
                dataGridView2[0, dataGridView2.RowCount - 1].Value = nombre;

                String cantidad = consultar.GetInt32(1).ToString();
                dataGridView2[1, dataGridView2.RowCount - 1].Value = cantidad;

                String desc = consultar.GetString(2);
                dataGridView2[2, dataGridView2.RowCount - 1].Value = desc;
            }

            conexion.Close();

        }

        //muestra en el dgv1 todas las recetas creadas 
        public void actualizarRecetas()
        {

            ObtenerConexion();
            cmd.CommandText = "Select nombre, precio, tiempo_preparacion, autor from Receta";
            cmd.Connection = conexion;
            consultar = cmd.ExecuteReader();


            while (consultar.Read())
            {
                dataGridView1.Rows.Add(1);
                String nombre = consultar.GetInt32(0).ToString();
                dataGridView1[0, dataGridView1.RowCount - 1].Value = nombre;

                String precio = consultar.GetDouble(1).ToString();
                dataGridView1[1, dataGridView1.RowCount - 1].Value = precio;

                String tprepa = consultar.GetString(2);
                dataGridView1[2, dataGridView1.RowCount - 1].Value = tprepa;

                String autor = consultar.GetString(3);
                dataGridView1[3, dataGridView1.RowCount - 1].Value = autor;

                dataGridView1[4, dataGridView1.RowCount - 1].Value = "Modificar";
                dataGridView1[5, dataGridView1.RowCount - 1].Value = "Eliminar";

            }

            conexion.Close();



        }


        //private void mostrarReceta()
        //{

        //    DataSet ds = new DataSet();
        //    cmd = new SqlCommand("Select nombre, precio, tiempo_preparacion, autor from Receta", ObtenerConexion());
        //    SqlDataAdapter recetas = new SqlDataAdapter(cmd);
        //    recetas.Fill(ds);
        //    dataGridView1.DataSource = ds.Tables[1];

        //}

        
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        //Clic al boton del dgv para Modificar Recetas
        private void ClickBoton(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                var row = dataGridView1.CurrentRow;

                tabControl1.SelectedTab = tabModRec;
                var nombre = tabModRec.Controls["txtNombre"];
                var precio = tabModRec.Controls["txtPrecio"];
                var tiempo = tabModRec.Controls["txtTPrep"];
                var autor = tabModRec.Controls["txtAutor"];

                nombre.Text = row.Cells[0].Value.ToString();
                precio.Text = row.Cells[1].Value.ToString();
                tiempo.Text = row.Cells[2].Value.ToString();
                autor.Text = row.Cells[3].Value.ToString();


            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        //boton Cancelar 
        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtTPrep.Text = "";
            txtAutor.Text = "";

            tabControl1.SelectedTab = tabVerRec;
        }


        
        private void button6_Click(object sender, EventArgs e)
        {

            
        }
        //crear recetas
        private void button6_Click_1(object sender, EventArgs e)
        {
            if ((textBox1.Text.Trim() != "") & (textBox2.Text.Trim() != "") & (textBox3.Text.Trim() != "") & (textBox4.Text.Trim() != ""))
            {
                String nombre = textBox1.Text;
                Double precio = Convert.ToDouble(textBox2.Text);
                String autor = textBox3.Text;
                String tPrep = textBox4.Text;

                MySqlCommand cmd = new MySqlCommand(String.Format("INSERT into Recetas (nombre, precio, tiempo_preparacion,autor) values '{0}','{1}','{2}','{3}')",nombre, precio, tPrep,autor),ObtenerConexion());

                conexion.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                actualizarRecetas();
                MessageBox.Show("Receta Creada Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        //inserta un ingrediente a la base de datos
        private void button4_Click_1(object sender, EventArgs e)
        {
            if ((textBox6.Text.Trim() != "") & (textBox7.Text.Trim() != "") & (richTextBox1.Text != ""))
            {
                String nombre = textBox6.Text;
                String descripcion = richTextBox1.Text;
                Double cantidad = Convert.ToDouble(textBox7.Text);

                MySqlCommand cmd = new MySqlCommand(String.Format("INSERT into Ingredientes (nombre, cantidad, descripcion) values '{0}','{1}','{2}')", nombre, descripcion, cantidad), ObtenerConexion());

                conexion.Close();

                textBox6.Clear();
                textBox7.Clear();
                richTextBox1.Clear();


                actualizarIngredientes();
                MessageBox.Show("Ingrediente Creado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        //Aceptar las modificaciones a las recetas
        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Receta Modificada Exitosamente");

            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtTPrep.Text = "";
            txtAutor.Text = "";

            tabControl1.SelectedTab = tabVerRec;
        }
    }
}

