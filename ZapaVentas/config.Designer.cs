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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cambiar_nombre = new System.Windows.Forms.Button();
            this.tbx_database_name = new System.Windows.Forms.TextBox();
            this.lbl_alert = new System.Windows.Forms.Label();
            this.lbl_alert2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base de datos";
            // 
            // btn_cambiar_nombre
            // 
            this.btn_cambiar_nombre.Location = new System.Drawing.Point(523, 85);
            this.btn_cambiar_nombre.Name = "btn_cambiar_nombre";
            this.btn_cambiar_nombre.Size = new System.Drawing.Size(113, 23);
            this.btn_cambiar_nombre.TabIndex = 1;
            this.btn_cambiar_nombre.Text = "Cambiar base";
            this.btn_cambiar_nombre.UseVisualStyleBackColor = true;
            this.btn_cambiar_nombre.Visible = false;
            this.btn_cambiar_nombre.Click += new System.EventHandler(this.btn_cambiar_nombre_Click);
            // 
            // tbx_database_name
            // 
            this.tbx_database_name.Location = new System.Drawing.Point(220, 85);
            this.tbx_database_name.MaxLength = 50;
            this.tbx_database_name.Name = "tbx_database_name";
            this.tbx_database_name.Size = new System.Drawing.Size(206, 22);
            this.tbx_database_name.TabIndex = 2;
            this.tbx_database_name.TextChanged += new System.EventHandler(this.tbx_database_name_TextChanged);
            // 
            // lbl_alert
            // 
            this.lbl_alert.AutoSize = true;
            this.lbl_alert.ForeColor = System.Drawing.Color.Red;
            this.lbl_alert.Location = new System.Drawing.Point(119, 129);
            this.lbl_alert.Name = "lbl_alert";
            this.lbl_alert.Size = new System.Drawing.Size(517, 16);
            this.lbl_alert.TabIndex = 3;
            this.lbl_alert.Text = "ATENCION: Se ocupa taner la base de datos ya creada para poder ver los productos";
            this.lbl_alert.Visible = false;
            // 
            // lbl_alert2
            // 
            this.lbl_alert2.AutoSize = true;
            this.lbl_alert2.ForeColor = System.Drawing.Color.Red;
            this.lbl_alert2.Location = new System.Drawing.Point(280, 145);
            this.lbl_alert2.Name = "lbl_alert2";
            this.lbl_alert2.Size = new System.Drawing.Size(198, 16);
            this.lbl_alert2.TabIndex = 4;
            this.lbl_alert2.Text = "desde MongoDB sin problemas";
            this.lbl_alert2.Visible = false;
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_alert2);
            this.Controls.Add(this.lbl_alert);
            this.Controls.Add(this.tbx_database_name);
            this.Controls.Add(this.btn_cambiar_nombre);
            this.Controls.Add(this.label1);
            this.Name = "config";
            this.Text = "config";
            this.Load += new System.EventHandler(this.config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cambiar_nombre;
        private System.Windows.Forms.TextBox tbx_database_name;
        private System.Windows.Forms.Label lbl_alert;
        private System.Windows.Forms.Label lbl_alert2;
    }
}