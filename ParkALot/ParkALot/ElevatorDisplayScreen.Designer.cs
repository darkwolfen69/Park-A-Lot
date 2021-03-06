﻿namespace ParkALot
{
    partial class ElevatorDisplayScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElevatorDisplayScreen));
            this.label2 = new System.Windows.Forms.Label();
            this.bn_PullForward = new System.Windows.Forms.Button();
            this.lb_Display = new System.Windows.Forms.Label();
            this.lb_header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Park-A-Lot © 2016";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bn_PullForward
            // 
            this.bn_PullForward.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_PullForward.Location = new System.Drawing.Point(266, 320);
            this.bn_PullForward.Margin = new System.Windows.Forms.Padding(2);
            this.bn_PullForward.Name = "bn_PullForward";
            this.bn_PullForward.Size = new System.Drawing.Size(131, 41);
            this.bn_PullForward.TabIndex = 41;
            this.bn_PullForward.Text = "Pulling forward.";
            this.bn_PullForward.UseVisualStyleBackColor = true;
            this.bn_PullForward.Click += new System.EventHandler(this.bn_PullForward_Click);
            // 
            // lb_Display
            // 
            this.lb_Display.AutoSize = true;
            this.lb_Display.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Display.Location = new System.Drawing.Point(95, 145);
            this.lb_Display.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Display.Name = "lb_Display";
            this.lb_Display.Size = new System.Drawing.Size(485, 44);
            this.lb_Display.TabIndex = 42;
            this.lb_Display.Text = "This screen is you driving from the entrance to the elevator.\r\nYour licences plat" +
    "e will be read again at the elevator. ";
            this.lb_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Display.TextChanged += new System.EventHandler(this.lb_Display_TextChanged);
            // 
            // lb_header
            // 
            this.lb_header.AutoSize = true;
            this.lb_header.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_header.Location = new System.Drawing.Point(169, 8);
            this.lb_header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(304, 32);
            this.lb_header.TabIndex = 1;
            this.lb_header.Text = "Welcome to Park-A-Lot!";
            this.lb_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElevatorDisplayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 368);
            this.Controls.Add(this.lb_Display);
            this.Controls.Add(this.bn_PullForward);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 250);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ElevatorDisplayScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Park-A-Lot: Elevator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button bn_PullForward;
        public System.Windows.Forms.Label lb_Display;
        public System.Windows.Forms.Label lb_header;
    }
}