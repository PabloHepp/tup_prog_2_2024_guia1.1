using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1Motos
{
    internal class Moto
    {
        public string marca;

        public int modelo;

        public double valorFabricacion;

        public Moto(string mar, int mod, double año)
        {
            marca = mar;
            modelo = mod;
            valorFabricacion = año;
        }
        // al hacer las propiedades , viendo que el diagrama UML especificaba <<readonly>>, supongo
        // que se refiere a que solamente está habilitada la lectura de los atributos
        // por eso le pongo el get publico y el set private
        public string Marca
        {
            get { return marca; }
            private set { marca = value; }
        }

        public int Modelo
        {
            get { return modelo; }
            private set { modelo = value; }

        }

        public double ValorFabricacion
        {
            get { return valorFabricacion; }
            private set { valorFabricacion = value; }
        }

        public double CalcularDepreciacionLineal(int añoacalcular, int vidautil)
        {
            int uso = añoacalcular - modelo;
            double valorActualizado = valorFabricacion - (valorFabricacion * (uso / vidautil));
            return valorActualizado;
        }

        public double CalcularDepreciacionAnual(int añoacalcular, double tasaDepreciacion)
        {
            int uso = añoacalcular - modelo;
            double valorActualizado = valorFabricacion * (Math.Pow((1 - tasaDepreciacion), uso));
            return valorActualizado;
        }

        public string VerDescripcion()
        {
            return $"Marca:{marca}, Modelo:{modelo}, Valor de Fabricación: ${valorFabricacion,10:f2}";
        }


    }
}
