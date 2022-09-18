using System;
using Clases.Compras;
using Clases.Ventas;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            var remito = new Remito();
            Factura fact = new Factura();
            var item1 = new ItemFactura("Zapatilla", 1);
            item1.PrecioUnitario = 100;
            
            var item2 = new ItemFactura("Pantalon", 2);
            item2.PrecioUnitario = 200;

            fact.Agregar(item1);
            fact.Agregar(item2);
            fact.Tipo = Factura.tipo.A;
            Console.WriteLine(item1.SubTotal);
            Console.WriteLine(item2.SubTotal);
            try
            {
                Console.WriteLine("Total:" + fact.Total);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message.ToString());
            }
            
            Console.WriteLine("------------------------------");


            //fact.Descontar();
            //fact.Tipo = Factura.tipo.C;
            //Console.WriteLine(item1.SubTotal);
            //Console.WriteLine(item2.SubTotal);
            //Console.WriteLine("Total con descuento:" + fact.Total);


            //fact.Tipo = Factura.tipo.A;
            //Console.WriteLine(fact.IVA);

            //fact.Tipo = Factura.tipo.C;
            //Console.WriteLine(fact.IVA);

            Console.ReadKey();
        }
    }
}
