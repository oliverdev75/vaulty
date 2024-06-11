namespace Vaulty.Account
{
    partial class IdentitiesPanel
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
            this.lbUserIdentities = new System.Windows.Forms.ListBox();
            this.btnCreateIdentity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUserIdentities
            // 
            this.lbUserIdentities.DataSource = this.lbUserIdentities.CustomTabOffsets;
            this.lbUserIdentities.FormattingEnabled = true;
            this.lbUserIdentities.Location = new System.Drawing.Point(175, 19);
            this.lbUserIdentities.Name = "lbUserIdentities";
            this.lbUserIdentities.Size = new System.Drawing.Size(387, 407);
            this.lbUserIdentities.TabIndex = 0;
            // 
            // btnCreateIdentity
            // 
            this.btnCreateIdentity.Location = new System.Drawing.Point(598, 19);
            this.btnCreateIdentity.Name = "btnCreateIdentity";
            this.btnCreateIdentity.Size = new System.Drawing.Size(115, 43);
            this.btnCreateIdentity.TabIndex = 1;
            this.btnCreateIdentity.Text = "Create identity";
            this.btnCreateIdentity.UseVisualStyleBackColor = true;
            this.btnCreateIdentity.Click += new System.EventHandler(this.btnCreateIdentity_Click);
            // 
            // IdentitiesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.btnCreateIdentity);
            this.Controls.Add(this.lbUserIdentities);
            this.Name = "IdentitiesPanel";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbUserIdentities;
        private System.Windows.Forms.Button btnCreateIdentity;
    }
}