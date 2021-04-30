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
            this.btnScanFinanda = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnTrans = new System.Windows.Forms.Button();
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMonth.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1013, 432);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbMain
            // 
            this.gbMain.BackColor = System.Drawing.SystemColors.WindowText;
            this.gbMain.Controls.Add(this.btnScanFinanda);
            this.gbMain.Controls.Add(this.btnStatus);
            this.gbMain.Controls.Add(this.btnTrans);
            this.gbMain.Controls.Add(this.button4);
            this.gbMain.Controls.Add(this.button3);
            this.gbMain.Controls.Add(this.button2);
            this.gbMain.Controls.Add(this.button1);
            this.gbMain.Controls.Add(this.btnNavBudget);
            this.gbMain.Controls.Add(this.panel1);
            this.gbMain.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbMain.Location = new System.Drawing.Point(13, 92);
            this.gbMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbMain.Name = "gbMain";
            this.gbMain.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbMain.Size = new System.Drawing.Size(1171, 333);
            this.gbMain.TabIndex = 1;
            this.gbMain.TabStop = false;
            // 
            // btnScanFinanda
            // 
            this.btnScanFinanda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnScanFinanda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnScanFinanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanFinanda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScanFinanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnScanFinanda.Image = ((System.Drawing.Image)(resources.GetObject("btnScanFinanda.Image")));
            this.btnScanFinanda.Location = new System.Drawing.Point(4, 293);
            this.btnScanFinanda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnScanFinanda.Name = "btnScanFinanda";
            this.btnScanFinanda.Size = new System.Drawing.Size(68, 37);
            this.btnScanFinanda.TabIndex = 2;
            this.btnScanFinanda.UseVisualStyleBackColor = true;
            this.btnScanFinanda.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStatus.Location = new System.Drawing.Point(4, 241);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(68, 37);
            this.btnStatus.TabIndex = 2;
            this.btnStatus.Text = "סטטוס";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnTrans
            // 
            this.btnTrans.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrans.FlatAppearance.BorderSize = 0;
            this.btnTrans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrans.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTrans.Location = new System.Drawing.Point(4, 204);
            this.btnTrans.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(68, 37);
            this.btnTrans.TabIndex = 2;
            this.btnTrans.Text = "תנועות";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(4, 167);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 37);
            this.button4.TabIndex = 2;
            this.button4.Text = "הגדרות";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(4, 130);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "דוחות";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(4, 93);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "הכנסות";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(4, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "קטגוריות";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnNavBudget
            // 
            this.btnNavBudget.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavBudget.FlatAppearance.BorderSize = 0;
            this.btnNavBudget.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNavBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBudget.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavBudget.Location = new System.Drawing.Point(4, 19);
            this.btnNavBudget.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNavBudget.Name = "btnNavBudget";
            this.btnNavBudget.Size = new System.Drawing.Size(68, 37);
            this.btnNavBudget.TabIndex = 2;
            this.btnNavBudget.Text = "תקציב";
            this.btnNavBudget.UseVisualStyleBackColor = true;
            this.btnNavBudget.Click += new System.EventHandler(this.btnNavBudget_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(72, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 311);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(355, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(740, 311);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlMonth
            // 
            this.pnlMonth.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMonth.Controls.Add(this.lblMonthTitle);
            this.pnlMonth.Controls.Add(this.btnPrevMonth);
            this.pnlMonth.Controls.Add(this.btnNextMonth);
            this.pnlMonth.Location = new System.Drawing.Point(410, 39);
            this.pnlMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMonth.Name = "pnlMonth";
            this.pnlMonth.Size = new System.Drawing.Size(272, 37);
            this.pnlMonth.TabIndex = 2;
            // 
            // lblMonthTitle
            // 
            this.lblMonthTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonthTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonthTitle.Location = new System.Drawing.Point(75, 0);
            this.lblMonthTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthTitle.Name = "lblMonthTitle";
            this.lblMonthTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthTitle.Size = new System.Drawing.Size(122, 37);
            this.lblMonthTitle.TabIndex = 1;
            this.lblMonthTitle.Text = "label1";
            this.lblMonthTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrevMonth.FlatAppearance.BorderSize = 0;
            this.btnPrevMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrevMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevMonth.ForeColor = System.Drawing.Color.Crimson;
            this.btnPrevMonth.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevMonth.Image")));
            this.btnPrevMonth.Location = new System.Drawing.Point(197, 0);
            this.btnPrevMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.btnNextMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextMonth.ForeColor = System.Drawing.Color.Crimson;
            this.btnNextMonth.Image = ((System.Drawing.Image)(resources.GetObject("btnNextMonth.Image")));
            this.btnNextMonth.Location = new System.Drawing.Point(0, 0);
            this.btnNextMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(75, 37);
            this.btnNextMonth.TabIndex = 0;
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(916, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 472);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMonth);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.Resize += new System.EventHandler(this.BaseForm_Resize);
            this.gbMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlMonth.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnScanFinanda;
    }
}

