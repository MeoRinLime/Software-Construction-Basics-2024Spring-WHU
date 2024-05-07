namespace OrderManage
{
    partial class UpdateForm
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
            UpdateCostomerLabel = new Label();
            UpdateOrderIDLabel = new Label();
            UpdateOrderIDText = new TextBox();
            UpdateCostomerTextBox = new TextBox();
            UpdateOrderDetailsComboBox = new ComboBox();
            UpdateDetailsLabel = new Label();
            SaveButton = new Button();
            BackButton = new Button();
            UpdateQuantityLabel = new Label();
            UpdateQuantityTextBox = new TextBox();
            SuspendLayout();
            // 
            // UpdateCostomerLabel
            // 
            UpdateCostomerLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpdateCostomerLabel.Location = new Point(180, 292);
            UpdateCostomerLabel.Margin = new Padding(4, 0, 4, 0);
            UpdateCostomerLabel.Name = "UpdateCostomerLabel";
            UpdateCostomerLabel.Size = new Size(229, 60);
            UpdateCostomerLabel.TabIndex = 0;
            UpdateCostomerLabel.Text = "客户:";
            // 
            // UpdateOrderIDLabel
            // 
            UpdateOrderIDLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpdateOrderIDLabel.Location = new Point(180, 168);
            UpdateOrderIDLabel.Margin = new Padding(4, 0, 4, 0);
            UpdateOrderIDLabel.Name = "UpdateOrderIDLabel";
            UpdateOrderIDLabel.Size = new Size(229, 60);
            UpdateOrderIDLabel.TabIndex = 1;
            UpdateOrderIDLabel.Text = "订单号:";
            // 
            // UpdateOrderIDText
            // 
            UpdateOrderIDText.Location = new Point(517, 165);
            UpdateOrderIDText.Margin = new Padding(4);
            UpdateOrderIDText.Name = "UpdateOrderIDText";
            UpdateOrderIDText.ReadOnly = true;
            UpdateOrderIDText.Size = new Size(256, 43);
            UpdateOrderIDText.TabIndex = 2;
            // 
            // UpdateCostomerTextBox
            // 
            UpdateCostomerTextBox.Location = new Point(517, 292);
            UpdateCostomerTextBox.Margin = new Padding(4);
            UpdateCostomerTextBox.Name = "UpdateCostomerTextBox";
            UpdateCostomerTextBox.Size = new Size(256, 43);
            UpdateCostomerTextBox.TabIndex = 3;
            // 
            // UpdateOrderDetailsComboBox
            // 
            UpdateOrderDetailsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateOrderDetailsComboBox.FormattingEnabled = true;
            UpdateOrderDetailsComboBox.ImeMode = ImeMode.Disable;
            UpdateOrderDetailsComboBox.Location = new Point(517, 419);
            UpdateOrderDetailsComboBox.Margin = new Padding(4);
            UpdateOrderDetailsComboBox.Name = "UpdateOrderDetailsComboBox";
            UpdateOrderDetailsComboBox.Size = new Size(430, 45);
            UpdateOrderDetailsComboBox.TabIndex = 4;
            // 
            // UpdateDetailsLabel
            // 
            UpdateDetailsLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpdateDetailsLabel.Location = new Point(180, 419);
            UpdateDetailsLabel.Margin = new Padding(4, 0, 4, 0);
            UpdateDetailsLabel.Name = "UpdateDetailsLabel";
            UpdateDetailsLabel.Size = new Size(229, 60);
            UpdateDetailsLabel.TabIndex = 5;
            UpdateDetailsLabel.Text = "具体商品：";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(592, 672);
            SaveButton.Margin = new Padding(4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(181, 58);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "确认";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(228, 672);
            BackButton.Margin = new Padding(4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(181, 58);
            BackButton.TabIndex = 7;
            BackButton.Text = "返回";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // UpdateQuantityLabel
            // 
            UpdateQuantityLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpdateQuantityLabel.Location = new Point(180, 526);
            UpdateQuantityLabel.Margin = new Padding(4, 0, 4, 0);
            UpdateQuantityLabel.Name = "UpdateQuantityLabel";
            UpdateQuantityLabel.Size = new Size(229, 60);
            UpdateQuantityLabel.TabIndex = 8;
            UpdateQuantityLabel.Text = "数量：";
            // 
            // UpdateQuantityTextBox
            // 
            UpdateQuantityTextBox.Location = new Point(517, 526);
            UpdateQuantityTextBox.Margin = new Padding(4);
            UpdateQuantityTextBox.Name = "UpdateQuantityTextBox";
            UpdateQuantityTextBox.Size = new Size(256, 43);
            UpdateQuantityTextBox.TabIndex = 9;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(18F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 870);
            Controls.Add(UpdateQuantityTextBox);
            Controls.Add(UpdateQuantityLabel);
            Controls.Add(BackButton);
            Controls.Add(SaveButton);
            Controls.Add(UpdateDetailsLabel);
            Controls.Add(UpdateOrderDetailsComboBox);
            Controls.Add(UpdateCostomerTextBox);
            Controls.Add(UpdateOrderIDText);
            Controls.Add(UpdateOrderIDLabel);
            Controls.Add(UpdateCostomerLabel);
            Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            Margin = new Padding(4);
            Name = "UpdateForm";
            Text = "修改订单";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UpdateCostomerLabel;
        private Label UpdateOrderIDLabel;
        private TextBox UpdateOrderIDText;
        private TextBox UpdateCostomerTextBox;
        private ComboBox UpdateOrderDetailsComboBox;
        private Label UpdateDetailsLabel;
        private Button SaveButton;
        private Button BackButton;
        private Label UpdateQuantityLabel;
        private TextBox UpdateQuantityTextBox;
    }
}