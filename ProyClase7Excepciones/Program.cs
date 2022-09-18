using System;

namespace ProyClase7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar el valor x");
            var x=Console.ReadLine();   
            Console.WriteLine("Ingresa el valor y");
            var y=Console.ReadLine();
            
            try{
                Mostrar(x);
                Mostrar(y);
                var xx=int.Parse(x);
                var yy=int.Parse(y);
                int resultado=xx/yy;
                Console.WriteLine(resultado);
            }
            catch(DivideByZeroException ex){
                Console.WriteLine("Error divide por cero:" + ex.Message.ToString());
            }
            catch(ArgumentNullException ex){
                Console.WriteLine("Error null exception:" + ex.Message.ToString() );
            }
            catch(InvalidCastException ex){
                Console.WriteLine("Error de casteo" + ex.Message.ToString() + ex.InnerException.ToString()  );
            }
            catch(System.Exception ex){
                Console.WriteLine("Error generico:" + ex.Message.ToString());
            }
            finally{

            }
        }
        static void Mostrar(string valor){
            if(String.IsNullOrEmpty(valor))
                throw new ArgumentNullException("El valor es null");
            Console.WriteLine(valor);
        }
    }
}