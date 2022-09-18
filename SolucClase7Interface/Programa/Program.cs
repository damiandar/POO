using System;
using Biblioteca;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1=new Persona();
            
            var pinguino1=new Pinguino();
            
            ActivarSerVivo(persona1);
            ActivarSerVivo(pinguino1);
            ActivarSerVivo(new Pez());
            var pez2=new Pez();
            
        }

        static void ActivarSerVivo(Servivo servivo){
            Console.WriteLine(servivo.GetType().ToString());
            if(servivo is INadador ){
                Console.WriteLine("Implementa Inadador");
                ((INadador)servivo).Nadar();
            }
            if(servivo is ICorredor){
                Console.WriteLine("Implementa ICorredor");
            }
            if (servivo is IVolador){
                Console.WriteLine("Implementa ivolador");
            }

            if(servivo is ISerhumano){
                Console.WriteLine("Implementa Iserhumano");
            }

            


        }
    }
}
