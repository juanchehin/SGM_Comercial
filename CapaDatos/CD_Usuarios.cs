using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregados

namespace CapaDatos
{
    public class CD_Usuarios
    {
        private int _IdUsuario;
        private string _Usuario;
        private string _Password;
        private string _Estado;

        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string Estado { get => _Estado; set => _Estado = value; }

        //Constructores
        public CD_Usuarios()
        {

        }

        public CD_Usuarios(int IdUsuario, string Usuario, string Password, string Estado)
        {
            this.IdUsuario = IdUsuario;
            this.Usuario = Usuario;
            this.Password = Password;
            this.Estado = Estado;

        }
        private CD_Conexion conexion = new CD_Conexion();


        MySqlCommand comando = new MySqlCommand(); 

        public string Login(CD_Usuarios Usuario)
        {

            string rpta = "";
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "bsp_login";

                MySqlParameter pUsuario = new MySqlParameter();
                pUsuario.ParameterName = "@pUsuario";
                pUsuario.MySqlDbType = MySqlDbType.VarChar;
                pUsuario.Size = 30;
                pUsuario.Value = Usuario.Usuario;
                comando.Parameters.Add(pUsuario);

                MySqlParameter pPassword = new MySqlParameter();
                pPassword.ParameterName = "@pPassword";
                pPassword.MySqlDbType = MySqlDbType.VarChar;
                pPassword.Size = 30;
                pPassword.Value = Usuario.Password;
                comando.Parameters.Add(pPassword);

                rpta = comando.ExecuteScalar().ToString() == "Ok" ? "Ok" : "Error de login";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;

        }


    }
}
