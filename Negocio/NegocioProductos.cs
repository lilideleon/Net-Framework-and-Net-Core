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
    public class NegocioProductos
    {
        Repuestos Producto = new Repuestos();

        public bool insertarRepuesto (EntidadRepuestos entidad)
        {
            return Producto.InsertarRepuesto(entidad);
        }

        public bool actualizarRepuesto(EntidadRepuestos entidad)
        {
            return Producto.ActualizarRepuesto(entidad);
        }

        public bool eliminarRepuesto(EntidadRepuestos entidad)
        {
            return Producto.EliminarRepuesto(entidad);
        }

        public DataTable listarProductos ()
        {
            return Producto.ListarRepuestos();
        }

        public EntidadRepuestos consultarProducto (int Id)
        {
            return Producto.ConsultarRepuesto(Id);
        }

    }
}
