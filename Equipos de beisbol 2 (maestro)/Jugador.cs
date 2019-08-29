using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_de_beisbol_2__maestro_
{
    class Jugador
    {
        public string NombreJug { get; set; }
        public int Numero { get; set; }

        public Jugador()  //Constructor sin parametros
        {
            NombreJug = "Pendiente";
            Numero = 0;
        }

        public Jugador(string nombrejug, int numero)    // Constructor con parametros; (nombrejug y numero)
        {
            NombreJug = nombrejug;
            Numero = numero;
        }
    }
}
