using System;

namespace Clase16TiposGenericos
{
    class Program
    {
        static void Main(string[] args)
        {
            var impresora1=new Impresora();
            impresora1.Imprimir<int>(244); 
            impresora1.Imprimir<string>("cadena");
            impresora1.Imprimir(244);
            impresora1.Imprimir("cadena");

            var alumno= new Alumno() {Nombre="Laura", Apellido="Alonso"};
            impresora1.Imprimir(alumno);
             /*
             var repo=new Repositorio<string>();
             repo.Dato="Valor de la variable";
             impresora1.Imprimir(repo.Dato);

             var repo2=new Repositorio<int>();
             repo2.Dato=200;
             impresora1.Imprimir(repo2.Dato);
            */
            var repo3=new Repositorio<Alumno>();
            repo3.Dato=alumno;
            impresora1.Imprimir(repo3.Dato);

            //var listaAlumnos=new List<Alumno>
        }
    }

    public class Repositorio<T> where T:Persona
    {
        public T Dato {get;set;}
    }

    public class Persona{
        public string Nombre{get;set;}
        public string Apellido {get;set;}
    }
    public class Alumno:Persona {
        public int DNI {get;set;}
    }
    public class Profesor:Persona{
        public int Legajo {get;set;}
    }

    public class Materia{
        public int Id {get;set;}
        public string Descripcion {get;set;}
    }
    public class Impresora{
        public void Imprimir<T>(T dato){
            if(dato.GetType()==typeof(Alumno)){
                Alumno alu;
                /*alu=(Alumno)dato;
                Console.WriteLine( alu.GetType());*/
            }
            else{
                Console.WriteLine("Imprimir: " + dato.ToString());
            }
            
        }
        /*
        public void Imprimir(int dato){
            Console.WriteLine("Imprimir: " + dato.ToString());
        }
        public void Imprimir(string dato){
            Console.WriteLine("Imprimir: " + dato.ToString());
        }
        public void Imprimir(double dato){
            Console.WriteLine("Imprimir: " + dato.ToString());
        }
        */

    }
}
