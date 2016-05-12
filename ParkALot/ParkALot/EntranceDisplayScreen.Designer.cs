namespace ParkALot
{
    partial class EntranceDisplayScreen
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bn_walkin = new System.Windows.Forms.Button();
            this.bn_ResCust = new System.Windows.Forms.Button();
            this.lb_WalkinWarning = new System.Windows.Forms.Label();
            this.lb_ResCusWarning = new System.Windows.Forms.Label();
            this.lb_OptDetail = new System.Windows.Forms.Label();
            this.lb_Ticket = new System.Windows.Forms.Label();
            this.lb_ParkingInstructions = new System.Windows.Forms.Label();
            this.lb_header = new System.Windows.Forms.Label();
            this.lb_WalkinHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 347);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Park-A-Lot © 2016";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bn_walkin
            // 
            this.bn_walkin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_walkin.Location = new System.Drawing.Point(84, 100);
            this.bn_walkin.Margin = new System.Windows.Forms.Padding(2);
            this.bn_walkin.Name = "bn_walkin";
            this.bn_walkin.Size = new System.Drawing.Size(206, 102);
            this.bn_walkin.TabIndex = 1;
            this.bn_walkin.Text = "Drive-In";
            this.bn_walkin.UseVisualStyleBackColor = true;
            this.bn_walkin.Click += new System.EventHandler(this.bn_walkin_Click);
            // 
            // bn_ResCust
            // 
            this.bn_ResCust.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_ResCust.Location = new System.Drawing.Point(371, 100);
            this.bn_ResCust.Margin = new System.Windows.Forms.Padding(2);
            this.bn_ResCust.Name = "bn_ResCust";
            this.bn_ResCust.Size = new System.Drawing.Size(206, 102);
            this.bn_ResCust.TabIndex = 2;
            this.bn_ResCust.Text = "Reservation";
            this.bn_ResCust.UseVisualStyleBackColor = true;
            this.bn_ResCust.Click += new System.EventHandler(this.bn_ResCust_Click);
            // 
            // lb_WalkinWarning
            // 
            this.lb_WalkinWarning.AutoSize = true;
            this.lb_WalkinWarning.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_WalkinWarning.ForeColor = System.Drawing.Color.Red;
            this.lb_WalkinWarning.Location = new System.Drawing.Point(71, 205);
            this.lb_WalkinWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_WalkinWarning.Name = "lb_WalkinWarning";
            this.lb_WalkinWarning.Size = new System.Drawing.Size(232, 34);
            this.lb_WalkinWarning.TabIndex = 3;
            this.lb_WalkinWarning.Text = "Drive-In customers are only \r\nallowed to park on the ground floor.";
            this.lb_WalkinWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ResCusWarning
            // 
            this.lb_ResCusWarning.AutoSize = true;
            this.lb_ResCusWarning.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ResCusWarning.ForeColor = System.Drawing.Color.Red;
            this.lb_ResCusWarning.Location = new System.Drawing.Point(358, 204);
            this.lb_ResCusWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ResCusWarning.Name = "lb_ResCusWarning";
            this.lb_ResCusWarning.Size = new System.Drawing.Size(235, 34);
            this.lb_ResCusWarning.TabIndex = 4;
            this.lb_ResCusWarning.Text = "Customers with reservations will be \r\nallowed to park on the upper levels.";
            this.lb_ResCusWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_OptDetail
            // 
            this.lb_OptDetail.AutoSize = true;
            this.lb_OptDetail.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_OptDetail.Location = new System.Drawing.Point(164, 332);
            this.lb_OptDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_OptDetail.Name = "lb_OptDetail";
            this.lb_OptDetail.Size = new System.Drawing.Size(331, 19);
            this.lb_OptDetail.TabIndex = 5;
            this.lb_OptDetail.Text = "Please choose the option that applies to you!";
            this.lb_OptDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_OptDetail.TextChanged += new System.EventHandler(this.lb_OptDetail_TextChanged);
            // 
            // lb_Ticket
            // 
            this.lb_Ticket.AutoSize = true;
            this.lb_Ticket.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ticket.ForeColor = System.Drawing.Color.Red;
            this.lb_Ticket.Location = new System.Drawing.Point(283, 132);
            this.lb_Ticket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Ticket.Name = "lb_Ticket";
            this.lb_Ticket.Size = new System.Drawing.Size(73, 57);
            this.lb_Ticket.TabIndex = 7;
            this.lb_Ticket.Text = "---";
            this.lb_Ticket.Visible = false;
            // 
            // lb_ParkingInstructions
            // 
            this.lb_ParkingInstructions.AutoSize = true;
            this.lb_ParkingInstructions.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ParkingInstructions.Location = new System.Drawing.Point(200, 253);
            this.lb_ParkingInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ParkingInstructions.Name = "lb_ParkingInstructions";
            this.lb_ParkingInstructions.Size = new System.Drawing.Size(261, 34);
            this.lb_ParkingInstructions.TabIndex = 8;
            this.lb_ParkingInstructions.Text = "Please pull to the parking spot displayed \r\nabove and on your parking ticket.";
            this.lb_ParkingInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_ParkingInstructions.Visible = false;
            // 
            // lb_header
            // 
            this.lb_header.AutoSize = true;
            this.lb_header.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_header.Location = new System.Drawing.Point(169, 8);
            this.lb_header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(304, 32);
            this.lb_header.TabIndex = 0;
            this.lb_header.Text = "Welcome to Park-A-Lot!";
            this.lb_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_WalkinHeader
            // 
            this.lb_WalkinHeader.AutoSize = true;
            this.lb_WalkinHeader.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_WalkinHeader.Location = new System.Drawing.Point(180, 76);
            this.lb_WalkinHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_WalkinHeader.Name = "lb_WalkinHeader";
            this.lb_WalkinHeader.Size = new System.Drawing.Size(284, 22);
            this.lb_WalkinHeader.TabIndex = 6;
            this.lb_WalkinHeader.Text = "Thank you for using Park-A-Lot!";
            this.lb_WalkinHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_WalkinHeader.Visible = false;
            // 
            // EntranceDisplayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_ParkingInstructions);
            this.Controls.Add(this.lb_Ticket);
            this.Controls.Add(this.lb_WalkinHeader);
            this.Controls.Add(this.lb_OptDetail);
            this.Controls.Add(this.lb_ResCusWarning);
            this.Controls.Add(this.lb_WalkinWarning);
            this.Controls.Add(this.bn_ResCust);
            this.Controls.Add(this.bn_walkin);
            this.Controls.Add(this.lb_header);
            this.Location = new System.Drawing.Point(10, 250);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EntranceDisplayScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Park-A-Lot: Entrance";
            this.Load += new System.EventHandler(this.EntranceDisplayScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bn_walkin;
        public System.Windows.Forms.Button bn_ResCust;
        public System.Windows.Forms.Label lb_WalkinWarning;
        public System.Windows.Forms.Label lb_ResCusWarning;
        public System.Windows.Forms.Label lb_OptDetail;
        public System.Windows.Forms.Label lb_Ticket;
        public System.Windows.Forms.Label lb_ParkingInstructions;
        public System.Windows.Forms.Label lb_header;
        public System.Windows.Forms.Label lb_WalkinHeader;

    }
}

