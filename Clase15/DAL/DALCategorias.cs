using Entidades;
using System.Collections.Generic;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System.Data;
using System;

namespace DAL
{
    public class DALCategorias
    {
        Datos odatos;
        public DALCategorias(){
            odatos=new Datos();
        }
        public void InsertarCategoria(Categoria categoria){
            var consulta="insert into categorias(descripcion) values(@pdescripcion)";
            var parametroDescripcion=new SqlParameter("@pdescripcion",categoria.Descripcion);
            var vecparams= new SqlParameter[] {parametroDescripcion};
            odatos.EjecutarSinResultado(consulta,vecparams);
        }
        public void ActualizarCategoria(Categoria categoria){
            var consulta="update categorias set descripcion=@pdescripcion where id=@pid";
            var parametroDescripcion=new SqlParameter("@pdescripcion",categoria.Descripcion);
            var parametroID=new SqlParameter("@pid",categoria.Id);
            var vecparams= new SqlParameter[] {parametroDescripcion,parametroID};
            odatos.EjecutarSinResultado(consulta,vecparams);
        }
        public void EliminarCategoria(int id){
            var consulta="delete from categorias where id=@pid";
            var parametroID=new SqlParameter("@pid",id);
            var vecparams= new SqlParameter[] {parametroID};
            odatos.EjecutarSinResultado(consulta,vecparams);
        }

        public List<Categoria> MostrarTodos(){
            var listacategorias=new List<Categoria>();
            var consulta="select * from categorias";
            DataTable dt= odatos.MostrarDataTable(consulta,null);
        
            foreach(DataRow dr in dt.Rows ){
                var categoria=new Categoria();
                categoria.Id= Int32.Parse( dr["id"].ToString());
                categoria.Descripcion= dr["descripcion"].ToString();
                listacategorias.Add(categoria);
            }
            return listacategorias;
        }

        public Categoria MostrarPorId(int id){
            var consulta="select * from categorias where id=@pid";
            var parametroID=new SqlParameter("@pid",id);
            var vecparams= new SqlParameter[] {parametroID};
            DataTable dt= odatos.MostrarDataTable(consulta,vecparams);
            var categoria=new Categoria();
            foreach(DataRow dr in dt.Rows ){
                
                categoria.Id= Int32.Parse( dr["id"].ToString());
                categoria.Descripcion= dr["descripcion"].ToString();
           
            }
            return categoria;
        }

        public int MostrarTotalCategorias(){
            var consulta="select count(*) from categorias";
            var resultado=  odatos.EjecutarScalar(consulta,null);
            return Int32.Parse(resultado.ToString());
        }
    }
}