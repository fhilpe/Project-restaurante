namespace pruebadiseño.Formularios
{
    partial class MenuAdmin
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkDisponible = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administrar Menu";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 59);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(531, 300);
            this.dgvProductos.TabIndex = 101;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(650, 56);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProducto.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 103;
            this.label4.Text = "Id Producto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(646, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(646, 167);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 106;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(646, 232);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(578, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 111;
            this.label6.Text = "Categoria";
            // 
            // chkDisponible
            // 
            this.chkDisponible.AutoSize = true;
            this.chkDisponible.Checked = true;
            this.chkDisponible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisponible.Location = new System.Drawing.Point(581, 389);
            this.chkDisponible.Name = "chkDisponible";
            this.chkDisponible.Size = new System.Drawing.Size(75, 17);
            this.chkDisponible.TabIndex = 112;
            this.chkDisponible.Text = "Disponible";
            this.chkDisponible.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(186)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(131)))), ((int)(((byte)(30)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(204)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(291, 375);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 31);
            this.btnGuardar.TabIndex = 116;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(186)))));
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(137)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 373);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 33);
            this.btnLimpiar.TabIndex = 113;
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
            this.btnModificar.Location = new System.Drawing.Point(105, 374);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 32);
            this.btnModificar.TabIndex = 114;
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
            this.btnEliminar.Location = new System.Drawing.Point(198, 375);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 31);
            this.btnEliminar.TabIndex = 115;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(650, 339);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(100, 20);
            this.txtImagen.TabIndex = 117;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Url Imagen";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            " "});
            this.cbCategoria.Location = new System.Drawing.Point(646, 285);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(100, 21);
            this.cbCategoria.TabIndex = 110;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 441);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.chkDisponible);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.label1);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkDisponible;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}