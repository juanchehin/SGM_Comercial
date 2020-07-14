namespace CapaPresentacion
{
    partial class formCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCompras));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotalCompras = new System.Windows.Forms.Label();
            this.btnNuevaCompra = new System.Windows.Forms.Button();
            this.dataListadoCompras = new System.Windows.Forms.DataGridView();
            this.botonEditarListado = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 91);
            this.label1.TabIndex = 5;
            this.label1.Text = "Compras";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CapaPresentacion.Properties.Resources.cart;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(685, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 77);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 57);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTotalCompras
            // 
            this.lblTotalCompras.AutoSize = true;
            this.lblTotalCompras.Location = new System.Drawing.Point(635, 143);
            this.lblTotalCompras.Name = "lblTotalCompras";
            this.lblTotalCompras.Size = new System.Drawing.Size(35, 13);
            this.lblTotalCompras.TabIndex = 38;
            this.lblTotalCompras.Text = "label2";
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.Location = new System.Drawing.Point(533, 109);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(186, 23);
            this.btnNuevaCompra.TabIndex = 37;
            this.btnNuevaCompra.Text = "Nuevo compra";
            this.btnNuevaCompra.UseVisualStyleBackColor = true;
            this.btnNuevaCompra.Click += new System.EventHandler(this.btnNuevaCompra_Click);
            // 
            // dataListadoCompras
            // 
            this.dataListadoCompras.AllowUserToAddRows = false;
            this.dataListadoCompras.AllowUserToDeleteRows = false;
            this.dataListadoCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListadoCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListadoCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataListadoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoCompras.Location = new System.Drawing.Point(19, 159);
            this.dataListadoCompras.MultiSelect = false;
            this.dataListadoCompras.Name = "dataListadoCompras";
            this.dataListadoCompras.ReadOnly = true;
            this.dataListadoCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoCompras.Size = new System.Drawing.Size(739, 279);
            this.dataListadoCompras.TabIndex = 32;
            this.dataListadoCompras.SelectionChanged += new System.EventHandler(this.dataListadoProductos_SelectionChanged);
            // 
            // botonEditarListado
            // 
            this.botonEditarListado.Location = new System.Drawing.Point(19, 105);
            this.botonEditarListado.Name = "botonEditarListado";
            this.botonEditarListado.Size = new System.Drawing.Size(75, 23);
            this.botonEditarListado.TabIndex = 36;
            this.botonEditarListado.Text = "Editar";
            this.botonEditarListado.UseVisualStyleBackColor = true;
            this.botonEditarListado.Click += new System.EventHandler(this.botonEditarListado_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(100, 105);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btnRefrescar.Location = new System.Drawing.Point(725, 101);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(33, 31);
            this.btnRefrescar.TabIndex = 39;
            this.toolTip1.SetToolTip(this.btnRefrescar, "Actualizar tabla");
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // formCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.lblTotalCompras);
            this.Controls.Add(this.btnNuevaCompra);
            this.Controls.Add(this.dataListadoCompras);
            this.Controls.Add(this.botonEditarListado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCompras";
            this.Text = "                                                                                 " +
    "                              ..:: Compras ::..";
            this.Load += new System.EventHandler(this.formCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotalCompras;
        private System.Windows.Forms.Button btnNuevaCompra;
        private System.Windows.Forms.DataGridView dataListadoCompras;
        private System.Windows.Forms.Button botonEditarListado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}