using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CompositeExample
{
    public class Factory
    {
        private static Factory _instance;
        public static Factory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Factory();
                }
                return _instance;
            }
        }

        public IEstrategiaFijarPreciosVenta GestorDescuentosVigentes(params IEstrategiaFijarPreciosVenta[] estrategias)
        {
            try
            {
                var builder = new ConfigurationBuilder()
                    .AddJsonFile($"appSettings.json", true, true);

                var config = builder.Build();

                string className = config["Implementation"];
                Assembly assem = typeof(Factory).Assembly;
                DescuentoCompuesto p = (DescuentoCompuesto)assem.CreateInstance(className);
                p.AddEstrategias(estrategias);
                Console.WriteLine($"Usando {p.GetType().Name} ");
                return p;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
