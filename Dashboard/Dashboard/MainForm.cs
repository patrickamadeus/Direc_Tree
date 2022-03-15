using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Dashboard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BFS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DFS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StartDirectory_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog();
            openFileDialog.IsFolderPicker = true;
            if (openFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DirectoryText.Text = openFileDialog.FileName;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if ((!BFS.Checked && !DFS.Checked) || DirectoryText.Text == "" || FileInput.Text == "")
            {
                WarningLabel.Text = "";
                System.Threading.Thread.Sleep(20);
                WarningLabel.Text = "Please fill in required fields";
            }
            else
            {
                WarningLabel.Text = "";
                SampleForm form = new SampleForm(DirectoryText.Text, FileInput.Text, AllOccurence.Checked, BFS.Checked);
                form.ShowDialog();
            }

        }
    }
}
