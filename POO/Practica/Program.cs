using System;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            var chef=new Chef();
            var repostero=new Repostero();

            var restaurante=new Restaurante();
            /*restaurante.SacarPlato(chef);
            restaurante.SacarPlato(chef);
            restaurante.SacarPlato(repostero);
*/

            var mesa1=new Mesa();
            var mesa2=new Mesa();

            mesa1.AgregarPlato(restaurante.SacarPlato(chef));
            restaurante.ServirPlatos();
            mesa2.AgregarPlato(restaurante.SacarPlato(chef));

            Console.WriteLine("Mesa 1 servida:" + mesa1.Cuenta());
            Console.WriteLine("Mesa 2 pedido: " + mesa2.Cuenta());
            
            restaurante.ServirPlatos();
            mesa2.AgregarPlato(restaurante.SacarPlato(repostero));
            restaurante.ServirPlatos();
         
            //Console.WriteLine("Mesa 1 servida:" +mesa1.Cuenta());
            Console.WriteLine("Mesa 2 servida:" +mesa2.Cuenta());
            
            Console.WriteLine("total restaurante: " + restaurante.CostoTotal);
        }
    }
}
