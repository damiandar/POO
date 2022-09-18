using Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALAlumnos
    {
        Datos datos;
        public DALAlumnos(){
            datos=new Datos();
        }
        public List<Alumno> Listar(){
            var Alumnos=new List<Alumno>();
            var consulta="select * from alumnos";
            DataTable dt= datos.MostrarDatos(consulta,null);
            foreach (DataRow dr in dt.Rows)
            {
                var alum=new Alumno();
                alum.Id=(int)dr["alumnoid"];
                alum.Nombre=dr["Nombre"].ToString();
                alum.Apellido=dr["Apellido"].ToString();

                Alumnos.Add(alum);
            }
            return Alumnos;
        }

        public void Insertar(Alumno alumno){
           
            var consulta="insert into alumnos(alumnoid,nombre,apellido) values(@id,@nombre,@apellido)";
            datos.EjecutarConsultaSinResultado(consulta,MostrarParametros(true,alumno));
        }

        public void Actualizar(Alumno alumno){
            var consulta="update alumnos set apellido=@apellido, nombre=@nombre where alumnoid=@id";
            datos.EjecutarConsultaSinResultado(consulta,MostrarParametros(true,alumno));
        }

        public void Borrar(Alumno alumno){
            var consulta="delete alumnos where alumnoid=@id"; 
            datos.EjecutarConsultaSinResultado(consulta,MostrarParametros(false,alumno));
        }

        private SqlParameter[] MostrarParametros(bool InsUpd,Alumno alumno){
            var paramId=new SqlParameter("@id",alumno.Id);
            var paramNombre=new SqlParameter("@nombre",alumno.Nombre);
            var paramApellido=new SqlParameter("@apellido",alumno.Apellido);
            if(InsUpd)
                return new SqlParameter[]{paramId,paramNombre,paramApellido};
            return new SqlParameter[]{paramId};
        }
    }
}