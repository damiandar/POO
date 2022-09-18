using System;
using System.Collections.Generic;
using System.Linq;

namespace Cohete
{
    class Program
    {
        static void Main(string[] args)
        {
            var rover=new Rover();
            var telescopio=new Telescopio();
            var tanqueagua1=new Agua();
            var tanqueagua2=new Agua();
            var mision1=new MisionInvestigacion("Mision Luna");
            mision1.Agregar(rover);

            var mision2=new MisionAprovicionamiento("Mision Estacion Espacial");
            try{
                mision2.Agregar(rover);
                mision2.Agregar(tanqueagua2);
            }
            catch(Exception ex){
                //Console.WriteLine("Error al agregar un equipo a la mision de aprovicionamiento" + ex.Message.ToString());
                Console.WriteLine(ex.Message.ToString());
            }
            

            var mision3=new MisionColonizacion("Mision a Marte");
            mision3.Agregar(rover);
            mision3.Agregar(telescopio);
            mision3.Agregar(tanqueagua1);

            var cohete1=new Cohete("SpaceX",new Motor(4),mision1);
            var cohete2=new Cohete("BlueOrigin",new Motor(3),mision2);
            var cohete3=new Cohete("Virgin Galactic",new Motor(5),mision3);

            Console.WriteLine(cohete1.Fabricante + " " + cohete1.CalcularCarga() );
            Console.WriteLine(cohete2.Fabricante + " " + cohete2.CalcularCarga() );
            Console.WriteLine(cohete3.Fabricante + " " + cohete3.CalcularCarga() );

        }

    }

    public class Cohete{
        public string Fabricante{get;set;}
        public Motor Motor {get;set;}
        public Mision Mision { get; set; }

        public Cohete(string fab,Motor motor,Mision mision){
            Fabricante=fab;
            Motor=motor;
            Mision=mision;
        }
        public int CalcularCarga(){
            var pesocohete=0;
            pesocohete+=this.Motor.Peso;
            pesocohete+=this.Mision.PesoTotal;
            return pesocohete;
        }
    }

    public class Motor{
        public int Peso{get;set;}
        public Motor(int peso){
            Peso=peso;
        }
    }
    public abstract class Mision{
        private string Nombre;
        public Mision(string nombre) {
            Nombre=nombre;
        }
        public abstract void Agregar(Equipo equipo);
        public abstract int PesoTotal {get;}
    }

    public class MisionInvestigacion :Mision{
        public MisionInvestigacion(string nombre):base(nombre){

        }
        public Rover Rover {get;set;}

        public override void Agregar(Equipo equipo){
            this.Rover=(Rover)equipo;
        }
        public override int PesoTotal{
            get{
                return this.Rover.Peso;
            }
        }

    }
    public class MisionColonizacion:Mision {
        public MisionColonizacion(string nombre):base(nombre){

        }

        private List<Equipo> equipos;
        public override void Agregar(Equipo equipo){
            if(equipos is null)
                equipos=new List<Equipo>();
            equipos.Add(equipo);
        }
        public override int PesoTotal{
            get{
                return equipos.Sum(x=> x.Peso);
            }
        }
    }

    public class MisionAprovicionamiento:Mision{
        public MisionAprovicionamiento(string nombre):base(nombre){

        }

        private List<Agua> Contenedores;
        public override void Agregar(Equipo equipo){
            if(Contenedores is null)
                Contenedores=new List<Agua>();
            
            if(equipo.GetType()!=typeof(Agua))
                throw new Exception("El equipo que está intentando agregar no es del tipo agua.");
            Contenedores.Add((Agua)equipo);
        }

        public override int PesoTotal{
            get{
                if(Contenedores is null)
                    return 0;
                return Contenedores.Sum(x=> x.Peso);
            }
        }
    }

    public abstract class Equipo {
        public abstract int Peso{get;}
    }

    public class Rover:Equipo {
        public override int Peso{
            get {return 1;}
        }
    }
    public class Agua:Equipo {
        public override int Peso{
            get {return 5;}
        }
    }
    public class Telescopio:Equipo {
        public override int Peso{
            get {return 6;}
        }
    }



}
