namespace pruebadiseño.Formularios
{
    partial class AdminReservas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.cbMesa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrar Reservas";
            // 
            // dgvReservas
            // 
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(16, 66);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.Size = new System.Drawing.Size(531, 300);
            this.dgvReservas.TabIndex = 100;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(621, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(621, 73);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 2;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(621, 120);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(186)))));
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(137)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(15, 382);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 33);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(186)))));
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(137)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(108, 383);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 32);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(186)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(201, 384);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 31);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(186)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(131)))), ((int)(((byte)(30)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(204)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(294, 384);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 31);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Cel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Hora";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(621, 315);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Id";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(621, 218);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(110, 24);
            this.dtpFecha.TabIndex = 5;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "\"hh:mm tt\"";
            this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(621, 264);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(112, 24);
            this.dtpHora.TabIndex = 6;
            this.dtpHora.ValueChanged += new System.EventHandler(this.dtpHora_ValueChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.FormattingEnabled = true;
            this.txtCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.txtCantidad.Location = new System.Drawing.Point(621, 169);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(55, 26);
            this.txtCantidad.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(621, 395);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 101;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(186)))));
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(137)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBuscar.IconSize = 30;
            this.btnBuscar.Location = new System.Drawing.Point(580, 409);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 33);
            this.btnBuscar.TabIndex = 102;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbBuscarPor
            // 
            this.cbBuscarPor.FormattingEnabled = true;
            this.cbBuscarPor.Items.AddRange(new object[] {
            "Nombre",
            "Correo"});
            this.cbBuscarPor.Location = new System.Drawing.Point(621, 421);
            this.cbBuscarPor.Name = "cbBuscarPor";
            this.cbBuscarPor.Size = new System.Drawing.Size(100, 21);
            this.cbBuscarPor.TabIndex = 103;
            // 
            // cbMesa
            // 
            this.cbMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMesa.FormattingEnabled = true;
            this.cbMesa.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbMesa.Location = new System.Drawing.Point(621, 356);
            this.cbMesa.Name = "cbMesa";
            this.cbMesa.Size = new System.Drawing.Size(55, 21);
            this.cbMesa.TabIndex = 104;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(571, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 105;
            this.label9.Text = "Mesa";
            // 
            // AdminReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 441);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbMesa);
            this.Controls.Add(this.cbBuscarPor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.label1);
            this.Name = "AdminReservas";
            this.Text = "AdminReservas";
            this.Load += new System.EventHandler(this.AdminReservas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.ComboBox txtCantidad;
        private System.Windows.Forms.TextBox txtBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.ComboBox cbBuscarPor;
        private System.Windows.Forms.ComboBox cbMesa;
        private System.Windows.Forms.Label label9;
    }
}