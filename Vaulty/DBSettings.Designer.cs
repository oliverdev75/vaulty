namespace Vaulty
{
    partial class DBSettings
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
            this.txtHostField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsernameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPortField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordField = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDBField = new System.Windows.Forms.TextBox();
            this.lblTestResult = new System.Windows.Forms.Label();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHostField
            // 
            this.txtHostField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtHostField.Location = new System.Drawing.Point(24, 43);
            this.txtHostField.Name = "txtHostField";
            this.txtHostField.Size = new System.Drawing.Size(213, 28);
            this.txtHostField.TabIndex = 0;
            this.txtHostField.Tag = "hostField";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(178, 464);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(113, 33);
            this.btnSaveConfig.TabIndex = 2;
            this.btnSaveConfig.Text = "Save";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(20, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // txtUsernameField
            // 
            this.txtUsernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtUsernameField.Location = new System.Drawing.Point(24, 170);
            this.txtUsernameField.Name = "txtUsernameField";
            this.txtUsernameField.Size = new System.Drawing.Size(213, 28);
            this.txtUsernameField.TabIndex = 3;
            this.txtUsernameField.Tag = "usernameField";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Port";
            // 
            // txtPortField
            // 
            this.txtPortField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPortField.Location = new System.Drawing.Point(24, 103);
            this.txtPortField.Name = "txtPortField";
            this.txtPortField.Size = new System.Drawing.Size(213, 28);
            this.txtPortField.TabIndex = 5;
            this.txtPortField.Tag = "portField";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(20, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // txtPasswordField
            // 
            this.txtPasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPasswordField.Location = new System.Drawing.Point(24, 231);
            this.txtPasswordField.Name = "txtPasswordField";
            this.txtPasswordField.Size = new System.Drawing.Size(213, 28);
            this.txtPasswordField.TabIndex = 7;
            this.txtPasswordField.Tag = "passwordField";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 33);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(20, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Database name";
            // 
            // txtDBField
            // 
            this.txtDBField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDBField.Location = new System.Drawing.Point(24, 300);
            this.txtDBField.Name = "txtDBField";
            this.txtDBField.Size = new System.Drawing.Size(213, 28);
            this.txtDBField.TabIndex = 10;
            this.txtDBField.Tag = "dbField";
            // 
            // lblTestResult
            // 
            this.lblTestResult.AutoSize = true;
            this.lblTestResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTestResult.Location = new System.Drawing.Point(3, 0);
            this.lblTestResult.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblTestResult.Name = "lblTestResult";
            this.lblTestResult.Size = new System.Drawing.Size(0, 20);
            this.lblTestResult.TabIndex = 12;
            // 
            // btnTestConn
            // 
            this.btnTestConn.Location = new System.Drawing.Point(24, 345);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(113, 33);
            this.btnTestConn.TabIndex = 13;
            this.btnTestConn.Text = "Test";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.BtnTestConn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Restore defaults";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnRestoreDefaults_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblTestResult);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 395);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(1000, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(386, 45);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // DBSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 509);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTestConn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDBField);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPasswordField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPortField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsernameField);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHostField);
            this.Name = "DBSettings";
            this.Text = "Database settings";
            this.Load += new System.EventHandler(this.DBSettings_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHostField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsernameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPortField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPasswordField;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDBField;
        private System.Windows.Forms.Label lblTestResult;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}