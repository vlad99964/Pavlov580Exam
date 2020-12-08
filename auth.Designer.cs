namespace Exam
{
    partial class auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(auth));
            this.logobox = new System.Windows.Forms.PictureBox();
            this.labellogin = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.Inputlogin = new System.Windows.Forms.TextBox();
            this.Inputpass = new System.Windows.Forms.TextBox();
            this.buttonauth = new System.Windows.Forms.Button();
            this.BoxShow = new System.Windows.Forms.CheckBox();
            this.buttonclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).BeginInit();
            this.SuspendLayout();
            // 
            // logobox
            // 
            this.logobox.Image = ((System.Drawing.Image)(resources.GetObject("logobox.Image")));
            this.logobox.Location = new System.Drawing.Point(134, 12);
            this.logobox.Name = "logobox";
            this.logobox.Size = new System.Drawing.Size(236, 209);
            this.logobox.TabIndex = 0;
            this.logobox.TabStop = false;
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("Comic Sans MS", 10.75F);
            this.labellogin.Location = new System.Drawing.Point(88, 254);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(54, 20);
            this.labellogin.TabIndex = 1;
            this.labellogin.Text = "Логин";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Comic Sans MS", 10.75F);
            this.labelpassword.Location = new System.Drawing.Point(88, 292);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(65, 20);
            this.labelpassword.TabIndex = 2;
            this.labelpassword.Text = "Пароль";
            // 
            // Inputlogin
            // 
            this.Inputlogin.Location = new System.Drawing.Point(192, 252);
            this.Inputlogin.Name = "Inputlogin";
            this.Inputlogin.Size = new System.Drawing.Size(206, 26);
            this.Inputlogin.TabIndex = 3;
            // 
            // Inputpass
            // 
            this.Inputpass.Location = new System.Drawing.Point(192, 290);
            this.Inputpass.Name = "Inputpass";
            this.Inputpass.Size = new System.Drawing.Size(206, 26);
            this.Inputpass.TabIndex = 4;
            this.Inputpass.UseSystemPasswordChar = true;
            // 
            // buttonauth
            // 
            this.buttonauth.Font = new System.Drawing.Font("Comic Sans MS", 11.75F);
            this.buttonauth.Location = new System.Drawing.Point(134, 356);
            this.buttonauth.Name = "buttonauth";
            this.buttonauth.Size = new System.Drawing.Size(100, 32);
            this.buttonauth.TabIndex = 5;
            this.buttonauth.Text = "Вход";
            this.buttonauth.UseVisualStyleBackColor = true;
            this.buttonauth.Click += new System.EventHandler(this.Buttonauth_Click);
            // 
            // BoxShow
            // 
            this.BoxShow.AutoSize = true;
            this.BoxShow.Location = new System.Drawing.Point(265, 322);
            this.BoxShow.Name = "BoxShow";
            this.BoxShow.Size = new System.Drawing.Size(133, 22);
            this.BoxShow.TabIndex = 6;
            this.BoxShow.Text = "Показать пароль";
            this.BoxShow.UseVisualStyleBackColor = true;
            this.BoxShow.CheckedChanged += new System.EventHandler(this.BoxShow_CheckedChanged);
            // 
            // buttonclose
            // 
            this.buttonclose.Font = new System.Drawing.Font("Comic Sans MS", 11.75F);
            this.buttonclose.Location = new System.Drawing.Point(287, 356);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(83, 32);
            this.buttonclose.TabIndex = 7;
            this.buttonclose.Text = "Закрыть";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.Buttonclose_Click);
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 400);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.BoxShow);
            this.Controls.Add(this.buttonauth);
            this.Controls.Add(this.Inputpass);
            this.Controls.Add(this.Inputlogin);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.logobox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лаборатория №20 - Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logobox;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox Inputlogin;
        private System.Windows.Forms.TextBox Inputpass;
        private System.Windows.Forms.Button buttonauth;
        private System.Windows.Forms.CheckBox BoxShow;
        private System.Windows.Forms.Button buttonclose;
    }
}