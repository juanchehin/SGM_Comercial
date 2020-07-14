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
    public partial class formNuevoEditarVenta : Form
    {
        CN_Ventas objetoCN = new CN_Ventas();
        CN_Empleados objetoCN_empleado = new CN_Empleados();


        DataTable respuesta;
        // int parametroActual;
        bool bandera;
        bool IsNuevo = false;
        bool IsEditar = false;

        private int IdVenta;
        private string IdProveedor;

        private DateTime Fecha;

        private string Proveedor;

        private string Producto;

        private string Empleado;

        private string Cantidad;

        private string Titular; // Cliente

        public formNuevoEditarVenta(int parametro, bool IsNuevoEditar)
        {
            InitializeComponent();
            this.IdVenta = parametro;
            this.bandera = IsNuevoEditar;
        }


        private void formNuevoEditarCompra_Load(object sender, EventArgs e)
        {

        }

        // Carga los valores en los campos de texto del formulario para que se modifiquen los que se desean
        // Solo se carga en el caso de EDITAR
        private void MostrarVenta(int IdVenta)
        {
            respuesta = objetoCN.MostrarVenta(IdVenta);

            Console.WriteLine("Respuesta es ; " + respuesta.Rows.Count);
            foreach (DataRow row in respuesta.Rows)
            {
                IdVenta = Convert.ToInt32(row["IdVenta"]);

                Producto = Convert.ToString(row["Producto"]);
                Titular = Convert.ToString(row["Titular"]); // Cliente
                Empleado = Convert.ToString(row["Empleado"]); // Empleado
                Cantidad = Convert.ToString(row["Cantidad"]);
                Fecha = Convert.ToDateTime(row["Fecha"]);


                cbProductos.Text = Producto;
                // dataListadoEmpleados. = Empleado;
                cbProductos.Text = Producto;
                txtCantidad.Text = Cantidad;
                cbClientes.Text = Titular;

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

        // Defino valores para usar en el metodo cargar empleados
        // DataTable empleados;
        CN_Empleados objetoCN_Empleado = new CN_Empleados();
        // private string empleadoActual;

        // Cargo los Proveedores en el comboBox
        private void CargarEmpleados()
        {
            dataListadoEmpleados.DataSource = objetoCN_Empleado.MostrarEmp();
            dataListadoEmpleados.Columns[0].Visible = false;
            dataListadoEmpleados.Columns[3].Visible = false;
            dataListadoEmpleados.Columns[4].Visible = false;
            dataListadoEmpleados.Columns[5].Visible = false;
            dataListadoEmpleados.Columns[6].Visible = false;

        }

        // Defino valores para usar en el metodo cargar empleados
        DataTable clientes;
        CN_Clientes objetoCN_Cliente = new CN_Clientes();
        private string clienteActual;

        // Cargo los Proveedores en el comboBox
        private void CargarClientesComboBox()
        {

            clientes = objetoCN_Cliente.MostrarClientes();

            cbClientes.DataSource = clientes;

            // cbTrabajos.ValueMember = cbTrabajos;
            // Console.WriteLine(" cbTrabajos.ValueMember es  " + cbEmpleados.ValueMember);
            cbClientes.DisplayMember = "Titular";
            cbClientes.ValueMember = "IdCliente";

            this.clienteActual = cbClientes.ValueMember.ToString();
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar valores numericos ");
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.cbProductos.Text == string.Empty  || this.cbClientes.Text == string.Empty || this.txtCantidad.Text == string.Empty || dataListadoEmpleados.CurrentRow == null)
                {
                    MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = CN_Ventas.Insertar(this.cbProductos.Text, this.cbClientes.Text, this.IdEmpleado, this.txtCantidad.Text);
                    }
                    else
                    {
                        rpta = CN_Ventas.Editar(this.IdVenta, this.cbProductos.Text, this.cbClientes.Text, this.IdEmpleado, this.txtCantidad.Text);
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

        private void formNuevoEditarVenta_Load(object sender, EventArgs e)
        {
            this.CargarProductosComboBox();
            this.CargarClientesComboBox();
            this.CargarEmpleados();
            this.ActiveControl = cbProductos;
            if (this.bandera)
            {
                lblEditarNuevo.Text = "Nueva";
                // this.MostrarProducto(this.IdProducto);
                this.IsNuevo = true;
                this.IsEditar = false;

            }
            else
            {
                lblEditarNuevo.Text = "Editar";
                this.IsNuevo = false;
                this.IsEditar = true;
                this.MostrarVenta(this.IdVenta);
            }
        }
        private int IdEmpleado;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataListadoEmpleados.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataListadoEmpleados.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataListadoEmpleados.Rows[selectedrowindex];
                this.IdEmpleado = Convert.ToInt32(selectedRow.Cells["IdEmpleado"].Value);
                Console.WriteLine("El this.IdEmpleado es " + this.IdEmpleado);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dataListadoEmpleados.DataSource = objetoCN_empleado.BuscarEmpleado(this.txtBuscar.Text);
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            this.dataListadoEmpleados.DataSource = objetoCN_empleado.BuscarEmpleado(this.txtBuscar.Text);
        }
    }
}
