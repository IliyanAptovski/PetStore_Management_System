
namespace PetStore
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.captionTextLbl = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.subtotalTextLbl = new System.Windows.Forms.Label();
            this.lineLbl = new System.Windows.Forms.Label();
            this.shippingTextLbl = new System.Windows.Forms.Label();
            this.taxTextLbl = new System.Windows.Forms.Label();
            this.subtotalLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.totalTextLbl = new System.Windows.Forms.Label();
            this.finalizeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // captionTextLbl
            // 
            this.captionTextLbl.AutoSize = true;
            this.captionTextLbl.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captionTextLbl.ForeColor = System.Drawing.Color.White;
            this.captionTextLbl.Location = new System.Drawing.Point(429, 43);
            this.captionTextLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.captionTextLbl.Name = "captionTextLbl";
            this.captionTextLbl.Size = new System.Drawing.Size(359, 84);
            this.captionTextLbl.TabIndex = 11;
            this.captionTextLbl.Text = "Finalize order";
            this.captionTextLbl.Click += new System.EventHandler(this.captionTextLbl_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.updateBtn.Location = new System.Drawing.Point(444, 553);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(275, 66);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.deleteBtn.Location = new System.Drawing.Point(751, 553);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(275, 66);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // subtotalTextLbl
            // 
            this.subtotalTextLbl.AutoSize = true;
            this.subtotalTextLbl.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtotalTextLbl.ForeColor = System.Drawing.Color.White;
            this.subtotalTextLbl.Location = new System.Drawing.Point(227, 185);
            this.subtotalTextLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotalTextLbl.Name = "subtotalTextLbl";
            this.subtotalTextLbl.Size = new System.Drawing.Size(184, 64);
            this.subtotalTextLbl.TabIndex = 22;
            this.subtotalTextLbl.Text = "Subtotal";
            this.subtotalTextLbl.Click += new System.EventHandler(this.subtotalTextLbl_Click);
            // 
            // lineLbl
            // 
            this.lineLbl.AutoSize = true;
            this.lineLbl.BackColor = System.Drawing.Color.Transparent;
            this.lineLbl.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.lineLbl.Location = new System.Drawing.Point(205, 110);
            this.lineLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lineLbl.Name = "lineLbl";
            this.lineLbl.Size = new System.Drawing.Size(771, 77);
            this.lineLbl.TabIndex = 23;
            this.lineLbl.Text = "_________________________________________";
            this.lineLbl.Visible = false;
            this.lineLbl.Click += new System.EventHandler(this.lineLbl_Click);
            // 
            // shippingTextLbl
            // 
            this.shippingTextLbl.AutoSize = true;
            this.shippingTextLbl.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shippingTextLbl.ForeColor = System.Drawing.Color.White;
            this.shippingTextLbl.Location = new System.Drawing.Point(227, 257);
            this.shippingTextLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shippingTextLbl.Name = "shippingTextLbl";
            this.shippingTextLbl.Size = new System.Drawing.Size(190, 64);
            this.shippingTextLbl.TabIndex = 24;
            this.shippingTextLbl.Text = "Shipping";
            this.shippingTextLbl.Click += new System.EventHandler(this.shippingTextLbl_Click);
            // 
            // taxTextLbl
            // 
            this.taxTextLbl.AutoSize = true;
            this.taxTextLbl.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taxTextLbl.ForeColor = System.Drawing.Color.White;
            this.taxTextLbl.Location = new System.Drawing.Point(227, 332);
            this.taxTextLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxTextLbl.Name = "taxTextLbl";
            this.taxTextLbl.Size = new System.Drawing.Size(94, 64);
            this.taxTextLbl.TabIndex = 25;
            this.taxTextLbl.Text = "Tax";
            this.taxTextLbl.Click += new System.EventHandler(this.taxTextLbl_Click);
            // 
            // subtotalLbl
            // 
            this.subtotalLbl.AutoSize = true;
            this.subtotalLbl.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.subtotalLbl.Location = new System.Drawing.Point(763, 185);
            this.subtotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotalLbl.Name = "subtotalLbl";
            this.subtotalLbl.Size = new System.Drawing.Size(191, 64);
            this.subtotalLbl.TabIndex = 26;
            this.subtotalLbl.Text = "$000.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(763, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 64);
            this.label2.TabIndex = 27;
            this.label2.Text = "$10.00";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taxLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.taxLbl.Location = new System.Drawing.Point(763, 257);
            this.taxLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(164, 64);
            this.taxLbl.TabIndex = 28;
            this.taxLbl.Text = "$20.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(205, 384);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 77);
            this.label1.TabIndex = 29;
            this.label1.Text = "_________________________________________";
            this.label1.Visible = false;
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.totalLbl.Location = new System.Drawing.Point(763, 452);
            this.totalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(191, 64);
            this.totalLbl.TabIndex = 31;
            this.totalLbl.Text = "$000.00";
            // 
            // totalTextLbl
            // 
            this.totalTextLbl.AutoSize = true;
            this.totalTextLbl.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalTextLbl.ForeColor = System.Drawing.Color.White;
            this.totalTextLbl.Location = new System.Drawing.Point(227, 452);
            this.totalTextLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalTextLbl.Name = "totalTextLbl";
            this.totalTextLbl.Size = new System.Drawing.Size(123, 64);
            this.totalTextLbl.TabIndex = 30;
            this.totalTextLbl.Text = "Total";
            // 
            // finalizeBtn
            // 
            this.finalizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizeBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finalizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.finalizeBtn.Location = new System.Drawing.Point(142, 553);
            this.finalizeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.finalizeBtn.Name = "finalizeBtn";
            this.finalizeBtn.Size = new System.Drawing.Size(275, 66);
            this.finalizeBtn.TabIndex = 32;
            this.finalizeBtn.Text = "Finalize";
            this.finalizeBtn.UseVisualStyleBackColor = true;
            this.finalizeBtn.Click += new System.EventHandler(this.finalizeBtn_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1183, 688);
            this.Controls.Add(this.finalizeBtn);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.totalTextLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taxLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subtotalLbl);
            this.Controls.Add(this.taxTextLbl);
            this.Controls.Add(this.shippingTextLbl);
            this.Controls.Add(this.lineLbl);
            this.Controls.Add(this.subtotalTextLbl);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.captionTextLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1201, 735);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1201, 735);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label captionTextLbl;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label subtotalTextLbl;
        private System.Windows.Forms.Label lineLbl;
        private System.Windows.Forms.Label shippingTextLbl;
        private System.Windows.Forms.Label taxTextLbl;
        private System.Windows.Forms.Label subtotalLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label totalTextLbl;
        private System.Windows.Forms.Button finalizeBtn;
    }
}