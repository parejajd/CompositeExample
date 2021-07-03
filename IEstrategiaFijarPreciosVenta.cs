using CompositeExample.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    public interface IEstrategiaFijarPreciosVenta
    {
        double GetTotal(Venta venta);
        double GetDescuento(Venta venta);
        string GetDescuentoDescripcion(Venta venta);
    }
}
