using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class CN_Compras
    {
        private CD_Compras objetoCD = new CD_Compras();

        //Método Insertar que llama al método Insertar de la clase
        //de la CapaDatos
        public static string Insertar(string Producto, string Proveedor,string Cantidad)
        {
            // No olvidar sumar al stock de un producto si ya existe
            // Console.WriteLine("En insertar , nombre es " + nombre);

            CD_Compras Obj = new CD_Compras();
            Obj.Producto = Producto;
            Obj.Proveedor = Proveedor;
            Obj.Cantidad = Cantidad;

            return Obj.Insertar(Obj);
        }

        // Devuelve todas las compras habidas y por haber
        public DataTable MostrarCompras()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCompras();
            return tabla;
        }
        // Devuelve una compra (unica) dado un Id
        public DataTable MostrarCompra(int IdCompra)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCompra(IdCompra);
            return tabla;
        }
        public static string Eliminar(int IdCompra)
        {
            CD_Compras Obj = new CD_Compras();
            Obj.IdCompra = IdCompra;
            return Obj.Eliminar(Obj);
        }


        public static string Editar(int IdCompra, string Producto, string Proveedor, string Cantidad)
        {
            Console.WriteLine("Compra.IdCompra es 2 : " + IdCompra);
            CD_Compras Obj = new CD_Compras();
            Obj.IdCompra = IdCompra;

            Obj.Producto = Producto;
            Obj.Proveedor = Proveedor;
            Obj.Cantidad = Cantidad;

            // Console.WriteLine("Produco.IdProducto es 3 : " + IdProducto);

            return Obj.Editar(Obj);
        }
        // HACER LA BUSQUEDA QUE SEA ENTRE FECHAS
        /*
        public DataTable BuscarCompra(string textobuscar)
        {
            Console.WriteLine("textobuscar en capa negocio es : " + textobuscar);
            CD_Productos Obj = new CD_Productos();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarProducto(Obj);
        }*/
    }
}
