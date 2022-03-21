using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EntidadAsociar
    {
        public int Id { get; set; }
        public int Producto { get; set; }
        public int Existencia { get; set; }
        public int Bodega { get; set; }
        public String Ubicacion { get; set; }
        public int Minimo { get; set; }
        public int Maximo { get; set; }
        public float precio { get; set; }
    }
}
