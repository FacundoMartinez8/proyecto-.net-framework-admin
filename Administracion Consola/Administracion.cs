using Proyecto_1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

class Administracion : Empleado
{
    public string RecursoHumanos { get; set; }
    public string Empleador { get; set; }

    public Administracion(string nombre, string apellido, string dni, int edad, string genero, string puesto, int antiguedad, int sueldo, string recursoHumanos, string empleador)
        : base(nombre, apellido, dni, edad, genero, puesto, antiguedad, sueldo)
    {
        RecursoHumanos = recursoHumanos;
        Empleador = empleador;
    }

    // Método para agregar un empleado al archivo de texto
    public void Agregar()
    {
        using (StreamWriter writer = new StreamWriter("empleados.txt", true))
        {
            writer.WriteLine($"{Nombre},{Apellido},{Dni},{Edad},{Genero},{Puesto},{Antiguedad},{Sueldo},{RecursoHumanos},{Empleador}");
        }
    }

    // Método para listar todos los empleados en el archivo de texto
    public string Listar()
    {
        using (StreamReader reader = new StreamReader("empleados.txt"))
        {
            return reader.ReadToEnd();
        }
    }

    // Método para buscar empleados por nombre o DNI en el archivo de texto
    public List<Empleado> Buscar(string criterio)
    {
        List<Empleado> empleadosEncontrados = new List<Empleado>();
        using (StreamReader reader = new StreamReader("empleados.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] datos = line.Split(',');
                if (datos[0].Contains(criterio) || datos[2].Contains(criterio)) // Busca por nombre o DNI
                {
                    Empleado empleadoEncontrado = new Empleado(datos[0], datos[1], datos[2], int.Parse(datos[3]), datos[4], datos[5], int.Parse(datos[6]), int.Parse(datos[7]));
                    empleadosEncontrados.Add(empleadoEncontrado);
                }
            }
        }
        return empleadosEncontrados;
    }
    public void Eliminar(string dni)
    {
        // Método para eliminar un empleado por su DNI
        List<string> lineas = new List<string>();
        using (StreamReader reader = new StreamReader("empleados.txt"))
        {
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                string[] datos = linea.Split(',');
                if (datos[2] != dni) // Si el DNI no coincide, conserva la línea
                {
                    lineas.Add(linea);
                }
            }
        }
        using (StreamWriter writer = new StreamWriter("empleados.txt"))
        {
            foreach (var linea in lineas)
            {
                writer.WriteLine(linea);
            }
        }
    }

    public void Modificar(string dni, Administracion nuevoEmpleado)
    {
        // Método para modificar los datos de un empleado por su DNI
        List<string> lineas = new List<string>();
        using (StreamReader reader = new StreamReader("empleados.txt"))
        {
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                string[] datos = linea.Split(',');
                if (datos[2] == dni) // Si el DNI coincide, usa los nuevos datos
                {
                    lineas.Add($"{nuevoEmpleado.Nombre},{nuevoEmpleado.Apellido},{nuevoEmpleado.Dni},{nuevoEmpleado.Edad},{nuevoEmpleado.Genero},{nuevoEmpleado.Puesto},{nuevoEmpleado.Antiguedad},{nuevoEmpleado.Sueldo},{RecursoHumanos},{Empleador}");
                }
                else
                {
                    lineas.Add(linea);
                }
            }
        }
        using (StreamWriter writer = new StreamWriter("empleados.txt"))
        {
            foreach (var linea in lineas)
            {
                writer.WriteLine(linea);
            }
        }
    }
    public int SumaSalarios()
    {
        int suma = 0;
        using (StreamReader reader = new StreamReader("empleados.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] datos = line.Split(',');
                int sueldo = int.Parse(datos[7]);
                suma += sueldo;
            }
        }
        return suma;
    }
}