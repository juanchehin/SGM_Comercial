using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Proveedores
    {
        private int _IdProveedor;
        private string _Proveedor;
        private string _CUIL;
        private string _Direccion;
        private string _Telefono;

        private string _TextoBuscar;


        public int IdProveedor { get => _IdProveedor; set => _IdProveedor = value; }
        public string Proveedor { get => _Proveedor; set => _Proveedor = value; }
        public string CUIL { get => _CUIL; set => _CUIL = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        //Constructores
        public CD_Proveedores()
        {

        }

        public CD_Proveedores(int IdProveedor, string Proveedor, string CUIL, string Direccion, string Telefono)
        {
            this.IdProveedor = IdProveedor;
            this.Proveedor = Proveedor;
            this.CUIL = CUIL;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
        }

        // ==================================================
        //  Variables para la conexion y devolucion de datos
        // ==================================================
        private CD_Conexion conexion = new CD_Conexion();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        // ==================================================
        //  Permite devolver todos los proveedores de la BD
        // ==================================================
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_dame_proveedores";

            tabla.Clear();
            leer = comando.ExecuteReader();
            tabla.Load(leer);

            // conexion.CerrarConexion();
            return tabla;

        }

        // Devuelve un solo proveedor dado un ID
        public DataTable MostrarProveedor(int IdProveedor)
        {
            Console.WriteLine("proveedor en capa datos es : " + IdProveedor);
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_dame_proveedor";

            MySqlParameter pIdProveedor = new MySqlParameter();
            pIdProveedor.ParameterName = "@pIdProveedor";
            pIdProveedor.MySqlDbType = MySqlDbType.Int32;
            // pIdProducto.Size = 60;
            pIdProveedor.Value = IdProveedor;
            comando.Parameters.Add(pIdProveedor);

            tabla.Clear();
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
        public string Insertar(CD_Proveedores Proveedor)
        {
            string rpta = "";
            try
            {

                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_alta_proveedor";

                MySqlParameter pProveedor = new MySqlParameter();
                pProveedor.ParameterName = "@pProveedor";
                pProveedor.MySqlDbType = MySqlDbType.VarChar;
                pProveedor.Size = 60;
                pProveedor.Value = Proveedor.Proveedor;
                comando.Parameters.Add(pProveedor);

                MySqlParameter pCUIL = new MySqlParameter();
                pCUIL.ParameterName = "@pCUIL";
                pCUIL.MySqlDbType = MySqlDbType.VarChar;
                pCUIL.Size = 60;
                pCUIL.Value = Proveedor.CUIL;
                comando.Parameters.Add(pCUIL);

                MySqlParameter pDireccion = new MySqlParameter();
                pDireccion.ParameterName = "@pDireccion";
                pDireccion.MySqlDbType = MySqlDbType.VarChar;
                pDireccion.Size = 60;
                pDireccion.Value = Proveedor.Direccion;
                comando.Parameters.Add(pDireccion);

                MySqlParameter pTelefono = new MySqlParameter();
                pTelefono.ParameterName = "@pTelefono";
                pTelefono.MySqlDbType = MySqlDbType.VarChar;
                pTelefono.Size = 60;
                pTelefono.Value = Proveedor.Telefono;
                comando.Parameters.Add(pTelefono);

                // Console.WriteLine("rpta es : " + rpta);

                rpta = (string)comando.ExecuteScalar();

                if(rpta == "Ya existe un proveedor con ese CUIL")
                {
                    rpta = "Ya existe un proveedor con ese CUIL";
                    return rpta;
                }
                else
                {
                    if (rpta == "El Proveedor es obligatorio.")
                    {
                        rpta = "El Proveedor es obligatorio.";
                        return rpta;
                    }
                }
                rpta = "Ok";
                comando.Parameters.Clear();
                return rpta;

                 // == "Ok" ? "OK" : "NO se Ingreso el Registro";
                

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
        public string Eliminar(CD_Proveedores Proveedor)
        {
            Console.WriteLine("Ingreso en eliminar CD_Proveedores");
            string rpta = "";
            try
            {
                Console.WriteLine("Ingreso en eliminar CD_Proveedores 2");

                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_eliminar_proveedor";

                MySqlParameter pIdProveedor = new MySqlParameter();
                pIdProveedor.ParameterName = "@pIdProveedor";
                pIdProveedor.MySqlDbType = MySqlDbType.Int32;
                // pIdEmpleado.Size = 60;
                pIdProveedor.Value = Proveedor.IdProveedor;
                comando.Parameters.Add(pIdProveedor);

                //Ejecutamos nuestro comando
                // Console.WriteLine("comando es " + comando.ExecuteScalar() );
                // rpta = "Ok";
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";

            }
            catch (Exception ex)
            {
                Console.WriteLine("Entro en el catch y mensaje es " + ex.Message);
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

        public string Editar(CD_Proveedores Proveedor)
        {
            string rpta = "";
            comando.Parameters.Clear();// si no ponerlo al comienzo de esta funcion
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_editar_proveedor";

                MySqlParameter pIdProveedor = new MySqlParameter();
                pIdProveedor.ParameterName = "@pIdProveedor";
                pIdProveedor.MySqlDbType = MySqlDbType.Int32;
                // pIdEmpleado.Size = 60;
                pIdProveedor.Value = Proveedor.IdProveedor;
                comando.Parameters.Add(pIdProveedor);

                MySqlParameter pProveedor = new MySqlParameter();
                pProveedor.ParameterName = "@pProveedor";
                pProveedor.MySqlDbType = MySqlDbType.VarChar;
                pProveedor.Size = 60;
                pProveedor.Value = Proveedor.Proveedor;
                comando.Parameters.Add(pProveedor);

                MySqlParameter pCUIL = new MySqlParameter();
                pCUIL.ParameterName = "@pCUIL";
                pCUIL.MySqlDbType = MySqlDbType.VarChar;
                pCUIL.Size = 60;
                pCUIL.Value = Proveedor.CUIL;
                comando.Parameters.Add(pCUIL);

                MySqlParameter pDireccion = new MySqlParameter();
                pDireccion.ParameterName = "@pDireccion";
                pDireccion.MySqlDbType = MySqlDbType.VarChar;
                pDireccion.Size = 60;
                pDireccion.Value = Proveedor.Direccion;
                comando.Parameters.Add(pDireccion);

                MySqlParameter pTelefono = new MySqlParameter();
                pTelefono.ParameterName = "@pTelefono";
                pTelefono.MySqlDbType = MySqlDbType.VarChar;
                pTelefono.Size = 60;
                pTelefono.Value = Proveedor.Telefono;
                comando.Parameters.Add(pTelefono);

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

        public DataTable BuscarProveedor(CD_Proveedores Proveedor)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_buscar_proveedor";

                MySqlParameter pTextoBuscar = new MySqlParameter();
                pTextoBuscar.ParameterName = "@pTextoBuscar";
                pTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                pTextoBuscar.Size = 30;
                pTextoBuscar.Value = Proveedor.TextoBuscar;
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
