namespace QBalanceDesktop.UI
{
    partial class CategoryEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryEdit));
            this.lblName = new System.Windows.Forms.Label();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkUpdateAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(250, 49);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbGroups
            // 
            this.cmbGroups.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmbGroups.DisplayMember = "Key";
            this.cmbGroups.DropDownHeight = 120;
            this.cmbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGroups.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbGroups.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.IntegralHeight = false;
            this.cmbGroups.Location = new System.Drawing.Point(423, 13);
            this.cmbGroups.MaxDropDownItems = 20;
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(211, 25);
            this.cmbGroups.TabIndex = 1;
            this.cmbGroups.ValueMember = "Key";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(662, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 49);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chkUpdateAll
            // 
            this.chkUpdateAll.AutoSize = true;
            this.chkUpdateAll.Location = new System.Drawing.Point(257, 13);
            this.chkUpdateAll.Name = "chkUpdateAll";
            this.chkUpdateAll.Size = new System.Drawing.Size(48, 19);
            this.chkUpdateAll.TabIndex = 3;
            this.chkUpdateAll.Text = "All ?";
            this.chkUpdateAll.UseVisualStyleBackColor = true;
            // 
            // CategoryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.chkUpdateAll);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.lblName);
            this.Name = "CategoryEdit";
            this.Size = new System.Drawing.Size(737, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkUpdateAll;
    }
}
