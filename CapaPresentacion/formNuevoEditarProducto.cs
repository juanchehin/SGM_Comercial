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
    public partial class formNuevoEditarProducto : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        DataTable respuesta;
        // int parametroActual;
        bool bandera;
        bool IsNuevo = false;
        bool IsEditar = false;

        private int IdProducto;
        private string Producto;
        private string Codigo;
        private string PrecioCompra;
        private string PrecioVenta;
        private string Stock;
        private string Descripcion;

        public formNuevoEditarProducto(int parametro,bool IsNuevoEditar)
        {
            Console.WriteLine("El parametro es : " + parametro);
            InitializeComponent();
            this.IdProducto = parametro;
            this.bandera = IsNuevoEditar;
            // this.ActiveControl = txtNombre;
            // this.txtNombre.Focus();

        }

        private void formNuevoEditarProducto_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtNombre;
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
                this.MostrarProducto(this.IdProducto);
            }

            
        }

        // Carga los valores en los campos de texto del formulario para que se modifiquen los que se desean
        private void MostrarProducto(int IdProducto)
        {
            respuesta = objetoCN.MostrarProducto(IdProducto);

            Console.WriteLine("Respuesta es ; " + respuesta.Rows.Count );
            foreach (DataRow row in respuesta.Rows)
            {
                Console.WriteLine("row es :" + row["Producto"]);

                IdProducto = Convert.ToInt32(row["IdProducto"]);
                Producto = Convert.ToString(row["Producto"]);
                Codigo = Convert.ToString(row["Codigo"]);
                PrecioCompra = Convert.ToString(row["PrecioCompra"]);
                PrecioVenta = Convert.ToString(row["PrecioVenta"]);
                Stock = Convert.ToString(row["Stock"]);
                Descripcion = Convert.ToString(row["Descripcion"]);


                    txtNombre.Text = Producto;

                    txtCodigo.Text = Codigo;
                    txtStock.Text = Stock;
                    txtPrecioCompra.Text = PrecioCompra;
                    txtPrecioVenta.Text = PrecioVenta;
                    txtDescripcion.Text = Descripcion; 

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                try
                {
                    string rpta = "";
                    if (this.txtNombre.Text == string.Empty || this.txtStock.Text == string.Empty || this.txtPrecioCompra.Text == string.Empty || this.txtPrecioVenta.Text == string.Empty)
                    {
                        MensajeError("Falta ingresar algunos datos");
                    }
                    else
                    {
                        if (this.IsNuevo)
                        {
                            rpta = CN_Productos.Insertar(this.txtNombre.Text.Trim(), this.txtCodigo.Text.Trim(), this.txtPrecioCompra.Text.Trim(),
                                this.txtPrecioVenta.Text.Trim(), this.txtDescripcion.Text.Trim(),
                                this.txtStock.Text.Trim());
                        }
                        else
                        {
                            rpta = CN_Productos.Editar(this.IdProducto, this.txtNombre.Text.Trim(), this.txtCodigo.Text.Trim(),
                                this.txtPrecioCompra.Text.Trim(), this.txtPrecioVenta.Text.Trim(), this.txtDescripcion.Text.Trim()
                                , this.txtStock.Text.Trim());
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {

            Char chr = e.KeyChar;

            if(!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar valores numericos ");
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar valores numericos ");
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar valores numericos ");
            }
        }

        private void formNuevoEditarProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Se debe mostrar cuando se cierre el formulario de editar");
            formProductos formP = new formProductos();
            formP.MostrarProductos();
        }

        private void txtPrecioCompra_MouseHover(object sender, EventArgs e)
        {
            this.ttPrecioCompra.SetToolTip(txtPrecioCompra, "Precio al que se esta comprando actualmente el producto");
        }

        private void txtPrecioVenta_MouseHover(object sender, EventArgs e)
        {
            this.ttPrecioVenta.SetToolTip(txtPrecioCompra, "Precio al que se esta vendiendo actualmente el producto");
        }
    }
}
