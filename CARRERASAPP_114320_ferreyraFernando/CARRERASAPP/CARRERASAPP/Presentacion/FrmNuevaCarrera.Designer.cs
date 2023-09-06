namespace CARRERASAPP.Presentacion
{
    partial class FrmNuevaCarrera
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
            this.lblNuevaCarrera = new System.Windows.Forms.Label();
            this.lblNombreCarrera = new System.Windows.Forms.Label();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.lblDatosMateria = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.lblAnioCursado = new System.Windows.Forms.Label();
            this.txtAnioCursado = new System.Windows.Forms.TextBox();
            this.rbnPrimerCuatrimestre = new System.Windows.Forms.RadioButton();
            this.rbnSegundoCuatrimestre = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalleCarrera = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ColIDAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevaCarrera
            // 
            this.lblNuevaCarrera.AutoSize = true;
            this.lblNuevaCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCarrera.Location = new System.Drawing.Point(34, 22);
            this.lblNuevaCarrera.Name = "lblNuevaCarrera";
            this.lblNuevaCarrera.Size = new System.Drawing.Size(124, 20);
            this.lblNuevaCarrera.TabIndex = 0;
            this.lblNuevaCarrera.Text = "Nueva Carrera";
            // 
            // lblNombreCarrera
            // 
            this.lblNombreCarrera.AutoSize = true;
            this.lblNombreCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCarrera.Location = new System.Drawing.Point(37, 76);
            this.lblNombreCarrera.Name = "lblNombreCarrera";
            this.lblNombreCarrera.Size = new System.Drawing.Size(118, 16);
            this.lblNombreCarrera.TabIndex = 1;
            this.lblNombreCarrera.Text = "Nombre Carrera";
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Location = new System.Drawing.Point(188, 72);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(303, 20);
            this.txtNombreCarrera.TabIndex = 2;
            // 
            // lblDatosMateria
            // 
            this.lblDatosMateria.AutoSize = true;
            this.lblDatosMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosMateria.Location = new System.Drawing.Point(37, 118);
            this.lblDatosMateria.Name = "lblDatosMateria";
            this.lblDatosMateria.Size = new System.Drawing.Size(134, 16);
            this.lblDatosMateria.TabIndex = 3;
            this.lblDatosMateria.Text = "Datos de Materias";
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterias.Location = new System.Drawing.Point(37, 161);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(67, 16);
            this.lblMaterias.TabIndex = 4;
            this.lblMaterias.Text = "Materias";
            // 
            // cboMaterias
            // 
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(188, 156);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(303, 21);
            this.cboMaterias.TabIndex = 5;
            // 
            // lblAnioCursado
            // 
            this.lblAnioCursado.AutoSize = true;
            this.lblAnioCursado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioCursado.Location = new System.Drawing.Point(37, 193);
            this.lblAnioCursado.Name = "lblAnioCursado";
            this.lblAnioCursado.Size = new System.Drawing.Size(118, 16);
            this.lblAnioCursado.TabIndex = 6;
            this.lblAnioCursado.Text = "Año de Cursado";
            // 
            // txtAnioCursado
            // 
            this.txtAnioCursado.Location = new System.Drawing.Point(188, 193);
            this.txtAnioCursado.Name = "txtAnioCursado";
            this.txtAnioCursado.Size = new System.Drawing.Size(303, 20);
            this.txtAnioCursado.TabIndex = 7;
            // 
            // rbnPrimerCuatrimestre
            // 
            this.rbnPrimerCuatrimestre.AutoSize = true;
            this.rbnPrimerCuatrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnPrimerCuatrimestre.Location = new System.Drawing.Point(497, 156);
            this.rbnPrimerCuatrimestre.Name = "rbnPrimerCuatrimestre";
            this.rbnPrimerCuatrimestre.Size = new System.Drawing.Size(134, 17);
            this.rbnPrimerCuatrimestre.TabIndex = 8;
            this.rbnPrimerCuatrimestre.TabStop = true;
            this.rbnPrimerCuatrimestre.Text = "Primer Cuatrimestre";
            this.rbnPrimerCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // rbnSegundoCuatrimestre
            // 
            this.rbnSegundoCuatrimestre.AutoSize = true;
            this.rbnSegundoCuatrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnSegundoCuatrimestre.Location = new System.Drawing.Point(497, 194);
            this.rbnSegundoCuatrimestre.Name = "rbnSegundoCuatrimestre";
            this.rbnSegundoCuatrimestre.Size = new System.Drawing.Size(149, 17);
            this.rbnSegundoCuatrimestre.TabIndex = 9;
            this.rbnSegundoCuatrimestre.TabStop = true;
            this.rbnSegundoCuatrimestre.Text = "Segundo Cuatrimestre";
            this.rbnSegundoCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(692, 184);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalleCarrera
            // 
            this.dgvDetalleCarrera.AllowUserToAddRows = false;
            this.dgvDetalleCarrera.AllowUserToDeleteRows = false;
            this.dgvDetalleCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCarrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIDAsignatura,
            this.ColNombreAsignatura,
            this.ColAnioCursado,
            this.ColCuatrimestre});
            this.dgvDetalleCarrera.Location = new System.Drawing.Point(37, 242);
            this.dgvDetalleCarrera.Name = "dgvDetalleCarrera";
            this.dgvDetalleCarrera.ReadOnly = true;
            this.dgvDetalleCarrera.Size = new System.Drawing.Size(751, 95);
            this.dgvDetalleCarrera.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(324, 376);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(444, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ColIDAsignatura
            // 
            this.ColIDAsignatura.HeaderText = "Id_Asignatura";
            this.ColIDAsignatura.Name = "ColIDAsignatura";
            this.ColIDAsignatura.ReadOnly = true;
            this.ColIDAsignatura.Width = 150;
            // 
            // ColNombreAsignatura
            // 
            this.ColNombreAsignatura.HeaderText = " Asignatura";
            this.ColNombreAsignatura.Name = "ColNombreAsignatura";
            this.ColNombreAsignatura.ReadOnly = true;
            this.ColNombreAsignatura.Width = 250;
            // 
            // ColAnioCursado
            // 
            this.ColAnioCursado.HeaderText = "Año Cursado";
            this.ColAnioCursado.Name = "ColAnioCursado";
            this.ColAnioCursado.ReadOnly = true;
            this.ColAnioCursado.Width = 150;
            // 
            // ColCuatrimestre
            // 
            this.ColCuatrimestre.HeaderText = "Cuatrimeste";
            this.ColCuatrimestre.Name = "ColCuatrimestre";
            this.ColCuatrimestre.ReadOnly = true;
            this.ColCuatrimestre.Width = 150;
            // 
            // FrmNuevaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvDetalleCarrera);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbnSegundoCuatrimestre);
            this.Controls.Add(this.rbnPrimerCuatrimestre);
            this.Controls.Add(this.txtAnioCursado);
            this.Controls.Add(this.lblAnioCursado);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.lblMaterias);
            this.Controls.Add(this.lblDatosMateria);
            this.Controls.Add(this.txtNombreCarrera);
            this.Controls.Add(this.lblNombreCarrera);
            this.Controls.Add(this.lblNuevaCarrera);
            this.Name = "FrmNuevaCarrera";
            this.Text = "Nueva Carrera";
            this.Load += new System.EventHandler(this.FrmNuevaCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCarrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaCarrera;
        private System.Windows.Forms.Label lblNombreCarrera;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.Label lblDatosMateria;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.Label lblAnioCursado;
        private System.Windows.Forms.TextBox txtAnioCursado;
        private System.Windows.Forms.RadioButton rbnPrimerCuatrimestre;
        private System.Windows.Forms.RadioButton rbnSegundoCuatrimestre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalleCarrera;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAnioCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuatrimestre;
    }
}