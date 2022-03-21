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
    public class Repuestos
    {

        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        private SqlCommand comando = new SqlCommand();
        EntidadRepuestos entidad = new EntidadRepuestos();
        private bool Realizado = false;


        public bool InsertarRepuesto(EntidadRepuestos Repuestos)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "InsertarRepuestos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", Repuestos.Nombre);
                comando.Parameters.AddWithValue("@Tipo", Repuestos.Tipo);
                comando.Parameters.AddWithValue("@Descripcion", Repuestos.Descripcion);
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

        public bool ActualizarRepuesto(EntidadRepuestos Repuestos)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ActualizarRepuestos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", Repuestos.Id);
                comando.Parameters.AddWithValue("@Nombre", Repuestos.Nombre);
                comando.Parameters.AddWithValue("@Tipo", Repuestos.Tipo);
                comando.Parameters.AddWithValue("@Descripcion", Repuestos.Descripcion);
                comando.ExecuteNonQuery();
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

        public bool EliminarRepuesto(EntidadRepuestos Repuestos)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarRepuestos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", Repuestos.Id);
                comando.ExecuteNonQuery();
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

        public DataTable ListarRepuestos()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ListarRepuestos";
                leer = comando.ExecuteReader();
                tabla.Load(leer);
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return tabla;
        }


        public EntidadRepuestos ConsultarRepuesto(int Id)
        {
            try
            {
                SqlDataReader dt;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "DevolverProducto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", Id);
                dt = comando.ExecuteReader();
                //comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                if (dt.HasRows)
                {
                    dt.Read();
                    entidad.Id = Convert.ToInt32(dt[0]);
                    entidad.Nombre = Convert.ToString(dt[1]);
                    entidad.Tipo = Convert.ToInt32(dt[2]);
                    entidad.Descripcion = Convert.ToString(dt[3]);
                }
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return entidad;
        }
    }
}
