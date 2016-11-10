using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Clases_Generales
{
    class Clase_ConeccionDB
    {
        public static MySqlConnection obtenerConeccion() {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=gestionDB; Uid=root; pwd=1234;");
            conectar.Open();
            return conectar;
        }
    }
}
