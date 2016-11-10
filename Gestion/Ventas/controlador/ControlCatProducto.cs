using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion.Ventas.Modelo;
using System.Data;
using Gestion.Clases_Generales;
using MySql.Data.MySqlClient;



namespace Gestion.Ventas.controlador
    
{
    class ControlCatProducto
    {
        Clase_ConeccionDB conexion = new Clase_ConeccionDB();
        public List<CatProducto> seleccionarCatProducto()
        {
            List<CatProducto> listaCtProducto = new List<CatProducto>();
                      
            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Clase_ConeccionDB.obtenerConeccion();
            Comando.CommandType = CommandType.StoredProcedure;
             Comando.CommandText = "selectCatProduto";
    

            try
            {
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    CatProducto _catProduto = new CatProducto();
                    _catProduto.Id = int.Parse(lector[0].ToString());
                    _catProduto.Categoria = lector[1].ToString();
                    listaCtProducto.Add(_catProduto);
                }
            }
            catch (Exception ex)
            {
                string m = ex.Message;
                Comando.Dispose();
            }

            finally
            {
                
            }

            return listaCtProducto;
        }

    }
}
