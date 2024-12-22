namespace SystemIntegFinal
{
    partial class Customers
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CusIdTb = new TextBox();
            CusNameTb = new TextBox();
            TelTb = new TextBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            OrderCount = new Label();
            label7 = new Label();
            OrderAmount = new Label();
            label9 = new Label();
            LastOrderDate = new Label();
            InsertButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            ClearButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rating;
            pictureBox1.Location = new Point(30, 88);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(334, 77);
            label1.TabIndex = 1;
            label1.Text = "CUSTOMERS";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(482, 349);
            label2.Name = "label2";
            label2.Size = new Size(118, 19);
            label2.TabIndex = 2;
            label2.Text = "Customer ID";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(482, 390);
            label3.Name = "label3";
            label3.Size = new Size(153, 19);
            label3.TabIndex = 3;
            label3.Text = "Customer Name";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(482, 428);
            label4.Name = "label4";
            label4.Size = new Size(153, 19);
            label4.TabIndex = 4;
            label4.Text = "Contact Number";
            // 
            // CusIdTb
            // 
            CusIdTb.Location = new Point(652, 352);
            CusIdTb.Margin = new Padding(3, 2, 3, 2);
            CusIdTb.Name = "CusIdTb";
            CusIdTb.Size = new Size(203, 23);
            CusIdTb.TabIndex = 5;
            CusIdTb.TextChanged += CusIdTb_TextChanged;
            // 
            // CusNameTb
            // 
            CusNameTb.Location = new Point(652, 392);
            CusNameTb.Margin = new Padding(3, 2, 3, 2);
            CusNameTb.Name = "CusNameTb";
            CusNameTb.Size = new Size(203, 23);
            CusNameTb.TabIndex = 6;
            // 
            // TelTb
            // 
            TelTb.Location = new Point(652, 431);
            TelTb.Margin = new Padding(3, 2, 3, 2);
            TelTb.Name = "TelTb";
            TelTb.Size = new Size(203, 23);
            TelTb.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(482, 37);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(765, 293);
            dataGridView1.TabIndex = 8;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(482, 491);
            label5.Name = "label5";
            label5.Size = new Size(116, 22);
            label5.TabIndex = 9;
            label5.Text = "Order Count";
            // 
            // OrderCount
            // 
            OrderCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderCount.Location = new Point(698, 491);
            OrderCount.Name = "OrderCount";
            OrderCount.Size = new Size(116, 22);
            OrderCount.TabIndex = 10;
            OrderCount.Text = "Orders";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(482, 550);
            label7.Name = "label7";
            label7.Size = new Size(130, 22);
            label7.TabIndex = 11;
            label7.Text = "Order Amount";
            // 
            // OrderAmount
            // 
            OrderAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderAmount.Location = new Point(698, 550);
            OrderAmount.Name = "OrderAmount";
            OrderAmount.Size = new Size(116, 22);
            OrderAmount.TabIndex = 12;
            OrderAmount.Text = "Amount";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(482, 607);
            label9.Name = "label9";
            label9.Size = new Size(129, 22);
            label9.TabIndex = 13;
            label9.Text = "Last Order Date";
            // 
            // LastOrderDate
            // 
            LastOrderDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LastOrderDate.Location = new Point(698, 607);
            LastOrderDate.Name = "LastOrderDate";
            LastOrderDate.Size = new Size(116, 22);
            LastOrderDate.TabIndex = 14;
            LastOrderDate.Text = "Date";
            // 
            // InsertButton
            // 
            InsertButton.Location = new Point(934, 356);
            InsertButton.Margin = new Padding(3, 2, 3, 2);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(104, 39);
            InsertButton.TabIndex = 15;
            InsertButton.Text = "INSERT";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(1090, 356);
            UpdateButton.Margin = new Padding(3, 2, 3, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(104, 39);
            UpdateButton.TabIndex = 16;
            UpdateButton.Text = "UPDATE";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(934, 415);
            DeleteButton.Margin = new Padding(3, 2, 3, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(104, 39);
            DeleteButton.TabIndex = 17;
            DeleteButton.Text = "DELETE";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(1090, 415);
            ClearButton.Margin = new Padding(3, 2, 3, 2);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(104, 39);
            ClearButton.TabIndex = 18;
            ClearButton.Text = "CLEAR";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 608);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 19;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1540, 641);
            Controls.Add(button1);
            Controls.Add(ClearButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(InsertButton);
            Controls.Add(LastOrderDate);
            Controls.Add(label9);
            Controls.Add(OrderAmount);
            Controls.Add(label7);
            Controls.Add(OrderCount);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(TelTb);
            Controls.Add(CusNameTb);
            Controls.Add(CusIdTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Customers";
            Text = "Customers";
            Load += Customers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox CusIdTb;
        private TextBox CusNameTb;
        private TextBox TelTb;
        private DataGridView dataGridView1;
        private Label label5;
        private Label OrderCount;
        private Label label7;
        private Label OrderAmount;
        private Label label9;
        private Label LastOrderDate;
        private Button InsertButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ClearButton;
        private Button button1;
    }
}