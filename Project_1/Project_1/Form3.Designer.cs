namespace Project_1
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.менюToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(989, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
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
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.менюToolStripMenuItem.BackColor = System.Drawing.Color.RosyBrown;
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записьКлиентаToolStripMenuItem,
            this.расписаниеToolStripMenuItem});
            this.менюToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.менюToolStripMenuItem.ForeColor = System.Drawing.Color.MistyRose;
            this.менюToolStripMenuItem.Image = global::Project_1.Properties.Resources.Frame_11;
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(90, 27);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // записьКлиентаToolStripMenuItem
            // 
            this.записьКлиентаToolStripMenuItem.BackColor = System.Drawing.Color.RosyBrown;
            this.записьКлиентаToolStripMenuItem.Name = "записьКлиентаToolStripMenuItem";
            this.записьКлиентаToolStripMenuItem.Size = new System.Drawing.Size(211, 28);
            this.записьКлиентаToolStripMenuItem.Text = "Запись клиента";
            this.записьКлиентаToolStripMenuItem.Click += new System.EventHandler(this.записьКлиентаToolStripMenuItem_Click);
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.расписаниеToolStripMenuItem.ForeColor = System.Drawing.Color.NavajoWhite;
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(208, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(29, 27);
            this.toolStripMenuItem1.Text = "  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(311, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент успешно записан!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(237, 289);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(516, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Записать клиента";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(989, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записьКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator расписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}