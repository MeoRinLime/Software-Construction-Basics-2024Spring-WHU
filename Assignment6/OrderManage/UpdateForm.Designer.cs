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
            SuspendLayout();
            // 
            // UpdateCostomerLabel
            // 
            UpdateCostomerLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpdateCostomerLabel.Location = new Point(140, 245);
            UpdateCostomerLabel.Name = "UpdateCostomerLabel";
            UpdateCostomerLabel.Size = new Size(178, 50);
            UpdateCostomerLabel.TabIndex = 0;
            UpdateCostomerLabel.Text = "客户:";
            // 
            // UpdateOrderIDLabel
            // 
            UpdateOrderIDLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpdateOrderIDLabel.Location = new Point(140, 141);
            UpdateOrderIDLabel.Name = "UpdateOrderIDLabel";
            UpdateOrderIDLabel.Size = new Size(178, 50);
            UpdateOrderIDLabel.TabIndex = 1;
            UpdateOrderIDLabel.Text = "订单号:";
            // 
            // UpdateOrderIDText
            // 
            UpdateOrderIDText.Location = new Point(402, 138);
            UpdateOrderIDText.Name = "UpdateOrderIDText";
            UpdateOrderIDText.ReadOnly = true;
            UpdateOrderIDText.Size = new Size(200, 38);
            UpdateOrderIDText.TabIndex = 2;
            // 
            // UpdateCostomerTextBox
            // 
            UpdateCostomerTextBox.Location = new Point(402, 245);
            UpdateCostomerTextBox.Name = "UpdateCostomerTextBox";
            UpdateCostomerTextBox.Size = new Size(200, 38);
            UpdateCostomerTextBox.TabIndex = 3;
            // 
            // UpdateOrderDetailsComboBox
            // 
            UpdateOrderDetailsComboBox.FormattingEnabled = true;
            UpdateOrderDetailsComboBox.Location = new Point(402, 351);
            UpdateOrderDetailsComboBox.Name = "UpdateOrderDetailsComboBox";
            UpdateOrderDetailsComboBox.Size = new Size(242, 39);
            UpdateOrderDetailsComboBox.TabIndex = 4;
            // 
            // UpdateDetailsLabel
            // 
            UpdateDetailsLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpdateDetailsLabel.Location = new Point(140, 351);
            UpdateDetailsLabel.Name = "UpdateDetailsLabel";
            UpdateDetailsLabel.Size = new Size(178, 50);
            UpdateDetailsLabel.TabIndex = 5;
            UpdateDetailsLabel.Text = "具体商品：";
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 729);
            Controls.Add(UpdateDetailsLabel);
            Controls.Add(UpdateOrderDetailsComboBox);
            Controls.Add(UpdateCostomerTextBox);
            Controls.Add(UpdateOrderIDText);
            Controls.Add(UpdateOrderIDLabel);
            Controls.Add(UpdateCostomerLabel);
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
    }
}