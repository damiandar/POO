using System;
using BLL;
using Entities;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var bllProf=new BLLProfesor();
            

            var profesor1=new Profesor();
            profesor1.Nombre="Francisco";
            profesor1.Apellido="Gonzalez"; 
            profesor1.Activo=false;
            //profesor1.Id=1002;
            //bllProf.Actualizar(profesor1);
            //bllProf.Insertar(profesor1);
            //bllProf.Eliminar(1004);
 /*
           var sueldo= bllProf.CalcularSueldo(profesor1);


           var listaProf=bllProf.Listar();
           foreach(Profesor prof in listaProf){
               Console.WriteLine(prof.Apellido + " " + prof.Nombre);
           }

           Console.WriteLine(bllProf.BuscarPorId(2).Nombre);
           Console.WriteLine(sueldo);
           */
           var bllal=new BLLAlumno();
            var alumnos=bllal.Listar();

            foreach(Alumno alu in alumnos){

                Console.WriteLine(alu.Nombre);
            }

           //bllal.Crear(new Alumno(){Id=2,Nombre="Juan",Apellido="Romano"});

           //bllal.Modificar(new Alumno(){Id=2,Nombre="Juan Martin",Apellido="Romano"});

           //bllal.Eliminar(new Alumno(){Id=2});

           var bllprof=new BLLProfesor();
            Console.WriteLine(   bllprof.MostrarCantidadActivos().ToString());
            Console.WriteLine(bllprof.BuscarPorCodigo(2));



        }
    }
}
