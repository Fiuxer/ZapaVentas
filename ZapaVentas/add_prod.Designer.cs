namespace ZapaVentas
{
    partial class add_prod
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
            this.pnl_cantidad_envasado = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_cantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.pnl_cantidad_envasado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(40, 66);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(228, 22);
            this.tbx_nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del producto";
            // 
            // dgv_productos
            // 
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(12, 94);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 24;
            this.dgv_productos.Size = new System.Drawing.Size(776, 344);
            this.dgv_productos.TabIndex = 2;
            this.dgv_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellContentClick);
            // 
            // pnl_cantidad_envasado
            // 
            this.pnl_cantidad_envasado.Controls.Add(this.nud_cantidad);
            this.pnl_cantidad_envasado.Controls.Add(this.label2);
            this.pnl_cantidad_envasado.Location = new System.Drawing.Point(133, 112);
            this.pnl_cantidad_envasado.Name = "pnl_cantidad_envasado";
            this.pnl_cantidad_envasado.Size = new System.Drawing.Size(541, 293);
            this.pnl_cantidad_envasado.TabIndex = 3;
            this.pnl_cantidad_envasado.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad:";
            // 
            // nud_cantidad
            // 
            this.nud_cantidad.Location = new System.Drawing.Point(209, 119);
            this.nud_cantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_cantidad.Name = "nud_cantidad";
            this.nud_cantidad.Size = new System.Drawing.Size(120, 22);
            this.nud_cantidad.TabIndex = 1;
            this.nud_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // add_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_cantidad_envasado);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_nombre);
            this.Name = "add_prod";
            this.Text = "add_prod";
            this.Load += new System.EventHandler(this.add_prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.pnl_cantidad_envasado.ResumeLayout(false);
            this.pnl_cantidad_envasado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Panel pnl_cantidad_envasado;
        private System.Windows.Forms.NumericUpDown nud_cantidad;
        private System.Windows.Forms.Label label2;
    }
}