using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo equipo = new Equipo();
            Jugador jugador1 = new Jugador();
            
            equipos.Add(new Equipo());
            equipos[0].Nombre = "Divos";
            equipos[0].Entrenador = "Armador Meza";
            equipos[0].CiudadOrigen = "Obregon";
            equipos[0].Jugadores.Add(new Jugador("Pepe Molina"));
            equipos[0].Jugadores.Add(new Jugador("Emilio Rocha"));
            equipos[0].Jugadores.Add(new Jugador("Santos Felix"));
            equipos[0].Jugadores.Add(new Jugador("Camilo Yegua"));
            equipos[0].Jugadores.Add(new Jugador("Juan Gracia"));
            equipos[0].Jugadores.Add(new Jugador("Pancho Perez"));
            equipos[0].Jugadores.Add(new Jugador("Teo Camargo"));
            equipos[0].Jugadores.Add(new Jugador("Esteban Gaxiola"));
            equipos[0].Jugadores.Add(new Jugador("Samuel Gtz"));
            equipo.Nombre = "Cañones";
            equipo.CiudadOrigen = "Guanajuato";
            equipo.Entrenador = "Santos Aguirre";
            equipo.Jugadores.Add(new Jugador("Pepe Molina"));
            equipo.Jugadores.Add(new Jugador("Emilio Rocha"));
            equipo.Jugadores.Add(new Jugador("Santos Felix"));
            equipo.Jugadores.Add(new Jugador("Camilo Yegua"));
            equipo.Jugadores.Add(new Jugador("Juan Gracia"));
            equipo.Jugadores.Add(new Jugador("Pancho Perez"));
            equipo.Jugadores.Add(new Jugador("Teo Camargo"));
            equipo.Jugadores.Add(new Jugador("Esteban Gaxiola"));
            equipo.Jugadores.Add(new Jugador("Samuel Gtz"));
            equipos.Add(equipo);
            //jugador1.Nombre = "Pepe Molina";
            //jugador1.Numero = "8";

            foreach(Equipo elemento in equipos)
            {
                Console.WriteLine("Equipo: " + equipos);
                foreach(Jugador elementoEquipo in elemento.Jugadores)
                {
                    Console.WriteLine("Jugador: " + equipo.Jugadores);
                }
            }
            Console.ReadLine();
        }
    }
}
