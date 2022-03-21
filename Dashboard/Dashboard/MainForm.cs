using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void StartDirectory_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog();
            openFileDialog.IsFolderPicker = true;
            if (openFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DirectoryText.Text = openFileDialog.FileName;
            }
        }
        public static string visualizeMap(Dictionary<string, int> map)
        {
            string result = "";
            foreach (KeyValuePair<string, int> i in map)
            {
                result = result + (i.Key + ": " + i.Value + "  \n");
            }
            return result;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if ((!BFSbutton.Checked && !DFSbutton.Checked) || DirectoryText.Text == "" || FileInput.Text == "")
            {
                WarningLabel.Text = "";
                System.Threading.Thread.Sleep(20);
                WarningLabel.Text = "Please fill in required fields";
            }
            else
            {

                WarningLabel.Text = "";
                //SampleForm form = new SampleForm(DirectoryText.Text, FileInput.Text, AllOccurence.Checked, BFS.Checked);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();


                var g = new Graph();
                if (BFSbutton.Checked)
                {
                    GraphPanel.Controls.Add(g.ShowGraph(BFS.BFSsearching(AllOccurence.Checked, DirectoryText.Text, FileInput.Text)));
                }
                else
                {
                    GraphPanel.Controls.Add(g.ShowGraph(DFS.DFSsearching(AllOccurence.Checked, DirectoryText.Text, FileInput.Text)));
                }

                FoundDirText.Text = "File Path : " + DirectoryText.Text; //TODO : append found dir
                if (BFSbutton.Checked)
                {
                    FoundDirText.Text = visualizeMap(BFS.BFSsearching(AllOccurence.Checked, DirectoryText.Text, FileInput.Text));
                }
                else
                {
                    FoundDirText.Text = visualizeMap(DFS.DFSsearching(AllOccurence.Checked, DirectoryText.Text, FileInput.Text));
                }
                
                stopwatch.Stop();
                TimeSpentText.Text = "Time Spent: " + (stopwatch.ElapsedMilliseconds/1000.0).ToString()+"s";
            }

        }
    }
}
