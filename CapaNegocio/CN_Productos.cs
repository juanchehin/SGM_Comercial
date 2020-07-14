using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregados
using CapaDatos;
using System.Data;
using MySql.Data.MySqlClient;


namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        //Método Insertar que llama al método Insertar de la clase DArticulo
        //de la CapaDatos
        public static string Insertar(string nombre, string Codigo, string PrecioCompra, string PrecioVenta, string Descripcion, string Stock)
        {
            // Console.WriteLine("En insertar , nombre es " + nombre);

            CD_Productos Obj = new CD_Productos();
            Obj.Producto = nombre;
            Obj.Descripcion = Descripcion;
            Obj.Codigo = Codigo;
            Obj.PrecioCompra = PrecioCompra;
            Obj.PrecioVenta = PrecioVenta;
            Obj.Stock = Stock;

            return Obj.Insertar(Obj);
        }

        public DataTable MostrarProd()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        // Devuelve solo un producto
        public DataTable MostrarProducto(int IdProducto)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarProducto(IdProducto);
            Console.WriteLine("tabla TableName en capa negocio es : " + tabla.TableName);
            Console.WriteLine("tabla Rows en capa negocio es : " + tabla.Rows);
            return tabla;
        }
        public static string Eliminar(int IdProducto)
        {
            CD_Productos Obj = new CD_Productos();
            Obj.IdProducto = IdProducto;
            return Obj.Eliminar(Obj);
        }


        public static string Editar(int IdProducto, string Producto, string Codigo, string PrecioCompra, string PrecioVenta, string Descripcion, string Stock)
        {
            // Console.WriteLine("Produco.IdProducto es 2 : " + IdProducto);
            CD_Productos Obj = new CD_Productos();
            Obj.IdProducto = IdProducto;

            Obj.Producto = Producto;
            Obj.Codigo = Codigo;
            Obj.PrecioCompra = PrecioCompra;
            Obj.PrecioVenta = PrecioVenta;
            Obj.Descripcion = Descripcion;
            Obj.Stock = Stock;

            // Console.WriteLine("Produco.IdProducto es 3 : " + IdProducto);

            return Obj.Editar(Obj);
        }

        public DataTable BuscarProducto(string textobuscar)
        {
            Console.WriteLine("textobuscar en capa negocio es : " + textobuscar);
            CD_Productos Obj = new CD_Productos();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarProducto(Obj);
        }

    }
}
