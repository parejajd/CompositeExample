using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample.Dominio
{
    public abstract class Venta
    {
        public double SubTotal { get; set; }
        protected double Total { get; set; }
        public int EdadCliente { get; set; }
        public abstract double GetTotal();
        public abstract double CalcularDescuentos(params IEstrategiaFijarPreciosVenta[] descuentos);
        public abstract double GetSubtotal();
    }
}
