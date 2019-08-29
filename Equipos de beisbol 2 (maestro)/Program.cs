using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_de_beisbol_2__maestro_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo toros =                                 //Declaración de la variable nueva
                new Equipo("Toros");
            toros.Entrenador = "Maximiliano";
            toros.CiudadDeOrigen = "Hermosillo";

            toros.Jugadores.Add(
                new Jugador("Pedro", 12));
            toros.Jugadores.Add(
                new Jugador("Juan", 99));
            toros.Jugadores.Add(
                 new Jugador("Jose", 24));
            toros.Jugadores.Add(
                new Jugador("Miguel", 57));
            toros.Jugadores.Add(
                new Jugador("Pablo", 01));
            toros.Jugadores.Add(
                new Jugador("Ramon", 10));
            toros.Jugadores.Add(
                new Jugador("Antonio", 09));
            toros.Jugadores.Add(
                new Jugador("Alfredo", 77));
            toros.Jugadores.Add(
                new Jugador("Enrique", 45));


            Equipo pumas =
                new Equipo("Pumas");
            pumas.Entrenador = "Roberto";
            pumas.CiudadDeOrigen = "Tijuana";

            pumas.Jugadores.Add(
                new Jugador("Francisco", 11));
            pumas.Jugadores.Add(
                new Jugador("Angel", 05));
            pumas.Jugadores.Add(
                new Jugador("Alonso", 39));
            pumas.Jugadores.Add(
                new Jugador("Alejandro", 98));
            pumas.Jugadores.Add(
                new Jugador("Adrian", 80));
            pumas.Jugadores.Add(
                new Jugador("Kevin", 15));
            pumas.Jugadores.Add(
                new Jugador("Manuel", 23));
            pumas.Jugadores.Add(
                new Jugador("Ivan", 67));
            pumas.Jugadores.Add(
                new Jugador("David", 26));

            equipos.Add(toros);
            equipos.Add(pumas);
               
            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("*" +
                       equipo.Nombre + " de " +
                       equipo.CiudadDeOrigen);
                Console.WriteLine("Equipo: " +
                    equipo.Nombre);
                foreach (Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("-" +
                        jugador.NombreJug + " " +
                        jugador.Numero);                 
                }
            }

            Console.Read();
        }
    }
    
}
