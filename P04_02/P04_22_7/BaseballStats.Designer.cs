namespace P4_22_7
{
    partial class BaseballForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseballForm));
            this.playersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseballDataSet = new P4_22_7.BaseballDataSet();
            this.playersTableAdapter = new P4_22_7.BaseballDataSetTableAdapters.PlayersTableAdapter();
            this.tableAdapterManager = new P4_22_7.BaseballDataSetTableAdapters.TableAdapterManager();
            this.battingAverageToolStrip = new System.Windows.Forms.ToolStrip();
            this.minAverageToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.minAverageToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.maxAverageToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.maxAverageToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.battingAverageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseballDataSet)).BeginInit();
            this.battingAverageToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // playersDataGridView
            // 
            this.playersDataGridView.AutoGenerateColumns = false;
            this.playersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.playersDataGridView.DataSource = this.playersBindingSource;
            this.playersDataGridView.Location = new System.Drawing.Point(12, 37);
            this.playersDataGridView.Name = "playersDataGridView";
            this.playersDataGridView.Size = new System.Drawing.Size(450, 220);
            this.playersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PlayerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PlayerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BattingAverage";
            this.dataGridViewTextBoxColumn4.HeaderText = "BattingAverage";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.baseballDataSet;
            // 
            // baseballDataSet
            // 
            this.baseballDataSet.DataSetName = "BaseballDataSet";
            this.baseballDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlayersTableAdapter = this.playersTableAdapter;
            this.tableAdapterManager.UpdateOrder = P4_22_7.BaseballDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // battingAverageToolStrip
            // 
            this.battingAverageToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.battingAverageToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minAverageToolStripLabel,
            this.minAverageToolStripTextBox,
            this.maxAverageToolStripLabel,
            this.maxAverageToolStripTextBox,
            this.battingAverageToolStripButton,
            this.toolStripButton1});
            this.battingAverageToolStrip.Location = new System.Drawing.Point(12, 9);
            this.battingAverageToolStrip.Name = "battingAverageToolStrip";
            this.battingAverageToolStrip.Size = new System.Drawing.Size(481, 25);
            this.battingAverageToolStrip.TabIndex = 6;
            this.battingAverageToolStrip.Text = "battingAverageToolStrip";
            // 
            // minAverageToolStripLabel
            // 
            this.minAverageToolStripLabel.Name = "minAverageToolStripLabel";
            this.minAverageToolStripLabel.Size = new System.Drawing.Size(74, 22);
            this.minAverageToolStripLabel.Text = "MinAverage:";
            // 
            // minAverageToolStripTextBox
            // 
            this.minAverageToolStripTextBox.Name = "minAverageToolStripTextBox";
            this.minAverageToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.minAverageToolStripTextBox.Text = "0.000";
            // 
            // maxAverageToolStripLabel
            // 
            this.maxAverageToolStripLabel.Name = "maxAverageToolStripLabel";
            this.maxAverageToolStripLabel.Size = new System.Drawing.Size(75, 22);
            this.maxAverageToolStripLabel.Text = "MaxAverage:";
            // 
            // maxAverageToolStripTextBox
            // 
            this.maxAverageToolStripTextBox.Name = "maxAverageToolStripTextBox";
            this.maxAverageToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.maxAverageToolStripTextBox.Text = "1.000";
            // 
            // battingAverageToolStripButton
            // 
            this.battingAverageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.battingAverageToolStripButton.Name = "battingAverageToolStripButton";
            this.battingAverageToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.battingAverageToolStripButton.Text = "Search";
            this.battingAverageToolStripButton.Click += new System.EventHandler(this.battingAverageToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(39, 22);
            this.toolStripButton1.Text = "Reset";
            this.toolStripButton1.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // BaseballForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 304);
            this.Controls.Add(this.battingAverageToolStrip);
            this.Controls.Add(this.playersDataGridView);
            this.Name = "BaseballForm";
            this.Text = "Baseball Stats";
            this.Load += new System.EventHandler(this.BaseballForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseballDataSet)).EndInit();
            this.battingAverageToolStrip.ResumeLayout(false);
            this.battingAverageToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseballDataSet baseballDataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private BaseballDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private BaseballDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView playersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStrip battingAverageToolStrip;
        private System.Windows.Forms.ToolStripLabel minAverageToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox minAverageToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel maxAverageToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox maxAverageToolStripTextBox;
        private System.Windows.Forms.ToolStripButton battingAverageToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

