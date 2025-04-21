namespace ZapaVentas
{
    partial class main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.btn_conteo = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_compra_actual = new System.Windows.Forms.DataGridView();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_cobrar = new System.Windows.Forms.Button();
            this.lbl_atiende = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compra_actual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ventas
            // 
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ventas.Location = new System.Drawing.Point(358, 19);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(181, 82);
            this.btn_ventas.TabIndex = 1;
            this.btn_ventas.Text = "Acerca";
            this.btn_ventas.UseVisualStyleBackColor = true;
            // 
            // btn_productos
            // 
            this.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_productos.Location = new System.Drawing.Point(545, 19);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(181, 82);
            this.btn_productos.TabIndex = 2;
            this.btn_productos.Text = "Productos";
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // btn_conteo
            // 
            this.btn_conteo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_conteo.Location = new System.Drawing.Point(732, 19);
            this.btn_conteo.Name = "btn_conteo";
            this.btn_conteo.Size = new System.Drawing.Size(181, 82);
            this.btn_conteo.TabIndex = 3;
            this.btn_conteo.Text = "Conteo";
            this.btn_conteo.UseVisualStyleBackColor = true;
            this.btn_conteo.Click += new System.EventHandler(this.btn_conteo_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_exit.Location = new System.Drawing.Point(1003, 19);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(149, 82);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Cerrar sesión";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_config
            // 
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_config.Location = new System.Drawing.Point(919, 19);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(78, 82);
            this.btn_config.TabIndex = 5;
            this.btn_config.Text = "Config";
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(28, 139);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(205, 54);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Agregar producto";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_compra_actual
            // 
            this.dgv_compra_actual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_compra_actual.Location = new System.Drawing.Point(28, 199);
            this.dgv_compra_actual.Name = "dgv_compra_actual";
            this.dgv_compra_actual.RowHeadersWidth = 51;
            this.dgv_compra_actual.RowTemplate.Height = 24;
            this.dgv_compra_actual.Size = new System.Drawing.Size(1123, 435);
            this.dgv_compra_actual.TabIndex = 6;
            // 
            // tick
            // 
            this.tick.Enabled = true;
            this.tick.Interval = 1000;
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_total.Location = new System.Drawing.Point(912, 686);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(102, 39);
            this.lbl_total.TabIndex = 8;
            this.lbl_total.Text = "Total:";
            // 
            // btn_cobrar
            // 
            this.btn_cobrar.Location = new System.Drawing.Point(739, 680);
            this.btn_cobrar.Name = "btn_cobrar";
            this.btn_cobrar.Size = new System.Drawing.Size(157, 53);
            this.btn_cobrar.TabIndex = 9;
            this.btn_cobrar.Text = "Cobrar (F12):";
            this.btn_cobrar.UseVisualStyleBackColor = true;
            this.btn_cobrar.Click += new System.EventHandler(this.btn_cobrar_Click);
            // 
            // lbl_atiende
            // 
            this.lbl_atiende.AutoSize = true;
            this.lbl_atiende.Location = new System.Drawing.Point(921, 163);
            this.lbl_atiende.Name = "lbl_atiende";
            this.lbl_atiende.Size = new System.Drawing.Size(76, 16);
            this.lbl_atiende.TabIndex = 10;
            this.lbl_atiende.Text = "Lo atiende: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ZapaVentas.Properties.Resources.MainBG;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1180, 750);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.lbl_atiende);
            this.Controls.Add(this.btn_cobrar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_compra_actual);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_conteo);
            this.Controls.Add(this.btn_productos);
            this.Controls.Add(this.btn_ventas);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compra_actual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Button btn_conteo;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_compra_actual;
        private System.Windows.Forms.Timer tick;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_cobrar;
        private System.Windows.Forms.Label lbl_atiende;
    }
}

