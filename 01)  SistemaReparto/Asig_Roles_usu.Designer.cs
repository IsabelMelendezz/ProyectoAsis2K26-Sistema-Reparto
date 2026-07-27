namespace SistemaReparto
{
    partial class Asig_Roles_usu
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
            label1 = new Label();
            label2 = new Label();
            Btn_Update_Usu = new Button();
            Btn_Delete_Usu = new Button();
            Dgv_Tabla_Usu = new DataGridView();
            Btn_Read_Usu = new Button();
            Btn_Insert_Usu = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_Usu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 55;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 120);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 56;
            label2.Text = "Roles";
            label2.Click += label2_Click;
            // 
            // Btn_Update_Usu
            // 
            Btn_Update_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Update_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Update_Usu.Location = new Point(569, 232);
            Btn_Update_Usu.Name = "Btn_Update_Usu";
            Btn_Update_Usu.Size = new Size(159, 37);
            Btn_Update_Usu.TabIndex = 61;
            Btn_Update_Usu.Text = "✏️ Editar Rol";
            Btn_Update_Usu.UseVisualStyleBackColor = true;
            // 
            // Btn_Delete_Usu
            // 
            Btn_Delete_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Delete_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Delete_Usu.Location = new Point(21, 230);
            Btn_Delete_Usu.Name = "Btn_Delete_Usu";
            Btn_Delete_Usu.Size = new Size(139, 39);
            Btn_Delete_Usu.TabIndex = 60;
            Btn_Delete_Usu.Text = "❌ Borrar Rol";
            Btn_Delete_Usu.UseVisualStyleBackColor = true;
            // 
            // Dgv_Tabla_Usu
            // 
            Dgv_Tabla_Usu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_Tabla_Usu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Tabla_Usu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Tabla_Usu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4 });
            Dgv_Tabla_Usu.Location = new Point(20, 328);
            Dgv_Tabla_Usu.Name = "Dgv_Tabla_Usu";
            Dgv_Tabla_Usu.RowHeadersWidth = 51;
            Dgv_Tabla_Usu.Size = new Size(975, 158);
            Dgv_Tabla_Usu.TabIndex = 59;
            // 
            // Btn_Read_Usu
            // 
            Btn_Read_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Read_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Read_Usu.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Read_Usu.Location = new Point(384, 232);
            Btn_Read_Usu.Name = "Btn_Read_Usu";
            Btn_Read_Usu.Size = new Size(152, 37);
            Btn_Read_Usu.TabIndex = 58;
            Btn_Read_Usu.Text = "🔄️ Actualizar Datos";
            Btn_Read_Usu.UseVisualStyleBackColor = true;
            // 
            // Btn_Insert_Usu
            // 
            Btn_Insert_Usu.BackgroundImage = Properties.Resources.barra_menu_horizontal;
            Btn_Insert_Usu.ForeColor = SystemColors.ControlLightLight;
            Btn_Insert_Usu.Location = new Point(193, 230);
            Btn_Insert_Usu.Name = "Btn_Insert_Usu";
            Btn_Insert_Usu.Size = new Size(152, 39);
            Btn_Insert_Usu.TabIndex = 57;
            Btn_Insert_Usu.Text = "➕ Añadir Rol";
            Btn_Insert_Usu.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID_Usu";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "ID_Rol";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.HeaderText = "Fecha_Asig";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(312, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 28);
            comboBox1.TabIndex = 62;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(312, 152);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 28);
            comboBox2.TabIndex = 63;
            // 
            // Asig_Roles_usu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 529);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(Btn_Update_Usu);
            Controls.Add(Btn_Delete_Usu);
            Controls.Add(Dgv_Tabla_Usu);
            Controls.Add(Btn_Read_Usu);
            Controls.Add(Btn_Insert_Usu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Asig_Roles_usu";
            Text = "Asig_Roles_usu";
            ((System.ComponentModel.ISupportInitialize)Dgv_Tabla_Usu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button Btn_Update_Usu;
        private Button Btn_Delete_Usu;
        private DataGridView Dgv_Tabla_Usu;
        private Button Btn_Read_Usu;
        private Button Btn_Insert_Usu;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}