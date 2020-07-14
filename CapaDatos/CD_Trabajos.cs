using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Trabajos
    {
        private int _IdTrabajo;
        private string _Trabajo;
        private string _PrecioUnitario;

        private string _TextoBuscar;


        public int IdTrabajo { get => _IdTrabajo; set => _IdTrabajo = value; }
        public string Trabajo { get => _Trabajo; set => _Trabajo = value; }
        public string PrecioUnitario { get => _PrecioUnitario; set => _PrecioUnitario = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        //Constructores
        public CD_Trabajos()
        {

        }

        public CD_Trabajos(int IdTrabajo, string Trabajo, string PrecioUnitario)
        {
            this.IdTrabajo = IdTrabajo;
            this.Trabajo = Trabajo;
            this.PrecioUnitario = PrecioUnitario;
        }


        private CD_Conexion conexion = new CD_Conexion();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();


        // ==================================================
        //  Permite devolver todos los trabajos de la BD
        // ==================================================
        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_dame_trabajos";


            tabla.Clear();
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            // conexion.CerrarConexion();
            return tabla;

        }

        //Métodos
        //Insertar
        public string Insertar(CD_Trabajos Trabajo)
        {
            string rpta = "";
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_alta_trabajo";

                MySqlParameter pTrabajo = new MySqlParameter();
                pTrabajo.ParameterName = "@pTrabajo";
                pTrabajo.MySqlDbType = MySqlDbType.VarChar;
                pTrabajo.Size = 60;
                pTrabajo.Value = Trabajo.Trabajo;
                comando.Parameters.Add(pTrabajo);

                // Console.WriteLine("pNombre es : " + pNombre.Value);

                MySqlParameter pPrecioUnitario = new MySqlParameter();
                pPrecioUnitario.ParameterName = "@pPrecioUnitario";
                pPrecioUnitario.MySqlDbType = MySqlDbType.VarChar;
                pPrecioUnitario.Size = 60;
                pPrecioUnitario.Value = Trabajo.PrecioUnitario;
                comando.Parameters.Add(pPrecioUnitario);

                rpta = (string)comando.ExecuteScalar();

                Console.WriteLine("rta es : ..... **** " + rpta);

                if (rpta == "El Trabajo es obligatorio.")
                {
                    rpta = "El Trabajo es obligatorio.";
                    return rpta;
                }
                if (rpta == "El trabajo ya existe")
                {
                    rpta = "El trabajo ya existe";
                    return rpta;
                }
                rpta = "OK";
                comando.Parameters.Clear();
                return rpta;
                // rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el trabajo";


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
        public string Eliminar(CD_Trabajos Trabajo)
        {
            string rpta = "";
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_eliminar_trabajo";

                MySqlParameter pIdTrabajo = new MySqlParameter();
                pIdTrabajo.ParameterName = "@pIdTrabajo";
                pIdTrabajo.MySqlDbType = MySqlDbType.Int32;
                // pIdEmpleado.Size = 60;
                pIdTrabajo.Value = Trabajo.IdTrabajo;
                comando.Parameters.Add(pIdTrabajo);

                //Ejecutamos nuestro comando

                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Trabajo";

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
            return rpta;
        }

        public DataTable MostrarTrabajo(int IdTrabajo)
        {
            Console.WriteLine("IdProducto en capa datos es : " + IdTrabajo);
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_dame_trabajo";

            MySqlParameter pIdTrabajo = new MySqlParameter();
            pIdTrabajo.ParameterName = "@pIdTrabajo";
            pIdTrabajo.MySqlDbType = MySqlDbType.Int32;
            // pIdProducto.Size = 60;
            pIdTrabajo.Value = IdTrabajo;
            comando.Parameters.Add(pIdTrabajo);


            leer = comando.ExecuteReader();
            tabla.Load(leer);
            // Console.WriteLine("tabla en capa datos es : " + tabla);
            // Console.WriteLine("leer en capa datos es : " + leer.ToString());
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return tabla;

        }

        public string Editar(CD_Trabajos Trabajo)
        {
            string rpta = "";
            comando.Parameters.Clear();// si no ponerlo al comienzo de esta funcion
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_editar_trabajo";

                MySqlParameter pIdTrabajo = new MySqlParameter();
                pIdTrabajo.ParameterName = "@pIdTrabajo";
                pIdTrabajo.MySqlDbType = MySqlDbType.Int32;
                // pIdEmpleado.Size = 60;
                pIdTrabajo.Value = Trabajo.IdTrabajo;
                comando.Parameters.Add(pIdTrabajo);

                MySqlParameter pTrabajo = new MySqlParameter();
                pTrabajo.ParameterName = "@pTrabajo";
                pTrabajo.MySqlDbType = MySqlDbType.VarChar;
                pTrabajo.Size = 60;
                pTrabajo.Value = Trabajo.Trabajo;
                comando.Parameters.Add(pTrabajo);

                MySqlParameter pPrecioUnitario = new MySqlParameter();
                pPrecioUnitario.ParameterName = "@pPrecioUnitario";
                pPrecioUnitario.MySqlDbType = MySqlDbType.Decimal;
                // pPrecioUnitario.Size = 30;
                pPrecioUnitario.Value = Trabajo.PrecioUnitario;
                comando.Parameters.Add(pPrecioUnitario);

                rpta = (string)comando.ExecuteScalar();


                if (rpta == "El trabajo esta dado de baja")
                {
                    rpta = "El trabajo esta dado de baja";
                    return rpta;
                }
                rpta = "OK";
                return rpta;


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

        public DataTable BuscarTrabajo(CD_Trabajos Trabajo)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_buscar_trabajo";

                MySqlParameter pTextoBuscar = new MySqlParameter();
                pTextoBuscar.ParameterName = "@pTextoBuscar";
                pTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                pTextoBuscar.Size = 30;
                pTextoBuscar.Value = Trabajo.TextoBuscar;
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
