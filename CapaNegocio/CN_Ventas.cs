using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class CN_Ventas
    {
        private CD_Ventas objetoCD = new CD_Ventas();

        //Método Insertar que llama al método Insertar de la clase
        //de la CapaDatos
        public static string Insertar(string Producto, string Titular, int IdEmpleado, string cantidad)
        {
            // No olvidar sumar al stock de un producto si ya existe
            // Console.WriteLine("En insertar , nombre es " + nombre);

            CD_Ventas Obj = new CD_Ventas();
            Obj.Producto = Producto;
            Obj.Titular = Titular;
            Obj.IdEmpleado = IdEmpleado;
            Obj.Cantidad = cantidad;

            return Obj.Insertar(Obj);
        }

        // Devuelve todas las compras habidas y por haber
        public DataTable MostrarVentas()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarVentas();
            return tabla;
        }
        // Devuelve una compra (unica) dado un Id
        public DataTable MostrarVenta(int IdVenta)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarVenta(IdVenta);
            return tabla;
        }
        public static string Eliminar(int IdVenta)
        {
            CD_Ventas Obj = new CD_Ventas();
            Obj.IdVenta = IdVenta;
            return Obj.Eliminar(Obj);
        }


        public static string Editar(int IdVenta, string Producto, string Titular, int IdEmpleado, string cantidad)
        {
            Console.WriteLine("IdVenta.IdVenta es 2 : " + IdVenta);
            CD_Ventas Obj = new CD_Ventas();
            Obj.IdVenta = IdVenta;

            Obj.Producto = Producto;
            Obj.Titular = Titular;
            Obj.IdEmpleado = IdEmpleado;
            Obj.Cantidad = cantidad;

            // Console.WriteLine("Produco.IdProducto es 3 : " + IdProducto);

            return Obj.Editar(Obj);
        }
    }
}
