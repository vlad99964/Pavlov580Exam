namespace Exam
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.buttonexit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonotchet = new System.Windows.Forms.Button();
            this.buttondata = new System.Windows.Forms.Button();
            this.buttonhistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(367, 81);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(75, 23);
            this.buttonexit.TabIndex = 0;
            this.buttonexit.Text = "Выход";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.Buttonexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(367, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonotchet
            // 
            this.buttonotchet.Font = new System.Drawing.Font("Comic Sans MS", 13.75F);
            this.buttonotchet.Location = new System.Drawing.Point(78, 139);
            this.buttonotchet.Name = "buttonotchet";
            this.buttonotchet.Size = new System.Drawing.Size(325, 103);
            this.buttonotchet.TabIndex = 2;
            this.buttonotchet.Text = "Сформировать отчет";
            this.buttonotchet.UseVisualStyleBackColor = true;
            // 
            // buttondata
            // 
            this.buttondata.Font = new System.Drawing.Font("Comic Sans MS", 13.75F);
            this.buttondata.Location = new System.Drawing.Point(78, 273);
            this.buttondata.Name = "buttondata";
            this.buttondata.Size = new System.Drawing.Size(325, 103);
            this.buttondata.TabIndex = 3;
            this.buttondata.Text = "Работа с расходными данными";
            this.buttondata.UseVisualStyleBackColor = true;
            // 
            // buttonhistory
            // 
            this.buttonhistory.Font = new System.Drawing.Font("Comic Sans MS", 13.75F);
            this.buttonhistory.Location = new System.Drawing.Point(78, 412);
            this.buttonhistory.Name = "buttonhistory";
            this.buttonhistory.Size = new System.Drawing.Size(325, 103);
            this.buttonhistory.TabIndex = 4;
            this.buttonhistory.Text = "Проверить историю входа";
            this.buttonhistory.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 567);
            this.Controls.Add(this.buttonhistory);
            this.Controls.Add(this.buttondata);
            this.Controls.Add(this.buttonotchet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonexit);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лаборатория №20 - Администатор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonotchet;
        private System.Windows.Forms.Button buttondata;
        private System.Windows.Forms.Button buttonhistory;
    }
}