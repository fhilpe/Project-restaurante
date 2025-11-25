namespace pruebadiseño.Formularios
{
    partial class EditarPerfil
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(162, 219);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(162, 43);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(138, 125);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(162, 273);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(138, 20);
            this.txtCelular.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "URL Imagen";
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Location = new System.Drawing.Point(161, 325);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(138, 20);
            this.txtImagenUrl.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cambiar contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(162, 382);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(138, 20);
            this.txtContraseña.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(163, 448);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 30);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(161, 408);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(118, 17);
            this.chkShowPassword.TabIndex = 44;
            this.chkShowPassword.Text = "Mostrar Contraseña";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // EditarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 490);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtNombre);
            this.Name = "EditarPerfil";
            this.Text = "EditarPerfil";
            this.Load += new System.EventHandler(this.EditarPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chkShowPassword;
    }
}