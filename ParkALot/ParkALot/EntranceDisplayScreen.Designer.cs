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
            this.lb_header = new System.Windows.Forms.Label();
            this.bn_walkin = new System.Windows.Forms.Button();
            this.bn_ResCust = new System.Windows.Forms.Button();
            this.lb_WalkinWarning = new System.Windows.Forms.Label();
            this.lb_ResCusWarning = new System.Windows.Forms.Label();
            this.lb_OptDetail = new System.Windows.Forms.Label();
            this.lb_WalkinHeader = new System.Windows.Forms.Label();
            this.lb_Ticket = new System.Windows.Forms.Label();
            this.lb_ParkingInstructions = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_header
            // 
            this.lb_header.AutoSize = true;
            this.lb_header.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_header.Location = new System.Drawing.Point(225, 10);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(426, 48);
            this.lb_header.TabIndex = 0;
            this.lb_header.Text = "Welcome to Park-A-Lot!";
            this.lb_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bn_walkin
            // 
            this.bn_walkin.Location = new System.Drawing.Point(112, 123);
            this.bn_walkin.Name = "bn_walkin";
            this.bn_walkin.Size = new System.Drawing.Size(275, 125);
            this.bn_walkin.TabIndex = 1;
            this.bn_walkin.Text = "Walk-In";
            this.bn_walkin.UseVisualStyleBackColor = true;
            this.bn_walkin.Click += new System.EventHandler(this.bn_walkin_Click);
            // 
            // bn_ResCust
            // 
            this.bn_ResCust.Location = new System.Drawing.Point(495, 123);
            this.bn_ResCust.Name = "bn_ResCust";
            this.bn_ResCust.Size = new System.Drawing.Size(275, 125);
            this.bn_ResCust.TabIndex = 2;
            this.bn_ResCust.Text = "Reserved Customer";
            this.bn_ResCust.UseVisualStyleBackColor = true;
            this.bn_ResCust.Click += new System.EventHandler(this.bn_ResCust_Click);
            // 
            // lb_WalkinWarning
            // 
            this.lb_WalkinWarning.AutoSize = true;
            this.lb_WalkinWarning.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_WalkinWarning.ForeColor = System.Drawing.Color.Red;
            this.lb_WalkinWarning.Location = new System.Drawing.Point(108, 251);
            this.lb_WalkinWarning.Name = "lb_WalkinWarning";
            this.lb_WalkinWarning.Size = new System.Drawing.Size(303, 48);
            this.lb_WalkinWarning.TabIndex = 3;
            this.lb_WalkinWarning.Text = "Walk-In customers will only be \r\nallowed to park on the ground floor.";
            // 
            // lb_ResCusWarning
            // 
            this.lb_ResCusWarning.AutoSize = true;
            this.lb_ResCusWarning.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ResCusWarning.ForeColor = System.Drawing.Color.Red;
            this.lb_ResCusWarning.Location = new System.Drawing.Point(491, 251);
            this.lb_ResCusWarning.Name = "lb_ResCusWarning";
            this.lb_ResCusWarning.Size = new System.Drawing.Size(330, 48);
            this.lb_ResCusWarning.TabIndex = 4;
            this.lb_ResCusWarning.Text = "Reserved customers will be allowed \r\nto park in the spots they have reserved.";
            // 
            // lb_OptDetail
            // 
            this.lb_OptDetail.AutoSize = true;
            this.lb_OptDetail.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_OptDetail.Location = new System.Drawing.Point(218, 409);
            this.lb_OptDetail.Name = "lb_OptDetail";
            this.lb_OptDetail.Size = new System.Drawing.Size(453, 29);
            this.lb_OptDetail.TabIndex = 5;
            this.lb_OptDetail.Text = "Please choose the option that applies to you!";
            // 
            // lb_WalkinHeader
            // 
            this.lb_WalkinHeader.AutoSize = true;
            this.lb_WalkinHeader.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_WalkinHeader.Location = new System.Drawing.Point(236, 97);
            this.lb_WalkinHeader.Name = "lb_WalkinHeader";
            this.lb_WalkinHeader.Size = new System.Drawing.Size(399, 35);
            this.lb_WalkinHeader.TabIndex = 6;
            this.lb_WalkinHeader.Text = "Thank you for using Park-A-Lot!";
            this.lb_WalkinHeader.Visible = false;
            // 
            // lb_Ticket
            // 
            this.lb_Ticket.AutoSize = true;
            this.lb_Ticket.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ticket.ForeColor = System.Drawing.Color.Red;
            this.lb_Ticket.Location = new System.Drawing.Point(359, 164);
            this.lb_Ticket.Name = "lb_Ticket";
            this.lb_Ticket.Size = new System.Drawing.Size(146, 84);
            this.lb_Ticket.TabIndex = 7;
            this.lb_Ticket.Text = "---";
            this.lb_Ticket.Visible = false;
            this.lb_Ticket.TextChanged += new System.EventHandler(this.lb_Ticket_TextChanged);
            // 
            // lb_ParkingInstructions
            // 
            this.lb_ParkingInstructions.AutoSize = true;
            this.lb_ParkingInstructions.Location = new System.Drawing.Point(290, 299);
            this.lb_ParkingInstructions.Name = "lb_ParkingInstructions";
            this.lb_ParkingInstructions.Size = new System.Drawing.Size(267, 34);
            this.lb_ParkingInstructions.TabIndex = 8;
            this.lb_ParkingInstructions.Text = "Please pull to the parking spot displayed \r\nabove and on your parking ticket.";
            this.lb_ParkingInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_ParkingInstructions.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Park-A-Lot © 2016";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
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
            this.Name = "DisplayScreen";
            this.Text = "Park-A-Lot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_header;
        public System.Windows.Forms.Button bn_walkin;
        public System.Windows.Forms.Button bn_ResCust;
        public System.Windows.Forms.Label lb_WalkinWarning;
        public System.Windows.Forms.Label lb_ResCusWarning;
        public System.Windows.Forms.Label lb_OptDetail;
        public System.Windows.Forms.Label lb_WalkinHeader;
        public System.Windows.Forms.Label lb_Ticket;
        public System.Windows.Forms.Label lb_ParkingInstructions;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;

    }
}

