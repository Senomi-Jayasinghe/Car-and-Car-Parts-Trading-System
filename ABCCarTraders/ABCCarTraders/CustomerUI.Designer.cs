namespace ABCCarTraders
{
    partial class CustomerUI
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
            grdCustomers = new DataGridView();
            label3 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)grdCustomers).BeginInit();
            SuspendLayout();
            // 
            // grdCustomers
            // 
            grdCustomers.BackgroundColor = SystemColors.ButtonHighlight;
            grdCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCustomers.GridColor = Color.Black;
            grdCustomers.Location = new Point(99, 79);
            grdCustomers.Name = "grdCustomers";
            grdCustomers.Size = new Size(599, 341);
            grdCustomers.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(207, 2, 2);
            label3.Location = new Point(29, 21);
            label3.Name = "label3";
            label3.Size = new Size(193, 29);
            label3.TabIndex = 14;
            label3.Text = "Customer Data";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Verdana", 10F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(688, 21);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(73, 35);
            btnBack.TabIndex = 22;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // CustomerUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(label3);
            Controls.Add(grdCustomers);
            Name = "CustomerUI";
            Text = "CustomerUI";
            ((System.ComponentModel.ISupportInitialize)grdCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdCustomers;
        private Label label3;
        private Button btnBack;
    }
}