namespace VeterinariaApp.Vistas
{
    partial class fmrNuevaAtencion
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
            this.lblAtencionNro = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblMacota = new System.Windows.Forms.Label();
            this.lblDescripcionAtencion = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dgvMascota = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboDescripcionAtencion = new System.Windows.Forms.ComboBox();
            this.cboMascota = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAtencionNro
            // 
            this.lblAtencionNro.AutoSize = true;
            this.lblAtencionNro.Location = new System.Drawing.Point(27, 26);
            this.lblAtencionNro.Name = "lblAtencionNro";
            this.lblAtencionNro.Size = new System.Drawing.Size(81, 16);
            this.lblAtencionNro.TabIndex = 0;
            this.lblAtencionNro.Text = "AtencionNro";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(35, 94);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(116, 153);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(559, 22);
            this.txtCliente.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(116, 94);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(181, 22);
            this.txtFecha.TabIndex = 4;
            // 
            // lblMacota
            // 
            this.lblMacota.AutoSize = true;
            this.lblMacota.Location = new System.Drawing.Point(35, 199);
            this.lblMacota.Name = "lblMacota";
            this.lblMacota.Size = new System.Drawing.Size(59, 16);
            this.lblMacota.TabIndex = 7;
            this.lblMacota.Text = "Mascota";
            this.lblMacota.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDescripcionAtencion
            // 
            this.lblDescripcionAtencion.AutoSize = true;
            this.lblDescripcionAtencion.Location = new System.Drawing.Point(35, 272);
            this.lblDescripcionAtencion.Name = "lblDescripcionAtencion";
            this.lblDescripcionAtencion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcionAtencion.TabIndex = 8;
            this.lblDescripcionAtencion.Text = "Descripcion";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(35, 153);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(48, 16);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // dgvMascota
            // 
            this.dgvMascota.AllowUserToAddRows = false;
            this.dgvMascota.AllowUserToDeleteRows = false;
            this.dgvMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colEdad,
            this.colTipo,
            this.colDetalle,
            this.colAcciones});
            this.dgvMascota.Location = new System.Drawing.Point(29, 322);
            this.dgvMascota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMascota.Name = "dgvMascota";
            this.dgvMascota.ReadOnly = true;
            this.dgvMascota.RowHeadersWidth = 51;
            this.dgvMascota.RowTemplate.Height = 24;
            this.dgvMascota.Size = new System.Drawing.Size(686, 150);
            this.dgvMascota.TabIndex = 10;
            this.dgvMascota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 125;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 125;
            // 
            // colEdad
            // 
            this.colEdad.HeaderText = "Edad";
            this.colEdad.MinimumWidth = 6;
            this.colEdad.Name = "colEdad";
            this.colEdad.ReadOnly = true;
            this.colEdad.Width = 125;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.MinimumWidth = 6;
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Width = 125;
            // 
            // colDetalle
            // 
            this.colDetalle.HeaderText = "Detalle";
            this.colDetalle.MinimumWidth = 6;
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.ReadOnly = true;
            this.colDetalle.Width = 125;
            // 
            // colAcciones
            // 
            this.colAcciones.HeaderText = "Acciones";
            this.colAcciones.MinimumWidth = 6;
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;
            this.colAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAcciones.Width = 125;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(589, 277);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(204, 22);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cboDescripcionAtencion
            // 
            this.cboDescripcionAtencion.FormattingEnabled = true;
            this.cboDescripcionAtencion.Location = new System.Drawing.Point(116, 272);
            this.cboDescripcionAtencion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDescripcionAtencion.Name = "cboDescripcionAtencion";
            this.cboDescripcionAtencion.Size = new System.Drawing.Size(381, 24);
            this.cboDescripcionAtencion.TabIndex = 13;
            // 
            // cboMascota
            // 
            this.cboMascota.FormattingEnabled = true;
            this.cboMascota.Location = new System.Drawing.Point(116, 199);
            this.cboMascota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMascota.Name = "cboMascota";
            this.cboMascota.Size = new System.Drawing.Size(559, 24);
            this.cboMascota.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(800, 274);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 27);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(513, 281);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 16);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(610, 511);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 33);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(467, 511);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 33);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // fmrNuevaAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VeterinariaApp.Properties.Resources.atenciones2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 574);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboMascota);
            this.Controls.Add(this.cboDescripcionAtencion);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dgvMascota);
            this.Controls.Add(this.lblDescripcionAtencion);
            this.Controls.Add(this.lblMacota);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblAtencionNro);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fmrNuevaAtencion";
            this.Text = "NuevaAtencion";
            this.Load += new System.EventHandler(this.fmrNuevaAtencion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtencionNro;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblMacota;
        private System.Windows.Forms.Label lblDescripcionAtencion;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridView dgvMascota;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboDescripcionAtencion;
        private System.Windows.Forms.ComboBox cboMascota;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalle;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
    }
}