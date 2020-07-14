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
    public partial class formNuevoEditarCompra : Form
    {
        CN_Compras objetoCN = new CN_Compras();

        DataTable respuesta;
        // int parametroActual;
        bool bandera;
        bool IsNuevo = false;
        bool IsEditar = false;

        private int IdCompra;
        private string IdProveedor;

        private string Proveedor;

        private string Producto;

        private string Cantidad;


        public formNuevoEditarCompra(int parametro, bool IsNuevoEditar)
        {
            InitializeComponent();
            this.IdCompra = parametro;
            this.bandera = IsNuevoEditar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formNuevoEditarCompra_Load(object sender, EventArgs e)
        {
            this.CargarProductosComboBox();
            this.CargarProveedoresComboBox();
            this.ActiveControl = cbProductos;
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
                this.MostrarCompra(this.IdCompra);
            }
        }

        // Carga los valores en los campos de texto del formulario para que se modifiquen los que se desean
        // Solo se carga en el caso de EDITAR
        private void MostrarCompra(int IdCompra)
        {
            respuesta = objetoCN.MostrarCompra(IdCompra);

            Console.WriteLine("Respuesta es ; " + respuesta.Rows.Count);
            foreach (DataRow row in respuesta.Rows)
            {
                IdCompra = Convert.ToInt32(row["IdCompra"]);

                Producto = Convert.ToString(row["Producto"]);
                Cantidad = Convert.ToString(row["Cantidad"]);  // cantidad que se realizo en ese momento
                Proveedor = Convert.ToString(row["Proveedor"]);

                Console.WriteLine("IdCompra es : " + IdCompra);
                Console.WriteLine("Producto es : " + Producto);
                Console.WriteLine("Cantidad es : " + Cantidad);
                Console.WriteLine("Proveedor es : " + Proveedor);                

                cbProductos.Text = Producto;
                txtCantidad.Text = Cantidad;
                cbProveedores.Text = Proveedor;

            }
        }

        // Defino valores para usar en el metodo Cargar productos
        DataTable productos;
        CN_Productos objetoCN_productos = new CN_Productos();
        private string productoActual;

        // Cargo los productos en el comboBox
        private void CargarProductosComboBox()
        {
            productos = objetoCN_productos.MostrarProd();

            cbProductos.DataSource = productos;

            // cbTrabajos.ValueMember = cbTrabajos;
            Console.WriteLine(" cbTrabajos.ValueMember es  " + cbProductos.ValueMember);
            cbProductos.DisplayMember = "Producto";
            cbProductos.ValueMember = "IdProducto";

            this.productoActual = cbProductos.ValueMember.ToString();
        }

        // Defino valores para usar en el metodo cargar proveedores
        DataTable proveedores;
        CN_Proveedores objetoCN_Proveedores = new CN_Proveedores();
        private string proveedoresActual;

        // Cargo los Proveedores en el comboBox
        private void CargarProveedoresComboBox()
        {

            proveedores = objetoCN_Proveedores.MostrarProveedores();

            cbProveedores.DataSource = proveedores;

            // cbTrabajos.ValueMember = cbTrabajos;
            Console.WriteLine(" cbTrabajos.ValueMember es  " + cbProveedores.ValueMember);
            cbProveedores.DisplayMember = "Proveedor";
            cbProveedores.ValueMember = "IdProveedor";

            this.proveedoresActual = cbProveedores.ValueMember.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.cbProveedores.Text == string.Empty || this.cbProductos.Text == string.Empty || this.txtCantidad.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        // controlar que se esten pasando bien los valores del combo box
                        rpta = CN_Compras.Insertar(this.cbProductos.Text,this.cbProveedores.Text,  this.txtCantidad.Text);
                    }
                    else
                    {
                        rpta = CN_Compras.Editar(this.IdCompra, this.cbProductos.Text, this.cbProveedores.Text, this.txtCantidad.Text);
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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar valores numericos ");
            }
        }
    }
}
