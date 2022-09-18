using DAL;
using Entidades;
using System.Collections.Generic;

namespace BLL
{
    public class BLLProducto
    {
        public List<Producto> MostrarTodosLosProductos(){
            var dalprod=new DALProductos();
            return dalprod.MostrarProductos();
        }
        public Producto MostrarProducto(int codigo){
            var dalprod=new DALProductos();
            return dalprod.MostrarUnProducto(codigo);
        }

        public void GuardarProducto(Producto prod){
            var dalprod=new DALProductos();
            dalprod.InsertarProducto(prod);
        }
        public void ModificarProducto(Producto prod){
            var dalprod=new DALProductos();
            dalprod.ModificarProducto(prod);
        }
        public void EliminarProducto(int id){
            var dalprod=new DALProductos();
            dalprod.BorrarProducto(id);
        }

        
    }
}