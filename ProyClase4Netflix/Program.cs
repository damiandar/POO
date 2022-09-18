using System;
using System.Collections.Generic;

namespace ProyClase4Netflix
{
    class Program
    {
        static void Main(string[] args)
        { 

        }
    }

    public class Film{
        public string Nombre{get;set;}
        public int Duracion {get;set;}

        public string Origen {get;set;}

        public int Anio {get;set;}
        public string BandaSonido {get;set;}
         public enum TipoGenero {
            Comedia,
            Suspenso,
            Terror,
            Documental
        }
    public TipoGenero Genero {get;set;}
    }
    public class Pelicula:Film{
        public List<Actor> Actores {get;set;}
      
    
    }

    public class Documental:Film{
        public enum TipoTematica{
            Bio,
            Historico,
            Naturaleza
        }
        public TipoTematica Tematica {get;set;}
    }

    public class Serie:Film{
        
        public List<Actor> Actores {get;set;} 
        public List<Temporada> Temporadas {get;set;}
    }
    public class Temporada{
        public List<Capitulo> Capitulos{get;set;}
        public int Nro {get;set;}

        public int CantCapitulos{
            get {
                return Capitulos.Count;
            }
        }

        public int CalcularCantCapitulos(){
            return Capitulos.Count;
        }

    }
    public class Capitulo {
        public string Titulo{get;set;}
        public int Duracion{get;set;}
        public int Numero{get;set;}
        
    }
    public class Actor{
        public string Nombre{get;set;}
        public string Apellido{get;set;}
    }

}
