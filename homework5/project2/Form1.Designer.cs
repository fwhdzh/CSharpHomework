namespace project2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label4;
            this.button1 = new System.Windows.Forms.Button();
            this.textTh1 = new System.Windows.Forms.TextBox();
            this.textK = new System.Windows.Forms.TextBox();
            this.textTh2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupColor = new System.Windows.Forms.GroupBox();
            this.rButtonBlue = new System.Windows.Forms.RadioButton();
            this.rButtonYellow = new System.Windows.Forms.RadioButton();
            this.rButtonRed = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textPer2 = new System.Windows.Forms.TextBox();
            this.textPer1 = new System.Windows.Forms.TextBox();
            this.textWid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            this.groupColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(549, 301);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 18);
            label4.TabIndex = 9;
            label4.Text = "位置系数";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(560, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textTh1
            // 
            this.textTh1.Location = new System.Drawing.Point(644, 94);
            this.textTh1.Name = "textTh1";
            this.textTh1.Size = new System.Drawing.Size(100, 28);
            this.textTh1.TabIndex = 1;
            this.textTh1.Text = "35";
            this.textTh1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textK
            // 
            this.textK.Location = new System.Drawing.Point(644, 298);
            this.textK.Name = "textK";
            this.textK.Size = new System.Drawing.Size(100, 28);
            this.textK.TabIndex = 3;
            this.textK.Text = "1";
            this.textK.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textTh2
            // 
            this.textTh2.Location = new System.Drawing.Point(644, 142);
            this.textTh2.Name = "textTh2";
            this.textTh2.Size = new System.Drawing.Size(100, 28);
            this.textTh2.TabIndex = 5;
            this.textTh2.Text = "30";
            this.textTh2.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "角度1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "角度2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "粗细";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // groupColor
            // 
            this.groupColor.Controls.Add(this.rButtonBlue);
            this.groupColor.Controls.Add(this.rButtonYellow);
            this.groupColor.Controls.Add(this.rButtonRed);
            this.groupColor.Location = new System.Drawing.Point(560, 395);
            this.groupColor.Name = "groupColor";
            this.groupColor.Size = new System.Drawing.Size(197, 101);
            this.groupColor.TabIndex = 13;
            this.groupColor.TabStop = false;
            this.groupColor.Text = "颜色";
            this.groupColor.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rButtonBlue
            // 
            this.rButtonBlue.AutoSize = true;
            this.rButtonBlue.Checked = true;
            this.rButtonBlue.Location = new System.Drawing.Point(66, 70);
            this.rButtonBlue.Name = "rButtonBlue";
            this.rButtonBlue.Size = new System.Drawing.Size(69, 22);
            this.rButtonBlue.TabIndex = 15;
            this.rButtonBlue.TabStop = true;
            this.rButtonBlue.Text = "蓝色";
            this.rButtonBlue.UseVisualStyleBackColor = true;
            // 
            // rButtonYellow
            // 
            this.rButtonYellow.AutoSize = true;
            this.rButtonYellow.Location = new System.Drawing.Point(66, 42);
            this.rButtonYellow.Name = "rButtonYellow";
            this.rButtonYellow.Size = new System.Drawing.Size(69, 22);
            this.rButtonYellow.TabIndex = 14;
            this.rButtonYellow.Text = "黄色";
            this.rButtonYellow.UseVisualStyleBackColor = true;
            this.rButtonYellow.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rButtonRed
            // 
            this.rButtonRed.AutoSize = true;
            this.rButtonRed.Location = new System.Drawing.Point(66, 13);
            this.rButtonRed.Name = "rButtonRed";
            this.rButtonRed.Size = new System.Drawing.Size(69, 22);
            this.rButtonRed.TabIndex = 13;
            this.rButtonRed.Text = "红色";
            this.rButtonRed.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "长度2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "长度1";
            // 
            // textPer2
            // 
            this.textPer2.Location = new System.Drawing.Point(644, 244);
            this.textPer2.Name = "textPer2";
            this.textPer2.Size = new System.Drawing.Size(100, 28);
            this.textPer2.TabIndex = 15;
            this.textPer2.Text = "0.7";
            // 
            // textPer1
            // 
            this.textPer1.Location = new System.Drawing.Point(644, 196);
            this.textPer1.Name = "textPer1";
            this.textPer1.Size = new System.Drawing.Size(100, 28);
            this.textPer1.TabIndex = 14;
            this.textPer1.Text = "0.6";
            // 
            // textWid
            // 
            this.textWid.Location = new System.Drawing.Point(644, 351);
            this.textWid.Name = "textWid";
            this.textWid.Size = new System.Drawing.Size(100, 28);
            this.textWid.TabIndex = 2;
            this.textWid.Text = "1";
            this.textWid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(663, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "随机";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 517);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPer2);
            this.Controls.Add(this.textPer1);
            this.Controls.Add(this.groupColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTh2);
            this.Controls.Add(this.textK);
            this.Controls.Add(this.textWid);
            this.Controls.Add(this.textTh1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupColor.ResumeLayout(false);
            this.groupColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textTh1;
        private System.Windows.Forms.TextBox textK;
        private System.Windows.Forms.TextBox textTh2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupColor;
        private System.Windows.Forms.RadioButton rButtonBlue;
        private System.Windows.Forms.RadioButton rButtonYellow;
        private System.Windows.Forms.RadioButton rButtonRed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPer2;
        private System.Windows.Forms.TextBox textPer1;
        private System.Windows.Forms.TextBox textWid;
        private System.Windows.Forms.Button button2;
    }
}

