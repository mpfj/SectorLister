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
            ((System.ComponentModel.ISupportInitialize)(this.updnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSectorName
            // 
            this.lblSectorName.AutoSize = true;
            this.lblSectorName.Location = new System.Drawing.Point(27, 15);
            this.lblSectorName.Name = "lblSectorName";
            this.lblSectorName.Size = new System.Drawing.Size(69, 13);
            this.lblSectorName.TabIndex = 0;
            this.lblSectorName.Text = "Sector Name";
            this.lblSectorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSectorName
            // 
            this.txtSectorName.Location = new System.Drawing.Point(102, 12);
            this.txtSectorName.Name = "txtSectorName";
            this.txtSectorName.Size = new System.Drawing.Size(174, 20);
            this.txtSectorName.TabIndex = 1;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(67, 40);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Start";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // updnStart
            // 
            this.updnStart.Location = new System.Drawing.Point(102, 38);
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
            this.updnEnd.Location = new System.Drawing.Point(102, 64);
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
            this.lblEnd.Location = new System.Drawing.Point(70, 66);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(26, 13);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "End";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Location = new System.Drawing.Point(102, 90);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(140, 20);
            this.txtOutputDir.TabIndex = 7;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 116);
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
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Output Directory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOutputDir
            // 
            this.btnOutputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputDir.Location = new System.Drawing.Point(248, 89);
            this.btnOutputDir.Name = "btnOutputDir";
            this.btnOutputDir.Size = new System.Drawing.Size(28, 20);
            this.btnOutputDir.TabIndex = 10;
            this.btnOutputDir.Text = "...";
            this.btnOutputDir.UseVisualStyleBackColor = true;
            this.btnOutputDir.Click += new System.EventHandler(this.btnOutputDir_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 169);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(264, 10);
            this.progressBar.TabIndex = 11;
            // 
            // SectorLister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 188);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnOutputDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtOutputDir);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.updnEnd);
            this.Controls.Add(this.updnStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtSectorName);
            this.Controls.Add(this.lblSectorName);
            this.Name = "SectorLister";
            this.Text = "Sector Lister 1v0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updnEnd)).EndInit();
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
    }
}

