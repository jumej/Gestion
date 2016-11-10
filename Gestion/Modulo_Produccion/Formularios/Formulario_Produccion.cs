using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Modulo_Produccion.Formularios
{
    public partial class Formulario_Produccion : Form
    {

        //conexion a la base de datos
        private SqlConnection conexion;
        private SqlCommand cmd;
        private SqlDataReader consultar;
        public static String dat = "server = localhost; database = restaurante; Uid = root; pwd = 1234;";
        public static String nombre = "";

        public Formulario_Produccion()
        {
            InitializeComponent();
        }

        private SqlConnection ObtenerConexion()
        {

            conexion = new SqlConnection();
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

        //inserta un ingrediente a la base de datos
        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox6.Text.Trim() != "") & (textBox7.Text.Trim() != "") & (richTextBox1.Text != ""))
            {
                String nombre = textBox6.Text;
                String descripcion = richTextBox1.Text;
                Double cantidad = Convert.ToDouble(textBox7.Text);

                SqlCommand cmd = new SqlCommand(String.Format("INSERT into Ingredientes (nombre, cantidad, descripcion) values '{0}','{1}','{2}')", nombre, descripcion, cantidad), ObtenerConexion());

                conexion.Close();

                textBox6.Clear();
                textBox7.Clear();
                richTextBox1.Clear();


                actualizarIngredientes();
                MessageBox.Show("Ingrediente Creado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
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


        //Aceptar las modificaciones a las recetas
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Receta Modificada Exitosamente");

            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtTPrep.Text = "";
            txtAutor.Text = "";

            tabControl1.SelectedTab = tabVerRec;
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


        //crear recetas
        private void button6_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Receta Creada Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            actualizarRecetas();
        }
    }
}

