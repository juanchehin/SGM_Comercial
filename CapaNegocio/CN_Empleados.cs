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
    public class CN_Empleados
    {
        private CD_Empleados objetoCD = new CD_Empleados();

        //Método Insertar que llama al método Insertar de la clase DArticulo
        //de la CapaDatos
        public static string Insertar(string Nombre, string Apellidos, string DNI,string Direccion,string Telefono,string FechaNac)
        {
            // Console.WriteLine("En insertar , nombre es " + nombre);

            CD_Empleados Obj = new CD_Empleados();
            Obj.Nombre = Nombre;
            Obj.Apellidos = Apellidos;
            Obj.DNI = DNI;
            Obj.Direccion = Direccion;
            Obj.Telefono = Telefono;
            Obj.FechaNac = FechaNac;

            return Obj.Insertar(Obj);
        }

        public DataTable MostrarEmp()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public static string Eliminar(int IdEmpleado)
        {
            CD_Empleados Obj = new CD_Empleados();
            Obj.IdEmpleado = IdEmpleado;
            return Obj.Eliminar(Obj);
        }

        public DataTable MostrarEmpleado(int IdEmpleado)
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarEmpleado(IdEmpleado);
            Console.WriteLine("tabla TableName en capa negocio es : " + tabla.TableName);
            Console.WriteLine("tabla Rows en capa negocio es : " + tabla.Rows);
            return tabla;
        }

        public static string Editar(int IdEmpleado, string Nombre, string Apellidos, string DNI, string Direccion, string Telefono,string FechaNac)
        {
            // Console.WriteLine("Produco.IdProducto es 2 : " + IdProducto);
            CD_Empleados Obj = new CD_Empleados();
            Obj.IdEmpleado = IdEmpleado;

            Obj.Nombre = Nombre;
            Obj.Apellidos = Apellidos;
            Obj.DNI = DNI;
            Obj.Direccion = Direccion;
            Obj.Telefono = Telefono;
            Obj.FechaNac = FechaNac;

            // Console.WriteLine("Produco.IdProducto es 3 : " + IdProducto);

            return Obj.Editar(Obj);
        }

        public DataTable BuscarEmpleado(string textobuscar)
        {
            Console.WriteLine("textobuscar en capa negocio es : " + textobuscar);
            CD_Empleados Obj = new CD_Empleados();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarEmpleado(Obj);
        }


    }
}
