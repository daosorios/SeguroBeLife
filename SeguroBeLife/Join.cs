using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BeLife.Datos;
namespace SeguroBeLife
{
    public class Join
    {
        internal static void Syncronize(object origen, object destino)
        {
            Type tipo = null;
            PropertyInfo[] propiedades = null;
            tipo = origen.GetType();
            propiedades = tipo.GetProperties();

            foreach (PropertyInfo propiedad in propiedades)
            {
                try
                {
                    PropertyInfo propInfo = destino.GetType().GetProperty(propiedad.Name);

                    propInfo.SetValue(destino, propiedad.GetValue(origen, null));
                }
                catch {/* Nel Bruhh*/}
            }
        }
    }
}
