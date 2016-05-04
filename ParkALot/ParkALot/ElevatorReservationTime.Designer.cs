﻿namespace ParkALot
{
    partial class ElevatorReservationTime
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
            this.lb_TimeInstruction = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bn_Submit = new System.Windows.Forms.Button();
            this.lb_Now = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_TimeInstruction
            // 
            this.lb_TimeInstruction.AutoSize = true;
            this.lb_TimeInstruction.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimeInstruction.Location = new System.Drawing.Point(12, 9);
            this.lb_TimeInstruction.Name = "lb_TimeInstruction";
            this.lb_TimeInstruction.Size = new System.Drawing.Size(455, 29);
            this.lb_TimeInstruction.TabIndex = 0;
            this.lb_TimeInstruction.Text = "Please, enter the times you wish to reserve.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "End:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 22);
            this.textBox2.TabIndex = 3;
            // 
            // bn_Submit
            // 
            this.bn_Submit.Location = new System.Drawing.Point(190, 144);
            this.bn_Submit.Name = "bn_Submit";
            this.bn_Submit.Size = new System.Drawing.Size(100, 75);
            this.bn_Submit.TabIndex = 5;
            this.bn_Submit.Text = "Submit";
            this.bn_Submit.UseVisualStyleBackColor = true;
            this.bn_Submit.Click += new System.EventHandler(this.bn_Submit_Click);
            // 
            // lb_Now
            // 
            this.lb_Now.AutoSize = true;
            this.lb_Now.Location = new System.Drawing.Point(126, 61);
            this.lb_Now.Name = "lb_Now";
            this.lb_Now.Size = new System.Drawing.Size(35, 17);
            this.lb_Now.TabIndex = 6;
            this.lb_Now.Text = "Now";
            // 
            // ElevatorReservationTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 231);
            this.Controls.Add(this.lb_Now);
            this.Controls.Add(this.bn_Submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_TimeInstruction);
            this.Name = "ElevatorReservationTime";
            this.Text = "Park-A-Lot: Elevator";
            this.Load += new System.EventHandler(this.ElevatorReservationTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TimeInstruction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bn_Submit;
        private System.Windows.Forms.Label lb_Now;
    }
}