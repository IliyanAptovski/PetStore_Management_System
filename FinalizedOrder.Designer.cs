namespace PetStore
{
    partial class FinalizedOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalizedOrder));
            this.thanksTextLbl = new System.Windows.Forms.Label();
            this.lineLbl = new System.Windows.Forms.Label();
            this.secondLineLbl = new System.Windows.Forms.Label();
            this.orderNumberTextLbl = new System.Windows.Forms.Label();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // thanksTextLbl
            // 
            this.thanksTextLbl.AutoSize = true;
            this.thanksTextLbl.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thanksTextLbl.ForeColor = System.Drawing.Color.White;
            this.thanksTextLbl.Location = new System.Drawing.Point(241, 22);
            this.thanksTextLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thanksTextLbl.Name = "thanksTextLbl";
            this.thanksTextLbl.Size = new System.Drawing.Size(659, 84);
            this.thanksTextLbl.TabIndex = 12;
            this.thanksTextLbl.Text = "Thank you for your order!";
            // 
            // lineLbl
            // 
            this.lineLbl.AutoSize = true;
            this.lineLbl.BackColor = System.Drawing.Color.Transparent;
            this.lineLbl.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.lineLbl.Location = new System.Drawing.Point(201, 106);
            this.lineLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lineLbl.Name = "lineLbl";
            this.lineLbl.Size = new System.Drawing.Size(771, 77);
            this.lineLbl.TabIndex = 24;
            this.lineLbl.Text = "_________________________________________";
            // 
            // secondLineLbl
            // 
            this.secondLineLbl.AutoSize = true;
            this.secondLineLbl.BackColor = System.Drawing.Color.Transparent;
            this.secondLineLbl.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondLineLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.secondLineLbl.Location = new System.Drawing.Point(201, 215);
            this.secondLineLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondLineLbl.Name = "secondLineLbl";
            this.secondLineLbl.Size = new System.Drawing.Size(771, 77);
            this.secondLineLbl.TabIndex = 25;
            this.secondLineLbl.Text = "_________________________________________";
            // 
            // orderNumberTextLbl
            // 
            this.orderNumberTextLbl.AutoSize = true;
            this.orderNumberTextLbl.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderNumberTextLbl.ForeColor = System.Drawing.Color.White;
            this.orderNumberTextLbl.Location = new System.Drawing.Point(231, 174);
            this.orderNumberTextLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderNumberTextLbl.Name = "orderNumberTextLbl";
            this.orderNumberTextLbl.Size = new System.Drawing.Size(211, 76);
            this.orderNumberTextLbl.TabIndex = 26;
            this.orderNumberTextLbl.Text = "Order #";
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.orderDataGridView.ColumnHeadersHeight = 29;
            this.orderDataGridView.Location = new System.Drawing.Point(52, 295);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowHeadersWidth = 51;
            this.orderDataGridView.RowTemplate.Height = 24;
            this.orderDataGridView.Size = new System.Drawing.Size(1074, 364);
            this.orderDataGridView.TabIndex = 27;
            // 
            // FinalizedOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1183, 688);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.orderNumberTextLbl);
            this.Controls.Add(this.secondLineLbl);
            this.Controls.Add(this.lineLbl);
            this.Controls.Add(this.thanksTextLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1201, 735);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1201, 735);
            this.Name = "FinalizedOrder";
            this.Text = "FinalizedOrder";
            this.Load += new System.EventHandler(this.FinalizedOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label thanksTextLbl;
        private System.Windows.Forms.Label lineLbl;
        private System.Windows.Forms.Label secondLineLbl;
        private System.Windows.Forms.Label orderNumberTextLbl;
        private System.Windows.Forms.DataGridView orderDataGridView;
    }
}