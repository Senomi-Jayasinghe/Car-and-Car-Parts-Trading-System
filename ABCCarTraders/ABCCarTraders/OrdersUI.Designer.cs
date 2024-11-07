namespace ABCCarTraders
{
    partial class OrdersUI
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
            grdCarOrders = new DataGridView();
            grdCarPartOrders = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)grdCarOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdCarPartOrders).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(207, 2, 2);
            label3.Location = new Point(12, 20);
            label3.Name = "label3";
            label3.Size = new Size(166, 29);
            label3.TabIndex = 12;
            label3.Text = "Track Orders";
            // 
            // grdCarOrders
            // 
            grdCarOrders.BackgroundColor = SystemColors.ButtonHighlight;
            grdCarOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCarOrders.GridColor = Color.Black;
            grdCarOrders.Location = new Point(12, 102);
            grdCarOrders.Name = "grdCarOrders";
            grdCarOrders.Size = new Size(644, 200);
            grdCarOrders.TabIndex = 13;
            // 
            // grdCarPartOrders
            // 
            grdCarPartOrders.BackgroundColor = SystemColors.ButtonHighlight;
            grdCarPartOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCarPartOrders.GridColor = Color.Black;
            grdCarPartOrders.Location = new Point(12, 347);
            grdCarPartOrders.Name = "grdCarPartOrders";
            grdCarPartOrders.Size = new Size(749, 200);
            grdCarPartOrders.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16F);
            label1.ForeColor = Color.FromArgb(207, 2, 2);
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(130, 26);
            label1.TabIndex = 15;
            label1.Text = "Car Orders";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 16F);
            label2.ForeColor = Color.FromArgb(207, 2, 2);
            label2.Location = new Point(12, 318);
            label2.Name = "label2";
            label2.Size = new Size(192, 26);
            label2.TabIndex = 16;
            label2.Text = "Car Parts Orders";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Verdana", 10F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(688, 22);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(73, 35);
            btnBack.TabIndex = 20;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // OrdersUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(795, 568);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grdCarPartOrders);
            Controls.Add(grdCarOrders);
            Controls.Add(label3);
            Name = "OrdersUI";
            Text = "OrdersUI";
            Load += OrdersUI_Load;
            ((System.ComponentModel.ISupportInitialize)grdCarOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdCarPartOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DataGridView grdCarOrders;
        private DataGridView grdCarPartOrders;
        private Label label1;
        private Label label2;
        private Button btnBack;
    }
}