namespace ABCCarTraders
{
    partial class CarPartsUI
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
            btnAdd = new Button();
            label3 = new Label();
            grdCarParts = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)grdCarParts).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(207, 2, 2);
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(714, 39);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(64, 35);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "+Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(207, 2, 2);
            label3.Location = new Point(23, 18);
            label3.Name = "label3";
            label3.Size = new Size(197, 29);
            label3.TabIndex = 16;
            label3.Text = "Car Part Details";
            // 
            // grdCarParts
            // 
            grdCarParts.BackgroundColor = SystemColors.ButtonHighlight;
            grdCarParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCarParts.GridColor = Color.Black;
            grdCarParts.Location = new Point(42, 80);
            grdCarParts.Name = "grdCarParts";
            grdCarParts.Size = new Size(736, 341);
            grdCarParts.TabIndex = 15;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Verdana", 10F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(635, 39);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(73, 35);
            btnBack.TabIndex = 18;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // CarPartsUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(grdCarParts);
            Name = "CarPartsUI";
            Text = "CarPartsUI";
            Load += CarPartsUI_Load;
            ((System.ComponentModel.ISupportInitialize)grdCarParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label3;
        private DataGridView grdCarParts;
        private Button btnBack;
    }
}