using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class formAgregarTrabajoEmpleado : Form
    {
        CN_Empleados objetoCN = new CN_Empleados();
        CN_Trabajos objetoCN_trabajos = new CN_Trabajos();

        private int IdEmpleado;
        // bool IsNuevo = false;

        private DataTable respuesta;
        private DataTable respuesta_trabajos;


        private string Nombre;
        private string Apellidos;
        private DateTime Fecha;

        private string TrabajoActual;


        public formAgregarTrabajoEmpleado(int parametro)
        {
            Console.WriteLine("EL parametro recibido en agregar trabajo es : " + parametro);
            this.IdEmpleado = parametro;
            InitializeComponent();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formAgregarTrabajoEmpleado_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cbTrabajos;
            this.MostrarEmpleado(this.IdEmpleado);
            this.CargarTrabajos();
        }

        // Cargo los trabajos en el comboBox
        private void CargarTrabajos()
        {
            respuesta_trabajos = objetoCN_trabajos.MostrarTrabajos();

            cbTrabajos.DataSource = respuesta_trabajos;

            cbTrabajos.DisplayMember = "Trabajo";
            cbTrabajos.ValueMember = "IdTrabajo";
        }

        private void MostrarEmpleado(int IdEmpleado)
        {
            Console.WriteLine("EL IdEmpleado recibido en agregar trabajo mostrar emp es : " + IdEmpleado);
            respuesta = objetoCN.MostrarEmpleado(IdEmpleado);

            Console.WriteLine("Respuesta es ; " + respuesta.Rows.Count);
            foreach (DataRow row in respuesta.Rows)
            {

                Nombre = Convert.ToString(row["Nombre"]);
                Apellidos = Convert.ToString(row["Apellidos"]);
                

                lblNombreEmpleado.Text = Nombre + "  " + Apellidos;


            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("En insertar TE btnGuardar_Click ");

            this.TrabajoActual = cbTrabajos.Text;
            try
            {
                string rpta = "";
                if (this.cbTrabajos.Text == string.Empty || this.txtCantidad.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    Console.WriteLine("En insertar TE btnGuardar_Click 2");
                    var año = this.dtFecha.Value.Year;
                    var mes = this.dtFecha.Value.Month;
                    var dia = this.dtFecha.Value.Day;
                    var fecha = año + "-" + mes + "-" + dia;
                    // if (this.IsNuevo)
                    // {   int IdTrabajo, int IdEmpleado,string Fecha,string Cantidad

                        Console.WriteLine("En insertar TE btnGuardar_Click fecha " + fecha);

                        rpta = CN_TrabajosEmpleado.Insertar(this.TrabajoActual,this.IdEmpleado,this.txtCantidad.Text, fecha);
                    
                    /*else
                    {
                        rpta = CN_TrabajosEmpleado.Editar(this.TrabajoActual, this.IdEmpleado,this.txtCantidad.Text, fecha);
                    }*/

                    if (rpta.Equals("Ok"))
                    {
                     this.MensajeOk("Se Insertó de forma correcta el registro");
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SGM", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SGM", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
