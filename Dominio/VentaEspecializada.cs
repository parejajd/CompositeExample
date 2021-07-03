using CompositeExample.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    public class VentaEspecializada : Venta
    {
        private readonly Factory _factory;

        public VentaEspecializada()
        {
            this._factory = Factory.Instance;
        }

        public override double CalcularDescuentos(params IEstrategiaFijarPreciosVenta[] descuentos)
        {
            var gestor = this._factory.GestorDescuentosVigentes(descuentos);
            return gestor.GetDescuento(this);
        }

        public override double GetSubtotal()
        {
            return this.SubTotal;
        }

        public override double GetTotal()
        {
            return this.SubTotal - CalcularDescuentos();
        }
    }
}
