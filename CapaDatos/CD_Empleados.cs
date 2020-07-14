using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Empleados
    {
        private int _IdEmpleado;
        private string _Nombre;
        private string _Apellidos;
        private string _DNI;
        private string _EstadoEmp;
        private string _Direccion;
        private string _Telefono;
        private string _FechaNac;

        private string _TextoBuscar;



        public int IdEmpleado { get => _IdEmpleado; set => _IdEmpleado = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string DNI { get => _DNI; set => _DNI = value; }
        public string EstadoEmp { get => _EstadoEmp; set => _EstadoEmp = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }
        public string FechaNac { get => _FechaNac; set => _FechaNac = value; }

        //Constructores
        public CD_Empleados()
        {

        }

        public CD_Empleados(int IdEmpleado, string Nombre, string Apellidos, string DNI, string EstadoEmp, string Direccion,string Telefono, string FechaNac)
        {
            this.IdEmpleado = IdEmpleado;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Apellidos = Apellidos;
            this.DNI = DNI;
            this.EstadoEmp = EstadoEmp;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.FechaNac = FechaNac;

        }

        // ==================================================
        //  Permite devolver todos los empleados activos de la BD
        // ==================================================
        private CD_Conexion conexion = new CD_Conexion();

        MySqlDataReader leer;
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();


        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_dame_empleados";

            tabla.Clear();
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();// si no ponerlo al comienzo de esta funcion

            conexion.CerrarConexion();
            return tabla;

        }

        //Métodos
        //Insertar
        public string Insertar(CD_Empleados Empleado)
        {
            string rpta = "";
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_alta_empleado";

                MySqlParameter pNombre = new MySqlParameter();
                pNombre.ParameterName = "@pNombre";
                pNombre.MySqlDbType = MySqlDbType.VarChar;
                pNombre.Size = 60;
                pNombre.Value = Empleado.Nombre;
                comando.Parameters.Add(pNombre);

                // Console.WriteLine("pNombre es : " + pNombre.Value);

                MySqlParameter pApellidos = new MySqlParameter();
                pApellidos.ParameterName = "@pApellidos";
                pApellidos.MySqlDbType = MySqlDbType.VarChar;
                pApellidos.Size = 60;
                pApellidos.Value = Empleado.Apellidos;
                comando.Parameters.Add(pApellidos);

                MySqlParameter pDNI = new MySqlParameter();
                pDNI.ParameterName = "@pDNI";
                pDNI.MySqlDbType = MySqlDbType.VarChar;
                pDNI.Size = 45;
                pDNI.Value = Empleado.DNI;
                comando.Parameters.Add(pDNI);

                MySqlParameter pDireccion = new MySqlParameter();
                pDireccion.ParameterName = "@pDireccion";
                pDireccion.MySqlDbType = MySqlDbType.VarChar;
                pDireccion.Size = 40;
                pDireccion.Value = Empleado.Direccion;
                comando.Parameters.Add(pDireccion);

                MySqlParameter pTelefono = new MySqlParameter();
                pTelefono.ParameterName = "@pTelefono";
                pTelefono.MySqlDbType = MySqlDbType.VarChar;
                pTelefono.Size = 15;
                pTelefono.Value = Empleado.Telefono;
                comando.Parameters.Add(pTelefono);

                MySqlParameter pFechaNac = new MySqlParameter();
                pFechaNac.ParameterName = "@pFechaNac";
                pFechaNac.MySqlDbType = MySqlDbType.VarChar;
                pFechaNac.Size = 40;
                pFechaNac.Value = Empleado.FechaNac;
                comando.Parameters.Add(pFechaNac);


                // Console.WriteLine("el comando es : " + comando.CommandText[0]);
                //Ejecutamos nuestro comando

                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


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
        public string Eliminar(CD_Empleados Empleado)
        {
            string rpta = "";
            try
            {


                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_eliminar_empleado";

                MySqlParameter pIdEmpleado = new MySqlParameter();
                pIdEmpleado.ParameterName = "@pIdEmpleado";
                pIdEmpleado.MySqlDbType = MySqlDbType.Int32;
                // pIdEmpleado.Size = 60;
                pIdEmpleado.Value = Empleado.IdEmpleado;
                comando.Parameters.Add(pIdEmpleado);

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
            return rpta;
        }

        public string Editar(CD_Empleados Empleado)
        {
            Console.WriteLine("Produco.IdProducto es 1 : " + Empleado.IdEmpleado);
            string rpta = "";
            comando.Parameters.Clear();// si no ponerlo al comienzo de esta funcion
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_editar_empleado";

                MySqlParameter pIdEmpleado = new MySqlParameter();
                pIdEmpleado.ParameterName = "@pIdEmpleado";
                pIdEmpleado.MySqlDbType = MySqlDbType.Int32;
                // pIdEmpleado.Size = 60;
                pIdEmpleado.Value = Empleado.IdEmpleado;
                comando.Parameters.Add(pIdEmpleado);

                MySqlParameter pNombre = new MySqlParameter();
                pNombre.ParameterName = "@pNombre";
                pNombre.MySqlDbType = MySqlDbType.VarChar;
                pNombre.Size = 60;
                pNombre.Value = Empleado.Nombre;
                comando.Parameters.Add(pNombre);

                MySqlParameter pApellidos = new MySqlParameter();
                pApellidos.ParameterName = "@pApellidos";
                pApellidos.MySqlDbType = MySqlDbType.VarChar;
                pApellidos.Size = 60;
                pApellidos.Value = Empleado.Apellidos;
                comando.Parameters.Add(pApellidos);

                MySqlParameter pDNI = new MySqlParameter();
                pDNI.ParameterName = "@pDNI";
                pDNI.MySqlDbType = MySqlDbType.VarChar;
                pDNI.Size = 45;
                pDNI.Value = Empleado.DNI;
                comando.Parameters.Add(pDNI);

                MySqlParameter pDireccion = new MySqlParameter();
                pDireccion.ParameterName = "@pDireccion";
                pDireccion.MySqlDbType = MySqlDbType.VarChar;
                pDireccion.Size = 60;
                pDireccion.Value = Empleado.Direccion;
                comando.Parameters.Add(pDireccion);

                MySqlParameter pTelefono = new MySqlParameter();
                pTelefono.ParameterName = "@pTelefono";
                pTelefono.MySqlDbType = MySqlDbType.VarChar;
                pTelefono.Size = 15;
                pTelefono.Value = Empleado.Telefono;
                comando.Parameters.Add(pTelefono);

                MySqlParameter pFechaNac = new MySqlParameter();
                pFechaNac.ParameterName = "@pFechaNac";
                pFechaNac.MySqlDbType = MySqlDbType.VarChar;
                pFechaNac.Size = 60;
                pFechaNac.Value = Empleado.FechaNac;
                comando.Parameters.Add(pFechaNac);



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

        public DataTable BuscarEmpleado(CD_Empleados Empleado)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_buscar_empleado";

                MySqlParameter pTextoBuscar = new MySqlParameter();
                pTextoBuscar.ParameterName = "@pTextoBuscar";
                pTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                pTextoBuscar.Size = 30;
                pTextoBuscar.Value = Empleado.TextoBuscar;
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

        // Devuelve un solo producto dado un ID
        public DataTable MostrarEmpleado(int IdEmpleado)
        {
            Console.WriteLine("IdEmpleado en capa datos es : " + IdEmpleado);
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "bsp_dame_empleado";

            MySqlParameter pIdEmpleado = new MySqlParameter();
            pIdEmpleado.ParameterName = "@pIdEmpleado";
            pIdEmpleado.MySqlDbType = MySqlDbType.Int32;
            // pIdProducto.Size = 60;
            pIdEmpleado.Value = IdEmpleado;
            comando.Parameters.Add(pIdEmpleado);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Console.WriteLine("tabla en capa datos es : " + tabla);
            Console.WriteLine("leer en capa datos es : " + leer.ToString());
            comando.Parameters.Clear();
            conexion.CerrarConexion();

            return tabla;

        }


    }
}
