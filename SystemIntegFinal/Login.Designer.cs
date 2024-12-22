namespace SystemIntegFinal
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            usernameBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            passwordBox = new TextBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(439, 142);
            label1.Name = "label1";
            label1.Size = new Size(564, 35);
            label1.TabIndex = 0;
            label1.Text = "AESYNC CONVENIENCE STORE";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-45, -106);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(466, 413);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(700, 224);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 2;
            label2.Text = "LOGIN";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(482, 275);
            label3.Name = "label3";
            label3.Size = new Size(133, 32);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(482, 322);
            label4.Name = "label4";
            label4.Size = new Size(128, 32);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(646, 281);
            usernameBox.Margin = new Padding(3, 2, 3, 2);
            usernameBox.Multiline = true;
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(219, 26);
            usernameBox.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(705, 413);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(705, 448);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 7;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(646, 327);
            passwordBox.Margin = new Padding(3, 2, 3, 2);
            passwordBox.Multiline = true;
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(219, 26);
            passwordBox.TabIndex = 8;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(700, 374);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1540, 639);
            Controls.Add(checkBox1);
            Controls.Add(passwordBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(usernameBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox usernameBox;
        private Button button1;
        private Button button2;
        private TextBox passwordBox;
        private CheckBox checkBox1;
    }
}
