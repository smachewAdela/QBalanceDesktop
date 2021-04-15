﻿namespace QBalanceDesktop
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMigrate = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCategoryTypes = new System.Windows.Forms.ComboBox();
            this.cmbLoans = new System.Windows.Forms.ComboBox();
            this.cmbAccounts = new System.Windows.Forms.ComboBox();
            this.cmbCategoryGroups = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1013, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMigrate);
            this.groupBox1.Controls.Add(this.btnScan);
            this.groupBox1.Controls.Add(this.btnSync);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // btnMigrate
            // 
            this.btnMigrate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMigrate.Location = new System.Drawing.Point(3, 27);
            this.btnMigrate.Name = "btnMigrate";
            this.btnMigrate.Size = new System.Drawing.Size(147, 23);
            this.btnMigrate.TabIndex = 0;
            this.btnMigrate.Text = "Migrate";
            this.btnMigrate.UseVisualStyleBackColor = true;
            this.btnMigrate.Click += new System.EventHandler(this.btnMigrate_Click);
            // 
            // btnScan
            // 
            this.btnScan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnScan.Location = new System.Drawing.Point(3, 50);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(147, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnSync
            // 
            this.btnSync.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSync.Location = new System.Drawing.Point(3, 73);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(147, 23);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(181, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1003, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cmbCategoryTypes
            // 
            this.cmbCategoryTypes.FormattingEnabled = true;
            this.cmbCategoryTypes.Location = new System.Drawing.Point(309, 25);
            this.cmbCategoryTypes.Name = "cmbCategoryTypes";
            this.cmbCategoryTypes.Size = new System.Drawing.Size(181, 23);
            this.cmbCategoryTypes.TabIndex = 2;
            // 
            // cmbLoans
            // 
            this.cmbLoans.FormattingEnabled = true;
            this.cmbLoans.Location = new System.Drawing.Point(918, 62);
            this.cmbLoans.Name = "cmbLoans";
            this.cmbLoans.Size = new System.Drawing.Size(181, 23);
            this.cmbLoans.TabIndex = 2;
            // 
            // cmbAccounts
            // 
            this.cmbAccounts.FormattingEnabled = true;
            this.cmbAccounts.Location = new System.Drawing.Point(918, 25);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Size = new System.Drawing.Size(181, 23);
            this.cmbAccounts.TabIndex = 2;
            // 
            // cmbCategoryGroups
            // 
            this.cmbCategoryGroups.FormattingEnabled = true;
            this.cmbCategoryGroups.Location = new System.Drawing.Point(309, 62);
            this.cmbCategoryGroups.Name = "cmbCategoryGroups";
            this.cmbCategoryGroups.Size = new System.Drawing.Size(181, 23);
            this.cmbCategoryGroups.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category Types";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(835, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Accounts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category Groups";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(835, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loans";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoryGroups);
            this.Controls.Add(this.cmbAccounts);
            this.Controls.Add(this.cmbLoans);
            this.Controls.Add(this.cmbCategoryTypes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnMigrate;
        private System.Windows.Forms.ComboBox cmbCategoryTypes;
        private System.Windows.Forms.ComboBox cmbLoans;
        private System.Windows.Forms.ComboBox cmbAccounts;
        private System.Windows.Forms.ComboBox cmbCategoryGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

