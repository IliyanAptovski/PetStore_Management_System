
namespace PetStore
{
    partial class ShoppingCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCart));
            this.nameLbl = new System.Windows.Forms.Label();
            this.lineLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.buyBtn = new System.Windows.Forms.Button();
            this.nameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.lastNameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.emailRichTextBox = new System.Windows.Forms.RichTextBox();
            this.itemsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.secondLineLbl = new System.Windows.Forms.Label();
            this.personalInfoTextLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(26, 103);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(163, 77);
            this.nameLbl.TabIndex = 10;
            this.nameLbl.Text = "Name\r\n";
            // 
            // lineLbl
            // 
            this.lineLbl.AutoSize = true;
            this.lineLbl.BackColor = System.Drawing.Color.Transparent;
            this.lineLbl.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.lineLbl.Location = new System.Drawing.Point(456, -52);
            this.lineLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lineLbl.Name = "lineLbl";
            this.lineLbl.Size = new System.Drawing.Size(47, 847);
            this.lineLbl.TabIndex = 15;
            this.lineLbl.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            this.lineLbl.Click += new System.EventHandler(this.lineLbl_Click);
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLbl.ForeColor = System.Drawing.Color.White;
            this.lastNameLbl.Location = new System.Drawing.Point(26, 262);
            this.lastNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(275, 77);
            this.lastNameLbl.TabIndex = 16;
            this.lastNameLbl.Text = "Last Name\r\n";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLbl.ForeColor = System.Drawing.Color.White;
            this.emailLbl.Location = new System.Drawing.Point(26, 410);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(185, 77);
            this.emailLbl.TabIndex = 17;
            this.emailLbl.Text = "E-Mail";
            // 
            // buyBtn
            // 
            this.buyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.buyBtn.Location = new System.Drawing.Point(41, 597);
            this.buyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(383, 66);
            this.buyBtn.TabIndex = 18;
            this.buyBtn.Text = "Buy";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // nameRichTextBox
            // 
            this.nameRichTextBox.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameRichTextBox.Location = new System.Drawing.Point(39, 183);
            this.nameRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameRichTextBox.Name = "nameRichTextBox";
            this.nameRichTextBox.Size = new System.Drawing.Size(383, 59);
            this.nameRichTextBox.TabIndex = 19;
            this.nameRichTextBox.Text = "";
            // 
            // lastNameRichTextBox
            // 
            this.lastNameRichTextBox.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameRichTextBox.Location = new System.Drawing.Point(41, 346);
            this.lastNameRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameRichTextBox.Name = "lastNameRichTextBox";
            this.lastNameRichTextBox.Size = new System.Drawing.Size(383, 59);
            this.lastNameRichTextBox.TabIndex = 20;
            this.lastNameRichTextBox.Text = "";
            // 
            // emailRichTextBox
            // 
            this.emailRichTextBox.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailRichTextBox.Location = new System.Drawing.Point(41, 499);
            this.emailRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailRichTextBox.Name = "emailRichTextBox";
            this.emailRichTextBox.Size = new System.Drawing.Size(383, 59);
            this.emailRichTextBox.TabIndex = 21;
            this.emailRichTextBox.Text = "";
            // 
            // itemsRichTextBox
            // 
            this.itemsRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.itemsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemsRichTextBox.Font = new System.Drawing.Font("Segoe Print", 24F);
            this.itemsRichTextBox.ForeColor = System.Drawing.Color.White;
            this.itemsRichTextBox.Location = new System.Drawing.Point(502, 13);
            this.itemsRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemsRichTextBox.Name = "itemsRichTextBox";
            this.itemsRichTextBox.Size = new System.Drawing.Size(659, 662);
            this.itemsRichTextBox.TabIndex = 23;
            this.itemsRichTextBox.Text = "";
            this.itemsRichTextBox.TextChanged += new System.EventHandler(this.itemsRichTextBox_TextChanged);
            // 
            // secondLineLbl
            // 
            this.secondLineLbl.AutoSize = true;
            this.secondLineLbl.BackColor = System.Drawing.Color.Transparent;
            this.secondLineLbl.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondLineLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.secondLineLbl.Location = new System.Drawing.Point(28, 45);
            this.secondLineLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondLineLbl.Name = "secondLineLbl";
            this.secondLineLbl.Size = new System.Drawing.Size(397, 77);
            this.secondLineLbl.TabIndex = 25;
            this.secondLineLbl.Text = "-------------";
            this.secondLineLbl.Click += new System.EventHandler(this.secondLineLbl_Click);
            // 
            // personalInfoTextLbl
            // 
            this.personalInfoTextLbl.AutoSize = true;
            this.personalInfoTextLbl.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalInfoTextLbl.ForeColor = System.Drawing.Color.White;
            this.personalInfoTextLbl.Location = new System.Drawing.Point(57, 8);
            this.personalInfoTextLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personalInfoTextLbl.Name = "personalInfoTextLbl";
            this.personalInfoTextLbl.Size = new System.Drawing.Size(334, 77);
            this.personalInfoTextLbl.TabIndex = 26;
            this.personalInfoTextLbl.Text = "Personal Info.";
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1183, 688);
            this.Controls.Add(this.personalInfoTextLbl);
            this.Controls.Add(this.secondLineLbl);
            this.Controls.Add(this.itemsRichTextBox);
            this.Controls.Add(this.emailRichTextBox);
            this.Controls.Add(this.lastNameRichTextBox);
            this.Controls.Add(this.nameRichTextBox);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.lineLbl);
            this.Controls.Add(this.nameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1201, 735);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1201, 735);
            this.Name = "ShoppingCart";
            this.Text = "ShoppingCart";
            this.Load += new System.EventHandler(this.ShoppingCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label lineLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.RichTextBox nameRichTextBox;
        private System.Windows.Forms.RichTextBox lastNameRichTextBox;
        private System.Windows.Forms.RichTextBox emailRichTextBox;
        private System.Windows.Forms.RichTextBox itemsRichTextBox;
        private System.Windows.Forms.Label secondLineLbl;
        private System.Windows.Forms.Label personalInfoTextLbl;
    }
}