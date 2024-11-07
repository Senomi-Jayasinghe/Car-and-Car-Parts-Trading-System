namespace ABCCarTraders
{
    partial class CarsUI
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
            grdCars = new DataGridView();
            label3 = new Label();
            btnAdd = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)grdCars).BeginInit();
            SuspendLayout();
            // 
            // grdCars
            // 
            grdCars.BackgroundColor = SystemColors.ButtonHighlight;
            grdCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCars.GridColor = Color.Black;
            grdCars.Location = new Point(31, 80);
            grdCars.Name = "grdCars";
            grdCars.Size = new Size(736, 341);
            grdCars.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(207, 2, 2);
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(143, 29);
            label3.TabIndex = 10;
            label3.Text = "Car Details";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(207, 2, 2);
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(703, 39);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(64, 35);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "+Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Verdana", 10F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(624, 40);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(73, 35);
            btnBack.TabIndex = 19;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // CarsUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(grdCars);
            Name = "CarsUI";
            Text = "Cars";
            Load += CarsUI_Load;
            ((System.ComponentModel.ISupportInitialize)grdCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdCars;
        private Label label3;
        private Button btnAdd;
        private Button btnBack;
    }
}