namespace CapaPresentacion
{
    partial class formVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVentas));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.dataListadoVentas = new System.Windows.Forms.DataGridView();
            this.botonEditarListado = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 91);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ventas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::CapaPresentacion.Properties.Resources.sale;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(677, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 75);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Location = new System.Drawing.Point(633, 143);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(35, 13);
            this.lblTotalVentas.TabIndex = 31;
            this.lblTotalVentas.Text = "label2";
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Location = new System.Drawing.Point(482, 105);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(186, 23);
            this.btnNuevaVenta.TabIndex = 30;
            this.btnNuevaVenta.Text = "Nueva venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // dataListadoVentas
            // 
            this.dataListadoVentas.AllowUserToAddRows = false;
            this.dataListadoVentas.AllowUserToDeleteRows = false;
            this.dataListadoVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListadoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoVentas.Location = new System.Drawing.Point(17, 159);
            this.dataListadoVentas.MultiSelect = false;
            this.dataListadoVentas.Name = "dataListadoVentas";
            this.dataListadoVentas.ReadOnly = true;
            this.dataListadoVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoVentas.Size = new System.Drawing.Size(739, 279);
            this.dataListadoVentas.TabIndex = 25;
            this.dataListadoVentas.SelectionChanged += new System.EventHandler(this.dataListadoVentas_SelectionChanged);
            // 
            // botonEditarListado
            // 
            this.botonEditarListado.Location = new System.Drawing.Point(17, 105);
            this.botonEditarListado.Name = "botonEditarListado";
            this.botonEditarListado.Size = new System.Drawing.Size(75, 23);
            this.botonEditarListado.TabIndex = 29;
            this.botonEditarListado.Text = "Editar";
            this.botonEditarListado.UseVisualStyleBackColor = true;
            this.botonEditarListado.Click += new System.EventHandler(this.botonEditarListado_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(98, 105);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 57);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btnRefrescar.Location = new System.Drawing.Point(723, 93);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(33, 31);
            this.btnRefrescar.TabIndex = 33;
            this.toolTip1.SetToolTip(this.btnRefrescar, "Actualizar tabla");
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click_1);
            // 
            // formVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotalVentas);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.dataListadoVentas);
            this.Controls.Add(this.botonEditarListado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formVentas";
            this.Text = "                                                                                 " +
    "                         ..:: Ventas ::..";
            this.Load += new System.EventHandler(this.formVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.DataGridView dataListadoVentas;
        private System.Windows.Forms.Button botonEditarListado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}