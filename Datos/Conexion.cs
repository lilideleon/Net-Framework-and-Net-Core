using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    class Conexion
    {
        //CADENA DE CONEXION

        private SqlConnection CadenaConexion = new SqlConnection("Server=DESKTOP-5RLBNDP\\SQLEXPRESS;DataBase= Repuestos;Integrated Security=true");

        //"data source = ServidorSQL; initial catalog = BaseDatos; user id = Usuario; password = Contraseña";

        //METODO PARA ABRIR LA CONEXION
        public SqlConnection AbrirConexion()
        {
            if (CadenaConexion.State == ConnectionState.Closed)
                CadenaConexion.Open();
            return CadenaConexion;
        }

        //METODO PARA CERRAR CONEXION
        public SqlConnection CerrarConexion()
        {
            if (CadenaConexion.State == ConnectionState.Open)
                CadenaConexion.Close();
            return CadenaConexion;
        }
    }
}
