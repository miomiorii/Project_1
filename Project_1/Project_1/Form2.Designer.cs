namespace Project_1
{
    partial class Form2
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
            this.fio_client_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dates_text = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phone_number_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.email_text = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.fio_master_text = new System.Windows.Forms.TextBox();
            this.times_text = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fio_client_text
            // 
            this.fio_client_text.BackColor = System.Drawing.Color.MistyRose;
            this.fio_client_text.Location = new System.Drawing.Point(504, 246);
            this.fio_client_text.Margin = new System.Windows.Forms.Padding(4);
            this.fio_client_text.Name = "fio_client_text";
            this.fio_client_text.Size = new System.Drawing.Size(260, 22);
            this.fio_client_text.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(124, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Запись клиента";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(127, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Время записи";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dates_text
            // 
            this.dates_text.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dates_text.CalendarTitleBackColor = System.Drawing.Color.MistyRose;
            this.dates_text.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
            this.dates_text.CalendarTrailingForeColor = System.Drawing.Color.SaddleBrown;
            this.dates_text.Location = new System.Drawing.Point(133, 389);
            this.dates_text.Margin = new System.Windows.Forms.Padding(4);
            this.dates_text.Name = "dates_text";
            this.dates_text.Size = new System.Drawing.Size(256, 22);
            this.dates_text.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(127, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Мастер";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(497, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Данные клиента";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(497, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Имя клиента";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(497, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "Номер телефона";
            // 
            // phone_number_text
            // 
            this.phone_number_text.BackColor = System.Drawing.Color.MistyRose;
            this.phone_number_text.Location = new System.Drawing.Point(504, 329);
            this.phone_number_text.Margin = new System.Windows.Forms.Padding(4);
            this.phone_number_text.Name = "phone_number_text";
            this.phone_number_text.Size = new System.Drawing.Size(260, 22);
            this.phone_number_text.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(497, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Адрес электронной почты";
            // 
            // email_text
            // 
            this.email_text.BackColor = System.Drawing.Color.MistyRose;
            this.email_text.Location = new System.Drawing.Point(504, 415);
            this.email_text.Margin = new System.Windows.Forms.Padding(4);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(360, 22);
            this.email_text.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.MistyRose;
            this.button2.Location = new System.Drawing.Point(134, 464);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(730, 56);
            this.button2.TabIndex = 17;
            this.button2.Text = "Записать!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(127, 228);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 36);
            this.label8.TabIndex = 18;
            this.label8.Text = "ФИО";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem4});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(989, 31);
            this.menuStrip2.TabIndex = 20;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.MistyRose;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(133, 27);
            this.toolStripTextBox1.Text = "Nailify CRM";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.RosyBrown;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator1});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.MistyRose;
            this.toolStripMenuItem1.Image = global::Project_1.Properties.Resources.Frame_11;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(90, 27);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.RosyBrown;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 28);
            this.toolStripMenuItem2.Text = "Запись клиента";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.RosyBrown;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.RosyBrown;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(29, 27);
            this.toolStripMenuItem4.Text = "  ";
            // 
            // fio_master_text
            // 
            this.fio_master_text.BackColor = System.Drawing.Color.MistyRose;
            this.fio_master_text.Location = new System.Drawing.Point(134, 271);
            this.fio_master_text.Margin = new System.Windows.Forms.Padding(4);
            this.fio_master_text.Name = "fio_master_text";
            this.fio_master_text.Size = new System.Drawing.Size(260, 22);
            this.fio_master_text.TabIndex = 21;
            // 
            // times_text
            // 
            this.times_text.BackColor = System.Drawing.Color.MistyRose;
            this.times_text.Location = new System.Drawing.Point(133, 356);
            this.times_text.Margin = new System.Windows.Forms.Padding(4);
            this.times_text.Name = "times_text";
            this.times_text.Size = new System.Drawing.Size(260, 22);
            this.times_text.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(989, 559);
            this.Controls.Add(this.times_text);
            this.Controls.Add(this.fio_master_text);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phone_number_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dates_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fio_client_text);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fio_client_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dates_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phone_number_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.TextBox fio_master_text;
        private System.Windows.Forms.TextBox times_text;
    }
}