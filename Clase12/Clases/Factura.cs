using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ventas
{
    public class Factura : IComprobante
    {

        public delegate void TipoDelegadoDescuento(bool desc);
        public event TipoDelegadoDescuento DescuentoAplicado; 

        private List<ItemFactura> Items;

        public enum tipo { 
            A,
            B,
            C,
        }

        public tipo Tipo { get; set; }
        public string Nombre { get; set; }
        public string CUIT { get; set; }

        public double Total { 
            get 
            {
                if (Tipo != tipo.C && String.IsNullOrEmpty(CUIT))
                    throw new Exception("Debe especificar el cuit");
                return Items.Sum(x => x.SubTotal);
            } 
        }

       
        public DateTime Fecha { get; set; }

        public double IVA { 
            get {
                if (Tipo == tipo.C)
                    return 0;
                return (Total * 1.21) -Total;
            }  
        }

        public int NroComprobante { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Descontar() { 
            DescuentoAplicado(true);
        }
        
        public void Agregar(ItemFactura item)
        {
            
            if (Items is null) {
                Items = new List<ItemFactura>();
            }
            DescuentoAplicado += item.DescontarHandler;
            this.Items.Add(item);
        }



    }
}
