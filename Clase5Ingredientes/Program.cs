using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase5Ingredientes
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingrediente1=new Ingrediente();
            ingrediente1.Nombre="Lechuga";
            ingrediente1.Precio=50;

            var ingrediente2=new Ingrediente();
            ingrediente2.Nombre="Tomate";
            ingrediente2.Precio=50;

            var ingrediente3=new Ingrediente();
            ingrediente3.Nombre="Milanesa";
            ingrediente3.Precio=400;

            var ingrediente4=new Ingrediente();
            ingrediente4.Nombre="Suprema";
            ingrediente4.Precio=300;

            var ingrediente5=new Ingrediente();
            ingrediente5.Nombre="Jamon";
            ingrediente5.Precio=60;

            var ingrediente6=new Ingrediente();
            ingrediente6.Nombre="Queso";
            ingrediente6.Precio=55;

            var ingrediente7=new Ingrediente();
            ingrediente7.Nombre="Papas fritas";
            ingrediente7.Precio=80;

            var plato1=new Plato();
            plato1.Nombre="Sandwich de suprema con lechuga y tomate";
            plato1.Ingredientes=new List<Ingrediente>{
                ingrediente4,
                ingrediente1,
                ingrediente2,
            };

            var plato2=new Plato();
            plato2.Nombre="Sandwich de milanesa con jamon y queso";
            plato2.Ingredientes=new List<Ingrediente>{
                ingrediente3,ingrediente4,ingrediente5
            };
            plato1.Ingredientes.Add(ingrediente7); 
            //plato1.Ingredientes.RemoveAt(3);
            plato1.Ingredientes.Remove(ingrediente1);
            Console.WriteLine(plato1.Nombre);
            foreach(var x in plato1.Ingredientes){
                Console.WriteLine(x.Nombre + " " + x.Precio );
            }
            Console.WriteLine("El costo del plato 1 es: " + plato1.Costo );
        }
    }

    public class Ingrediente{
        public string Nombre{get;set;}
        public double Precio{get;set;}
    }

    public class Plato{
        public List<Ingrediente> Ingredientes {get;set;}
        public string Nombre{get;set;}

        public double Costo{
            get{
                double costo=0;
                //costo=Ingredientes.Sum(x=> x.Precio);
                foreach(var x in Ingredientes){
                    costo+=x.Precio;
                }
                return costo;
            }
        }
    }
}
