namespace QBalanceDesktop
{
    partial class BaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnIncrementMonth = new System.Windows.Forms.Button();
            this.btnMigrate = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.pnlMonth = new System.Windows.Forms.Panel();
            this.lblMonthTitle = new System.Windows.Forms.Label();
            this.btnPrevMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.gbActions.SuspendLayout();
            this.pnlMonth.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1013, 432);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbActions
            // 
            this.gbActions.BackColor = System.Drawing.Color.Goldenrod;
            this.gbActions.Controls.Add(this.btnIncrementMonth);
            this.gbActions.Controls.Add(this.btnMigrate);
            this.gbActions.Controls.Add(this.btnScan);
            this.gbActions.Controls.Add(this.btnSync);
            this.gbActions.Location = new System.Drawing.Point(12, 12);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(153, 414);
            this.gbActions.TabIndex = 1;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // btnIncrementMonth
            // 
            this.btnIncrementMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncrementMonth.FlatAppearance.BorderSize = 0;
            this.btnIncrementMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncrementMonth.Location = new System.Drawing.Point(3, 19);
            this.btnIncrementMonth.Name = "btnIncrementMonth";
            this.btnIncrementMonth.Size = new System.Drawing.Size(147, 23);
            this.btnIncrementMonth.TabIndex = 0;
            this.btnIncrementMonth.Text = "Increment";
            this.btnIncrementMonth.UseVisualStyleBackColor = true;
            this.btnIncrementMonth.Click += new System.EventHandler(this.btnIncrementMonth_Click);
            // 
            // btnMigrate
            // 
            this.btnMigrate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMigrate.Enabled = false;
            this.btnMigrate.Location = new System.Drawing.Point(3, 342);
            this.btnMigrate.Name = "btnMigrate";
            this.btnMigrate.Size = new System.Drawing.Size(147, 23);
            this.btnMigrate.TabIndex = 0;
            this.btnMigrate.Text = "Migrate";
            this.btnMigrate.UseVisualStyleBackColor = true;
            // 
            // btnScan
            // 
            this.btnScan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnScan.Enabled = false;
            this.btnScan.Location = new System.Drawing.Point(3, 365);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(147, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // btnSync
            // 
            this.btnSync.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSync.Enabled = false;
            this.btnSync.Location = new System.Drawing.Point(3, 388);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(147, 23);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            // 
            // gbMain
            // 
            this.gbMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbMain.Location = new System.Drawing.Point(181, 92);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(1003, 334);
            this.gbMain.TabIndex = 1;
            this.gbMain.TabStop = false;
            // 
            // pnlMonth
            // 
            this.pnlMonth.BackColor = System.Drawing.Color.Tomato;
            this.pnlMonth.Controls.Add(this.lblMonthTitle);
            this.pnlMonth.Controls.Add(this.btnPrevMonth);
            this.pnlMonth.Controls.Add(this.btnNextMonth);
            this.pnlMonth.Location = new System.Drawing.Point(409, 39);
            this.pnlMonth.Name = "pnlMonth";
            this.pnlMonth.Size = new System.Drawing.Size(464, 37);
            this.pnlMonth.TabIndex = 2;
            // 
            // lblMonthTitle
            // 
            this.lblMonthTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthTitle.AutoSize = true;
            this.lblMonthTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonthTitle.Location = new System.Drawing.Point(241, 8);
            this.lblMonthTitle.Name = "lblMonthTitle";
            this.lblMonthTitle.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblMonthTitle.Size = new System.Drawing.Size(69, 25);
            this.lblMonthTitle.TabIndex = 1;
            this.lblMonthTitle.Text = "label1";
            this.lblMonthTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrevMonth.FlatAppearance.BorderSize = 0;
            this.btnPrevMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevMonth.ForeColor = System.Drawing.Color.Crimson;
            this.btnPrevMonth.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevMonth.Image")));
            this.btnPrevMonth.Location = new System.Drawing.Point(389, 0);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Size = new System.Drawing.Size(75, 37);
            this.btnPrevMonth.TabIndex = 0;
            this.btnPrevMonth.UseVisualStyleBackColor = true;
            this.btnPrevMonth.Click += new System.EventHandler(this.btnPrevMonth_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNextMonth.FlatAppearance.BorderSize = 0;
            this.btnNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextMonth.ForeColor = System.Drawing.Color.Crimson;
            this.btnNextMonth.Image = ((System.Drawing.Image)(resources.GetObject("btnNextMonth.Image")));
            this.btnNextMonth.Location = new System.Drawing.Point(0, 0);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(75, 37);
            this.btnNextMonth.TabIndex = 0;
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 472);
            this.Controls.Add(this.pnlMonth);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.btnExit);
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.Resize += new System.EventHandler(this.BaseForm_Resize);
            this.gbActions.ResumeLayout(false);
            this.pnlMonth.ResumeLayout(false);
            this.pnlMonth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnMigrate;
        private System.Windows.Forms.Panel pnlMonth;
        private System.Windows.Forms.Label lblMonthTitle;
        private System.Windows.Forms.Button btnPrevMonth;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnIncrementMonth;
    }
}

