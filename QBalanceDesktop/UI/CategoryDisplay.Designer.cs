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
            this.pnlIndex = new System.Windows.Forms.Panel();
            this.lblIndex = new System.Windows.Forms.Label();
            this.pnlDelemeter = new System.Windows.Forms.Panel();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblStatusAmount = new System.Windows.Forms.Label();
            this.txAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlIndex.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIndex
            // 
            this.pnlIndex.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlIndex.Controls.Add(this.lblIndex);
            this.pnlIndex.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIndex.Location = new System.Drawing.Point(0, 0);
            this.pnlIndex.Name = "pnlIndex";
            this.pnlIndex.Size = new System.Drawing.Size(40, 49);
            this.pnlIndex.TabIndex = 0;
            // 
            // lblIndex
            // 
            this.lblIndex.BackColor = System.Drawing.SystemColors.Desktop;
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
            // pnlDelemeter
            // 
            this.pnlDelemeter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlDelemeter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDelemeter.Location = new System.Drawing.Point(40, 47);
            this.pnlDelemeter.Name = "pnlDelemeter";
            this.pnlDelemeter.Size = new System.Drawing.Size(697, 2);
            this.pnlDelemeter.TabIndex = 0;
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
            this.lblStatusAmount.ForeColor = System.Drawing.Color.AliceBlue;
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
            this.txAmount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txAmount.Location = new System.Drawing.Point(421, 10);
            this.txAmount.Name = "txAmount";
            this.txAmount.Size = new System.Drawing.Size(176, 27);
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
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txAmount);
            this.Controls.Add(this.lblStatusAmount);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.pnlDelemeter);
            this.Controls.Add(this.pnlIndex);
            this.Name = "CategoryDisplay";
            this.Size = new System.Drawing.Size(737, 49);
            this.pnlIndex.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlIndex;
        private System.Windows.Forms.Panel pnlDelemeter;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblStatusAmount;
        private System.Windows.Forms.TextBox txAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblIndex;
    }
}
