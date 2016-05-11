namespace ParkALot
{
    partial class Marquee
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
            this.lb_marquee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_marquee
            // 
            this.lb_marquee.AutoSize = true;
            this.lb_marquee.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_marquee.Location = new System.Drawing.Point(84, 62);
            this.lb_marquee.Name = "lb_marquee";
            this.lb_marquee.Size = new System.Drawing.Size(1225, 94);
            this.lb_marquee.TabIndex = 6;
            this.lb_marquee.Text = "There are 10 spots available for Drive-in, \r\nand 50 spots available for registere" +
    "d customers with reservations.";
            this.lb_marquee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Marquee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 243);
            this.Controls.Add(this.lb_marquee);
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "Marquee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Park-A-Lot: Marquee";
            this.Load += new System.EventHandler(this.Marquee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_marquee;




    }
}