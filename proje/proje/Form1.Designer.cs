namespace proje
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.control = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.register1 = new proje.Register();
            this.login1 = new proje.Login();
            this.control.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(41, 205);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(284, 42);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(41, 290);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(284, 43);
            this.register_button.TabIndex = 1;
            this.register_button.Text = "REGISTR";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(71, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME";
            // 
            // control
            // 
            this.control.Controls.Add(this.label1);
            this.control.Controls.Add(this.login_button);
            this.control.Controls.Add(this.register_button);
            this.control.Location = new System.Drawing.Point(12, 12);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(370, 523);
            this.control.TabIndex = 4;
            this.control.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("ali.Image")));
            this.label2.Location = new System.Drawing.Point(389, 16);
            this.label2.Name = "ali";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // register1
            // 
            this.register1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.register1.ForeColor = System.Drawing.Color.Black;
            this.register1.Location = new System.Drawing.Point(388, 32);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(400, 490);
            this.register1.TabIndex = 6;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.login1.Location = new System.Drawing.Point(388, 58);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(400, 412);
            this.login1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.control);
            this.Controls.Add(this.login1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.control.ResumeLayout(false);
            this.control.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label label1;
        private Login login1;
        private System.Windows.Forms.GroupBox control;
        private System.Windows.Forms.Label label2;
        private Register register1;
    }
}

