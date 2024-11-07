namespace ABCCarTraders
{
    partial class CarPartForm
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
            txtCarPartId = new TextBox();
            btnBack = new Button();
            btnUpload = new Button();
            picCarPart = new PictureBox();
            label9 = new Label();
            txtPrice = new TextBox();
            label8 = new Label();
            dateManuDate = new DateTimePicker();
            label7 = new Label();
            txtDesc = new TextBox();
            label5 = new Label();
            ddlColors = new ComboBox();
            label2 = new Label();
            btnSave = new Button();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            ddlCarType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picCarPart).BeginInit();
            SuspendLayout();
            // 
            // txtCarPartId
            // 
            txtCarPartId.BackColor = Color.White;
            txtCarPartId.BorderStyle = BorderStyle.FixedSingle;
            txtCarPartId.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarPartId.ForeColor = Color.Black;
            txtCarPartId.Location = new Point(233, 60);
            txtCarPartId.Multiline = true;
            txtCarPartId.Name = "txtCarPartId";
            txtCarPartId.Size = new Size(279, 23);
            txtCarPartId.TabIndex = 49;
            txtCarPartId.Visible = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(904, 27);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(53, 29);
            btnBack.TabIndex = 48;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = SystemColors.Control;
            btnUpload.Font = new Font("Segoe UI", 10F);
            btnUpload.Location = new Point(553, 118);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(74, 34);
            btnUpload.TabIndex = 47;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // picCarPart
            // 
            picCarPart.Location = new Point(645, 86);
            picCarPart.Name = "picCarPart";
            picCarPart.Size = new Size(299, 186);
            picCarPart.SizeMode = PictureBoxSizeMode.StretchImage;
            picCarPart.TabIndex = 46;
            picCarPart.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(553, 87);
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
            label8.Location = new Point(15, 301);
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
            label7.Location = new Point(15, 342);
            label7.Name = "label7";
            label7.Size = new Size(199, 23);
            label7.TabIndex = 41;
            label7.Text = "Manufactured Date:";
            // 
            // txtDesc
            // 
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesc.Location = new Point(233, 218);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(279, 66);
            txtDesc.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 218);
            label5.Name = "label5";
            label5.Size = new Size(172, 23);
            label5.TabIndex = 37;
            label5.Text = "Part Description:";
            // 
            // ddlColors
            // 
            ddlColors.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ddlColors.FormattingEnabled = true;
            ddlColors.Location = new Point(233, 173);
            ddlColors.Name = "ddlColors";
            ddlColors.Size = new Size(279, 26);
            ddlColors.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 173);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 35;
            label2.Text = "Car Part Color:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(207, 2, 2);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(864, 335);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 35);
            btnSave.TabIndex = 34;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 131);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 32;
            label4.Text = "Car Type:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(233, 89);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 23);
            txtName.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(207, 2, 2);
            label3.Location = new Point(12, 22);
            label3.Name = "label3";
            label3.Size = new Size(268, 29);
            label3.TabIndex = 30;
            label3.Text = "Enter Car Part Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 89);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 29;
            label1.Text = "Car Part Name:";
            // 
            // ddlCarType
            // 
            ddlCarType.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ddlCarType.FormattingEnabled = true;
            ddlCarType.Location = new Point(233, 132);
            ddlCarType.Name = "ddlCarType";
            ddlCarType.Size = new Size(279, 26);
            ddlCarType.TabIndex = 50;
            // 
            // CarPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(983, 394);
            Controls.Add(ddlCarType);
            Controls.Add(txtCarPartId);
            Controls.Add(btnBack);
            Controls.Add(btnUpload);
            Controls.Add(picCarPart);
            Controls.Add(label9);
            Controls.Add(txtPrice);
            Controls.Add(label8);
            Controls.Add(dateManuDate);
            Controls.Add(label7);
            Controls.Add(txtDesc);
            Controls.Add(label5);
            Controls.Add(ddlColors);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CarPartForm";
            Text = "CarPartForm";
            Load += CarPartForm_Load;
            ((System.ComponentModel.ISupportInitialize)picCarPart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCarPartId;
        private Button btnBack;
        private Button btnUpload;
        private PictureBox picCarPart;
        private Label label9;
        private TextBox txtPrice;
        private Label label8;
        private DateTimePicker dateManuDate;
        private Label label7;
        private TextBox txtDesc;
        private Label label5;
        private ComboBox ddlColors;
        private Label label2;
        private Button btnSave;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private Label label1;
        private ComboBox ddlCarType;
    }
}