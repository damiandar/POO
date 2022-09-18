using DAL;
using Entidades;
using System.Collections.Generic;

namespace BLL
{
    public class BLLCategoria
    {
        public void GuardarCategoria(Categoria categoria){
            var dalcategoria=new DALCategorias();
            dalcategoria.InsertarCategoria(categoria);
        }
        public void ModificarCategoria(Categoria categoria){
            var dalcategoria=new DALCategorias();
            dalcategoria.ActualizarCategoria(categoria);
        }
        public void BorrarCategoria(int id){
            var dalcategoria=new DALCategorias();
            dalcategoria.EliminarCategoria(id);
        }

        public List<Categoria> Listar(){
            var dalcategoria=new DALCategorias();
            return dalcategoria.MostrarTodos();
        }

        public Categoria Buscar(int id){
            var dalcategoria=new DALCategorias();
            return dalcategoria.MostrarPorId(id);
        }

        public int MostrarCantidad(){
            var dalcategoria=new DALCategorias();
            return dalcategoria.MostrarTotalCategorias();
        }
    }
}