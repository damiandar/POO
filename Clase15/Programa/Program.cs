using System;
using System.Collections.Generic;
using BLL;
using Entidades;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            var bllprod=new BLLProducto();
            //var productos=bllprod.MostrarTodosLosProductos();
            /*
            foreach( var prod in productos){
                Console.WriteLine(prod.Codigo + " " + prod.Nombre); 
            }
            */

            var prod=bllprod.MostrarProducto(3);
            Console.WriteLine(prod.Codigo + " " + prod.Nombre);

            var prodinsert=new Producto();
            prodinsert.Nombre="Clase15 modificado";
            prodinsert.Stock=1;
            prodinsert.Codigo=2016;
            prodinsert.Precio=1999;

            //bllprod.GuardarProducto(prodinsert);
            //bllprod.ModificarProducto(prodinsert);
            //bllprod.EliminarProducto(1016);

            var bllcategoria=new BLLCategoria();

            var categoriainsert=new Categoria();
            categoriainsert.Descripcion="CategoriaModificadaPOO";
            categoriainsert.Id=3003;

            //bllcategoria.GuardarCategoria(categoriainsert);
            //bllcategoria.ModificarCategoria(categoriainsert);
            //bllcategoria.BorrarCategoria(3003);
            
            var listaCategorias=bllcategoria.Listar();

            //foreach(var cat in listaCategorias){
            //    Console.WriteLine(cat.Descripcion);
            //}

            var catbuscada= bllcategoria.Buscar(2017);

            //Console.WriteLine(catbuscada.Descripcion);

            Console.WriteLine(bllcategoria.MostrarCantidad());

            

        }
    }
}
