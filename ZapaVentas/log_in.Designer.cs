namespace ZapaVentas
{
    partial class log_in
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
            this.tbx_usr = new System.Windows.Forms.TextBox();
            this.tbx_pwd = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_zn = new System.Windows.Forms.Button();
            this.btn_fr = new System.Windows.Forms.Button();
            this.btn_de = new System.Windows.Forms.Button();
            this.btn_en = new System.Windows.Forms.Button();
            this.btn_es = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_usr
            // 
            this.tbx_usr.Location = new System.Drawing.Point(346, 138);
            this.tbx_usr.Name = "tbx_usr";
            this.tbx_usr.Size = new System.Drawing.Size(100, 22);
            this.tbx_usr.TabIndex = 0;
            this.tbx_usr.Text = "Usuario";
            // 
            // tbx_pwd
            // 
            this.tbx_pwd.Location = new System.Drawing.Point(346, 166);
            this.tbx_pwd.Name = "tbx_pwd";
            this.tbx_pwd.PasswordChar = '*';
            this.tbx_pwd.Size = new System.Drawing.Size(100, 22);
            this.tbx_pwd.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(346, 241);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 38);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Iniciar Sesión";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_zn
            // 
            this.btn_zn.Location = new System.Drawing.Point(695, 415);
            this.btn_zn.Name = "btn_zn";
            this.btn_zn.Size = new System.Drawing.Size(93, 23);
            this.btn_zn.TabIndex = 24;
            this.btn_zn.Text = "中文";
            this.btn_zn.UseVisualStyleBackColor = true;
            this.btn_zn.Click += new System.EventHandler(this.btn_zn_Click);
            // 
            // btn_fr
            // 
            this.btn_fr.Location = new System.Drawing.Point(695, 357);
            this.btn_fr.Name = "btn_fr";
            this.btn_fr.Size = new System.Drawing.Size(93, 23);
            this.btn_fr.TabIndex = 23;
            this.btn_fr.Text = "Français";
            this.btn_fr.UseVisualStyleBackColor = true;
            this.btn_fr.Click += new System.EventHandler(this.btn_fr_Click);
            // 
            // btn_de
            // 
            this.btn_de.Location = new System.Drawing.Point(695, 386);
            this.btn_de.Name = "btn_de";
            this.btn_de.Size = new System.Drawing.Size(93, 23);
            this.btn_de.TabIndex = 22;
            this.btn_de.Text = "Deutsch";
            this.btn_de.UseVisualStyleBackColor = true;
            this.btn_de.Click += new System.EventHandler(this.btn_de_Click);
            // 
            // btn_en
            // 
            this.btn_en.Location = new System.Drawing.Point(695, 328);
            this.btn_en.Name = "btn_en";
            this.btn_en.Size = new System.Drawing.Size(93, 23);
            this.btn_en.TabIndex = 21;
            this.btn_en.Text = "English";
            this.btn_en.UseVisualStyleBackColor = true;
            this.btn_en.Click += new System.EventHandler(this.btn_en_Click);
            // 
            // btn_es
            // 
            this.btn_es.Location = new System.Drawing.Point(695, 299);
            this.btn_es.Name = "btn_es";
            this.btn_es.Size = new System.Drawing.Size(93, 23);
            this.btn_es.TabIndex = 20;
            this.btn_es.Text = "Español";
            this.btn_es.UseVisualStyleBackColor = true;
            this.btn_es.Click += new System.EventHandler(this.btn_es_Click);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_zn);
            this.Controls.Add(this.btn_fr);
            this.Controls.Add(this.btn_de);
            this.Controls.Add(this.btn_en);
            this.Controls.Add(this.btn_es);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbx_pwd);
            this.Controls.Add(this.tbx_usr);
            this.Name = "log_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "log_in";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.log_in_FormClosed);
            this.Load += new System.EventHandler(this.log_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_usr;
        private System.Windows.Forms.TextBox tbx_pwd;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_zn;
        private System.Windows.Forms.Button btn_fr;
        private System.Windows.Forms.Button btn_de;
        private System.Windows.Forms.Button btn_en;
        private System.Windows.Forms.Button btn_es;
    }
}