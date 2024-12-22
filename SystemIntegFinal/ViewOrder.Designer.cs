namespace SystemIntegFinal
{
    partial class ViewOrder
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
            ViewOrderDGV = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            PrintOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)ViewOrderDGV).BeginInit();
            SuspendLayout();
            // 
            // ViewOrderDGV
            // 
            ViewOrderDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewOrderDGV.Location = new Point(229, 107);
            ViewOrderDGV.Name = "ViewOrderDGV";
            ViewOrderDGV.RowHeadersWidth = 51;
            ViewOrderDGV.Size = new Size(713, 403);
            ViewOrderDGV.TabIndex = 0;
            ViewOrderDGV.CellContentClick += ViewOrderDGV_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 41);
            label1.Name = "label1";
            label1.Size = new Size(176, 38);
            label1.TabIndex = 1;
            label1.Text = "Your Order: ";
            // 
            // button1
            // 
            button1.Location = new Point(1056, 640);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PrintOrder
            // 
            PrintOrder.Location = new Point(506, 536);
            PrintOrder.Name = "PrintOrder";
            PrintOrder.Size = new Size(169, 55);
            PrintOrder.TabIndex = 3;
            PrintOrder.Text = "Print Receipt";
            PrintOrder.UseVisualStyleBackColor = true;
            PrintOrder.Click += PrintOrder_Click;
            // 
            // ViewOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 718);
            Controls.Add(PrintOrder);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(ViewOrderDGV);
            Name = "ViewOrder";
            Text = "OrderModule";
            ((System.ComponentModel.ISupportInitialize)ViewOrderDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ViewOrderDGV;
        private Label label1;
        private Button button1;
        private Button PrintOrder;
    }
}