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
    public partial class formNuevoEditarTrabajo : Form
    {
        CN_Trabajos objetoCN = new CN_Trabajos();
        DataTable respuesta;
        // int parametroActual;
        bool bandera;
        bool IsNuevo = false;
        bool IsEditar = false;

        private int IdTrabajo;
        private string Trabajo;
        private string PrecioUnitario;

        public formNuevoEditarTrabajo(int parametro, bool IsNuevoEditar)
        {
            InitializeComponent();
            this.IdTrabajo = parametro;
            this.bandera = IsNuevoEditar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formNuevoEditarTrabajo_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtNombreTrabajo;
            if (this.bandera)
            {
                lblEditarNuevo.Text = "Nuevo";
                this.IsNuevo = true;
                this.IsEditar = false;
            }
            else
            {
                lblEditarNuevo.Text = "Editar";
                this.IsNuevo = false;
                this.IsEditar = true;
                this.MostrarTrabajo(this.IdTrabajo);
            }
        }

        // Carga los valores en los campos de texto del formulario para que se modifiquen los que se desean
        private void MostrarTrabajo(int IdTrabajo)
        {
            respuesta = objetoCN.MostrarTrabajo(IdTrabajo);
            foreach (DataRow row in respuesta.Rows)
            {
                IdTrabajo = Convert.ToInt32(row["IdTrabajo"]);
                Trabajo = Convert.ToString(row["Trabajo"]);
                PrecioUnitario = Convert.ToString(row["Precio Unitario"]);

                txtNombreTrabajo.Text = Trabajo;
                txtPrecioUnitario.Text = PrecioUnitario;
 
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombreTrabajo.Text == string.Empty || this.txtPrecioUnitario.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = CN_Trabajos.Insertar(this.txtNombreTrabajo.Text, this.txtPrecioUnitario.Text);
                    }
                    else
                    {
                        rpta = CN_Trabajos.Editar(this.IdTrabajo, this.txtNombreTrabajo.Text.Trim(), this.txtPrecioUnitario.Text.Trim());
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
                        this.Close();
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

        private void txtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar valores numericos para el precio");
            }
        }
    }
}
