namespace NumberManipulator
{
    partial class Form1
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
            this.MaxValueButton = new System.Windows.Forms.Button();
            this.MinValueButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.NormalizeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.smallestLabel = new System.Windows.Forms.Label();
            this.largestLabel = new System.Windows.Forms.Label();
            this.errorTextbox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MaxValueButton
            // 
            this.MaxValueButton.Location = new System.Drawing.Point(12, 70);
            this.MaxValueButton.Name = "MaxValueButton";
            this.MaxValueButton.Size = new System.Drawing.Size(150, 40);
            this.MaxValueButton.TabIndex = 0;
            this.MaxValueButton.Text = "Show Max Value Index";
            this.MaxValueButton.UseVisualStyleBackColor = true;
            this.MaxValueButton.Click += new System.EventHandler(this.MaxValueButton_Click_1);
            // 
            // MinValueButton
            // 
            this.MinValueButton.Location = new System.Drawing.Point(12, 120);
            this.MinValueButton.Name = "MinValueButton";
            this.MinValueButton.Size = new System.Drawing.Size(150, 40);
            this.MinValueButton.TabIndex = 1;
            this.MinValueButton.Text = "Show Min Value Index";
            this.MinValueButton.UseVisualStyleBackColor = true;
            this.MinValueButton.Click += new System.EventHandler(this.MinValueButton_Click_1);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(12, 220);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(150, 40);
            this.SortButton.TabIndex = 2;
            this.SortButton.Text = "Sort the values into ascending order";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click_1);
            // 
            // NormalizeButton
            // 
            this.NormalizeButton.Location = new System.Drawing.Point(12, 170);
            this.NormalizeButton.Name = "NormalizeButton";
            this.NormalizeButton.Size = new System.Drawing.Size(150, 40);
            this.NormalizeButton.TabIndex = 3;
            this.NormalizeButton.Text = "Normalize the list of values";
            this.NormalizeButton.UseVisualStyleBackColor = true;
            this.NormalizeButton.Click += new System.EventHandler(this.NormalizeButton_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input a comma separated list of numbers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 6;
            // 
            // smallestLabel
            // 
            this.smallestLabel.AutoSize = true;
            this.smallestLabel.Location = new System.Drawing.Point(188, 84);
            this.smallestLabel.Name = "smallestLabel";
            this.smallestLabel.Size = new System.Drawing.Size(46, 13);
            this.smallestLabel.TabIndex = 7;
            this.smallestLabel.Text = "Smallest";
            this.smallestLabel.Visible = false;
            this.smallestLabel.Click += new System.EventHandler(this.smallestLabel_Click);
            // 
            // largestLabel
            // 
            this.largestLabel.AutoSize = true;
            this.largestLabel.Location = new System.Drawing.Point(188, 84);
            this.largestLabel.Name = "largestLabel";
            this.largestLabel.Size = new System.Drawing.Size(42, 13);
            this.largestLabel.TabIndex = 8;
            this.largestLabel.Text = "Largest";
            this.largestLabel.Visible = false;
            this.largestLabel.Click += new System.EventHandler(this.largestLabel_Click);
            // 
            // errorTextbox
            // 
            this.errorTextbox.AutoSize = true;
            this.errorTextbox.ForeColor = System.Drawing.Color.Red;
            this.errorTextbox.Location = new System.Drawing.Point(12, 51);
            this.errorTextbox.Name = "errorTextbox";
            this.errorTextbox.Size = new System.Drawing.Size(35, 13);
            this.errorTextbox.TabIndex = 9;
            this.errorTextbox.Text = "label3";
            this.errorTextbox.Visible = false;
            this.errorTextbox.Click += new System.EventHandler(this.errorTextbox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.errorTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NormalizeButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.MinValueButton);
            this.Controls.Add(this.MaxValueButton);
            this.Controls.Add(this.smallestLabel);
            this.Controls.Add(this.largestLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MaxValueButton;
        private System.Windows.Forms.Button MinValueButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button NormalizeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label smallestLabel;
        private System.Windows.Forms.Label largestLabel;
        private System.Windows.Forms.Label errorTextbox;
    }
}

