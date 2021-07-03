using CompositeExample.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    public class DescuentoEdadCliente : IEstrategiaFijarPreciosVenta
    {
        private int edad = 50;
        private double porcentaje;

        public DescuentoEdadCliente()
        {
            porcentaje = 10;//porcentaje=consultarEnBaseDatos();        
            this.porcentaje = porcentaje / 100.0;
        }
        private double CalcularDescuento(Venta venta)
        {
            double valor;

            if (venta.EdadCliente >= edad)
                valor = Math.Round(porcentaje * 100.0) / 100.0;
            else
                valor = 0;

            return venta.GetSubtotal() * valor;
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
            return "Descuento del " + this.porcentaje + " para Clientes mayores de  >=" + this.edad;
        }

    }
}
