namespace ParkALot
{
    partial class ExitLicensePlate
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
            this.label2 = new System.Windows.Forms.Label();
            this.bn_LPRead = new System.Windows.Forms.Button();
            this.tb_LPNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Park-A-Lot © 2016";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bn_LPRead
            // 
            this.bn_LPRead.Location = new System.Drawing.Point(153, 112);
            this.bn_LPRead.Name = "bn_LPRead";
            this.bn_LPRead.Size = new System.Drawing.Size(104, 52);
            this.bn_LPRead.TabIndex = 54;
            this.bn_LPRead.Text = "Search";
            this.bn_LPRead.UseVisualStyleBackColor = true;
            this.bn_LPRead.Click += new System.EventHandler(this.bn_LPRead_Click);
            // 
            // tb_LPNum
            // 
            this.tb_LPNum.Location = new System.Drawing.Point(30, 77);
            this.tb_LPNum.Name = "tb_LPNum";
            this.tb_LPNum.Size = new System.Drawing.Size(352, 26);
            this.tb_LPNum.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 40);
            this.label1.TabIndex = 52;
            this.label1.Text = "License plate reader is currently scanning your \r\nlicense plate.  Please keep you" +
    "r vehicle stopped.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExitLicensePlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 180);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bn_LPRead);
            this.Controls.Add(this.tb_LPNum);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(906, 250);
            this.Name = "ExitLicensePlate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Park-A-Lot: Exit Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bn_LPRead;
        private System.Windows.Forms.TextBox tb_LPNum;
        private System.Windows.Forms.Label label1;
    }
}