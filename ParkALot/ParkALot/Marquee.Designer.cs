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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marquee));
            this.lb_marquee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_marquee
            // 
            this.lb_marquee.AutoSize = true;
            this.lb_marquee.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_marquee.Location = new System.Drawing.Point(150, 34);
            this.lb_marquee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_marquee.Name = "lb_marquee";
            this.lb_marquee.Size = new System.Drawing.Size(652, 32);
            this.lb_marquee.TabIndex = 6;
            this.lb_marquee.Text = "Text for this is changed within the code for this form";
            this.lb_marquee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Marquee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 158);
            this.Controls.Add(this.lb_marquee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(2);
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