using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantClase7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Restaurante");
            var miresturante=new Restaurante();
            var michef=new Chef();
            var repostero=new Repostero();
            miresturante.SacarPlato(michef);
            miresturante.SacarPlato(michef);
            miresturante.SacarPlato(repostero);

            Console.WriteLine(miresturante.CostoTotal);
            Console.ReadKey();
        }
    }

    public class Ingrediente {
        public Ingrediente(){

        }
        public Ingrediente(string nombre, double precio){
            this.Nombre=nombre;
            this.Precio=precio;
        }
         
        public string Nombre{get;set;}
        public double Precio { get; set; }
    }
    public class Plato{
        public Plato(){
            //Ingredientes=new List<Ingrediente>();
        } 
        public void AgregarIngrediente(Ingrediente ingred){
            try {
                this.Ingredientes.Add(ingred);
            }
            catch(NullReferenceException ex)
            {
                this.Ingredientes = new List<Ingrediente>();
                this.Ingredientes.Add(ingred);
            }
            catch(Exception ex)
            {
                var excep = ex;
            }
                
        }

        private List<Ingrediente> Ingredientes;
        
        public double Costo{
            get {
                double total=0;
                total=Ingredientes.Sum(x=>x.Precio);
                //foreach (var ingred in this.Ingredientes)
                //{
                //    total+=ingred.Precio;
                //}
                return total;
            }
        }
    }

    public class Restaurante{
        private double costoTotal;

        public double CostoTotal {
            get {
                return costoTotal;
            } 
        }


        public Plato SacarPlato(Cocinero cocinero){
            var plato=cocinero.PrepararPlato();
            costoTotal+=plato.Costo;
            return plato;
        }

        public void ValorCubierto(){
            costoTotal+=100;
        }
    }

    public abstract class Cocinero {
        public abstract Plato PrepararPlato();
    }

    public class Chef: Cocinero{
        public override Plato PrepararPlato(){
            var pastelcarne=new Plato();
            pastelcarne.AgregarIngrediente(new Ingrediente(){ Nombre="Carne", Precio=700});
            pastelcarne.AgregarIngrediente(new Ingrediente(){ Nombre="Condimentos", Precio=300});
            pastelcarne.AgregarIngrediente(new Ingrediente(){ Nombre="Papa", Precio=100});
            return pastelcarne;
        }
    }

    public class Repostero:Cocinero {
        public override Plato PrepararPlato(){
            var torta=new Plato();
            torta.AgregarIngrediente(new Ingrediente(){ Nombre="huevos", Precio=200});
            torta.AgregarIngrediente(new Ingrediente(){ Nombre="Harina", Precio=150});
            torta.AgregarIngrediente(new Ingrediente("Dulce de leche",200));
            torta.AgregarIngrediente(new Ingrediente("Crema",150));
            return torta;
        }
    }
}
