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
            this.chkNeighbours = new System.Windows.Forms.CheckBox();
            this.chkChildren = new System.Windows.Forms.CheckBox();
            this.chkParents = new System.Windows.Forms.CheckBox();
            this.lstSystemNames = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.updnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnEnd)).BeginInit();
            this.grpIsolate.SuspendLayout();
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
            this.lblStart.Location = new System.Drawing.Point(64, 292);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Start";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // updnStart
            // 
            this.updnStart.Location = new System.Drawing.Point(99, 290);
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
            this.updnEnd.Location = new System.Drawing.Point(99, 316);
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
            this.lblEnd.Location = new System.Drawing.Point(67, 318);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(26, 13);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "End";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Location = new System.Drawing.Point(99, 342);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(140, 20);
            this.txtOutputDir.TabIndex = 7;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 391);
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
            this.label1.Location = new System.Drawing.Point(9, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Output Directory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOutputDir
            // 
            this.btnOutputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputDir.Location = new System.Drawing.Point(245, 341);
            this.btnOutputDir.Name = "btnOutputDir";
            this.btnOutputDir.Size = new System.Drawing.Size(28, 20);
            this.btnOutputDir.TabIndex = 10;
            this.btnOutputDir.Text = "...";
            this.btnOutputDir.UseVisualStyleBackColor = true;
            this.btnOutputDir.Click += new System.EventHandler(this.btnOutputDir_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 444);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(264, 10);
            this.progressBar.TabIndex = 11;
            // 
            // chkAppend
            // 
            this.chkAppend.AutoSize = true;
            this.chkAppend.Location = new System.Drawing.Point(21, 368);
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
            this.grpIsolate.Controls.Add(this.lstSystemNames);
            this.grpIsolate.Controls.Add(this.chkNeighbours);
            this.grpIsolate.Controls.Add(this.chkChildren);
            this.grpIsolate.Controls.Add(this.chkParents);
            this.grpIsolate.Location = new System.Drawing.Point(12, 35);
            this.grpIsolate.Name = "grpIsolate";
            this.grpIsolate.Size = new System.Drawing.Size(264, 249);
            this.grpIsolate.TabIndex = 15;
            this.grpIsolate.TabStop = false;
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
            // lstSystemNames
            // 
            this.lstSystemNames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstSystemNames.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstSystemNames.Location = new System.Drawing.Point(6, 46);
            this.lstSystemNames.MultiSelect = false;
            this.lstSystemNames.Name = "lstSystemNames";
            this.lstSystemNames.Size = new System.Drawing.Size(252, 197);
            this.lstSystemNames.TabIndex = 19;
            this.lstSystemNames.UseCompatibleStateImageBehavior = false;
            this.lstSystemNames.View = System.Windows.Forms.View.Details;
            // 
            // SectorLister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 468);
            this.Controls.Add(this.chkIsolate);
            this.Controls.Add(this.lblSectorName);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.chkAppend);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.updnStart);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtSectorName);
            this.Controls.Add(this.btnOutputDir);
            this.Controls.Add(this.updnEnd);
            this.Controls.Add(this.txtOutputDir);
            this.Controls.Add(this.grpIsolate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SectorLister";
            this.Text = "Sector Lister 1v3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnEnd)).EndInit();
            this.grpIsolate.ResumeLayout(false);
            this.grpIsolate.PerformLayout();
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
    }
}

