using System;
using System.Collections.Generic;


namespace ProyClase3Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var alumno1=new Alumno();
            alumno1.Nombre="Laura";
            alumno1.Apellido="Alonso";
            alumno1.Saludar();
        

            var profesor=new Profesor();
            profesor.Nombre="Damian";
            profesor.Apellido="Rosso";
            profesor.Saludar();
            profesor.Sueldo=1000;
            profesor.Cobrar();
            profesor.Evaluar();

            var secretaria=new Secretaria();
            secretaria.Nombre="Lorena";
            secretaria.Saludar();
            secretaria.Sueldo=1400;
            secretaria.Cobrar();
            secretaria.ControlarAsistencia();



        }
    }

    public class Persona{
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public int DNI {get;set;}
        public void Saludar(){
            Console.WriteLine("Hola mi nombre es " + Nombre);
        }
    }

    public class Alumno: Persona{
    
        public List<int> Notas{get;set;}
        public List<string> Materias {get;set;}

        public void PagarCuota(int valor){

        }
    }
    public class Empleado :Persona{
        public int Sueldo {get;set;}
        public void Cobrar(){

        }
    }
    public class Profesor:Empleado{  
 

        public List<string> MateriasDictadas{get;set;}

        public void Evaluar(){
            Console.WriteLine("Evaluando alumnos");
        }
    }

    public class Secretaria: Empleado{ 
        public void ControlarAsistencia(){
            Console.WriteLine("Controlar asistencia");
        }
 
    }

    
}
