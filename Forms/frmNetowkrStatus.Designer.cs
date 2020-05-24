namespace WifiAutoConnector
{
    partial class frmNetowkrStatus
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.connected = new System.Windows.Forms.Label();
            this.secured = new System.Windows.Forms.Label();
            this.signalstrength = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.prgss = new System.Windows.Forms.ProgressBar();
            this.domainr = new System.Windows.Forms.Label();
            this.usernamer = new System.Windows.Forms.Label();
            this.passwordr = new System.Windows.Forms.Label();
            this.domain = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prgss);
            this.groupBox1.Controls.Add(this.connected);
            this.groupBox1.Controls.Add(this.secured);
            this.groupBox1.Controls.Add(this.signalstrength);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Access Point Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.domain);
            this.groupBox2.Controls.Add(this.username);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.domainr);
            this.groupBox2.Controls.Add(this.usernamer);
            this.groupBox2.Controls.Add(this.passwordr);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Security";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Signal Stregnth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Secured";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Connected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Domain";
            // 
            // connected
            // 
            this.connected.AutoSize = true;
            this.connected.Location = new System.Drawing.Point(126, 55);
            this.connected.Name = "connected";
            this.connected.Size = new System.Drawing.Size(59, 13);
            this.connected.TabIndex = 7;
            this.connected.Text = "Connected";
            // 
            // secured
            // 
            this.secured.AutoSize = true;
            this.secured.Location = new System.Drawing.Point(126, 42);
            this.secured.Name = "secured";
            this.secured.Size = new System.Drawing.Size(47, 13);
            this.secured.TabIndex = 6;
            this.secured.Text = "Secured";
            // 
            // signalstrength
            // 
            this.signalstrength.AutoSize = true;
            this.signalstrength.Location = new System.Drawing.Point(126, 29);
            this.signalstrength.Name = "signalstrength";
            this.signalstrength.Size = new System.Drawing.Size(79, 13);
            this.signalstrength.TabIndex = 5;
            this.signalstrength.Text = "Signal Strength";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(126, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 4;
            this.name.Text = "Name";
            // 
            // prgss
            // 
            this.prgss.Location = new System.Drawing.Point(220, 29);
            this.prgss.Name = "prgss";
            this.prgss.Size = new System.Drawing.Size(118, 13);
            this.prgss.TabIndex = 8;
            // 
            // domainr
            // 
            this.domainr.AutoSize = true;
            this.domainr.Location = new System.Drawing.Point(126, 42);
            this.domainr.Name = "domainr";
            this.domainr.Size = new System.Drawing.Size(43, 13);
            this.domainr.TabIndex = 9;
            this.domainr.Text = "Domain";
            // 
            // usernamer
            // 
            this.usernamer.AutoSize = true;
            this.usernamer.Location = new System.Drawing.Point(126, 29);
            this.usernamer.Name = "usernamer";
            this.usernamer.Size = new System.Drawing.Size(55, 13);
            this.usernamer.TabIndex = 8;
            this.usernamer.Text = "Username";
            // 
            // passwordr
            // 
            this.passwordr.AutoSize = true;
            this.passwordr.Location = new System.Drawing.Point(126, 16);
            this.passwordr.Name = "passwordr";
            this.passwordr.Size = new System.Drawing.Size(53, 13);
            this.passwordr.TabIndex = 7;
            this.passwordr.Text = "Password";
            // 
            // domain
            // 
            this.domain.AutoSize = true;
            this.domain.Location = new System.Drawing.Point(217, 42);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(43, 13);
            this.domain.TabIndex = 12;
            this.domain.Text = "Domain";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(217, 29);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(55, 13);
            this.username.TabIndex = 11;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(217, 16);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 10;
            this.password.Text = "Password";
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(149, 64);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(183, 23);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // frmNetowkrStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 175);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNetowkrStatus";
            this.Text = "frmNetowkrStatus";
            this.Load += new System.EventHandler(this.frmNetowkrStatus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prgss;
        private System.Windows.Forms.Label connected;
        private System.Windows.Forms.Label secured;
        private System.Windows.Forms.Label signalstrength;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label domain;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label domainr;
        private System.Windows.Forms.Label usernamer;
        private System.Windows.Forms.Label passwordr;
        private System.Windows.Forms.Button btnConnect;
    }
}