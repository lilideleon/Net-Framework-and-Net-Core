using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
using System.Data;

namespace Negocio
{
    public class NegocioAsociar
    {
        Asociar Producto = new Asociar();

        public bool insertarRepuesto(EntidadAsociar entidad)
        {
            return Producto.Insertar(entidad);
        }
    }
}
