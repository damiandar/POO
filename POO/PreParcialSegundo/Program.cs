using System;
using Clases;

namespace PreParcialSegundo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var cliente=new Cliente("Maria","Fernandez",22222123);
            
            var tarjeta=new Tarjeta(160);
            var debito=new Debito(90);
            var mp=new MercadoPago(199);
            
            cliente.AgregarMedioPago(mp);
            mp.Pagar(100000);
            Console.WriteLine(mp.Estado());

        }
    }
}
