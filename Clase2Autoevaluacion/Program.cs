using System;
using System.Collections.Generic;

namespace Clase2Autoevaluacion
{
    class Program
    {
        static void Main(string[] args)
        {
            var empleado1=new Empleado("Marina","Lopez",271219992,20000,1,5);
            var empleado2=new Empleado("Laura","Alonso",9991211,24000,0,7);
            var empleado3=new Empleado("Juan","Martinez",928281,17000,2,3);



            var liquidador=new Liquidador();
            liquidador.AgregarEmpleados(empleado1);
            liquidador.AgregarEmpleados(empleado2);
            liquidador.AgregarEmpleados(empleado3);

            Console.WriteLine(liquidador.TotalSueldos());
        }
    }
    class Empleado{

        public Empleado(string nombre,string apellido, int cuil, int sueldobasico,int hijos,int anios){
            Nombre=nombre;
            Apellido=apellido;
            CUIL=cuil;
            SueldoBasico=sueldobasico;
            Hijos=hijos;
            Antiguedad=anios;
        }
        public string Nombre{get;set;}
        public string Apellido{get;set;}
        public string Cargo{get;set;}
        public int CUIL {get;set;}

        public int Hijos {get;set;}
        public int Antiguedad{get;set;}

        public int SueldoBasico {get;set;}

        public int LiquidarSueldo(){
            var sueldoliquidado=SueldoBasico;
            sueldoliquidado+= CalcularAsignacion();
            sueldoliquidado+=Antiguedad * 50;
            return sueldoliquidado;
        }

        private int CalcularAsignacion(){
            return Hijos * 100;
        }

    }

    class Liquidador{
        public List<Empleado> Nomina {get;set;}

        public void AgregarEmpleados(Empleado emple){
            if(Nomina==null)
                Nomina=new List<Empleado>();
            Nomina.Add(emple);
        }

        public int TotalSueldos(){
            var total=0;
            foreach(var emple in Nomina){
                total+=emple.LiquidarSueldo();
            }
            return total;
        }

        public void ImprimirNomina(){

        }
    }
}
