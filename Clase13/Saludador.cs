namespace Clase13
{
    public class Saludador<T>  where T : PersonaIdioma
    {
        public void hacersaludo(T persona){
            persona.Saludar();
        }
    }
    
    public abstract class PersonaIdioma{
        public abstract void Saludar();
    }
    public class HispanoParlante: PersonaIdioma{
        public override void Saludar(){

        }
    }

    public class Chino: PersonaIdioma{
        public override void Saludar(){

        }
    }
}