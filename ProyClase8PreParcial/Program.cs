using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyClase8PreParcial
{
    class Program
    {
        static void Main(string[] args)
        {
           var cuenta1=new Cuenta(Cuenta.TipoCuenta.CajaAhorro,100);
           try{
            cuenta1.AplicarCredito(150);
            cuenta1.AplicarDebito(200);
            cuenta1.AplicarDebito(50);
            cuenta1.CobrarMantenimiento();
           }
           catch(Exception ex){
               Console.WriteLine("El error es:" + ex.Message.ToString());
           }
           

        }
    }
    public interface ICuenta {
        void CobrarMantenimiento();
        void AplicarCredito(double monto);
        void AplicarDebito(double monto);
    }
    public class Cuenta:ICuenta{
        public Cuenta(TipoCuenta tipo,double saldo ){
            Tipo=tipo;
            Saldo=saldo;
        }

        public Cuenta(TipoCuenta tipo,double saldo,string Numero ):this(tipo,saldo) {
            this.Numero=Numero;
        }

        public void CobrarMantenimiento(){
            if(Tipo==TipoCuenta.CajaAhorro){
                //Saldo-=50;
                AplicarDebito(50);
            }
            else if(Tipo==TipoCuenta.CuentaCorriente){
                AplicarDebito(100);
            }

        }
        public string Numero {get;private set;}

        public enum TipoCuenta{
            CajaAhorro,
            CuentaCorriente,
            CuentaSueldo
        }

        public TipoCuenta Tipo {get;private set;}
        public double Saldo{get;private set;}

        public void AplicarCredito(double monto){
            Saldo+=monto;
        }
        public void AplicarDebito(double monto){
            Saldo-=monto;
            if(Tipo!=TipoCuenta.CuentaCorriente && Saldo<0){
                throw new Exception("El saldo de esta cuenta no permite valores negativos");
            }
        }
    }

    public class CuentaPremium:ICuenta{
        public void CobrarMantenimiento(){

        }
        public void AplicarCredito(double monto){

        }
        public void AplicarDebito(double monto){

        }
    }
    public class Cliente{

        public Cliente(string usuario){
            Usuario=usuario;
        }

        public Cliente(string usuario,string nombre,string apellido,string clave){
            Usuario=usuario;
            Nombre=nombre;
            Apellido=apellido;
            Clave=clave;
        }
        private List<Cuenta> Cuentas;
        public string Nombre {get;set;}
        public string Apellido{get;set;}
        public string Usuario{get;set;}
        public string Clave{get;set;}

        public double LimiteCredito {get;set;}

        

    }
}
