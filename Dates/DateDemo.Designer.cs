namespace Dates
{
    partial class DateDemo
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
            this.txtDate1 = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.lblParsedDate = new System.Windows.Forms.Label();
            this.dtpSecondDate = new System.Windows.Forms.DateTimePicker();
            this.btnDifference = new System.Windows.Forms.Button();
            this.lblTimespan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDate1
            // 
            this.txtDate1.Location = new System.Drawing.Point(12, 12);
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(100, 20);
            this.txtDate1.TabIndex = 0;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(118, 10);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 1;
            this.btnParse.Text = "Parse Date";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // lblParsedDate
            // 
            this.lblParsedDate.AutoSize = true;
            this.lblParsedDate.Location = new System.Drawing.Point(199, 15);
            this.lblParsedDate.Name = "lblParsedDate";
            this.lblParsedDate.Size = new System.Drawing.Size(35, 13);
            this.lblParsedDate.TabIndex = 2;
            this.lblParsedDate.Text = "label1";
            // 
            // dtpSecondDate
            // 
            this.dtpSecondDate.Location = new System.Drawing.Point(12, 39);
            this.dtpSecondDate.Name = "dtpSecondDate";
            this.dtpSecondDate.Size = new System.Drawing.Size(200, 20);
            this.dtpSecondDate.TabIndex = 3;
            // 
            // btnDifference
            // 
            this.btnDifference.Location = new System.Drawing.Point(12, 65);
            this.btnDifference.Name = "btnDifference";
            this.btnDifference.Size = new System.Drawing.Size(75, 23);
            this.btnDifference.TabIndex = 4;
            this.btnDifference.Text = "TimeSpan";
            this.btnDifference.UseVisualStyleBackColor = true;
            this.btnDifference.Click += new System.EventHandler(this.btnDifference_Click);
            // 
            // lblTimespan
            // 
            this.lblTimespan.AutoSize = true;
            this.lblTimespan.Location = new System.Drawing.Point(93, 70);
            this.lblTimespan.Name = "lblTimespan";
            this.lblTimespan.Size = new System.Drawing.Size(35, 13);
            this.lblTimespan.TabIndex = 5;
            this.lblTimespan.Text = "label1";
            // 
            // DateDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 108);
            this.Controls.Add(this.lblTimespan);
            this.Controls.Add(this.btnDifference);
            this.Controls.Add(this.dtpSecondDate);
            this.Controls.Add(this.lblParsedDate);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.txtDate1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DateDemo";
            this.Text = "Date Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDate1;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Label lblParsedDate;
        private System.Windows.Forms.DateTimePicker dtpSecondDate;
        private System.Windows.Forms.Button btnDifference;
        private System.Windows.Forms.Label lblTimespan;
    }
}

