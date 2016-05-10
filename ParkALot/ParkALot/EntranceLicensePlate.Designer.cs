namespace ParkALot
{
    partial class EntranceLicensePlate
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
            this.label2.Location = new System.Drawing.Point(240, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Park-A-Lot © 2016";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bn_LPRead
            // 
            this.bn_LPRead.Location = new System.Drawing.Point(136, 90);
            this.bn_LPRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bn_LPRead.Name = "bn_LPRead";
            this.bn_LPRead.Size = new System.Drawing.Size(92, 42);
            this.bn_LPRead.TabIndex = 54;
            this.bn_LPRead.Text = "Searching";
            this.bn_LPRead.UseVisualStyleBackColor = true;
            this.bn_LPRead.Click += new System.EventHandler(this.bn_LPRead_Click);
            // 
            // tb_LPNum
            // 
            this.tb_LPNum.Location = new System.Drawing.Point(27, 62);
            this.tb_LPNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_LPNum.Name = "tb_LPNum";
            this.tb_LPNum.Size = new System.Drawing.Size(313, 22);
            this.tb_LPNum.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 34);
            this.label1.TabIndex = 52;
            this.label1.Text = "License plate reader is currently scanning your \r\nlicense plate.  Please keep you" +
    "r vehicle stopped.";
            // 
            // EntranceLicensePlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 144);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bn_LPRead);
            this.Controls.Add(this.tb_LPNum);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(906, 440);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EntranceLicensePlate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EntranceLicensePlate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bn_LPRead;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_LPNum;
    }
}