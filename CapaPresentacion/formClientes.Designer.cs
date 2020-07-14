namespace CapaPresentacion
{
    partial class formClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataListadoClientes = new System.Windows.Forms.DataGridView();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.botonEditarListado = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 91);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clientes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CapaPresentacion.Properties.Resources.man4;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(675, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 74);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 57);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataListadoClientes
            // 
            this.dataListadoClientes.AllowUserToAddRows = false;
            this.dataListadoClientes.AllowUserToDeleteRows = false;
            this.dataListadoClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListadoClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListadoClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoClientes.Location = new System.Drawing.Point(31, 158);
            this.dataListadoClientes.MultiSelect = false;
            this.dataListadoClientes.Name = "dataListadoClientes";
            this.dataListadoClientes.ReadOnly = true;
            this.dataListadoClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoClientes.Size = new System.Drawing.Size(703, 315);
            this.dataListadoClientes.TabIndex = 10;
            this.dataListadoClientes.SelectionChanged += new System.EventHandler(this.dataListadoClientes_SelectionChanged);
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Location = new System.Drawing.Point(626, 142);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(35, 13);
            this.lblTotalClientes.TabIndex = 16;
            this.lblTotalClientes.Text = "label2";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(394, 100);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(186, 23);
            this.btnNuevoCliente.TabIndex = 15;
            this.btnNuevoCliente.Text = "Nuevo cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(31, 100);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(181, 20);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // botonEditarListado
            // 
            this.botonEditarListado.Location = new System.Drawing.Point(313, 100);
            this.botonEditarListado.Name = "botonEditarListado";
            this.botonEditarListado.Size = new System.Drawing.Size(75, 23);
            this.botonEditarListado.TabIndex = 14;
            this.botonEditarListado.Text = "Editar";
            this.botonEditarListado.UseVisualStyleBackColor = true;
            this.botonEditarListado.Click += new System.EventHandler(this.botonEditarListado_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(586, 100);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(231, 100);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Busqueda por titular o transporte";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btnRefrescar.Location = new System.Drawing.Point(703, 100);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(31, 32);
            this.btnRefrescar.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btnRefrescar, "Actualizar tabla");
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // formClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 485);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalClientes);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.botonEditarListado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataListadoClientes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formClientes";
            this.Text = "                                                                                 " +
    "                                 ..:: Clientes ::..";
            this.Load += new System.EventHandler(this.formClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataListadoClientes;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button botonEditarListado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}