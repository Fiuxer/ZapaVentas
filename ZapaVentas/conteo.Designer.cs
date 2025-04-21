namespace ZapaVentas
{
    partial class conteo
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
            this.dgv_conteo = new System.Windows.Forms.DataGridView();
            this.cbx_view_mine = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_conteo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_conteo
            // 
            this.dgv_conteo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_conteo.Location = new System.Drawing.Point(12, 65);
            this.dgv_conteo.Name = "dgv_conteo";
            this.dgv_conteo.RowHeadersWidth = 51;
            this.dgv_conteo.RowTemplate.Height = 24;
            this.dgv_conteo.Size = new System.Drawing.Size(776, 373);
            this.dgv_conteo.TabIndex = 0;
            // 
            // cbx_view_mine
            // 
            this.cbx_view_mine.AutoSize = true;
            this.cbx_view_mine.Location = new System.Drawing.Point(12, 25);
            this.cbx_view_mine.Name = "cbx_view_mine";
            this.cbx_view_mine.Size = new System.Drawing.Size(93, 20);
            this.cbx_view_mine.TabIndex = 1;
            this.cbx_view_mine.Text = "Mis ventas";
            this.cbx_view_mine.UseVisualStyleBackColor = true;
            // 
            // conteo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbx_view_mine);
            this.Controls.Add(this.dgv_conteo);
            this.Name = "conteo";
            this.Text = "conteo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.conteo_FormClosed);
            this.Load += new System.EventHandler(this.conteo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_conteo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_conteo;
        private System.Windows.Forms.CheckBox cbx_view_mine;
    }
}