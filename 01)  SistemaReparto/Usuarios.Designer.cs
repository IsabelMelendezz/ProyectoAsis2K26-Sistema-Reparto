namespace SistemaReparto
{
    partial class Usuarios
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
            panel4 = new Panel();
            btn_cambiar_contra = new Button();
            cbo_Estado_Usuario = new ComboBox();
            label8 = new Label();
            txt_Contraseña = new TextBox();
            label6 = new Label();
            txt_Correo = new TextBox();
            txt_Nombre_Usuario = new TextBox();
            label1 = new Label();
            dtp_Fecha_Creacion = new DateTimePicker();
            pictureBox4 = new PictureBox();
            label13 = new Label();
            label2 = new Label();
            cbo_Id_Empleados = new ComboBox();
            label14 = new Label();
            txt_Nombre_Empleado = new TextBox();
            label5 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            Btn_Limpiar_Emp = new Button();
            Btn_Nuevo_Emp = new Button();
            Btn_Editar_Emp = new Button();
            Btn_Eliminar_Emp = new Button();
            Btn_Guardar_Emp = new Button();
            Btn_Actualizar_Usu = new Button();
            panel3 = new Panel();
            panel10 = new Panel();
            label11 = new Label();
            button10 = new Button();
            panel8 = new Panel();
            label9 = new Label();
            button8 = new Button();
            label17 = new Label();
            label16 = new Label();
            panel6 = new Panel();
            label18 = new Label();
            btnProbarConexion_Click = new Button();
            panel7 = new Panel();
            label19 = new Label();
            button1 = new Button();
            button7 = new Button();
            Dgv_Tabla_Usu = new DataGridView();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label15 = new Label();
            label10 = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_Usu).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(btn_cambiar_contra);
            panel4.Controls.Add(cbo_Estado_Usuario);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(txt_Contraseña);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txt_Correo);
            panel4.Controls.Add(txt_Nombre_Usuario);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(dtp_Fecha_Creacion);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(cbo_Id_Empleados);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(txt_Nombre_Empleado);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(56, 200);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(648, 512);
            panel4.TabIndex = 49;
            // 
            // btn_cambiar_contra
            // 
            btn_cambiar_contra.Location = new Point(432, 440);
            btn_cambiar_contra.Margin = new Padding(3, 4, 3, 4);
            btn_cambiar_contra.Name = "btn_cambiar_contra";
            btn_cambiar_contra.Size = new Size(144, 56);
            btn_cambiar_contra.TabIndex = 42;
            btn_cambiar_contra.UseVisualStyleBackColor = true;
            btn_cambiar_contra.Click += button2_Click;
            // 
            // cbo_Estado_Usuario
            // 
            cbo_Estado_Usuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Estado_Usuario.FormattingEnabled = true;
            cbo_Estado_Usuario.Location = new Point(520, 360);
            cbo_Estado_Usuario.Margin = new Padding(5);
            cbo_Estado_Usuario.Name = "cbo_Estado_Usuario";
            cbo_Estado_Usuario.Size = new Size(96, 28);
            cbo_Estado_Usuario.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.AliceBlue;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(448, 368);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(56, 18);
            label8.TabIndex = 48;
            label8.Text = "Estado";
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.Location = new Point(152, 320);
            txt_Contraseña.Margin = new Padding(5);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.PlaceholderText = "contraseñasegura123";
            txt_Contraseña.ShortcutsEnabled = false;
            txt_Contraseña.Size = new Size(256, 27);
            txt_Contraseña.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 328);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 18);
            label6.TabIndex = 46;
            label6.Text = "Contraseña";
            // 
            // txt_Correo
            // 
            txt_Correo.Location = new Point(152, 272);
            txt_Correo.Margin = new Padding(5);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.PlaceholderText = "ejemplo@gmail.com";
            txt_Correo.ShortcutsEnabled = false;
            txt_Correo.Size = new Size(256, 27);
            txt_Correo.TabIndex = 45;
            txt_Correo.KeyPress += txt_Correo_KeyPress;
            // 
            // txt_Nombre_Usuario
            // 
            txt_Nombre_Usuario.Location = new Point(152, 224);
            txt_Nombre_Usuario.Margin = new Padding(5);
            txt_Nombre_Usuario.Name = "txt_Nombre_Usuario";
            txt_Nombre_Usuario.PlaceholderText = "VicoromarG";
            txt_Nombre_Usuario.ShortcutsEnabled = false;
            txt_Nombre_Usuario.Size = new Size(256, 27);
            txt_Nombre_Usuario.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 232);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 18);
            label1.TabIndex = 43;
            label1.Text = "Nombre Usuario";
            // 
            // dtp_Fecha_Creacion
            // 
            dtp_Fecha_Creacion.Location = new Point(152, 368);
            dtp_Fecha_Creacion.Margin = new Padding(5);
            dtp_Fecha_Creacion.Name = "dtp_Fecha_Creacion";
            dtp_Fecha_Creacion.Size = new Size(273, 27);
            dtp_Fecha_Creacion.TabIndex = 29;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Usu_ico1;
            pictureBox4.Location = new Point(223, 13);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 42;
            pictureBox4.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(17, 376);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(128, 18);
            label13.TabIndex = 27;
            label13.Text = "Fecha Creacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(264, 16);
            label2.Name = "label2";
            label2.Size = new Size(292, 32);
            label2.TabIndex = 34;
            label2.Text = "Información del Usuario\r\n";
            // 
            // cbo_Id_Empleados
            // 
            cbo_Id_Empleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Id_Empleados.FormattingEnabled = true;
            cbo_Id_Empleados.Location = new Point(144, 80);
            cbo_Id_Empleados.Margin = new Padding(5);
            cbo_Id_Empleados.Name = "cbo_Id_Empleados";
            cbo_Id_Empleados.Size = new Size(264, 28);
            cbo_Id_Empleados.TabIndex = 30;
            cbo_Id_Empleados.SelectedIndexChanged += cmbIdEmpleado_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(16, 272);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(60, 18);
            label14.TabIndex = 31;
            label14.Text = "Correo";
            // 
            // txt_Nombre_Empleado
            // 
            txt_Nombre_Empleado.Enabled = false;
            txt_Nombre_Empleado.Location = new Point(152, 136);
            txt_Nombre_Empleado.Margin = new Padding(5);
            txt_Nombre_Empleado.Name = "txt_Nombre_Empleado";
            txt_Nombre_Empleado.PlaceholderText = "🙋 ID";
            txt_Nombre_Empleado.ShortcutsEnabled = false;
            txt_Nombre_Empleado.Size = new Size(256, 27);
            txt_Nombre_Empleado.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AliceBlue;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 80);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 18);
            label5.TabIndex = 7;
            label5.Text = "Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 136);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 18);
            label3.TabIndex = 5;
            label3.Text = "Id Empleado";
            // 
            // panel5
            // 
            panel5.BackColor = Color.AliceBlue;
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(Btn_Limpiar_Emp);
            panel5.Controls.Add(Btn_Nuevo_Emp);
            panel5.Controls.Add(Btn_Editar_Emp);
            panel5.Controls.Add(Btn_Eliminar_Emp);
            panel5.Controls.Add(Btn_Guardar_Emp);
            panel5.Controls.Add(Btn_Actualizar_Usu);
            panel5.Location = new Point(784, 568);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(425, 149);
            panel5.TabIndex = 48;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Icon_Acciones;
            pictureBox3.Location = new Point(130, 1);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 41;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(166, 1);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 40;
            label4.Text = "Acciones";
            // 
            // Btn_Limpiar_Emp
            // 
            Btn_Limpiar_Emp.Image = Properties.Resources.Btn_Limpiar;
            Btn_Limpiar_Emp.Location = new Point(287, 85);
            Btn_Limpiar_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Limpiar_Emp.Name = "Btn_Limpiar_Emp";
            Btn_Limpiar_Emp.Size = new Size(114, 47);
            Btn_Limpiar_Emp.TabIndex = 39;
            Btn_Limpiar_Emp.UseVisualStyleBackColor = true;
            // 
            // Btn_Nuevo_Emp
            // 
            Btn_Nuevo_Emp.Image = Properties.Resources.Btn_Nuevo;
            Btn_Nuevo_Emp.Location = new Point(42, 39);
            Btn_Nuevo_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Nuevo_Emp.Name = "Btn_Nuevo_Emp";
            Btn_Nuevo_Emp.Size = new Size(114, 47);
            Btn_Nuevo_Emp.TabIndex = 34;
            Btn_Nuevo_Emp.UseVisualStyleBackColor = true;
            Btn_Nuevo_Emp.Click += Btn_Nuevo_Emp_Click;
            // 
            // Btn_Editar_Emp
            // 
            Btn_Editar_Emp.Image = Properties.Resources.Btn_Editar;
            Btn_Editar_Emp.Location = new Point(287, 33);
            Btn_Editar_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Editar_Emp.Name = "Btn_Editar_Emp";
            Btn_Editar_Emp.Size = new Size(114, 47);
            Btn_Editar_Emp.TabIndex = 36;
            Btn_Editar_Emp.UseVisualStyleBackColor = true;
            Btn_Editar_Emp.Click += Btn_Editar_Emp_Click;
            // 
            // Btn_Eliminar_Emp
            // 
            Btn_Eliminar_Emp.Image = Properties.Resources.Btn_ELiminar;
            Btn_Eliminar_Emp.Location = new Point(42, 91);
            Btn_Eliminar_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Eliminar_Emp.Name = "Btn_Eliminar_Emp";
            Btn_Eliminar_Emp.Size = new Size(114, 47);
            Btn_Eliminar_Emp.TabIndex = 37;
            Btn_Eliminar_Emp.UseVisualStyleBackColor = true;
            Btn_Eliminar_Emp.Click += Btn_Eliminar_Emp_Click;
            // 
            // Btn_Guardar_Emp
            // 
            Btn_Guardar_Emp.Image = Properties.Resources.Btn_guardar;
            Btn_Guardar_Emp.Location = new Point(166, 39);
            Btn_Guardar_Emp.Margin = new Padding(3, 4, 3, 4);
            Btn_Guardar_Emp.Name = "Btn_Guardar_Emp";
            Btn_Guardar_Emp.Size = new Size(114, 47);
            Btn_Guardar_Emp.TabIndex = 35;
            Btn_Guardar_Emp.UseVisualStyleBackColor = true;
            Btn_Guardar_Emp.Click += Btn_Guardar_Emp_Click;
            // 
            // Btn_Actualizar_Usu
            // 
            Btn_Actualizar_Usu.Image = Properties.Resources.Btn_Actualizar;
            Btn_Actualizar_Usu.Location = new Point(166, 85);
            Btn_Actualizar_Usu.Margin = new Padding(3, 4, 3, 4);
            Btn_Actualizar_Usu.Name = "Btn_Actualizar_Usu";
            Btn_Actualizar_Usu.Size = new Size(114, 47);
            Btn_Actualizar_Usu.TabIndex = 38;
            Btn_Actualizar_Usu.UseVisualStyleBackColor = true;
            Btn_Actualizar_Usu.Click += Btn_Actualizar_Usu_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel7);
            panel3.Location = new Point(776, 208);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(425, 336);
            panel3.TabIndex = 47;
            // 
            // panel10
            // 
            panel10.BackColor = Color.PowderBlue;
            panel10.Controls.Add(label11);
            panel10.Controls.Add(button10);
            panel10.Location = new Point(9, 272);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(408, 51);
            panel10.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(56, 16);
            label11.Name = "label11";
            label11.Size = new Size(196, 23);
            label11.TabIndex = 42;
            label11.Text = "Asig. Modulos Usuarios";
            // 
            // button10
            // 
            button10.AccessibleRole = AccessibleRole.Clock;
            button10.Location = new Point(288, 4);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(114, 40);
            button10.TabIndex = 41;
            button10.Text = "Administrar >";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.PowderBlue;
            panel8.Controls.Add(label9);
            panel8.Controls.Add(button8);
            panel8.Location = new Point(9, 208);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(408, 51);
            panel8.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(64, 8);
            label9.Name = "label9";
            label9.Size = new Size(171, 23);
            label9.TabIndex = 42;
            label9.Text = "Asig. Modulos Roles";
            // 
            // button8
            // 
            button8.AccessibleRole = AccessibleRole.Clock;
            button8.Location = new Point(288, 4);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(114, 40);
            button8.TabIndex = 41;
            button8.Text = "Administrar >";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Navy;
            label17.Location = new Point(16, 40);
            label17.Name = "label17";
            label17.Size = new Size(405, 23);
            label17.TabIndex = 43;
            label17.Text = "Gestiona la información del personal de la empresa.";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Navy;
            label16.Location = new Point(56, 8);
            label16.Name = "label16";
            label16.Size = new Size(264, 32);
            label16.TabIndex = 35;
            label16.Text = "Catálogos del Sistema";
            // 
            // panel6
            // 
            panel6.BackColor = Color.PowderBlue;
            panel6.Controls.Add(label18);
            panel6.Controls.Add(btnProbarConexion_Click);
            panel6.Location = new Point(9, 88);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(408, 51);
            panel6.TabIndex = 44;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Navy;
            label18.Location = new Point(104, 12);
            label18.Name = "label18";
            label18.Size = new Size(52, 23);
            label18.TabIndex = 42;
            label18.Text = "Roles";
            // 
            // btnProbarConexion_Click
            // 
            btnProbarConexion_Click.AccessibleRole = AccessibleRole.Clock;
            btnProbarConexion_Click.Location = new Point(288, 4);
            btnProbarConexion_Click.Margin = new Padding(3, 4, 3, 4);
            btnProbarConexion_Click.Name = "btnProbarConexion_Click";
            btnProbarConexion_Click.Size = new Size(114, 40);
            btnProbarConexion_Click.TabIndex = 41;
            btnProbarConexion_Click.Text = "Administrar >";
            btnProbarConexion_Click.UseVisualStyleBackColor = true;
            btnProbarConexion_Click.Click += btnProbarConexion_Click_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightBlue;
            panel7.Controls.Add(label19);
            panel7.Controls.Add(button1);
            panel7.Controls.Add(button7);
            panel7.Location = new Point(9, 148);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(408, 49);
            panel7.TabIndex = 45;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Navy;
            label19.Location = new Point(56, 16);
            label19.Name = "label19";
            label19.Size = new Size(171, 23);
            label19.TabIndex = 44;
            label19.Text = "Asignacion De Roles";
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.Clock;
            button1.Location = new Point(287, 5);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 40);
            button1.TabIndex = 43;
            button1.Text = "Administrar >";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // button7
            // 
            button7.Location = new Point(271, 0);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(0, 0);
            button7.TabIndex = 42;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // Dgv_Tabla_Usu
            // 
            Dgv_Tabla_Usu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_Tabla_Usu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Tabla_Usu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Tabla_Usu.Location = new Point(40, 744);
            Dgv_Tabla_Usu.Name = "Dgv_Tabla_Usu";
            Dgv_Tabla_Usu.RowHeadersWidth = 51;
            Dgv_Tabla_Usu.Size = new Size(1192, 109);
            Dgv_Tabla_Usu.TabIndex = 46;
            Dgv_Tabla_Usu.CellContentClick += Dgv_Tabla_Usu_CellContentClick;
            Dgv_Tabla_Usu.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Indigo;
            panel1.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1277, 176);
            panel1.TabIndex = 50;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.patito1;
            pictureBox2.Location = new Point(1104, 8);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Usu_ico;
            pictureBox1.Location = new Point(56, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(178, 103);
            label15.Name = "label15";
            label15.Size = new Size(465, 28);
            label15.TabIndex = 9;
            label15.Text = "Gestiona la información del personal de la empresa.";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoEllipsis = true;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(178, 52);
            label10.Name = "label10";
            label10.Size = new Size(190, 52);
            label10.TabIndex = 6;
            label10.Text = "USUARIOS";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.UseCompatibleTextRendering = true;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 854);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(Dgv_Tabla_Usu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Usuarios_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_Usu).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private Panel panel4;
        private ComboBox cbo_Estado_Usuario;
        private Label label8;
        private TextBox txt_Contraseña;
        private Label label6;
        private TextBox txt_Correo;
        private TextBox txt_Nombre_Usuario;
        private Label label1;
        private DateTimePicker dtp_Fecha_Creacion;
        private PictureBox pictureBox4;
        private Label label13;
        private Label label2;
        private ComboBox cbo_Id_Empleados;
        private Label label14;
        private TextBox txt_Nombre_Empleado;
        private Label label5;
        private Label label3;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label label4;
        private Button Btn_Limpiar_Emp;
        private Button Btn_Nuevo_Emp;
        private Button Btn_Editar_Emp;
        private Button Btn_Eliminar_Emp;
        private Button Btn_Guardar_Emp;
        private Button Btn_Actualizar_Usu;
        private Panel panel3;
        private Panel panel10;
        private Label label11;
        private Button button10;
        private Panel panel8;
        private Label label9;
        private Button button8;
        private Label label17;
        private Label label16;
        private Panel panel6;
        private Label label18;
        private Button btnProbarConexion_Click;
        private Panel panel7;
        private Label label19;
        private Button button1;
        private Button button7;
        private DataGridView Dgv_Tabla_Usu;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label15;
        private Label label10;
        private PictureBox pictureBox2;
        private Button btn_cambiar_contra;
    }
}