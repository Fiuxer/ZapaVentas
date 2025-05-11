namespace ZapaVentas
{
    partial class product_editor
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
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.lbl_prodName = new System.Windows.Forms.Label();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.lbl_no_encontrado = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_inv = new System.Windows.Forms.Label();
            this.cbx_granel = new System.Windows.Forms.CheckBox();
            this.tbx_precio = new System.Windows.Forms.TextBox();
            this.tbx_inv = new System.Windows.Forms.TextBox();
            this.btn_commit = new System.Windows.Forms.Button();
            this.lbl_prodId = new System.Windows.Forms.Label();
            this.tbx_id_prod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(9, 40);
            this.tbx_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(246, 26);
            this.tbx_nombre.TabIndex = 0;
            this.tbx_nombre.TextChanged += new System.EventHandler(this.tbx_nombre_TextChanged);
            // 
            // lbl_prodName
            // 
            this.lbl_prodName.AutoSize = true;
            this.lbl_prodName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prodName.Location = new System.Drawing.Point(11, 23);
            this.lbl_prodName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_prodName.Name = "lbl_prodName";
            this.lbl_prodName.Size = new System.Drawing.Size(141, 19);
            this.lbl_prodName.TabIndex = 1;
            this.lbl_prodName.Text = "Nombre del producto";
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(8, 67);
            this.dgv_productos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 24;
            this.dgv_productos.Size = new System.Drawing.Size(571, 388);
            this.dgv_productos.TabIndex = 2;
            this.dgv_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellContentClick);
            // 
            // lbl_no_encontrado
            // 
            this.lbl_no_encontrado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_no_encontrado.AutoSize = true;
            this.lbl_no_encontrado.Location = new System.Drawing.Point(253, 254);
            this.lbl_no_encontrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_no_encontrado.Name = "lbl_no_encontrado";
            this.lbl_no_encontrado.Size = new System.Drawing.Size(45, 19);
            this.lbl_no_encontrado.TabIndex = 3;
            this.lbl_no_encontrado.Text = "label2";
            this.lbl_no_encontrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_no_encontrado.Visible = false;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(583, 104);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(49, 19);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Precio:";
            // 
            // lbl_inv
            // 
            this.lbl_inv.AutoSize = true;
            this.lbl_inv.Location = new System.Drawing.Point(583, 174);
            this.lbl_inv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_inv.Name = "lbl_inv";
            this.lbl_inv.Size = new System.Drawing.Size(74, 19);
            this.lbl_inv.TabIndex = 5;
            this.lbl_inv.Text = "Inventario:";
            // 
            // cbx_granel
            // 
            this.cbx_granel.AutoSize = true;
            this.cbx_granel.Location = new System.Drawing.Point(640, 316);
            this.cbx_granel.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_granel.Name = "cbx_granel";
            this.cbx_granel.Size = new System.Drawing.Size(71, 23);
            this.cbx_granel.TabIndex = 6;
            this.cbx_granel.Text = "Granel";
            this.cbx_granel.UseVisualStyleBackColor = true;
            // 
            // tbx_precio
            // 
            this.tbx_precio.Location = new System.Drawing.Point(585, 120);
            this.tbx_precio.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_precio.Name = "tbx_precio";
            this.tbx_precio.Size = new System.Drawing.Size(126, 26);
            this.tbx_precio.TabIndex = 7;
            // 
            // tbx_inv
            // 
            this.tbx_inv.Location = new System.Drawing.Point(585, 190);
            this.tbx_inv.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_inv.Name = "tbx_inv";
            this.tbx_inv.Size = new System.Drawing.Size(126, 26);
            this.tbx_inv.TabIndex = 8;
            // 
            // btn_commit
            // 
            this.btn_commit.FlatAppearance.BorderSize = 0;
            this.btn_commit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_commit.Image = global::ZapaVentas.Properties.Resources.button10;
            this.btn_commit.Location = new System.Drawing.Point(617, 360);
            this.btn_commit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(136, 64);
            this.btn_commit.TabIndex = 9;
            this.btn_commit.Text = "Agregar producto";
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_prodId
            // 
            this.lbl_prodId.AutoSize = true;
            this.lbl_prodId.Location = new System.Drawing.Point(585, 248);
            this.lbl_prodId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_prodId.Name = "lbl_prodId";
            this.lbl_prodId.Size = new System.Drawing.Size(84, 19);
            this.lbl_prodId.TabIndex = 10;
            this.lbl_prodId.Text = "Id producto:";
            // 
            // tbx_id_prod
            // 
            this.tbx_id_prod.Location = new System.Drawing.Point(585, 266);
            this.tbx_id_prod.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_id_prod.Name = "tbx_id_prod";
            this.tbx_id_prod.Size = new System.Drawing.Size(136, 26);
            this.tbx_id_prod.TabIndex = 11;
            // 
            // product_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(209)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(786, 465);
            this.Controls.Add(this.tbx_nombre);
            this.Controls.Add(this.tbx_id_prod);
            this.Controls.Add(this.lbl_prodId);
            this.Controls.Add(this.btn_commit);
            this.Controls.Add(this.tbx_inv);
            this.Controls.Add(this.tbx_precio);
            this.Controls.Add(this.cbx_granel);
            this.Controls.Add(this.lbl_inv);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_no_encontrado);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.lbl_prodName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "product_editor";
            this.Text = "Editor de productos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.product_editor_FormClosed);
            this.Load += new System.EventHandler(this.product_editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.Label lbl_prodName;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Label lbl_no_encontrado;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_inv;
        private System.Windows.Forms.CheckBox cbx_granel;
        private System.Windows.Forms.TextBox tbx_precio;
        private System.Windows.Forms.TextBox tbx_inv;
        private System.Windows.Forms.Button btn_commit;
        private System.Windows.Forms.Label lbl_prodId;
        private System.Windows.Forms.TextBox tbx_id_prod;
    }
}