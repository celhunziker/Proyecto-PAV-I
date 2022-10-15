using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos
{
    class BDHelper 
    {
        enum ResultadoTransacción
        {
            exito, fracaso
        }
        enum TipoConexion
        {
            simple, transaccion
        }
        private static BDHelper instancia;
        private SqlConnection conexion;
        private SqlCommand comando;
        private string cadenaConexion;
        private SqlTransaction transaccion;
        private ResultadoTransacción miEstado = ResultadoTransacción.exito;
        private TipoConexion miTipo = TipoConexion.simple;
        private BDHelper() 
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            cadenaConexion = @"Data Source=valentina\sqlexpress;Initial Catalog=TPPAV2;Integrated Security=True"; //Properties.Resources.StringConexion;
        }
        public static BDHelper obtenerInstancia()
        {
            if (instancia == null)
                instancia = new BDHelper();
            return instancia;
        }
        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            return tabla;
        }

        public int actualizar(string consultaSQL)
        {
            int filasAfectadas = 0;
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            filasAfectadas = comando.ExecuteNonQuery();

            conexion.Close();
            return filasAfectadas;
        }

        //CAMBIAR CON VARIABLES DE ESTE PROYECTO
        public void conectarConTransaccion()
        {
            miTipo = TipoConexion.transaccion;
            miEstado = ResultadoTransacción.exito;

            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            comando.Transaction = transaccion;
            comando.Connection = conexion;
        }

        public bool Desconectar()
        {
            if (miTipo == TipoConexion.transaccion)
            {
                if (miEstado == ResultadoTransacción.exito)
                {
                    transaccion.Commit();
                }
                else
                {
                    transaccion.Rollback();
                }
                miTipo = TipoConexion.simple;
            }
            if ((conexion.State == ConnectionState.Open))
            {
                conexion.Close();
            }
            conexion.Dispose();
            if (miEstado.Equals(ResultadoTransacción.exito))
                return true;
            else
                return false;
        }

        public void EjecutarConTransaccion(string consulta)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = consulta;
                comando.ExecuteNonQuery();
            }
            catch
            {
                miEstado = ResultadoTransacción.fracaso;
            }
        }

        public object ConsultaSQLScalar(string consulta) //Ejecuta una query que devuelve un sólo valor
        {
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
            return comando.ExecuteScalar();
        }



        //public void EjecutarSQLConTransaccion(string strSql)
        //{
        //    //  Se utiliza para sentencias SQL del tipo Insert, Update, Delete con transaccion.
        //    try
        //    {
        //        comando.CommandType = CommandType.Text;
        //        comando.CommandText = strSql;
        //        comando.ExecuteNonQuery();
        //    }
        //    catch
        //    {
        //        miEstado = ResultadoTransaccion.fracaso;
        //    }
        //}
        //public void conectarConTransaccion()
        //{
        //    miTipo = tipoConexion.transaccion;
        //    miEstado = ResultadoTransaccion.exito;
        //    conexion.ConnectionString = cadenaConexion;
        //    conexion.Open();
        //    transaccion = conexion.BeginTransaction();
        //    comando.Transaction = transaccion;
        //    comando.Connection = conexion;
        //}
        //public void desconectar()
        //{
        //    if (miTipo == tipoConexion.transaccion)
        //    {
        //        if (miEstado == ResultadoTransaccion.exito)
        //        {
        //            transaccion.Commit();

        //            //MessageBox.Show("La trasacción resultó con éxito...");
        //        }
        //        else
        //        {
        //            transaccion.Rollback();
        //            //MessageBox.Show("La trasacción no pudo realizarce...");
        //        }
        //        miTipo = tipoConexion.simple;
        //    }

        //    if ((conexion.State == ConnectionState.Open))
        //    {
        //        conexion.Close();
        //    }

        //    // Dispose() libera los recursos asociados a la conexón
        //    conexion.Dispose();

        //}
    }
}
