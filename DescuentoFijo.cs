using CompositeExample.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    public class DescuentoFijo : IEstrategiaFijarPreciosVenta
    {
        private double porcentaje;
        private double descuento;
        public DescuentoFijo()
        {
            porcentaje = 30;
            descuento = 0;
            this.porcentaje = porcentaje / 100.0;
        }
        private double CalcularDescuento(Venta venta)
        {
            double valor = Math.Round(porcentaje * 100.0) / 100.0;
            descuento = venta.GetSubtotal() * valor;
            return descuento;
        }
        public double GetTotal(Venta venta)
        {
            return venta.GetTotal() - CalcularDescuento(venta);
        }

        public double GetDescuento(Venta venta)
        {
            return CalcularDescuento(venta);
        }

        public String GetDescuentoDescripcion(Venta venta)
        {
            return "Porcentaje de descuento=" + porcentaje * 100 + "%.";
        }
    }
}
