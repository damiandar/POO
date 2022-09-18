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
            //var compu1=new Computadora();
            macbook.MostrarEspecificaciones();
            //macbook.Fabricante="";

            var pc=new PcEscritorio();


            Console.WriteLine(macbook.GetType().ToString());
            Console.WriteLine(macbook.GetType()==typeof(Notebook));
            Console.WriteLine(macbook.GetType()==typeof(PcEscritorio));
            Console.WriteLine(macbook is Notebook);
             Console.WriteLine(macbook is PcEscritorio);
            Console.WriteLine(macbook is Computadora);

            Console.WriteLine(pc.GetType().ToString());
            Console.WriteLine(pc.GetType()==typeof(Notebook));
            Console.WriteLine(pc.GetType()==typeof(PcEscritorio));
            Console.WriteLine(pc is Notebook);
            Console.WriteLine(pc is PcEscritorio);
            Console.WriteLine(pc is Computadora);
            
            
        }

        static void ImprimirConfiguracion(Computadora c){
            //si es notebook, muestro cant de celdas
            //c.GetType()==typeof(Notebook)
            if(c is Notebook){
                Console.WriteLine("cantidad de celdas es: " +   ((Notebook)c).Bateria.Celdas );
            }
            else if(c.GetType()==typeof(PcEscritorio)){
                Console.WriteLine("la marca de la fuente es: " + ((PcEscritorio) c).Fuente.Marca );
            }
            //si es pc escritorio, muestro marca fuente
        }
    }

    public abstract class Computadora{
        public Procesador Procesador{get;set;}
        public int Memoria {get;set;}

        private string ClaveSeguridad{get;set;}

        protected string Fabricante{get;set;}
        public Disco Disco{get;set;}

        public Monitor Monitor{get;set;}

        public abstract void Encender();

        //public abstract void Apagar();

        public void MostrarEspecificaciones(){
            Console.WriteLine("La computadora tiene memo:" + Memoria + "Clave:" + ClaveSeguridad + "Fabricante" + Fabricante );
        }

    }

    public class PcEscritorio:Computadora{
        public string Gabinete{get;set;}
        public Fuente Fuente{get;set;}

        public override void Encender(){
            Console.WriteLine("se enciende la pc escritorio");
        }
 
    }

    public class Notebook:Computadora{
        public Bateria Bateria{get;set;}

        public override void Encender()
        {
            Console.WriteLine("se enciende la notebook" + Fabricante);
            //ClaveSeguridad
        }

        public enum mouse{
            touchPad,
            trackPoint
        }

        public mouse Mouse{get;set;}
    }

    public class CompuAuto:Computadora{
        public override void Encender()
        {
            Console.WriteLine("se enciende la computadora del auto cuando pongo la llave en el auto");
        }
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
