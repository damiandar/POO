using Entities;
using DAL;
using System.Collections.Generic;
namespace BLL{
    public class BLLAlumno{

        public void Crear(Alumno alumno){
            var dalalumno=new DALAlumnos();
            dalalumno.Insertar(alumno);
        }

        public void Modificar(Alumno alumno){
            var dalalumno=new DALAlumnos();
            dalalumno.Actualizar(alumno);
        }

        public void Eliminar(Alumno alumno){
            var dalalumno=new DALAlumnos();
            dalalumno.Borrar(alumno);
        }

        public List<Alumno> Listar(){
            var dalalumno=new DALAlumnos();
            return dalalumno.Listar();
        }
    }
}