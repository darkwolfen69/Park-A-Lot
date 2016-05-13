namespace ParkALot
{
    partial class FancyCar
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
            this.lblCar = new System.Windows.Forms.Label();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.btnSubmitName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCar.Location = new System.Drawing.Point(12, 21);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(180, 18);
            this.lblCar.TabIndex = 0;
            this.lblCar.Text = "Please Enter Type Of Car:";
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(15, 58);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(100, 20);
            this.txtCarName.TabIndex = 1;
            // 
            // btnSubmitName
            // 
            this.btnSubmitName.Location = new System.Drawing.Point(144, 156);
            this.btnSubmitName.Name = "btnSubmitName";
            this.btnSubmitName.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitName.TabIndex = 2;
            this.btnSubmitName.Text = "Submit";
            this.btnSubmitName.UseVisualStyleBackColor = true;
            this.btnSubmitName.Click += new System.EventHandler(this.btnSubmitName_Click);
            // 
            // FancyCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 228);
            this.Controls.Add(this.btnSubmitName);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.lblCar);
            this.Location = new System.Drawing.Point(906, 500);
            this.Name = "FancyCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FancyCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Button btnSubmitName;
    }
}