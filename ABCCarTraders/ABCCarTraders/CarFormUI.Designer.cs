namespace ABCCarTraders
{
    partial class CarFormUI
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
            btnSave = new Button();
            txtBrand = new TextBox();
            label4 = new Label();
            txtType = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            ddlColors = new ComboBox();
            txtFuelEco = new TextBox();
            label5 = new Label();
            txtEnginePw = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dateManuDate = new DateTimePicker();
            txtPrice = new TextBox();
            label8 = new Label();
            label9 = new Label();
            picCar = new PictureBox();
            btnUpload = new Button();
            btnBack = new Button();
            txtCarId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(207, 2, 2);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(877, 337);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 35);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtBrand
            // 
            txtBrand.BorderStyle = BorderStyle.FixedSingle;
            txtBrand.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrand.Location = new Point(233, 128);
            txtBrand.Multiline = true;
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(279, 23);
            txtBrand.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 128);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 11;
            label4.Text = "Car Brand:";
            // 
            // txtType
            // 
            txtType.BackColor = Color.White;
            txtType.BorderStyle = BorderStyle.FixedSingle;
            txtType.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtType.ForeColor = Color.Black;
            txtType.Location = new Point(233, 86);
            txtType.Multiline = true;
            txtType.Name = "txtType";
            txtType.Size = new Size(279, 23);
            txtType.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(207, 2, 2);
            label3.Location = new Point(12, 19);
            label3.Name = "label3";
            label3.Size = new Size(214, 29);
            label3.TabIndex = 9;
            label3.Text = "Enter Car Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 86);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 8;
            label1.Text = "Car Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 170);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 14;
            label2.Text = "Car Color:";
            // 
            // ddlColors
            // 
            ddlColors.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ddlColors.FormattingEnabled = true;
            ddlColors.Location = new Point(233, 170);
            ddlColors.Name = "ddlColors";
            ddlColors.Size = new Size(279, 26);
            ddlColors.TabIndex = 15;
            // 
            // txtFuelEco
            // 
            txtFuelEco.BorderStyle = BorderStyle.FixedSingle;
            txtFuelEco.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFuelEco.Location = new Point(233, 215);
            txtFuelEco.Multiline = true;
            txtFuelEco.Name = "txtFuelEco";
            txtFuelEco.Size = new Size(279, 23);
            txtFuelEco.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 215);
            label5.Name = "label5";
            label5.Size = new Size(222, 23);
            label5.TabIndex = 16;
            label5.Text = "Fuel Economy (km/l):";
            // 
            // txtEnginePw
            // 
            txtEnginePw.BorderStyle = BorderStyle.FixedSingle;
            txtEnginePw.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnginePw.Location = new Point(233, 256);
            txtEnginePw.Multiline = true;
            txtEnginePw.Name = "txtEnginePw";
            txtEnginePw.Size = new Size(279, 23);
            txtEnginePw.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 256);
            label6.Name = "label6";
            label6.Size = new Size(199, 23);
            label6.TabIndex = 18;
            label6.Text = "Engine Power (HP):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 337);
            label7.Name = "label7";
            label7.Size = new Size(199, 23);
            label7.TabIndex = 20;
            label7.Text = "Manufactured Date:";
            // 
            // dateManuDate
            // 
            dateManuDate.Font = new Font("Verdana", 10F);
            dateManuDate.Location = new Point(233, 336);
            dateManuDate.Name = "dateManuDate";
            dateManuDate.Size = new Size(246, 24);
            dateManuDate.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(233, 296);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(279, 23);
            txtPrice.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 296);
            label8.Name = "label8";
            label8.Size = new Size(65, 23);
            label8.TabIndex = 22;
            label8.Text = "Price:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(553, 84);
            label9.Name = "label9";
            label9.Size = new Size(84, 23);
            label9.TabIndex = 24;
            label9.Text = "Picture:";
            // 
            // picCar
            // 
            picCar.Location = new Point(645, 83);
            picCar.Name = "picCar";
            picCar.Size = new Size(299, 186);
            picCar.SizeMode = PictureBoxSizeMode.StretchImage;
            picCar.TabIndex = 25;
            picCar.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = SystemColors.Control;
            btnUpload.Font = new Font("Segoe UI", 10F);
            btnUpload.Location = new Point(553, 115);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(74, 34);
            btnUpload.TabIndex = 26;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(904, 24);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(53, 29);
            btnBack.TabIndex = 27;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtCarId
            // 
            txtCarId.BackColor = Color.White;
            txtCarId.BorderStyle = BorderStyle.FixedSingle;
            txtCarId.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarId.ForeColor = Color.Black;
            txtCarId.Location = new Point(233, 57);
            txtCarId.Multiline = true;
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(279, 23);
            txtCarId.TabIndex = 28;
            txtCarId.Visible = false;
            // 
            // CarFormUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(986, 407);
            Controls.Add(txtCarId);
            Controls.Add(btnBack);
            Controls.Add(btnUpload);
            Controls.Add(picCar);
            Controls.Add(label9);
            Controls.Add(txtPrice);
            Controls.Add(label8);
            Controls.Add(dateManuDate);
            Controls.Add(label7);
            Controls.Add(txtEnginePw);
            Controls.Add(label6);
            Controls.Add(txtFuelEco);
            Controls.Add(label5);
            Controls.Add(ddlColors);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtBrand);
            Controls.Add(label4);
            Controls.Add(txtType);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CarFormUI";
            Text = "Car Form";
            Load += CarFormUI_Load;
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtBrand;
        private Label label4;
        private TextBox txtType;
        private Label label3;
        private Label label1;
        private Label label2;
        private ComboBox ddlColors;
        private TextBox txtFuelEco;
        private Label label5;
        private TextBox txtEnginePw;
        private Label label6;
        private Label label7;
        private DateTimePicker dateManuDate;
        private TextBox txtPrice;
        private Label label8;
        private Label label9;
        private PictureBox picCar;
        private Button btnUpload;
        private Button btnBack;
        private TextBox txtCarId;
    }
}