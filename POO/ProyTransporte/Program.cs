using System;

namespace ProyTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
            var avion =new Avion();
            avion.Aterrizo+= AterrizarHandler;
            avion.Acelerar();
            avion.Aminorar();

            var auto=new Auto();
            auto.Estaciono+=EstacionarHandler;
            auto.Acelerar();
            auto.Aminorar();


        }
        static void AterrizarHandler(){
            Console.WriteLine("El avion aterrizo");
        }
        static void EstacionarHandler(){
            Console.WriteLine("Estaciona el auto");
        }

        static void AmarrarHandler(){
            Console.WriteLine("Amarra el barco");
        }
    }


    public abstract class Transporte{
        private int velocidad;
        public int Velocidad{
            get{return velocidad;}
        }
        protected void CambiarVelocidad(int vel){
            this.velocidad+=vel;
            if(this.velocidad==0){
                this.SeDetuvo();
            } 
        }

        public delegate void DelegadoTransporte();

        protected event DelegadoTransporte SeDetuvo;

        public abstract void Acelerar();
        public abstract void Aminorar();
    }

    public class Auto : Transporte
    {
           public event DelegadoTransporte Estaciono;
        public override void Acelerar()
        {
            this.CambiarVelocidad(10);
        }

        public override void Aminorar()
        {
            this.SeDetuvo+=Estaciono; 
            this.CambiarVelocidad(-10);
        }
    }
    public class Avion : Transporte
    {
        public event DelegadoTransporte Aterrizo;

        
        public override void Acelerar()
        {
            this.CambiarVelocidad(10);
        }

        public override void Aminorar()
        {
            
            this.SeDetuvo+=Aterrizo; 
            this.CambiarVelocidad(-10);
        }

    }

    public class Barco : Transporte
    {

   public event DelegadoTransporte Amarro;
        public override void Acelerar()
        {
           this.CambiarVelocidad(5);
        }

        public override void Aminorar()
        {
            this.SeDetuvo+=Amarro; 
            this.CambiarVelocidad(-5);
        }
    }

}
