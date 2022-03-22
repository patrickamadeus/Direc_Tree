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

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                GraphPanel.Controls.Clear();

                var g = new Graph();
                List<string> foundPath = new List<string>();
                if (BFSbutton.Checked)
                {
                    GraphPanel.Controls.Add(g.ShowGraph(BFS.BFSsearching(AllOccurence.Checked, DirectoryText.Text, FileInput.Text, ref foundPath),true));
                }
                else
                {
                    GraphPanel.Controls.Add(g.ShowGraph(DFS.DFSsearching(AllOccurence.Checked, DirectoryText.Text, FileInput.Text, ref foundPath),false));
                }

                FoundDirText.Text = "File Path : \n";
                foreach(string path in foundPath)
                {
                    FoundDirText.Text += path + "\n";
                }
                
                stopwatch.Stop();
                TimeSpentText.Text = "Time Spent: " + (stopwatch.ElapsedMilliseconds/1000.0).ToString()+"s";
            }

        }
    }
}
