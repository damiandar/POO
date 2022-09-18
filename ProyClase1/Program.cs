using System;
using System.Collections.Generic;

namespace ProyClase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto miauto=new Auto();
            miauto.Marca="Peugeot";
            Console.WriteLine(miauto.Marca);
            miauto.Modelo="208";
            miauto.Acelerar(100);
            miauto.Frenar();

            //bool estado= miauto.EstaApagado();

            if(miauto.EstaApagado()){
                Console.WriteLine("Esta apagado");
            }
            else{

            }
            var auto2=new Auto();
            auto2.Marca="Fiat";
            auto2.Modelo="Palio";
            Console.WriteLine(auto2.MarcaYModelo);

            var cta=new Cuenta(200);     
                
            cta.Depositar(50);
            cta.Extraer(100);
            Console.WriteLine(cta.Saldo);

            var cliente1=new Cliente();
            cliente1.Nombre="Marina";
            cliente1.Apellido="Lopez";

            cliente1.Cta=new Cuenta(500);
            Console.WriteLine(cliente1.Cta.Saldo);

            var cliente2=new Cliente();
            cliente2.Nombre="Laura";
            cliente2.Apellido="Alonso";
            cliente2.Cta=cta;

            Console.WriteLine(cliente2.Cta.Saldo);

            Banco galicia=new Banco();
            //galicia.Clientes=new List<Cliente>();
            galicia.AgregarCliente(cliente1);
            galicia.AgregarCliente(cliente2);
            galicia.AgregarCliente(new Cliente("Florencia","Santos",112121));

            galicia.MostrarClientes();
        }
    }

    public class Auto{

        //public string Marca {get;set;}

        private string marca; 
        public string Marca{
            get{  return marca;     }
            set{  marca=value;      }
        }

        public string MarcaYModelo {
            get { return marca + " " + Modelo; }
        }

        public string Modelo{get;set;}
        public int Velocidad{get;set;}
        public string NombreConductor{get;set;}

        public void Acelerar(int vel){
            //implementacion
            Console.WriteLine("Estoy acelerando");
        }
        public void Frenar(){
            Console.WriteLine("Estoy frenando");
        }

        public bool EstaApagado(){
            return false;
        }
    }

    public class Cuenta{
        public Cuenta(int monto){
            saldo=monto;
        }
        private int saldo;

        public int Saldo {
            get {return saldo;}
        }
        public void Depositar(int monto){
            saldo+=monto;
        }

        public void Extraer(int monto){
            saldo-=monto;
        }
    }

    public class Cliente{

        public Cliente(){
            Nombre="SIN ASIGNAR";
        }
        public Cliente(string nombre,string apellido){
            Nombre=nombre;
            Apellido=apellido;
        }
        public Cliente(string nombre,string apellido,int dni){
            Nombre=nombre;
            Apellido=apellido;
            DNI=dni;
        }
        public string Nombre{get;set;}
        public string Apellido{get;set;}

        public int DNI {get;set;}

        public Cuenta Cta {get;set;}
    }

    public class Banco {
        public Banco(){
            Clientes=new List<Cliente>();
        }
        public string Nombre{get;set;}
        public List<Cliente> Clientes {get;set;}

        public void AgregarCliente(Cliente cli){
            Clientes.Add(cli);
        }

        public void MostrarClientes(){
            foreach(var cli in Clientes){
                Console.WriteLine(cli.Nombre + " " + cli.Apellido);
            }
        }

    }


}
