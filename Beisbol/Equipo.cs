using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string CiudadOrigen { get; set; }
        public string Entrenador { get; set; }

        public List<Jugador> Jugadores;
       
        public Equipo()
        {
            Jugadores = new List<Jugador>();
        }
        public Equipo(string nombre,string ciudadOrigen,string entrenador)
        {
            Nombre = nombre;
            CiudadOrigen = ciudadOrigen;
            Entrenador = entrenador;
        }
    }
}
