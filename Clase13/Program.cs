using System;

namespace Clase13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sumador=new Sumador();
            var resultado= sumador.Sumar(3,4);
            var resultado2=sumador.Sumar(4.3,5.7);
            Console.WriteLine(resultado2);
        }
    }
}
