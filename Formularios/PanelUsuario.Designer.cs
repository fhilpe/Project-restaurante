namespace pruebadiseño.Formularios
{
    partial class PanelUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.idNameUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReservasUsuario = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.btnVerMenu = new System.Windows.Forms.Button();
            this.btnVerPedidos = new System.Windows.Forms.Button();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnCerrarCuenta = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnCerrarCuenta);
            this.panel1.Controls.Add(this.idNameUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 50);
            this.panel1.TabIndex = 0;
            // 
            // idNameUser
            // 
            this.idNameUser.AutoSize = true;
            this.idNameUser.Font = new System.Drawing.Font("Noto Serif TC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNameUser.Location = new System.Drawing.Point(97, 9);
            this.idNameUser.Name = "idNameUser";
            this.idNameUser.Size = new System.Drawing.Size(98, 23);
            this.idNameUser.TabIndex = 1;
            this.idNameUser.Text = "Name User";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 25);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(75, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ver reservas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 25);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mis Reservas";
            // 
            // dgvReservasUsuario
            // 
            this.dgvReservasUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservasUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasUsuario.Location = new System.Drawing.Point(16, 164);
            this.dgvReservasUsuario.Name = "dgvReservasUsuario";
            this.dgvReservasUsuario.ReadOnly = true;
            this.dgvReservasUsuario.Size = new System.Drawing.Size(563, 149);
            this.dgvReservasUsuario.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(131, 342);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 103;
            // 
            // cbBuscarPor
            // 
            this.cbBuscarPor.FormattingEnabled = true;
            this.cbBuscarPor.Items.AddRange(new object[] {
            "Nombre",
            "Correo"});
            this.cbBuscarPor.Location = new System.Drawing.Point(131, 368);
            this.cbBuscarPor.Name = "cbBuscarPor";
            this.cbBuscarPor.Size = new System.Drawing.Size(100, 21);
            this.cbBuscarPor.TabIndex = 105;
            // 
            // btnVerMenu
            // 
            this.btnVerMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(186)))));
            this.btnVerMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(137)))));
            this.btnVerMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.btnVerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMenu.Location = new System.Drawing.Point(16, 413);
            this.btnVerMenu.Name = "btnVerMenu";
            this.btnVerMenu.Size = new System.Drawing.Size(120, 33);
            this.btnVerMenu.TabIndex = 114;
            this.btnVerMenu.Text = "Ver el menu";
            this.btnVerMenu.UseVisualStyleBackColor = true;
            this.btnVerMenu.Click += new System.EventHandler(this.btnVerMenu_Click);
            // 
            // btnVerPedidos
            // 
            this.btnVerPedidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(186)))));
            this.btnVerPedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(76)))), ((int)(((byte)(137)))));
            this.btnVerPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(115)))), ((int)(((byte)(225)))));
            this.btnVerPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPedidos.Location = new System.Drawing.Point(164, 413);
            this.btnVerPedidos.Name = "btnVerPedidos";
            this.btnVerPedidos.Size = new System.Drawing.Size(120, 33);
            this.btnVerPedidos.TabIndex = 115;
            this.btnVerPedidos.Text = "Ver pedidos";
            this.btnVerPedidos.UseVisualStyleBackColor = true;
            this.btnVerPedidos.Click += new System.EventHandler(this.btnVerPedidos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBuscar.IconSize = 30;
            this.btnBuscar.Location = new System.Drawing.Point(75, 339);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 50);
            this.btnBuscar.TabIndex = 104;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(12, 339);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(50, 50);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnCerrarCuenta
            // 
            this.btnCerrarCuenta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCerrarCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCerrarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarCuenta.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnCerrarCuenta.IconColor = System.Drawing.Color.Black;
            this.btnCerrarCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarCuenta.Location = new System.Drawing.Point(700, 3);
            this.btnCerrarCuenta.Name = "btnCerrarCuenta";
            this.btnCerrarCuenta.Size = new System.Drawing.Size(45, 45);
            this.btnCerrarCuenta.TabIndex = 6;
            this.btnCerrarCuenta.UseVisualStyleBackColor = false;
            this.btnCerrarCuenta.Click += new System.EventHandler(this.btnCerrarCuenta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PanelUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 492);
            this.Controls.Add(this.btnVerPedidos);
            this.Controls.Add(this.btnVerMenu);
            this.Controls.Add(this.cbBuscarPor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dgvReservasUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PanelUsuario";
            this.Text = "PanelUsuario";
            this.Load += new System.EventHandler(this.PanelUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label idNameUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReservasUsuario;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnCerrarCuenta;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbBuscarPor;
        private System.Windows.Forms.Button btnVerMenu;
        private System.Windows.Forms.Button btnVerPedidos;
    }
}