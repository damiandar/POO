using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ventas
{
    public class ItemFactura
    {
        #region Constructores
        public ItemFactura(string prod) {
            this.producto = prod;
        }

        public ItemFactura(string prod, int cant) {
            this.Cantidad = cant;
            this.producto = prod;
        }
        #endregion

        #region Propiedades
        private string producto;
        public string Producto
        {
            get { return producto; }
        }

        public int Cantidad { get; set; }

        public double PrecioUnitario { get; set; }
        private bool descuento;
        public bool Descuento { get { return descuento; } }

        public double SubTotal { get { return PrecioUnitario * Cantidad;  } }
        #endregion

        public void DescontarHandler(bool desc) {
            PrecioUnitario = PrecioUnitario * 0.90;
        }

    }
}
