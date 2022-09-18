using System;
using System.Collections.Generic;

namespace Clase6POOLavadero
{
    class Program
    {
        static void Main(string[] args)
        {
            var lavadero=new Lavadero();
            lavadero.Agregar(new AutoMovil(1){});
            lavadero.Agregar(new AutoMovil(2){});
            lavadero.Agregar(new AutoMovil(3){});
            lavadero.Agregar(new AutoMovil(4){});
            lavadero.Agregar(new AutoMovil(5){});
            lavadero.Agregar(new Moto(6){});
            lavadero.Agregar(new Moto(7){});
            lavadero.Agregar(new AutoMovil(8){});
            lavadero.Agregar(new AutoMovil(9){});
            lavadero.Agregar(new AutoMovil(10){});

            Console.WriteLine( lavadero.LavarTodos());
        }

        class Lavadero{
            public Lavadero(){
                this.Vehiculos=new List<Vehiculo>();
            }
            private List<Vehiculo> Vehiculos {get;set;}

            public void Agregar(Vehiculo veh){
                this.Vehiculos.Add(veh);
            }

            public double LavarTodos(){
                double totalRecaudado=0;
                foreach (var veh in this.Vehiculos)
                {
                    if(veh.GetType()==typeof(AutoMovil)){
                        totalRecaudado+=500;
                        veh.Lavar();
                    }
                    if(veh.GetType()==typeof(Moto)){
                        totalRecaudado+=350;
                        veh.Lavar();
                    }
                }
                return totalRecaudado;
            }
        }

       abstract class Vehiculo{
            #region Propiedades
            public Vehiculo(int id){
                this.id=id;
                this.Lavado=false;
            }
            private int id;
            public int Id {get {return id;}}
            public bool Lavado {get;set;}
            #endregion

            #region  Metodos 
            public abstract void Lavar();

            #endregion
        }

        class Moto: Vehiculo {
            public Moto(int id):base(id){

            }
            public override void Lavar(){
                this.Lavado=true;
            }
        }

        class AutoMovil: Vehiculo {
            public AutoMovil(int id):base(id){

            }
            public override void Lavar(){
                this.Lavado=true;
            }
        }
    }
}
