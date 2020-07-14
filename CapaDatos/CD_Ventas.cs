using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Ventas
    {
        private int _IdVenta;
        private string _Producto;
        private string _Titular;
        private int _IdEmpleado;
        private string _Cantidad;

        public int IdVenta { get => _IdVenta; set => _IdVenta = value; }
        public string Titular { get => _Titular; set => _Titular = value; }
        public int IdEmpleado { get => _IdEmpleado; set => _IdEmpleado = value; }
        public string Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public string Producto { get => _Producto; set => _Producto = value; }

        //Constructores
        public CD_Ventas()
        {

        }

        public CD_Ventas(int IdVenta, string Producto, string Titular, int IdEmpleado, string Cantidad)
        {
            this.IdVenta = IdVenta;
            this.Producto = Producto;
            this.Titular = Titular;
            this.IdEmpleado = IdEmpleado;
            this.Cantidad = Cantidad;


        }

        // ==================================================
        //  Permite devolver todos las compras de la BD ordenada por fecha
        // ==================================================
        private CD_Conexion conexion = new CD_Conexion();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();



        public DataTable MostrarVentas()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_dame_ventas";

            tabla.Clear();
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        // Devuelve un solo compra dado un ID
        public DataTable MostrarVenta(int IdVenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_dame_venta";

            MySqlParameter pIdVenta = new MySqlParameter();
            pIdVenta.ParameterName = "@pIdVenta";
            pIdVenta.MySqlDbType = MySqlDbType.Int32;
            // pIdProducto.Size = 60;
            pIdVenta.Value = IdVenta;
            comando.Parameters.Add(pIdVenta);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return tabla;

        }

        //Métodos
        //Insertar
        public string Insertar(CD_Ventas Venta)
        {
            string rpta = "";
            try
            {


                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_alta_venta";



                MySqlParameter pProducto = new MySqlParameter();
                pProducto.ParameterName = "@pProducto";
                pProducto.MySqlDbType = MySqlDbType.VarChar;
                pProducto.Size = 60;
                pProducto.Value = Venta.Producto;
                comando.Parameters.Add(pProducto);

                MySqlParameter pTitular = new MySqlParameter();
                pTitular.ParameterName = "@pTitular";
                pTitular.MySqlDbType = MySqlDbType.VarChar;
                pTitular.Size = 30;
                pTitular.Value = Venta.Titular;
                comando.Parameters.Add(pTitular);


                MySqlParameter pIdEmpleado = new MySqlParameter();
                pIdEmpleado.ParameterName = "@pIdEmpleado";
                pIdEmpleado.MySqlDbType = MySqlDbType.Int32;
                // pIdProducto.Size = 60;
                pIdEmpleado.Value = Venta.IdEmpleado;
                comando.Parameters.Add(pIdEmpleado);

                MySqlParameter pCantidad = new MySqlParameter();
                pCantidad.ParameterName = "@pCantidad";
                pCantidad.MySqlDbType = MySqlDbType.VarChar;  // Ver por que esta definido como string
                pCantidad.Size = 10;
                pCantidad.Value = Venta.Cantidad;
                comando.Parameters.Add(pCantidad);

                rpta = (string)comando.ExecuteScalar();//  == "Ok";//  : "NO se Ingreso el Registro";
                Console.WriteLine("rpta es : " + rpta);
                comando.Parameters.Clear();

                /*if (rpta == "Ok")
                {
                    rpta = "Ok";
                    return rpta;
                }*/

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                conexion.CerrarConexion();
            }
            Console.WriteLine("rpta es : " + rpta);
            return rpta;

        }

        // Metodo ELIMINAR venta
        public string Eliminar(CD_Ventas Venta)
        {
            string rpta = "";
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_eliminar_venta";

                MySqlParameter pIdVenta = new MySqlParameter();
                pIdVenta.ParameterName = "@pIdVenta";
                pIdVenta.MySqlDbType = MySqlDbType.Int32;
                // pIdEmpleado.Size = 60;
                pIdVenta.Value = Venta.IdVenta;
                comando.Parameters.Add(pIdVenta);

                //Ejecutamos nuestro comando

                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";
                Console.WriteLine("rpta es ; " + rpta);

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                //if (conexion. == ConnectionState.Open) 
                conexion.CerrarConexion();
            }
            comando.Parameters.Clear();
            return rpta;
        }

        public string Editar(CD_Ventas Venta)
        {
            string rpta = "";
            comando.Parameters.Clear();// si no ponerlo al comienzo de esta funcion
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_editar_venta";

                MySqlParameter pIdVenta = new MySqlParameter();
                pIdVenta.ParameterName = "@pIdVenta";
                pIdVenta.MySqlDbType = MySqlDbType.Int32;
                // pIdEmpleado.Size = 60;
                pIdVenta.Value = Venta.IdVenta;
                comando.Parameters.Add(pIdVenta);

                MySqlParameter pProducto = new MySqlParameter();
                pProducto.ParameterName = "@pProducto";
                pProducto.MySqlDbType = MySqlDbType.VarChar;
                pProducto.Size = 60;
                pProducto.Value = Venta.Producto;
                comando.Parameters.Add(pProducto);

                MySqlParameter pTitular = new MySqlParameter();
                pTitular.ParameterName = "@pTitular";
                pTitular.MySqlDbType = MySqlDbType.VarChar;
                pTitular.Size = 30;
                pTitular.Value = Venta.Titular;
                comando.Parameters.Add(pTitular);


                MySqlParameter pIdEmpleado = new MySqlParameter();
                pIdEmpleado.ParameterName = "@pIdEmpleado";
                pIdEmpleado.MySqlDbType = MySqlDbType.Int32;
                // pIdProducto.Size = 60;
                pIdEmpleado.Value = Venta.IdEmpleado;
                comando.Parameters.Add(pIdEmpleado);

                MySqlParameter pCantidad = new MySqlParameter();
                pCantidad.ParameterName = "@pCantidad";
                pCantidad.MySqlDbType = MySqlDbType.Int32;  // Ver por que esta definido como string
                // pCantidad.Size = 60;
                pCantidad.Value = Venta.Cantidad;
                comando.Parameters.Add(pCantidad);


                //Ejecutamos nuestro comando

                rpta = comando.ExecuteScalar().ToString() == "Ok" ? "OK" : "No se edito el Registro";



            }
            catch (Exception ex)
            {

                rpta = ex.Message;
                Console.WriteLine("rpta es : " + rpta);
            }
            finally
            {
                //if (conexion. == ConnectionState.Open) 
                conexion.CerrarConexion();
            }
            comando.Parameters.Clear();
            return rpta;
        }
    }
}
