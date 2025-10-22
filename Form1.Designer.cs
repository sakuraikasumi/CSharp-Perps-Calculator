namespace CSharp_Perps_Calculator
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
            longbutton = new RadioButton();
            shortbutton = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            trackBar1 = new TrackBar();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            label19 = new Label();
            label18 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // longbutton
            // 
            longbutton.Appearance = Appearance.Button;
            longbutton.AutoSize = true;
            longbutton.Cursor = Cursors.Hand;
            longbutton.Dock = DockStyle.Fill;
            longbutton.Location = new Point(6, 9);
            longbutton.Margin = new Padding(3, 6, 3, 3);
            longbutton.Name = "longbutton";
            longbutton.Size = new Size(257, 48);
            longbutton.TabIndex = 0;
            longbutton.TabStop = true;
            longbutton.Text = "做多";
            longbutton.TextAlign = ContentAlignment.MiddleCenter;
            longbutton.UseVisualStyleBackColor = true;
            longbutton.CheckedChanged += longbutton_CheckedChanged;
            // 
            // shortbutton
            // 
            shortbutton.Appearance = Appearance.Button;
            shortbutton.AutoSize = true;
            shortbutton.Cursor = Cursors.Hand;
            shortbutton.Dock = DockStyle.Fill;
            shortbutton.Location = new Point(269, 9);
            shortbutton.Margin = new Padding(3, 6, 3, 3);
            shortbutton.Name = "shortbutton";
            shortbutton.Size = new Size(258, 48);
            shortbutton.TabIndex = 1;
            shortbutton.TabStop = true;
            shortbutton.Text = "做空";
            shortbutton.TextAlign = ContentAlignment.MiddleCenter;
            shortbutton.UseVisualStyleBackColor = true;
            shortbutton.CheckedChanged += shortbutton_CheckedChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(longbutton, 0, 0);
            tableLayoutPanel1.Controls.Add(shortbutton, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(533, 63);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(trackBar1, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 63);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 43.2175369F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3291435F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.4533157F));
            tableLayoutPanel2.Size = new Size(533, 175);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6601944F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.67961F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6601944F));
            tableLayoutPanel3.Controls.Add(button1, 0, 0);
            tableLayoutPanel3.Controls.Add(button2, 2, 0);
            tableLayoutPanel3.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(6, 6);
            tableLayoutPanel3.Margin = new Padding(6);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(3);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(521, 63);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(6, 6);
            button1.Name = "button1";
            button1.Size = new Size(95, 51);
            button1.TabIndex = 0;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(419, 6);
            button2.Name = "button2";
            button2.Size = new Size(96, 51);
            button2.TabIndex = 1;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(107, 12);
            textBox1.Margin = new Padding(3, 9, 3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 38);
            textBox1.TabIndex = 2;
            textBox1.Text = "1x";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // trackBar1
            // 
            trackBar1.Dock = DockStyle.Fill;
            trackBar1.Location = new Point(9, 84);
            trackBar1.Margin = new Padding(9);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(515, 40);
            trackBar1.TabIndex = 6;
            trackBar1.TickFrequency = 25;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(label2, 1, 0);
            tableLayoutPanel4.Controls.Add(label3, 2, 0);
            tableLayoutPanel4.Controls.Add(label4, 3, 0);
            tableLayoutPanel4.Controls.Add(label5, 4, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 136);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(527, 36);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 36);
            label1.TabIndex = 0;
            label1.Text = "1x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(108, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 36);
            label2.TabIndex = 1;
            label2.Text = "  25x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(213, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 36);
            label3.TabIndex = 2;
            label3.Text = "  50x";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(318, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 36);
            label4.TabIndex = 3;
            label4.Text = "      75x";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(423, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 36);
            label5.TabIndex = 4;
            label5.Text = "100x";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Controls.Add(label7, 0, 2);
            tableLayoutPanel5.Controls.Add(label8, 0, 4);
            tableLayoutPanel5.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel5.Controls.Add(textBox3, 0, 3);
            tableLayoutPanel5.Controls.Add(textBox4, 0, 5);
            tableLayoutPanel5.Controls.Add(label12, 1, 1);
            tableLayoutPanel5.Controls.Add(label13, 1, 3);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 238);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4541979F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 19.8791332F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4541979F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 19.8791332F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4541979F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 19.8791332F));
            tableLayoutPanel5.Size = new Size(533, 276);
            tableLayoutPanel5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Location = new Point(12, 3);
            label6.Margin = new Padding(12, 3, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 34);
            label6.TabIndex = 0;
            label6.Text = "开仓价格";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Location = new Point(12, 94);
            label7.Margin = new Padding(12, 3, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 34);
            label7.TabIndex = 1;
            label7.Text = "平仓价格";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Location = new Point(12, 185);
            label8.Margin = new Padding(12, 3, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 34);
            label8.TabIndex = 2;
            label8.Text = "成交数量";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft YaHei UI", 11F);
            textBox2.Location = new Point(50, 40);
            textBox2.Margin = new Padding(50, 3, 3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(391, 45);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft YaHei UI", 11F);
            textBox3.Location = new Point(50, 131);
            textBox3.Margin = new Padding(50, 3, 3, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(391, 45);
            textBox3.TabIndex = 4;
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft YaHei UI", 11F);
            textBox4.Location = new Point(50, 222);
            textBox4.Margin = new Padding(50, 3, 3, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(391, 45);
            textBox4.TabIndex = 5;
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Top;
            label12.Location = new Point(447, 45);
            label12.Margin = new Padding(3, 8, 3, 0);
            label12.Name = "label12";
            label12.Size = new Size(83, 31);
            label12.TabIndex = 6;
            label12.Text = "USD";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Top;
            label13.Location = new Point(447, 136);
            label13.Margin = new Padding(3, 8, 3, 0);
            label13.Name = "label13";
            label13.Size = new Size(83, 31);
            label13.TabIndex = 7;
            label13.Text = "USD";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.42346F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.6660042F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.71173F));
            tableLayoutPanel6.Controls.Add(label19, 1, 2);
            tableLayoutPanel6.Controls.Add(label18, 1, 1);
            tableLayoutPanel6.Controls.Add(label9, 0, 0);
            tableLayoutPanel6.Controls.Add(label10, 0, 1);
            tableLayoutPanel6.Controls.Add(label11, 0, 2);
            tableLayoutPanel6.Controls.Add(label14, 2, 0);
            tableLayoutPanel6.Controls.Add(label15, 2, 1);
            tableLayoutPanel6.Controls.Add(label16, 2, 2);
            tableLayoutPanel6.Controls.Add(label17, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Bottom;
            tableLayoutPanel6.Location = new Point(15, 38);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Size = new Size(503, 154);
            tableLayoutPanel6.TabIndex = 7;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BorderStyle = BorderStyle.Fixed3D;
            label19.Dock = DockStyle.Fill;
            label19.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label19.Location = new Point(151, 105);
            label19.Margin = new Padding(3, 3, 3, 0);
            label19.Name = "label19";
            label19.Size = new Size(274, 49);
            label19.TabIndex = 11;
            label19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BorderStyle = BorderStyle.Fixed3D;
            label18.Dock = DockStyle.Fill;
            label18.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label18.Location = new Point(151, 54);
            label18.Margin = new Padding(3, 3, 3, 0);
            label18.Name = "label18";
            label18.Size = new Size(274, 48);
            label18.TabIndex = 10;
            label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 10);
            label9.Margin = new Padding(3, 10, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(142, 41);
            label9.TabIndex = 0;
            label9.Text = "起始保证金";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(3, 61);
            label10.Margin = new Padding(3, 10, 3, 0);
            label10.Name = "label10";
            label10.Size = new Size(142, 41);
            label10.TabIndex = 1;
            label10.Text = "盈亏";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(3, 112);
            label11.Margin = new Padding(3, 10, 3, 0);
            label11.Name = "label11";
            label11.Size = new Size(142, 42);
            label11.TabIndex = 2;
            label11.Text = "回报率";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Top;
            label14.Location = new Point(431, 12);
            label14.Margin = new Padding(3, 12, 3, 0);
            label14.Name = "label14";
            label14.Size = new Size(69, 31);
            label14.TabIndex = 6;
            label14.Text = "USD";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Top;
            label15.Location = new Point(431, 63);
            label15.Margin = new Padding(3, 12, 3, 0);
            label15.Name = "label15";
            label15.Size = new Size(69, 31);
            label15.TabIndex = 7;
            label15.Text = "USD";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Top;
            label16.Location = new Point(431, 114);
            label16.Margin = new Padding(3, 12, 3, 0);
            label16.Name = "label16";
            label16.Size = new Size(69, 31);
            label16.TabIndex = 8;
            label16.Text = "%";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BorderStyle = BorderStyle.Fixed3D;
            label17.Dock = DockStyle.Fill;
            label17.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            label17.Location = new Point(151, 3);
            label17.Margin = new Padding(3, 3, 3, 0);
            label17.Name = "label17";
            label17.Size = new Size(274, 48);
            label17.TabIndex = 9;
            label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel6);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 514);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15);
            groupBox1.Size = new Size(533, 207);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "计算结果";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Microsoft YaHei UI", 10F);
            button3.Location = new Point(114, 738);
            button3.Name = "button3";
            button3.Size = new Size(306, 74);
            button3.TabIndex = 9;
            button3.Text = "计算";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 824);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "合约计算器";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RadioButton longbutton;
        private RadioButton shortbutton;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TrackBar trackBar1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label9;
        private Label label10;
        private Label label11;
        private GroupBox groupBox1;
        private Label label12;
        private Label label13;
        private Label label19;
        private Label label18;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Button button3;
    }
}
