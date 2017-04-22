namespace Lines_Circles_AA
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xiaolinCircleButton = new System.Windows.Forms.Button();
            this.xiaolinLineButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.midPointCircleButton = new System.Windows.Forms.Button();
            this.thicknessTextBox = new System.Windows.Forms.TextBox();
            this.symmetricMidPointLineButton = new System.Windows.Forms.Button();
            this.clickIndicatorLabel = new System.Windows.Forms.Label();
            this.clickIndicatorBox = new System.Windows.Forms.TextBox();
            this.pointRecordButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aCoordinateLabel = new System.Windows.Forms.Label();
            this.bCoordinateLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.thicknessLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(695, 551);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xiaolinCircleButton);
            this.panel1.Controls.Add(this.xiaolinLineButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.midPointCircleButton);
            this.panel1.Controls.Add(this.thicknessTextBox);
            this.panel1.Controls.Add(this.symmetricMidPointLineButton);
            this.panel1.Location = new System.Drawing.Point(713, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 261);
            this.panel1.TabIndex = 1;
            // 
            // xiaolinCircleButton
            // 
            this.xiaolinCircleButton.Location = new System.Drawing.Point(4, 196);
            this.xiaolinCircleButton.Name = "xiaolinCircleButton";
            this.xiaolinCircleButton.Size = new System.Drawing.Size(204, 23);
            this.xiaolinCircleButton.TabIndex = 7;
            this.xiaolinCircleButton.Text = "Circle";
            this.xiaolinCircleButton.UseVisualStyleBackColor = true;
            this.xiaolinCircleButton.Click += new System.EventHandler(this.xiaolinCircleButton_Click);
            // 
            // xiaolinLineButton
            // 
            this.xiaolinLineButton.Location = new System.Drawing.Point(4, 166);
            this.xiaolinLineButton.Name = "xiaolinLineButton";
            this.xiaolinLineButton.Size = new System.Drawing.Size(204, 23);
            this.xiaolinLineButton.TabIndex = 6;
            this.xiaolinLineButton.Text = "Line";
            this.xiaolinLineButton.UseVisualStyleBackColor = true;
            this.xiaolinLineButton.Click += new System.EventHandler(this.xiaolinLineButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Circle And Lines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thickness";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Xiaolin Wu Anti-Aliasing";
            // 
            // midPointCircleButton
            // 
            this.midPointCircleButton.Location = new System.Drawing.Point(4, 97);
            this.midPointCircleButton.Name = "midPointCircleButton";
            this.midPointCircleButton.Size = new System.Drawing.Size(204, 23);
            this.midPointCircleButton.TabIndex = 2;
            this.midPointCircleButton.Text = "Mid Point Circle(w/ Multiplication)";
            this.midPointCircleButton.UseVisualStyleBackColor = true;
            this.midPointCircleButton.Click += new System.EventHandler(this.midPointCircleButton_Click);
            // 
            // thicknessTextBox
            // 
            this.thicknessTextBox.Location = new System.Drawing.Point(65, 42);
            this.thicknessTextBox.Name = "thicknessTextBox";
            this.thicknessTextBox.Size = new System.Drawing.Size(43, 20);
            this.thicknessTextBox.TabIndex = 1;
            this.thicknessTextBox.Text = "1";
            this.thicknessTextBox.TextChanged += new System.EventHandler(this.thicknessTextBox_TextChanged);
            // 
            // symmetricMidPointLineButton
            // 
            this.symmetricMidPointLineButton.Location = new System.Drawing.Point(4, 68);
            this.symmetricMidPointLineButton.Name = "symmetricMidPointLineButton";
            this.symmetricMidPointLineButton.Size = new System.Drawing.Size(204, 23);
            this.symmetricMidPointLineButton.TabIndex = 0;
            this.symmetricMidPointLineButton.Text = "Symmetric Midpoint Line";
            this.symmetricMidPointLineButton.UseVisualStyleBackColor = true;
            this.symmetricMidPointLineButton.Click += new System.EventHandler(this.symmetricMidPointLineButton_Click);
            // 
            // clickIndicatorLabel
            // 
            this.clickIndicatorLabel.AutoSize = true;
            this.clickIndicatorLabel.Location = new System.Drawing.Point(3, 107);
            this.clickIndicatorLabel.Name = "clickIndicatorLabel";
            this.clickIndicatorLabel.Size = new System.Drawing.Size(113, 13);
            this.clickIndicatorLabel.TabIndex = 2;
            this.clickIndicatorLabel.Text = "Number Of Clicks Left:";
            // 
            // clickIndicatorBox
            // 
            this.clickIndicatorBox.Location = new System.Drawing.Point(122, 100);
            this.clickIndicatorBox.Name = "clickIndicatorBox";
            this.clickIndicatorBox.Size = new System.Drawing.Size(35, 20);
            this.clickIndicatorBox.TabIndex = 3;
            this.clickIndicatorBox.Text = "0";
            // 
            // pointRecordButton
            // 
            this.pointRecordButton.Location = new System.Drawing.Point(65, 135);
            this.pointRecordButton.Name = "pointRecordButton";
            this.pointRecordButton.Size = new System.Drawing.Size(75, 23);
            this.pointRecordButton.TabIndex = 4;
            this.pointRecordButton.Text = "Record Points";
            this.pointRecordButton.UseVisualStyleBackColor = true;
            this.pointRecordButton.Click += new System.EventHandler(this.pointRecordButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "B:";
            // 
            // aCoordinateLabel
            // 
            this.aCoordinateLabel.AutoSize = true;
            this.aCoordinateLabel.Location = new System.Drawing.Point(22, 31);
            this.aCoordinateLabel.Name = "aCoordinateLabel";
            this.aCoordinateLabel.Size = new System.Drawing.Size(80, 13);
            this.aCoordinateLabel.TabIndex = 7;
            this.aCoordinateLabel.Text = "A\'s Coordinates";
            // 
            // bCoordinateLabel
            // 
            this.bCoordinateLabel.AutoSize = true;
            this.bCoordinateLabel.Location = new System.Drawing.Point(22, 67);
            this.bCoordinateLabel.Name = "bCoordinateLabel";
            this.bCoordinateLabel.Size = new System.Drawing.Size(80, 13);
            this.bCoordinateLabel.TabIndex = 8;
            this.bCoordinateLabel.Text = "B\'s Coordinates";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.thicknessLabel);
            this.panel2.Controls.Add(this.pointRecordButton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.clickIndicatorBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.clickIndicatorLabel);
            this.panel2.Controls.Add(this.bCoordinateLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.aCoordinateLabel);
            this.panel2.Location = new System.Drawing.Point(713, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 161);
            this.panel2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Thickness:";
            // 
            // thicknessLabel
            // 
            this.thicknessLabel.AutoSize = true;
            this.thicknessLabel.Location = new System.Drawing.Point(62, 4);
            this.thicknessLabel.Name = "thicknessLabel";
            this.thicknessLabel.Size = new System.Drawing.Size(0, 13);
            this.thicknessLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
       
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button xiaolinCircleButton;
        private System.Windows.Forms.Button xiaolinLineButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button midPointCircleButton;
        private System.Windows.Forms.TextBox thicknessTextBox;
        private System.Windows.Forms.Button symmetricMidPointLineButton;
        private System.Windows.Forms.Label clickIndicatorLabel;
        private System.Windows.Forms.TextBox clickIndicatorBox;
        private System.Windows.Forms.Button pointRecordButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label aCoordinateLabel;
        private System.Windows.Forms.Label bCoordinateLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label thicknessLabel;
        private System.Windows.Forms.Label label6;
    }
}

