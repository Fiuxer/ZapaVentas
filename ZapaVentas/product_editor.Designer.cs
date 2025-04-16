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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.lbl_no_encontrado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_granel = new System.Windows.Forms.CheckBox();
            this.tbx_precio = new System.Windows.Forms.TextBox();
            this.tbx_inv = new System.Windows.Forms.TextBox();
            this.btn_commit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_id_prod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(12, 55);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(327, 22);
            this.tbx_nombre.TabIndex = 0;
            this.tbx_nombre.TextChanged += new System.EventHandler(this.tbx_nombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del producto";
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(10, 82);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 24;
            this.dgv_productos.Size = new System.Drawing.Size(761, 477);
            this.dgv_productos.TabIndex = 2;
            this.dgv_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellContentClick);
            // 
            // lbl_no_encontrado
            // 
            this.lbl_no_encontrado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_no_encontrado.AutoSize = true;
            this.lbl_no_encontrado.Location = new System.Drawing.Point(337, 312);
            this.lbl_no_encontrado.Name = "lbl_no_encontrado";
            this.lbl_no_encontrado.Size = new System.Drawing.Size(44, 16);
            this.lbl_no_encontrado.TabIndex = 3;
            this.lbl_no_encontrado.Text = "label2";
            this.lbl_no_encontrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_no_encontrado.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(777, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inventario:";
            // 
            // cbx_granel
            // 
            this.cbx_granel.AutoSize = true;
            this.cbx_granel.Location = new System.Drawing.Point(780, 330);
            this.cbx_granel.Name = "cbx_granel";
            this.cbx_granel.Size = new System.Drawing.Size(69, 20);
            this.cbx_granel.TabIndex = 6;
            this.cbx_granel.Text = "Granel";
            this.cbx_granel.UseVisualStyleBackColor = true;
            // 
            // tbx_precio
            // 
            this.tbx_precio.Location = new System.Drawing.Point(780, 138);
            this.tbx_precio.Name = "tbx_precio";
            this.tbx_precio.Size = new System.Drawing.Size(167, 22);
            this.tbx_precio.TabIndex = 7;
            // 
            // tbx_inv
            // 
            this.tbx_inv.Location = new System.Drawing.Point(780, 234);
            this.tbx_inv.Name = "tbx_inv";
            this.tbx_inv.Size = new System.Drawing.Size(167, 22);
            this.tbx_inv.TabIndex = 8;
            // 
            // btn_commit
            // 
            this.btn_commit.Location = new System.Drawing.Point(823, 443);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(181, 79);
            this.btn_commit.TabIndex = 9;
            this.btn_commit.Text = "Agregar producto";
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(853, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Id producto:";
            // 
            // tbx_id_prod
            // 
            this.tbx_id_prod.Location = new System.Drawing.Point(856, 327);
            this.tbx_id_prod.Name = "tbx_id_prod";
            this.tbx_id_prod.Size = new System.Drawing.Size(180, 22);
            this.tbx_id_prod.TabIndex = 11;
            // 
            // product_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 572);
            this.Controls.Add(this.tbx_id_prod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_commit);
            this.Controls.Add(this.tbx_inv);
            this.Controls.Add(this.tbx_precio);
            this.Controls.Add(this.cbx_granel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_no_encontrado);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_nombre);
            this.Name = "product_editor";
            this.Text = "product_editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.product_editor_FormClosed);
            this.Load += new System.EventHandler(this.product_editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Label lbl_no_encontrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbx_granel;
        private System.Windows.Forms.TextBox tbx_precio;
        private System.Windows.Forms.TextBox tbx_inv;
        private System.Windows.Forms.Button btn_commit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_id_prod;
    }
}