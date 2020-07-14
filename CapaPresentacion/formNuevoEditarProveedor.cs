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
    public partial class formNuevoEditarProveedor : Form
    {
        CN_Proveedores objetoCN = new CN_Proveedores();
        DataTable respuesta;
        // int parametroActual;
        bool bandera;
        bool IsNuevo = false;
        bool IsEditar = false;

        private int IdProveedor;
        private string Proveedor;
        private string CUIL;
        private string Direccion;
        private string Telefono;

        public formNuevoEditarProveedor(int parametro, bool IsNuevoEditar)
        {
            InitializeComponent();
            this.IdProveedor = parametro;
            this.bandera = IsNuevoEditar;
            // MostrarProveedor(parametro);
        }

        private void formNuevoEditarProveedor_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtProveedor;
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
                this.MostrarProveedor(this.IdProveedor);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Carga los valores en los campos de texto del formulario para que se modifiquen los que se desean
        private void MostrarProveedor(int IdProveedor)
        {
            respuesta = objetoCN.MostrarProveedor(IdProveedor);

            foreach (DataRow row in respuesta.Rows)
            {
                IdProveedor = Convert.ToInt32(row["IdProveedor"]);
                Proveedor = Convert.ToString(row["Proveedor"]);
                CUIL = Convert.ToString(row["CUIL"]);
                Direccion = Convert.ToString(row["Direccion"]);
                Telefono = Convert.ToString(row["Telefono"]);


                txtProveedor.Text = Proveedor;

                txtCUIL.Text = CUIL;
                txtDireccion.Text = Direccion;
                txtTelefono.Text = Telefono;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtProveedor.Text == string.Empty || this.txtCUIL.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = CN_Proveedores.Insertar(this.txtProveedor.Text.Trim(), this.txtCUIL.Text, this.txtDireccion.Text.Trim(),
                            this.txtTelefono.Text.Trim());
                    }
                    else
                    {
                        rpta = CN_Proveedores.Editar(this.IdProveedor, this.txtProveedor.Text.Trim(), this.txtCUIL.Text, this.txtDireccion.Text.Trim(),
                            this.txtTelefono.Text.Trim());
                    }

                    if (rpta.Equals("Ok"))
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
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SGM", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SGM", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
