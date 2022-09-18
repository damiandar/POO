using System;
using System.Threading.Task;
using System.Task;

namespace Clase16Asincrono
{
    class Program
    {
        static async Task Main(string[] args)
        {
             var resultado=await DescargarArchivo("nombreurl","direccionfisica");
             if(resultado){
                Console.WriteLine("Descarga completa");
             }
        }
        public async Task<bool> static DescargarArchivo(string Nombre,string Ruta){
            try
            {
                var descarga=await System.Net.Http.HttpCliente.GetByteArrayAsync(Nombre);
            }
            catch (System.Exception)
            {
                
                throw;
                return false;
            }
            return true;
        }
    }

    
}
