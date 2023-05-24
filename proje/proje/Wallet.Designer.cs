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
            this.label2 = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pay.SuspendLayout();
            this.SuspendLayout();
            // 
            // wallet_header
            // 
            this.wallet_header.AutoSize = true;
            this.wallet_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.wallet_header.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.wallet_header.Location = new System.Drawing.Point(201, 38);
            this.wallet_header.Name = "wallet_header";
            this.wallet_header.Size = new System.Drawing.Size(154, 39);
            this.wallet_header.TabIndex = 0;
            this.wallet_header.Text = "WALLET";
            this.wallet_header.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "ali";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Balance :";
            // 
            // pay
            // 
            this.pay.BackColor = System.Drawing.SystemColors.GrayText;
            this.pay.Controls.Add(this.button1);
            this.pay.Controls.Add(this.groupBox1);
            this.pay.Controls.Add(this.textBox1);
            this.pay.Controls.Add(this.label3);
            this.pay.Location = new System.Drawing.Point(109, 92);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(341, 305);
            this.pay.TabIndex = 2;
            this.pay.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(107, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Money Amount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(69, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "CONFIRM";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.pay);
            this.Controls.Add(this.wallet_header);
            this.Name = "Wallet";
            this.Size = new System.Drawing.Size(566, 436);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label wallet_header;
    }
}
