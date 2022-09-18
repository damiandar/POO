 
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace DAL{
    public class Datos{

        private SqlConnection cnx;
        public Datos(){
            cnx=new SqlConnection();
            cnx.ConnectionString="Server=rosso;database=herramientas2022;user=sa;password=Password_123;";
        }
        //usar cuando tengamos consultas del tipo insert, update y delete.
        public int EjecutarConsultaSinResultado(string consulta,SqlParameter[] parametros ){
            int cantidadFilasAfectadas=0;
            using(var comando=new SqlCommand(consulta,cnx)){
                if(parametros!=null && parametros.Length>0)
                    comando.Parameters.AddRange(parametros);
                cnx.Open();
                    cantidadFilasAfectadas=comando.ExecuteNonQuery();
                cnx.Close();
            }
            return cantidadFilasAfectadas;
        }


        //usar cuando tengamos consultas de agregado por ej: count,sum,avg
        public object EjecutarEscalar(string consulta,SqlParameter[] parametros){
            object resultado=null;
            using(var comando=new SqlCommand(consulta,cnx)){
                if(parametros!=null && parametros.Length>0)
                    comando.Parameters.AddRange(parametros);
                cnx.Open();
                    resultado=comando.ExecuteScalar();
                cnx.Close();
            }
            return resultado;
        }

        //usar cuando tengamos consultas que devuelvan una o mas filas
        public DataTable MostrarDatos(string consulta,SqlParameter[] parametros){
            var dt=new DataTable();
            using(var comando=new SqlCommand(consulta,cnx)){
                 if(parametros!=null && parametros.Length>0)
                    comando.Parameters.AddRange(parametros);
                var da=new SqlDataAdapter();
                da.SelectCommand=comando;
                cnx.Open();
                da.Fill(dt);
                cnx.Close();
            }
            return dt;
        }
    }
}