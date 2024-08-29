
namespace DBConfigTool
{
    partial class Form1
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblhostip = new System.Windows.Forms.Label();
            this.lblport = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lalpath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btntestconnection = new System.Windows.Forms.Button();
            this.btnGenerateConfig = new System.Windows.Forms.Button();
            this.btnReadConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(141, 35);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(196, 23);
            this.txtIP.TabIndex = 0;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(141, 64);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(196, 23);
            this.txtPort.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(141, 93);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(196, 23);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(141, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(196, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // lblhostip
            // 
            this.lblhostip.AutoSize = true;
            this.lblhostip.Location = new System.Drawing.Point(82, 38);
            this.lblhostip.Name = "lblhostip";
            this.lblhostip.Size = new System.Drawing.Size(53, 15);
            this.lblhostip.TabIndex = 4;
            this.lblhostip.Text = "HOST IP:";
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Location = new System.Drawing.Point(97, 67);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(38, 15);
            this.lblport.TabIndex = 5;
            this.lblport.Text = "PORT:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(64, 96);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(71, 15);
            this.lblusername.TabIndex = 6;
            this.lblusername.Text = "USERNAME:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(64, 125);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(71, 15);
            this.lblpassword.TabIndex = 7;
            this.lblpassword.Text = "PASSWORD:";
            // 
            // lalpath
            // 
            this.lalpath.AutoSize = true;
            this.lalpath.Location = new System.Drawing.Point(97, 154);
            this.lalpath.Name = "lalpath";
            this.lalpath.Size = new System.Drawing.Size(38, 15);
            this.lalpath.TabIndex = 8;
            this.lalpath.Text = "PATH:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(141, 151);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(196, 23);
            this.txtPath.TabIndex = 9;
            // 
            // btntestconnection
            // 
            this.btntestconnection.Location = new System.Drawing.Point(53, 200);
            this.btntestconnection.Name = "btntestconnection";
            this.btntestconnection.Size = new System.Drawing.Size(119, 23);
            this.btntestconnection.TabIndex = 10;
            this.btntestconnection.Text = "Test Connection";
            this.btntestconnection.UseVisualStyleBackColor = true;
            this.btntestconnection.Click += new System.EventHandler(this.btntestconnection_Click);
            // 
            // btnGenerateConfig
            // 
            this.btnGenerateConfig.Location = new System.Drawing.Point(178, 200);
            this.btnGenerateConfig.Name = "btnGenerateConfig";
            this.btnGenerateConfig.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateConfig.TabIndex = 11;
            this.btnGenerateConfig.Text = "Get Config";
            this.btnGenerateConfig.UseVisualStyleBackColor = true;
            this.btnGenerateConfig.Click += new System.EventHandler(this.btnGenerateConfig_Click);
            // 
            // btnReadConfig
            // 
            this.btnReadConfig.Location = new System.Drawing.Point(262, 200);
            this.btnReadConfig.Name = "btnReadConfig";
            this.btnReadConfig.Size = new System.Drawing.Size(109, 23);
            this.btnReadConfig.TabIndex = 12;
            this.btnReadConfig.Text = "Read Config";
            this.btnReadConfig.UseVisualStyleBackColor = true;
            this.btnReadConfig.Click += new System.EventHandler(this.btnReadConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 267);
            this.Controls.Add(this.btnReadConfig);
            this.Controls.Add(this.btnGenerateConfig);
            this.Controls.Add(this.btntestconnection);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lalpath);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblport);
            this.Controls.Add(this.lblhostip);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Name = "Form1";
            this.Text = "DBSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblhostip;
        private System.Windows.Forms.Label lblport;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lalpath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btntestconnection;
        private System.Windows.Forms.Button btnGenerateConfig;
        private System.Windows.Forms.Button btnReadConfig;
    }
}

