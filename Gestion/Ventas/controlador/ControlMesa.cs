using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion.Clases_Generales;
using MySql.Data.MySqlClient;
using Gestion.Ventas.Modelo;
using System.Data;

namespace Gestion.Ventas.controlador
{
    class ControlMesa
    {
        Clase_ConeccionDB conexion = new Clase_ConeccionDB();


        public string[] seleccionarStatusMesa()


        {
            string[] arraymesas = new string[12];
                                            

            MySqlCommand Comando = new MySqlCommand();
            Comando.Connection = Clase_ConeccionDB.obtenerConeccion();
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.CommandText = "selectMesa";

      
            try
            {
                int i = 0;
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {

                    mesa _municipi = new mesa();

                    arraymesas[i] = lector[2].ToString();

                    i++;

                }

                arraymesas[i + 1] = "fin";
            }
            catch (Exception ex)
            {
                string m = ex.Message;
                Comando.Dispose();
            }

            finally
            {
             
            }


            return arraymesas;
        }

    }
}
