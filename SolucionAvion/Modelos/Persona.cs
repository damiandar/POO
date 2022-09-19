namespace Modelos
{
    public abstract class Persona
    {
        public Persona(){

        }
        public Persona(int DNI, string Nombre){
            this.DNI=DNI;
            this.Nombre=Nombre; 
        }
         public Persona(int DNI, string Nombre,string Apellido):this(DNI,Nombre){
            
            this.Apellido=Apellido;
        }
        public int DNI {get;set;}
        public string Apellido {get;set;}
        public string Nombre{get;set;}
    }
}