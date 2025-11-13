namespace pruebadiseño.Formularios
{
    partial class AdminPedidos
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
            this.btnActualizarEstado = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarEstado
            // 
            this.btnActualizarEstado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(186)))));
            this.btnActualizarEstado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(137)))));
            this.btnActualizarEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.btnActualizarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEstado.Location = new System.Drawing.Point(28, 383);
            this.btnActualizarEstado.Name = "btnActualizarEstado";
            this.btnActualizarEstado.Size = new System.Drawing.Size(165, 33);
            this.btnActualizarEstado.TabIndex = 132;
            this.btnActualizarEstado.Text = "Actualizar Estado";
            this.btnActualizarEstado.UseVisualStyleBackColor = true;
            this.btnActualizarEstado.Click += new System.EventHandler(this.btnActualizarEstado_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 130;
            this.label6.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            " "});
            this.cbEstado.Location = new System.Drawing.Point(93, 343);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(100, 21);
            this.cbEstado.TabIndex = 129;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(12, 66);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(738, 204);
            this.dgvPedidos.TabIndex = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 119;
            this.label1.Text = "Administrar Pedidos";
            // 
            // AdminPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 441);
            this.Controls.Add(this.btnActualizarEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.label1);
            this.Name = "AdminPedidos";
            this.Text = "AdminPedidos";
            this.Load += new System.EventHandler(this.AdminPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActualizarEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label label1;
    }
}