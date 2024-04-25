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
            InforDisplayArea = new Panel();
            RefreshButton = new Button();
            OrdersDisplayArea = new Panel();
            OrdersDataGridView = new DataGridView();
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
            InforDisplayArea.SuspendLayout();
            OrdersDisplayArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            OrderIDArea.SuspendLayout();
            SuspendLayout();
            // 
            // MainArea
            // 
            MainArea.Controls.Add(InforDisplayArea);
            MainArea.Controls.Add(Exit);
            MainArea.Controls.Add(QueryOrder);
            MainArea.Controls.Add(DeleteOrder);
            MainArea.Controls.Add(UpdateOrder);
            MainArea.Controls.Add(CreateOrder);
            MainArea.Location = new Point(-4, -4);
            MainArea.Margin = new Padding(4);
            MainArea.Name = "MainArea";
            MainArea.Size = new Size(1896, 1014);
            MainArea.TabIndex = 0;
            // 
            // InforDisplayArea
            // 
            InforDisplayArea.Controls.Add(RefreshButton);
            InforDisplayArea.Controls.Add(OrdersDisplayArea);
            InforDisplayArea.Controls.Add(OrderIDArea);
            InforDisplayArea.Controls.Add(ControlInformation);
            InforDisplayArea.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            InforDisplayArea.Location = new Point(538, 58);
            InforDisplayArea.Margin = new Padding(4);
            InforDisplayArea.Name = "InforDisplayArea";
            InforDisplayArea.Size = new Size(1192, 802);
            InforDisplayArea.TabIndex = 5;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(955, 153);
            RefreshButton.Margin = new Padding(4);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(150, 46);
            RefreshButton.TabIndex = 4;
            RefreshButton.Text = "刷新";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // OrdersDisplayArea
            // 
            OrdersDisplayArea.Controls.Add(OrdersDataGridView);
            OrdersDisplayArea.Location = new Point(76, 264);
            OrdersDisplayArea.Margin = new Padding(6, 5, 6, 5);
            OrdersDisplayArea.Name = "OrdersDisplayArea";
            OrdersDisplayArea.Size = new Size(1096, 503);
            OrdersDisplayArea.TabIndex = 4;
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.BackgroundColor = SystemColors.HighlightText;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Dock = DockStyle.Fill;
            OrdersDataGridView.GridColor = SystemColors.ControlLightLight;
            OrdersDataGridView.Location = new Point(0, 0);
            OrdersDataGridView.Margin = new Padding(6, 5, 6, 5);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.RowHeadersWidth = 82;
            OrdersDataGridView.Size = new Size(1096, 503);
            OrdersDataGridView.TabIndex = 0;
            OrdersDataGridView.CellContentClick += OrdersDataGridView_CellContentClick;
            // 
            // OrderIDArea
            // 
            OrderIDArea.Controls.Add(ConfirmOrderID);
            OrderIDArea.Controls.Add(InputOrderID);
            OrderIDArea.Controls.Add(OrderTip);
            OrderIDArea.Location = new Point(76, 146);
            OrderIDArea.Margin = new Padding(4);
            OrderIDArea.Name = "OrderIDArea";
            OrderIDArea.Size = new Size(800, 64);
            OrderIDArea.TabIndex = 3;
            // 
            // ConfirmOrderID
            // 
            ConfirmOrderID.Location = new Point(598, 5);
            ConfirmOrderID.Margin = new Padding(4);
            ConfirmOrderID.Name = "ConfirmOrderID";
            ConfirmOrderID.Size = new Size(150, 46);
            ConfirmOrderID.TabIndex = 3;
            ConfirmOrderID.Text = "确认";
            ConfirmOrderID.UseVisualStyleBackColor = true;
            ConfirmOrderID.Click += ConfirmOrderID_Click;
            // 
            // InputOrderID
            // 
            InputOrderID.Location = new Point(164, 7);
            InputOrderID.Margin = new Padding(4);
            InputOrderID.Name = "InputOrderID";
            InputOrderID.Size = new Size(266, 38);
            InputOrderID.TabIndex = 2;
            // 
            // OrderTip
            // 
            OrderTip.AutoSize = true;
            OrderTip.Location = new Point(20, 15);
            OrderTip.Margin = new Padding(4, 0, 4, 0);
            OrderTip.Name = "OrderTip";
            OrderTip.Size = new Size(110, 31);
            OrderTip.TabIndex = 1;
            OrderTip.Text = "订单号：";
            // 
            // ControlInformation
            // 
            ControlInformation.BorderStyle = BorderStyle.FixedSingle;
            ControlInformation.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ControlInformation.Location = new Point(76, 4);
            ControlInformation.Margin = new Padding(4);
            ControlInformation.Multiline = true;
            ControlInformation.Name = "ControlInformation";
            ControlInformation.ReadOnly = true;
            ControlInformation.Size = new Size(890, 90);
            ControlInformation.TabIndex = 0;
            ControlInformation.Text = "TEST";
            // 
            // Exit
            // 
            Exit.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            Exit.Location = new Point(1580, 915);
            Exit.Margin = new Padding(4);
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
            QueryOrder.Location = new Point(80, 616);
            QueryOrder.Margin = new Padding(4);
            QueryOrder.Name = "QueryOrder";
            QueryOrder.Size = new Size(380, 120);
            QueryOrder.TabIndex = 3;
            QueryOrder.Text = "查询订单";
            QueryOrder.UseVisualStyleBackColor = true;
            // 
            // DeleteOrder
            // 
            DeleteOrder.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 134);
            DeleteOrder.Location = new Point(80, 427);
            DeleteOrder.Margin = new Padding(4);
            DeleteOrder.Name = "DeleteOrder";
            DeleteOrder.Size = new Size(380, 120);
            DeleteOrder.TabIndex = 2;
            DeleteOrder.Text = "删除订单";
            DeleteOrder.UseVisualStyleBackColor = true;
            // 
            // UpdateOrder
            // 
            UpdateOrder.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 134);
            UpdateOrder.Location = new Point(80, 244);
            UpdateOrder.Margin = new Padding(4);
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
            CreateOrder.Location = new Point(80, 58);
            CreateOrder.Margin = new Padding(4);
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
            ClientSize = new Size(1894, 1008);
            Controls.Add(MainArea);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "订单管理";
            MainArea.ResumeLayout(false);
            InforDisplayArea.ResumeLayout(false);
            InforDisplayArea.PerformLayout();
            OrdersDisplayArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
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
        private Panel InforDisplayArea;
        private TextBox ControlInformation;
        private Panel OrderIDArea;
        private TextBox InputOrderID;
        private Label OrderTip;
        private Button ConfirmOrderID;
        private Panel OrdersDisplayArea;
        private DataGridView OrdersDataGridView;
        private Button RefreshButton;
    }
}
