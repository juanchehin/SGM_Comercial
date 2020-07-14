// Agregados
using MySql.Data.MySqlClient;
using System;
using System.Data;
// using System.Data.MySqlClient;


namespace CapaDatos
{
    public class CD_Productos
    {
        private int _IdProducto;
        private string _Producto;
        private string _Codigo;
        private string _Descripcion;
        private string _Stock;
        private string _PrecioCompra;
        private string _PrecioVenta;
        private string _EstadoProd;

        private string _TextoBuscar;



        public int IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public string Producto { get => _Producto; set => _Producto = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Stock { get => _Stock; set => _Stock = value; }
        public string EstadoProd { get => _EstadoProd; set => _EstadoProd = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string PrecioCompra { get => _PrecioCompra; set => _PrecioCompra = value; }
        public string PrecioVenta { get => _PrecioVenta; set => _PrecioVenta = value; }

        //Constructores
        public CD_Productos()
        {

        }

        public CD_Productos(int IdProducto, string Producto,string Codigo,string Descripcion,string PrecioVenta,string PrecioCompra, string Stock, string EstadoProd, string textobuscar)
        {
            this.IdProducto = IdProducto;
            this.Producto = Producto;
            this.Codigo = Codigo;
            this.PrecioVenta = PrecioVenta;
            this.PrecioCompra = PrecioCompra;
            this.Descripcion = Descripcion;
            this.Stock = Stock;
            this.EstadoProd = EstadoProd;
            this.TextoBuscar = textobuscar;

        }

        // ==================================================
        //  Permite devolver todos los productos de la BD
        // ==================================================
        private CD_Conexion conexion = new CD_Conexion();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_dame_productos";

            tabla.Clear();
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        // Devuelve un solo producto dado un ID
        public DataTable MostrarProducto(int IdProducto)
        {
            Console.WriteLine("IdProducto en capa datos es : " + IdProducto);
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_dame_producto";

            MySqlParameter pIdProducto = new MySqlParameter();
            pIdProducto.ParameterName = "@pIdProducto";
            pIdProducto.MySqlDbType = MySqlDbType.Int32;
            // pIdProducto.Size = 60;
            pIdProducto.Value = IdProducto;
            comando.Parameters.Add(pIdProducto);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Console.WriteLine("tabla en capa datos es : " + tabla);
            Console.WriteLine("leer en capa datos es : " + leer.ToString());
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            
            return tabla;

        }

        //Métodos
        //Insertar
        public string Insertar(CD_Productos Producto)
        {
            string rpta = "";
            // SqlConnection SqlCon = new SqlConnection();
            try
            {

                Console.WriteLine("Producto es : " + Producto.Producto);

                //Código
                /*SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand(); */

                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_alta_producto";

                /*SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_articulo";
                SqlCmd.CommandType = CommandType.StoredProcedure; */


                MySqlParameter pProducto = new MySqlParameter();
                pProducto.ParameterName = "@pProducto";
                pProducto.MySqlDbType = MySqlDbType.VarChar;
                pProducto.Size = 60;
                pProducto.Value = Producto.Producto;
                comando.Parameters.Add(pProducto);

                MySqlParameter pCodigo = new MySqlParameter();
                pCodigo.ParameterName = "@pCodigo";
                pCodigo.MySqlDbType = MySqlDbType.VarChar;
                pCodigo.Size = 30;
                pCodigo.Value = Producto.Codigo;
                comando.Parameters.Add(pCodigo);

                MySqlParameter pPrecioCompra = new MySqlParameter();
                pPrecioCompra.ParameterName = "@pPrecioCompra";
                pPrecioCompra.MySqlDbType = MySqlDbType.VarChar;
                pPrecioCompra.Size = 60;
                pPrecioCompra.Value = Producto.PrecioCompra;
                comando.Parameters.Add(pPrecioCompra);

                MySqlParameter pPrecioVenta = new MySqlParameter();
                pPrecioVenta.ParameterName = "@pPrecioVenta";
                pPrecioVenta.MySqlDbType = MySqlDbType.VarChar;
                pPrecioVenta.Size = 60;
                pPrecioVenta.Value = Producto.PrecioVenta;
                comando.Parameters.Add(pPrecioVenta);

                MySqlParameter pStock = new MySqlParameter();
                pStock.ParameterName = "@pStock";
                pStock.MySqlDbType = MySqlDbType.Int16;
                pStock.Size = 40;
                pStock.Value = Producto.Stock;
                comando.Parameters.Add(pStock);

                MySqlParameter pDescripcion = new MySqlParameter();
                pDescripcion.ParameterName = "@pDescripcion";
                pDescripcion.MySqlDbType = MySqlDbType.VarChar;
                pDescripcion.Size = 60;
                pDescripcion.Value = Producto.Descripcion;
                comando.Parameters.Add(pDescripcion);

                

                Console.WriteLine("rpta es : " + rpta );

                // Console.WriteLine("el comando es : " + comando.CommandText[0]);
                //Ejecutamos nuestro comando

                // ExecuteNonQuery devuelve el numero de filas afectadas
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                comando.Parameters.Clear();

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                conexion.CerrarConexion();
            }
            
            return rpta;

        }
        // Metodo ELIMINAR Empleado (da de baja)
        public string Eliminar(CD_Productos Producto)
        {
            string rpta = "";
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_eliminar_producto";

                MySqlParameter pIdProducto = new MySqlParameter();
                pIdProducto.ParameterName = "@pIdProducto";
                pIdProducto.MySqlDbType = MySqlDbType.Int32;
                // pIdEmpleado.Size = 60;
                pIdProducto.Value = Producto.IdProducto;
                comando.Parameters.Add(pIdProducto);

                //Ejecutamos nuestro comando

                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";

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

        public string Editar(CD_Productos Producto)
        {
            Console.WriteLine("Produco.IdProducto es 1 : " + Producto.IdProducto);
            string rpta = "";
            comando.Parameters.Clear();// si no ponerlo al comienzo de esta funcion
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_editar_producto";

                MySqlParameter pIdProducto = new MySqlParameter();
                pIdProducto.ParameterName = "@pIdProducto";
                pIdProducto.MySqlDbType = MySqlDbType.Int32;
                // pIdEmpleado.Size = 60;
                pIdProducto.Value = Producto.IdProducto;
                comando.Parameters.Add(pIdProducto);

                Console.WriteLine("Produco.IdProducto es : " + Producto.IdProducto);

                MySqlParameter pProducto = new MySqlParameter();
                pProducto.ParameterName = "@pProducto";
                pProducto.MySqlDbType = MySqlDbType.VarChar;
                pProducto.Size = 60;
                pProducto.Value = Producto.Producto;
                comando.Parameters.Add(pProducto);

                MySqlParameter pCodigo = new MySqlParameter();
                pCodigo.ParameterName = "@pCodigo";
                pCodigo.MySqlDbType = MySqlDbType.VarChar;
                pCodigo.Size = 30;
                pCodigo.Value = Producto.Codigo;
                comando.Parameters.Add(pCodigo);

                MySqlParameter pPrecioCompra = new MySqlParameter();
                pPrecioCompra.ParameterName = "@pPrecioCompra";
                pPrecioCompra.MySqlDbType = MySqlDbType.Decimal;
                // pPrecioCompra.Size = 60;
                pPrecioCompra.Value = Producto.PrecioCompra;
                comando.Parameters.Add(pPrecioCompra);

                MySqlParameter pPrecioVenta = new MySqlParameter();
                pPrecioVenta.ParameterName = "@pPrecioVenta";
                pPrecioVenta.MySqlDbType = MySqlDbType.Decimal;
                // pIdEmpleado.Size = 60;
                pPrecioVenta.Value = Producto.PrecioVenta;
                comando.Parameters.Add(pPrecioVenta);

                MySqlParameter pStock = new MySqlParameter();
                pStock.ParameterName = "@pStock";
                pStock.MySqlDbType = MySqlDbType.Int32;
                // pIdEmpleado.Size = 60;
                pStock.Value = Producto.Stock;
                comando.Parameters.Add(pStock);

                MySqlParameter pDescripcion = new MySqlParameter();
                pDescripcion.ParameterName = "@pDescripcion";
                pDescripcion.MySqlDbType = MySqlDbType.VarChar;
                pDescripcion.Size = 60;
                pDescripcion.Value = Producto.Descripcion;
                comando.Parameters.Add(pDescripcion);

                // Console.WriteLine("comando.Executeexe() es : " + comando.ExecuteReader().ToString());

                //Console.WriteLine("comando.ExecuteScalar().ToString() es : " + comando.ExecuteScalar().ToString());

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

        public DataTable BuscarProducto(CD_Productos Producto)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_buscar_producto";

                MySqlParameter pTextoBuscar = new MySqlParameter();
                pTextoBuscar.ParameterName = "@pTextoBuscar";
                pTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                pTextoBuscar.Size = 30;
                pTextoBuscar.Value = Producto.TextoBuscar;
                comando.Parameters.Add(pTextoBuscar);

                leer = comando.ExecuteReader();
                tabla.Load(leer);
                Console.WriteLine("tabla en capa datos es : " + tabla);
                Console.WriteLine("leer en capa datos es : " + leer.ToString());
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                // return tabla;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Entro en el catch y tabla es en capa datos" + tabla);
                Console.WriteLine("Entro en el catch y ex es en capa datos" + ex.Message);

                tabla = null;
            }
            return tabla;

        }
    }
}
