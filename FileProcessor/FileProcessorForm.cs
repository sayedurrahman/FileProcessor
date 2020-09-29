using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileProcessor
{
    public partial class FileProcessorForm : Form
    {
        public FileProcessorForm()
        {
            InitializeComponent();
            new Service.FileProcessorController("G:\\Delete2").UpdateCompanyName();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            ShowFolderBrowsedDialog();
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {

        }

        private void repoPathTextBox_Click(object sender, EventArgs e)
        {
            ShowFolderBrowsedDialog();
        }

        private void ShowFolderBrowsedDialog()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.Desktop,
                Description = "Select Folder",
                ShowNewFolderButton = false
            };

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                repoPathTextBox.Text = fbd.SelectedPath;
                replaceButton.Enabled = true;
                targetTextBox.Focus();
            }
            else
            {
                repoPathTextBox.Text = "";
                replaceButton.Enabled = false;
            }
        }
    }
}
