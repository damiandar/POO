using System;
using System.Collections.Generic;

namespace ProyClase3HerenciaRegion
{
    class Program
    {
        static void Main(string[] args)
        {
            var Continente1=new Continente();
            Continente1.Nombre="America del sur";
            Continente1.Paises=new List<Pais>();

            var pais1=new Pais();
            pais1.Nombre="Argentina";
            
            pais1.Ciudades=new List<Ciudad>();
            pais1.Ciudades.Add(new Ciudad(){ Nombre="Buenos Aires", Superficie=300, CiudadCapital=true });

            var CiudadCordoba=new Ciudad();
            CiudadCordoba.Nombre="Cordoba";
            CiudadCordoba.CiudadCapital=false;
            CiudadCordoba.Superficie=350;

            pais1.Ciudades.Add(CiudadCordoba);

            var Brasil=new Pais();
            Brasil.Ciudades=new List<Ciudad>();
            Brasil.Ciudades.Add(new Ciudad(){ Nombre="San Pablo",Superficie=200, CiudadCapital=false});
            Brasil.Ciudades.Add(new Ciudad(){ Nombre="Rio de Janeiro",Superficie=150, CiudadCapital=false});

            var pais2=new Pais();
            pais2.Nombre="EEUU";
            pais2.Ciudades=new List<Ciudad>();
            pais2.Ciudades.Add(new Ciudad(){Nombre="Baltimore",Superficie=100, CiudadCapital=false});
            pais2.Ciudades.Add(new Ciudad(){Nombre="Filadelfia",Superficie=100,CiudadCapital=false});

     

            Continente1.Paises.Add(pais1);
            Continente1.Paises.Add(Brasil);

            var continente2=new Continente();
            continente2.Nombre="America del norte";
            continente2.Paises=new List<Pais>();
            continente2.Paises.Add(pais2);

            

            Console.WriteLine(Continente1.CalcularSuperficie());
        }
    }

    public  class Region {
        public string Nombre {get;set;}
        public int Superficie {get;set;}

        public Region(){

        }
        public Region(string nombre,int superficie){
            Nombre=nombre;
            Superficie=superficie;
        }
       
    }

    public class Pais: Region {
        public Pais(){
            Ciudades=new List<Ciudad>();
        }
        public Pais(string nombre,int superficie):base(nombre,superficie)  {
       
            Ciudades=new List<Ciudad>();
        }
        public string OrganizacionPolitica {get;set;}
        public string Idioma {get;set;}
        public List<Ciudad> Ciudades {get;set;}

        public  int CalcularSuperficie(){
            
            foreach(var ciudad in this.Ciudades){
                Superficie+=ciudad.Superficie;
            }
            return Superficie;
        }
    }
    public class Ciudad: Region {
        public Ciudad(){

        }
        public Ciudad(string nombre,int superficie):base(nombre,superficie){
 
        }
        public bool CiudadCapital {get;set;}

        public  int CalcularSuperficie(){
            return Superficie;
        }
        
    }

    public class Continente:Region {
        public Continente(){
            Paises=new List<Pais>();
        }
        public Continente(string nombre,int superficie):base(nombre,superficie){
            Paises=new List<Pais>();
        }
        public List<Pais> Paises{get;set;}

             public  int CalcularSuperficie(){
                
                foreach(var item in this.Paises){
                    Superficie+=item.CalcularSuperficie();
                }
                 
                 return Superficie;
             }
    }
}
