using CompositeExample.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    public abstract class DescuentoCompuesto : IEstrategiaFijarPreciosVenta
    {
        protected List<IEstrategiaFijarPreciosVenta> Estrategias;
        public DescuentoCompuesto(params IEstrategiaFijarPreciosVenta[] estrategias)
        {
            Estrategias = estrategias.ToList();
        }

        public abstract double GetDescuento(Venta venta);

        public abstract string GetDescuentoDescripcion(Venta venta);

        public abstract double GetTotal(Venta venta);
    }
}
