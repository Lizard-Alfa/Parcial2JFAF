namespace CpParcial2JFAF
{
    partial class FrmHorarioPrograma
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lblParametro = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtConductorPrincipal = new System.Windows.Forms.TextBox();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblConductorPrincipal = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.cbxCanal = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCanal = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.erpCanal = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpTitulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpHoraInicio = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpHoraFin = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDiaSemana = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpConductorPrincipal = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtbHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.mtbHoraFin = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbxLista.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCanal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHoraInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHoraFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDiaSemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpConductorPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(6, 23);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(741, 158);
            this.dgvLista.TabIndex = 0;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Location = new System.Drawing.Point(12, 9);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(753, 34);
            this.lblEncabezado.TabIndex = 1;
            this.lblEncabezado.Text = "Horario Programas";
            this.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(18, 50);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(316, 18);
            this.lblParametro.TabIndex = 2;
            this.lblParametro.Text = "Buscar por Canal, Titulo, Horario o Conductor:";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(344, 47);
            this.txtParametro.MaxLength = 80;
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(326, 24);
            this.txtParametro.TabIndex = 3;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Location = new System.Drawing.Point(18, 77);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(756, 187);
            this.gbxLista.TabIndex = 5;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Programas";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Location = new System.Drawing.Point(24, 270);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(741, 49);
            this.pnlAcciones.TabIndex = 6;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::CpParcial2JFAF.Properties.Resources._new;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(149, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 40);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::CpParcial2JFAF.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(249, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 40);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::CpParcial2JFAF.Properties.Resources.close;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(449, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 40);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::CpParcial2JFAF.Properties.Resources.delete;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(341, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 40);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.mtbHoraFin);
            this.gbxDatos.Controls.Add(this.mtbHoraInicio);
            this.gbxDatos.Controls.Add(this.txtConductorPrincipal);
            this.gbxDatos.Controls.Add(this.txtDiaSemana);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.txtTitulo);
            this.gbxDatos.Controls.Add(this.lblConductorPrincipal);
            this.gbxDatos.Controls.Add(this.lblDiaSemana);
            this.gbxDatos.Controls.Add(this.lblHoraFin);
            this.gbxDatos.Controls.Add(this.lblHoraInicio);
            this.gbxDatos.Controls.Add(this.cbxCanal);
            this.gbxDatos.Controls.Add(this.lblTitulo);
            this.gbxDatos.Controls.Add(this.lblCanal);
            this.gbxDatos.Location = new System.Drawing.Point(24, 326);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(741, 150);
            this.gbxDatos.TabIndex = 7;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // txtConductorPrincipal
            // 
            this.txtConductorPrincipal.Location = new System.Drawing.Point(499, 57);
            this.txtConductorPrincipal.Name = "txtConductorPrincipal";
            this.txtConductorPrincipal.Size = new System.Drawing.Size(220, 24);
            this.txtConductorPrincipal.TabIndex = 2;
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Location = new System.Drawing.Point(499, 27);
            this.txtDiaSemana.MaxLength = 20;
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(220, 24);
            this.txtDiaSemana.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::CpParcial2JFAF.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(499, 102);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::CpParcial2JFAF.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(612, 102);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 40);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(125, 57);
            this.txtTitulo.MaxLength = 100;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(220, 24);
            this.txtTitulo.TabIndex = 2;
            // 
            // lblConductorPrincipal
            // 
            this.lblConductorPrincipal.AutoSize = true;
            this.lblConductorPrincipal.Location = new System.Drawing.Point(351, 57);
            this.lblConductorPrincipal.Name = "lblConductorPrincipal";
            this.lblConductorPrincipal.Size = new System.Drawing.Size(142, 18);
            this.lblConductorPrincipal.TabIndex = 0;
            this.lblConductorPrincipal.Text = "Conductor Principal:";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(351, 27);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(128, 18);
            this.lblDiaSemana.TabIndex = 0;
            this.lblDiaSemana.Text = "Día de la Semana:";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(16, 120);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(89, 18);
            this.lblHoraFin.TabIndex = 0;
            this.lblHoraFin.Text = "Hora de Fin:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(16, 87);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(103, 18);
            this.lblHoraInicio.TabIndex = 0;
            this.lblHoraInicio.Text = "Hora de Inicio:";
            // 
            // cbxCanal
            // 
            this.cbxCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCanal.FormattingEnabled = true;
            this.cbxCanal.Location = new System.Drawing.Point(125, 25);
            this.cbxCanal.Name = "cbxCanal";
            this.cbxCanal.Size = new System.Drawing.Size(220, 26);
            this.cbxCanal.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(16, 57);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(48, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.Location = new System.Drawing.Point(16, 27);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(46, 18);
            this.lblCanal.TabIndex = 0;
            this.lblCanal.Text = "Canal";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CpParcial2JFAF.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(676, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 35);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // erpCanal
            // 
            this.erpCanal.ContainerControl = this;
            // 
            // erpTitulo
            // 
            this.erpTitulo.ContainerControl = this;
            // 
            // erpHoraInicio
            // 
            this.erpHoraInicio.ContainerControl = this;
            // 
            // erpHoraFin
            // 
            this.erpHoraFin.ContainerControl = this;
            // 
            // erpDiaSemana
            // 
            this.erpDiaSemana.ContainerControl = this;
            // 
            // erpConductorPrincipal
            // 
            this.erpConductorPrincipal.ContainerControl = this;
            // 
            // mtbHoraInicio
            // 
            this.mtbHoraInicio.BeepOnError = true;
            this.mtbHoraInicio.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtbHoraInicio.Location = new System.Drawing.Point(125, 87);
            this.mtbHoraInicio.Mask = "00:00";
            this.mtbHoraInicio.Name = "mtbHoraInicio";
            this.mtbHoraInicio.Size = new System.Drawing.Size(220, 24);
            this.mtbHoraInicio.TabIndex = 5;
            // 
            // mtbHoraFin
            // 
            this.mtbHoraFin.BeepOnError = true;
            this.mtbHoraFin.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtbHoraFin.Location = new System.Drawing.Point(125, 117);
            this.mtbHoraFin.Mask = "00:00";
            this.mtbHoraFin.Name = "mtbHoraFin";
            this.mtbHoraFin.Size = new System.Drawing.Size(220, 24);
            this.mtbHoraFin.TabIndex = 5;
            // 
            // FrmHorarioPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.lblEncabezado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHorarioPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Horaio - Programas :::";
            this.Load += new System.EventHandler(this.FrmHorarioPrograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gbxLista.ResumeLayout(false);
            this.pnlAcciones.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCanal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHoraInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHoraFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDiaSemana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpConductorPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cbxCanal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.TextBox txtConductorPrincipal;
        private System.Windows.Forms.Label lblConductorPrincipal;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider erpCanal;
        private System.Windows.Forms.ErrorProvider erpTitulo;
        private System.Windows.Forms.ErrorProvider erpHoraInicio;
        private System.Windows.Forms.ErrorProvider erpHoraFin;
        private System.Windows.Forms.ErrorProvider erpDiaSemana;
        private System.Windows.Forms.ErrorProvider erpConductorPrincipal;
        private System.Windows.Forms.MaskedTextBox mtbHoraFin;
        private System.Windows.Forms.MaskedTextBox mtbHoraInicio;
    }
}

