﻿using CompositeExample.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    public class DescuentoMejorEmpresa : DescuentoCompuesto
    {
        public DescuentoMejorEmpresa(params IEstrategiaFijarPreciosVenta[] estrategias)
            : base(estrategias)
        {

        }
        public override double GetDescuento(Venta venta)
        {
            double descuento = this.Estrategias?.First()?.GetDescuento(venta) ?? 0;
            foreach (var estrategia in this.Estrategias)
            {
                double esteDescuento = estrategia.GetDescuento(venta);

                if (esteDescuento < descuento)
                {
                    descuento = esteDescuento;
                }
            }

            return descuento;
        }

        public override string GetDescuentoDescripcion(Venta venta)
        {
            return $"Descuento{GetDescuento(venta)}";
        }

        public override double GetTotal(Venta venta)
        {
            return venta.GetTotal() - GetDescuento(venta);
        }
    }
}