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

namespace Gestion.Modulo_Inventario.Formularios
{
    public partial class Formulario_Inventario : Form
    {
        private MySqlConnection conexion;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        public static string dat = "server=localhost; database=gestionDB; Uid=root; pwd=1234;";
        public static string nombre = "";
        public static MySqlDataAdapter combo;

        public Formulario_Inventario()
        {
            InitializeComponent();
        }

        private void Formulario_Inventario_Load(object sender, EventArgs e)
        {
            actComboBox();
            dt = getInventario();
            ds.Tables.Add(dt);
            dgvInvenario.DataSource = dt;
            cargarInsumos();
        }

        private MySqlConnection ObtenerConexion()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = dat;
            conexion.Open();
            return conexion;
        }

        private DataTable getInventario()
        {
            try
            {
                combo = new MySqlDataAdapter("select i.idProducto, i.Nombre, c.tipoCategoria, m.tipoMedida from insumo i inner join categoria c on c.idCategoria = i.Categoria_idCategoria inner join medida m on m.idMedida = i.Medida_idMedida", ObtenerConexion());
                DataTable dt = new DataTable();
                combo.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private int validarId(string id, string tabla)
        {
            int cont = 0;

            try
            {
                cmd = new MySqlCommand("Select COUNT(" + id + ") from " + tabla + "", ObtenerConexion());
                read = cmd.ExecuteReader();

                if (read.Read() == true)
                {
                    cont = read.GetInt32(0);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return cont + 1;
        }

        private bool yaExiste(string iden ,string nombre, string tabla)
        {
            try
            {
                string existente = "";
                cmd = new MySqlCommand("select "+iden+" from "+tabla+" where "+iden+"= '"+nombre+"'", ObtenerConexion());
                read = cmd.ExecuteReader();

                if (read.Read() == true)
                {
                    existente = read.GetString(0);
                }

                if (nombre == existente)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        private void ventanaEmergente()
        {
            Formulario_Emergente v = new Formulario_Emergente();
            v.ShowDialog(this);
        }

        private void actComboBox()
        {
            try
            {
                cmd = new MySqlCommand("select idCategoria,tipoCategoria from categoria", ObtenerConexion());
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                cmbCategoria.ValueMember = "idCategoria";
                cmbCategoria.DisplayMember = "tipoCategoria";
                cmbCategoria.DataSource = dt;

                MySqlCommand cmd1 = new MySqlCommand("select idMedida,tipoMedida from medida", ObtenerConexion());
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da2.Fill(dt1);

                cmbMedida.ValueMember = "idMedida";
                cmbMedida.DisplayMember = "tipoMedida";
                cmbMedida.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inventario()
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter myda = new MySqlDataAdapter("select i.idProducto, i.Nombre, c.tipoCategoria, m.tipoMedida from insumo i inner join categoria c on c.idCategoria = i.Categoria_idCategoria inner join medida m on m.idMedida = i.Medida_idMedida", ObtenerConexion());
                myda.Fill(dt);
                dgvInvenario.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insCompra(string fechaI, string fechaV, int cantidad, double precio, int idP)
        {
            try
            {
                cmd = new MySqlCommand("insert into lote (fechaIngreso,fechaVencimiento,cantidad,precio,Producto_idProducto) values ('" + fechaI + "','" + fechaV + "'," + cantidad + "," + precio + "," + idP + ");", ObtenerConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Compra Realizada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public int busIdInsumo(string nombre)
        {
            int cont = 0;

            try
            {
                cmd = new MySqlCommand("Select idProducto from insumo where Nombre = '" + nombre + "';", ObtenerConexion());
                read = cmd.ExecuteReader();

                if (read.Read() == true)
                {
                    cont = read.GetInt32(0);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cont;
        }

        public void cargarInsumos()
        {

            try
            {
                cmd = new MySqlCommand("Select* from insumo ;", ObtenerConexion());
                combo = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                combo.Fill(dt);

                cBoxSelecInsumo.DisplayMember = "Nombre";
                cBoxSelecInsumo.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_crearInsumo_Click(object sender, EventArgs e)
        {
            int id = validarId("idProducto", "insumo");
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            int idCategoria = Convert.ToInt32(((System.Data.DataRowView)cmbCategoria.SelectedItem).Row.ItemArray[0].ToString());
            int idMedida = Convert.ToInt32(((System.Data.DataRowView)cmbMedida.SelectedItem).Row.ItemArray[0].ToString());

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Hay campos vacíos", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (!yaExiste("Nombre",nombre,"insumo"))
                    {

                        cmd = new MySqlCommand("insert into insumo values (" + id + ",'" + nombre + "','" + descripcion + "'," + idCategoria + "," + idMedida + ");", ObtenerConexion());
                        cmd.ExecuteNonQuery();
                        cargarInsumos();
                        MessageBox.Show("Insumo creado");
                        inventario();
                        
                    }
                    else
                    {
                        MessageBox.Show("El insumo ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtNombre.Clear();
                txtDescripcion.Clear();
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            ventanaEmergente();
            int id = validarId("idCategoria", "categoria");

            try
            {
                if (!yaExiste("tipoCategoria", nombre, "categoria"))
                {
                    cmd = new MySqlCommand("insert into categoria values (" + id + ",'" + nombre + "')", ObtenerConexion());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoría creada");
                    actComboBox();
                }
                else
                {
                    MessageBox.Show("La categoria ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAgregarMedida_Click(object sender, EventArgs e)
        {
            ventanaEmergente();
            int id = validarId("idMedida", "medida");

            try
            {
                if (!yaExiste("tipoMedida", nombre, "medida"))
                {
                    cmd = new MySqlCommand("insert into medida values (" + id + ",'" + nombre + "')", ObtenerConexion());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medida creada");
                    actComboBox();
                }
                else
                {
                    MessageBox.Show("La medida ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (char.IsPunctuation(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnCompraInsumo_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            int idP;

            if ((txtCantInsumo.Text == "") || (txtPrecioInsumo.Text == ""))
            {
                MessageBox.Show("Ingrese Datos");
            }
            else
            {
                double precio = Convert.ToDouble(txtPrecioInsumo.Text);
                int cantidad = Convert.ToInt32(txtCantInsumo.Text);

                string insumo = cBoxSelecInsumo.Text;
                idP = busIdInsumo(insumo);

                string fechaVencimiento = Convert.ToString(dateTimePicker_fecCadInsumo.Value.Year + "-" + dateTimePicker_fecCadInsumo.Value.Month + "-" + dateTimePicker_fecCadInsumo.Value.Day);

                string fechaIngreso = Convert.ToString(thisDay.Year + "-" + thisDay.Month + "-" + thisDay.Day);


                insCompra(fechaIngreso, fechaVencimiento, cantidad, precio, idP);
                inventario();

                txtPrecioInsumo.Clear();
                txtCantInsumo.Clear();
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string busqueda = string.Concat("[", dt.Columns[1].ColumnName, "]");
            dt.DefaultView.Sort = busqueda;
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Empty;

            if (txtBusqueda.Text != string.Empty)
            {
                dv.RowFilter = busqueda + "LIKE '%" + txtBusqueda.Text + "%'";
                dgvInvenario.DataSource = dv;
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            dt = getInventario();
            ds.Tables.Add(dt);
            dgvInvenario.DataSource = dt;
        }
    }
}
