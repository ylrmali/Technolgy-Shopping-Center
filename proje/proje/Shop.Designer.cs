namespace proje
{
    partial class Shop
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
            this.wallet = new System.Windows.Forms.Button();
            this.laptop = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.Button();
            this.accessory = new System.Windows.Forms.Button();
            this.wallet2 = new System.Windows.Forms.Button();
            this.wallet1 = new proje.Wallet();
            this.laptop1 = new proje.Laptop();
            this.SuspendLayout();
            // 
            // wallet
            // 
            this.wallet.Location = new System.Drawing.Point(13, 64);
            this.wallet.Name = "wallet";
            this.wallet.Size = new System.Drawing.Size(137, 23);
            this.wallet.TabIndex = 1;
            this.wallet.Text = "Wallet";
            this.wallet.UseVisualStyleBackColor = true;
            this.wallet.Click += new System.EventHandler(this.wallet_Click);
            // 
            // laptop
            // 
            this.laptop.Location = new System.Drawing.Point(13, 110);
            this.laptop.Name = "laptop";
            this.laptop.Size = new System.Drawing.Size(137, 23);
            this.laptop.TabIndex = 2;
            this.laptop.Text = "Laptop";
            this.laptop.UseVisualStyleBackColor = true;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(12, 153);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(137, 23);
            this.phone.TabIndex = 3;
            this.phone.Text = "Phone";
            this.phone.UseVisualStyleBackColor = true;
            // 
            // accessory
            // 
            this.accessory.Location = new System.Drawing.Point(12, 192);
            this.accessory.Name = "accessory";
            this.accessory.Size = new System.Drawing.Size(137, 23);
            this.accessory.TabIndex = 4;
            this.accessory.Text = "Accessory";
            this.accessory.UseVisualStyleBackColor = true;
            // 
            // wallet2
            // 
            this.wallet2.Location = new System.Drawing.Point(13, 250);
            this.wallet2.Name = "wallet2";
            this.wallet2.Size = new System.Drawing.Size(137, 23);
            this.wallet2.TabIndex = 1;
            this.wallet2.Text = "Wallet2";
            this.wallet2.UseVisualStyleBackColor = true;
            this.wallet2.Click += new System.EventHandler(this.wallet_Click);
            // 
            // wallet1
            // 
            this.wallet1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wallet1.Location = new System.Drawing.Point(222, 1);
            this.wallet1.Name = "wallet1";
            this.wallet1.Size = new System.Drawing.Size(579, 446);
            this.wallet1.TabIndex = 5;
            // 
            // laptop1
            // 
            this.laptop1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.laptop1.Location = new System.Drawing.Point(222, 0);
            this.laptop1.Name = "laptop1";
            this.laptop1.Size = new System.Drawing.Size(584, 447);
            this.laptop1.TabIndex = 6;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laptop1);
            this.Controls.Add(this.wallet1);
            this.Controls.Add(this.accessory);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.laptop);
            this.Controls.Add(this.wallet);
            this.Controls.Add(this.wallet2);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wallet;
        private System.Windows.Forms.Button wallet2;
        private System.Windows.Forms.Button laptop;
        private System.Windows.Forms.Button phone;
        private System.Windows.Forms.Button accessory;
        private Wallet wallet1;
        private Laptop laptop1;
    }
}