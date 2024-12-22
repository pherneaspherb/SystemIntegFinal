namespace SystemIntegFinal
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            logoutButton = new Button();
            productsButton = new Button();
            customersButton = new Button();
            ordersButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 77);
            label1.TabIndex = 0;
            label1.Text = "HOME";
            // 
            // logoutButton
            // 
            logoutButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            logoutButton.Location = new Point(12, 604);
            logoutButton.Margin = new Padding(3, 2, 3, 2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(82, 22);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Log Out";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += button1_Click;
            // 
            // productsButton
            // 
            productsButton.BackColor = SystemColors.Control;
            productsButton.Cursor = Cursors.Hand;
            productsButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productsButton.ForeColor = SystemColors.ActiveCaptionText;
            productsButton.Location = new Point(557, 224);
            productsButton.Margin = new Padding(3, 2, 3, 2);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(150, 44);
            productsButton.TabIndex = 2;
            productsButton.Text = "PRODUCTS";
            productsButton.UseVisualStyleBackColor = false;
            productsButton.Click += productsButton_Click;
            // 
            // customersButton
            // 
            customersButton.BackColor = SystemColors.Control;
            customersButton.Cursor = Cursors.Hand;
            customersButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customersButton.ForeColor = SystemColors.ActiveCaptionText;
            customersButton.Location = new Point(557, 490);
            customersButton.Margin = new Padding(3, 2, 3, 2);
            customersButton.Name = "customersButton";
            customersButton.Size = new Size(150, 44);
            customersButton.TabIndex = 3;
            customersButton.Text = "CUSTOMERS";
            customersButton.UseVisualStyleBackColor = false;
            customersButton.Click += customersButton_Click;
            // 
            // ordersButton
            // 
            ordersButton.BackColor = SystemColors.Control;
            ordersButton.Cursor = Cursors.Hand;
            ordersButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ordersButton.ForeColor = SystemColors.ActiveCaptionText;
            ordersButton.Location = new Point(801, 353);
            ordersButton.Margin = new Padding(3, 2, 3, 2);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(150, 44);
            ordersButton.TabIndex = 4;
            ordersButton.Text = "ORDERS";
            ordersButton.UseVisualStyleBackColor = false;
            ordersButton.Click += ordersButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(328, 34);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(612, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(328, 300);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(612, 234);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(735, 135);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(283, 282);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1542, 637);
            Controls.Add(ordersButton);
            Controls.Add(pictureBox3);
            Controls.Add(customersButton);
            Controls.Add(productsButton);
            Controls.Add(logoutButton);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            Text = "Form1";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button logoutButton;
        private Button productsButton;
        private Button customersButton;
        private Button ordersButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}