using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    internal class Agregar : Persona
    {
        private string nuevoEmpleado;
        private string puestoAIngresar;
        private string diasLaboral;

        public string NuevoEmpleado { get => nuevoEmpleado; set => nuevoEmpleado = value; }
        public string PuestoAIngresar { get => puestoAIngresar; set => puestoAIngresar = value; }
        public string DiasLaboral { get => diasLaboral; set => diasLaboral = value; }

        public Agregar(string nuevoEmpleado, string puestoAIngresar, string diasLaboral, string nombre, string apellido, string dni, int edad, string genero) : base(nombre, apellido, dni, edad, genero)
        {
            NuevoEmpleado = nuevoEmpleado;
            PuestoAIngresar = puestoAIngresar;
            DiasLaboral = diasLaboral;
        }

        public void InformacionEmpleado()
        {
            Console.WriteLine($"Nombre del nuevo empleado{Nombre},Apellido{Apellido}, Edad{Edad}, Dni{Dni}, Genero{Genero}, Puesto Asignado{puestoAIngresar}, Que Dias trabaja {diasLaboral} ");
        }
    }
}
