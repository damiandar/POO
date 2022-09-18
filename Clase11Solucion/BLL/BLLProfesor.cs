using Entities;
using DAL;
using System.Collections.Generic;
using System.Linq;

namespace BLL{
    public class BLLProfesor{

        public List<Profesor> Listar(){
            var dalprof=new DALProfesor();
            return dalprof.MostrarTodos();
        }

        public Profesor BuscarPorId(int idprof){
            var dalprof=new DALProfesor();
            return dalprof.MostrarUnProfesor(idprof);
        }
        public void Insertar(Profesor profe){
            var dalprof=new DALProfesor();
            dalprof.InsertarProfesor(profe);
        }

        public void Actualizar(Profesor pro){
            var dalprof=new DALProfesor();
            dalprof.ModificarProfesor(pro);
        }
        
        public void Eliminar(int cod){
            var dalprof=new DALProfesor();
            dalprof.BorrarProfesor(cod);
        }

        public List<Profesor> MostrarActivos(){
            var profesoresactivos=Listar();
            return profesoresactivos.Where(x=>x.Activo==true).ToList();
        }

        public void MostrarCursosAsignados(){

        }

        public double CalcularSueldo(Profesor prof){

            var dalprof=new DALProfesor();
            var sueldo=dalprof.Calculador();
            var ina=dalprof.Inasistencias();


            if(prof.Activo)
                return sueldo - ina;
            return 10000;
        }

        public int MostrarCantidadActivos(){
            var dalprof=new DALProfesor();
            return dalprof.CantidadActivos();
        }

        public string BuscarPorCodigo(int cod){
            var dalprof=new DALProfesor();
            return dalprof.MostrarNombrePorId(cod);
        }
    }
}