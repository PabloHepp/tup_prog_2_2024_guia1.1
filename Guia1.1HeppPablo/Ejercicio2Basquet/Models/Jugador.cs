using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Basquet.Models
{
    internal class Jugador
    {
        private string nombre; //variable de instancia
        private int nroCamiseta; //variable de instancia
        private int[] puntos; //variable de instancia

        public string Nombre //propiedad para acceder al atributo Nombre
        {
            private set { nombre = value; } //metodo para setear nombre
            get { return nombre; } //metodo para devolver nombre
        }

        public int Camiseta //propiedad para acceder al atributo nrocamiseta
        {
            get { return nroCamiseta; }
            private set { nroCamiseta = value; }
        }

        public Jugador(string nombre, int numero) //Constructor de la clase
        {
            Nombre = nombre;
            nroCamiseta = numero;
            puntos = new int[3];
        }

        public void CargarPunto(int valor, int tipo)
        {
            puntos[tipo-1] += valor;
            
            /*
            switch (valor)
            {
                case 1:
                    puntos[0]++;
                    break;
                case 2:
                    puntos[1]++;
                    break;
                case 3:
                    puntos[2]++;
                    break;
            }
            */

        }

        public int VerPuntos()
        {
            return puntos[0] + (puntos[1] * 2) + (puntos[2] * 3);
        }

        public double PorcentajeSimples()
        {
            double total = 0.0;
            foreach (int p in puntos)
            {
                total += p;
            }
            return (puntos[0] * 100.0) / total;
        }
        
        public double PorcentajeDobles()
        {
            double total = 0.0;
            foreach (int p in puntos)
            {
                total += p;
            }
            return (puntos[1] * 100) / total;
        }

        public double PorcentajeTriples()
        {
            double total = 0.0;
            foreach (int p in puntos)
            {
                total += p;
            }
            return (puntos[2] * 100) / total;
        }
    }
}
