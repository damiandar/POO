using Entidades;
using System.Collections.Generic;
using Microsoft.Data;
using Microsoft.Data.SqlClient;


namespace DAL
{
    public class DALProductos
    {
    public List<Producto> MostrarProductos(){
            var productos=new List<Producto>();
            string connectionString= "server=localhost;database=Comercio;trusted_connection=true";

            using( var cnx= new SqlConnection(connectionString) ){
                cnx.Open();

                var sqlQuery="Select * from Productos";
                //using(SqlCommand command=cnx.CreateCommand()){
                using(var command=new SqlCommand(sqlQuery,cnx)   ){
                    command.CommandText=sqlQuery;
                    SqlDataReader dr= command.ExecuteReader();

                    while(dr.Read()){
                        var prod=new Producto();
                        prod.Codigo=dr.GetInt32(0);
                        prod.Nombre=dr.GetString(1);
                        productos.Add(prod);
                    }
                }
                cnx.Close();
            }

            return productos;
        }    
    public Producto MostrarUnProducto(int codigo){
            var prod=new Producto();
            string connectionString= "server=localhost;database=Comercio;trusted_connection=true";

            using( var cnx= new SqlConnection(connectionString) ){
                cnx.Open();

                var sqlQuery="Select * from Productos where id=@cod";
                //using(SqlCommand command=cnx.CreateCommand()){
                using(var command=new SqlCommand(sqlQuery,cnx)   ){
                    command.CommandText=sqlQuery;
                    var parametroid=new SqlParameter("@cod",codigo);
                    command.Parameters.Add(parametroid);
                    SqlDataReader dr= command.ExecuteReader();

                    while(dr.Read()){
                        prod.Codigo=dr.GetInt32(0);
                        prod.Nombre=dr.GetString(1); 
                    }
                }
                cnx.Close();
            }

            return prod;
        }
    public void InsertarProducto(Producto prod){
        string connectionString= "server=localhost;database=Comercio;trusted_connection=true";

            using( var cnx= new SqlConnection(connectionString) ){
                cnx.Open();

                var sqlQuery=@"insert into productos(stock,nombre,precio)
                values(@stock,@nombre,2000)";
                //using(SqlCommand command=cnx.CreateCommand()){
                using(var command=new SqlCommand(sqlQuery,cnx)   ){
                    command.CommandText=sqlQuery;
                    var parametrostock=new SqlParameter("@stock",prod.Stock);
                    var parametronombre=new SqlParameter("@nombre",prod.Nombre);
                    command.Parameters.Add(parametrostock);
                    command.Parameters.Add(parametronombre);
                    
                    command.ExecuteNonQuery();
                }
                cnx.Close();
            }
    }
    public void ModificarProducto(Producto prod){
        string connectionString= "server=localhost;database=Comercio;trusted_connection=true";

            using( var cnx= new SqlConnection(connectionString) ){
                cnx.Open();

                var sqlQuery=@"update productos
                set stock=@stock, nombre=@nombre,precio=@precio 
                where id=@cod";
                //using(SqlCommand command=cnx.CreateCommand()){
                using(var command=new SqlCommand(sqlQuery,cnx)   ){
                    command.CommandText=sqlQuery;
                    var parametrostock=new SqlParameter("@stock",prod.Stock);
                    var parametronombre=new SqlParameter("@nombre",prod.Nombre);
                    var parametroPrecio=new SqlParameter("@precio",prod.Precio);
                    var parametroId=new SqlParameter("@cod",prod.Codigo);
                    command.Parameters.Add(parametrostock);
                    command.Parameters.Add(parametronombre);
                    command.Parameters.Add(parametroPrecio);
                    command.Parameters.Add(parametroId);
                    
                    command.ExecuteNonQuery();
                }
                cnx.Close();
            }
    }
    public void BorrarProducto(int codigo){
        string connectionString= "server=localhost;database=Comercio;trusted_connection=true";

            using( var cnx= new SqlConnection(connectionString) ){
                cnx.Open();

                var sqlQuery=@"delete productos 
                where id=@cod";
                //using(SqlCommand command=cnx.CreateCommand()){
                using(var command=new SqlCommand(sqlQuery,cnx)   ){
                    command.CommandText=sqlQuery; 
                    var parametroId=new SqlParameter("@cod",codigo); 
                    command.Parameters.Add(parametroId);
                    
                    command.ExecuteNonQuery();
                }
                cnx.Close();
            }
    }

    }
}