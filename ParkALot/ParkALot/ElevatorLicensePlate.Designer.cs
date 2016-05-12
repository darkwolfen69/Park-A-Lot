namespace ParkALot
{
    partial class ElevatorLicensePlate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElevatorLicensePlate));
            this.label2 = new System.Windows.Forms.Label();
            this.bn_LPRead = new System.Windows.Forms.Button();
            this.tb_LPNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Park-A-Lot © 2016";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bn_LPRead
            // 
            this.bn_LPRead.Location = new System.Drawing.Point(102, 73);
            this.bn_LPRead.Margin = new System.Windows.Forms.Padding(2);
            this.bn_LPRead.Name = "bn_LPRead";
            this.bn_LPRead.Size = new System.Drawing.Size(69, 34);
            this.bn_LPRead.TabIndex = 50;
            this.bn_LPRead.Text = "Search";
            this.bn_LPRead.UseVisualStyleBackColor = true;
            this.bn_LPRead.Click += new System.EventHandler(this.bn_LPRead_Click);
            // 
            // tb_LPNum
            // 
            this.tb_LPNum.Location = new System.Drawing.Point(20, 50);
            this.tb_LPNum.Margin = new System.Windows.Forms.Padding(2);
            this.tb_LPNum.Name = "tb_LPNum";
            this.tb_LPNum.Size = new System.Drawing.Size(236, 20);
            this.tb_LPNum.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 26);
            this.label1.TabIndex = 48;
            this.label1.Text = "This acts as the virtual licenses plate reader.\r\nPlease enter a 10 character lice" +
    "nses plate number. ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElevatorLicensePlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 117);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bn_LPRead);
            this.Controls.Add(this.tb_LPNum);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(906, 440);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ElevatorLicensePlate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Park-A-Lot: Elevator";
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