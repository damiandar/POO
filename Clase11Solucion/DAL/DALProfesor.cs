using Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL{
    public class DALProfesor{

        Datos datos;
        public DALProfesor(){
            datos=new Datos();
        }

        public List<Profesor> MostrarTodos(){
            var profesores=new List<Profesor>();
            var cnx=new SqlConnection();
            cnx.ConnectionString="Server=rosso;database=herramientas2022;user=sa;password=Password_123;";
            cnx.Open();
                var consulta="select * from profesores";
                var comando=new SqlCommand(consulta,cnx);
                SqlDataReader dr=comando.ExecuteReader();
                while(dr.Read()){
                     var prof=new Profesor();
                     prof.Id=dr.GetInt32(0);
                     prof.Nombre=dr.GetString(1);
                     prof.Apellido=dr.GetString(2);
                     prof.Activo=(bool)dr["Activo"];
                     profesores.Add(prof);
                }
            cnx.Close();
            return profesores;
        }
        public Profesor MostrarUnProfesor(int id){
            var prof=new Profesor();
            var cnx=new SqlConnection();
            cnx.ConnectionString="Server=rosso;database=herramientas2022;user=sa;password=Password_123;";
            cnx.Open();
                var comando=new SqlCommand("select * from profesores where id=@cod",cnx);
                var paramId=new SqlParameter("@cod",id);
                comando.Parameters.Add(paramId);
                SqlDataReader dr=comando.ExecuteReader();
                 while(dr.Read()){
                      
                     prof.Id=dr.GetInt32(0);
                     prof.Nombre=dr.GetString(1);
                     prof.Apellido=dr.GetString(2);
                     prof.Activo=(bool)dr["Activo"]; 
                }
            cnx.Close();
            return prof;
        }
        public void InsertarProfesor(Profesor prof){ 
         
                var consulta="insert into profesores (nombre,apellido,activo) values(@nom,@ape,@act)";
                datos.EjecutarConsultaSinResultado(consulta, MostrarParametros(prof,true));
        }
        public void ModificarProfesor(Profesor prof){ 
       
                var consulta="update profesores set nombre=@nom, apellido=@ape, activo=@act where id=@cod";
            datos.EjecutarConsultaSinResultado(consulta,MostrarParametros(prof,true));   
        }
         public void BorrarProfesor(int id){ 
  
                var consulta="delete profesores where id=@cod";
                datos.EjecutarConsultaSinResultado(consulta,MostrarParametros(new Profesor(){Id=id},false));
        }
        public double Calculador(){
            //consulta base de datos
            return 20000;
        }
        public double Inasistencias(){
            //consulta bd
            return 10000;
        }

        public int CantidadActivos(){
            var consulta="select count(*) from Profesores where Activo=1";
            return (int)datos.EjecutarEscalar(consulta,null);
        }

        public string MostrarNombrePorId(int id){
            var consulta="select Nombre from profesores where id=@id";
         
            return datos.EjecutarEscalar(consulta,new SqlParameter[]{new SqlParameter("@id",id)}).ToString();
        }
        private SqlParameter[] MostrarParametros(Profesor prof,bool InsUpd){
               var paramNomb=new SqlParameter("@nom",prof.Nombre);
                var paramApell=new SqlParameter("@ape",prof.Apellido);
                var paramAct=new SqlParameter("@act",prof.Activo);
                var paramId=new SqlParameter("@cod",prof.Id);
            if(InsUpd)
               return new SqlParameter[]{paramId,paramAct,paramApell,paramNomb};
            return new SqlParameter[]{paramId};
        }
    }
}