namespace SystemIntegFinal
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ProductIdTB = new TextBox();
            ProNameTb = new TextBox();
            ProQuanTB = new TextBox();
            DescTb = new TextBox();
            label8 = new Label();
            BrantTb = new TextBox();
            PriceTb = new TextBox();
            ProCatCb = new ComboBox();
            Update = new Button();
            button3 = new Button();
            button4 = new Button();
            productDGV = new DataGridView();
            button5 = new Button();
            comboBox2 = new ComboBox();
            button6 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)productDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(294, 77);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTS";
            // 
            // button1
            // 
            button1.Location = new Point(12, 608);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(945, 474);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(130, 40);
            button2.TabIndex = 3;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(478, 349);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 4;
            label2.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(478, 386);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 5;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(478, 470);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 6;
            label4.Text = "Brand";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(478, 429);
            label5.Name = "label5";
            label5.Size = new Size(144, 21);
            label5.TabIndex = 7;
            label5.Text = "Product Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(934, 346);
            label6.Name = "label6";
            label6.Size = new Size(98, 21);
            label6.TabIndex = 8;
            label6.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(934, 388);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 9;
            label7.Text = "Price";
            // 
            // ProductIdTB
            // 
            ProductIdTB.Location = new Point(680, 352);
            ProductIdTB.Margin = new Padding(3, 2, 3, 2);
            ProductIdTB.Name = "ProductIdTB";
            ProductIdTB.Size = new Size(208, 23);
            ProductIdTB.TabIndex = 10;
            ProductIdTB.TextChanged += ProductIdTB_TextChanged;
            // 
            // ProNameTb
            // 
            ProNameTb.Location = new Point(680, 389);
            ProNameTb.Margin = new Padding(3, 2, 3, 2);
            ProNameTb.Name = "ProNameTb";
            ProNameTb.Size = new Size(208, 23);
            ProNameTb.TabIndex = 11;
            ProNameTb.TextChanged += ProNameTb_TextChanged;
            // 
            // ProQuanTB
            // 
            ProQuanTB.Location = new Point(1136, 431);
            ProQuanTB.Margin = new Padding(3, 2, 3, 2);
            ProQuanTB.Name = "ProQuanTB";
            ProQuanTB.Size = new Size(208, 23);
            ProQuanTB.TabIndex = 12;
            // 
            // DescTb
            // 
            DescTb.Location = new Point(1136, 349);
            DescTb.Margin = new Padding(3, 2, 3, 2);
            DescTb.Name = "DescTb";
            DescTb.Size = new Size(208, 23);
            DescTb.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(934, 431);
            label8.Name = "label8";
            label8.Size = new Size(141, 21);
            label8.TabIndex = 14;
            label8.Text = "Product Quantity";
            // 
            // BrantTb
            // 
            BrantTb.Location = new Point(680, 470);
            BrantTb.Margin = new Padding(3, 2, 3, 2);
            BrantTb.Name = "BrantTb";
            BrantTb.Size = new Size(208, 23);
            BrantTb.TabIndex = 15;
            // 
            // PriceTb
            // 
            PriceTb.Location = new Point(1136, 391);
            PriceTb.Margin = new Padding(3, 2, 3, 2);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(208, 23);
            PriceTb.TabIndex = 16;
            // 
            // ProCatCb
            // 
            ProCatCb.FormattingEnabled = true;
            ProCatCb.Items.AddRange(new object[] { "Helmet", "Motocare", "Lube", "Apparel", "Tire", "Accessory", "" });
            ProCatCb.Location = new Point(680, 429);
            ProCatCb.Margin = new Padding(3, 2, 3, 2);
            ProCatCb.Name = "ProCatCb";
            ProCatCb.Size = new Size(208, 23);
            ProCatCb.TabIndex = 17;
            // 
            // Update
            // 
            Update.Location = new Point(1136, 474);
            Update.Margin = new Padding(3, 2, 3, 2);
            Update.Name = "Update";
            Update.Size = new Size(130, 40);
            Update.TabIndex = 18;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // button3
            // 
            button3.Location = new Point(945, 542);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(130, 40);
            button3.TabIndex = 19;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1136, 542);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(130, 40);
            button4.TabIndex = 20;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // productDGV
            // 
            productDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDGV.Location = new Point(477, 34);
            productDGV.Margin = new Padding(3, 2, 3, 2);
            productDGV.Name = "productDGV";
            productDGV.RowHeadersWidth = 51;
            productDGV.Size = new Size(768, 291);
            productDGV.TabIndex = 21;
            productDGV.CellContentClick += productDGV_CellContentClick;
            productDGV.DoubleClick += productDGV_DoubleClick;
            // 
            // button5
            // 
            button5.Location = new Point(335, 173);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(108, 23);
            button5.TabIndex = 22;
            button5.Text = "Select";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Helmet", "Motocare", "Lube", "Apparel", "Tire", "Accessory" });
            comboBox2.Location = new Point(335, 120);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 23;
            comboBox2.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button6
            // 
            button6.Location = new Point(335, 224);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(108, 23);
            button6.TabIndex = 24;
            button6.Text = "Undo";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(335, 9);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(170, 134);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1216, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1540, 641);
            Controls.Add(button6);
            Controls.Add(comboBox2);
            Controls.Add(button5);
            Controls.Add(productDGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Update);
            Controls.Add(ProCatCb);
            Controls.Add(PriceTb);
            Controls.Add(BrantTb);
            Controls.Add(label8);
            Controls.Add(DescTb);
            Controls.Add(ProQuanTB);
            Controls.Add(ProNameTb);
            Controls.Add(ProductIdTB);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "form1";
            Text = "Products";
            Load += ProCatCb_Load;
            ((System.ComponentModel.ISupportInitialize)productDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox ProductIdTB;
        private TextBox ProNameTb;
        private TextBox ProQuanTB;
        private TextBox DescTb;
        private Label label8;
        private TextBox BrantTb;
        private TextBox PriceTb;
        private ComboBox ProCatCb;
        private Button Update;
        private Button button3;
        private Button button4;
        private DataGridView productDGV;
        private Button button5;
        private ComboBox comboBox2;
        private Button button6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}