namespace task2
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
            button1 = new Button();
            Number1 = new TextBox();
            Number2 = new TextBox();
            Result = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.AutoSize = true;
            button1.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(365, 325);
            button1.Name = "button1";
            button1.Size = new Size(218, 51);
            button1.TabIndex = 0;
            button1.Text = "计算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Number1
            // 
            Number1.Anchor = AnchorStyles.Left;
            Number1.Cursor = Cursors.IBeam;
            Number1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Number1.Location = new Point(204, 163);
            Number1.MaxLength = 10;
            Number1.Multiline = true;
            Number1.Name = "Number1";
            Number1.Size = new Size(100, 45);
            Number1.TabIndex = 1;
            // 
            // Number2
            // 
            Number2.Anchor = AnchorStyles.Top;
            Number2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Number2.Location = new Point(423, 163);
            Number2.MaxLength = 10;
            Number2.Multiline = true;
            Number2.Name = "Number2";
            Number2.Size = new Size(100, 45);
            Number2.TabIndex = 2;
            // 
            // Result
            // 
            Result.Anchor = AnchorStyles.Right;
            Result.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Result.Location = new Point(655, 163);
            Result.MaxLength = 12;
            Result.Multiline = true;
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Size = new Size(287, 45);
            Result.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(204, 120);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 4;
            label1.Text = "Number1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(423, 120);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 5;
            label2.Text = "Number2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(655, 120);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 6;
            label3.Text = "Result:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(576, 170);
            label4.Name = "label4";
            label4.Size = new Size(28, 28);
            label4.TabIndex = 7;
            label4.Text = "=";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(341, 168);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(47, 39);
            comboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 543);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Result);
            Controls.Add(Number2);
            Controls.Add(Number1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Number1;
        private TextBox Number2;
        private TextBox Result;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
    }
}
