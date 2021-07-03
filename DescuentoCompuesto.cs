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
        public DescuentoCompuesto()
        {
            Estrategias = new List<IEstrategiaFijarPreciosVenta>();
        }

        public void AddEstrategias(params IEstrategiaFijarPreciosVenta[] estrategias)
        {
            Estrategias.AddRange(estrategias);
        }

        public abstract double GetDescuento(Venta venta);

        public abstract string GetDescuentoDescripcion(Venta venta);

        public abstract double GetTotal(Venta venta);
    }
}
