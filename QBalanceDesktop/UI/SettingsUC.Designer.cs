namespace QBalanceDesktop.UI
{
    partial class SettingsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txNewCategoryBudget = new System.Windows.Forms.TextBox();
            this.btnGenNewCategory = new System.Windows.Forms.Button();
            this.chkAllMonths = new System.Windows.Forms.CheckBox();
            this.cmbNewCategoryGroup = new System.Windows.Forms.ComboBox();
            this.txNewCategoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateMonth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkUnBudgetCats = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnSaveSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSettings.Image")));
            this.btnSaveSettings.Location = new System.Drawing.Point(626, 0);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(111, 38);
            this.btnSaveSettings.TabIndex = 0;
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(29, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 346);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Controls.Add(this.txNewCategoryBudget);
            this.panel5.Controls.Add(this.btnGenNewCategory);
            this.panel5.Controls.Add(this.chkAllMonths);
            this.panel5.Controls.Add(this.cmbNewCategoryGroup);
            this.panel5.Controls.Add(this.txNewCategoryName);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(19, 155);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(651, 105);
            this.panel5.TabIndex = 6;
            // 
            // txNewCategoryBudget
            // 
            this.txNewCategoryBudget.Location = new System.Drawing.Point(162, 59);
            this.txNewCategoryBudget.Name = "txNewCategoryBudget";
            this.txNewCategoryBudget.Size = new System.Drawing.Size(200, 23);
            this.txNewCategoryBudget.TabIndex = 5;
            // 
            // btnGenNewCategory
            // 
            this.btnGenNewCategory.FlatAppearance.BorderSize = 0;
            this.btnGenNewCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGenNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenNewCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnGenNewCategory.Image")));
            this.btnGenNewCategory.Location = new System.Drawing.Point(435, 61);
            this.btnGenNewCategory.Name = "btnGenNewCategory";
            this.btnGenNewCategory.Size = new System.Drawing.Size(109, 23);
            this.btnGenNewCategory.TabIndex = 8;
            this.btnGenNewCategory.UseVisualStyleBackColor = true;
            this.btnGenNewCategory.Click += new System.EventHandler(this.btnGenNewCategory_Click);
            // 
            // chkAllMonths
            // 
            this.chkAllMonths.AutoSize = true;
            this.chkAllMonths.Checked = true;
            this.chkAllMonths.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllMonths.Location = new System.Drawing.Point(18, 61);
            this.chkAllMonths.Name = "chkAllMonths";
            this.chkAllMonths.Size = new System.Drawing.Size(133, 19);
            this.chkAllMonths.TabIndex = 7;
            this.chkAllMonths.Text = "Apply To All Months";
            this.chkAllMonths.UseVisualStyleBackColor = true;
            // 
            // cmbNewCategoryGroup
            // 
            this.cmbNewCategoryGroup.FormattingEnabled = true;
            this.cmbNewCategoryGroup.Location = new System.Drawing.Point(388, 17);
            this.cmbNewCategoryGroup.Name = "cmbNewCategoryGroup";
            this.cmbNewCategoryGroup.Size = new System.Drawing.Size(189, 23);
            this.cmbNewCategoryGroup.TabIndex = 6;
            // 
            // txNewCategoryName
            // 
            this.txNewCategoryName.Location = new System.Drawing.Point(162, 14);
            this.txNewCategoryName.Name = "txNewCategoryName";
            this.txNewCategoryName.Size = new System.Drawing.Size(200, 23);
            this.txNewCategoryName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Generate Category";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dtPicker);
            this.panel4.Controls.Add(this.btnGenerateMonth);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(19, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(651, 50);
            this.panel4.TabIndex = 5;
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(161, 13);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(200, 23);
            this.dtPicker.TabIndex = 2;
            // 
            // btnGenerateMonth
            // 
            this.btnGenerateMonth.FlatAppearance.BorderSize = 0;
            this.btnGenerateMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGenerateMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateMonth.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateMonth.Image")));
            this.btnGenerateMonth.Location = new System.Drawing.Point(434, 15);
            this.btnGenerateMonth.Name = "btnGenerateMonth";
            this.btnGenerateMonth.Size = new System.Drawing.Size(109, 23);
            this.btnGenerateMonth.TabIndex = 3;
            this.btnGenerateMonth.UseVisualStyleBackColor = true;
            this.btnGenerateMonth.Click += new System.EventHandler(this.btnGenerateMonth_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Generate Month";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.chkUnBudgetCats);
            this.panel3.Location = new System.Drawing.Point(19, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 44);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show UnBudget Categories";
            // 
            // chkUnBudgetCats
            // 
            this.chkUnBudgetCats.AutoSize = true;
            this.chkUnBudgetCats.Location = new System.Drawing.Point(200, 19);
            this.chkUnBudgetCats.Name = "chkUnBudgetCats";
            this.chkUnBudgetCats.Size = new System.Drawing.Size(15, 14);
            this.chkUnBudgetCats.TabIndex = 1;
            this.chkUnBudgetCats.UseVisualStyleBackColor = true;
            // 
            // SettingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SettingsUC";
            this.Size = new System.Drawing.Size(737, 429);
            this.Load += new System.EventHandler(this.SettingsUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkUnBudgetCats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateMonth;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnGenNewCategory;
        private System.Windows.Forms.CheckBox chkAllMonths;
        private System.Windows.Forms.ComboBox cmbNewCategoryGroup;
        private System.Windows.Forms.TextBox txNewCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txNewCategoryBudget;
    }
}
