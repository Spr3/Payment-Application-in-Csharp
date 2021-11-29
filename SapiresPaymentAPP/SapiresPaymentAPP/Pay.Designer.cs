
namespace SapiresPaymentAPP
{
    partial class Pay
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
            this.AddCompanysLabel = new System.Windows.Forms.Label();
            this.CompanyName1 = new System.Windows.Forms.Label();
            this.AmountPayed = new System.Windows.Forms.Label();
            this.DateAndTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddCompanysLabel
            // 
            this.AddCompanysLabel.AutoSize = true;
            this.AddCompanysLabel.Font = new System.Drawing.Font("Microsoft YaHei", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCompanysLabel.Location = new System.Drawing.Point(1, 0);
            this.AddCompanysLabel.Name = "AddCompanysLabel";
            this.AddCompanysLabel.Size = new System.Drawing.Size(204, 31);
            this.AddCompanysLabel.TabIndex = 0;
            this.AddCompanysLabel.Text = "Past 5 Payments";
            // 
            // CompanyName1
            // 
            this.CompanyName1.AutoSize = true;
            this.CompanyName1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName1.Location = new System.Drawing.Point(3, 72);
            this.CompanyName1.Name = "CompanyName1";
            this.CompanyName1.Size = new System.Drawing.Size(109, 19);
            this.CompanyName1.TabIndex = 1;
            this.CompanyName1.Text = "Company Name";
            // 
            // AmountPayed
            // 
            this.AmountPayed.AutoSize = true;
            this.AmountPayed.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountPayed.Location = new System.Drawing.Point(3, 91);
            this.AmountPayed.Name = "AmountPayed";
            this.AmountPayed.Size = new System.Drawing.Size(118, 21);
            this.AmountPayed.TabIndex = 2;
            this.AmountPayed.Text = "AmountPayed";
            // 
            // DateAndTime
            // 
            this.DateAndTime.AutoSize = true;
            this.DateAndTime.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAndTime.Location = new System.Drawing.Point(3, 112);
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.Size = new System.Drawing.Size(60, 21);
            this.DateAndTime.TabIndex = 3;
            this.DateAndTime.Text = "Payed:";
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 329);
            this.Controls.Add(this.DateAndTime);
            this.Controls.Add(this.AmountPayed);
            this.Controls.Add(this.CompanyName1);
            this.Controls.Add(this.AddCompanysLabel);
            this.Name = "Pay";
            this.Text = "Pay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddCompanysLabel;
        private System.Windows.Forms.Label CompanyName1;
        private System.Windows.Forms.Label AmountPayed;
        private System.Windows.Forms.Label DateAndTime;
    }
}