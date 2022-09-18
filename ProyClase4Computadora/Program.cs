using System;

namespace ProyClase4Computadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //typeof
            //GetType
            //is

            var macbook=new Notebook();
            
            Console.WriteLine(macbook.GetType().ToString());
            Console.WriteLine(macbook.GetType()==typeof(Notebook));
            Console.WriteLine(macbook.GetType()==typeof(PcEscritorio));
            Console.WriteLine(macbook is Notebook);
            Console.WriteLine(macbook is Computadora);
            
            
        }
    }

    public class Computadora{
        public Procesador Procesador{get;set;}
        public int Memoria {get;set;}

        public Disco Disco{get;set;}

        public Monitor Monitor{get;set;}

    }

    public class PcEscritorio:Computadora{
        public string Gabinete{get;set;}
        public Fuente Fuente{get;set;}
 
    }

    public class Notebook:Computadora{
        public Bateria Bateria{get;set;}
    }

    public class Fuente{
        public int Watts{get;set;}
        public string Marca{get;set;}
        public string TipoCertificacion{get;set;}
    
        public double CalcularPrecio(){
            return 0;
        }
    }
    public class Monitor{
        public string Marca{get;set;}
        public bool Incorporado{get;set;}

        public int Pulgadas{get;set;}
    }
    public class Bateria{
        public int Celdas{get;set;}
        public int Duracion{get;set;}
        public double Amperaje{get;set;}
    }

    public class Procesador{
        public int Velocidad{get;set;}
        public string Marca{get;set;}
        public int Nucleos{get;set;}
    }

    public class Disco{
        public int Capacidad{get;set;}
        public enum TipoDisco{
            Solido,
            Rigido
        }

        public TipoDisco Tipo {get;set;}
    }
}
