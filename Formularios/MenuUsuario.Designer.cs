namespace pruebadiseño.Formularios
{
    partial class MenuUsuario
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnIrCarrito = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnAgregarPedido, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvMenu, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbCategoria, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(247, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(186)))));
            this.btnAgregarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(137)))));
            this.btnAgregarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPedido.Location = new System.Drawing.Point(3, 333);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(128, 32);
            this.btnAgregarPedido.TabIndex = 115;
            this.btnAgregarPedido.Text = "Agregar Pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Categorias";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(3, 68);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.Size = new System.Drawing.Size(241, 259);
            this.dgvMenu.TabIndex = 1;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(3, 21);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(159, 21);
            this.cbCategoria.TabIndex = 0;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu Usuario";
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescripcion.Location = new System.Drawing.Point(391, 336);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.ReadOnly = true;
            this.rtbDescripcion.Size = new System.Drawing.Size(158, 66);
            this.rtbDescripcion.TabIndex = 6;
            this.rtbDescripcion.Text = "";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(555, 336);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(80, 15);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(391, 283);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 17);
            this.txtNombre.TabIndex = 8;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(391, 116);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(244, 154);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 4;
            this.pbImagen.TabStop = false;
            // 
            // btnIrCarrito
            // 
            this.btnIrCarrito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(186)))));
            this.btnIrCarrito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(137)))));
            this.btnIrCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.btnIrCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrCarrito.Location = new System.Drawing.Point(16, 442);
            this.btnIrCarrito.Name = "btnIrCarrito";
            this.btnIrCarrito.Size = new System.Drawing.Size(128, 32);
            this.btnIrCarrito.TabIndex = 116;
            this.btnIrCarrito.Text = "Ir al carrito";
            this.btnIrCarrito.UseVisualStyleBackColor = true;
            this.btnIrCarrito.Click += new System.EventHandler(this.btnIrCarrito_Click);
            // 
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 492);
            this.Controls.Add(this.btnIrCarrito);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.rtbDescripcion);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MenuUsuario";
            this.Text = "MenuUsuario";
            this.Load += new System.EventHandler(this.MenuUsuario_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIrCarrito;
    }
}