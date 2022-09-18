using System;

namespace ProyEventosClase11
{
    class Program
    {
        static void Main(string[] args)
        {
            var miauto=new Auto();
            miauto.AlarmaPuesta=true;
            //miauto.SonarAlarma +=EscucharAlarma;
            miauto.SonarAlarma +=MirarAuto;
            miauto.AbrirPuerta();

        }
        static void EscucharAlarma(){
            Console.WriteLine("LLamar a la policia");
        }
        static void MirarAuto(){
            Console.WriteLine("Mirar el auto si la cerradura esta forzada");
        }
    }

    class Auto{
        public delegate void TipoDelegadoAlarma();
        public event TipoDelegadoAlarma SonarAlarma;
        public bool AlarmaPuesta{get;set;}
        public void AbrirPuerta(){
            if(AlarmaPuesta)
                SonarAlarma();
        }

    }
}
