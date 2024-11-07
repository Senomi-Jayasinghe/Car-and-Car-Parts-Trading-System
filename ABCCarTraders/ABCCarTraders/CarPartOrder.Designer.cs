namespace ABCCarTraders
{
    partial class CarPartOrder
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
            btnSearch = new Button();
            ddlColors = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            grdCarParts = new DataGridView();
            label3 = new Label();
            ddlCarType = new ComboBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)grdCarParts).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(207, 2, 2);
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(35, 94);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 35);
            btnSearch.TabIndex = 28;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // ddlColors
            // 
            ddlColors.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ddlColors.FormattingEnabled = true;
            ddlColors.Location = new Point(598, 54);
            ddlColors.Name = "ddlColors";
            ddlColors.Size = new Size(173, 26);
            ddlColors.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13F);
            label4.Location = new Point(534, 58);
            label4.Name = "label4";
            label4.Size = new Size(58, 22);
            label4.TabIndex = 26;
            label4.Text = "Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13F);
            label2.Location = new Point(296, 58);
            label2.Name = "label2";
            label2.Size = new Size(42, 22);
            label2.TabIndex = 24;
            label2.Text = "Car";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(102, 59);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(164, 22);
            txtName.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13F);
            label1.Location = new Point(33, 58);
            label1.Name = "label1";
            label1.Size = new Size(63, 22);
            label1.TabIndex = 22;
            label1.Text = "Name";
            // 
            // grdCarParts
            // 
            grdCarParts.BackgroundColor = SystemColors.ButtonHighlight;
            grdCarParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCarParts.GridColor = Color.Black;
            grdCarParts.Location = new Point(35, 135);
            grdCarParts.Name = "grdCarParts";
            grdCarParts.Size = new Size(736, 292);
            grdCarParts.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(207, 2, 2);
            label3.Location = new Point(29, 14);
            label3.Name = "label3";
            label3.Size = new Size(290, 29);
            label3.TabIndex = 20;
            label3.Text = "Search and Order Parts";
            // 
            // ddlCarType
            // 
            ddlCarType.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ddlCarType.FormattingEnabled = true;
            ddlCarType.Location = new Point(344, 58);
            ddlCarType.Name = "ddlCarType";
            ddlCarType.Size = new Size(173, 26);
            ddlCarType.TabIndex = 29;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Verdana", 10F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(698, 16);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(73, 35);
            btnBack.TabIndex = 30;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // CarPartOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(ddlCarType);
            Controls.Add(btnSearch);
            Controls.Add(ddlColors);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(grdCarParts);
            Controls.Add(label3);
            Name = "CarPartOrder";
            Text = "CarPartOrder";
            Load += CarPartOrder_Load;
            ((System.ComponentModel.ISupportInitialize)grdCarParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private ComboBox ddlColors;
        private Label label4;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private DataGridView grdCarParts;
        private Label label3;
        private ComboBox ddlCarType;
        private Button btnBack;
    }
}