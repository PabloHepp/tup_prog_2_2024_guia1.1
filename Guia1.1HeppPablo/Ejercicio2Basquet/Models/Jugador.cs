using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Basquet.Models
{
    internal class Jugador
    {
        private string nombre;
        private int nroCamiseta;
        private int puntos[];

        public Jugador(string nombre)
        {
            this.nombre = nombre;
        }

        public int camiseta
        {
            get { return camiseta; }
            set { camiseta = value; }
        }


    }
}
