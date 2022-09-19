namespace Modelos
{
    public abstract class Tripulante: Persona
    {
         public Tripulante(){}
        public Tripulante(int DNI,string Nombre,string Apellido):base(DNI,Nombre,Apellido){
            
        }

        protected void Saludar(){
            Console.WriteLine("Hola pasajeros mi nombre es " + this.Nombre );
        }
        //lo puedo usar en derivadas y en avion.
        protected internal void Despedir(){
            Console.WriteLine("Despedir");
        }
    }
    public sealed class Tcp:Tripulante {
        public Tcp(int DNI,string Nombre,string Apellido):base(DNI,Nombre,Apellido){
            
        }
        //no se ve desde el programa
        internal void SaludarCordialmente(){
            base.Saludar();
            
        }
        
    }
    public sealed class Piloto:Tripulante{
        public Piloto(){

        }
        public Piloto(int DNI,string Nombre,string Apellido):base(DNI,Nombre,Apellido){
            
        }

        public void SaludoOficial(){
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            base.Saludar();
            
            Console.WriteLine(" y soy el piloto de este vuelo.");
            Console.ForegroundColor=ConsoleColor.White;
        }
    }

    
}