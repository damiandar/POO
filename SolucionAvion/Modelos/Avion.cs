namespace Modelos
{
    public class Avion
    {
        private Piloto Piloto;
        private List<Pasajero> Pasajeros;
        private List<Tcp> Tripulacion;
        public Avion(){
            Pasajeros=new List<Pasajero>();
            Tripulacion=new List<Tcp>();
            Piloto=new Piloto();
        }
        public void Abordar(Persona persona){
            if(persona.GetType()==typeof(Pasajero)){
                Pasajeros.Add((Pasajero)persona);
            }
            else if(persona is Tripulante){
                if(persona.GetType()==typeof(Tcp)){
                    Tripulacion.Add((Tcp)persona);
                }
                else{
                    Piloto=(Piloto)persona;
                    
                }
            }
        }
        public void Reporte(){
            this.Piloto.SaludoOficial();
            foreach(var tcp in Tripulacion){
                 tcp.SaludarCordialmente() ;
            }
        }
    }
}