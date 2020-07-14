namespace CapaPresentacion
{
    partial class formProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProveedores));
            this.lblTotalProveedores = new System.Windows.Forms.Label();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.dataListadoProveedores = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.botonEditarListado = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalProveedores
            // 
            this.lblTotalProveedores.AutoSize = true;
            this.lblTotalProveedores.Location = new System.Drawing.Point(664, 155);
            this.lblTotalProveedores.Name = "lblTotalProveedores";
            this.lblTotalProveedores.Size = new System.Drawing.Size(35, 13);
            this.lblTotalProveedores.TabIndex = 17;
            this.lblTotalProveedores.Text = "label2";
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.Location = new System.Drawing.Point(418, 121);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(186, 23);
            this.btnNuevoProveedor.TabIndex = 16;
            this.btnNuevoProveedor.Text = "Nuevo proveedor";
            this.btnNuevoProveedor.UseVisualStyleBackColor = true;
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // dataListadoProveedores
            // 
            this.dataListadoProveedores.AllowUserToAddRows = false;
            this.dataListadoProveedores.AllowUserToDeleteRows = false;
            this.dataListadoProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListadoProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListadoProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataListadoProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoProveedores.Location = new System.Drawing.Point(12, 171);
            this.dataListadoProveedores.MultiSelect = false;
            this.dataListadoProveedores.Name = "dataListadoProveedores";
            this.dataListadoProveedores.ReadOnly = true;
            this.dataListadoProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoProveedores.Size = new System.Drawing.Size(763, 332);
            this.dataListadoProveedores.TabIndex = 8;
            this.dataListadoProveedores.SelectionChanged += new System.EventHandler(this.dataListadoProveedores_SelectionChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 124);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(181, 20);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // botonEditarListado
            // 
            this.botonEditarListado.Location = new System.Drawing.Point(337, 121);
            this.botonEditarListado.Name = "botonEditarListado";
            this.botonEditarListado.Size = new System.Drawing.Size(75, 23);
            this.botonEditarListado.TabIndex = 15;
            this.botonEditarListado.Text = "Editar";
            this.botonEditarListado.UseVisualStyleBackColor = true;
            this.botonEditarListado.Click += new System.EventHandler(this.botonEditarListado_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(610, 121);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 91);
            this.label1.TabIndex = 13;
            this.label1.Text = "Proveedores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 57);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(199, 122);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CapaPresentacion.Properties.Resources.team1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(710, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 70);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btnRefrescar.Location = new System.Drawing.Point(744, 106);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(31, 32);
            this.btnRefrescar.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btnRefrescar, "Actualizar tabla");
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // formProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 515);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.lblTotalProveedores);
            this.Controls.Add(this.btnNuevoProveedor);
            this.Controls.Add(this.dataListadoProveedores);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.botonEditarListado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formProveedores";
            this.Text = "                                                                                 " +
    "                       ..:: Proveedores ::..";
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalProveedores;
        private System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.DataGridView dataListadoProveedores;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button botonEditarListado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}