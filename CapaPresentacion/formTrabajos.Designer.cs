namespace CapaPresentacion
{
    partial class formTrabajos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTrabajos));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalTrabajos = new System.Windows.Forms.Label();
            this.btnNuevoTrabajo = new System.Windows.Forms.Button();
            this.dataListadoTrabajos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.botonEditarListado = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoTrabajos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 91);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trabajos";
            // 
            // lblTotalTrabajos
            // 
            this.lblTotalTrabajos.AutoSize = true;
            this.lblTotalTrabajos.Location = new System.Drawing.Point(645, 143);
            this.lblTotalTrabajos.Name = "lblTotalTrabajos";
            this.lblTotalTrabajos.Size = new System.Drawing.Size(71, 13);
            this.lblTotalTrabajos.TabIndex = 24;
            this.lblTotalTrabajos.Text = "Total trabajos";
            // 
            // btnNuevoTrabajo
            // 
            this.btnNuevoTrabajo.Location = new System.Drawing.Point(413, 114);
            this.btnNuevoTrabajo.Name = "btnNuevoTrabajo";
            this.btnNuevoTrabajo.Size = new System.Drawing.Size(186, 23);
            this.btnNuevoTrabajo.TabIndex = 23;
            this.btnNuevoTrabajo.Text = "Nuevo trabajo";
            this.btnNuevoTrabajo.UseVisualStyleBackColor = true;
            this.btnNuevoTrabajo.Click += new System.EventHandler(this.btnNuevoTrabajo_Click);
            // 
            // dataListadoTrabajos
            // 
            this.dataListadoTrabajos.AllowUserToAddRows = false;
            this.dataListadoTrabajos.AllowUserToDeleteRows = false;
            this.dataListadoTrabajos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListadoTrabajos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListadoTrabajos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataListadoTrabajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoTrabajos.Location = new System.Drawing.Point(19, 159);
            this.dataListadoTrabajos.MultiSelect = false;
            this.dataListadoTrabajos.Name = "dataListadoTrabajos";
            this.dataListadoTrabajos.ReadOnly = true;
            this.dataListadoTrabajos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoTrabajos.Size = new System.Drawing.Size(739, 279);
            this.dataListadoTrabajos.TabIndex = 18;
            this.dataListadoTrabajos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListadoTrabajos_CellContentClick);
            this.dataListadoTrabajos.SelectionChanged += new System.EventHandler(this.dataListadoTrabajos_SelectionChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(19, 117);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(181, 20);
            this.txtBuscar.TabIndex = 20;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // botonEditarListado
            // 
            this.botonEditarListado.Location = new System.Drawing.Point(332, 115);
            this.botonEditarListado.Name = "botonEditarListado";
            this.botonEditarListado.Size = new System.Drawing.Size(75, 23);
            this.botonEditarListado.TabIndex = 22;
            this.botonEditarListado.Text = "Editar";
            this.botonEditarListado.UseVisualStyleBackColor = true;
            this.botonEditarListado.Click += new System.EventHandler(this.botonEditarListado_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(605, 114);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(226, 114);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::CapaPresentacion.Properties.Resources.labour;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(684, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 79);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(19, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 57);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btnRefrescar.Location = new System.Drawing.Point(727, 101);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(31, 32);
            this.btnRefrescar.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btnRefrescar, "Actualizar tabla");
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // formTrabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.lblTotalTrabajos);
            this.Controls.Add(this.btnNuevoTrabajo);
            this.Controls.Add(this.dataListadoTrabajos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.botonEditarListado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formTrabajos";
            this.Text = "                                                                                 " +
    "                                  ..:: Trabajos ::..";
            this.Load += new System.EventHandler(this.formTrabajos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoTrabajos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotalTrabajos;
        private System.Windows.Forms.Button btnNuevoTrabajo;
        private System.Windows.Forms.DataGridView dataListadoTrabajos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button botonEditarListado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}