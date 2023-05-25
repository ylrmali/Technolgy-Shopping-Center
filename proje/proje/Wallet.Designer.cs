namespace proje
{
    partial class Wallet
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.wallet_header = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.balance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.money_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pay.SuspendLayout();
            this.SuspendLayout();
            // 
            // wallet_header
            // 
            this.wallet_header.AutoSize = true;
            this.wallet_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.wallet_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.wallet_header.Location = new System.Drawing.Point(238, 81);
            this.wallet_header.Name = "wallet_header";
            this.wallet_header.Size = new System.Drawing.Size(154, 39);
            this.wallet_header.TabIndex = 0;
            this.wallet_header.Text = "WALLET";
            this.wallet_header.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.balance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(62, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.balance.Location = new System.Drawing.Point(167, 16);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(113, 25);
            this.balance.TabIndex = 1;
            this.balance.Text = "9999999TL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Balance :";
            // 
            // pay
            // 
            this.pay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pay.Controls.Add(this.button1);
            this.pay.Controls.Add(this.groupBox1);
            this.pay.Controls.Add(this.money_amount);
            this.pay.Controls.Add(this.label3);
            this.pay.Location = new System.Drawing.Point(91, 123);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(444, 319);
            this.pay.TabIndex = 2;
            this.pay.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(124, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "CONFIRM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // money_amount
            // 
            this.money_amount.Location = new System.Drawing.Point(124, 96);
            this.money_amount.Name = "money_amount";
            this.money_amount.Size = new System.Drawing.Size(198, 20);
            this.money_amount.TabIndex = 1;
            this.money_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(150, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Money Amount";
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.pay);
            this.Controls.Add(this.wallet_header);
            this.Name = "Wallet";
            this.Size = new System.Drawing.Size(645, 535);
            this.Load += new System.EventHandler(this.Wallet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pay.ResumeLayout(false);
            this.pay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox pay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox money_amount;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label wallet_header;
        private System.Windows.Forms.Label balance;
    }
}
