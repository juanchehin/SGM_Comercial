using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_TrabajosEmpleado
    {
        private string _Trabajo;
        private int _IdEmpleado;
        private string _Fecha;
        private string _Cantidad;

        private string _FechaInicio;
        private string _FechaFin;

        private string _TextoBuscar;

        public int IdEmpleado { get => _IdEmpleado; set => _IdEmpleado = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public string Trabajo { get => _Trabajo; set => _Trabajo = value; }
        public string FechaInicio { get => _FechaInicio; set => _FechaInicio = value; }
        public string FechaFin { get => _FechaFin; set => _FechaFin = value; }

        //Constructores
        public CD_TrabajosEmpleado()
        {

        }

        public CD_TrabajosEmpleado(string Trabajo, int IdEmpleado, string Fecha,string Cantidad)
        {
            this.Trabajo = Trabajo;
            this.IdEmpleado = IdEmpleado;
            this.Fecha = Fecha;
            this.Cantidad = Cantidad;
        }

        // ==================================================
        //  Permite devolver todos los trabajos de un empleado de la BD
        // ==================================================
        private CD_Conexion conexion = new CD_Conexion();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();



        public DataTable Mostrar(int IdEmpleado, string FechaInicio, string FechaFin)
        {
            string rpta = "";

            Console.WriteLine(" rpta es llego!!! IdEmpleado" + IdEmpleado);
            Console.WriteLine(" rpta es llego!!! FechaInicio" + FechaInicio);
            Console.WriteLine(" rpta es llego!!! FechaFin" + FechaFin);

            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_dame_trabajos_empleado";

            MySqlParameter pIdEmpleado = new MySqlParameter();
            pIdEmpleado.ParameterName = "@pIdEmpleado";
            pIdEmpleado.MySqlDbType = MySqlDbType.Int32;
            // pIdTrabajo.Size = 60;
            pIdEmpleado.Value = IdEmpleado;
            comando.Parameters.Add(pIdEmpleado);

            MySqlParameter pFechaInicio = new MySqlParameter();
            pFechaInicio.ParameterName = "@pFechaInicio";
            pFechaInicio.MySqlDbType = MySqlDbType.VarChar;
            pFechaInicio.Size = 60;
            pFechaInicio.Value = FechaInicio;
            comando.Parameters.Add(pFechaInicio);

            MySqlParameter pFechaFin = new MySqlParameter();
            pFechaFin.ParameterName = "@pFechaFin";
            pFechaFin.MySqlDbType = MySqlDbType.VarChar;
            pFechaFin.Size = 60;
            pFechaFin.Value = FechaFin;
            comando.Parameters.Add(pFechaFin);

            rpta = (string)comando.ExecuteScalar();


            if (rpta == "El empleado no posee trabajos")
            {
                conexion.CerrarConexion();
                return null;
            }

            tabla.Clear();
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //Métodos
        //Insertar
        public string Insertar(CD_TrabajosEmpleado TrabajosEmpleado)
        {
            Console.WriteLine("Ingreso en insertar");
            string rpta = "";
            try
            {
                Console.WriteLine("Ingreso en insertar 2");
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_alta_trabajo_empleado";

                MySqlParameter pTrabajo = new MySqlParameter();
                pTrabajo.ParameterName = "@pTrabajo";
                pTrabajo.MySqlDbType = MySqlDbType.VarChar;
                pTrabajo.Size = 60;
                pTrabajo.Value = TrabajosEmpleado.Trabajo;
                comando.Parameters.Add(pTrabajo);

                // Console.WriteLine("pNombre es : " + pNombre.Value);

                MySqlParameter pIdEmpleado = new MySqlParameter();
                pIdEmpleado.ParameterName = "@pIdEmpleado";
                pIdEmpleado.MySqlDbType = MySqlDbType.Int32;
                // pIdTrabajo.Size = 60;
                pIdEmpleado.Value = TrabajosEmpleado.IdEmpleado;
                comando.Parameters.Add(pIdEmpleado);


                MySqlParameter pCantidad = new MySqlParameter();
                pCantidad.ParameterName = "@pCantidad";
                pCantidad.MySqlDbType = MySqlDbType.Int32;
                // pIdTrabajo.Size = 60;
                pCantidad.Value = TrabajosEmpleado.Cantidad;
                comando.Parameters.Add(pCantidad);

                MySqlParameter pFecha = new MySqlParameter();
                pFecha.ParameterName = "@pFecha";
                pFecha.MySqlDbType = MySqlDbType.String;
                // pIdTrabajo.Size = 60;
                pFecha.Value = TrabajosEmpleado.Fecha;
                comando.Parameters.Add(pFecha);

                rpta = (string)comando.ExecuteScalar();//  == 1 ? "OK" : "NO se Ingreso el trabajo del empleado";

                Console.WriteLine("rptar en trabajos empleado es : " + rpta);


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
        // Metodo ELIMINAR un trabajo de un Empleado (da de baja)
        public string Eliminar(CD_TrabajosEmpleado TrabajosEmpleado)
        {
            string rpta = "";
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_eliminar_trabajo_empleado";

                MySqlParameter pIdTrabajo = new MySqlParameter();
                pIdTrabajo.ParameterName = "@pIdTrabajo";
                pIdTrabajo.MySqlDbType = MySqlDbType.Int32;
                // pIdEmpleado.Size = 60;
                pIdTrabajo.Value = TrabajosEmpleado.Trabajo;
                comando.Parameters.Add(pIdTrabajo);

                MySqlParameter pIdEmpleado = new MySqlParameter();
                pIdEmpleado.ParameterName = "@pIdEmpleado";
                pIdEmpleado.MySqlDbType = MySqlDbType.Int32;
                // pIdEmpleado.Size = 60;
                pIdEmpleado.Value = TrabajosEmpleado.IdEmpleado;
                comando.Parameters.Add(pIdEmpleado);

                //Ejecutamos nuestro comando

                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Trabajo del empleado";

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
        public string Editar(CD_TrabajosEmpleado TrabajosEmpleado)
        {
            string rpta = "";
            comando.Parameters.Clear();// si no ponerlo al comienzo de esta funcion
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_editar_trabajo_empleado";

                MySqlParameter pTrabajo = new MySqlParameter();
                pTrabajo.ParameterName = "pTrabajo";
                pTrabajo.MySqlDbType = MySqlDbType.VarChar;
                pTrabajo.Size = 60;
                pTrabajo.Value = TrabajosEmpleado.Trabajo;
                comando.Parameters.Add(pTrabajo);

                MySqlParameter pIdEmpleado = new MySqlParameter();
                pIdEmpleado.ParameterName = "@pIdEmpleado";
                pIdEmpleado.MySqlDbType = MySqlDbType.Int32;
                // pTrabajo.Size = 60;
                pIdEmpleado.Value = TrabajosEmpleado.IdEmpleado;
                comando.Parameters.Add(pIdEmpleado);

                MySqlParameter pCantidad = new MySqlParameter();
                pCantidad.ParameterName = "@pCantidad";
                pCantidad.MySqlDbType = MySqlDbType.VarChar;
                pCantidad.Size = 30;
                pCantidad.Value = TrabajosEmpleado.Cantidad;
                comando.Parameters.Add(pCantidad);

                MySqlParameter pFecha = new MySqlParameter();
                pFecha.ParameterName = "@pFecha";
                pFecha.MySqlDbType = MySqlDbType.VarChar;
                pFecha.Size = 30;
                pFecha.Value = TrabajosEmpleado.Fecha;
                comando.Parameters.Add(pFecha);

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
    }
    
}
