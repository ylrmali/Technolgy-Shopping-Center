namespace proje
{
    partial class Login
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
            this.username_login = new System.Windows.Forms.Label();
            this.password_login = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.username_input = new System.Windows.Forms.MaskedTextBox();
            this.login_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_login
            // 
            this.username_login.AutoSize = true;
            this.username_login.BackColor = System.Drawing.Color.Transparent;
            this.username_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.username_login.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.username_login.Location = new System.Drawing.Point(152, 145);
            this.username_login.Name = "username_login";
            this.username_login.Size = new System.Drawing.Size(97, 24);
            this.username_login.TabIndex = 0;
            this.username_login.Text = "Username";
            // 
            // password_login
            // 
            this.password_login.AutoSize = true;
            this.password_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.password_login.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.password_login.Location = new System.Drawing.Point(157, 215);
            this.password_login.Name = "password_login";
            this.password_login.Size = new System.Drawing.Size(92, 24);
            this.password_login.TabIndex = 1;
            this.password_login.Text = "Password";
            // 
            // password_input
            // 
            this.password_input.BackColor = System.Drawing.SystemColors.Control;
            this.password_input.Location = new System.Drawing.Point(60, 242);
            this.password_input.MinimumSize = new System.Drawing.Size(4, 40);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(283, 20);
            this.password_input.TabIndex = 2;
            this.password_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_input.UseSystemPasswordChar = true;
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(60, 172);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(283, 20);
            this.username_input.TabIndex = 3;
            this.username_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login_login
            // 
            this.login_login.BackColor = System.Drawing.Color.DodgerBlue;
            this.login_login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.login_login.Location = new System.Drawing.Point(60, 300);
            this.login_login.Name = "login_login";
            this.login_login.Size = new System.Drawing.Size(283, 58);
            this.login_login.TabIndex = 4;
            this.login_login.Text = "Login";
            this.login_login.UseVisualStyleBackColor = false;
            this.login_login.Click += new System.EventHandler(this.login_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(149, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "LOGIN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_login);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.password_login);
            this.Controls.Add(this.username_login);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(423, 484);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_login;
        private System.Windows.Forms.Label password_login;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.MaskedTextBox username_input;
        private System.Windows.Forms.Button login_login;
        private System.Windows.Forms.Label label2;
    }
}
