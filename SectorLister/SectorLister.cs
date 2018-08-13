using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SectorLister
{
    public partial class SectorLister : Form
    {
        public SectorLister()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // init output file to %UserProfile%\Desktop
            txtOutputDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            String filename = txtOutputDir.Text + "\\ImportStars.txt";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
            {
                int start = Decimal.ToInt32(updnStart.Value);
                int end = Decimal.ToInt32(updnEnd.Value);
                progressBar.Maximum = (end - start);
                for (int i = start; i <= end; i++)
                {
                    // write data
                    String line = txtSectorName.Text + i.ToString();
                    file.WriteLine(line);

                    // update progress bar
                    progressBar.Value = i - start;
                }
            }
        }

        private void btnOutputDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Select where to save \"ImportedStars.txt\" file";
            dlg.SelectedPath = txtOutputDir.Text;
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK)
            {
                txtOutputDir.Text = dlg.SelectedPath;
            }
        }
    }
}
