using System;

namespace ProyDelegadosClase11
{
    class Program
    {
        static void Main(string[] args)
        {
            var vendedor=new VendedorAmbulante();
            vendedor.SeleccionarProducto(VendedorAmbulante.TipoProducto.Libro);
            vendedor.Vender("El principito");
        }
    }

    class VendedorAmbulante{
        public delegate  string TipoDelegadoVenta(string nombre);

        TipoDelegadoVenta productoseleccionadoDel;
        public enum TipoProducto{
            Lapicera,
            Caramelo,
            Libro,
        }
        public void SeleccionarProducto(TipoProducto tipo){
            switch(tipo)
            {
                case TipoProducto.Lapicera:
                    productoseleccionadoDel=VenderLapicera;
                    break;
                case TipoProducto.Caramelo:
                    productoseleccionadoDel=VenderCaramelos;
                    break;
                case TipoProducto.Libro:
                    productoseleccionadoDel=VenderLibros;
                    break;

            }
        }
        public void Vender(string Nombre){
            string mensaje= productoseleccionadoDel(Nombre);
            Console.WriteLine(mensaje);
        }

        private string VenderLapicera(string nombre){
            return "Estoy vendiendo lapicera marca " + nombre;
        }
        private string VenderCaramelos(string nombre){
            return "Los caramelos mas ricos " + nombre;
        }
        private string VenderLibros(string nombre){
            return "El mejor libro " + nombre;
        }

    }
}
