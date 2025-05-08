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
            this.lbl_prodName = new System.Windows.Forms.Label();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.pnl_cantidad_envasado = new System.Windows.Forms.Panel();
            this.nud_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_granel = new System.Windows.Forms.Panel();
            this.lbl_ppk = new System.Windows.Forms.Label();
            this.lbl_unitPrice = new System.Windows.Forms.Label();
            this.nud_granel = new System.Windows.Forms.NumericUpDown();
            this.lbl_granQuant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.pnl_cantidad_envasado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).BeginInit();
            this.pnl_granel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_granel)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(40, 66);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(228, 22);
            this.tbx_nombre.TabIndex = 0;
            // 
            // lbl_prodName
            // 
            this.lbl_prodName.AutoSize = true;
            this.lbl_prodName.Location = new System.Drawing.Point(87, 47);
            this.lbl_prodName.Name = "lbl_prodName";
            this.lbl_prodName.Size = new System.Drawing.Size(134, 16);
            this.lbl_prodName.TabIndex = 1;
            this.lbl_prodName.Text = "Nombre del producto";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad:";
            // 
            // pnl_granel
            // 
            this.pnl_granel.Controls.Add(this.lbl_ppk);
            this.pnl_granel.Controls.Add(this.lbl_unitPrice);
            this.pnl_granel.Controls.Add(this.nud_granel);
            this.pnl_granel.Controls.Add(this.lbl_granQuant);
            this.pnl_granel.Location = new System.Drawing.Point(133, 113);
            this.pnl_granel.Name = "pnl_granel";
            this.pnl_granel.Size = new System.Drawing.Size(541, 293);
            this.pnl_granel.TabIndex = 4;
            this.pnl_granel.Visible = false;
            // 
            // lbl_ppk
            // 
            this.lbl_ppk.AutoSize = true;
            this.lbl_ppk.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_ppk.Location = new System.Drawing.Point(233, 84);
            this.lbl_ppk.Name = "lbl_ppk";
            this.lbl_ppk.Size = new System.Drawing.Size(98, 46);
            this.lbl_ppk.TabIndex = 3;
            this.lbl_ppk.Text = "$/Kg";
            // 
            // lbl_unitPrice
            // 
            this.lbl_unitPrice.AutoSize = true;
            this.lbl_unitPrice.Location = new System.Drawing.Point(237, 44);
            this.lbl_unitPrice.Name = "lbl_unitPrice";
            this.lbl_unitPrice.Size = new System.Drawing.Size(92, 16);
            this.lbl_unitPrice.TabIndex = 2;
            this.lbl_unitPrice.Text = "Precio unitario";
            // 
            // nud_granel
            // 
            this.nud_granel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_granel.Location = new System.Drawing.Point(226, 211);
            this.nud_granel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_granel.Name = "nud_granel";
            this.nud_granel.Size = new System.Drawing.Size(120, 22);
            this.nud_granel.TabIndex = 1;
            this.nud_granel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_granel.ValueChanged += new System.EventHandler(this.nud_granel_ValueChanged);
            this.nud_granel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
            // 
            // lbl_granQuant
            // 
            this.lbl_granQuant.AutoSize = true;
            this.lbl_granQuant.Location = new System.Drawing.Point(239, 183);
            this.lbl_granQuant.Name = "lbl_granQuant";
            this.lbl_granQuant.Size = new System.Drawing.Size(90, 16);
            this.lbl_granQuant.TabIndex = 0;
            this.lbl_granQuant.Text = "Cantidad (kg):";
            // 
            // add_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_granel);
            this.Controls.Add(this.pnl_cantidad_envasado);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.lbl_prodName);
            this.Controls.Add(this.tbx_nombre);
            this.Name = "add_prod";
            this.Text = "add_prod";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_prod_FormClosed);
            this.Load += new System.EventHandler(this.add_prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.pnl_cantidad_envasado.ResumeLayout(false);
            this.pnl_cantidad_envasado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).EndInit();
            this.pnl_granel.ResumeLayout(false);
            this.pnl_granel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_granel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.Label lbl_prodName;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Panel pnl_cantidad_envasado;
        private System.Windows.Forms.NumericUpDown nud_cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_granel;
        private System.Windows.Forms.Label lbl_ppk;
        private System.Windows.Forms.Label lbl_unitPrice;
        private System.Windows.Forms.NumericUpDown nud_granel;
        private System.Windows.Forms.Label lbl_granQuant;
    }
}