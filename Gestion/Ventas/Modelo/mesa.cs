using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Ventas.Modelo
{
    class mesa
    {
        private int id;
        private int numeroMesa;
        private int idStatus;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int NumeroMesa
        {
            get { return numeroMesa; }
            set { numeroMesa = value; }
        }
        public int Idstatus
        {
            get { return idStatus; }
            set { idStatus = value; }
        }
    }
}
