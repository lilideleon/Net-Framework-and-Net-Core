using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class Asociar
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        private SqlCommand comando = new SqlCommand();
        EntidadAsociar entidad = new EntidadAsociar();
        private bool Realizado = false;

        public bool Insertar(EntidadAsociar Bode)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "InsertarInventario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Producto", Bode.Producto);
                comando.Parameters.AddWithValue("@Existencia", Bode.Existencia);
                comando.Parameters.AddWithValue("@Bodega", Bode.Bodega);
                comando.Parameters.AddWithValue("@Ubicacion", Bode.Ubicacion);
                comando.Parameters.AddWithValue("@Minimo", Bode.Minimo);
                comando.Parameters.AddWithValue("@Maximo", Bode.Maximo);
                comando.Parameters.AddWithValue("@Precio", Bode.precio);
                comando.ExecuteNonQuery();
                Realizado = true;
                comando.Parameters.Clear();
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return Realizado;
        }
    }
}
