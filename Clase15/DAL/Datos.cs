using System.Data;
using System.IO;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DAL
{
    public class Datos
    {
        SqlConnection oConexion=new SqlConnection();
        public Datos(){
            oConexion.ConnectionString= "server=localhost;database=Comercio;trusted_connection=true";
 
        }

        //utilizamos para insert,update y delete.
        public int EjecutarSinResultado(string consulta, SqlParameter[] parametros){
            int cantFilasAfectadas=0;
            using(var commando=new SqlCommand(consulta,oConexion)   ){
                if(parametros!=null && parametros.Length>0)
                    commando.Parameters.AddRange(parametros);
                
                oConexion.Open();
                cantFilasAfectadas=commando.ExecuteNonQuery();
                oConexion.Close();
            }
            return cantFilasAfectadas;
        }

        //utilizamos para mostrar datos, una lista o un solo registro
        public DataTable MostrarDataTable(string consulta, SqlParameter[] parametros){
            var dt=new DataTable();
            using(var comando=new SqlCommand(consulta,oConexion)   ){
                if(parametros!=null && parametros.Length>0)
                    comando.Parameters.AddRange(parametros);

                var da=new SqlDataAdapter();
                da.SelectCommand=comando;

                oConexion.Open();
                da.Fill(dt);
                oConexion.Close();
            }
            return dt;
        }
        
        //funciones de agregado como count sum avg
        public object EjecutarScalar(string consulta,SqlParameter[] parametros){
            object resultado=null;
            using(var comando=new SqlCommand(consulta,oConexion)   ){
                if(parametros!=null && parametros.Length>0)
                    comando.Parameters.AddRange(parametros);
                oConexion.Open();
                resultado=comando.ExecuteScalar();
                oConexion.Close();
            }
            return resultado;
        }
    }
}