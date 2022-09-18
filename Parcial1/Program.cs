using System;
using System.Collections.Generic;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var empleado1=new persona();
            //empleado1.Sueldo=20000;

        }
    }

    public abstract  class persona{

        public int DNI { get; set; }
        public string Nombre {get;set;}
        public string Apellido { get; set; }
        public int Legajo {get;set;}
        public double Sueldo {get;set;}

        public int Descansar(){
            //comportamiento
            //calculos

            return 0;
        }

        public int Trabajar(int horas){
            return 1;
        }
        public virtual int Trabajar(){
            var productividad=1;
            return productividad;
        }

    }

    interface IControlar
    {
        void ControlarPersonal();

    }

    public class Gerente:  Jefe , IControlar {
        public List<Supervisor> Supervisores {get;set;}

        public void ControlarPersonal(){
        //controlar supervisores
        }
    }

    public class Director: Gerente {
        
    }
    public class Supervisor: Jefe ,IControlar {
        public void ControlarPersonal(){
            //controlo a empleados
        }
    }
    public class Empleado:persona {
        public Empleado(){
            this.Sueldo=2000;
        }

    }

    public class Jefe: persona { 
        public Jefe(){
            this.Sueldo=3000;
        }
        public List<Empleado> Empleados {get;set;}
        
        public override int Trabajar(){
            var horastrabajadas=0;
            foreach (var emp in this.Empleados)
            {
                horastrabajadas=emp.Trabajar() ;
            }
            return horastrabajadas;
        }
    }
    
    public interface IProducto {
        bool vencido();
        int Codigo {get;set;}
        int Stock {get;set;}
    }
    public abstract class Producto :IProducto{
      public int Codigo {get;set;}
      public virtual bool vencido(){
            //evaluo la fecha
            return true;
        }
      public int Stock {get;set;}
    }
    public abstract class ProductoPerecedero:Producto {
  
        public DateTime FechaVencimiento {get;set;}  
    }

    public abstract class ProductoNoPerecedero:Producto { 
        public override bool vencido(){
            return false;
        }
    }

    public interface INadador{
        void Nadar();
    }
    public interface ICorredor{
        void Correr();
    }
    public interface IVolador{
        void Volar();
    }
    public interface ISerHumano {
        string Nombre {get;set;}
    }
    public interface ISerVivo{

    }

    public class Gaviota :ISerVivo ,INadador,ICorredor,IVolador{
        public void Nadar(){
            //mueve las patas
        }
        public void Correr(){

        }
        public void Volar(){

        }
    }
    public class Pinguino: ISerVivo, INadador,ICorredor {
        public void Nadar(){

        }
        public void Correr(){

        }
    }
    public class Persona: ISerVivo, INadador,ICorredor,ISerHumano{
        public void Nadar(){
            //aplicara distintas tecnicas
        }
        public void Correr(){

        }
        public string Nombre {get;set;}
    }
    public class Pez :ISerVivo,INadador{
        public void Nadar(){
            //mueve aletas
        }
    }

}
