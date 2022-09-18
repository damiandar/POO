using System;

namespace ProyClase6Productos
{
    class Program
    {
        static void Main(string[] args)
        {
             //var prod=new Producto();

             var lechedescremada=new Leche(DateTime.Now.AddYears(1));
            //lechedescremada.Vencimiento=DateTime.Now.AddYears(1);
            Console.WriteLine(lechedescremada.Vencimiento);
        }
    }

    public abstract class Producto{
        public abstract double Precio{get;set;}
        public abstract int Codigo {get;set;}
    }
    public class ProductoPerecedero:Producto{
        public override double Precio { get;set; }
        public override int Codigo { get;set; }
        /*
        private DateTime vencimiento;
        public  DateTime Vencimiento{
            get {return vencimiento;} 
             
        }
        */

        public DateTime Vencimiento{get;private set;}

        public ProductoPerecedero(DateTime fechavencimiento){
            //vencimiento=fechavencimiento;
            Vencimiento=fechavencimiento;
        }
    }
    public class ProductoNoPerecedero:Producto{
        public override double Precio { get;set; }
        public override int Codigo { get;set; } 
    }
    public sealed class Leche:ProductoPerecedero{

        public Leche(DateTime fecha):base(fecha){

        }
        
    }
    /*
    public class LecheAvena: Leche{

    }
    */
    public class Pan:ProductoPerecedero{

        public Pan(DateTime fecha):base(fecha){

        }
        
    }
    public class Cuchara:ProductoNoPerecedero{
   
    }
    public class Trapo:ProductoNoPerecedero{
   
    }
}
