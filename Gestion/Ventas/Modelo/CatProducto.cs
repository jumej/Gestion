using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Ventas.Modelo
{
    class CatProducto
    {
        

            private int idCategoría;
            private string tipoCategoría;


            public int Id
            {
                get { return idCategoría; }
                set { idCategoría = value; }
            }


            public string Categoria
            {
                get { return tipoCategoría; }
                set { tipoCategoría = value; }
            }
        }

    
}
