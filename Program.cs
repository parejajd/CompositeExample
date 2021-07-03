using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompositeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var desc1 = new DescuentoAbsoluto();
            var desc2 = new DescuentoEdadCliente();
            var desc3 = new DescuentoFijo();

            VentaEspecializada venta = new VentaEspecializada
            {
                EdadCliente = 51,
                SubTotal = 10000
            };

            Console.WriteLine("Valor del subtotal= " + venta.GetSubtotal());
            Console.WriteLine("Valor del descuento= " + venta.CalcularDescuentos(desc1, desc2, desc3));
            Console.WriteLine("Valor del total= " + venta.GetTotal());
        }
    }
}
