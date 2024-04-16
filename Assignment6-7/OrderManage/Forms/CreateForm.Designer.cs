namespace OrderManage
{
    partial class CreateForm
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
            CreateDetailsLabel = new Label();
            CreateCostomerLabel = new Label();
            CreateCostomerTextBox = new TextBox();
            CreateGoodsComboBox = new ComboBox();
            CreateGoodsQuantityLabel = new Label();
            CreateGoodsQuantityTextBox = new TextBox();
            CreateConfirmButton = new Button();
            CreateBackButton = new Button();
            CreateGoodsListBox = new ListBox();
            CreateAddButton = new Button();
            CreateRemoveButton = new Button();
            SuspendLayout();
            // 
            // CreateDetailsLabel
            // 
            CreateDetailsLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            CreateDetailsLabel.Location = new Point(114, 172);
            CreateDetailsLabel.Name = "CreateDetailsLabel";
            CreateDetailsLabel.Size = new Size(178, 50);
            CreateDetailsLabel.TabIndex = 7;
            CreateDetailsLabel.Text = "具体商品：";
            // 
            // CreateCostomerLabel
            // 
            CreateCostomerLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            CreateCostomerLabel.Location = new Point(114, 66);
            CreateCostomerLabel.Name = "CreateCostomerLabel";
            CreateCostomerLabel.Size = new Size(178, 50);
            CreateCostomerLabel.TabIndex = 6;
            CreateCostomerLabel.Text = "客户:";
            // 
            // CreateCostomerTextBox
            // 
            CreateCostomerTextBox.Location = new Point(351, 66);
            CreateCostomerTextBox.Name = "CreateCostomerTextBox";
            CreateCostomerTextBox.Size = new Size(242, 38);
            CreateCostomerTextBox.TabIndex = 8;
            // 
            // CreateGoodsComboBox
            // 
            CreateGoodsComboBox.FormattingEnabled = true;
            CreateGoodsComboBox.Items.AddRange(new object[] { "123" });
            CreateGoodsComboBox.Location = new Point(351, 172);
            CreateGoodsComboBox.Name = "CreateGoodsComboBox";
            CreateGoodsComboBox.Size = new Size(242, 39);
            CreateGoodsComboBox.TabIndex = 9;
            // 
            // CreateGoodsQuantityLabel
            // 
            CreateGoodsQuantityLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            CreateGoodsQuantityLabel.Location = new Point(114, 289);
            CreateGoodsQuantityLabel.Name = "CreateGoodsQuantityLabel";
            CreateGoodsQuantityLabel.Size = new Size(178, 50);
            CreateGoodsQuantityLabel.TabIndex = 10;
            CreateGoodsQuantityLabel.Text = "商品数量: ";
            // 
            // CreateGoodsQuantityTextBox
            // 
            CreateGoodsQuantityTextBox.Location = new Point(351, 289);
            CreateGoodsQuantityTextBox.Name = "CreateGoodsQuantityTextBox";
            CreateGoodsQuantityTextBox.Size = new Size(242, 38);
            CreateGoodsQuantityTextBox.TabIndex = 11;
            // 
            // CreateConfirmButton
            // 
            CreateConfirmButton.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            CreateConfirmButton.Location = new Point(114, 627);
            CreateConfirmButton.Name = "CreateConfirmButton";
            CreateConfirmButton.Size = new Size(150, 58);
            CreateConfirmButton.TabIndex = 12;
            CreateConfirmButton.Text = "确认";
            CreateConfirmButton.UseVisualStyleBackColor = true;
            CreateConfirmButton.Click += CreateConfirmButton_Click;
            // 
            // CreateBackButton
            // 
            CreateBackButton.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            CreateBackButton.Location = new Point(443, 627);
            CreateBackButton.Name = "CreateBackButton";
            CreateBackButton.Size = new Size(150, 58);
            CreateBackButton.TabIndex = 13;
            CreateBackButton.Text = "返回";
            CreateBackButton.UseVisualStyleBackColor = true;
            CreateBackButton.Click += CreateBackButton_Click;
            // 
            // CreateGoodsListBox
            // 
            CreateGoodsListBox.FormattingEnabled = true;
            CreateGoodsListBox.Location = new Point(114, 360);
            CreateGoodsListBox.Name = "CreateGoodsListBox";
            CreateGoodsListBox.Size = new Size(479, 221);
            CreateGoodsListBox.TabIndex = 14;
            // 
            // CreateAddButton
            // 
            CreateAddButton.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            CreateAddButton.Location = new Point(629, 287);
            CreateAddButton.Name = "CreateAddButton";
            CreateAddButton.Size = new Size(120, 46);
            CreateAddButton.TabIndex = 15;
            CreateAddButton.Text = "添加";
            CreateAddButton.UseVisualStyleBackColor = true;
            CreateAddButton.Click += CreateAddButton_Click;
            // 
            // CreateRemoveButton
            // 
            CreateRemoveButton.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            CreateRemoveButton.Location = new Point(629, 360);
            CreateRemoveButton.Name = "CreateRemoveButton";
            CreateRemoveButton.Size = new Size(120, 46);
            CreateRemoveButton.TabIndex = 16;
            CreateRemoveButton.Text = "移除";
            CreateRemoveButton.UseVisualStyleBackColor = true;
            CreateRemoveButton.Click += CreateRemoveButton_Click;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 729);
            Controls.Add(CreateRemoveButton);
            Controls.Add(CreateAddButton);
            Controls.Add(CreateGoodsListBox);
            Controls.Add(CreateBackButton);
            Controls.Add(CreateConfirmButton);
            Controls.Add(CreateGoodsQuantityTextBox);
            Controls.Add(CreateGoodsQuantityLabel);
            Controls.Add(CreateGoodsComboBox);
            Controls.Add(CreateCostomerTextBox);
            Controls.Add(CreateDetailsLabel);
            Controls.Add(CreateCostomerLabel);
            Name = "CreateForm";
            Text = "创建订单";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateDetailsLabel;
        private Label CreateCostomerLabel;
        private TextBox CreateCostomerTextBox;
        private ComboBox CreateGoodsComboBox;
        private Label CreateGoodsQuantityLabel;
        private TextBox CreateGoodsQuantityTextBox;
        private Button CreateConfirmButton;
        private Button CreateBackButton;
        private ListBox CreateGoodsListBox;
        private Button CreateAddButton;
        private Button CreateRemoveButton;
    }
}