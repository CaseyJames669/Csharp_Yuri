using System;
using System.Windows.Forms;

namespace P4_22_7
{
    public partial class BaseballForm : Form
    {
        public BaseballForm()
        {
            InitializeComponent();
        }

        private void playersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseballDataSet);

        }

        private void BaseballForm_Load(object sender, EventArgs e)
        {
            this.playersTableAdapter.Fill(this.baseballDataSet.Players);

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.playersTableAdapter.Fill(this.baseballDataSet.Players);
        }

        private void battingAverageToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.playersTableAdapter.BattingAverage(this.baseballDataSet.Players, ((decimal)(System.Convert.ChangeType(minAverageToolStripTextBox.Text, typeof(decimal)))), ((decimal)(System.Convert.ChangeType(maxAverageToolStripTextBox.Text, typeof(decimal)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
