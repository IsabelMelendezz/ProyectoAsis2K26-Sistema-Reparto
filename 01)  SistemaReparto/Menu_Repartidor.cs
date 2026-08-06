using SistemaReparto.Clases;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaReparto
{
    public partial class Menu_Repartidor : Form
    {
        private Form activeForm = null;

        // --- Controles del panel "Paquetes por Entregar" (creados por código) ---
        private Panel pnlPedidosPendientes;
        private FlowLayoutPanel flpFilasPedidos;
        private Label lblTotalPedidos;
        private Label lblPesoTotal;
        private Label lblParadas;
        private Label lblTiempoEstimado;

        public Menu_Repartidor()
        {
            InitializeComponent();
        }

        private void OpenFormInPanel(Form childForm)
        {
            // Cerrar formulario activo si existe
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnl_Control.Controls.Clear();
            pnl_Control.Controls.Add(childForm);
            pnl_Control.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Usuarios());
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Rutas());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Bodegas());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Bienvenido_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ActualizarInformacionUsuario()
        {
            lbl_usu_con.Text = $"Usuario: {Sesion.NombreEmpleado}";
            lbl_rol_con.Text = $"Rol: {Sesion.RolesComoTexto()}";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarInformacionUsuario();
            lbelUsuario.Text = Sesion.NombreUsuario + "!";
            lbelUsuario.ForeColor = Color.Navy;
            lbelUsuario.Enabled = false;

            // --- Dashboard del repartidor ---
            CMenu_Repartidor controlador = new CMenu_Repartidor();
            var datos = controlador.ObtenerDashboard(Sesion.IdUsuario);

            text_Estado_Ruta.Text = datos.NombreEstadoRuta;
            text_Area.Text = datos.AreaRuta;

            text_Usuario.Text = datos.NombreEmpleado;
            text_Rol.Text = datos.NombreRol;
            text_Ruta_Asignada.Text = datos.NombreTipoRuta;
            text_Area_Asignada.Text = datos.AreaAsignada;

            label_paquetes.Text = datos.PaquetesPendientes.ToString();
            label_rutas.Text = datos.IdRuta > 0 ? "1" : "0";
            label_entregas.Text = datos.EntregasHoy.ToString();
            label_actual.Text = datos.EstadoEmpleado;

            ConvertirCamposALabels();
            InicializarPanelPedidos();
            CargarPedidosAsignacion(datos.IdAsignacion);
        }

        // ================== CAMPOS DE DATOS: TEXTBOX -> LABEL ==================

        // Sustituye cada TextBox de solo-información por un Label (mismo lugar, mismo tamaño)
        // para que se vea como dato, no como campo editable.
        private void ConvertirCamposALabels()
        {
            foreach (var caja in new[] { text_Usuario, text_Rol, text_Area_Asignada, text_Ruta_Asignada, text_Estado_Ruta, text_Area })
            {
                var lbl = new Label
                {
                    Text = string.IsNullOrWhiteSpace(caja.Text) ? "-" : caja.Text,
                    Location = caja.Location,
                    Size = caja.Size,
                    Font = new Font("Century Gothic", 10.5F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(30, 30, 30),
                    BackColor = Color.Transparent,
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoEllipsis = true,
                    AutoSize = false
                };

                caja.Parent.Controls.Add(lbl);
                lbl.BringToFront();
                caja.Visible = false;
            }
        }

        // ================== PANEL "PAQUETES POR ENTREGAR" ==================

        private void InicializarPanelPedidos()
        {
            pnl_Control.AutoScroll = true;

            // Alineado con el ancho real que usan las 4 tarjetas de resumen (x=21 .. x=1213)
            pnlPedidosPendientes = new Panel
            {
                Location = new Point(21, 764),
                Size = new Size(1192, 460),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            var lblTitulo = new Label
            {
                Text = "Paquetes por Entregar",
                Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold),
                ForeColor = Color.Navy,
                AutoSize = true,
                BackColor = Color.Transparent,
                Location = new Point(20, 14)
            };
            pnlPedidosPendientes.Controls.Add(lblTitulo);

            // --- Encabezado de columnas ---
            var header = new Panel
            {
                Location = new Point(14, 54),
                Size = new Size(1162, 40),
                BackColor = Color.FromArgb(245, 248, 255)
            };

            void AgregarHeader(string texto, int x, int width, ContentAlignment alineacion)
            {
                header.Controls.Add(new Label
                {
                    Text = texto,
                    Location = new Point(x, 0),
                    Size = new Size(width, header.Height),
                    TextAlign = alineacion,
                    Font = new Font("Century Gothic", 9.5F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(90, 90, 90)
                });
            }

            AgregarHeader("No.", 20, 50, ContentAlignment.MiddleCenter);
            AgregarHeader("Pedido", 80, 110, ContentAlignment.MiddleLeft);
            AgregarHeader("Cliente", 200, 190, ContentAlignment.MiddleLeft);
            AgregarHeader("Dirección", 400, 380, ContentAlignment.MiddleLeft);
            AgregarHeader("Estado", 800, 120, ContentAlignment.MiddleCenter);
            AgregarHeader("Peso (kg)", 980, 110, ContentAlignment.MiddleCenter);
            pnlPedidosPendientes.Controls.Add(header);

            // --- Filas (scrollable) ---
            flpFilasPedidos = new FlowLayoutPanel
            {
                Location = new Point(14, 96),
                Size = new Size(1162, 288),
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = Color.White,
                TabStop = true // permite que reciba foco y así capture la rueda del mouse
            };

            // FlowLayoutPanel a veces muestra una barra horizontal "fantasma" que
            // achica el área visible. Este truco (apagar/prender AutoScroll) fuerza
            // a que solo se calcule y muestre la barra vertical.
            flpFilasPedidos.AutoScroll = false;
            flpFilasPedidos.HorizontalScroll.Enabled = false;
            flpFilasPedidos.HorizontalScroll.Visible = false;
            flpFilasPedidos.AutoScroll = true;

            // Sin esto, para que la rueda del mouse funcione hay que darle foco
            // manualmente al pasar el mouse por encima (los Panel no toman foco solos).
            flpFilasPedidos.MouseEnter += (s, e) =>
            {
                if (!flpFilasPedidos.Focused) flpFilasPedidos.Focus();
            };

            pnlPedidosPendientes.Controls.Add(flpFilasPedidos);

            // --- Resumen inferior ---
            var panelResumen = new Panel
            {
                Location = new Point(14, 390),
                Size = new Size(1162, 60),
                BackColor = Color.FromArgb(245, 248, 255)
            };
            lblTotalPedidos = CrearTarjetaResumen(panelResumen, "Total Pedidos:", 30);
            lblPesoTotal = CrearTarjetaResumen(panelResumen, "Peso Total:", 320);
            lblParadas = CrearTarjetaResumen(panelResumen, "Paradas:", 630);
            lblTiempoEstimado = CrearTarjetaResumen(panelResumen, "Tiempo Estimado:", 890);
            pnlPedidosPendientes.Controls.Add(panelResumen);

            pnl_Control.Controls.Add(pnlPedidosPendientes);
            pnlPedidosPendientes.BringToFront();
        }

        private Label CrearTarjetaResumen(Panel contenedor, string titulo, int x)
        {
            var lblTitulo = new Label
            {
                Text = titulo,
                Font = new Font("Century Gothic", 9.5F, FontStyle.Regular),
                ForeColor = Color.FromArgb(90, 90, 90),
                Location = new Point(x, 8),
                AutoSize = true
            };
            var lblValor = new Label
            {
                Text = "0",
                Font = new Font("Century Gothic", 13F, FontStyle.Bold),
                ForeColor = Color.Navy,
                Location = new Point(x, 30),
                AutoSize = true
            };
            contenedor.Controls.Add(lblTitulo);
            contenedor.Controls.Add(lblValor);
            return lblValor;
        }

        private void CargarPedidosAsignacion(int idAsignacion)
        {
            flpFilasPedidos.Controls.Clear();

            CMenu_Repartidor controlador = new CMenu_Repartidor();
            var pedidos = controlador.ObtenerPedidosPendientesAsignacion(idAsignacion);

            int orden = 1;
            decimal pesoTotal = 0;

            foreach (var pedido in pedidos)
            {
                flpFilasPedidos.Controls.Add(CrearFilaPedido(orden, pedido));
                pesoTotal += pedido.Peso;
                orden++;
            }

            if (pedidos.Count == 0)
            {
                flpFilasPedidos.Controls.Add(new Label
                {
                    Text = "No tienes paquetes pendientes por entregar. ¡Buen trabajo!",
                    AutoSize = true,
                    Font = new Font("Century Gothic", 10F, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Margin = new Padding(20, 20, 0, 0)
                });
            }

            lblTotalPedidos.Text = pedidos.Count.ToString();
            lblPesoTotal.Text = pesoTotal.ToString("0.00") + " kg";
            lblParadas.Text = pedidos.Count.ToString();

            int minutosEstimados = pedidos.Count * 25; // ~25 min por parada (ajustable a tu criterio)
            var tiempo = TimeSpan.FromMinutes(minutosEstimados);
            lblTiempoEstimado.Text = (tiempo.Hours > 0 ? tiempo.Hours + "h " : "") + tiempo.Minutes + "m";
        }

        private Panel CrearFilaPedido(int orden, PedidoRepartoInfo pedido)
        {
            var fila = new Panel
            {
                Size = new Size(1140, 58),
                BackColor = Color.White,
                Margin = new Padding(0)
            };

            // El mouse suele quedar "encima" de esta fila, no del FlowLayoutPanel
            // que la contiene, así que le pasamos el foco a flpFilasPedidos para
            // que la rueda del mouse siga haciendo scroll en la tabla.
            fila.MouseEnter += (s, e) =>
            {
                if (!flpFilasPedidos.Focused) flpFilasPedidos.Focus();
            };

            fila.Paint += (s, e) =>
            {
                using (var pen = new Pen(Color.FromArgb(230, 230, 230)))
                {
                    e.Graphics.DrawLine(pen, 0, fila.Height - 1, fila.Width, fila.Height - 1);
                }
            };

            Label CrearCelda(string texto, int x, int width, ContentAlignment alineacion, bool negrita)
            {
                return new Label
                {
                    Text = texto,
                    Location = new Point(x, 0),
                    Size = new Size(width, fila.Height),
                    TextAlign = alineacion,
                    Font = new Font("Century Gothic", 9.5F, negrita ? FontStyle.Bold : FontStyle.Regular),
                    ForeColor = Color.FromArgb(50, 50, 50),
                    BackColor = Color.Transparent,
                    AutoEllipsis = true
                };
            }

            fila.Controls.Add(CrearCelda(orden.ToString(), 20, 50, ContentAlignment.MiddleCenter, true));
            fila.Controls.Add(CrearCelda(pedido.CodigoPedido, 80, 110, ContentAlignment.MiddleLeft, true));
            fila.Controls.Add(CrearCelda(pedido.Cliente, 200, 190, ContentAlignment.MiddleLeft, false));
            fila.Controls.Add(CrearCelda(pedido.Direccion, 400, 380, ContentAlignment.MiddleLeft, false));

            var pill = CrearPillEstado(pedido.Estado);
            pill.Location = new Point(800 + (120 - pill.Width) / 2, (fila.Height - pill.Height) / 2);
            fila.Controls.Add(pill);

            fila.Controls.Add(CrearCelda(pedido.Peso.ToString("0.00"), 980, 110, ContentAlignment.MiddleCenter, false));

            return fila;
        }

        private Panel CrearPillEstado(string estado)
        {
            Color fondo, texto;
            switch ((estado ?? "").Trim().ToLower())
            {
                case "pendiente":
                    fondo = Color.FromArgb(255, 243, 205);
                    texto = Color.FromArgb(133, 100, 4);
                    break;
                case "en ruta":
                case "en camino":
                    fondo = Color.FromArgb(207, 226, 255);
                    texto = Color.FromArgb(4, 84, 133);
                    break;
                case "entregado":
                    fondo = Color.FromArgb(209, 231, 221);
                    texto = Color.FromArgb(15, 81, 50);
                    break;
                case "no entregado":
                case "cancelado":
                    fondo = Color.FromArgb(248, 215, 218);
                    texto = Color.FromArgb(114, 28, 36);
                    break;
                default:
                    fondo = Color.FromArgb(226, 226, 226);
                    texto = Color.FromArgb(66, 66, 66);
                    break;
            }

            var pill = new Panel
            {
                Size = new Size(110, 32),
                BackColor = Color.Transparent
            };

            var lbl = new Label
            {
                Text = estado,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Century Gothic", 9F, FontStyle.Bold),
                ForeColor = texto,
                BackColor = Color.Transparent
            };
            pill.Controls.Add(lbl);

            pill.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var path = ObtenerRectanguloRedondeado(new Rectangle(0, 0, pill.Width - 1, pill.Height - 1), pill.Height / 2))
                using (var brush = new SolidBrush(fondo))
                {
                    e.Graphics.FillPath(brush, path);
                }
            };

            return pill;
        }

        private GraphicsPath ObtenerRectanguloRedondeado(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            var path = new GraphicsPath();
            var arc = new Rectangle(bounds.Location, new Size(diameter, diameter));

            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }

        // ================== RESTO DE EVENTOS ORIGINALES ==================

        private void panelcontrol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Transportes());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Paquetes());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Reportes());
        }

        private void btnRepartidores_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Empleados());
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Sucursales());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            OpenFormInPanel(new Bienvenida());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OpenFormInPanel(new Pedidos());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Area_Cubierta());
        }

        private void btnAsignacion_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Asignaciones());
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void text_Ruta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que deseas cerrar sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Logs formLogin = new Logs();
                formLogin.Show();
                this.Hide();
            }
        }
    }
}