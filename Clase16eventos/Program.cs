using System;

namespace Clase16eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            var auto=new Auto();
            auto.Velocidad=121;
            auto.ExcesoVelocidad +=SacarFotoMulta;
            //auto.ExcesoVelocidad -=SacarFotoMulta;
            auto.Acelerar(); 
            
        }

        static void SacarFotoMulta(int velocidad){
            Console.WriteLine("Peligro Su velocidad es de: " + velocidad );
        }
    }

    public class Auto{
        public delegate void EjemploDelegado();
        public event EjemploDelegado ejemploEvento;

        public delegate void DelegadoExcesoVelocidad(int velocidad);
        public event DelegadoExcesoVelocidad ExcesoVelocidad;

        public void Activar(){
            this.ejemploEvento();
        }

        public int Velocidad {get;set;}
        public void Acelerar(){
            if(ExcesoVelocidad !=null){
                if(this.Velocidad>120){
                    this.ExcesoVelocidad(Velocidad);
                }
            }
            else{
                Console.WriteLine("No hay suscriptores para este evento");
            }

        }

    }
}
