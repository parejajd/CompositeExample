using CompositeExample.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    public class DescuentoAbsoluto : IEstrategiaFijarPreciosVenta
    {
        private double Descuento { get; set; }
        private double Umbral { get; set; }

        public DescuentoAbsoluto()
        {
            Descuento = 10;
            Umbral = 150;
        }

        private double CalcularDescuento(Venta venta)
        {
            if (venta.GetSubtotal() >= Umbral)
                return Descuento;
            else
                return 0;
        }

        public double GetDescuento(Venta venta)
        {
            if (venta.GetSubtotal() >= Umbral)
                return CalcularDescuento(venta);
            else
                return 0;
        }

        public string GetDescuentoDescripcion(Venta venta)
        {
            return "Descuento=" + Descuento + " para un umbral de venta >=" + Umbral;
        }

        public double GetTotal(Venta venta)
        {
            return venta.GetTotal() - CalcularDescuento(venta);
        }
    }
}
