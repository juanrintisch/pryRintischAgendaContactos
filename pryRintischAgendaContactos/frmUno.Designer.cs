namespace pryRintischAgendaContactos
{
    partial class frmUno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUno));
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.mskNumero = new System.Windows.Forms.MaskedTextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.brnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpTabla = new System.Windows.Forms.GroupBox();
            this.dtaDatos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDatos.SuspendLayout();
            this.grpBotones.SuspendLayout();
            this.grpTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.SteelBlue;
            this.grpDatos.Controls.Add(this.mskNumero);
            this.grpDatos.Controls.Add(this.cmbCategoria);
            this.grpDatos.Controls.Add(this.txtCorreo);
            this.grpDatos.Controls.Add(this.txtApellido);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblCategoria);
            this.grpDatos.Controls.Add(this.lblCorreo);
            this.grpDatos.Controls.Add(this.lblNumeroTelefono);
            this.grpDatos.Controls.Add(this.lblApellido);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(328, 198);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            // 
            // mskNumero
            // 
            this.mskNumero.Location = new System.Drawing.Point(165, 91);
            this.mskNumero.Mask = "(351)000-0000";
            this.mskNumero.Name = "mskNumero";
            this.mskNumero.Size = new System.Drawing.Size(80, 20);
            this.mskNumero.TabIndex = 2;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Amigo/a",
            "Familia",
            "Trabajo"});
            this.cmbCategoria.Location = new System.Drawing.Point(165, 169);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 4;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(165, 130);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(139, 20);
            this.txtCorreo.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(165, 52);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(165, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(6, 172);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(153, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Seleccione una Categoria";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(6, 133);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(112, 13);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo Electronico";
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTelefono.Location = new System.Drawing.Point(6, 94);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(93, 13);
            this.lblNumeroTelefono.TabIndex = 2;
            this.lblNumeroTelefono.Text = "Nº de Telefono";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(6, 55);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // grpBotones
            // 
            this.grpBotones.BackColor = System.Drawing.Color.SteelBlue;
            this.grpBotones.Controls.Add(this.btnEliminar);
            this.grpBotones.Controls.Add(this.brnEditar);
            this.grpBotones.Controls.Add(this.btnAgregar);
            this.grpBotones.Location = new System.Drawing.Point(12, 216);
            this.grpBotones.Name = "grpBotones";
            this.grpBotones.Size = new System.Drawing.Size(328, 69);
            this.grpBotones.TabIndex = 1;
            this.grpBotones.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(247, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 35);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // brnEditar
            // 
            this.brnEditar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.brnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnEditar.Location = new System.Drawing.Point(130, 19);
            this.brnEditar.Name = "brnEditar";
            this.brnEditar.Size = new System.Drawing.Size(75, 35);
            this.brnEditar.TabIndex = 1;
            this.brnEditar.Text = "EDITAR";
            this.brnEditar.UseVisualStyleBackColor = false;
            this.brnEditar.Click += new System.EventHandler(this.brnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(9, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 35);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpTabla
            // 
            this.grpTabla.BackColor = System.Drawing.Color.SteelBlue;
            this.grpTabla.Controls.Add(this.dtaDatos);
            this.grpTabla.Location = new System.Drawing.Point(346, 12);
            this.grpTabla.Name = "grpTabla";
            this.grpTabla.Size = new System.Drawing.Size(564, 273);
            this.grpTabla.TabIndex = 1;
            this.grpTabla.TabStop = false;
            // 
            // dtaDatos
            // 
            this.dtaDatos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.NumeroTelefono,
            this.CorreoElectronico,
            this.Categoria});
            this.dtaDatos.Location = new System.Drawing.Point(6, 13);
            this.dtaDatos.Name = "dtaDatos";
            this.dtaDatos.Size = new System.Drawing.Size(548, 254);
            this.dtaDatos.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // NumeroTelefono
            // 
            this.NumeroTelefono.HeaderText = "Nº de Telefono";
            this.NumeroTelefono.Name = "NumeroTelefono";
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.HeaderText = "Correo Electronico";
            this.CorreoElectronico.Name = "CorreoElectronico";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // frmUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(922, 302);
            this.Controls.Add(this.grpBotones);
            this.Controls.Add(this.grpTabla);
            this.Controls.Add(this.grpDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactos";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpBotones.ResumeLayout(false);
            this.grpTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.GroupBox grpTabla;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.MaskedTextBox mskNumero;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button brnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}

