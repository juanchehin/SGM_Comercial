using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Compras
    {
        private int _IdCompra;
        private string _Producto;
        private string _Proveedor;
        private string _Cantidad;

        public int IdCompra { get => _IdCompra; set => _IdCompra = value; }
        public string Producto { get => _Producto; set => _Producto = value; }
        public string Proveedor { get => _Proveedor; set => _Proveedor = value; }
        public string Cantidad { get => _Cantidad; set => _Cantidad = value; }

        // private string _TextoBuscar;

        //Constructores
        public CD_Compras()
        {

        }

        public CD_Compras(int IdCompra, string Producto, string Proveedor, string Descripcion, string Cantidad)
        {
            this.IdCompra = IdCompra;
            this.Producto = Producto;
            this.Proveedor = Proveedor;
            this.Cantidad = Cantidad;


        }

        // ==================================================
        //  Permite devolver todos las compras de la BD ordenada por fecha
        // ==================================================
        private CD_Conexion conexion = new CD_Conexion();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();
        public DataTable MostrarCompras()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_dame_compras";

            tabla.Clear();
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        // Devuelve un solo compra dado un ID
        public DataTable MostrarCompra(int IdCompra)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_dame_compra";

            MySqlParameter pIdCompra = new MySqlParameter();
            pIdCompra.ParameterName = "@pIdCompra";
            pIdCompra.MySqlDbType = MySqlDbType.Int32;
            // pIdProducto.Size = 60;
            pIdCompra.Value = IdCompra;
            comando.Parameters.Add(pIdCompra);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return tabla;

        }

        //Métodos
        //Insertar
        public string Insertar(CD_Compras Compra)
        {
            string rpta = "";
            try
            {


                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_alta_compra";



                MySqlParameter pProducto = new MySqlParameter();
                pProducto.ParameterName = "@pProducto";
                pProducto.MySqlDbType = MySqlDbType.VarChar;
                pProducto.Size = 60;
                pProducto.Value = Compra.Producto;
                comando.Parameters.Add(pProducto);

                MySqlParameter pProveedor = new MySqlParameter();
                pProveedor.ParameterName = "@pProveedor";
                pProveedor.MySqlDbType = MySqlDbType.VarChar;
                pProveedor.Size = 30;
                pProveedor.Value = Compra.Proveedor;
                comando.Parameters.Add(pProveedor);

                MySqlParameter pCantidad = new MySqlParameter();
                pCantidad.ParameterName = "@pCantidad";
                pCantidad.MySqlDbType = MySqlDbType.Int32;  // Ver por que esta definido como string
                // pCantidad.Size = 60;
                pCantidad.Value = Compra.Cantidad;
                comando.Parameters.Add(pCantidad);



                

                // Console.WriteLine("el comando es : " + comando.ExecuteScalar());
                //Ejecutamos nuestro comando

                // ExecuteNonQuery devuelve el numero de filas afectadas
                rpta = (string)comando.ExecuteScalar();//  == "Ok";//  : "NO se Ingreso el Registro";
                comando.Parameters.Clear();

                if (rpta == "Ok")
                {
                    rpta = "Ok";
                    // return rpta;
                }

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
        // Metodo ELIMINAR Empleado (da de baja)
        public string Eliminar(CD_Compras Compra)
        {
            string rpta = "";
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_eliminar_compra";

                MySqlParameter pIdCompra = new MySqlParameter();
                pIdCompra.ParameterName = "@pIdCompra";
                pIdCompra.MySqlDbType = MySqlDbType.Int32;
                // pIdEmpleado.Size = 60;
                pIdCompra.Value = Compra.IdCompra;
                comando.Parameters.Add(pIdCompra);

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

        public string Editar(CD_Compras Compra)
        {
            string rpta = "";
            comando.Parameters.Clear();// si no ponerlo al comienzo de esta funcion
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_editar_compra";

                MySqlParameter pIdCompra = new MySqlParameter();
                pIdCompra.ParameterName = "@pIdCompra";
                pIdCompra.MySqlDbType = MySqlDbType.Int32;
                // pIdEmpleado.Size = 60;
                pIdCompra.Value = Compra.IdCompra;
                comando.Parameters.Add(pIdCompra);

                MySqlParameter pProducto = new MySqlParameter();
                pProducto.ParameterName = "@pProducto";
                pProducto.MySqlDbType = MySqlDbType.VarChar;
                pProducto.Size = 60;
                pProducto.Value = Compra.Producto;
                comando.Parameters.Add(pProducto);

                MySqlParameter pProveedor = new MySqlParameter();
                pProveedor.ParameterName = "@pProveedor";
                pProveedor.MySqlDbType = MySqlDbType.VarChar;
                pProveedor.Size = 30;
                pProveedor.Value = Compra.Proveedor;
                comando.Parameters.Add(pProveedor);

                MySqlParameter pCantidad = new MySqlParameter();
                pCantidad.ParameterName = "@pCantidad";
                pCantidad.MySqlDbType = MySqlDbType.Int32;
                // pPrecioCompra.Size = 60;
                pCantidad.Value = Compra.Cantidad;
                comando.Parameters.Add(pCantidad);

                //Ejecutamos nuestro comando

                rpta = comando.ExecuteScalar().ToString() == "Ok" ? "Ok" : "No se edito el Registro";



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
