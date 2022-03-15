using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class SampleForm : Form
    {
        public SampleForm(string dir, string file, bool occ, bool type)
        {
            InitializeComponent();
            label1.Text = dir;
            label2.Text = file;
            label3.Text = occ.ToString();
            label4.Text = type.ToString();
        }

        public string Value { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Value;
        }
    }
}
