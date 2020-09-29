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
            string targetString = string.IsNullOrWhiteSpace(targetTextBox.Text) ? "Software People" : targetTextBox.Text;
            string replaceString = string.IsNullOrWhiteSpace(replaceTextBox.Text) ? "Software People Bangladesh" : replaceTextBox.Text;
            var controller = new Service.FileProcessorController(repoFolderBrowserDialog.SelectedPath, targetString, replaceString);
            
            // Release the UIThread
            await Task.Run(() => controller.UpdateTextInFile());
            
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
        }
    }
}
