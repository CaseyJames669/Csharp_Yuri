namespace P04_22_7
{
    partial class Books
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
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.booksDataSet = new P04_22_7.BooksDataSet();
            this.titleButton = new System.Windows.Forms.Button();
            this.titleByAuthorButton = new System.Windows.Forms.Button();
            this.authorsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // booksGridView
            // 
            this.booksGridView.AllowUserToOrderColumns = true;
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGridView.Location = new System.Drawing.Point(21, 70);
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.RowHeadersVisible = false;
            this.booksGridView.Size = new System.Drawing.Size(514, 179);
            this.booksGridView.TabIndex = 0;
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titleButton
            // 
            this.titleButton.Location = new System.Drawing.Point(21, 41);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(75, 23);
            this.titleButton.TabIndex = 1;
            this.titleButton.Text = "Titles";
            this.titleButton.UseVisualStyleBackColor = true;
            this.titleButton.Click += new System.EventHandler(this.titleButton_Click);
            // 
            // titleByAuthorButton
            // 
            this.titleByAuthorButton.Location = new System.Drawing.Point(103, 40);
            this.titleByAuthorButton.Name = "titleByAuthorButton";
            this.titleByAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.titleByAuthorButton.TabIndex = 2;
            this.titleByAuthorButton.Text = "Title by Author";
            this.titleByAuthorButton.UseVisualStyleBackColor = true;
            this.titleByAuthorButton.Click += new System.EventHandler(this.titleByAuthorButton_Click);
            // 
            // authorsButton
            // 
            this.authorsButton.Location = new System.Drawing.Point(185, 41);
            this.authorsButton.Name = "authorsButton";
            this.authorsButton.Size = new System.Drawing.Size(75, 23);
            this.authorsButton.TabIndex = 3;
            this.authorsButton.Text = "Authors";
            this.authorsButton.UseVisualStyleBackColor = true;
            this.authorsButton.Click += new System.EventHandler(this.authorsButton_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 269);
            this.Controls.Add(this.authorsButton);
            this.Controls.Add(this.titleByAuthorButton);
            this.Controls.Add(this.titleButton);
            this.Controls.Add(this.booksGridView);
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booksGridView;
        private BooksDataSet booksDataSet;
        private System.Windows.Forms.Button titleButton;
        private System.Windows.Forms.Button titleByAuthorButton;
        private System.Windows.Forms.Button authorsButton;
    }
}

