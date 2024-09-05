using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1Motos
{
    internal class Moto
    {
        public string Marca;
        public int Modelo { get; private set; }
        public double ValorFabricacion { get; private set; }

        public Moto(string marca, int mod, double año)
        {
            Marca = marca;
            Modelo = mod;
            ValorFabricacion = año;
        }
        // revisar la propiedad, porque con mayuscula no la toma y con minuscula si
        public string marca
        {
            get { return marca ; }
            private set { marca = value ; }
        }



    }
}
