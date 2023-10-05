using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    abstract class Persona
    {
        public string Nombre;
        public string Apellido;
        public string Dni;
        public int Edad;
        public string Genero;

        public Persona(string nombre, string apellido, string dni, int edad, string genero)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Edad = edad;
            Genero = genero;
        }


        public string HolaSoy()
        {
            return $"{Nombre} {Apellido}";
        }
        public string MiDniEs()
        {
            return $"{Dni}";
        }
    }
}
