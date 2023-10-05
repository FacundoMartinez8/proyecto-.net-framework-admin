using Proyecto_1;
using System;

namespace Proyecto_1
{
    class Empleado : Persona, IHorario, IRH
    {
        private string puesto;
        private int antiguedad;
        private int sueldo;

        public string Puesto { get => puesto; set => puesto = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }

        public Empleado(string nombre, string apellido, string dni, int edad, string genero, string puesto, int antiguedad, int sueldo)
        : base(nombre, apellido, dni, edad, genero)
        {
            Puesto = puesto;
            Antiguedad = antiguedad;
            Sueldo = sueldo;
        }
        public void IngresarHorario(DateTime entrada, DateTime salida)
        {
            Console.WriteLine($"{Nombre} {Apellido} ha ingresado su horario: Entrada: {entrada}, Salida: {salida}");
        }

        public void DespedirEmpleado(string nombre)
        {
            Console.WriteLine($"Se ha despedido a {nombre}.");
        }

        public void Ascender(string nombre)
        {
            Console.WriteLine($"{nombre} ha sido ascendido.");
        }


        public string irAlTrabajo()
        {
            return "";
        }

        public bool retirarse()
        {
            return true;
        }

    }
}