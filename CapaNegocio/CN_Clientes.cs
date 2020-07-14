using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class CN_Clientes
    {
        private CD_Clientes objetoCD = new CD_Clientes();

        //Método Insertar que llama al método Insertar de la clase DArticulo
        //de la CapaDatos
        public static string Insertar(string Titular, string Transporte, string Telefono)
        {
            // Console.WriteLine("En insertar , nombre es " + nombre);

            CD_Clientes Obj = new CD_Clientes();
            Obj.Titular = Titular;
            Obj.Transporte = Transporte;
            Obj.Telefono = Telefono;

            return Obj.Insertar(Obj);
        }

        public DataTable MostrarClientes()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public static string Eliminar(int IdCliente)
        {
            CD_Clientes Obj = new CD_Clientes();
            Obj.IdCliente = IdCliente;
            return Obj.Eliminar(Obj);
        }

        // Devuelve solo un Cliente
        public DataTable MostrarCliente(int IdCliente)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCliente(IdCliente);
            // Console.WriteLine("tabla TableName en capa negocio es : " + tabla.TableName);
            // Console.WriteLine("tabla Rows en capa negocio es : " + tabla.Rows);
            return tabla;
        }

        public static string Editar(int IdCliente, string Transporte, string Titular, string Telefono)
        {
            
            CD_Clientes Obj = new CD_Clientes();
            Obj.IdCliente = IdCliente;

            Obj.Transporte = Transporte;
            Obj.Titular = Titular;
            Obj.Telefono = Telefono;

            return Obj.Editar(Obj);
        }

        public DataTable BuscarCliente(string textobuscar)
        {
            // Console.WriteLine("textobuscar en capa negocio es : " + textobuscar);
            CD_Clientes Obj = new CD_Clientes();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCliente(Obj);
        }
    }
}
