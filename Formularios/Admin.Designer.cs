namespace pruebadiseño.Formularios
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpenMenu = new System.Windows.Forms.Button();
            this.btnOpenBooking = new System.Windows.Forms.Button();
            this.btnOpenUsers = new System.Windows.Forms.Button();
            this.panelPadreAdmin = new System.Windows.Forms.Panel();
            this.btnOpenPedidos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 60;
            this.label1.Text = "Panel de Administrador";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 40);
            this.panel1.TabIndex = 62;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnOpenPedidos, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOpenMenu, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOpenBooking, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOpenUsers, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 30);
            this.tableLayoutPanel1.TabIndex = 63;
            // 
            // btnOpenMenu
            // 
            this.btnOpenMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenMenu.Location = new System.Drawing.Point(377, 3);
            this.btnOpenMenu.Name = "btnOpenMenu";
            this.btnOpenMenu.Size = new System.Drawing.Size(181, 24);
            this.btnOpenMenu.TabIndex = 0;
            this.btnOpenMenu.Text = "Administrar Menu";
            this.btnOpenMenu.UseVisualStyleBackColor = true;
            this.btnOpenMenu.Click += new System.EventHandler(this.btnOpenMenu_Click);
            // 
            // btnOpenBooking
            // 
            this.btnOpenBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenBooking.Location = new System.Drawing.Point(3, 3);
            this.btnOpenBooking.Name = "btnOpenBooking";
            this.btnOpenBooking.Size = new System.Drawing.Size(181, 24);
            this.btnOpenBooking.TabIndex = 64;
            this.btnOpenBooking.Text = "Administrar Reservas";
            this.btnOpenBooking.UseVisualStyleBackColor = true;
            this.btnOpenBooking.Click += new System.EventHandler(this.btnOpenBooking_Click);
            // 
            // btnOpenUsers
            // 
            this.btnOpenUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenUsers.Location = new System.Drawing.Point(190, 3);
            this.btnOpenUsers.Name = "btnOpenUsers";
            this.btnOpenUsers.Size = new System.Drawing.Size(181, 24);
            this.btnOpenUsers.TabIndex = 65;
            this.btnOpenUsers.Text = "Administrar Usuarios";
            this.btnOpenUsers.UseVisualStyleBackColor = true;
            this.btnOpenUsers.Click += new System.EventHandler(this.btnOpenUsers_Click);
            // 
            // panelPadreAdmin
            // 
            this.panelPadreAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPadreAdmin.Location = new System.Drawing.Point(0, 70);
            this.panelPadreAdmin.Name = "panelPadreAdmin";
            this.panelPadreAdmin.Size = new System.Drawing.Size(748, 422);
            this.panelPadreAdmin.TabIndex = 64;
            // 
            // btnOpenPedidos
            // 
            this.btnOpenPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenPedidos.Location = new System.Drawing.Point(564, 3);
            this.btnOpenPedidos.Name = "btnOpenPedidos";
            this.btnOpenPedidos.Size = new System.Drawing.Size(181, 24);
            this.btnOpenPedidos.TabIndex = 0;
            this.btnOpenPedidos.Text = "Administrar Pedidos";
            this.btnOpenPedidos.UseVisualStyleBackColor = true;
            this.btnOpenPedidos.Click += new System.EventHandler(this.btnOpenPedidos_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 492);
            this.Controls.Add(this.panelPadreAdmin);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOpenBooking;
        private System.Windows.Forms.Button btnOpenUsers;
        private System.Windows.Forms.Panel panelPadreAdmin;
        private System.Windows.Forms.Button btnOpenMenu;
        private System.Windows.Forms.Button btnOpenPedidos;
    }
}