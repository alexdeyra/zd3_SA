namespace UP_lesson1_z3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            добавитьПеснюToolStripMenuItem = new ToolStripMenuItem();
            плэйлистToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            listBoxSongs = new ListBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьПеснюToolStripMenuItem, плэйлистToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1182, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // добавитьПеснюToolStripMenuItem
            // 
            добавитьПеснюToolStripMenuItem.Name = "добавитьПеснюToolStripMenuItem";
            добавитьПеснюToolStripMenuItem.Size = new Size(139, 24);
            добавитьПеснюToolStripMenuItem.Text = "Добавить песню";
            добавитьПеснюToolStripMenuItem.Click += добавитьПеснюToolStripMenuItem_Click;
            // 
            // плэйлистToolStripMenuItem
            // 
            плэйлистToolStripMenuItem.Name = "плэйлистToolStripMenuItem";
            плэйлистToolStripMenuItem.Size = new Size(88, 24);
            плэйлистToolStripMenuItem.Text = "Плэйлист";
            плэйлистToolStripMenuItem.Click += плэйлистToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Brown;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "Автор:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Brown;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 2;
            label2.Text = "Название композиции:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Brown;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 185);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 3;
            label3.Text = "Путь к файлу:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 208);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 241);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Brown;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(403, 55);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 8;
            label4.Text = "Текущая песня";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Brown;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(423, 93);
            label5.Name = "label5";
            label5.Size = new Size(13, 20);
            label5.TabIndex = 9;
            label5.Text = "l";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(462, 136);
            button2.Name = "button2";
            button2.Size = new Size(82, 30);
            button2.TabIndex = 10;
            button2.Text = "След";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(370, 136);
            button3.Name = "button3";
            button3.Size = new Size(82, 30);
            button3.TabIndex = 11;
            button3.Text = "Предыд";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Brown;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(423, 353);
            label6.Name = "label6";
            label6.Size = new Size(164, 20);
            label6.TabIndex = 12;
            label6.Text = "Введите номер песни:";
            label6.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(475, 376);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(79, 27);
            textBox4.TabIndex = 13;
            textBox4.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(423, 409);
            button4.Name = "button4";
            button4.Size = new Size(174, 29);
            button4.TabIndex = 14;
            button4.Text = "Вывести";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Maroon;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(423, 479);
            button5.Name = "button5";
            button5.Size = new Size(174, 31);
            button5.TabIndex = 15;
            button5.Text = "В начало плэйлиста";
            button5.UseVisualStyleBackColor = false;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Brown;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(901, 96);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 16;
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Brown;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(605, 56);
            label8.Name = "label8";
            label8.Size = new Size(267, 20);
            label8.TabIndex = 17;
            label8.Text = "Введите номер песни для удалиения";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Brown;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(605, 93);
            label9.Name = "label9";
            label9.Size = new Size(171, 20);
            label9.TabIndex = 18;
            label9.Text = "или нажмите на песню";
            label9.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(878, 56);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 19;
            textBox5.Visible = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Maroon;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(1019, 55);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 20;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = false;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Maroon;
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(423, 444);
            button7.Name = "button7";
            button7.Size = new Size(174, 29);
            button7.TabIndex = 21;
            button7.Text = "Удалить плэйлист";
            button7.UseVisualStyleBackColor = false;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // listBoxSongs
            // 
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.Location = new Point(605, 166);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(565, 344);
            listBoxSongs.TabIndex = 22;
            listBoxSongs.SelectedIndexChanged += listBoxSongs_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(814, 96);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 23;
            label10.Text = "Автор";
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(814, 116);
            label11.Name = "label11";
            label11.Size = new Size(77, 20);
            label11.TabIndex = 24;
            label11.Text = "Название";
            label11.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(814, 136);
            label12.Name = "label12";
            label12.Size = new Size(41, 20);
            label12.TabIndex = 25;
            label12.Text = "Путь";
            label12.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(1182, 526);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(listBoxSongs);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ButtonHighlight;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьПеснюToolStripMenuItem;
        private ToolStripMenuItem плэйлистToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button3;
        private Label label6;
        private TextBox textBox4;
        private Button button4;
        private Button button5;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox5;
        private Button button6;
        private Button button7;
        private ListBox listBoxSongs;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
