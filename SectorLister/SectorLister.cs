using System;
using System.Drawing;
using System.Windows.Forms;

namespace SectorLister
{
    public partial class SectorLister : Form
    {
        private struct sectorPos
        {
            public int x;
            public int y;
            public int z;
            public char code;
            public int num;
        }

        private sectorPos spTarget;
        private String sTargetPrefix = "";

        public SectorLister()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // init output file to %UserProfile%\Desktop
            txtOutputDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // disable isolator
            chkIsolate.Checked = false;
            grpIsolate.Enabled = false;

            // resize listview column width
            lstSystemNames.Columns[0].Width = lstSystemNames.Width - 24;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // reset progress bar
            progressBar.Value = 0;

            String filename = txtOutputDir.Text + "\\ImportStars.txt";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, chkAppend.Checked))
            {
                // single system ?
                if (!chkIsolate.Checked)
                {
                    int start = Decimal.ToInt32(updnStart.Value);
                    int end = Decimal.ToInt32(updnEnd.Value);
                    progressBar.Maximum = (end - start);
                    for (int i = start; i <= end; i++)
                    {
                        // write data
                        String line = txtSectorName.Text + "-" + i.ToString();
                        file.WriteLine(line);

                        // update progress bar
                        progressBar.Value = i - start;
                    }
                }
                else
                {
                    int start = Decimal.ToInt32(updnStart.Value);
                    int end = Decimal.ToInt32(updnEnd.Value);
                    int count = lstSystemNames.Items.Count;
                    progressBar.Maximum = count;
                    // loop through all sectors in the list
                    for (int j = 0; j < count; j++)
                    {
                        ListViewItem item = lstSystemNames.Items[j];
                        for (int i = start; i <= end; i++)
                        {
                            // write data
                            String line2 = item.Text + "-" + i.ToString();
                            file.WriteLine(line2);
                        }

                        // update progress bar
                        progressBar.Value = j + 1;
                    }
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

        private void chkIsolate_CheckedChanged(object sender, EventArgs e)
        {
            grpIsolate.Enabled = chkIsolate.Checked;
        }

        private void updateIsolationList()
        {
            // remove any existing names
            lstSystemNames.Items.Clear();

            // find parents ?
            if (chkParents.Checked)
            {
                FindParents(spTarget.x, spTarget.y, spTarget.z, spTarget.code);
            }

            // find children and/or neighbours ?
            FindChildrenAndNeighbours(spTarget.x, spTarget.y, spTarget.z, spTarget.code, chkChildren.Checked, chkNeighbours.Checked);
        }

        private void chkParents_CheckedChanged(object sender, EventArgs e)
        {
            updateIsolationList();
        }

        private void chkChildren_CheckedChanged(object sender, EventArgs e)
        {
            updateIsolationList();
        }

        private void chkNeighbours_CheckedChanged(object sender, EventArgs e)
        {
            updateIsolationList();
        }

        sectorPos FindPosition(char a, char b, char c, char code, int d)
        {
            int pos = (d * (26 * 26 * 26)) + ((c - 'A') * (26 * 26)) + ((b - 'A') * 26) + (a - 'A');
            sectorPos sp;
            sp.x = pos % 128;
            sp.y = (pos / 128) % 128;
            sp.z = (pos / (128 * 128)) % 128;
            sp.code = code;
            sp.num = d;
            return sp;
        }

        private void FindParents(int x, int y, int z, char code)
        {
            code++;
            int size = (int)Math.Pow(2, (int)'H' - (int)code);
            while (size >= 1)
            {
                x /= 2;
                y /= 2;
                z /= 2;
                AddSectorName(x, y, z, code++);
                size /= 2;
            }
        }

        void FindChildrenAndNeighbours(int x, int y, int z, char code, bool bFindChildren, bool bFindNeighbours)
        {
            int x0 = x, y0 = y, z0 = z, code0 = code;
            int size = 1;
            int max = (int)Math.Pow(2, (int)'H' - ((int)code + 1));
            while (code > 'A')  // ignore A cubes ... otherwise use >= 'A'
            {
                max *= 2;
                for (int z2 = -1; z2 < (size + 1); z2++)
                {
                    // outside the target cube ?
                    // if so, ignore if not searching for neighbours
                    if (!bFindNeighbours &&
                        ((z2 < 0) || (z2 >= size)))
                        continue;

                    // outside the child cube range ?
                    if (((z2 + z) < 0) || ((z2 + z) >= max))
                        continue;

                    for (int y2 = -1; y2 < (size + 1); y2++)
                    {
                        // outside the target cube ?
                        // if so, ignore if not searching for neighbours
                        if (!bFindNeighbours &&
                            ((y2 < 0) || (y2 >= size)))
                            continue;

                        // outside the child cube range ?
                        if (((y2 + y) < 0) || ((y2 + y) >= max))
                            continue;

                        for (int x2 = -1; x2 < (size + 1); x2++)
                        {
                            // the target cube ?
                            // if so, always ignore
                            if ((code0 == code) &&
                                (x0 == (x2 + x)) &&
                                (y0 == (y2 + y)) &&
                                (z0 == (z2 + z)))
                                continue;

                            // outside the target cube ?
                            // if so, ignore if not searching for neighbours
                            if (!bFindNeighbours &&
                                ((x2 < 0) || (x2 >= size)))
                                continue;

                            // outside the child cube range ?
                            if (((x2 + x) < 0) || ((x2 + x) >= max))
                                continue;

                            // within the target cube ?
                            // if so, ignore if not searching for children 
                            if (!bFindChildren &&
                                (x2 >= 0) && (x2 < size) &&
                                (y2 >= 0) && (y2 < size) &&
                                (z2 >= 0) && (z2 < size))
                                continue;

                            AddSectorName(x2 + x, y2 + y, z2 + z, code);
                        }
                    }
                }

                size *= 2;
                x *= 2;
                y *= 2;
                z *= 2;
                code--;
            }
        }

        void AddSectorName(int x, int y, int z, char code)
        {
            int location = (z * (128 * 128)) + (y * 128) + x;
            int a = location % 26;
            int b = (location / 26) % 26;
            int c = (location / (26 * 26)) % 26;
            int d = location / (26 * 26 * 26);

            String s = Char.ToString((char)(a + (int)'A')) + Char.ToString((char)(b + (int)'A')) + "-" + Char.ToString((char)(c + (int)'A')) + " " + code;
            if (d != 0)
                s += d.ToString();

            lstSystemNames.Items.Add(sTargetPrefix + " " + s);
        }

        private void txtSectorName_TextChanged(object sender, EventArgs e)
        {
            // target name format:-
            // <sector prefix> AB-C D<0,1,2 or 3 digit num>

            // Examples:-
            // EOL PROU AA-A D
            // Plaa Aescs KW-U b16
            // Tegnae RD-T e3

            // reset target
            spTarget.x = 0;
            spTarget.y = 0;
            spTarget.z = 0;
            spTarget.code = 'A';
            spTarget.num = 0;

            // assume name is invalid
            txtSectorName.BackColor = Color.Red;

            int len = txtSectorName.TextLength;
            if (len < 8)
                return;

            // find penultimate space
            int nPos = txtSectorName.Text.LastIndexOf(' ');
            if ((nPos == -1) || (nPos == 0))
                return;
            nPos = txtSectorName.Text.LastIndexOf(' ', nPos - 1);
            if ((nPos == -1) || ((len - nPos) < 7))
                return;

            // extract prefix
            String sPrefix = txtSectorName.Text.Substring(0, nPos).Trim();
            if (sPrefix.Length == 0)
                return;

            // extract 'A', 'B', '-', 'C', ' ', 'D'
            nPos++;
            Char a = Char.ToUpper(txtSectorName.Text[nPos++]);
            if (!Char.IsLetter(a))
                return;
            Char b = Char.ToUpper(txtSectorName.Text[nPos++]);
            if (!Char.IsLetter(b))
                return;
            if (txtSectorName.Text[nPos++] != '-')
                return;
            Char c = Char.ToUpper(txtSectorName.Text[nPos++]);
            if (!Char.IsLetter(c))
                return;
            if (txtSectorName.Text[nPos++] != ' ')
                return;
            Char d = Char.ToUpper(txtSectorName.Text[nPos++]);
            if (!Char.IsLetter(d))
                return;

            // check for optional <num>
            int nNum = 0;
            if (nPos < len)
            {
                while (nPos < len)
                {
                    Char n = txtSectorName.Text[nPos++];
                    if (!Char.IsDigit(n))
                        return;
                    nNum = (nNum * 10) + (n - '0');
                }

                // invalid number ?
                if (nNum > 119)
                    return;
            }

            // seems valid
            spTarget = FindPosition(a, b, c, d, nNum);
            sTargetPrefix = sPrefix;
            txtSectorName.BackColor = SystemColors.Window;
        }
    }
}

