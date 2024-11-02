namespace CapaVista.MenuAdmin.ABM_User
{
    partial class frmMantEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantEmpleado));
            this.btnCargarLista = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpBoxDatosEmp = new System.Windows.Forms.GroupBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.chkEstadoModif = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.txtNumCalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbTipoDNI = new System.Windows.Forms.ComboBox();
            this.lblMantEmp = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.chkEditar = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpBoxDatosEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarLista
            // 
            this.btnCargarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarLista.Location = new System.Drawing.Point(466, 385);
            this.btnCargarLista.Name = "btnCargarLista";
            this.btnCargarLista.Size = new System.Drawing.Size(333, 32);
            this.btnCargarLista.TabIndex = 51;
            this.btnCargarLista.Text = "Cargar Lista";
            this.btnCargarLista.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1020, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 23);
            this.btnRefresh.TabIndex = 50;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // grpBoxDatosEmp
            // 
            this.grpBoxDatosEmp.Controls.Add(this.txtCelular);
            this.grpBoxDatosEmp.Controls.Add(this.label39);
            this.grpBoxDatosEmp.Controls.Add(this.chkEstadoModif);
            this.grpBoxDatosEmp.Controls.Add(this.label5);
            this.grpBoxDatosEmp.Controls.Add(this.cmbCargo);
            this.grpBoxDatosEmp.Controls.Add(this.txtNumCalle);
            this.grpBoxDatosEmp.Controls.Add(this.label6);
            this.grpBoxDatosEmp.Controls.Add(this.txtCalle);
            this.grpBoxDatosEmp.Controls.Add(this.label14);
            this.grpBoxDatosEmp.Controls.Add(this.txtEmail);
            this.grpBoxDatosEmp.Controls.Add(this.label28);
            this.grpBoxDatosEmp.Controls.Add(this.dateNacimiento);
            this.grpBoxDatosEmp.Controls.Add(this.label29);
            this.grpBoxDatosEmp.Controls.Add(this.txtDNI);
            this.grpBoxDatosEmp.Controls.Add(this.label30);
            this.grpBoxDatosEmp.Controls.Add(this.label31);
            this.grpBoxDatosEmp.Controls.Add(this.cmbSexo);
            this.grpBoxDatosEmp.Controls.Add(this.txtApellido);
            this.grpBoxDatosEmp.Controls.Add(this.label32);
            this.grpBoxDatosEmp.Controls.Add(this.txtNombre);
            this.grpBoxDatosEmp.Controls.Add(this.label33);
            this.grpBoxDatosEmp.Controls.Add(this.label34);
            this.grpBoxDatosEmp.Controls.Add(this.label35);
            this.grpBoxDatosEmp.Controls.Add(this.cmbLocalidad);
            this.grpBoxDatosEmp.Controls.Add(this.cmbTipoDNI);
            this.grpBoxDatosEmp.Location = new System.Drawing.Point(156, 423);
            this.grpBoxDatosEmp.Name = "grpBoxDatosEmp";
            this.grpBoxDatosEmp.Size = new System.Drawing.Size(952, 174);
            this.grpBoxDatosEmp.TabIndex = 49;
            this.grpBoxDatosEmp.TabStop = false;
            this.grpBoxDatosEmp.Text = "Datos del Empleado";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(779, 88);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(151, 20);
            this.txtCelular.TabIndex = 65;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(731, 91);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(42, 13);
            this.label39.TabIndex = 64;
            this.label39.Text = "Celular:";
            // 
            // chkEstadoModif
            // 
            this.chkEstadoModif.AutoSize = true;
            this.chkEstadoModif.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEstadoModif.Checked = true;
            this.chkEstadoModif.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkEstadoModif.Location = new System.Drawing.Point(865, 28);
            this.chkEstadoModif.Name = "chkEstadoModif";
            this.chkEstadoModif.Size = new System.Drawing.Size(65, 17);
            this.chkEstadoModif.TabIndex = 63;
            this.chkEstadoModif.Text = "Estado: ";
            this.chkEstadoModif.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(735, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Cargo:";
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(779, 118);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(151, 21);
            this.cmbCargo.TabIndex = 59;
            // 
            // txtNumCalle
            // 
            this.txtNumCalle.Location = new System.Drawing.Point(562, 118);
            this.txtNumCalle.Name = "txtNumCalle";
            this.txtNumCalle.Size = new System.Drawing.Size(134, 20);
            this.txtNumCalle.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Número:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(346, 118);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(121, 20);
            this.txtCalle.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(307, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Calle:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(779, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 54;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(744, 62);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 13);
            this.label28.TabIndex = 53;
            this.label28.Text = "Mail:";
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.CustomFormat = "00/00/0000";
            this.dateNacimiento.Location = new System.Drawing.Point(563, 88);
            this.dateNacimiento.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(133, 20);
            this.dateNacimiento.TabIndex = 52;
            this.dateNacimiento.Value = new System.DateTime(2024, 6, 24, 0, 0, 0, 0);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(476, 91);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(81, 13);
            this.label29.TabIndex = 51;
            this.label29.Text = "Fecha de Nac.:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(346, 88);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(121, 20);
            this.txtDNI.TabIndex = 50;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(267, 91);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(73, 13);
            this.label30.TabIndex = 49;
            this.label30.Text = "Identificación:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(523, 63);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(34, 13);
            this.label31.TabIndex = 48;
            this.label31.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(563, 59);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(133, 21);
            this.cmbSexo.TabIndex = 47;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(346, 60);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 46;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(293, 63);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(47, 13);
            this.label32.TabIndex = 45;
            this.label32.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 44;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(81, 63);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(47, 13);
            this.label33.TabIndex = 43;
            this.label33.Text = "Nombre:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(72, 121);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(56, 13);
            this.label34.TabIndex = 42;
            this.label34.Text = "Localidad:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(31, 91);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(97, 13);
            this.label35.TabIndex = 41;
            this.label35.Text = "Tipo Identificación:";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(134, 118);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbLocalidad.TabIndex = 40;
            // 
            // cmbTipoDNI
            // 
            this.cmbTipoDNI.FormattingEnabled = true;
            this.cmbTipoDNI.Location = new System.Drawing.Point(134, 88);
            this.cmbTipoDNI.Name = "cmbTipoDNI";
            this.cmbTipoDNI.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDNI.TabIndex = 39;
            // 
            // lblMantEmp
            // 
            this.lblMantEmp.AutoSize = true;
            this.lblMantEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantEmp.Location = new System.Drawing.Point(160, 23);
            this.lblMantEmp.Name = "lblMantEmp";
            this.lblMantEmp.Size = new System.Drawing.Size(260, 25);
            this.lblMantEmp.TabIndex = 48;
            this.lblMantEmp.Text = "Mantenimiento de Empleado";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(878, 603);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 23);
            this.btnModificar.TabIndex = 47;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(156, 55);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowHeadersWidth = 47;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(952, 324);
            this.dgvEmpleados.TabIndex = 46;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1218, 11);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 52;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // chkEditar
            // 
            this.chkEditar.AutoSize = true;
            this.chkEditar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEditar.Location = new System.Drawing.Point(912, 394);
            this.chkEditar.Name = "chkEditar";
            this.chkEditar.Size = new System.Drawing.Size(59, 17);
            this.chkEditar.TabIndex = 64;
            this.chkEditar.Text = "Editar: ";
            this.chkEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(156, 603);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 23);
            this.btnNuevo.TabIndex = 65;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(996, 390);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 23);
            this.btnEliminar.TabIndex = 66;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(996, 603);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 23);
            this.btnGuardar.TabIndex = 67;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmMantEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 649);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.chkEditar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCargarLista);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grpBoxDatosEmp);
            this.Controls.Add(this.lblMantEmp);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMantEmpleado";
            this.Text = "Modificacion de Usuario";
            this.grpBoxDatosEmp.ResumeLayout(false);
            this.grpBoxDatosEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarLista;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox grpBoxDatosEmp;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.CheckBox chkEstadoModif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.TextBox txtNumCalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbTipoDNI;
        private System.Windows.Forms.Label lblMantEmp;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.CheckBox chkEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
    }
}