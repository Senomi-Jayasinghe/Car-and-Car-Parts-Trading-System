namespace ABCCarTraders
{
    partial class AdminHomeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomeUI));
            panel1 = new Panel();
            btnMenu = new Button();
            btnHome = new LinkLabel();
            ddlMenu = new ContextMenuStrip(components);
            ddlLogOut = new ToolStripMenuItem();
            pnlCars = new Panel();
            label1 = new Label();
            picCar = new PictureBox();
            pnlCarParts = new Panel();
            label2 = new Label();
            picCarparts = new PictureBox();
            pnlOrders = new Panel();
            label3 = new Label();
            picOrders = new PictureBox();
            pnlCustomer = new Panel();
            picCustomer = new PictureBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ddlMenu.SuspendLayout();
            pnlCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            pnlCarParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCarparts).BeginInit();
            pnlOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOrders).BeginInit();
            pnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(207, 2, 2);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 52);
            panel1.TabIndex = 1;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(207, 2, 2);
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMenu.Location = new Point(634, 17);
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
            ddlMenu.Opening += ddlMenu_Opening;
            // 
            // ddlLogOut
            // 
            ddlLogOut.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ddlLogOut.Name = "ddlLogOut";
            ddlLogOut.Size = new Size(180, 22);
            ddlLogOut.Text = "Logout";
            ddlLogOut.Click += ddlLogOut_Click;
            // 
            // pnlCars
            // 
            pnlCars.Controls.Add(label1);
            pnlCars.Controls.Add(picCar);
            pnlCars.ForeColor = SystemColors.ActiveCaptionText;
            pnlCars.Location = new Point(59, 73);
            pnlCars.Name = "pnlCars";
            pnlCars.Size = new Size(257, 280);
            pnlCars.TabIndex = 6;
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
            label1.Size = new Size(220, 23);
            label1.TabIndex = 3;
            label1.Text = "Manage Car Details";
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
            // pnlCarParts
            // 
            pnlCarParts.Controls.Add(label2);
            pnlCarParts.Controls.Add(picCarparts);
            pnlCarParts.ForeColor = SystemColors.ActiveCaptionText;
            pnlCarParts.Location = new Point(373, 73);
            pnlCarParts.Name = "pnlCarParts";
            pnlCarParts.Size = new Size(257, 280);
            pnlCarParts.TabIndex = 7;
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
            label2.Size = new Size(196, 46);
            label2.TabIndex = 3;
            label2.Text = "Manage Car Part \r\nDetails";
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
            // pnlOrders
            // 
            pnlOrders.Controls.Add(label3);
            pnlOrders.Controls.Add(picOrders);
            pnlOrders.ForeColor = SystemColors.ActiveCaptionText;
            pnlOrders.Location = new Point(59, 379);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(257, 280);
            pnlOrders.TabIndex = 8;
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
            label3.Size = new Size(211, 46);
            label3.TabIndex = 3;
            label3.Text = "Manage Customer \r\nOrders";
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
            // pnlCustomer
            // 
            pnlCustomer.Controls.Add(picCustomer);
            pnlCustomer.Controls.Add(label4);
            pnlCustomer.ForeColor = SystemColors.ActiveCaptionText;
            pnlCustomer.Location = new Point(373, 379);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new Size(257, 280);
            pnlCustomer.TabIndex = 8;
            pnlCustomer.Click += pnlCustomer_Click;
            pnlCustomer.Paint += pnlCustomer_Paint;
            // 
            // picCustomer
            // 
            picCustomer.Image = (Image)resources.GetObject("picCustomer.Image");
            picCustomer.Location = new Point(3, 3);
            picCustomer.Name = "picCustomer";
            picCustomer.Size = new Size(251, 187);
            picCustomer.SizeMode = PictureBoxSizeMode.Zoom;
            picCustomer.TabIndex = 4;
            picCustomer.TabStop = false;
            picCustomer.Paint += picCustomer_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(207, 2, 2);
            label4.Location = new Point(13, 204);
            label4.Name = "label4";
            label4.Size = new Size(211, 46);
            label4.TabIndex = 3;
            label4.Text = "Manage Customer \r\nDetails";
            // 
            // AdminHomeUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(722, 682);
            Controls.Add(pnlCustomer);
            Controls.Add(pnlOrders);
            Controls.Add(pnlCarParts);
            Controls.Add(pnlCars);
            Controls.Add(panel1);
            Name = "AdminHomeUI";
            Text = "AdminHomeUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ddlMenu.ResumeLayout(false);
            pnlCars.ResumeLayout(false);
            pnlCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            pnlCarParts.ResumeLayout(false);
            pnlCarParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCarparts).EndInit();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOrders).EndInit();
            pnlCustomer.ResumeLayout(false);
            pnlCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMenu;
        private LinkLabel btnHome;
        private ContextMenuStrip ddlMenu;
        private ToolStripMenuItem ddlLogOut;
        private Panel pnlCars;
        private Label label1;
        private PictureBox picCar;
        private Panel pnlCarParts;
        private Label label2;
        private PictureBox picCarparts;
        private Panel pnlOrders;
        private Label label3;
        private PictureBox picOrders;
        private Panel pnlCustomer;
        private Label label4;
        private PictureBox picCustomer;
    }
}