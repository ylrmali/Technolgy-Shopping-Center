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
            this.phone1 = new proje.Phone();
            this.laptop2 = new proje.Laptop();
            this.wallet1 = new proje.Wallet();
            this.accessory1 = new proje.Accessory();
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
            this.laptop.Click += new System.EventHandler(this.laptop_Click);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(12, 153);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(137, 23);
            this.phone.TabIndex = 3;
            this.phone.Text = "Phone";
            this.phone.UseVisualStyleBackColor = true;
            this.phone.Click += new System.EventHandler(this.phone_Click);
            // 
            // accessory
            // 
            this.accessory.Location = new System.Drawing.Point(12, 192);
            this.accessory.Name = "accessory";
            this.accessory.Size = new System.Drawing.Size(137, 23);
            this.accessory.TabIndex = 4;
            this.accessory.Text = "Accessory";
            this.accessory.UseVisualStyleBackColor = true;
            this.accessory.Click += new System.EventHandler(this.accessory_Click);
            // 
            // phone1
            // 
            this.phone1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.phone1.Location = new System.Drawing.Point(205, 7);
            this.phone1.Name = "phone1";
            this.phone1.Size = new System.Drawing.Size(641, 536);
            this.phone1.TabIndex = 7;
            // 
            // laptop2
            // 
            this.laptop2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.laptop2.Location = new System.Drawing.Point(205, 7);
            this.laptop2.Name = "laptop2";
            this.laptop2.Size = new System.Drawing.Size(641, 533);
            this.laptop2.TabIndex = 6;
            this.laptop2.Load += new System.EventHandler(this.laptop2_Load);
            // 
            // wallet1
            // 
            this.wallet1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wallet1.Location = new System.Drawing.Point(205, 2);
            this.wallet1.Name = "wallet1";
            this.wallet1.Size = new System.Drawing.Size(648, 538);
            this.wallet1.TabIndex = 5;
            this.wallet1.Load += new System.EventHandler(this.wallet1_Load);
            // 
            // accessory1
            // 
            this.accessory1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.accessory1.Location = new System.Drawing.Point(205, 13);
            this.accessory1.Name = "accessory1";
            this.accessory1.Size = new System.Drawing.Size(641, 530);
            this.accessory1.TabIndex = 8;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(858, 538);
            this.Controls.Add(this.accessory1);
            this.Controls.Add(this.phone1);
            this.Controls.Add(this.laptop2);
            this.Controls.Add(this.wallet1);
            this.Controls.Add(this.accessory);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.laptop);
            this.Controls.Add(this.wallet);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wallet;
        private System.Windows.Forms.Button laptop;
        private System.Windows.Forms.Button phone;
        private System.Windows.Forms.Button accessory;
        private Wallet wallet1;
        private Laptop laptop1;
        private Laptop laptop2;
        private Phone phone1;
        private Accessory accessory1;
    }
}