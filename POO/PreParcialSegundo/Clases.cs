using System.Collections.Generic;

namespace Clases
{

    public class Cliente{

        public Cliente(string nombre,string apellido,int dni){
            Nombre=nombre;
            Apellido=apellido;
            Dni=dni;
        }
        public string Nombre{get;set;}
        public string Apellido{get;set;}

        public int Dni {get;set;}

        private List<MedioPago> MediosDePago;

        public void AgregarMedioPago(MedioPago medio)
        {
            if(MediosDePago==null){
                this.MediosDePago=new List<MedioPago>();
            }

            this.MediosDePago.Add(medio);
        }

        public void RecibirAlerta(MedioPago mp){
            var indice=this.MediosDePago.IndexOf(mp);
            this.MediosDePago[indice].Bloquear();
        }
        

        
    }
    public interface IPagoElectronico{
        string CVU {get;set;}
        string Web {get;set;}



    }
    public abstract class MedioPago
    {


        public MedioPago(double creditoinicial){
            credito=creditoinicial;
        }
        public void Bloquear()
        {
            bloqueado = true;
        }

        public int NroCuenta{get;set;}

        protected bool bloqueado;
        protected double credito;
        public virtual void Pagar(double valor){
             if(bloqueado==false){
                var saldo=credito-valor;
                if(saldo<0){
                    throw new System.Exception("No dispone de saldo");
                }
                credito-=valor;
            }

        }

        public string Estado(){
            return "Mi estado bloqueado es: " + bloqueado;
        }



    }

    public class Tarjeta : MedioPago
    {
        public Tarjeta(double creditoinicial) : base(creditoinicial)
        {
        }
    }

    public class Debito : MedioPago
    {
        public Debito(double creditoinicial) : base(creditoinicial)
        {
        }
    }

    public class MercadoPago : MedioPago, IPagoElectronico
    {
        public delegate void DelEvento(MedioPago medio);

        public event DelEvento MontoSuperado;



 

        public MercadoPago(double creditoinicial) : base(creditoinicial)
        {
        }
        public override void Pagar(double valor)
        {
            if (valor > 50000)
            {
                var medio = this;
                this.MontoSuperado(medio);
            }
            if (bloqueado == false)
            {
                var saldo = credito - valor;
                if (saldo < 0)
                {
                    throw new System.Exception("No dispone de saldo");
                }
                credito -= valor;
            }

        }

        public string CVU { get; set; }
        public string Web { get; set; }
    }







}