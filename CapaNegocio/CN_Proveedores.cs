using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class CN_Proveedores
    {
        private CD_Proveedores objetoCD = new CD_Proveedores();

        public static string Insertar(string Proveedor, string CUIL, string Direccion, string Telefono)
        {
            // Console.WriteLine("En insertar , nombre es " + nombre);

            CD_Proveedores Obj = new CD_Proveedores();
            Obj.Proveedor = Proveedor;
            Obj.CUIL = CUIL;
            Obj.Direccion = Direccion;
            Obj.Telefono = Telefono;

            return Obj.Insertar(Obj);
        }

        // Muestra todos los proveedores dados de alta en la BD
        public DataTable MostrarProveedores()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        // Devuelve solo un producto
        public DataTable MostrarProveedor(int IdProveedor)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarProveedor(IdProveedor);
            Console.WriteLine("tabla TableName en capa negocio es : " + tabla.TableName);
            Console.WriteLine("tabla Rows en capa negocio es : " + tabla.Rows);
            return tabla;
        }
        public static string Eliminar(int IdProveedor)
        {
            CD_Proveedores Obj = new CD_Proveedores();
            Obj.IdProveedor = IdProveedor;
            return Obj.Eliminar(Obj);
        }


        public static string Editar(int IdProveedor, string Proveedor, string CUIL, string Direccion, string Telefono)
        {
            // Console.WriteLine("Produco.IdProducto es 2 : " + IdProducto);
            CD_Proveedores Obj = new CD_Proveedores();
            Obj.IdProveedor = IdProveedor;

            Obj.Proveedor = Proveedor;
            Obj.CUIL = CUIL;
            Obj.Direccion = Direccion;
            Obj.Telefono = Telefono;

            return Obj.Editar(Obj);
        }

        public DataTable BuscarProveedor(string textobuscar)
        {
            Console.WriteLine("textobuscar en capa negocio es : " + textobuscar);
            CD_Proveedores Obj = new CD_Proveedores();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarProveedor(Obj);
        }
    }
}
