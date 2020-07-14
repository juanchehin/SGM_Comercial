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
    public partial class formNuevoEditarClientes : Form
    {
        CN_Clientes objetoCN = new CN_Clientes();
        DataTable respuesta;
        // int parametroActual;
        bool bandera;
        bool IsNuevo = false;
        bool IsEditar = false;

        private int IdCliente;
        private string Transporte;
        private string Titular;
        private string Telefono;

        public formNuevoEditarClientes(int parametro, bool IsNuevoEditar)
        {
            InitializeComponent();
            this.IdCliente = parametro;
            this.bandera = IsNuevoEditar;
        }

        private void formNuevoEditarClientes_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtTransporte;
            if (this.bandera)
            {
                lblEditarNuevo.Text = "Nuevo";
                // this.MostrarProducto(this.IdProducto);
                this.IsNuevo = true;
                this.IsEditar = false;
            }
            else
            {
                lblEditarNuevo.Text = "Editar";
                this.IsNuevo = false;
                this.IsEditar = true;
                this.MostrarCliente(this.IdCliente);
            }
        }

        // Carga los valores en los campos de texto del formulario para que se modifiquen los que se desean
        private void MostrarCliente(int IdCliente)
        {
            respuesta = objetoCN.MostrarCliente(IdCliente);

            // Console.WriteLine("Respuesta es ; " + respuesta.Rows.Count);
            foreach (DataRow row in respuesta.Rows)
            {
                Console.WriteLine("row es :" + row["Transporte"]);

                IdCliente = Convert.ToInt32(row["IdCliente"]);
                Transporte = Convert.ToString(row["Transporte"]);
                Titular = Convert.ToString(row["Titular"]);
                Telefono = Convert.ToString(row["Telefono"]);



                txtTransporte.Text = Transporte;
                txtTitular.Text = Titular;
                txtTelefono.Text = Telefono;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtTransporte.Text == string.Empty || this.txtTitular.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = CN_Clientes.Insertar(this.txtTitular.Text.Trim(),this.txtTransporte.Text.Trim(), this.txtTelefono.Text.Trim());
                    }
                    else
                    {
                        rpta = CN_Clientes.Editar(this.IdCliente, this.txtTransporte.Text.Trim(), this.txtTitular.Text.Trim(), this.txtTelefono.Text.Trim());
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            this.Close();
        }
        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SGM", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SGM", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
