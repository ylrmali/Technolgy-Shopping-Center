namespace proje
{
    partial class Register
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
            this.password_reg = new System.Windows.Forms.TextBox();
            this.username_register = new System.Windows.Forms.TextBox();
            this.mail_input = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.register_reg = new System.Windows.Forms.Button();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.re_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // password_reg
            // 
            this.password_reg.Location = new System.Drawing.Point(57, 277);
            this.password_reg.Name = "password_reg";
            this.password_reg.Size = new System.Drawing.Size(259, 20);
            this.password_reg.TabIndex = 1;
            this.password_reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_reg.UseSystemPasswordChar = true;
            // 
            // username_register
            // 
            this.username_register.Location = new System.Drawing.Point(57, 210);
            this.username_register.Name = "username_register";
            this.username_register.Size = new System.Drawing.Size(259, 20);
            this.username_register.TabIndex = 2;
            this.username_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username_register.TextChanged += new System.EventHandler(this.username_register_TextChanged);
            // 
            // mail_input
            // 
            this.mail_input.Location = new System.Drawing.Point(57, 149);
            this.mail_input.Name = "mail_input";
            this.mail_input.Size = new System.Drawing.Size(259, 20);
            this.mail_input.TabIndex = 3;
            this.mail_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.username.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.username.Location = new System.Drawing.Point(134, 182);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(102, 25);
            this.username.TabIndex = 4;
            this.username.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(156, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(134, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(134, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "RePassword";
            // 
            // register_reg
            // 
            this.register_reg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.register_reg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.register_reg.Location = new System.Drawing.Point(57, 385);
            this.register_reg.Name = "register_reg";
            this.register_reg.Size = new System.Drawing.Size(259, 42);
            this.register_reg.TabIndex = 8;
            this.register_reg.Text = "REGISTER";
            this.register_reg.UseVisualStyleBackColor = false;
            this.register_reg.Click += new System.EventHandler(this.register_reg_Click);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(98, 55);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(218, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "REGISTER";
            // 
            // re_password
            // 
            this.re_password.Location = new System.Drawing.Point(57, 339);
            this.re_password.Name = "re_password";
            this.re_password.Size = new System.Drawing.Size(259, 20);
            this.re_password.TabIndex = 10;
            this.re_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.re_password.UseSystemPasswordChar = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.re_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_reg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.mail_input);
            this.Controls.Add(this.username_register);
            this.Controls.Add(this.password_reg);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Register";
            this.Size = new System.Drawing.Size(366, 462);
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password_reg;
        private System.Windows.Forms.TextBox username_register;
        private System.Windows.Forms.TextBox mail_input;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button register_reg;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox re_password;
    }
}
