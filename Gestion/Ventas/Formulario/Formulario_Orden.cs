using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.Ventas.controlador;
using MySql.Data.MySqlClient;
using Gestion.Ventas.Modelo;

namespace Gestion.Ventas.Formulario
{
    public partial class Formulario_Orden : Form
    {
        public Formulario_Orden()
        {
            InitializeComponent();
        }
        public void cargarGrigOrden()
        {                        
            dgwOrden.ColumnCount = 4;
            dgwOrden.Columns[0].Name = "Nombre";
            dgwOrden.Columns[1].Name = "Descripcion";
            dgwOrden.Columns[2].Name = "$Precio";
            dgwOrden.Columns[3].Name = "Categoria Producto";
                       
        }
        private void Formulario_Orden_Load(object sender, EventArgs e)
        {
            cargarGrigOrden();
            ControlCatProducto _catPro = new ControlCatProducto();
            cbCategoria.DataSource = _catPro.seleccionarCatProducto();
            cbCategoria.DisplayMember = "Categoria";
            cbCategoria.ValueMember = "Id";
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarGrig();
          

        }

        public void llenarGrig()
        {
            ControlProducto _Cproducto = new ControlProducto();
            CatProducto _categoriaproducto = new CatProducto();
            if (cbCategoria.SelectedValue.ToString() != "sistemaRestaurante.modelo.CatProducto")
            {
                
            }
        }
        private void txtTotalOrden_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
