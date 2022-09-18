using System;
using Entities;
using BLL;

namespace ConsoleAppUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var DNI = Console.ReadLine();
            var Nombre = Console.ReadLine();
            var Apellido = Console.ReadLine();
            var materiaid = Console.ReadLine();

            var alumno1 = new Alumno();
            alumno1.Dni = Int32.Parse( DNI);
            alumno1.Nombre = Nombre;

            var alumnoBLL = new AlumnoBLL();
            alumnoBLL.InscribirAlumno(alumno1, Int32.Parse( materiaid));
        }
    }
}
