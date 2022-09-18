using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyClase8Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            var restaurante=new Restaurante();
            var chef=new Chef();
            var repostero=new Repostero();

            restaurante.SacarPlato(chef);
            restaurante.SacarPlato(repostero);
            restaurante.SacarPlato(repostero);
            //restaurante.CostoTotal=3000;
            Console.WriteLine(restaurante.CostoTotal);
        }
    }

    public class Ingrediente{

        public Ingrediente(string nombre, double costo){
            Nombre=nombre;
            Costo=costo;
        }
        public string Nombre{get;set;}
        public double Costo{get;set;}
    }

    public class Plato{
        private List<Ingrediente> Ingredientes;
        public double Costo{
            get{
                var costo=Ingredientes.Sum(x=>x.Costo);
                return costo;
            }
        }

        public void AgregarIngrediente(Ingrediente ing){
            if(Ingredientes is null)
                Ingredientes=new List<Ingrediente>();
            Ingredientes.Add(ing);
        }
    }

    public abstract class Cocinero {
        public abstract Plato PrepararPlato();

    }

    public sealed class Chef :Cocinero {
        public override Plato PrepararPlato( )
        {
            var pizza=new Plato();
            pizza.AgregarIngrediente(new Ingrediente("muzzarella",100));
            pizza.AgregarIngrediente(new Ingrediente("salsa",50));
            var aceitunas=new Ingrediente("aceitunas",70);
            pizza.AgregarIngrediente(aceitunas);
            return pizza;
        }
    }

    public sealed class Repostero:Cocinero{
        public override Plato PrepararPlato()
        {
            var torta=new Plato();
            torta.AgregarIngrediente(new Ingrediente("Dulce de leche",150));
            torta.AgregarIngrediente(new Ingrediente("crema",100));
            torta.AgregarIngrediente(new Ingrediente("Harina",80));
            return torta;
        }
    }
    public class Restaurante{
        public double CostoTotal{get;private set;}
        public Plato SacarPlato(Cocinero cocinero){
            var plato=cocinero.PrepararPlato();
            CostoTotal+=plato.Costo;
            return plato;
        }
    }





    
}
