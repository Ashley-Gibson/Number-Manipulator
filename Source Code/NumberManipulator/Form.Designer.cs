namespace NumberManipulator
{
    partial class Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnMaxValue = new System.Windows.Forms.Button();
            this.btnMinValue = new System.Windows.Forms.Button();
            this.btnSortAscending = new System.Windows.Forms.Button();
            this.btnNormalise = new System.Windows.Forms.Button();
            this.txtInputOutput = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblSmallestLargestNumber = new System.Windows.Forms.Label();
            this.lblSmallest = new System.Windows.Forms.Label();
            this.lblLargest = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMaxValue
            // 
            this.btnMaxValue.Location = new System.Drawing.Point(12, 70);
            this.btnMaxValue.Name = "btnMaxValue";
            this.btnMaxValue.Size = new System.Drawing.Size(150, 40);
            this.btnMaxValue.TabIndex = 0;
            this.btnMaxValue.Text = "Show Max Value Index";
            this.btnMaxValue.UseVisualStyleBackColor = true;
            this.btnMaxValue.Click += new System.EventHandler(this.btnMaxValue_Click_1);
            // 
            // btnMinValue
            // 
            this.btnMinValue.Location = new System.Drawing.Point(12, 120);
            this.btnMinValue.Name = "btnMinValue";
            this.btnMinValue.Size = new System.Drawing.Size(150, 40);
            this.btnMinValue.TabIndex = 1;
            this.btnMinValue.Text = "Show Min Value Index";
            this.btnMinValue.UseVisualStyleBackColor = true;
            this.btnMinValue.Click += new System.EventHandler(this.btnMinValue_Click_1);
            // 
            // btnSortAscending
            // 
            this.btnSortAscending.Location = new System.Drawing.Point(12, 220);
            this.btnSortAscending.Name = "btnSortAscending";
            this.btnSortAscending.Size = new System.Drawing.Size(150, 40);
            this.btnSortAscending.TabIndex = 2;
            this.btnSortAscending.Text = "Sort the values into ascending order";
            this.btnSortAscending.UseVisualStyleBackColor = true;
            this.btnSortAscending.Click += new System.EventHandler(this.btnSortAscending_Click_1);
            // 
            // btnNormalise
            // 
            this.btnNormalise.Location = new System.Drawing.Point(12, 170);
            this.btnNormalise.Name = "btnNormalise";
            this.btnNormalise.Size = new System.Drawing.Size(150, 40);
            this.btnNormalise.TabIndex = 3;
            this.btnNormalise.Text = "Normalise the list of values";
            this.btnNormalise.UseVisualStyleBackColor = true;
            this.btnNormalise.Click += new System.EventHandler(this.btnNormalise_Click_1);
            // 
            // txtInputOutput
            // 
            this.txtInputOutput.Location = new System.Drawing.Point(12, 25);
            this.txtInputOutput.Name = "txtInputOutput";
            this.txtInputOutput.Size = new System.Drawing.Size(150, 20);
            this.txtInputOutput.TabIndex = 4;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(9, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(197, 13);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Input a comma separated list of numbers";
            // 
            // label2
            // 
            this.lblSmallestLargestNumber.AutoSize = true;
            this.lblSmallestLargestNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmallestLargestNumber.Location = new System.Drawing.Point(186, 126);
            this.lblSmallestLargestNumber.Name = "lblSmallestLargestNumber";
            this.lblSmallestLargestNumber.Size = new System.Drawing.Size(0, 25);
            this.lblSmallestLargestNumber.TabIndex = 6;
            // 
            // lblSmallest
            // 
            this.lblSmallest.AutoSize = true;
            this.lblSmallest.Location = new System.Drawing.Point(188, 84);
            this.lblSmallest.Name = "lblSmallest";
            this.lblSmallest.Size = new System.Drawing.Size(46, 13);
            this.lblSmallest.TabIndex = 7;
            this.lblSmallest.Text = "Smallest";
            this.lblSmallest.Visible = false;
            // 
            // lblLargest
            // 
            this.lblLargest.AutoSize = true;
            this.lblLargest.Location = new System.Drawing.Point(188, 84);
            this.lblLargest.Name = "lblLargest";
            this.lblLargest.Size = new System.Drawing.Size(42, 13);
            this.lblLargest.TabIndex = 8;
            this.lblLargest.Text = "Largest";
            this.lblLargest.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 51);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 13);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "lblError";
            this.lblError.Visible = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblSmallestLargestNumber);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtInputOutput);
            this.Controls.Add(this.btnNormalise);
            this.Controls.Add(this.btnSortAscending);
            this.Controls.Add(this.btnMinValue);
            this.Controls.Add(this.btnMaxValue);
            this.Controls.Add(this.lblSmallest);
            this.Controls.Add(this.lblLargest);
            this.Name = "Form";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaxValue;
        private System.Windows.Forms.Button btnMinValue;
        private System.Windows.Forms.Button btnSortAscending;
        private System.Windows.Forms.Button btnNormalise;
        private System.Windows.Forms.TextBox txtInputOutput;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblSmallestLargestNumber;
        private System.Windows.Forms.Label lblSmallest;
        private System.Windows.Forms.Label lblLargest;
        private System.Windows.Forms.Label lblError;
    }
}

