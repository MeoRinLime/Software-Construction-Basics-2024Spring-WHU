namespace OrderManage
{
    partial class MainForm
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
            MainArea = new Panel();
            OrderDisplayArea = new Panel();
            OrderIDArea = new Panel();
            ConfirmOrderID = new Button();
            InputOrderID = new TextBox();
            OrderTip = new Label();
            ControlInformation = new TextBox();
            Exit = new Button();
            QueryOrder = new Button();
            DeleteOrder = new Button();
            UpdateOrder = new Button();
            CreateOrder = new Button();
            MainArea.SuspendLayout();
            OrderDisplayArea.SuspendLayout();
            OrderIDArea.SuspendLayout();
            SuspendLayout();
            // 
            // MainArea
            // 
            MainArea.Controls.Add(OrderDisplayArea);
            MainArea.Controls.Add(Exit);
            MainArea.Controls.Add(QueryOrder);
            MainArea.Controls.Add(DeleteOrder);
            MainArea.Controls.Add(UpdateOrder);
            MainArea.Controls.Add(CreateOrder);
            MainArea.Location = new Point(-3, -4);
            MainArea.Name = "MainArea";
            MainArea.Size = new Size(1897, 1013);
            MainArea.TabIndex = 0;
            // 
            // OrderDisplayArea
            // 
            OrderDisplayArea.Controls.Add(OrderIDArea);
            OrderDisplayArea.Controls.Add(ControlInformation);
            OrderDisplayArea.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            OrderDisplayArea.Location = new Point(538, 58);
            OrderDisplayArea.Name = "OrderDisplayArea";
            OrderDisplayArea.Size = new Size(1191, 802);
            OrderDisplayArea.TabIndex = 5;
            // 
            // OrderIDArea
            // 
            OrderIDArea.Controls.Add(ConfirmOrderID);
            OrderIDArea.Controls.Add(InputOrderID);
            OrderIDArea.Controls.Add(OrderTip);
            OrderIDArea.Location = new Point(77, 146);
            OrderIDArea.Name = "OrderIDArea";
            OrderIDArea.Size = new Size(1097, 63);
            OrderIDArea.TabIndex = 3;
            // 
            // ConfirmOrderID
            // 
            ConfirmOrderID.Location = new Point(598, 6);
            ConfirmOrderID.Name = "ConfirmOrderID";
            ConfirmOrderID.Size = new Size(150, 46);
            ConfirmOrderID.TabIndex = 3;
            ConfirmOrderID.Text = "确认";
            ConfirmOrderID.UseVisualStyleBackColor = true;
            ConfirmOrderID.Click += ConfirmOrderID_Click;
            // 
            // InputOrderID
            // 
            InputOrderID.Location = new Point(163, 7);
            InputOrderID.Name = "InputOrderID";
            InputOrderID.Size = new Size(266, 38);
            InputOrderID.TabIndex = 2;
            // 
            // OrderTip
            // 
            OrderTip.AutoSize = true;
            OrderTip.Location = new Point(20, 14);
            OrderTip.Name = "OrderTip";
            OrderTip.Size = new Size(110, 31);
            OrderTip.TabIndex = 1;
            OrderTip.Text = "订单号：";
            // 
            // ControlInformation
            // 
            ControlInformation.BorderStyle = BorderStyle.FixedSingle;
            ControlInformation.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ControlInformation.Location = new Point(77, 3);
            ControlInformation.Multiline = true;
            ControlInformation.Name = "ControlInformation";
            ControlInformation.ReadOnly = true;
            ControlInformation.Size = new Size(891, 89);
            ControlInformation.TabIndex = 0;
            ControlInformation.Text = "TEST";
            // 
            // Exit
            // 
            Exit.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            Exit.Location = new Point(1579, 915);
            Exit.Name = "Exit";
            Exit.Size = new Size(150, 46);
            Exit.TabIndex = 4;
            Exit.Text = "退出";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // QueryOrder
            // 
            QueryOrder.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 134);
            QueryOrder.Location = new Point(79, 616);
            QueryOrder.Name = "QueryOrder";
            QueryOrder.Size = new Size(380, 120);
            QueryOrder.TabIndex = 3;
            QueryOrder.Text = "查询订单";
            QueryOrder.UseVisualStyleBackColor = true;
            // 
            // DeleteOrder
            // 
            DeleteOrder.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 134);
            DeleteOrder.Location = new Point(79, 418);
            DeleteOrder.Name = "DeleteOrder";
            DeleteOrder.Size = new Size(380, 120);
            DeleteOrder.TabIndex = 2;
            DeleteOrder.Text = "删除订单";
            DeleteOrder.UseVisualStyleBackColor = true;
            // 
            // UpdateOrder
            // 
            UpdateOrder.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 134);
            UpdateOrder.Location = new Point(79, 235);
            UpdateOrder.Name = "UpdateOrder";
            UpdateOrder.Size = new Size(380, 120);
            UpdateOrder.TabIndex = 1;
            UpdateOrder.Text = "修改订单";
            UpdateOrder.UseVisualStyleBackColor = true;
            UpdateOrder.Click += UpdateOrder_Click;
            // 
            // CreateOrder
            // 
            CreateOrder.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 134);
            CreateOrder.Location = new Point(79, 58);
            CreateOrder.Name = "CreateOrder";
            CreateOrder.Size = new Size(380, 120);
            CreateOrder.TabIndex = 0;
            CreateOrder.Text = "创建订单";
            CreateOrder.UseVisualStyleBackColor = true;
            CreateOrder.Click += CreateOrder_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
            Controls.Add(MainArea);
            Name = "MainForm";
            Text = "订单管理";
            MainArea.ResumeLayout(false);
            OrderDisplayArea.ResumeLayout(false);
            OrderDisplayArea.PerformLayout();
            OrderIDArea.ResumeLayout(false);
            OrderIDArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainArea;
        private Button CreateOrder;
        private Button Exit;
        private Button QueryOrder;
        private Button DeleteOrder;
        private Button UpdateOrder;
        private Panel OrderDisplayArea;
        private TextBox ControlInformation;
        private Panel OrderIDArea;
        private TextBox InputOrderID;
        private Label OrderTip;
        private Button ConfirmOrderID;
    }
}
