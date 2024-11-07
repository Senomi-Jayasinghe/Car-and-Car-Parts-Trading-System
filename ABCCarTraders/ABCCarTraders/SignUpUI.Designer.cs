namespace ABCCarTraders
{
    partial class SignUpUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpUI));
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            txtName = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtNewPassword = new TextBox();
            label2 = new Label();
            txtConfirmPassword = new TextBox();
            label5 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-8, -29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(419, 486);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(207, 2, 2);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(673, 387);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(99, 39);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "SignUp";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnSignUp_Click;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(458, 176);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 30);
            txtName.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(458, 150);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 11;
            label4.Text = "Name:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(458, 97);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(279, 30);
            txtEmail.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(207, 2, 2);
            label3.Location = new Point(424, 21);
            label3.Name = "label3";
            label3.Size = new Size(106, 29);
            label3.TabIndex = 9;
            label3.Text = "Sign Up";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(458, 71);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 8;
            label1.Text = "Email:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(458, 257);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(279, 30);
            txtNewPassword.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(458, 231);
            label2.Name = "label2";
            label2.Size = new Size(177, 23);
            label2.TabIndex = 14;
            label2.Text = "Create Password:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(458, 336);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(279, 30);
            txtConfirmPassword.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(458, 310);
            label5.Name = "label5";
            label5.Size = new Size(192, 23);
            label5.TabIndex = 16;
            label5.Text = "Confirm Password:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Verdana", 10F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(583, 387);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(84, 39);
            btnBack.TabIndex = 21;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // SignUpUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label5);
            Controls.Add(txtNewPassword);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "SignUpUI";
            Text = "SignUpUI";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLogin;
        private TextBox txtName;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private Label label1;
        private TextBox txtNewPassword;
        private Label label2;
        private TextBox txtConfirmPassword;
        private Label label5;
        private Button btnBack;
    }
}