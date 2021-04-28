namespace QBalanceDesktop.UI
{
    partial class CategoryDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryDisplay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIndex = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblStatusAmount = new System.Windows.Forms.Label();
            this.txAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lblIndex);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 49);
            this.panel1.TabIndex = 0;
            // 
            // lblIndex
            // 
            this.lblIndex.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIndex.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblIndex.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblIndex.Location = new System.Drawing.Point(0, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(40, 49);
            this.lblIndex.TabIndex = 0;
            this.lblIndex.Text = "label1";
            this.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(40, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 2);
            this.panel2.TabIndex = 0;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCategoryName.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategoryName.Location = new System.Drawing.Point(40, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(221, 47);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "label1";
            this.lblCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusAmount
            // 
            this.lblStatusAmount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatusAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusAmount.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblStatusAmount.Location = new System.Drawing.Point(261, 0);
            this.lblStatusAmount.Name = "lblStatusAmount";
            this.lblStatusAmount.Size = new System.Drawing.Size(130, 47);
            this.lblStatusAmount.TabIndex = 1;
            this.lblStatusAmount.Text = "label2";
            this.lblStatusAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txAmount
            // 
            this.txAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txAmount.Location = new System.Drawing.Point(416, 10);
            this.txAmount.Name = "txAmount";
            this.txAmount.Size = new System.Drawing.Size(181, 20);
            this.txAmount.TabIndex = 2;
            this.txAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(627, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 47);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CategoryDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txAmount);
            this.Controls.Add(this.lblStatusAmount);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CategoryDisplay";
            this.Size = new System.Drawing.Size(737, 49);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblStatusAmount;
        private System.Windows.Forms.TextBox txAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblIndex;
    }
}
