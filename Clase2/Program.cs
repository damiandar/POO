using System;

namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
               
                var cuenta1=new Cuenta(1000); 
                cuenta1.TitularCuenta=new Titular();
                cuenta1.TitularCuenta.Apellido="Alonso";
                cuenta1.TitularCuenta.Nombre="Laura";
                cuenta1.TitularCuenta.Documento=28999112;

                cuenta1.Numero=1111111;
                //cuenta1.Saldo=1000;
                //cuenta1.Tipo=Cuenta.EnumTipo.CajaAhorro;
                cuenta1.Tipo=0;

                Console.WriteLine("Cuenta tipo:" + cuenta1.Tipo.ToString());
                
                cuenta1.Depositar(500);
                cuenta1.Extraer(300);

            
                Cuenta cuenta2=new Cuenta(-5000);
                cuenta2.TitularCuenta=new Titular("Juan","Martinez",2222);
                cuenta2.Numero=2222222;
                //cuenta2.Saldo=-5000;
                cuenta2.Tipo=Cuenta.EnumTipo.CuentaCorriente;
                cuenta2.Depositar(7000);
                cuenta2.Extraer(1500);

                Console.WriteLine("Saldo Cuenta 1:" + cuenta1.Saldo );
                Console.WriteLine("Saldo Cuenta 2:" + cuenta2.Saldo );
                
                Cuenta cuenta3=new Cuenta();
                cuenta3.Tipo=Cuenta.EnumTipo.CuentaCorriente;

        }
    }

    class Cuenta
    {
        public Cuenta(){

        }

        public Cuenta(double monto){
            Saldo=monto;
        }
        public Titular TitularCuenta {get;set;}
        public int Numero {get;set;}

        public enum EnumTipo {
            CuentaCorriente,
            CajaAhorro

        }
        public EnumTipo Tipo {get;set;}
        /*
        private double saldo;
        public double Saldo {
            get{
                return saldo;
            } 
        }
        */
        public double Saldo {get;private set;} 
        public bool Activa {get;set;}

        public void Depositar(double monto){
            //Saldo=Saldo + monto;
            Saldo+=monto;
        }
        public void Extraer(double monto){
            Saldo -=monto;
        }
    }

    class Titular {

        public Titular(){

        }
        public Titular(string nombre,string apellido){
            Nombre=nombre;
            Apellido=apellido;
        }
            public Titular(string nombre,string apellido,string direccion){
            Nombre=nombre;
            Apellido=apellido;
            Domicilio=direccion;
        }
        public Titular(string apellido,string nombre,int dni){
            Nombre=nombre;
            Apellido=apellido; 
            Documento=dni;
        }
        public Titular(string nombre,string apellido,string direccion,int dni){
            Nombre=nombre;
            Apellido=apellido;
            Domicilio=direccion;
            Documento=dni;
        }
        public string Nombre {get;set;}
        public string Apellido{get;set;}
        public int Documento {get;set;}

        public string Domicilio {get;set;}
    }

}
