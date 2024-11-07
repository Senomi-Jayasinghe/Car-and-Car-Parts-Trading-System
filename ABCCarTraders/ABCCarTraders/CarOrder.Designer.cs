namespace ABCCarTraders
{
    partial class CarOrder
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
            label3 = new Label();
            grdCars = new DataGridView();
            txtType = new TextBox();
            label1 = new Label();
            txtBrand = new TextBox();
            label2 = new Label();
            label4 = new Label();
            ddlColors = new ComboBox();
            btnSearch = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)grdCars).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(207, 2, 2);
            label3.Location = new Point(12, 21);
            label3.Name = "label3";
            label3.Size = new Size(285, 29);
            label3.TabIndex = 11;
            label3.Text = "Search and Order Cars";
            // 
            // grdCars
            // 
            grdCars.BackgroundColor = SystemColors.ButtonHighlight;
            grdCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCars.GridColor = Color.Black;
            grdCars.Location = new Point(18, 142);
            grdCars.Name = "grdCars";
            grdCars.Size = new Size(736, 341);
            grdCars.TabIndex = 12;
            // 
            // txtType
            // 
            txtType.BackColor = Color.White;
            txtType.BorderStyle = BorderStyle.FixedSingle;
            txtType.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtType.ForeColor = Color.Black;
            txtType.Location = new Point(85, 65);
            txtType.Multiline = true;
            txtType.Name = "txtType";
            txtType.Size = new Size(164, 22);
            txtType.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13F);
            label1.Location = new Point(27, 65);
            label1.Name = "label1";
            label1.Size = new Size(52, 22);
            label1.TabIndex = 13;
            label1.Text = "Type";
            // 
            // txtBrand
            // 
            txtBrand.BackColor = Color.White;
            txtBrand.BorderStyle = BorderStyle.FixedSingle;
            txtBrand.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrand.ForeColor = Color.Black;
            txtBrand.Location = new Point(333, 65);
            txtBrand.Multiline = true;
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(164, 22);
            txtBrand.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13F);
            label2.Location = new Point(264, 65);
            label2.Name = "label2";
            label2.Size = new Size(63, 22);
            label2.TabIndex = 15;
            label2.Text = "Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13F);
            label4.Location = new Point(517, 65);
            label4.Name = "label4";
            label4.Size = new Size(58, 22);
            label4.TabIndex = 17;
            label4.Text = "Color";
            // 
            // ddlColors
            // 
            ddlColors.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ddlColors.FormattingEnabled = true;
            ddlColors.Location = new Point(581, 61);
            ddlColors.Name = "ddlColors";
            ddlColors.Size = new Size(173, 26);
            ddlColors.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(207, 2, 2);
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(18, 101);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 35);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Verdana", 10F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(681, 15);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(73, 35);
            btnBack.TabIndex = 21;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // CarOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(766, 505);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(ddlColors);
            Controls.Add(label4);
            Controls.Add(txtBrand);
            Controls.Add(label2);
            Controls.Add(txtType);
            Controls.Add(label1);
            Controls.Add(grdCars);
            Controls.Add(label3);
            Name = "CarOrder";
            Text = "CarOrder";
            Load += CarOrder_Load;
            ((System.ComponentModel.ISupportInitialize)grdCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DataGridView grdCars;
        private TextBox txtType;
        private Label label1;
        private TextBox txtBrand;
        private Label label2;
        private Label label4;
        private ComboBox ddlColors;
        private Button btnSearch;
        private Button btnBack;
    }
}