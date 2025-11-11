using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using pruebadiseño;
using pruebadiseño.Formularios;

namespace pruebadiseño
{
    public partial class Form1 : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildFrom(new Inicio());
        }

        //Estructura RGB
        private struct RGBColors
        {

        }



        // Métodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Botón
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(34,22,39);        //Color fondo cuando se activa
                currentBtn.ForeColor = color;                           //color letras cuando se activa
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;                           //color icono cuando se activa
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(212, 175, 55);
                currentBtn.ForeColor = Color.FromArgb(10,0,0);  //color letras despues de usarse
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(10,0,0);  //color icono despues de usarse
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        public void OpenChildFrom (Form ChildFrom)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = ChildFrom;
            ChildFrom.TopLevel = false;
            ChildFrom.FormBorderStyle = FormBorderStyle.None;
            ChildFrom.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(ChildFrom);
            panelDesktop.Tag = ChildFrom;
            ChildFrom.BringToFront();
            ChildFrom.Show();
        }


        
        private void iconButton1_Click(object sender, EventArgs e) //Boton inicio
        {
            ActivateButton(sender, Color.Red);
            OpenChildFrom(new Inicio());
        }

        
        private void iconButton2_Click(object sender, EventArgs e) // Boton Reserva
        {
            ActivateButton(sender, Color.Red);
            OpenChildFrom(new ReservaForm());
        }

        private void iconButton3_Click(object sender, EventArgs e) //Boton Menu
        {
            ActivateButton(sender, Color.Red);
            OpenChildFrom(new Menu());


        }

        private void iconButton4_Click(object sender, EventArgs e) //Boton Iniciar sesion 
        {
            ActivateButton(sender, Color.Red);
            // Verificar si hay una sesión activa
            if (!string.IsNullOrEmpty(Sesion.Nombre))
            {
                // Usuario logueado: abrir PanelUsuario
                OpenChildFrom(new PanelUsuario());
            }
            else
            {
                // No logueado: abrir Login
                OpenChildFrom(new Login());
            }

        }

        private void iconButton5_Click(object sender, EventArgs e) //Boton de admin
        {
            ActivateButton(sender, Color.Red);
            OpenChildFrom(new Admin());
        }

        private void btnSalir_Click(object sender, EventArgs e)  //Boton para salir
        {
            ActivateButton(sender, Color.Red);
            this.Close();
        }



        private void btnHome_Click(object sender, EventArgs e) //Boton del logo
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        




        
    }
}
