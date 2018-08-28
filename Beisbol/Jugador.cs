using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public Jugador()
        {
            Nombre = "Paco Juarez";
            Numero = "15";
        }
        public Jugador(string nombre)
        {
            Nombre = nombre;
        }
    }
}
