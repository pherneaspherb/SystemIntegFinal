namespace SystemIntegFinal
{
    partial class Orders
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
            dataGridView1 = new DataGridView();
            productDGV = new DataGridView();
            ordername = new Label();
            OrderIdTb = new TextBox();
            label5 = new Label();
            label6 = new Label();
            CusIdTb = new TextBox();
            CusNameTb = new TextBox();
            button1 = new Button();
            ProCatCb = new ComboBox();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            label7 = new Label();
            QtyTb = new TextBox();
            label8 = new Label();
            Tprice = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button5 = new Button();
            ViewOrderButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cargo;
            pictureBox1.Location = new Point(10, 9);
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
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 1;
            label1.Text = "Orders";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(477, 8);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Customers List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1063, 8);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 3;
            label3.Text = "Products List";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(308, 25);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(437, 379);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // productDGV
            // 
            productDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDGV.Location = new Point(876, 25);
            productDGV.Margin = new Padding(3, 2, 3, 2);
            productDGV.Name = "productDGV";
            productDGV.RowHeadersWidth = 51;
            productDGV.Size = new Size(447, 224);
            productDGV.TabIndex = 5;
            productDGV.DoubleClick += dataGridView2_DoubleClick;
            // 
            // ordername
            // 
            ordername.AutoSize = true;
            ordername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ordername.Location = new Point(317, 439);
            ordername.Name = "ordername";
            ordername.Size = new Size(56, 15);
            ordername.TabIndex = 6;
            ordername.Text = "Order ID";
            // 
            // OrderIdTb
            // 
            OrderIdTb.Location = new Point(383, 433);
            OrderIdTb.Margin = new Padding(3, 2, 3, 2);
            OrderIdTb.Name = "OrderIdTb";
            OrderIdTb.Size = new Size(129, 23);
            OrderIdTb.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(524, 438);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 8;
            label5.Text = "Customer ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(314, 475);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 9;
            label6.Text = "Customer Name";
            // 
            // CusIdTb
            // 
            CusIdTb.Location = new Point(615, 433);
            CusIdTb.Margin = new Padding(3, 2, 3, 2);
            CusIdTb.Name = "CusIdTb";
            CusIdTb.Size = new Size(129, 23);
            CusIdTb.TabIndex = 10;
            // 
            // CusNameTb
            // 
            CusNameTb.Location = new Point(427, 470);
            CusNameTb.Margin = new Padding(3, 2, 3, 2);
            CusNameTb.Name = "CusNameTb";
            CusNameTb.Size = new Size(219, 23);
            CusNameTb.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(1110, 276);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(110, 32);
            button1.TabIndex = 12;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProCatCb
            // 
            ProCatCb.FormattingEnabled = true;
            ProCatCb.Items.AddRange(new object[] { "Helmet", "Motocare", "Lube", "Apparel", "Tire", "Accessory" });
            ProCatCb.Location = new Point(875, 276);
            ProCatCb.Margin = new Padding(3, 2, 3, 2);
            ProCatCb.Name = "ProCatCb";
            ProCatCb.Size = new Size(133, 23);
            ProCatCb.TabIndex = 13;
            ProCatCb.Text = "Select Category";
            // 
            // button2
            // 
            button2.Location = new Point(1110, 322);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(110, 32);
            button2.TabIndex = 14;
            button2.Text = "Add to Order";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(875, 390);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(447, 224);
            dataGridView2.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(875, 322);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 16;
            label7.Text = "Quantity";
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(875, 339);
            QtyTb.Margin = new Padding(3, 2, 3, 2);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(171, 23);
            QtyTb.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1336, 501);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 18;
            label8.Text = "Total Price:";
            // 
            // Tprice
            // 
            Tprice.AutoSize = true;
            Tprice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tprice.Location = new Point(1410, 501);
            Tprice.Name = "Tprice";
            Tprice.Size = new Size(28, 15);
            Tprice.TabIndex = 19;
            Tprice.Text = "Php";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(346, 515);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 20;
            label9.Text = "Order Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(427, 511);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 21;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button3
            // 
            button3.Location = new Point(477, 547);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(110, 32);
            button3.TabIndex = 22;
            button3.Text = "Add Order";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(10, 607);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(82, 22);
            button5.TabIndex = 24;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ViewOrderButton
            // 
            ViewOrderButton.Location = new Point(477, 592);
            ViewOrderButton.Margin = new Padding(3, 2, 3, 2);
            ViewOrderButton.Name = "ViewOrderButton";
            ViewOrderButton.Size = new Size(110, 32);
            ViewOrderButton.TabIndex = 25;
            ViewOrderButton.Text = "View Order";
            ViewOrderButton.UseVisualStyleBackColor = true;
            ViewOrderButton.Click += ViewOrderButton_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1541, 640);
            Controls.Add(ViewOrderButton);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(Tprice);
            Controls.Add(label8);
            Controls.Add(QtyTb);
            Controls.Add(label7);
            Controls.Add(dataGridView2);
            Controls.Add(button2);
            Controls.Add(ProCatCb);
            Controls.Add(button1);
            Controls.Add(CusNameTb);
            Controls.Add(CusIdTb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(OrderIdTb);
            Controls.Add(ordername);
            Controls.Add(productDGV);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Orders";
            Text = "Orders";
            Load += label4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridView productDGV;
        private Label ordername;
        private TextBox OrderIdTb;
        private Label label5;
        private Label label6;
        private TextBox CusIdTb;
        private TextBox CusNameTb;
        private Button button1;
        private ComboBox ProCatCb;
        private Button button2;
        private DataGridView dataGridView2;
        private Label label7;
        private TextBox QtyTb;
        private Label label8;
        private Label Tprice;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button ViewOrderButton;
    }
}