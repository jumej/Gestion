using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Clases_Generales
{
    class Clase_FormDentroDePanel
    {
        Form fh;
        Panel panelContenedor;
        public Clase_FormDentroDePanel(Form fh, Panel panelContenedor)
        {
            this.fh = fh;
            this.panelContenedor = panelContenedor;
        }
        public void AgregarFormEnPanel()
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            fh.TopLevel = false;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
    }
}
