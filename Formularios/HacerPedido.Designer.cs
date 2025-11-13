namespace pruebadiseño.Formularios
{
    partial class HacerPedido
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
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.btnQuitarPlato = new System.Windows.Forms.Button();
            this.btnConfirmarPedido = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoPedido = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMesa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(12, 85);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(343, 187);
            this.dgvCarrito.TabIndex = 0;
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.BackColor = System.Drawing.Color.White;
            this.btnAgregarPlato.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(186)))));
            this.btnAgregarPlato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(131)))), ((int)(((byte)(30)))));
            this.btnAgregarPlato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(204)))), ((int)(((byte)(64)))));
            this.btnAgregarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPlato.Location = new System.Drawing.Point(12, 296);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Size = new System.Drawing.Size(112, 31);
            this.btnAgregarPlato.TabIndex = 73;
            this.btnAgregarPlato.Text = "Agregar Plato";
            this.btnAgregarPlato.UseVisualStyleBackColor = false;
            this.btnAgregarPlato.Click += new System.EventHandler(this.btnAgregarPlato_Click);
            // 
            // btnQuitarPlato
            // 
            this.btnQuitarPlato.BackColor = System.Drawing.Color.White;
            this.btnQuitarPlato.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(186)))));
            this.btnQuitarPlato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnQuitarPlato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnQuitarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPlato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitarPlato.Location = new System.Drawing.Point(143, 296);
            this.btnQuitarPlato.Name = "btnQuitarPlato";
            this.btnQuitarPlato.Size = new System.Drawing.Size(121, 31);
            this.btnQuitarPlato.TabIndex = 74;
            this.btnQuitarPlato.Text = "Quitar Plato";
            this.btnQuitarPlato.UseVisualStyleBackColor = false;
            this.btnQuitarPlato.Click += new System.EventHandler(this.btnQuitarPlato_Click);
            // 
            // btnConfirmarPedido
            // 
            this.btnConfirmarPedido.BackColor = System.Drawing.Color.White;
            this.btnConfirmarPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(186)))));
            this.btnConfirmarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(131)))), ((int)(((byte)(30)))));
            this.btnConfirmarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(204)))), ((int)(((byte)(64)))));
            this.btnConfirmarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarPedido.Location = new System.Drawing.Point(281, 296);
            this.btnConfirmarPedido.Name = "btnConfirmarPedido";
            this.btnConfirmarPedido.Size = new System.Drawing.Size(132, 31);
            this.btnConfirmarPedido.TabIndex = 75;
            this.btnConfirmarPedido.Text = "Confirmar Pedido";
            this.btnConfirmarPedido.UseVisualStyleBackColor = false;
            this.btnConfirmarPedido.Click += new System.EventHandler(this.btnConfirmarPedido_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(534, 83);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Total";
            // 
            // cbTipoPedido
            // 
            this.cbTipoPedido.FormattingEnabled = true;
            this.cbTipoPedido.Location = new System.Drawing.Point(557, 123);
            this.cbTipoPedido.Name = "cbTipoPedido";
            this.cbTipoPedido.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPedido.TabIndex = 78;
            this.cbTipoPedido.SelectedIndexChanged += new System.EventHandler(this.cbTipoPedido_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Tipo Pedido";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(571, 172);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Direccion";
            // 
            // cbMesa
            // 
            this.cbMesa.FormattingEnabled = true;
            this.cbMesa.Location = new System.Drawing.Point(557, 221);
            this.cbMesa.Name = "cbMesa";
            this.cbMesa.Size = new System.Drawing.Size(121, 21);
            this.cbMesa.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Mesa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 84;
            this.label5.Text = "Carrito";
            // 
            // HacerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 441);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMesa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnConfirmarPedido);
            this.Controls.Add(this.btnQuitarPlato);
            this.Controls.Add(this.btnAgregarPlato);
            this.Controls.Add(this.dgvCarrito);
            this.Name = "HacerPedido";
            this.Text = "HacerPedido";
            this.Load += new System.EventHandler(this.HacerPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.Button btnQuitarPlato;
        private System.Windows.Forms.Button btnConfirmarPedido;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMesa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}