using Ejercicio2Basquet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio2Basquet
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            AgregarJug nuevojug = new AgregarJug();
            string nombre;
            int camiseta;
            int puntos;
            int cantSimples, cantDobles, cantTriples;
            if (nuevojug.ShowDialog() == DialogResult.OK)
            {
                nombre = nuevojug.tbNombreJug.Text;
                camiseta = Convert.ToInt32(nuevojug.tbNroCamiseta.Text);
                Jugador nuevo = new Jugador(nombre, camiseta);

                cantSimples = Convert.ToInt32(nuevojug.numSimples.Value);
                cantDobles = Convert.ToInt32(nuevojug.numDobles.Value);
                cantTriples = Convert.ToInt32(nuevojug.numTriples.Value);

                nuevo.CargarPunto(cantSimples, 1);
                nuevo.CargarPunto(cantDobles, 2);
                nuevo.CargarPunto(cantTriples, 3);

                puntos = nuevo.VerPuntos();
                //label1.Text = Convert.ToString(puntos);
            }
            
            
        }

    }
}
