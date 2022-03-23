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
                DirTextInput.Text = openFileDialog.FileName;
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
            if ((!BFSbutton.Checked && !DFSbutton.Checked) || DirTextInput.Text == "" || FileInput.Text == "")
            {
                WarningLabel.Text = "";
                System.Threading.Thread.Sleep(20);
                WarningLabel.Text = "Please fill in required fields";
            }
            else
            {

                WarningLabel.Text = "";

                Stopwatch stopwatch = new Stopwatch();

                // Clearing Old Output(s)
                FoundDirs.Items.Clear();
                GraphPanel.Controls.Clear();

                var g = new Graph();
                Dictionary<string, int> nodes;
                List<string> foundPath = new List<string>();
                if (BFSbutton.Checked)
                {
                    stopwatch.Start();
                    nodes = BFS.BFSsearching(AllOccurence.Checked, DirTextInput.Text, FileInput.Text, ref foundPath);
                    stopwatch.Stop();
                }
                else
                {
                    stopwatch.Start();
                    nodes = DFS.DFSsearching(AllOccurence.Checked, DirTextInput.Text, FileInput.Text, ref foundPath);
                    stopwatch.Stop();
                }
    
                GraphPanel.Controls.Add(g.ShowGraph(nodes, true));

                foreach (string path in foundPath)
                {
                    FoundDirs.Items.Add(path);
                }
                
                TimeSpentText.Text = "Time Spent: " + (stopwatch.ElapsedMilliseconds/1000.0).ToString()+"s";
            }

            
        }

        private void FoundDirs_SelectedIndexChanged(object sender, EventArgs e) => System.Diagnostics.Process.Start("explorer.exe", FoundDirs.SelectedItem.ToString());
    }

    public class hyperlink
    {
        public string name;
        public string url;
    }
}
