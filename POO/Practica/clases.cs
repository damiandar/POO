using System.Collections.Generic;
using System.Linq;

namespace Practica
{
    public class Ingrediente
    {
        public Ingrediente(string nombre, double costo){
            this.Nombre=nombre;
            this.Costo=costo;
        }
        public string Nombre{get;set;}
        public double Costo{get;set;}

    }

    public class Plato{

        private bool servicio;
        public bool Servicio{get {return servicio;}}
        public void Servir(){
            servicio=true;
        }
        private List<Ingrediente> Ingredientes;
        public double Costo {get {
            return Ingredientes.Sum(x=>x.Costo);
        }}

        public void AgregarIngrediente(Ingrediente ing){
            if (Ingredientes==null)
                Ingredientes=new List<Ingrediente>();
            Ingredientes.Add(ing);
        }
    }

    public abstract class Cocinero{
        public abstract Plato PrepararPlato();

    }

    public class Chef: Cocinero{
        public override Plato PrepararPlato()
        { 
            var plato=new Plato();
            plato.AgregarIngrediente(new Ingrediente("Arroz",100) );
            plato.AgregarIngrediente(new Ingrediente("Pollo",300) );
            return plato;
        }
    }
    public class Repostero: Cocinero{
        public override Plato PrepararPlato()
        { 
            var plato=new Plato();
            plato.AgregarIngrediente(new Ingrediente("Crema",200) );
            plato.AgregarIngrediente(new Ingrediente("Dulce de leche",150) );
            plato.AgregarIngrediente(new Ingrediente("Harina",100));
            plato.AgregarIngrediente(new Ingrediente("Huevos",50));
            return plato;
        }
    }

    public class Restaurante{
        public delegate void TipoDelegado();
        TipoDelegado delServir;
        private double costototal;
        public double CostoTotal{
            get { return costototal;}
        }
        public Plato SacarPlato(Cocinero cocinero){
            var plato= cocinero.PrepararPlato();
            costototal+=plato.Costo;
            delServir+=plato.Servir;
            return plato;
        }

        public void ServirPlatos(){
            delServir();
        }
        /*
        private List<Mesa> Mesas;

        public void AgregarMesa(Mesa mesa){
            if(Mesas==null)
                Mesas=new List<Mesa>();
            Mesas.Add(mesa);
        }*/

    }

    public class Mesa{
        private List<Plato> platos;

        public void AgregarPlato(Plato plato){
            if(platos==null)
                platos=new List<Plato>();
            platos.Add(plato);
            
        }

        public double Cuenta(){
            if(platos==null)
                return 0;
            var platosServidos= platos.Where(x=>x.Servicio==true);
            if(platosServidos!=null && platosServidos.Count()>0)
                return platosServidos.Sum(x=>x.Costo);
            return 0;
        }
    }

}