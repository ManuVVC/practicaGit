using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;

            //Leo el telegrama 
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            /*if (cbUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else { tipoTelegrama = 'o'; }*/

            //Obtengo el número de palabras que forma el telegrama

            numPalabras = textoTelegrama.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;

            //Si el telegrama es ordinario
            if (rbOrdinario.Checked && !rbUrgente.Checked)
            {
                if (numPalabras <= 10)
                { coste = 3; }
                else
                { coste = 0.5 * numPalabras; }
            }

            //Si el telegrama es urgente
            else if (!rbOrdinario.Checked && rbUrgente.Checked)
            {
                if (numPalabras <= 10)
                { coste = 6; }
                else
                { coste = 6 + 0.75 * (numPalabras - 10); }
            }

            else
                coste = 0;

            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void rbOrdinario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUrgente.Checked)
            {
                rbUrgente.Checked = false;
                rbOrdinario.Checked = true;
            }

        }

        private void rbUrgente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrdinario.Checked)
            {
                rbOrdinario.Checked = false;
                rbUrgente.Checked = true;
            }
        }
    }
}
