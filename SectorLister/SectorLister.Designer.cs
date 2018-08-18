namespace SectorLister
{
    partial class SectorLister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSectorName = new System.Windows.Forms.Label();
            this.txtSectorName = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.updnStart = new System.Windows.Forms.NumericUpDown();
            this.updnEnd = new System.Windows.Forms.NumericUpDown();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOutputDir = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.chkAppend = new System.Windows.Forms.CheckBox();
            this.chkIsolate = new System.Windows.Forms.CheckBox();
            this.grpIsolate = new System.Windows.Forms.GroupBox();
            this.lstSystemNames = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkNeighbours = new System.Windows.Forms.CheckBox();
            this.chkChildren = new System.Windows.Forms.CheckBox();
            this.chkParents = new System.Windows.Forms.CheckBox();
            this.updnCountH = new System.Windows.Forms.NumericUpDown();
            this.lblCountH = new System.Windows.Forms.Label();
            this.lblCountG = new System.Windows.Forms.Label();
            this.updnCountG = new System.Windows.Forms.NumericUpDown();
            this.lblCountF = new System.Windows.Forms.Label();
            this.updnCountF = new System.Windows.Forms.NumericUpDown();
            this.lblCountE = new System.Windows.Forms.Label();
            this.updnCountE = new System.Windows.Forms.NumericUpDown();
            this.lblCountA = new System.Windows.Forms.Label();
            this.updnCountA = new System.Windows.Forms.NumericUpDown();
            this.lblCountB = new System.Windows.Forms.Label();
            this.updnCountB = new System.Windows.Forms.NumericUpDown();
            this.lblCountC = new System.Windows.Forms.Label();
            this.updnCountC = new System.Windows.Forms.NumericUpDown();
            this.lblCountD = new System.Windows.Forms.Label();
            this.updnCountD = new System.Windows.Forms.NumericUpDown();
            this.pnlCounts = new System.Windows.Forms.Panel();
            this.chkIncludeA = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.updnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnEnd)).BeginInit();
            this.grpIsolate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountD)).BeginInit();
            this.pnlCounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSectorName
            // 
            this.lblSectorName.AutoSize = true;
            this.lblSectorName.Location = new System.Drawing.Point(24, 12);
            this.lblSectorName.Name = "lblSectorName";
            this.lblSectorName.Size = new System.Drawing.Size(69, 13);
            this.lblSectorName.TabIndex = 0;
            this.lblSectorName.Text = "Sector Name";
            this.lblSectorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSectorName
            // 
            this.txtSectorName.Location = new System.Drawing.Point(99, 9);
            this.txtSectorName.Name = "txtSectorName";
            this.txtSectorName.Size = new System.Drawing.Size(177, 20);
            this.txtSectorName.TabIndex = 1;
            this.txtSectorName.TextChanged += new System.EventHandler(this.txtSectorName_TextChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(67, 333);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Start";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // updnStart
            // 
            this.updnStart.Location = new System.Drawing.Point(102, 331);
            this.updnStart.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.updnStart.Name = "updnStart";
            this.updnStart.Size = new System.Drawing.Size(68, 20);
            this.updnStart.TabIndex = 4;
            // 
            // updnEnd
            // 
            this.updnEnd.Location = new System.Drawing.Point(102, 357);
            this.updnEnd.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.updnEnd.Name = "updnEnd";
            this.updnEnd.Size = new System.Drawing.Size(68, 20);
            this.updnEnd.TabIndex = 5;
            this.updnEnd.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(70, 359);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(26, 13);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "End";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Location = new System.Drawing.Point(102, 383);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(140, 20);
            this.txtOutputDir.TabIndex = 7;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(15, 432);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(264, 47);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Output Directory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOutputDir
            // 
            this.btnOutputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputDir.Location = new System.Drawing.Point(248, 382);
            this.btnOutputDir.Name = "btnOutputDir";
            this.btnOutputDir.Size = new System.Drawing.Size(28, 20);
            this.btnOutputDir.TabIndex = 10;
            this.btnOutputDir.Text = "...";
            this.btnOutputDir.UseVisualStyleBackColor = true;
            this.btnOutputDir.Click += new System.EventHandler(this.btnOutputDir_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 485);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(264, 10);
            this.progressBar.TabIndex = 11;
            // 
            // chkAppend
            // 
            this.chkAppend.AutoSize = true;
            this.chkAppend.Location = new System.Drawing.Point(24, 409);
            this.chkAppend.Name = "chkAppend";
            this.chkAppend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAppend.Size = new System.Drawing.Size(91, 17);
            this.chkAppend.TabIndex = 12;
            this.chkAppend.Text = "Append to file";
            this.chkAppend.UseVisualStyleBackColor = true;
            // 
            // chkIsolate
            // 
            this.chkIsolate.AutoSize = true;
            this.chkIsolate.Location = new System.Drawing.Point(24, 35);
            this.chkIsolate.Name = "chkIsolate";
            this.chkIsolate.Size = new System.Drawing.Size(93, 17);
            this.chkIsolate.TabIndex = 13;
            this.chkIsolate.Text = "Isolate cube ?";
            this.chkIsolate.UseVisualStyleBackColor = true;
            this.chkIsolate.CheckedChanged += new System.EventHandler(this.chkIsolate_CheckedChanged);
            // 
            // grpIsolate
            // 
            this.grpIsolate.Controls.Add(this.chkIncludeA);
            this.grpIsolate.Controls.Add(this.lstSystemNames);
            this.grpIsolate.Controls.Add(this.chkNeighbours);
            this.grpIsolate.Controls.Add(this.chkChildren);
            this.grpIsolate.Controls.Add(this.chkParents);
            this.grpIsolate.Location = new System.Drawing.Point(12, 35);
            this.grpIsolate.Name = "grpIsolate";
            this.grpIsolate.Size = new System.Drawing.Size(264, 243);
            this.grpIsolate.TabIndex = 15;
            this.grpIsolate.TabStop = false;
            // 
            // lstSystemNames
            // 
            this.lstSystemNames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstSystemNames.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstSystemNames.Location = new System.Drawing.Point(6, 46);
            this.lstSystemNames.MultiSelect = false;
            this.lstSystemNames.Name = "lstSystemNames";
            this.lstSystemNames.Size = new System.Drawing.Size(252, 191);
            this.lstSystemNames.TabIndex = 19;
            this.lstSystemNames.UseCompatibleStateImageBehavior = false;
            this.lstSystemNames.View = System.Windows.Forms.View.Details;
            // 
            // chkNeighbours
            // 
            this.chkNeighbours.AutoSize = true;
            this.chkNeighbours.Location = new System.Drawing.Point(144, 23);
            this.chkNeighbours.Name = "chkNeighbours";
            this.chkNeighbours.Size = new System.Drawing.Size(80, 17);
            this.chkNeighbours.TabIndex = 18;
            this.chkNeighbours.Text = "Neighbours";
            this.chkNeighbours.UseVisualStyleBackColor = true;
            this.chkNeighbours.CheckedChanged += new System.EventHandler(this.chkNeighbours_CheckedChanged);
            // 
            // chkChildren
            // 
            this.chkChildren.AutoSize = true;
            this.chkChildren.Location = new System.Drawing.Point(74, 23);
            this.chkChildren.Name = "chkChildren";
            this.chkChildren.Size = new System.Drawing.Size(64, 17);
            this.chkChildren.TabIndex = 17;
            this.chkChildren.Text = "Children";
            this.chkChildren.UseVisualStyleBackColor = true;
            this.chkChildren.CheckedChanged += new System.EventHandler(this.chkChildren_CheckedChanged);
            // 
            // chkParents
            // 
            this.chkParents.AutoSize = true;
            this.chkParents.Location = new System.Drawing.Point(6, 23);
            this.chkParents.Name = "chkParents";
            this.chkParents.Size = new System.Drawing.Size(62, 17);
            this.chkParents.TabIndex = 16;
            this.chkParents.Text = "Parents";
            this.chkParents.UseVisualStyleBackColor = true;
            this.chkParents.CheckedChanged += new System.EventHandler(this.chkParents_CheckedChanged);
            // 
            // updnCountH
            // 
            this.updnCountH.Location = new System.Drawing.Point(69, 3);
            this.updnCountH.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.updnCountH.Name = "updnCountH";
            this.updnCountH.Size = new System.Drawing.Size(53, 20);
            this.updnCountH.TabIndex = 16;
            this.updnCountH.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblCountH
            // 
            this.lblCountH.AutoSize = true;
            this.lblCountH.Location = new System.Drawing.Point(6, 5);
            this.lblCountH.Name = "lblCountH";
            this.lblCountH.Size = new System.Drawing.Size(57, 13);
            this.lblCountH.TabIndex = 17;
            this.lblCountH.Text = "H Systems";
            // 
            // lblCountG
            // 
            this.lblCountG.AutoSize = true;
            this.lblCountG.Location = new System.Drawing.Point(6, 27);
            this.lblCountG.Name = "lblCountG";
            this.lblCountG.Size = new System.Drawing.Size(57, 13);
            this.lblCountG.TabIndex = 19;
            this.lblCountG.Text = "G Systems";
            // 
            // updnCountG
            // 
            this.updnCountG.Location = new System.Drawing.Point(69, 25);
            this.updnCountG.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.updnCountG.Name = "updnCountG";
            this.updnCountG.Size = new System.Drawing.Size(53, 20);
            this.updnCountG.TabIndex = 18;
            this.updnCountG.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // lblCountF
            // 
            this.lblCountF.AutoSize = true;
            this.lblCountF.Location = new System.Drawing.Point(6, 49);
            this.lblCountF.Name = "lblCountF";
            this.lblCountF.Size = new System.Drawing.Size(55, 13);
            this.lblCountF.TabIndex = 21;
            this.lblCountF.Text = "F Systems";
            // 
            // updnCountF
            // 
            this.updnCountF.Location = new System.Drawing.Point(69, 47);
            this.updnCountF.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.updnCountF.Name = "updnCountF";
            this.updnCountF.Size = new System.Drawing.Size(53, 20);
            this.updnCountF.TabIndex = 20;
            this.updnCountF.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // lblCountE
            // 
            this.lblCountE.AutoSize = true;
            this.lblCountE.Location = new System.Drawing.Point(6, 71);
            this.lblCountE.Name = "lblCountE";
            this.lblCountE.Size = new System.Drawing.Size(56, 13);
            this.lblCountE.TabIndex = 23;
            this.lblCountE.Text = "E Systems";
            // 
            // updnCountE
            // 
            this.updnCountE.Location = new System.Drawing.Point(69, 69);
            this.updnCountE.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.updnCountE.Name = "updnCountE";
            this.updnCountE.Size = new System.Drawing.Size(53, 20);
            this.updnCountE.TabIndex = 22;
            this.updnCountE.Value = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            // 
            // lblCountA
            // 
            this.lblCountA.AutoSize = true;
            this.lblCountA.Enabled = false;
            this.lblCountA.Location = new System.Drawing.Point(142, 71);
            this.lblCountA.Name = "lblCountA";
            this.lblCountA.Size = new System.Drawing.Size(56, 13);
            this.lblCountA.TabIndex = 31;
            this.lblCountA.Text = "A Systems";
            // 
            // updnCountA
            // 
            this.updnCountA.Enabled = false;
            this.updnCountA.Location = new System.Drawing.Point(205, 69);
            this.updnCountA.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.updnCountA.Name = "updnCountA";
            this.updnCountA.Size = new System.Drawing.Size(53, 20);
            this.updnCountA.TabIndex = 30;
            this.updnCountA.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // lblCountB
            // 
            this.lblCountB.AutoSize = true;
            this.lblCountB.Location = new System.Drawing.Point(142, 49);
            this.lblCountB.Name = "lblCountB";
            this.lblCountB.Size = new System.Drawing.Size(56, 13);
            this.lblCountB.TabIndex = 29;
            this.lblCountB.Text = "B Systems";
            // 
            // updnCountB
            // 
            this.updnCountB.Location = new System.Drawing.Point(205, 47);
            this.updnCountB.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.updnCountB.Name = "updnCountB";
            this.updnCountB.Size = new System.Drawing.Size(53, 20);
            this.updnCountB.TabIndex = 28;
            this.updnCountB.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // lblCountC
            // 
            this.lblCountC.AutoSize = true;
            this.lblCountC.Location = new System.Drawing.Point(142, 27);
            this.lblCountC.Name = "lblCountC";
            this.lblCountC.Size = new System.Drawing.Size(56, 13);
            this.lblCountC.TabIndex = 27;
            this.lblCountC.Text = "C Systems";
            // 
            // updnCountC
            // 
            this.updnCountC.Location = new System.Drawing.Point(205, 25);
            this.updnCountC.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.updnCountC.Name = "updnCountC";
            this.updnCountC.Size = new System.Drawing.Size(53, 20);
            this.updnCountC.TabIndex = 26;
            this.updnCountC.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // lblCountD
            // 
            this.lblCountD.AutoSize = true;
            this.lblCountD.Location = new System.Drawing.Point(142, 5);
            this.lblCountD.Name = "lblCountD";
            this.lblCountD.Size = new System.Drawing.Size(57, 13);
            this.lblCountD.TabIndex = 25;
            this.lblCountD.Text = "D Systems";
            // 
            // updnCountD
            // 
            this.updnCountD.Location = new System.Drawing.Point(205, 3);
            this.updnCountD.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.updnCountD.Name = "updnCountD";
            this.updnCountD.Size = new System.Drawing.Size(53, 20);
            this.updnCountD.TabIndex = 24;
            this.updnCountD.Value = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            // 
            // pnlCounts
            // 
            this.pnlCounts.Controls.Add(this.updnCountA);
            this.pnlCounts.Controls.Add(this.lblCountE);
            this.pnlCounts.Controls.Add(this.updnCountC);
            this.pnlCounts.Controls.Add(this.updnCountD);
            this.pnlCounts.Controls.Add(this.updnCountE);
            this.pnlCounts.Controls.Add(this.lblCountD);
            this.pnlCounts.Controls.Add(this.lblCountC);
            this.pnlCounts.Controls.Add(this.lblCountA);
            this.pnlCounts.Controls.Add(this.updnCountH);
            this.pnlCounts.Controls.Add(this.updnCountB);
            this.pnlCounts.Controls.Add(this.lblCountF);
            this.pnlCounts.Controls.Add(this.lblCountH);
            this.pnlCounts.Controls.Add(this.updnCountG);
            this.pnlCounts.Controls.Add(this.lblCountB);
            this.pnlCounts.Controls.Add(this.updnCountF);
            this.pnlCounts.Controls.Add(this.lblCountG);
            this.pnlCounts.Location = new System.Drawing.Point(12, 281);
            this.pnlCounts.Name = "pnlCounts";
            this.pnlCounts.Size = new System.Drawing.Size(264, 96);
            this.pnlCounts.TabIndex = 32;
            this.pnlCounts.Visible = false;
            // 
            // chkIncludeA
            // 
            this.chkIncludeA.AutoSize = true;
            this.chkIncludeA.Location = new System.Drawing.Point(141, 0);
            this.chkIncludeA.Name = "chkIncludeA";
            this.chkIncludeA.Size = new System.Drawing.Size(117, 17);
            this.chkIncludeA.TabIndex = 32;
            this.chkIncludeA.Text = "Include A sectors ?";
            this.chkIncludeA.UseVisualStyleBackColor = true;
            this.chkIncludeA.CheckedChanged += new System.EventHandler(this.chkIncludeA_CheckedChanged);
            // 
            // SectorLister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 509);
            this.Controls.Add(this.pnlCounts);
            this.Controls.Add(this.chkIsolate);
            this.Controls.Add(this.lblSectorName);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.chkAppend);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtSectorName);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.btnOutputDir);
            this.Controls.Add(this.txtOutputDir);
            this.Controls.Add(this.updnStart);
            this.Controls.Add(this.grpIsolate);
            this.Controls.Add(this.updnEnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SectorLister";
            this.Text = "Sector Lister 1v4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnEnd)).EndInit();
            this.grpIsolate.ResumeLayout(false);
            this.grpIsolate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnCountD)).EndInit();
            this.pnlCounts.ResumeLayout(false);
            this.pnlCounts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSectorName;
        private System.Windows.Forms.TextBox txtSectorName;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.NumericUpDown updnStart;
        private System.Windows.Forms.NumericUpDown updnEnd;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtOutputDir;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOutputDir;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox chkAppend;
        private System.Windows.Forms.CheckBox chkIsolate;
        private System.Windows.Forms.GroupBox grpIsolate;
        private System.Windows.Forms.CheckBox chkNeighbours;
        private System.Windows.Forms.CheckBox chkChildren;
        private System.Windows.Forms.CheckBox chkParents;
        private System.Windows.Forms.ListView lstSystemNames;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.NumericUpDown updnCountH;
        private System.Windows.Forms.Label lblCountH;
        private System.Windows.Forms.Label lblCountG;
        private System.Windows.Forms.NumericUpDown updnCountG;
        private System.Windows.Forms.Label lblCountF;
        private System.Windows.Forms.NumericUpDown updnCountF;
        private System.Windows.Forms.Label lblCountE;
        private System.Windows.Forms.NumericUpDown updnCountE;
        private System.Windows.Forms.Label lblCountA;
        private System.Windows.Forms.NumericUpDown updnCountA;
        private System.Windows.Forms.Label lblCountB;
        private System.Windows.Forms.NumericUpDown updnCountB;
        private System.Windows.Forms.Label lblCountC;
        private System.Windows.Forms.NumericUpDown updnCountC;
        private System.Windows.Forms.Label lblCountD;
        private System.Windows.Forms.NumericUpDown updnCountD;
        private System.Windows.Forms.Panel pnlCounts;
        private System.Windows.Forms.CheckBox chkIncludeA;
    }
}

