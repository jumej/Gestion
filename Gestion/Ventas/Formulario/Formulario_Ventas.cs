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

namespace Gestion.Ventas.Formulario
{
    public partial class Formulario_Ventas : Form
    {
        public Formulario_Ventas()
        {
            InitializeComponent();
        }
        int libres = 0;
        int ocupadas = 0;
        int reservadas = 0;

        private void mesas_Load(object sender, EventArgs e)
        {
            
            btncolor1.BackColor = Color.Lime;
            btncolor2.BackColor = Color.Red;
            txtTotalMesas.Text = "12";

            pintarMesas();
            txtlibres.Text = libres + "";
            txtOcupadas.Text = ocupadas + "";
            txtReservadas.Text = reservadas + "";
            //  MessageBox.Show(arraymesas[i] +" "+ i);

        }
        public void pintarMesas()
        {
            string[] arraymesas = new string[12];

            ControlMesa _mesa = new ControlMesa();
            arraymesas = _mesa.seleccionarStatusMesa();

            //mesa 1
            if (arraymesas[0] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[0] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[0] == "reservada")
            {
                m1.BackColor = Color.LightPink;
                reservadas++;
            }

            //mesa 2
            if (arraymesas[1] == "libre")
            {
                m2.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[1] == "ocupada")
            {
                m2.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[1] == "reservada")
            {
                m2.BackColor = Color.LightPink;
                reservadas++;
            }


            //mesa 3
            if (arraymesas[2] == "libre")
            {
                m3.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[2] == "ocupada")
            {
                m3.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[2] == "reservada")
            {
                m3.BackColor = Color.LightPink;
                reservadas++;
            }

            //mesa 4
            if (arraymesas[3] == "libre")
            {
                m4.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[3] == "ocupada")
            {
                m4.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[3] == "reservada")
            {
                m4.BackColor = Color.LightPink;
                reservadas++;
            }

            //mesa 5
            if (arraymesas[4] == "libre")
            {
                m5.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[4] == "ocupada")
            {
                m5.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[4] == "reservada")
            {
                m5.BackColor = Color.LightPink;
                reservadas++;
            }

            //mesa 6
            if (arraymesas[5] == "libre")
            {
                m6.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[5] == "ocupada")
            {
                m6.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[5] == "reservada")
            {
                m6.BackColor = Color.LightPink;
                reservadas++;
            }

            //mesa 7
            if (arraymesas[6] == "libre")
            {
                m7.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[6] == "ocupada")
            {
                m7.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[6] == "reservada")
            {
                m7.BackColor = Color.LightPink;
                reservadas++;
            }

            //mesa 8
            if (arraymesas[7] == "libre")
            {
                m8.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[7] == "ocupada")
            {
                m8.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[7] == "reservada")
            {
                m8.BackColor = Color.LightPink;
                reservadas++;
            }
            //mesa 9
            if (arraymesas[8] == "libre")
            {
                m9.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[8] == "ocupada")
            {
                m9.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[8] == "reservada")
            {
                m9.BackColor = Color.LightPink;
                reservadas++;
            }

            //mesa 10
            if (arraymesas[9] == "libre")
            {
                m10.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[9] == "ocupada")
            {
                m10.BackColor = Color.Red;
                ocupadas++;

            }
            if (arraymesas[9] == "reservada")
            {
                m10.BackColor = Color.LightPink;
                reservadas++;
            }
            //mesa 11
            if (arraymesas[10] == "libre")
            {
                m11.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[10] == "ocupada")
            {
                m11.BackColor = Color.Red;
                ocupadas++;
            }
            if (arraymesas[10] == "reservada")
            {
                m11.BackColor = Color.LightPink;
                reservadas++;
            }

            //  mesa 12
            if (arraymesas[11] == "libre")
            {
                m12.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[11] == "ocupada")
            {
                m12.BackColor = Color.Red;
                ocupadas++;

            }
            if (arraymesas[11] == "reservada")
            {
                m12.BackColor = Color.LightPink;
                reservadas++;
            }
        }

        private void m12_Click(object sender, EventArgs e)
        {
            Formulario_Orden f = new Formulario_Orden();
            f.lblMesa.Text = "12";
            this.Hide();
            f.ShowDialog();
        }

        private void m1_Click(object sender, EventArgs e)
        {
            Formulario_Orden f = new Formulario_Orden();
            f.lblMesa.Text = "1";
            this.Hide();
            f.ShowDialog();
        }

        private void m2_Click(object sender, EventArgs e)
        {
            Formulario_Orden f = new Formulario_Orden();
            f.lblMesa.Text = "2";
            this.Hide();
            f.ShowDialog();
        }

        private void m3_Click(object sender, EventArgs e)
        {
            Formulario_Orden f = new Formulario_Orden();
            f.lblMesa.Text = "3";
            this.Hide();
            f.ShowDialog();
        }

        private void m4_Click(object sender, EventArgs e)
        {
            Formulario_Orden f = new Formulario_Orden();
            f.lblMesa.Text = "4";
            this.Hide();
            f.ShowDialog();
        }

        private void m5_Click(object sender, EventArgs e)
        {
            Formulario_Orden f = new Formulario_Orden();
            f.lblMesa.Text = "5";
            this.Hide();
            f.ShowDialog();
        }

        private void m6_Click(object sender, EventArgs e)
        {
            Formulario_Orden f = new Formulario_Orden();
            f.lblMesa.Text = "6";
            this.Hide();
            f.ShowDialog();
        }

        private void m7_Click(object sender, EventArgs e)
        {
            Formulario_Orden f = new Formulario_Orden();
            f.lblMesa.Text = "7";
            this.Hide();
            f.ShowDialog();
        }

        private void m8_Click(object sender, EventArgs e)
        {
            Formulario_Orden f = new Formulario_Orden();
            f.lblMesa.Text = "8";
            this.Hide();
            f.ShowDialog();
        }

        private void m9_Click(object sender, EventArgs e)
        {
            Formulario_Orden f = new Formulario_Orden();
            f.lblMesa.Text = "9";
            this.Hide();
            f.ShowDialog();
        }

        private void m10_Click(object sender, EventArgs e)
        {
            Formulario_Orden f = new Formulario_Orden();
            f.lblMesa.Text = "10";
            this.Hide();
            f.ShowDialog();
        }

        private void m11_Click(object sender, EventArgs e)
        {
            Formulario_Orden f = new Formulario_Orden();
            f.lblMesa.Text = "11";
            this.Hide();
            f.ShowDialog();
        }
    }
}
