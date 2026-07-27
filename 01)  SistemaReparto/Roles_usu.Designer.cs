namespace SistemaReparto
{
    partial class Roles_usu
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
            Btn_Update_Usu = new Button();
            Btn_Delete_Usu = new Button();
            Dgv_Tabla_Rol = new DataGridView();
            Btn_Read_Usu = new Button();
            Btn_Insert_Usu = new Button();
            Txt_Nombre_Rol = new TextBox();
            txtDescripcion = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_Rol).BeginInit();
            SuspendLayout();
            // 
            // Btn_Update_Usu
            // 
            Btn_Update_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Update_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Update_Usu.Location = new Point(661, 272);
            Btn_Update_Usu.Name = "Btn_Update_Usu";
            Btn_Update_Usu.Size = new Size(159, 37);
            Btn_Update_Usu.TabIndex = 51;
            Btn_Update_Usu.Text = "✏️ Editar Rol";
            Btn_Update_Usu.UseVisualStyleBackColor = true;
            Btn_Update_Usu.Click += Btn_Update_Usu_Click;
            // 
            // Btn_Delete_Usu
            // 
            Btn_Delete_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Delete_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Delete_Usu.Location = new Point(113, 270);
            Btn_Delete_Usu.Name = "Btn_Delete_Usu";
            Btn_Delete_Usu.Size = new Size(139, 39);
            Btn_Delete_Usu.TabIndex = 50;
            Btn_Delete_Usu.Text = "❌ Borrar Rol";
            Btn_Delete_Usu.UseVisualStyleBackColor = true;
            Btn_Delete_Usu.Click += Btn_Delete_Usu_Click;
            // 
            // Dgv_Tabla_Rol
            // 
            Dgv_Tabla_Rol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_Tabla_Rol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Tabla_Rol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Tabla_Rol.Location = new Point(112, 368);
            Dgv_Tabla_Rol.Name = "Dgv_Tabla_Rol";
            Dgv_Tabla_Rol.RowHeadersWidth = 51;
            Dgv_Tabla_Rol.Size = new Size(761, 79);
            Dgv_Tabla_Rol.TabIndex = 44;
            Dgv_Tabla_Rol.SelectionChanged += dgvRoles_SelectionChanged;
            // 
            // Btn_Read_Usu
            // 
            Btn_Read_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Read_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Read_Usu.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Read_Usu.Location = new Point(476, 272);
            Btn_Read_Usu.Name = "Btn_Read_Usu";
            Btn_Read_Usu.Size = new Size(152, 37);
            Btn_Read_Usu.TabIndex = 43;
            Btn_Read_Usu.Text = "🔄️ Actualizar Datos";
            Btn_Read_Usu.UseVisualStyleBackColor = true;
            // 
            // Btn_Insert_Usu
            // 
            Btn_Insert_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Insert_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Insert_Usu.Location = new Point(285, 270);
            Btn_Insert_Usu.Name = "Btn_Insert_Usu";
            Btn_Insert_Usu.Size = new Size(152, 39);
            Btn_Insert_Usu.TabIndex = 42;
            Btn_Insert_Usu.Text = "➕ Añadir Rol";
            Btn_Insert_Usu.UseVisualStyleBackColor = true;
            Btn_Insert_Usu.Click += Btn_Insert_Usu_Click;
            // 
            // Txt_Nombre_Rol
            // 
            Txt_Nombre_Rol.Location = new Point(112, 32);
            Txt_Nombre_Rol.Name = "Txt_Nombre_Rol";
            Txt_Nombre_Rol.PlaceholderText = "👤Nombre Rol";
            Txt_Nombre_Rol.Size = new Size(173, 27);
            Txt_Nombre_Rol.TabIndex = 41;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(112, 104);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(720, 136);
            txtDescripcion.TabIndex = 53;
            txtDescripcion.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 88);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 54;
            label1.Text = "Descripcion";
            // 
            // Roles_usu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 529);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            Controls.Add(Btn_Update_Usu);
            Controls.Add(Btn_Delete_Usu);
            Controls.Add(Dgv_Tabla_Rol);
            Controls.Add(Btn_Read_Usu);
            Controls.Add(Btn_Insert_Usu);
            Controls.Add(Txt_Nombre_Rol);
            Name = "Roles_usu";
            Text = "Roles_usu";
            Load += Roles_usu_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_Rol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Btn_Update_Usu;
        private Button Btn_Delete_Usu;
        private DataGridView Dgv_Tabla_Rol;
        private Button Btn_Read_Usu;
        private Button Btn_Insert_Usu;
        private TextBox Txt_Nombre_Rol;
        private RichTextBox txtDescripcion;
        private Label label1;
    }
}