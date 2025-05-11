namespace ZapaVentas
{
    partial class config
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
            this.lbl_database = new System.Windows.Forms.Label();
            this.btn_cambiar_nombre = new System.Windows.Forms.Button();
            this.tbx_database_name = new System.Windows.Forms.TextBox();
            this.lbl_alert = new System.Windows.Forms.Label();
            this.tbx_usr = new System.Windows.Forms.TextBox();
            this.btn_create_profile = new System.Windows.Forms.Button();
            this.lbl_newUsr = new System.Windows.Forms.Label();
            this.tbx_pwd = new System.Windows.Forms.TextBox();
            this.lbl_usr = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.cmb_rol = new System.Windows.Forms.ComboBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_database
            // 
            this.lbl_database.AutoSize = true;
            this.lbl_database.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_database.Location = new System.Drawing.Point(162, 54);
            this.lbl_database.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_database.Name = "lbl_database";
            this.lbl_database.Size = new System.Drawing.Size(79, 13);
            this.lbl_database.TabIndex = 0;
            this.lbl_database.Text = "Base de datos";
            // 
            // btn_cambiar_nombre
            // 
            this.btn_cambiar_nombre.FlatAppearance.BorderSize = 0;
            this.btn_cambiar_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cambiar_nombre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cambiar_nombre.Image = global::ZapaVentas.Properties.Resources.button11;
            this.btn_cambiar_nombre.Location = new System.Drawing.Point(392, 69);
            this.btn_cambiar_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cambiar_nombre.Name = "btn_cambiar_nombre";
            this.btn_cambiar_nombre.Size = new System.Drawing.Size(85, 19);
            this.btn_cambiar_nombre.TabIndex = 1;
            this.btn_cambiar_nombre.Text = "Cambiar base";
            this.btn_cambiar_nombre.UseVisualStyleBackColor = true;
            this.btn_cambiar_nombre.Visible = false;
            this.btn_cambiar_nombre.Click += new System.EventHandler(this.btn_cambiar_nombre_Click);
            // 
            // tbx_database_name
            // 
            this.tbx_database_name.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_database_name.Location = new System.Drawing.Point(165, 69);
            this.tbx_database_name.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_database_name.MaxLength = 50;
            this.tbx_database_name.Name = "tbx_database_name";
            this.tbx_database_name.Size = new System.Drawing.Size(156, 22);
            this.tbx_database_name.TabIndex = 2;
            this.tbx_database_name.TextChanged += new System.EventHandler(this.tbx_database_name_TextChanged);
            // 
            // lbl_alert
            // 
            this.lbl_alert.AutoSize = true;
            this.lbl_alert.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alert.ForeColor = System.Drawing.Color.Red;
            this.lbl_alert.Location = new System.Drawing.Point(89, 124);
            this.lbl_alert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_alert.Name = "lbl_alert";
            this.lbl_alert.Size = new System.Drawing.Size(432, 13);
            this.lbl_alert.TabIndex = 3;
            this.lbl_alert.Text = "ATENCION: Se ocupa taner la base de datos ya creada para poder ver los productos";
            this.lbl_alert.Visible = false;
            // 
            // tbx_usr
            // 
            this.tbx_usr.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_usr.Location = new System.Drawing.Point(203, 236);
            this.tbx_usr.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_usr.MaxLength = 50;
            this.tbx_usr.Name = "tbx_usr";
            this.tbx_usr.Size = new System.Drawing.Size(156, 22);
            this.tbx_usr.TabIndex = 7;
            // 
            // btn_create_profile
            // 
            this.btn_create_profile.FlatAppearance.BorderSize = 0;
            this.btn_create_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_profile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_profile.Image = global::ZapaVentas.Properties.Resources.button11;
            this.btn_create_profile.Location = new System.Drawing.Point(412, 261);
            this.btn_create_profile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_create_profile.Name = "btn_create_profile";
            this.btn_create_profile.Size = new System.Drawing.Size(85, 19);
            this.btn_create_profile.TabIndex = 6;
            this.btn_create_profile.Text = "Crear perfil";
            this.btn_create_profile.UseVisualStyleBackColor = true;
            this.btn_create_profile.Click += new System.EventHandler(this.btn_create_profile_Click);
            // 
            // lbl_newUsr
            // 
            this.lbl_newUsr.AutoSize = true;
            this.lbl_newUsr.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newUsr.Location = new System.Drawing.Point(81, 261);
            this.lbl_newUsr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_newUsr.Name = "lbl_newUsr";
            this.lbl_newUsr.Size = new System.Drawing.Size(111, 13);
            this.lbl_newUsr.TabIndex = 5;
            this.lbl_newUsr.Text = "Crear nuevo usuario";
            // 
            // tbx_pwd
            // 
            this.tbx_pwd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_pwd.Location = new System.Drawing.Point(203, 280);
            this.tbx_pwd.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_pwd.MaxLength = 50;
            this.tbx_pwd.Name = "tbx_pwd";
            this.tbx_pwd.Size = new System.Drawing.Size(156, 22);
            this.tbx_pwd.TabIndex = 8;
            // 
            // lbl_usr
            // 
            this.lbl_usr.AutoSize = true;
            this.lbl_usr.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usr.Location = new System.Drawing.Point(202, 223);
            this.lbl_usr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_usr.Name = "lbl_usr";
            this.lbl_usr.Size = new System.Drawing.Size(47, 13);
            this.lbl_usr.TabIndex = 9;
            this.lbl_usr.Text = "Usuario";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd.Location = new System.Drawing.Point(202, 267);
            this.lbl_pwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(66, 13);
            this.lbl_pwd.TabIndex = 10;
            this.lbl_pwd.Text = "Contraseña";
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.Location = new System.Drawing.Point(202, 307);
            this.lbl_role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(24, 13);
            this.lbl_role.TabIndex = 12;
            this.lbl_role.Text = "Rol";
            // 
            // cmb_rol
            // 
            this.cmb_rol.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_rol.FormattingEnabled = true;
            this.cmb_rol.Items.AddRange(new object[] {
            "Administrador",
            "Cajero",
            "Reabastecedor",
            "Limpieza",
            "General",
            "Pasantía"});
            this.cmb_rol.Location = new System.Drawing.Point(203, 319);
            this.cmb_rol.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_rol.Name = "cmb_rol";
            this.cmb_rol.Size = new System.Drawing.Size(92, 21);
            this.cmb_rol.TabIndex = 13;
            this.cmb_rol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(184, 37);
            this.lbl_title.TabIndex = 26;
            this.lbl_title.Text = "Configuración";
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(209)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.cmb_rol);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_usr);
            this.Controls.Add(this.tbx_pwd);
            this.Controls.Add(this.tbx_usr);
            this.Controls.Add(this.btn_create_profile);
            this.Controls.Add(this.lbl_newUsr);
            this.Controls.Add(this.lbl_alert);
            this.Controls.Add(this.tbx_database_name);
            this.Controls.Add(this.btn_cambiar_nombre);
            this.Controls.Add(this.lbl_database);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_database;
        private System.Windows.Forms.Button btn_cambiar_nombre;
        private System.Windows.Forms.TextBox tbx_database_name;
        private System.Windows.Forms.Label lbl_alert;
        private System.Windows.Forms.TextBox tbx_usr;
        private System.Windows.Forms.Button btn_create_profile;
        private System.Windows.Forms.Label lbl_newUsr;
        private System.Windows.Forms.TextBox tbx_pwd;
        private System.Windows.Forms.Label lbl_usr;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.ComboBox cmb_rol;
        private System.Windows.Forms.Label lbl_title;
    }
}