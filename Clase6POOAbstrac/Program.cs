using System;
using System.Collections.Generic;


namespace Clase6POOAbstrac
{
    class Program
    {
        static void Main(string[] args)
        {
            //var compu=new Computadora();
            var compu=new Notebook();
            compu.Disco=new Disco(){ Tipo= Disco.tipos.SSD, Capacidad=512};
            compu.Procesador=new Procesador() { Velocidad=2.4};
            compu.Bateria=new Bateria(6,4);
            compu.Apagar();
            compu.Encender();

            var compu2=new PcEscritorio();
            compu2.Disco=new Disco() {Tipo=Disco.tipos.HDD,Capacidad=1024};
            compu2.Fuente=new Fuente() { Certificada=true, Watts=500};
            compu2.Perifericos=new List<Periferico>();
            compu2.Perifericos.Add(new Monitor(){Resolucion=1080, Pulgadas=20, Conexion=Periferico.conexion.HDMI});
            compu2.Perifericos.Add(new Camara() {Resolucion=12, Conexion=Periferico.conexion.USB} );
            compu2.Perifericos.Add(new Teclado(){Tipo= Teclado.tipo.Mecanico,Conexion=Periferico.conexion.USB,Idioma=Teclado.idioma.ESP});

            Console.WriteLine(compu2.Perifericos.Count);

            foreach (var per in compu2.Perifericos)
            {
                //MostarTipos(per);
                ImprimirPeriferico(per);
            }

            compu2.Apagar();
            compu2.Encender();
        }

        static void MostarTipos(Periferico perif){
            Console.WriteLine(perif.GetType().ToString());
            Console.WriteLine(perif.GetType() == typeof(Camara) );
            Console.WriteLine(perif is Periferico);
        }

        static void ImprimirPeriferico(Periferico perif){
              if(perif.GetType()==typeof(Monitor)){
                //si es un monitor me imprima las pulgadas
                Console.WriteLine(((Monitor)perif).Pulgadas);
            }

            if(perif.GetType()==typeof(Camara)){
                //si es una camara me imprima resolucion
                Console.WriteLine(((Camara)perif).Resolucion);
            }
            if(perif.GetType()==typeof(Teclado)){
                //si es teclado me imprima el idioma
                Console.WriteLine(((Teclado)perif).Idioma);
            }

        }
    }

    abstract class Computadora{
        public string Marca {get;set;}
        public string Modelo {get;set;}
        public Disco Disco {get;set;}
        public Procesador Procesador {get;set;}
        public List<Periferico> Perifericos {get;set;}
        public void Apagar(){
            Console.WriteLine("apagar computadora");
        }
    
        public abstract void Encender();
    }

     class Notebook :Computadora {
         public Bateria Bateria {get;set;}

         public enum mouse {
             touchPad,
             trackPoint
         }
         public mouse Mouse {get;set;}
         public override void Encender(){
             //dar comportamiento
             Console.WriteLine("Compu encendida");
         }
    }

    class PcEscritorio: Computadora {
        public Fuente Fuente {get;set;}
        public override void Encender(){
            Console.WriteLine("Compu encendida: " + Fuente.Watts);
        }
    }

    class Disco {
        public int Capacidad {get;set;}
        public enum tipos {
            SSD,
            HDD
        }

        public tipos Tipo {get;set;}
    }

    class Procesador {
        public double Velocidad {get;set;}
    }

    class Fuente {
        public int Watts {get;set;}
        public bool Certificada {get;set;}
    }

    class Bateria {
        public Bateria(int duracion, int celdas){
            this.Duracion=duracion;
            this.Celdas=celdas;
        }
        public int Duracion {get;set;}
        public int Celdas {get;set;}
    }

    abstract class Periferico{
        public enum conexion{
            USB,
            ThunderBolt,
            HDMI
        }
        public conexion Conexion {get;set;}

        public abstract void Conectar();
    }

    class Camara : Periferico {
        public int Resolucion{get;set;} 
        public override void Conectar(){
            //implementar
        }
    }

    class Monitor: Periferico {
        public int Pulgadas {get;set;}
        public int Resolucion {get;set;}
        public enum paneles{
            IPS,
            TN,
            VA
        }
        public paneles Paneles {get;set;}
        public override void Conectar(){
            //implementar
        }
    }

   sealed class Teclado: Periferico {
        public enum tipo {
            Mecanico,
            Membrana
        }
        public tipo Tipo {get;set;}

        public enum idioma {
            ESP,
            ENG,
            LA
        }
        public override void Conectar(){
            //implementar
        }
        public idioma Idioma {get;set;}
    }


    //class TecladoGamer :Teclado{

    //}





}
