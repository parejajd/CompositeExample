using System;
using System.Collections.Generic;
using System.Linq;
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
                /*
                    ResourceBundle rb = ResourceBundle.getBundle("patron.singleton.propiedades");
                    String c = rb.getString(clase);            
                    obj=Class.forName(c).newInstance();            
                    gestorDescuentosVigentes=(IEstrategiaFijarPreciosVenta)obj;
                    return gestorDescuentosVigentes;                 
                 */
                return new DescuentoMejorCliente(estrategias);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
