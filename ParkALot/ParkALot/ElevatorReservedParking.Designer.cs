namespace ParkALot
{
    partial class ElevatorReservedParking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElevatorReservedParking));
            this.lb_Reservation = new System.Windows.Forms.Label();
            this.bn_Yes = new System.Windows.Forms.Button();
            this.bn_No = new System.Windows.Forms.Button();
            this.lb_NoNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Reservation
            // 
            this.lb_Reservation.AutoSize = true;
            this.lb_Reservation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Reservation.Location = new System.Drawing.Point(19, 7);
            this.lb_Reservation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Reservation.Name = "lb_Reservation";
            this.lb_Reservation.Size = new System.Drawing.Size(326, 19);
            this.lb_Reservation.TabIndex = 0;
            this.lb_Reservation.Text = "Would you like to make a reservation now?";
            this.lb_Reservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bn_Yes
            // 
            this.bn_Yes.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_Yes.Location = new System.Drawing.Point(60, 56);
            this.bn_Yes.Margin = new System.Windows.Forms.Padding(2);
            this.bn_Yes.Name = "bn_Yes";
            this.bn_Yes.Size = new System.Drawing.Size(75, 61);
            this.bn_Yes.TabIndex = 1;
            this.bn_Yes.Text = "Yes";
            this.bn_Yes.UseVisualStyleBackColor = true;
            this.bn_Yes.Click += new System.EventHandler(this.bn_Yes_Click);
            // 
            // bn_No
            // 
            this.bn_No.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_No.Location = new System.Drawing.Point(219, 56);
            this.bn_No.Margin = new System.Windows.Forms.Padding(2);
            this.bn_No.Name = "bn_No";
            this.bn_No.Size = new System.Drawing.Size(75, 61);
            this.bn_No.TabIndex = 2;
            this.bn_No.Text = "No";
            this.bn_No.UseVisualStyleBackColor = true;
            this.bn_No.Click += new System.EventHandler(this.bn_No_Click);
            // 
            // lb_NoNote
            // 
            this.lb_NoNote.AutoSize = true;
            this.lb_NoNote.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NoNote.ForeColor = System.Drawing.Color.Red;
            this.lb_NoNote.Location = new System.Drawing.Point(32, 134);
            this.lb_NoNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NoNote.Name = "lb_NoNote";
            this.lb_NoNote.Size = new System.Drawing.Size(304, 15);
            this.lb_NoNote.TabIndex = 3;
            this.lb_NoNote.Text = "If you select \"No\", you will be asked to exit the garage.";
            this.lb_NoNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElevatorReservedParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 176);
            this.Controls.Add(this.lb_NoNote);
            this.Controls.Add(this.bn_No);
            this.Controls.Add(this.bn_Yes);
            this.Controls.Add(this.lb_Reservation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(906, 440);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ElevatorReservedParking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Park-A-Lot: Elevator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Reservation;
        private System.Windows.Forms.Button bn_Yes;
        private System.Windows.Forms.Button bn_No;
        private System.Windows.Forms.Label lb_NoNote;
    }
}