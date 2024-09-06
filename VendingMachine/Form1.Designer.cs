
namespace WindowsFormsApp1_coursewk_
{
    partial class VendingMachine
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
            this.listBoxitems = new System.Windows.Forms.ListBox();
            this.ListBoxCancel = new System.Windows.Forms.Button();
            this.OrderTotallabel = new System.Windows.Forms.Label();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fivepound = new System.Windows.Forms.Button();
            this.FinalTotallabel = new System.Windows.Forms.Label();
            this.PaymentSystem = new System.Windows.Forms.GroupBox();
            this.Coinslot = new System.Windows.Forms.PictureBox();
            this.Checkout = new System.Windows.Forms.Button();
            this.fiftypence = new System.Windows.Forms.Button();
            this.pound = new System.Windows.Forms.Button();
            this.Twopound = new System.Windows.Forms.Button();
            this.Tenpence = new System.Windows.Forms.Button();
            this.twentypence = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonsweets = new System.Windows.Forms.Button();
            this.buttoncrisps = new System.Windows.Forms.Button();
            this.buttondrinks = new System.Windows.Forms.Button();
            this.buttonchocolate = new System.Windows.Forms.Button();
            this.PaymentSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Coinslot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxitems
            // 
            this.listBoxitems.AllowDrop = true;
            this.listBoxitems.FormattingEnabled = true;
            this.listBoxitems.ItemHeight = 29;
            this.listBoxitems.Location = new System.Drawing.Point(399, 14);
            this.listBoxitems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxitems.Name = "listBoxitems";
            this.listBoxitems.Size = new System.Drawing.Size(261, 294);
            this.listBoxitems.TabIndex = 4;
            this.listBoxitems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxitems_MouseDown);
            this.listBoxitems.SelectedIndexChanged += new System.EventHandler(this.listBoxitems_SelectedIndexChanged_1);
            this.listBoxitems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxitems_MouseDown);
            // 
            // ListBoxCancel
            // 
            this.ListBoxCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListBoxCancel.Location = new System.Drawing.Point(689, 14);
            this.ListBoxCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBoxCancel.Name = "ListBoxCancel";
            this.ListBoxCancel.Size = new System.Drawing.Size(191, 121);
            this.ListBoxCancel.TabIndex = 5;
            this.ListBoxCancel.Text = "Cancel Order";
            this.ListBoxCancel.UseVisualStyleBackColor = true;
            this.ListBoxCancel.Click += new System.EventHandler(this.ListBoxCancel_Click);
            // 
            // OrderTotallabel
            // 
            this.OrderTotallabel.AutoSize = true;
            this.OrderTotallabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderTotallabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderTotallabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderTotallabel.Location = new System.Drawing.Point(399, 313);
            this.OrderTotallabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderTotallabel.Name = "OrderTotallabel";
            this.OrderTotallabel.Size = new System.Drawing.Size(199, 31);
            this.OrderTotallabel.TabIndex = 6;
            this.OrderTotallabel.Text = "Order Total £    ";
            this.OrderTotallabel.Click += new System.EventHandler(this.OrderTotallabel_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ContinueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ContinueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueButton.Location = new System.Drawing.Point(684, 313);
            this.ContinueButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(196, 38);
            this.ContinueButton.TabIndex = 7;
            this.ContinueButton.Text = "Continue ";
            this.ContinueButton.UseVisualStyleBackColor = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // fivepound
            // 
            this.fivepound.Image = global::WindowsFormsApp1_coursewk_.Properties.Resources.download__9_;
            this.fivepound.Location = new System.Drawing.Point(424, 181);
            this.fivepound.Name = "fivepound";
            this.fivepound.Size = new System.Drawing.Size(137, 124);
            this.fivepound.TabIndex = 14;
            this.fivepound.Text = "£5";
            this.fivepound.UseVisualStyleBackColor = true;
            this.fivepound.Click += new System.EventHandler(this.fivepound_Click);
            // 
            // FinalTotallabel
            // 
            this.FinalTotallabel.AutoSize = true;
            this.FinalTotallabel.BackColor = System.Drawing.Color.Honeydew;
            this.FinalTotallabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FinalTotallabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FinalTotallabel.Location = new System.Drawing.Point(667, 15);
            this.FinalTotallabel.Name = "FinalTotallabel";
            this.FinalTotallabel.Size = new System.Drawing.Size(118, 31);
            this.FinalTotallabel.TabIndex = 15;
            this.FinalTotallabel.Text = "To Pay £";
            this.FinalTotallabel.Click += new System.EventHandler(this.FinalTotallabel_Click);
            // 
            // PaymentSystem
            // 
            this.PaymentSystem.BackColor = System.Drawing.Color.Lime;
            this.PaymentSystem.Controls.Add(this.Coinslot);
            this.PaymentSystem.Controls.Add(this.Checkout);
            this.PaymentSystem.Controls.Add(this.fiftypence);
            this.PaymentSystem.Controls.Add(this.pound);
            this.PaymentSystem.Controls.Add(this.Twopound);
            this.PaymentSystem.Controls.Add(this.fivepound);
            this.PaymentSystem.Controls.Add(this.FinalTotallabel);
            this.PaymentSystem.Controls.Add(this.Tenpence);
            this.PaymentSystem.Controls.Add(this.twentypence);
            this.PaymentSystem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PaymentSystem.Location = new System.Drawing.Point(12, 359);
            this.PaymentSystem.Name = "PaymentSystem";
            this.PaymentSystem.Size = new System.Drawing.Size(868, 341);
            this.PaymentSystem.TabIndex = 16;
            this.PaymentSystem.TabStop = false;
            this.PaymentSystem.Text = "Payment";
            this.PaymentSystem.Enter += new System.EventHandler(this.PaymentSystem_Enter);
            // 
            // Coinslot
            // 
            this.Coinslot.Image = global::WindowsFormsApp1_coursewk_.Properties.Resources.ssss1;
            this.Coinslot.Location = new System.Drawing.Point(667, 73);
            this.Coinslot.Name = "Coinslot";
            this.Coinslot.Size = new System.Drawing.Size(145, 167);
            this.Coinslot.TabIndex = 17;
            this.Coinslot.TabStop = false;
            this.Coinslot.Click += new System.EventHandler(this.Coinslot_Click);
            this.Coinslot.DragDrop += new System.Windows.Forms.DragEventHandler(this.CoinslotDragDrop);
            this.Coinslot.DragEnter += new System.Windows.Forms.DragEventHandler(this.CoinslotDragEnter);
            this.Coinslot.MouseEnter += new System.EventHandler(this.Coinslot_Click);
            // 
            // Checkout
            // 
            this.Checkout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Checkout.ForeColor = System.Drawing.Color.Lime;
            this.Checkout.Location = new System.Drawing.Point(651, 264);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(193, 41);
            this.Checkout.TabIndex = 16;
            this.Checkout.Text = "Checkout";
            this.Checkout.UseVisualStyleBackColor = false;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // fiftypence
            // 
            this.fiftypence.Image = global::WindowsFormsApp1_coursewk_.Properties.Resources.download__6_;
            this.fiftypence.Location = new System.Drawing.Point(424, 24);
            this.fiftypence.Name = "fiftypence";
            this.fiftypence.Size = new System.Drawing.Size(137, 141);
            this.fiftypence.TabIndex = 11;
            this.fiftypence.Text = "50p";
            this.fiftypence.UseVisualStyleBackColor = true;
            this.fiftypence.Click += new System.EventHandler(this.fiftypence_Click);
            // 
            // pound
            // 
            this.pound.Image = global::WindowsFormsApp1_coursewk_.Properties.Resources.download__7_;
            this.pound.Location = new System.Drawing.Point(46, 171);
            this.pound.Name = "pound";
            this.pound.Size = new System.Drawing.Size(136, 134);
            this.pound.TabIndex = 12;
            this.pound.Text = "£1";
            this.pound.UseVisualStyleBackColor = true;
            this.pound.Click += new System.EventHandler(this.pound_Click);
            // 
            // Twopound
            // 
            this.Twopound.Image = global::WindowsFormsApp1_coursewk_.Properties.Resources.download__8_;
            this.Twopound.Location = new System.Drawing.Point(239, 181);
            this.Twopound.Name = "Twopound";
            this.Twopound.Size = new System.Drawing.Size(150, 124);
            this.Twopound.TabIndex = 13;
            this.Twopound.Text = "£2";
            this.Twopound.UseVisualStyleBackColor = true;
            this.Twopound.Click += new System.EventHandler(this.Twopound_Click);
            // 
            // Tenpence
            // 
            this.Tenpence.Image = global::WindowsFormsApp1_coursewk_.Properties.Resources.download__4_;
            this.Tenpence.Location = new System.Drawing.Point(46, 24);
            this.Tenpence.Name = "Tenpence";
            this.Tenpence.Size = new System.Drawing.Size(136, 141);
            this.Tenpence.TabIndex = 9;
            this.Tenpence.Text = "10p";
            this.Tenpence.UseVisualStyleBackColor = true;
            this.Tenpence.Click += new System.EventHandler(this.Tenpence_Click);
            this.Tenpence.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tenpence_MouseDown);
            this.Tenpence.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tenpence_MouseDown);
            // 
            // twentypence
            // 
            this.twentypence.Image = global::WindowsFormsApp1_coursewk_.Properties.Resources.download__5_;
            this.twentypence.Location = new System.Drawing.Point(239, 24);
            this.twentypence.Name = "twentypence";
            this.twentypence.Size = new System.Drawing.Size(150, 141);
            this.twentypence.TabIndex = 10;
            this.twentypence.Text = "20p";
            this.twentypence.UseVisualStyleBackColor = true;
            this.twentypence.Click += new System.EventHandler(this.twentypence_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1_coursewk_.Properties.Resources.download__3_;
            this.pictureBox1.Location = new System.Drawing.Point(708, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 116);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1DragEnter);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxitems_MouseDown);
            // 
            // buttonsweets
            // 
            this.buttonsweets.BackColor = System.Drawing.Color.Lime;
            this.buttonsweets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsweets.ForeColor = System.Drawing.Color.Transparent;
            this.buttonsweets.Image = global::WindowsFormsApp1_coursewk_.Properties.Resources.download;
            this.buttonsweets.Location = new System.Drawing.Point(27, 14);
            this.buttonsweets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonsweets.Name = "buttonsweets";
            this.buttonsweets.Size = new System.Drawing.Size(152, 145);
            this.buttonsweets.TabIndex = 0;
            this.buttonsweets.Text = "Sweets\r\n - 50p";
            this.buttonsweets.UseVisualStyleBackColor = false;
            this.buttonsweets.Click += new System.EventHandler(this.buttonsweets_Click);
            // 
            // buttoncrisps
            // 
            this.buttoncrisps.BackColor = System.Drawing.Color.Maroon;
            this.buttoncrisps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncrisps.ForeColor = System.Drawing.Color.Transparent;
            this.buttoncrisps.Image = global::WindowsFormsApp1_coursewk_.Properties.Resources.download__2_;
            this.buttoncrisps.Location = new System.Drawing.Point(215, 181);
            this.buttoncrisps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttoncrisps.Name = "buttoncrisps";
            this.buttoncrisps.Size = new System.Drawing.Size(150, 127);
            this.buttoncrisps.TabIndex = 3;
            this.buttoncrisps.Text = "Crisps \r\n- 65p";
            this.buttoncrisps.UseVisualStyleBackColor = false;
            this.buttoncrisps.Click += new System.EventHandler(this.buttoncrisps_Click);
            // 
            // buttondrinks
            // 
            this.buttondrinks.BackColor = System.Drawing.Color.Lime;
            this.buttondrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondrinks.ForeColor = System.Drawing.Color.Transparent;
            this.buttondrinks.Image = global::WindowsFormsApp1_coursewk_.Properties.Resources.images;
            this.buttondrinks.Location = new System.Drawing.Point(215, 14);
            this.buttondrinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttondrinks.Name = "buttondrinks";
            this.buttondrinks.Size = new System.Drawing.Size(150, 145);
            this.buttondrinks.TabIndex = 1;
            this.buttondrinks.Text = "Soft Drinks\r\n - £1";
            this.buttondrinks.UseVisualStyleBackColor = false;
            this.buttondrinks.Click += new System.EventHandler(this.buttondrinks_Click);
            // 
            // buttonchocolate
            // 
            this.buttonchocolate.BackColor = System.Drawing.Color.Lime;
            this.buttonchocolate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonchocolate.ForeColor = System.Drawing.Color.Transparent;
            this.buttonchocolate.Image = global::WindowsFormsApp1_coursewk_.Properties.Resources.images__1_;
            this.buttonchocolate.Location = new System.Drawing.Point(27, 190);
            this.buttonchocolate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonchocolate.Name = "buttonchocolate";
            this.buttonchocolate.Size = new System.Drawing.Size(152, 118);
            this.buttonchocolate.TabIndex = 2;
            this.buttonchocolate.Text = "Chocolate Bar \r\n- 75p";
            this.buttonchocolate.UseVisualStyleBackColor = false;
            this.buttonchocolate.Click += new System.EventHandler(this.buttonchocolate_Click);
            // 
            // VendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(987, 714);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonsweets);
            this.Controls.Add(this.buttoncrisps);
            this.Controls.Add(this.buttondrinks);
            this.Controls.Add(this.buttonchocolate);
            this.Controls.Add(this.ListBoxCancel);
            this.Controls.Add(this.OrderTotallabel);
            this.Controls.Add(this.listBoxitems);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.PaymentSystem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "VendingMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vending Machine : 30054008";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PaymentSystem.ResumeLayout(false);
            this.PaymentSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Coinslot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonsweets;
        private System.Windows.Forms.Button buttoncrisps;
        private System.Windows.Forms.Button buttonchocolate;
        private System.Windows.Forms.Button buttondrinks;
        private System.Windows.Forms.ListBox listBoxitems;
        private System.Windows.Forms.Button ListBoxCancel;
        private System.Windows.Forms.Label OrderTotallabel;
        private System.Windows.Forms.Button ContinueButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Tenpence;
        private System.Windows.Forms.Button twentypence;
        private System.Windows.Forms.Button fiftypence;
        private System.Windows.Forms.Button pound;
        private System.Windows.Forms.Button Twopound;
        private System.Windows.Forms.Button fivepound;
        private System.Windows.Forms.Label FinalTotallabel;
        private System.Windows.Forms.GroupBox PaymentSystem;
        private System.Windows.Forms.Button Checkout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Coinslot;
    }
}

