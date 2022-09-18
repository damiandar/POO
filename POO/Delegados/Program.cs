using System;

namespace Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            var vendedor=new VendedorAmbulante();
            vendedor.SeleccionarProducto(VendedorAmbulante.TipoProducto.Lapicera);
            vendedor.Vender("el principito"); 
        }
    }

    class VendedorAmbulante{

        public delegate string TipoDelegadoVenta(string nombre);

        TipoDelegadoVenta productoseleccionado;
        public enum TipoProducto{
            Lapicera,
            Caramelo,
            Libro
        }

        public void Vender(string Nombre){
            string mensaje=productoseleccionado(Nombre);
            Console.WriteLine(mensaje);
        }

        public void SeleccionarProducto(TipoProducto tipo){
                switch (tipo)
                {
                    case TipoProducto.Lapicera:
                        productoseleccionado=VenderLapiceras;
                       //Console.WriteLine( delegadoVLapicera.Invoke("Bic"));
                        break;
                    case TipoProducto.Caramelo:
                       productoseleccionado=VenderCaramelos;
                        break;

                    case TipoProducto.Libro:
                        productoseleccionado=VenderLibros;
                        break;
                }
        }
        private string VenderLapiceras(string nombre){
            return "Estoy vendiendo lapiceras marca " + nombre;
        }
        
        private string VenderCaramelos(string nombre){
            return "Los caramelos mas ricos " + nombre;
        }
        
        private string VenderLibros(string nombre){
            return "Un libro muy interesante " + nombre;
        }
    }
}
