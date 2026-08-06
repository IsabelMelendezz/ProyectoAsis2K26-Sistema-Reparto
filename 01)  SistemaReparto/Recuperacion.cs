using SistemaReparto.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SistemaReparto
{
    public partial class Recuperacion : Form
    {
        private readonly CRecuperarPassword objetoRecuperar = new CRecuperarPassword();

        private string usuarioActual = "";
        private string correoActual = "";
        public Recuperacion()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void Recuperacion_Load(object sender, EventArgs e)
        {
            panelStep2.Visible = false;

            txtNuevaContraseña.UseSystemPasswordChar = true;
            txtConfirmarContraseña.UseSystemPasswordChar = true;
        }

        // ---------- Helpers de dibujo (solo diseño) ----------

        private GraphicsPath GetRoundedRect(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Usado por panelStep1, panelStep2, panelSeguridad y panelImportante
        private void RoundedPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.Region = new Region(GetRoundedRect(panel.ClientRectangle, 16));
        }

        // Usado por pnlCircle1, pnlCircle2, picArrowCircle y picInfo
        private void CircleLabel_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.Region = new Region(GetRoundedRect(lbl.ClientRectangle, lbl.Height / 2));
        }

        // ---------- Stubs de eventos (lógica pendiente, se implementa manualmente) ----------

        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show(
                    "Ingrese el usuario.",
                    "Recuperación de contraseña",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show(
                    "Ingrese el correo electrónico.",
                    "Recuperación de contraseña",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCorreo.Focus();
                return;
            }

            usuarioActual = txtUsuario.Text.Trim();
            correoActual = txtCorreo.Text.Trim();

            bool enviado = objetoRecuperar.EnviarCodigo(usuarioActual, correoActual);

            if (enviado)
            {
                MessageBox.Show(
                    "Se envió un código de recuperación a su correo electrónico.",
                    "Código enviado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                panelStep1.Visible = false;
                panelStep2.Visible = true;
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show(
                    "Ingrese el código de verificación.",
                    "Recuperación de contraseña",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCodigo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNuevaContraseña.Text))
            {
                MessageBox.Show(
                    "Ingrese la nueva contraseña.",
                    "Recuperación de contraseña",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNuevaContraseña.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmarContraseña.Text))
            {
                MessageBox.Show(
                    "Confirme la nueva contraseña.",
                    "Recuperación de contraseña",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtConfirmarContraseña.Focus();
                return;
            }

            if (txtNuevaContraseña.Text != txtConfirmarContraseña.Text)
            {
                MessageBox.Show(
                    "Las contraseñas no coinciden.",
                    "Recuperación de contraseña",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNuevaContraseña.Clear();
                txtConfirmarContraseña.Clear();

                txtNuevaContraseña.Focus();

                return;
            }

            // Aquí continuará la validación del token
            if (!objetoRecuperar.ValidarTokenUsuario(usuarioActual, txtCodigo.Text.Trim()))
            {
                MessageBox.Show(
                    "El código de verificación es incorrecto o ha expirado.",
                    "Recuperación de contraseña",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCodigo.Clear();
                txtCodigo.Focus();

                return;
             }

            objetoRecuperar.ActualizarContrasena(
                 usuarioActual,
                 txtNuevaContraseña.Text.Trim());

            objetoRecuperar.LimpiarTokenUsuario(usuarioActual);

            MessageBox.Show(
                "La contraseña se actualizó correctamente.\n\nAhora puede iniciar sesión con su nueva contraseña.",
                "Contraseña actualizada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        private void lnkRegresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void lblEyeNueva_Click(object sender, EventArgs e)
        {
        }

        private void lblEyeConfirmar_Click(object sender, EventArgs e)
        {
        }
    }
}
