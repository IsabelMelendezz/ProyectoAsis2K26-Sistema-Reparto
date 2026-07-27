namespace SistemaReparto
{
    partial class Registro_usu
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
            Cbo_Estado_Usu = new ComboBox();
            Btn_Update_Usu = new Button();
            Btn_Delete_Usu = new Button();
            label2 = new Label();
            label1 = new Label();
            Dtp_Acceso_Usu = new DateTimePicker();
            Dtp_Creacion_Usu = new DateTimePicker();
            Txt_Contraseña_Usu = new TextBox();
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
            Txt_Correo_Usu = new TextBox();
            Btn_Read_Usu = new Button();
            Btn_Insert_Usu = new Button();
            Txt_Nombre_Usu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_Usu).BeginInit();
            SuspendLayout();
            // 
            // Cbo_Estado_Usu
            // 
            Cbo_Estado_Usu.FormattingEnabled = true;
            Cbo_Estado_Usu.Items.AddRange(new object[] { "Activo", "Suspendido", "Deshabilitado" });
            Cbo_Estado_Usu.Location = new Point(786, 136);
            Cbo_Estado_Usu.Name = "Cbo_Estado_Usu";
            Cbo_Estado_Usu.Size = new Size(178, 28);
            Cbo_Estado_Usu.TabIndex = 39;
            // 
            // Btn_Update_Usu
            // 
            Btn_Update_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Update_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Update_Usu.Location = new Point(768, 311);
            Btn_Update_Usu.Name = "Btn_Update_Usu";
            Btn_Update_Usu.Size = new Size(159, 37);
            Btn_Update_Usu.TabIndex = 38;
            Btn_Update_Usu.Text = "✏️ Editar Usuario";
            Btn_Update_Usu.UseVisualStyleBackColor = true;
            // 
            // Btn_Delete_Usu
            // 
            Btn_Delete_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Delete_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Delete_Usu.Location = new Point(220, 309);
            Btn_Delete_Usu.Name = "Btn_Delete_Usu";
            Btn_Delete_Usu.Size = new Size(139, 39);
            Btn_Delete_Usu.TabIndex = 37;
            Btn_Delete_Usu.Text = "❌ Borrar Usuario";
            Btn_Delete_Usu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 213);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 36;
            label2.Text = "Fecha Ultimo Acceso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(404, 213);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 35;
            label1.Text = "Fecha Creacion:";
            // 
            // Dtp_Acceso_Usu
            // 
            Dtp_Acceso_Usu.Location = new Point(44, 236);
            Dtp_Acceso_Usu.Name = "Dtp_Acceso_Usu";
            Dtp_Acceso_Usu.Size = new Size(296, 27);
            Dtp_Acceso_Usu.TabIndex = 34;
            // 
            // Dtp_Creacion_Usu
            // 
            Dtp_Creacion_Usu.Location = new Point(401, 236);
            Dtp_Creacion_Usu.Name = "Dtp_Creacion_Usu";
            Dtp_Creacion_Usu.Size = new Size(295, 27);
            Dtp_Creacion_Usu.TabIndex = 33;
            // 
            // Txt_Contraseña_Usu
            // 
            Txt_Contraseña_Usu.Location = new Point(549, 135);
            Txt_Contraseña_Usu.Name = "Txt_Contraseña_Usu";
            Txt_Contraseña_Usu.PlaceholderText = "🔐 Contraseña";
            Txt_Contraseña_Usu.Size = new Size(175, 27);
            Txt_Contraseña_Usu.TabIndex = 32;
            // 
            // Dgv_Tabla_Usu
            // 
            Dgv_Tabla_Usu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_Tabla_Usu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Tabla_Usu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Tabla_Usu.Columns.AddRange(new DataGridViewColumn[] { ID_Usuario, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            Dgv_Tabla_Usu.Location = new Point(18, 394);
            Dgv_Tabla_Usu.Name = "Dgv_Tabla_Usu";
            Dgv_Tabla_Usu.RowHeadersWidth = 51;
            Dgv_Tabla_Usu.Size = new Size(978, 0);
            Dgv_Tabla_Usu.TabIndex = 31;
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
            // Txt_Correo_Usu
            // 
            Txt_Correo_Usu.Location = new Point(286, 136);
            Txt_Correo_Usu.Multiline = true;
            Txt_Correo_Usu.Name = "Txt_Correo_Usu";
            Txt_Correo_Usu.PlaceholderText = "📧 Correo";
            Txt_Correo_Usu.Size = new Size(190, 28);
            Txt_Correo_Usu.TabIndex = 27;
            // 
            // Btn_Read_Usu
            // 
            Btn_Read_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Read_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Read_Usu.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Read_Usu.Location = new Point(583, 311);
            Btn_Read_Usu.Name = "Btn_Read_Usu";
            Btn_Read_Usu.Size = new Size(152, 37);
            Btn_Read_Usu.TabIndex = 30;
            Btn_Read_Usu.Text = "🔄️ Actualizar Datos";
            Btn_Read_Usu.UseVisualStyleBackColor = true;
            // 
            // Btn_Insert_Usu
            // 
            Btn_Insert_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Insert_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Insert_Usu.Location = new Point(392, 309);
            Btn_Insert_Usu.Name = "Btn_Insert_Usu";
            Btn_Insert_Usu.Size = new Size(152, 39);
            Btn_Insert_Usu.TabIndex = 29;
            Btn_Insert_Usu.Text = "➕ Añadir Usuario";
            Btn_Insert_Usu.UseVisualStyleBackColor = true;
            // 
            // Txt_Nombre_Usu
            // 
            Txt_Nombre_Usu.Location = new Point(38, 137);
            Txt_Nombre_Usu.Name = "Txt_Nombre_Usu";
            Txt_Nombre_Usu.PlaceholderText = "👤 Usuario";
            Txt_Nombre_Usu.Size = new Size(173, 27);
            Txt_Nombre_Usu.TabIndex = 28;
            // 
            // Registro_usu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 529);
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
            Name = "Registro_usu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_Usu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Cbo_Estado_Usu;
        private Button Btn_Update_Usu;
        private Button Btn_Delete_Usu;
        private Label label2;
        private Label label1;
        private DateTimePicker Dtp_Acceso_Usu;
        private DateTimePicker Dtp_Creacion_Usu;
        private TextBox Txt_Contraseña_Usu;
        private DataGridView Dgv_Tabla_Usu;
        private DataGridViewTextBoxColumn ID_Usuario;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private TextBox Txt_Correo_Usu;
        private Button Btn_Read_Usu;
        private Button Btn_Insert_Usu;
        private TextBox Txt_Nombre_Usu;
    }
}