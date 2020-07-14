using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregados
using CapaDatos;

namespace CapaNegocio
{
    // private CD_Usuarios objetoCD = new CD_Usuarios();
    public class CN_Usuarios
    {
        public static string Login(string usuario, string password)
        {
            CD_Usuarios Obj = new CD_Usuarios();
            Obj.Usuario = usuario;
            Obj.Password = password;
            return Obj.Login(Obj);
        }
    }
    
}
