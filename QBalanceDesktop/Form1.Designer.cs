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
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNavBudget = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMonth = new System.Windows.Forms.Panel();
            this.lblMonthTitle = new System.Windows.Forms.Label();
            this.btnPrevMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnMigrate = new System.Windows.Forms.Button();
            this.btnIncrementMonth = new System.Windows.Forms.Button();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.gbMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMonth.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(868, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbMain
            // 
            this.gbMain.BackColor = System.Drawing.SystemColors.WindowText;
            this.gbMain.Controls.Add(this.button4);
            this.gbMain.Controls.Add(this.button3);
            this.gbMain.Controls.Add(this.button2);
            this.gbMain.Controls.Add(this.button1);
            this.gbMain.Controls.Add(this.btnNavBudget);
            this.gbMain.Controls.Add(this.panel1);
            this.gbMain.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbMain.Location = new System.Drawing.Point(155, 80);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(860, 289);
            this.gbMain.TabIndex = 1;
            this.gbMain.TabStop = false;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button4.Location = new System.Drawing.Point(3, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 32);
            this.button4.TabIndex = 2;
            this.button4.Text = "הגדרות";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button3.Location = new System.Drawing.Point(3, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "דוחות";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2.Location = new System.Drawing.Point(3, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "הכנסות";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button1.Location = new System.Drawing.Point(3, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "קטגוריות";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNavBudget
            // 
            this.btnNavBudget.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBudget.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavBudget.Location = new System.Drawing.Point(3, 16);
            this.btnNavBudget.Name = "btnNavBudget";
            this.btnNavBudget.Size = new System.Drawing.Size(101, 32);
            this.btnNavBudget.TabIndex = 2;
            this.btnNavBudget.Text = "תקציב";
            this.btnNavBudget.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(104, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 270);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(753, 270);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlMonth
            // 
            this.pnlMonth.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMonth.Controls.Add(this.lblMonthTitle);
            this.pnlMonth.Controls.Add(this.btnPrevMonth);
            this.pnlMonth.Controls.Add(this.btnNextMonth);
            this.pnlMonth.Location = new System.Drawing.Point(351, 34);
            this.pnlMonth.Name = "pnlMonth";
            this.pnlMonth.Size = new System.Drawing.Size(398, 32);
            this.pnlMonth.TabIndex = 2;
            // 
            // lblMonthTitle
            // 
            this.lblMonthTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonthTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblMonthTitle.Location = new System.Drawing.Point(64, 0);
            this.lblMonthTitle.Name = "lblMonthTitle";
            this.lblMonthTitle.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblMonthTitle.Size = new System.Drawing.Size(270, 32);
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
            //this.btnPrevMonth.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevMonth.Image")));
            this.btnPrevMonth.Location = new System.Drawing.Point(334, 0);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Size = new System.Drawing.Size(64, 32);
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
            //this.btnNextMonth.Image = ((System.Drawing.Image)(resources.GetObject("btnNextMonth.Image")));
            this.btnNextMonth.Location = new System.Drawing.Point(0, 0);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(64, 32);
            this.btnNextMonth.TabIndex = 0;
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnSync
            // 
            this.btnSync.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSync.Enabled = false;
            this.btnSync.Location = new System.Drawing.Point(3, 336);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(125, 20);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            // 
            // btnScan
            // 
            this.btnScan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnScan.Enabled = false;
            this.btnScan.Location = new System.Drawing.Point(3, 316);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(125, 20);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // btnMigrate
            // 
            this.btnMigrate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMigrate.Enabled = false;
            this.btnMigrate.Location = new System.Drawing.Point(3, 296);
            this.btnMigrate.Name = "btnMigrate";
            this.btnMigrate.Size = new System.Drawing.Size(125, 20);
            this.btnMigrate.TabIndex = 0;
            this.btnMigrate.Text = "Migrate";
            this.btnMigrate.UseVisualStyleBackColor = true;
            // 
            // btnIncrementMonth
            // 
            this.btnIncrementMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncrementMonth.FlatAppearance.BorderSize = 0;
            this.btnIncrementMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncrementMonth.Location = new System.Drawing.Point(3, 16);
            this.btnIncrementMonth.Name = "btnIncrementMonth";
            this.btnIncrementMonth.Size = new System.Drawing.Size(125, 20);
            this.btnIncrementMonth.TabIndex = 0;
            this.btnIncrementMonth.Text = "Increment";
            this.btnIncrementMonth.UseVisualStyleBackColor = true;
            this.btnIncrementMonth.Click += new System.EventHandler(this.btnIncrementMonth_Click);
            // 
            // gbActions
            // 
            this.gbActions.BackColor = System.Drawing.Color.Goldenrod;
            this.gbActions.Controls.Add(this.btnIncrementMonth);
            this.gbActions.Controls.Add(this.btnMigrate);
            this.gbActions.Controls.Add(this.btnScan);
            this.gbActions.Controls.Add(this.btnSync);
            this.gbActions.Location = new System.Drawing.Point(10, 10);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(131, 359);
            this.gbActions.TabIndex = 1;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 409);
            this.Controls.Add(this.pnlMonth);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.btnExit);
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.Resize += new System.EventHandler(this.BaseForm_Resize);
            this.gbMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlMonth.ResumeLayout(false);
            this.gbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Panel pnlMonth;
        private System.Windows.Forms.Label lblMonthTitle;
        private System.Windows.Forms.Button btnPrevMonth;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNavBudget;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnMigrate;
        private System.Windows.Forms.Button btnIncrementMonth;
        private System.Windows.Forms.GroupBox gbActions;
    }
}

