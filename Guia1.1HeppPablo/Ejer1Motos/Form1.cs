using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer1Motos
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)

        {
     
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text;
            int año = Convert.ToInt32(numModelo.Value);
            int actual = Convert.ToInt32(numAño.Value);
            double valorFab = Convert.ToDouble(tbValorFab.Text);
            double tasa = Convert.ToDouble(tbTasa.Text);
            int vida = Convert.ToInt32(tbVida.Text);

            Moto cotizacion = new Moto(marca, año, valorFab);
                    
            VerResultados resultados = new VerResultados();

            string datos = cotizacion.VerDescripcion();
            double deplineal = cotizacion.CalcularDepreciacionLineal(actual, vida);
            double depAnual = cotizacion.CalcularDepreciacionAnual(actual, tasa);

            while (resultados.ShowDialog() == DialogResult.OK)
            {
                resultados.listBResultados.Items.Add(datos);
                resultados.listBResultados.Items.Add(Convert.ToString($"Depreciacion lineal: {deplineal}"));
                resultados.listBResultados.Items.Add(Convert.ToString($"Depreciación anual: {depAnual}"));
                
            }


        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numModelo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
