using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase5Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             var lista1=new List<int>();
             List<int> lista2=new List<int>();
             var lista3=new List<int>(){
                 29,1,60,14,99,5,12,23
             };
             lista3.Add(28);

     

             List<int> listaadicional=new List<int>(){
                 7,33,4,88
             };

             lista3.AddRange(listaadicional);
            
   
             Console.WriteLine("La lista tiene : " + lista3.Count);
            
             if( lista3.Contains(219)){
                 Console.WriteLine("Si contiene el nro 29");
             }
             else{
                 Console.WriteLine("No lo contiene");
             }
            
            lista3.Sort();
            lista3.RemoveAt(0);
            foreach(var x in lista3){
                 Console.WriteLine(x);
             }
             lista3.Reverse();

             lista3.Clear();
            */
             
        List<Alumno> listaAlumnos=new List<Alumno>(){
            new Alumno(){DNI=11111,Nombre="Laura",Apellido="Alonso",Edad=25},
            new Alumno(22222,"Marina","Lopez",25),
            new Alumno(33333,"Pablo","Martinez",24)
        };

        listaAlumnos.Add(new Alumno(44444,"Cristian","Botti",23));
        var alumno1=new Alumno(55555,"Stella","Fernandez",24);
        listaAlumnos.Add(alumno1);
        listaAlumnos.Add(alumno1);

        //predicado
        var resultado=listaAlumnos.Find(alu => alu.DNI==11111 );
        var listaresultado=listaAlumnos.FindAll(x=> x.Edad==23 || x.Nombre=="Pablo");
        if(resultado!=null)
        Console.WriteLine(resultado.Apellido);
        
        var listadistinta= listaAlumnos.Distinct().ToList<Alumno>();

  
        

        //var listaordenada= listaAlumnos.OrderBy(x=> x.Edad).ToList();
        var listaordenada= listaAlumnos.OrderByDescending(x=> x.Edad).ToList();




        var suma=listaAlumnos.Sum(x=> x.Edad);
        var max=listaAlumnos.Max(x=>x.Edad);
        var prom=listaAlumnos.Average(x=> x.Edad);
        Console.WriteLine(prom);

        var busqueda= listaAlumnos
                                .Where(x=> x.Nombre.Contains("a") && x.Edad==24)
                                .OrderBy(x=>x.Apellido)
                                .ToList();
                                 
        foreach(var x in listaAlumnos){
            Console.WriteLine(x.DNI + " " + x.Apellido + " " + x.Nombre + " " + x.Edad );
        }
        

        var agrupado=listaAlumnos.GroupBy(
            p=>p.Edad, 
            (key,g)=>new {AgrupadorEdad=key    ,   Cantidad=g.ToList().Count() }
        );

        foreach(var resul in agrupado){
            var a=resul;
            Console.WriteLine(a.AgrupadorEdad + " " + a.Cantidad );
        }


        }
    }


    class Alumno{
        public Alumno(){

        }
        public Alumno(int dni,string nombre,string apellido,int edad){
            DNI=dni;
            Nombre=nombre;
            Apellido=apellido;
            Edad=edad;
        }
        public int DNI{get;set;}
        public string Nombre{get;set;}
        public string Apellido{get;set;}

        public int Edad {get;set;}
    }
}
