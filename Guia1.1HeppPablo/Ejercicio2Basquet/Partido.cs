using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Basquet
{
    internal class Partido
    {
        Equipo local;
        Equipo visitante;

        public void AgregarEquipos (Equipo local, Equipo visitante) 
        {
            this.local = local;
            this.visitante = visitante;
        }
    }
}
