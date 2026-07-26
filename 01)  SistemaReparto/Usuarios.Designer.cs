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
            panel1 = new Panel();
            Lbl_Usu_Usu = new Label();
            panel2 = new Panel();
            Pic_Icono_Usu = new PictureBox();
            Txt_Nombre_Usu = new TextBox();
            Btn_Insert_Usu = new Button();
            Btn_Read_Usu = new Button();
            Txt_Correo_Usu = new TextBox();
            Dgv_Tabla_Usu = new DataGridView();
            ID_Usuario = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Txt_Contraseña_Usu = new TextBox();
            Dtp_Creacion_Usu = new DateTimePicker();
            Dtp_Acceso_Usu = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            Btn_Delete_Usu = new Button();
            Btn_Update_Usu = new Button();
            Cbo_Estado_Usu = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Icono_Usu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_Usu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Indigo;
            panel1.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(Lbl_Usu_Usu);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 176);
            panel1.TabIndex = 2;
            // 
            // Lbl_Usu_Usu
            // 
            Lbl_Usu_Usu.Anchor = AnchorStyles.Left;
            Lbl_Usu_Usu.AutoEllipsis = true;
            Lbl_Usu_Usu.AutoSize = true;
            Lbl_Usu_Usu.BackColor = Color.Transparent;
            Lbl_Usu_Usu.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Usu_Usu.ForeColor = Color.White;
            Lbl_Usu_Usu.Location = new Point(13, 72);
            Lbl_Usu_Usu.Name = "Lbl_Usu_Usu";
            Lbl_Usu_Usu.Size = new Size(190, 52);
            Lbl_Usu_Usu.TabIndex = 6;
            Lbl_Usu_Usu.Text = "USUARIOS";
            Lbl_Usu_Usu.TextAlign = ContentAlignment.MiddleCenter;
            Lbl_Usu_Usu.UseCompatibleTextRendering = true;
            Lbl_Usu_Usu.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(Pic_Icono_Usu);
            panel2.Location = new Point(659, 39);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.MaximumSize = new Size(1500, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(327, 134);
            panel2.TabIndex = 3;
            // 
            // Pic_Icono_Usu
            // 
            Pic_Icono_Usu.Image = Properties.Resources.patito1;
            Pic_Icono_Usu.Location = new Point(208, 10);
            Pic_Icono_Usu.Margin = new Padding(3, 4, 3, 4);
            Pic_Icono_Usu.Name = "Pic_Icono_Usu";
            Pic_Icono_Usu.Size = new Size(116, 120);
            Pic_Icono_Usu.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_Icono_Usu.TabIndex = 6;
            Pic_Icono_Usu.TabStop = false;
            // 
            // Txt_Nombre_Usu
            // 
            Txt_Nombre_Usu.Location = new Point(47, 236);
            Txt_Nombre_Usu.Name = "Txt_Nombre_Usu";
            Txt_Nombre_Usu.PlaceholderText = "👤 Usuario";
            Txt_Nombre_Usu.Size = new Size(173, 27);
            Txt_Nombre_Usu.TabIndex = 8;
            // 
            // Btn_Insert_Usu
            // 
            Btn_Insert_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Insert_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Insert_Usu.Location = new Point(401, 408);
            Btn_Insert_Usu.Name = "Btn_Insert_Usu";
            Btn_Insert_Usu.Size = new Size(152, 39);
            Btn_Insert_Usu.TabIndex = 13;
            Btn_Insert_Usu.Text = "➕ Añadir Usuario";
            Btn_Insert_Usu.UseVisualStyleBackColor = true;
            // 
            // Btn_Read_Usu
            // 
            Btn_Read_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Read_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Read_Usu.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Read_Usu.Location = new Point(592, 410);
            Btn_Read_Usu.Name = "Btn_Read_Usu";
            Btn_Read_Usu.Size = new Size(152, 37);
            Btn_Read_Usu.TabIndex = 14;
            Btn_Read_Usu.Text = "🔄️ Actualizar Datos";
            Btn_Read_Usu.UseVisualStyleBackColor = true;
            // 
            // Txt_Correo_Usu
            // 
            Txt_Correo_Usu.Location = new Point(295, 235);
            Txt_Correo_Usu.Multiline = true;
            Txt_Correo_Usu.Name = "Txt_Correo_Usu";
            Txt_Correo_Usu.PlaceholderText = "📧 Correo";
            Txt_Correo_Usu.Size = new Size(190, 28);
            Txt_Correo_Usu.TabIndex = 8;
            // 
            // Dgv_Tabla_Usu
            // 
            Dgv_Tabla_Usu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_Tabla_Usu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Tabla_Usu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Tabla_Usu.Columns.AddRange(new DataGridViewColumn[] { ID_Usuario, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            Dgv_Tabla_Usu.Location = new Point(27, 493);
            Dgv_Tabla_Usu.Name = "Dgv_Tabla_Usu";
            Dgv_Tabla_Usu.RowHeadersWidth = 51;
            Dgv_Tabla_Usu.Size = new Size(1013, 182);
            Dgv_Tabla_Usu.TabIndex = 17;
            // 
            // ID_Usuario
            // 
            ID_Usuario.HeaderText = "ID_Usuario";
            ID_Usuario.MinimumWidth = 6;
            ID_Usuario.Name = "ID_Usuario";
            // 
            // Column1
            // 
            Column1.HeaderText = "ID_Empleado";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Usuario";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Correo";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Contraseña";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Ultimo_Acceso";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Ultimo_Acceso";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Fecha_Creacion";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Estado";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // Txt_Contraseña_Usu
            // 
            Txt_Contraseña_Usu.Location = new Point(558, 234);
            Txt_Contraseña_Usu.Name = "Txt_Contraseña_Usu";
            Txt_Contraseña_Usu.PlaceholderText = "🔐 Contraseña";
            Txt_Contraseña_Usu.Size = new Size(175, 27);
            Txt_Contraseña_Usu.TabIndex = 19;
            // 
            // Dtp_Creacion_Usu
            // 
            Dtp_Creacion_Usu.Location = new Point(410, 335);
            Dtp_Creacion_Usu.Name = "Dtp_Creacion_Usu";
            Dtp_Creacion_Usu.Size = new Size(295, 27);
            Dtp_Creacion_Usu.TabIndex = 20;
            // 
            // Dtp_Acceso_Usu
            // 
            Dtp_Acceso_Usu.Location = new Point(53, 335);
            Dtp_Acceso_Usu.Name = "Dtp_Acceso_Usu";
            Dtp_Acceso_Usu.Size = new Size(296, 27);
            Dtp_Acceso_Usu.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(413, 312);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 22;
            label1.Text = "Fecha Creacion:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 312);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 23;
            label2.Text = "Fecha Ultimo Acceso:";
            // 
            // Btn_Delete_Usu
            // 
            Btn_Delete_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Delete_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Delete_Usu.Location = new Point(229, 408);
            Btn_Delete_Usu.Name = "Btn_Delete_Usu";
            Btn_Delete_Usu.Size = new Size(139, 39);
            Btn_Delete_Usu.TabIndex = 24;
            Btn_Delete_Usu.Text = "❌ Borrar Usuario";
            Btn_Delete_Usu.UseVisualStyleBackColor = true;
            // 
            // Btn_Update_Usu
            // 
            Btn_Update_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Update_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Update_Usu.Location = new Point(777, 410);
            Btn_Update_Usu.Name = "Btn_Update_Usu";
            Btn_Update_Usu.Size = new Size(159, 37);
            Btn_Update_Usu.TabIndex = 25;
            Btn_Update_Usu.Text = "✏️ Editar Usuario";
            Btn_Update_Usu.UseVisualStyleBackColor = true;
            // 
            // Cbo_Estado_Usu
            // 
            Cbo_Estado_Usu.FormattingEnabled = true;
            Cbo_Estado_Usu.Items.AddRange(new object[] { "Activo", "Suspendido", "Deshabilitado" });
            Cbo_Estado_Usu.Location = new Point(795, 235);
            Cbo_Estado_Usu.Name = "Cbo_Estado_Usu";
            Cbo_Estado_Usu.Size = new Size(178, 28);
            Cbo_Estado_Usu.TabIndex = 26;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 854);
            Controls.Add(Cbo_Estado_Usu);
            Controls.Add(Btn_Update_Usu);
            Controls.Add(Btn_Delete_Usu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Dtp_Acceso_Usu);
            Controls.Add(Dtp_Creacion_Usu);
            Controls.Add(Txt_Contraseña_Usu);
            Controls.Add(Dgv_Tabla_Usu);
            Controls.Add(Txt_Correo_Usu);
            Controls.Add(Btn_Read_Usu);
            Controls.Add(Btn_Insert_Usu);
            Controls.Add(Txt_Nombre_Usu);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pic_Icono_Usu).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_Usu).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pic_Icono_Usu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_Usu_Usu;
        private TextBox Txt_Nombre_Usu;
        private Button Btn_Insert_Usu;
        private Button Btn_Read_Usu;
        private TextBox Txt_Correo_Usu;
        private DataGridView Dgv_Tabla_Usu;
        private TextBox Txt_Contraseña_Usu;
        private DateTimePicker Dtp_Creacion_Usu;
        private DateTimePicker Dtp_Acceso_Usu;
        private Label label1;
        private Label label2;
        private Button Btn_Delete_Usu;
        private Button Btn_Update_Usu;
        private DataGridViewTextBoxColumn ID_Usuario;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private ComboBox Cbo_Estado_Usu;
    }
}