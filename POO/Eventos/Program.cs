using System;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
          Auto miauto=new Auto();
         
            //suscripcion
          miauto.SonarAlarma +=EscucharAlarma;
          miauto.SonarAlarma +=MirarAlAuto;


          miauto.AlarmaPuesta=true;
          miauto.AbrirPuerta();

        }

        static void EscucharAlarma(){
            Console.WriteLine("LLamar a la policia");
        }

        static void MirarAlAuto(){
            Console.WriteLine("miro el auto si tiene la cerradura forzada");
        }
    }


    class Auto{

        public delegate void TipoDelegadoAlarma();

        public event TipoDelegadoAlarma SonarAlarma;
        public bool AlarmaPuesta{get;set;}
        public void AbrirPuerta(){
            if(AlarmaPuesta){
                //sonar alarma
                SonarAlarma();
            }
        }
    }
}
