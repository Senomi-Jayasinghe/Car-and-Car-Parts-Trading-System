namespace ABCCarTraders
{
    partial class OrderCarFormUI
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
            txtOrderId = new TextBox();
            btnBack = new Button();
            picCar = new PictureBox();
            label9 = new Label();
            txtPrice = new TextBox();
            label8 = new Label();
            dateManuDate = new DateTimePicker();
            label7 = new Label();
            txtEnginePw = new TextBox();
            label6 = new Label();
            txtFuelEco = new TextBox();
            label5 = new Label();
            ddlColors = new ComboBox();
            label2 = new Label();
            btnCancel = new Button();
            txtBrand = new TextBox();
            label4 = new Label();
            txtType = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label10 = new Label();
            label11 = new Label();
            ddlStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            SuspendLayout();
            // 
            // txtOrderId
            // 
            txtOrderId.BackColor = Color.White;
            txtOrderId.BorderStyle = BorderStyle.FixedSingle;
            txtOrderId.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrderId.ForeColor = Color.Black;
            txtOrderId.Location = new Point(233, 62);
            txtOrderId.Multiline = true;
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(279, 23);
            txtOrderId.TabIndex = 49;
            txtOrderId.Visible = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(904, 29);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(53, 29);
            btnBack.TabIndex = 48;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // picCar
            // 
            picCar.Location = new Point(643, 64);
            picCar.Name = "picCar";
            picCar.Size = new Size(299, 186);
            picCar.SizeMode = PictureBoxSizeMode.StretchImage;
            picCar.TabIndex = 46;
            picCar.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(551, 65);
            label9.Name = "label9";
            label9.Size = new Size(84, 23);
            label9.TabIndex = 45;
            label9.Text = "Picture:";
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(233, 301);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(279, 23);
            txtPrice.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(-69, 326);
            label8.Name = "label8";
            label8.Size = new Size(65, 23);
            label8.TabIndex = 43;
            label8.Text = "Price:";
            // 
            // dateManuDate
            // 
            dateManuDate.Font = new Font("Verdana", 10F);
            dateManuDate.Location = new Point(233, 341);
            dateManuDate.Name = "dateManuDate";
            dateManuDate.Size = new Size(246, 24);
            dateManuDate.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 342);
            label7.Name = "label7";
            label7.Size = new Size(199, 23);
            label7.TabIndex = 41;
            label7.Text = "Manufactured Date:";
            // 
            // txtEnginePw
            // 
            txtEnginePw.BorderStyle = BorderStyle.FixedSingle;
            txtEnginePw.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnginePw.Location = new Point(233, 261);
            txtEnginePw.Multiline = true;
            txtEnginePw.Name = "txtEnginePw";
            txtEnginePw.Size = new Size(279, 23);
            txtEnginePw.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 261);
            label6.Name = "label6";
            label6.Size = new Size(199, 23);
            label6.TabIndex = 39;
            label6.Text = "Engine Power (HP):";
            // 
            // txtFuelEco
            // 
            txtFuelEco.BorderStyle = BorderStyle.FixedSingle;
            txtFuelEco.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFuelEco.Location = new Point(233, 220);
            txtFuelEco.Multiline = true;
            txtFuelEco.Name = "txtFuelEco";
            txtFuelEco.Size = new Size(279, 23);
            txtFuelEco.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 220);
            label5.Name = "label5";
            label5.Size = new Size(222, 23);
            label5.TabIndex = 37;
            label5.Text = "Fuel Economy (km/l):";
            // 
            // ddlColors
            // 
            ddlColors.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ddlColors.FormattingEnabled = true;
            ddlColors.Location = new Point(233, 175);
            ddlColors.Name = "ddlColors";
            ddlColors.Size = new Size(279, 26);
            ddlColors.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 175);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 35;
            label2.Text = "Car Color:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(207, 2, 2);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(877, 342);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 35);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtBrand
            // 
            txtBrand.BorderStyle = BorderStyle.FixedSingle;
            txtBrand.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrand.Location = new Point(233, 133);
            txtBrand.Multiline = true;
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(279, 23);
            txtBrand.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 133);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 32;
            label4.Text = "Car Brand:";
            // 
            // txtType
            // 
            txtType.BackColor = Color.White;
            txtType.BorderStyle = BorderStyle.FixedSingle;
            txtType.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtType.ForeColor = Color.Black;
            txtType.Location = new Point(233, 91);
            txtType.Multiline = true;
            txtType.Name = "txtType";
            txtType.Size = new Size(279, 23);
            txtType.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(207, 2, 2);
            label3.Location = new Point(12, 24);
            label3.Name = "label3";
            label3.Size = new Size(219, 29);
            label3.TabIndex = 30;
            label3.Text = "Car Order Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 91);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 29;
            label1.Text = "Car Type:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(15, 301);
            label10.Name = "label10";
            label10.Size = new Size(65, 23);
            label10.TabIndex = 51;
            label10.Text = "Price:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(551, 278);
            label11.Name = "label11";
            label11.Size = new Size(70, 23);
            label11.TabIndex = 52;
            label11.Text = "Status";
            // 
            // ddlStatus
            // 
            ddlStatus.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ddlStatus.FormattingEnabled = true;
            ddlStatus.Location = new Point(643, 279);
            ddlStatus.Name = "ddlStatus";
            ddlStatus.Size = new Size(279, 26);
            ddlStatus.TabIndex = 53;
            // 
            // OrderCarFormUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(970, 423);
            Controls.Add(ddlStatus);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtOrderId);
            Controls.Add(btnBack);
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
            Controls.Add(btnCancel);
            Controls.Add(txtBrand);
            Controls.Add(label4);
            Controls.Add(txtType);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "OrderCarFormUI";
            Text = "OrderCarFormUI";
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOrderId;
        private Button btnBack;
        private PictureBox picCar;
        private Label label9;
        private TextBox txtPrice;
        private Label label8;
        private DateTimePicker dateManuDate;
        private Label label7;
        private TextBox txtEnginePw;
        private Label label6;
        private TextBox txtFuelEco;
        private Label label5;
        private ComboBox ddlColors;
        private Label label2;
        private Button btnCancel;
        private TextBox txtBrand;
        private Label label4;
        private TextBox txtType;
        private Label label3;
        private Label label1;
        private Label label10;
        private Label label11;
        private ComboBox ddlStatus;
    }
}