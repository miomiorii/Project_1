namespace Project_1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.password = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.invite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.autorization = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.MistyRose;
            this.password.ForeColor = System.Drawing.Color.SaddleBrown;
            this.password.Location = new System.Drawing.Point(176, 295);
            this.password.Name = "password";
            this.password.PasswordChar = '-';
            this.password.Size = new System.Drawing.Size(401, 20);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox1.Location = new System.Drawing.Point(176, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // invite
            // 
            this.invite.BackColor = System.Drawing.Color.RosyBrown;
            this.invite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.invite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invite.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invite.ForeColor = System.Drawing.Color.MistyRose;
            this.invite.Location = new System.Drawing.Point(176, 353);
            this.invite.Name = "invite";
            this.invite.Size = new System.Drawing.Size(401, 49);
            this.invite.TabIndex = 5;
            this.invite.Text = "Войти";
            this.invite.UseVisualStyleBackColor = false;
            this.invite.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(179, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пароль:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // autorization
            // 
            this.autorization.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.autorization.AutoSize = true;
            this.autorization.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.autorization.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorization.ForeColor = System.Drawing.Color.DarkBlue;
            this.autorization.Location = new System.Drawing.Point(278, 197);
            this.autorization.Name = "autorization";
            this.autorization.Size = new System.Drawing.Size(0, 45);
            this.autorization.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(179, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 44);
            this.label2.TabIndex = 9;
            this.label2.Text = "Логин:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // logo
            // 
            this.logo.Image = global::Project_1.Properties.Resources.Frame_11;
            this.logo.Location = new System.Drawing.Point(261, 54);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(200, 99);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(742, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.autorization);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.invite);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.password);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button invite;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label autorization;
        private System.Windows.Forms.Label label2;
    }
}

