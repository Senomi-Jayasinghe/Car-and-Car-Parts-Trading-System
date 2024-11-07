namespace ABCCarTraders
{
    partial class CustomerHomeUI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHomeUI));
            panel1 = new Panel();
            btnMenu = new Button();
            btnHome = new LinkLabel();
            ddlMenu = new ContextMenuStrip(components);
            ddlLogOut = new ToolStripMenuItem();
            picCar = new PictureBox();
            picCarparts = new PictureBox();
            picOrders = new PictureBox();
            pnlCars = new Panel();
            label1 = new Label();
            pnlCarParts = new Panel();
            label2 = new Label();
            pnlOrders = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            ddlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCarparts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOrders).BeginInit();
            pnlCars.SuspendLayout();
            pnlCarParts.SuspendLayout();
            pnlOrders.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(207, 2, 2);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(-7, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 52);
            panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(207, 2, 2);
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMenu.Location = new Point(778, 17);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Profile";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnHome
            // 
            btnHome.AutoSize = true;
            btnHome.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.LinkBehavior = LinkBehavior.NeverUnderline;
            btnHome.LinkColor = Color.White;
            btnHome.Location = new Point(19, 19);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(59, 18);
            btnHome.TabIndex = 0;
            btnHome.TabStop = true;
            btnHome.Text = "Home";
            btnHome.LinkClicked += btnHome_LinkClicked;
            // 
            // ddlMenu
            // 
            ddlMenu.Items.AddRange(new ToolStripItem[] { ddlLogOut });
            ddlMenu.Name = "contextMenuStrip1";
            ddlMenu.Size = new Size(120, 26);
            // 
            // ddlLogOut
            // 
            ddlLogOut.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ddlLogOut.Name = "ddlLogOut";
            ddlLogOut.Size = new Size(119, 22);
            ddlLogOut.Text = "Logout";
            ddlLogOut.Click += ddlLogOut_Click;
            // 
            // picCar
            // 
            picCar.Image = (Image)resources.GetObject("picCar.Image");
            picCar.Location = new Point(3, 3);
            picCar.Name = "picCar";
            picCar.Size = new Size(251, 187);
            picCar.SizeMode = PictureBoxSizeMode.StretchImage;
            picCar.TabIndex = 2;
            picCar.TabStop = false;
            picCar.Paint += picCar_Paint;
            // 
            // picCarparts
            // 
            picCarparts.Image = (Image)resources.GetObject("picCarparts.Image");
            picCarparts.Location = new Point(3, 3);
            picCarparts.Name = "picCarparts";
            picCarparts.Size = new Size(251, 187);
            picCarparts.SizeMode = PictureBoxSizeMode.StretchImage;
            picCarparts.TabIndex = 3;
            picCarparts.TabStop = false;
            picCarparts.Paint += picCarparts_Paint;
            // 
            // picOrders
            // 
            picOrders.Image = (Image)resources.GetObject("picOrders.Image");
            picOrders.Location = new Point(3, 3);
            picOrders.Name = "picOrders";
            picOrders.Size = new Size(252, 187);
            picOrders.SizeMode = PictureBoxSizeMode.StretchImage;
            picOrders.TabIndex = 4;
            picOrders.TabStop = false;
            picOrders.Paint += picOrders_Paint;
            // 
            // pnlCars
            // 
            pnlCars.Controls.Add(label1);
            pnlCars.Controls.Add(picCar);
            pnlCars.ForeColor = SystemColors.ActiveCaptionText;
            pnlCars.Location = new Point(22, 105);
            pnlCars.Name = "pnlCars";
            pnlCars.Size = new Size(257, 313);
            pnlCars.TabIndex = 5;
            pnlCars.Click += pnlCars_Click;
            pnlCars.Paint += pnlCars_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(207, 2, 2);
            label1.Location = new Point(13, 204);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.TabIndex = 3;
            label1.Text = "Explore Cars";
            // 
            // pnlCarParts
            // 
            pnlCarParts.Controls.Add(label2);
            pnlCarParts.Controls.Add(picCarparts);
            pnlCarParts.ForeColor = SystemColors.ActiveCaptionText;
            pnlCarParts.Location = new Point(304, 105);
            pnlCarParts.Name = "pnlCarParts";
            pnlCarParts.Size = new Size(257, 313);
            pnlCarParts.TabIndex = 6;
            pnlCarParts.Click += pnlCarParts_Click;
            pnlCarParts.Paint += pnlCarParts_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(207, 2, 2);
            label2.Location = new Point(13, 204);
            label2.Name = "label2";
            label2.Size = new Size(197, 23);
            label2.TabIndex = 3;
            label2.Text = "Explore Car Parts";
            // 
            // pnlOrders
            // 
            pnlOrders.Controls.Add(label3);
            pnlOrders.Controls.Add(picOrders);
            pnlOrders.ForeColor = SystemColors.ActiveCaptionText;
            pnlOrders.Location = new Point(586, 105);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(257, 313);
            pnlOrders.TabIndex = 7;
            pnlOrders.Click += pnlOrders_Click;
            pnlOrders.Paint += pnlOrders_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(207, 2, 2);
            label3.Location = new Point(13, 204);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 3;
            label3.Text = "My Orders";
            // 
            // CustomerHomeUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(858, 492);
            Controls.Add(pnlOrders);
            Controls.Add(pnlCarParts);
            Controls.Add(pnlCars);
            Controls.Add(panel1);
            Name = "CustomerHomeUI";
            Text = "CustomerHomeUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ddlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCarparts).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOrders).EndInit();
            pnlCars.ResumeLayout(false);
            pnlCars.PerformLayout();
            pnlCarParts.ResumeLayout(false);
            pnlCarParts.PerformLayout();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel btnHome;
        private Button btnMenu;
        private ContextMenuStrip ddlMenu;
        private ToolStripMenuItem ddlLogOut;
        private PictureBox picCar;
        private PictureBox picCarparts;
        private PictureBox picOrders;
        private Panel pnlCars;
        private Label label1;
        private Panel pnlCarParts;
        private Label label2;
        private Panel pnlOrders;
        private Label label3;
    }
}