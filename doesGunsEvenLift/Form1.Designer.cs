namespace doesGunsEvenLift
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
            this.selectFileButton = new System.Windows.Forms.Button();
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.numOfLiftsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.avgOfLiftsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.threshLabel = new System.Windows.Forms.Label();
            this.randSetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(39, 24);
            this.selectFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(112, 35);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // filePathBox
            // 
            this.filePathBox.Location = new System.Drawing.Point(210, 24);
            this.filePathBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.ReadOnly = true;
            this.filePathBox.Size = new System.Drawing.Size(358, 26);
            this.filePathBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(376, 253);
            this.resultBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(192, 26);
            this.resultBox.TabIndex = 3;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(39, 97);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(171, 115);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // numOfLiftsBox
            // 
            this.numOfLiftsBox.Location = new System.Drawing.Point(376, 96);
            this.numOfLiftsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numOfLiftsBox.Name = "numOfLiftsBox";
            this.numOfLiftsBox.ReadOnly = true;
            this.numOfLiftsBox.Size = new System.Drawing.Size(192, 26);
            this.numOfLiftsBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Lifts:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // avgOfLiftsBox
            // 
            this.avgOfLiftsBox.Location = new System.Drawing.Point(376, 173);
            this.avgOfLiftsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avgOfLiftsBox.Name = "avgOfLiftsBox";
            this.avgOfLiftsBox.ReadOnly = true;
            this.avgOfLiftsBox.Size = new System.Drawing.Size(192, 26);
            this.avgOfLiftsBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Average Lifts:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // threshLabel
            // 
            this.threshLabel.AutoSize = true;
            this.threshLabel.Location = new System.Drawing.Point(259, 333);
            this.threshLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.threshLabel.Name = "threshLabel";
            this.threshLabel.Size = new System.Drawing.Size(109, 20);
            this.threshLabel.TabIndex = 9;
            this.threshLabel.Text = "Lift Threshold:";
            this.threshLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // randSetButton
            // 
            this.randSetButton.Location = new System.Drawing.Point(39, 238);
            this.randSetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.randSetButton.Name = "randSetButton";
            this.randSetButton.Size = new System.Drawing.Size(171, 115);
            this.randSetButton.TabIndex = 10;
            this.randSetButton.Text = "Create random set and test";
            this.randSetButton.UseVisualStyleBackColor = true;
            this.randSetButton.Click += new System.EventHandler(this.randSetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 407);
            this.Controls.Add(this.randSetButton);
            this.Controls.Add(this.threshLabel);
            this.Controls.Add(this.avgOfLiftsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numOfLiftsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.selectFileButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Does \'The Guns\' Even Lift?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox numOfLiftsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox avgOfLiftsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label threshLabel;
        private System.Windows.Forms.Button randSetButton;
    }
}

