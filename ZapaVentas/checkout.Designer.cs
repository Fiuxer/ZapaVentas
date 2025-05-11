namespace ZapaVentas
{
    partial class checkout
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
            this.components = new System.ComponentModel.Container();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_efectivo = new System.Windows.Forms.Button();
            this.btn_tarjeta = new System.Windows.Forms.Button();
            this.pnl_efectivo = new System.Windows.Forms.Panel();
            this.lbl_total_efectivo = new System.Windows.Forms.Label();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.tbx_change = new System.Windows.Forms.TextBox();
            this.nud_pago = new System.Windows.Forms.NumericUpDown();
            this.lbl_change = new System.Windows.Forms.Label();
            this.lbl_payWith = new System.Windows.Forms.Label();
            this.pnl_card = new System.Windows.Forms.Panel();
            this.lbl_card = new System.Windows.Forms.Label();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.pnl_efectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pago)).BeginInit();
            this.pnl_card.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI Symbol", 30F);
            this.lbl_total.Location = new System.Drawing.Point(178, 93);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(120, 54);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "Total:";
            // 
            // btn_efectivo
            // 
            this.btn_efectivo.Location = new System.Drawing.Point(185, 208);
            this.btn_efectivo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_efectivo.Name = "btn_efectivo";
            this.btn_efectivo.Size = new System.Drawing.Size(102, 55);
            this.btn_efectivo.TabIndex = 1;
            this.btn_efectivo.Text = "Efectivo";
            this.btn_efectivo.UseVisualStyleBackColor = true;
            this.btn_efectivo.Click += new System.EventHandler(this.btn_efectivo_Click);
            // 
            // btn_tarjeta
            // 
            this.btn_tarjeta.Location = new System.Drawing.Point(305, 208);
            this.btn_tarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tarjeta.Name = "btn_tarjeta";
            this.btn_tarjeta.Size = new System.Drawing.Size(102, 55);
            this.btn_tarjeta.TabIndex = 2;
            this.btn_tarjeta.Text = "Tarjeta";
            this.btn_tarjeta.UseVisualStyleBackColor = true;
            this.btn_tarjeta.Click += new System.EventHandler(this.btn_tarjeta_Click);
            // 
            // pnl_efectivo
            // 
            this.pnl_efectivo.Controls.Add(this.lbl_total_efectivo);
            this.pnl_efectivo.Controls.Add(this.btn_checkout);
            this.pnl_efectivo.Controls.Add(this.tbx_change);
            this.pnl_efectivo.Controls.Add(this.nud_pago);
            this.pnl_efectivo.Controls.Add(this.lbl_change);
            this.pnl_efectivo.Controls.Add(this.lbl_payWith);
            this.pnl_efectivo.Location = new System.Drawing.Point(9, 10);
            this.pnl_efectivo.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_efectivo.Name = "pnl_efectivo";
            this.pnl_efectivo.Size = new System.Drawing.Size(582, 346);
            this.pnl_efectivo.TabIndex = 3;
            this.pnl_efectivo.Visible = false;
            // 
            // lbl_total_efectivo
            // 
            this.lbl_total_efectivo.AutoSize = true;
            this.lbl_total_efectivo.Font = new System.Drawing.Font("Segoe UI Symbol", 30F);
            this.lbl_total_efectivo.Location = new System.Drawing.Point(225, 66);
            this.lbl_total_efectivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total_efectivo.Name = "lbl_total_efectivo";
            this.lbl_total_efectivo.Size = new System.Drawing.Size(130, 54);
            this.lbl_total_efectivo.TabIndex = 5;
            this.lbl_total_efectivo.Text = "label3";
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(234, 225);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(101, 46);
            this.btn_checkout.TabIndex = 2;
            this.btn_checkout.Text = "Cobrar";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // tbx_change
            // 
            this.tbx_change.Location = new System.Drawing.Point(261, 183);
            this.tbx_change.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_change.Name = "tbx_change";
            this.tbx_change.ReadOnly = true;
            this.tbx_change.Size = new System.Drawing.Size(91, 22);
            this.tbx_change.TabIndex = 10;
            this.tbx_change.TabStop = false;
            // 
            // nud_pago
            // 
            this.nud_pago.DecimalPlaces = 1;
            this.nud_pago.Location = new System.Drawing.Point(261, 154);
            this.nud_pago.Margin = new System.Windows.Forms.Padding(2);
            this.nud_pago.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_pago.Name = "nud_pago";
            this.nud_pago.Size = new System.Drawing.Size(90, 22);
            this.nud_pago.TabIndex = 1;
            this.nud_pago.ThousandsSeparator = true;
            this.nud_pago.ValueChanged += new System.EventHandler(this.nud_pago_ValueChanged);
            this.nud_pago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nud_pago_KeyDown);
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.Location = new System.Drawing.Point(214, 185);
            this.lbl_change.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(49, 13);
            this.lbl_change.TabIndex = 1;
            this.lbl_change.Text = "Cambio:";
            // 
            // lbl_payWith
            // 
            this.lbl_payWith.AutoSize = true;
            this.lbl_payWith.Location = new System.Drawing.Point(203, 156);
            this.lbl_payWith.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_payWith.Name = "lbl_payWith";
            this.lbl_payWith.Size = new System.Drawing.Size(61, 13);
            this.lbl_payWith.TabIndex = 0;
            this.lbl_payWith.Text = "Pagó con: ";
            // 
            // pnl_card
            // 
            this.pnl_card.Controls.Add(this.lbl_card);
            this.pnl_card.Location = new System.Drawing.Point(133, -3);
            this.pnl_card.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_card.Name = "pnl_card";
            this.pnl_card.Size = new System.Drawing.Size(341, 284);
            this.pnl_card.TabIndex = 11;
            this.pnl_card.Visible = false;
            // 
            // lbl_card
            // 
            this.lbl_card.AutoSize = true;
            this.lbl_card.Location = new System.Drawing.Point(134, 130);
            this.lbl_card.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_card.Name = "lbl_card";
            this.lbl_card.Size = new System.Drawing.Size(82, 13);
            this.lbl_card.TabIndex = 0;
            this.lbl_card.Text = "Insertar tarjeta";
            // 
            // tick
            // 
            this.tick.Interval = 200;
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(209)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pnl_card);
            this.Controls.Add(this.pnl_efectivo);
            this.Controls.Add(this.btn_tarjeta);
            this.Controls.Add(this.btn_efectivo);
            this.Controls.Add(this.lbl_total);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.checkout_Load);
            this.pnl_efectivo.ResumeLayout(false);
            this.pnl_efectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pago)).EndInit();
            this.pnl_card.ResumeLayout(false);
            this.pnl_card.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_efectivo;
        private System.Windows.Forms.Button btn_tarjeta;
        private System.Windows.Forms.Panel pnl_efectivo;
        private System.Windows.Forms.NumericUpDown nud_pago;
        private System.Windows.Forms.Label lbl_change;
        private System.Windows.Forms.Label lbl_payWith;
        private System.Windows.Forms.TextBox tbx_change;
        private System.Windows.Forms.Label lbl_total_efectivo;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Panel pnl_card;
        private System.Windows.Forms.Label lbl_card;
        private System.Windows.Forms.Timer tick;
    }
}