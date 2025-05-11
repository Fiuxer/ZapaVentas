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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_conteo = new System.Windows.Forms.DataGridView();
            this.cbx_view_mine = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_conteo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_conteo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_conteo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_conteo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(171)))), ((int)(((byte)(188)))));
            this.dgv_conteo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_conteo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_conteo.Location = new System.Drawing.Point(9, 53);
            this.dgv_conteo.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_conteo.Name = "dgv_conteo";
            this.dgv_conteo.RowHeadersWidth = 51;
            this.dgv_conteo.RowTemplate.Height = 24;
            this.dgv_conteo.Size = new System.Drawing.Size(582, 303);
            this.dgv_conteo.TabIndex = 0;
            // 
            // cbx_view_mine
            // 
            this.cbx_view_mine.AutoSize = true;
            this.cbx_view_mine.BackColor = System.Drawing.Color.Transparent;
            this.cbx_view_mine.Location = new System.Drawing.Point(9, 20);
            this.cbx_view_mine.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_view_mine.Name = "cbx_view_mine";
            this.cbx_view_mine.Size = new System.Drawing.Size(80, 17);
            this.cbx_view_mine.TabIndex = 1;
            this.cbx_view_mine.Text = "Mis ventas";
            this.cbx_view_mine.UseVisualStyleBackColor = false;
            this.cbx_view_mine.CheckedChanged += new System.EventHandler(this.cbx_view_mine_CheckedChanged);
            // 
            // conteo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZapaVentas.Properties.Resources.ConteoBG;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cbx_view_mine);
            this.Controls.Add(this.dgv_conteo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "conteo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conteo";
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