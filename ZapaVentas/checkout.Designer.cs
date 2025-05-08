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
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_total.Location = new System.Drawing.Point(237, 114);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(151, 58);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "Total:";
            // 
            // btn_efectivo
            // 
            this.btn_efectivo.Location = new System.Drawing.Point(247, 256);
            this.btn_efectivo.Name = "btn_efectivo";
            this.btn_efectivo.Size = new System.Drawing.Size(136, 68);
            this.btn_efectivo.TabIndex = 1;
            this.btn_efectivo.Text = "Efectivo";
            this.btn_efectivo.UseVisualStyleBackColor = true;
            this.btn_efectivo.Click += new System.EventHandler(this.btn_efectivo_Click);
            // 
            // btn_tarjeta
            // 
            this.btn_tarjeta.Location = new System.Drawing.Point(407, 256);
            this.btn_tarjeta.Name = "btn_tarjeta";
            this.btn_tarjeta.Size = new System.Drawing.Size(136, 68);
            this.btn_tarjeta.TabIndex = 2;
            this.btn_tarjeta.Text = "Tarjeta";
            this.btn_tarjeta.UseVisualStyleBackColor = true;
            this.btn_tarjeta.Click += new System.EventHandler(this.btn_tarjeta_Click);
            // 
            // pnl_efectivo
            // 
            this.pnl_efectivo.Controls.Add(this.pnl_card);
            this.pnl_efectivo.Controls.Add(this.lbl_total_efectivo);
            this.pnl_efectivo.Controls.Add(this.btn_checkout);
            this.pnl_efectivo.Controls.Add(this.tbx_change);
            this.pnl_efectivo.Controls.Add(this.nud_pago);
            this.pnl_efectivo.Controls.Add(this.lbl_change);
            this.pnl_efectivo.Controls.Add(this.lbl_payWith);
            this.pnl_efectivo.Location = new System.Drawing.Point(12, 12);
            this.pnl_efectivo.Name = "pnl_efectivo";
            this.pnl_efectivo.Size = new System.Drawing.Size(776, 426);
            this.pnl_efectivo.TabIndex = 3;
            this.pnl_efectivo.Visible = false;
            // 
            // lbl_total_efectivo
            // 
            this.lbl_total_efectivo.AutoSize = true;
            this.lbl_total_efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_total_efectivo.Location = new System.Drawing.Point(300, 81);
            this.lbl_total_efectivo.Name = "lbl_total_efectivo";
            this.lbl_total_efectivo.Size = new System.Drawing.Size(159, 58);
            this.lbl_total_efectivo.TabIndex = 5;
            this.lbl_total_efectivo.Text = "label3";
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(312, 277);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(135, 57);
            this.btn_checkout.TabIndex = 2;
            this.btn_checkout.Text = "Cobrar";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbx_change
            // 
            this.tbx_change.Location = new System.Drawing.Point(348, 225);
            this.tbx_change.Name = "tbx_change";
            this.tbx_change.ReadOnly = true;
            this.tbx_change.Size = new System.Drawing.Size(120, 22);
            this.tbx_change.TabIndex = 10;
            this.tbx_change.TabStop = false;
            // 
            // nud_pago
            // 
            this.nud_pago.DecimalPlaces = 1;
            this.nud_pago.Location = new System.Drawing.Point(348, 190);
            this.nud_pago.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_pago.Name = "nud_pago";
            this.nud_pago.Size = new System.Drawing.Size(120, 22);
            this.nud_pago.TabIndex = 1;
            this.nud_pago.ThousandsSeparator = true;
            this.nud_pago.ValueChanged += new System.EventHandler(this.nud_pago_ValueChanged);
            this.nud_pago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nud_pago_KeyDown);
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.Location = new System.Drawing.Point(285, 228);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(57, 16);
            this.lbl_change.TabIndex = 1;
            this.lbl_change.Text = "Cambio:";
            // 
            // lbl_payWith
            // 
            this.lbl_payWith.AutoSize = true;
            this.lbl_payWith.Location = new System.Drawing.Point(271, 192);
            this.lbl_payWith.Name = "lbl_payWith";
            this.lbl_payWith.Size = new System.Drawing.Size(71, 16);
            this.lbl_payWith.TabIndex = 0;
            this.lbl_payWith.Text = "Pagó con: ";
            // 
            // pnl_card
            // 
            this.pnl_card.Controls.Add(this.lbl_card);
            this.pnl_card.Location = new System.Drawing.Point(166, 27);
            this.pnl_card.Name = "pnl_card";
            this.pnl_card.Size = new System.Drawing.Size(455, 349);
            this.pnl_card.TabIndex = 11;
            this.pnl_card.Visible = false;
            // 
            // lbl_card
            // 
            this.lbl_card.AutoSize = true;
            this.lbl_card.Location = new System.Drawing.Point(179, 160);
            this.lbl_card.Name = "lbl_card";
            this.lbl_card.Size = new System.Drawing.Size(91, 16);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_efectivo);
            this.Controls.Add(this.btn_tarjeta);
            this.Controls.Add(this.btn_efectivo);
            this.Controls.Add(this.lbl_total);
            this.Name = "checkout";
            this.Text = "checkout";
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