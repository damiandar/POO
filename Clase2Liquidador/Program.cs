using System;
using System.Collections.Generic;

namespace Clase2Liquidador
{
    class Program
    {
        static void Main(string[] args)
        {
        
            var empleado1 =new Empleado("Romina","Perez",5,1,20000);
            var empleado2=new Empleado("Marcos","Salvatori",3,0,15000);
            var empleado3=new Empleado("Laura","Alonso",2,1,10000);
            empleado3.NroCta=1111;
            
            var empresa=new Empresa();
            empresa.AgregarEmpleado(empleado1);
            empresa.AgregarEmpleado(empleado2);
            empresa.AgregarEmpleado(empleado3);

            empresa.Liquidar();
        }
    }

    public class Empleado{
        
        private int nrocta;

        public int NroCta{
            get{return nrocta;}
            set {nrocta=value;}
        }

        public Empleado(string nombre,string apellido,int antiguedad,int hijos,double basico){
            this.Nombre=nombre;
            this.Apellido=apellido;
            this.Antiguedad=antiguedad;
            this.CantidadHijos=hijos;
            this.Sueldo=new Sueldo(basico); 
        }
        public string Nombre{get;set;}
        public string Apellido {get;set;}
        public int Antiguedad {get;set;}
        public string Cargo {get;set;}

        public string CUIL {get;set;}
        public int CantidadHijos {get;set;}

        public Sueldo Sueldo{get;set;}

        public string NombreCompleto{
            get { return this.Nombre + this.Apellido ;}
        }
 
    }
    public class Sueldo{

        public Sueldo(double basico){
            this.Basico=basico;
        }
        private double Basico {get;set;}
        private double BonificacionAntiguedad(int anios){
            var bonificacion= anios * 50;
            return bonificacion;
        }
        private double BonificacionAsignacion(int canthijos){
            return canthijos * 100;
        }

        public double CalcularSueldo(int anios,int canthijos){
            var sueldo=BonificacionAntiguedad(anios);
            sueldo+=BonificacionAsignacion(canthijos);
            return this.Basico + sueldo;
        }
    }
    public class Empresa{
        
        private List<Empleado> Empleados{get;set;}

        //metodo
        public int CantidadEmpleados(){
            return Empleados.Count;
        }

        //Propiedad
        public int CantEmpleados {
            get { return Empleados.Count;}
        }

        public void AgregarEmpleado(Empleado empleado){
            if(Empleados is null){
                Empleados=new List<Empleado>();
            }
            Empleados.Add(empleado);
        }
        public void Liquidar(){
            double totalliquidacion=0;
            foreach(var emp in this.Empleados){
                var sueldoconbonificacion=emp.Sueldo.CalcularSueldo(emp.Antiguedad,emp.CantidadHijos);
                totalliquidacion+=sueldoconbonificacion;
                Console.WriteLine(emp.NombreCompleto+ ": " + sueldoconbonificacion);
            }
            Console.WriteLine("Total en sueldos:" + totalliquidacion);

        }
    }
}
