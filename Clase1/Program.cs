using System;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            var telefono1= new Telefono();
            telefono1.Color="plateado";
            telefono1.Marca="Apple";
            telefono1.Modelo="7";
            telefono1.NroImei=8282832;

            var pudollamar= telefono1.LLamar(1151113421);
            if(pudollamar)
            {
                Console.WriteLine("llamada OK");
            }
            else{
                Console.WriteLine("no pudo llamar");
            }
            telefono1.SacarFoto();

            var telefonoAnterior=new Telefono();
            telefonoAnterior.Color="negro";
            telefonoAnterior.Marca="Motorola";
            telefonoAnterior.Modelo="Milestone";

            Console.WriteLine(telefonoAnterior.Color);
            telefonoAnterior.SacarFoto();

            Telefono telefono2=new Telefono();
            telefono2.Color="azul";
 


        }
    }

    class Telefono
    {
        //atributos
        public string Color {get;set;}
        public string Marca {get;set;}
        public int NroImei{get;set;}

        public string Modelo {get;set;}


        //comportamiento: METODOS
        public bool LLamar(int telDestino){
            if(telDestino==11111111){
                Console.WriteLine("El siguiente telefono no corresponde a una linea " );
                return false;
            }
            else{
                Console.WriteLine("llamando al " + telDestino );
                return true;
            }    
            
        }

        public void EscucharMusica(string Tema){
            Console.WriteLine("Reproduciendo el tema " +Tema );
        }

        public void SacarFoto(){
            //sacando foto
            //implementacion del metodo
        }



    }
}
