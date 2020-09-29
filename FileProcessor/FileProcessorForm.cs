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
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            string targetString = string.IsNullOrWhiteSpace(targetTextBox.Text) ? "Software People" : targetTextBox.Text;
            string replaceString = string.IsNullOrWhiteSpace(replaceTextBox.Text) ? "Software People Bangladesh" : replaceTextBox.Text;
            var controller = new Service.FileProcessorController(repoFolderBrowserDialog.SelectedPath, targetString, replaceString);
            controller.UpdateCompanyName();
            Reset();
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

        private void Reset() 
        {
            repoFolderBrowserDialog.SelectedPath = "";
            repoPathTextBox.Text = "";
            targetTextBox.Text = "";
            replaceTextBox.Text = "";
        }
    }
}
