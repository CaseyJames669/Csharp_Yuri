namespace BladowCasey_ex20_07
{
    partial class GenericLinearSearchForm
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
            this.createIntegersButton = new System.Windows.Forms.Button();
            this.createDoublesButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createIntegersButton
            // 
            this.createIntegersButton.Location = new System.Drawing.Point(58, 44);
            this.createIntegersButton.Name = "createIntegersButton";
            this.createIntegersButton.Size = new System.Drawing.Size(94, 23);
            this.createIntegersButton.TabIndex = 0;
            this.createIntegersButton.Text = "Create Integers";
            this.createIntegersButton.UseVisualStyleBackColor = true;
            this.createIntegersButton.Click += new System.EventHandler(this.createIntegersButton_Click);
            // 
            // createDoublesButton
            // 
            this.createDoublesButton.Location = new System.Drawing.Point(158, 44);
            this.createDoublesButton.Name = "createDoublesButton";
            this.createDoublesButton.Size = new System.Drawing.Size(91, 23);
            this.createDoublesButton.TabIndex = 1;
            this.createDoublesButton.Text = "Create Doubles";
            this.createDoublesButton.UseVisualStyleBackColor = true;
            this.createDoublesButton.Click += new System.EventHandler(this.createDoublesButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(58, 73);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(191, 165);
            this.textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Search Key:";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(158, 241);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(91, 20);
            this.inputTextBox.TabIndex = 4;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(55, 294);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(89, 13);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Results of seach.";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(58, 349);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(191, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // GenericLinearSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 431);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.createDoublesButton);
            this.Controls.Add(this.createIntegersButton);
            this.Name = "GenericLinearSearchForm";
            this.Text = "Generic Linear Search";
            //this.Load += new System.EventHandler(this.GenericLinearSearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createIntegersButton;
        private System.Windows.Forms.Button createDoublesButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button searchButton;
    }
}

