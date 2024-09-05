using Ejercicio2Basquet.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Basquet
{
    class Equipo
    {
        private string nombre; //Atributo

        public Equipo(string nombre) //Constructor
        {
            this.nombre = nombre;
        }

        public string Nombre // Propiedad
        {   
            private set { this.nombre = value; }
            get { return nombre; }
        }

        ArrayList jugadores = new ArrayList();

        public void AgregarJugador(Jugador nuevo) // Método para cargar jugadores
        {
            jugadores.Add(nuevo);
        }

    }

   
}
