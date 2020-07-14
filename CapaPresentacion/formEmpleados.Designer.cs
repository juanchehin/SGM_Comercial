namespace CapaPresentacion
{
    partial class formEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEmpleados));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalEmpleados = new System.Windows.Forms.Label();
            this.dataListadoEmpleados = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.botonEditarListado = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnNuevoEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarTrabajos = new System.Windows.Forms.Button();
            this.btnAgregarTrabajo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 91);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empleados";
            // 
            // lblTotalEmpleados
            // 
            this.lblTotalEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalEmpleados.AutoSize = true;
            this.lblTotalEmpleados.Location = new System.Drawing.Point(657, 151);
            this.lblTotalEmpleados.Name = "lblTotalEmpleados";
            this.lblTotalEmpleados.Size = new System.Drawing.Size(35, 13);
            this.lblTotalEmpleados.TabIndex = 25;
            this.lblTotalEmpleados.Text = "label2";
            // 
            // dataListadoEmpleados
            // 
            this.dataListadoEmpleados.AllowUserToAddRows = false;
            this.dataListadoEmpleados.AllowUserToDeleteRows = false;
            this.dataListadoEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListadoEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListadoEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataListadoEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoEmpleados.Location = new System.Drawing.Point(38, 167);
            this.dataListadoEmpleados.MultiSelect = false;
            this.dataListadoEmpleados.Name = "dataListadoEmpleados";
            this.dataListadoEmpleados.ReadOnly = true;
            this.dataListadoEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoEmpleados.Size = new System.Drawing.Size(765, 291);
            this.dataListadoEmpleados.TabIndex = 19;
            this.dataListadoEmpleados.SelectionChanged += new System.EventHandler(this.dataListadoEmpleados_SelectionChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(238, 121);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(400, 121);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // botonEditarListado
            // 
            this.botonEditarListado.Location = new System.Drawing.Point(319, 121);
            this.botonEditarListado.Name = "botonEditarListado";
            this.botonEditarListado.Size = new System.Drawing.Size(75, 23);
            this.botonEditarListado.TabIndex = 23;
            this.botonEditarListado.Text = "Editar";
            this.botonEditarListado.UseVisualStyleBackColor = true;
            this.botonEditarListado.Click += new System.EventHandler(this.botonEditarListado_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(38, 121);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(181, 20);
            this.txtBuscar.TabIndex = 21;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(481, 121);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(139, 23);
            this.btnNuevoEmpleado.TabIndex = 24;
            this.btnNuevoEmpleado.Text = "Nuevo empleado";
            this.btnNuevoEmpleado.UseVisualStyleBackColor = true;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // btnAgregarTrabajos
            // 
            this.btnAgregarTrabajos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarTrabajos.Location = new System.Drawing.Point(511, 464);
            this.btnAgregarTrabajos.Name = "btnAgregarTrabajos";
            this.btnAgregarTrabajos.Size = new System.Drawing.Size(143, 23);
            this.btnAgregarTrabajos.TabIndex = 26;
            this.btnAgregarTrabajos.Text = "Ver trabajos";
            this.btnAgregarTrabajos.UseVisualStyleBackColor = true;
            this.btnAgregarTrabajos.Click += new System.EventHandler(this.btnAgregarTrabajos_Click);
            // 
            // btnAgregarTrabajo
            // 
            this.btnAgregarTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarTrabajo.Location = new System.Drawing.Point(660, 464);
            this.btnAgregarTrabajo.Name = "btnAgregarTrabajo";
            this.btnAgregarTrabajo.Size = new System.Drawing.Size(143, 23);
            this.btnAgregarTrabajo.TabIndex = 27;
            this.btnAgregarTrabajo.Text = "Agregar trabajo";
            this.btnAgregarTrabajo.UseVisualStyleBackColor = true;
            this.btnAgregarTrabajo.Click += new System.EventHandler(this.btnAgregarTrabajo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Busqueda por apellido o nombre";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::CapaPresentacion.Properties.Resources.Empleado1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(735, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 77);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 57);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btnRefrescar.Location = new System.Drawing.Point(772, 109);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(31, 32);
            this.btnRefrescar.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnRefrescar, "Actualizar tabla");
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // formEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 499);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarTrabajo);
            this.Controls.Add(this.btnAgregarTrabajos);
            this.Controls.Add(this.lblTotalEmpleados);
            this.Controls.Add(this.btnNuevoEmpleado);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.botonEditarListado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataListadoEmpleados);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formEmpleados";
            this.Text = "                                                                                 " +
    "                    ..:: Empleados ::..";
            this.Load += new System.EventHandler(this.formEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotalEmpleados;
        private System.Windows.Forms.DataGridView dataListadoEmpleados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button botonEditarListado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNuevoEmpleado;
        private System.Windows.Forms.Button btnAgregarTrabajos;
        private System.Windows.Forms.Button btnAgregarTrabajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}