using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileProcessor
{
    public partial class FileProcessorForm : Form
    {
        public FileProcessorForm()
        {
            InitializeComponent();
        }

        private async void replaceButton_Click(object sender, EventArgs e)
        {
            timeEndLabel.Text = "";

            string targetString = string.IsNullOrWhiteSpace(targetTextBox.Text) ? "SoftwarePeople" : targetTextBox.Text;
            string replaceString = string.IsNullOrWhiteSpace(replaceTextBox.Text) ? "SoftwarePeople Bangladesh" : replaceTextBox.Text;
            var controller = new Service.FileProcessorController(repoFolderBrowserDialog.SelectedPath, targetString, replaceString);
            timeStartLlabel.Text = $"Start-{DateTime.Now.ToString("HH:mm:ss")}";
            Cursor = Cursors.WaitCursor;

            // Release the UIThread
            await Task.Run(() => controller.UpdateTextInFiles());
            timeEndLabel.Text = $"End-{DateTime.Now.ToString("HH:mm:ss")}";

            ResetControls();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            ShowFolderBrowsedDialog();
        }        

        private void repoPathTextBox_Click(object sender, EventArgs e)
        {
            ShowFolderBrowsedDialog();
        }

        private void ShowFolderBrowsedDialog()
        {
            if (repoFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                repoPathTextBox.Text = repoFolderBrowserDialog.SelectedPath;
                replaceButton.Enabled = true;
                targetTextBox.Focus();
            }
            else
            {
                repoPathTextBox.Text = "";
                replaceButton.Enabled = false;
            }
        }

        private void ResetControls() 
        {
            repoFolderBrowserDialog.SelectedPath = "";
            repoPathTextBox.Text = "";
            targetTextBox.Text = "";
            replaceTextBox.Text = "";
            Cursor = Cursors.Arrow;
        }
    }
}
