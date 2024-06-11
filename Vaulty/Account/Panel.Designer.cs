namespace Vaulty.Account
{
    partial class Panel
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
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbUserIdentities);
            this.Name = "Panel";
            this.Text = "Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbUserIdentities;
    }
}