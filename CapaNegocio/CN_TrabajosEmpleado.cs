using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class CN_TrabajosEmpleado
    {
        private CD_TrabajosEmpleado objetoCD = new CD_TrabajosEmpleado();

        //Método Insertar que llama al método Insertar de la clase
        //de la CapaDatos
        public static string Insertar(string Trabajo, int IdEmpleado,string Cantidad,string Fecha)
        {
            Console.WriteLine("En insertar TE , Trabajo es " + Trabajo);

            CD_TrabajosEmpleado Obj = new CD_TrabajosEmpleado();
            Obj.Trabajo = Trabajo;
            Obj.IdEmpleado = IdEmpleado;
            Obj.Fecha = Fecha;
            Obj.Cantidad = Cantidad;

            return Obj.Insertar(Obj);
        }

        public DataTable MostrarTrabajosEmpleado(int IdEmpleado, string FechaInicio, string FechaFin)
        {
            DataTable tabla = objetoCD.Mostrar(IdEmpleado, FechaInicio, FechaFin);
            return tabla;
        }
        public static string Eliminar(string Trabajo,int IdEmpleado)
        {
            CD_TrabajosEmpleado Obj = new CD_TrabajosEmpleado();
            Obj.Trabajo = Trabajo;
            Obj.IdEmpleado = IdEmpleado;
            return Obj.Eliminar(Obj);
        }

        public static string Editar(string Trabajo, int IdEmpleado, string Cantidad,string Fecha)
        {
            // Console.WriteLine("Produco.IdProducto es 2 : " + IdProducto);
            CD_TrabajosEmpleado Obj = new CD_TrabajosEmpleado();
            Obj.Trabajo = Trabajo;
            Obj.IdEmpleado = IdEmpleado;
            Obj.Cantidad = Cantidad;
            Obj.Fecha = Fecha;

            return Obj.Editar(Obj);
        }
    }
}
