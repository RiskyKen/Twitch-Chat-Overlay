namespace twitch_chat_overlay
{
    partial class SettingsForm
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
            this.txtMessageTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkTimeStamps = new System.Windows.Forms.CheckBox();
            this.numLineLimit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAutoChatChannel = new System.Windows.Forms.CheckBox();
            this.txtChatChannel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkEnableChatSound = new System.Windows.Forms.CheckBox();
            this.btnBrowseChatSound = new System.Windows.Forms.Button();
            this.txtChatSoundLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLineLimit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtMessageTime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chkTimeStamps);
            this.groupBox1.Controls.Add(this.numLineLimit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtFileLocation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat File";
            // 
            // txtMessageTime
            // 
            this.txtMessageTime.Location = new System.Drawing.Point(9, 140);
            this.txtMessageTime.Name = "txtMessageTime";
            this.txtMessageTime.Size = new System.Drawing.Size(100, 20);
            this.txtMessageTime.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Max Time Per Message (ms): -1 for infinite";
            // 
            // chkTimeStamps
            // 
            this.chkTimeStamps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTimeStamps.AutoSize = true;
            this.chkTimeStamps.Location = new System.Drawing.Point(255, 91);
            this.chkTimeStamps.Name = "chkTimeStamps";
            this.chkTimeStamps.Size = new System.Drawing.Size(93, 17);
            this.chkTimeStamps.TabIndex = 5;
            this.chkTimeStamps.Text = "Time Stamps?";
            this.chkTimeStamps.UseVisualStyleBackColor = true;
            // 
            // numLineLimit
            // 
            this.numLineLimit.Location = new System.Drawing.Point(9, 90);
            this.numLineLimit.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numLineLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLineLimit.Name = "numLineLimit";
            this.numLineLimit.Size = new System.Drawing.Size(75, 20);
            this.numLineLimit.TabIndex = 4;
            this.numLineLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chat File Line Limit:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(348, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileLocation.Location = new System.Drawing.Point(9, 42);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.Size = new System.Drawing.Size(333, 20);
            this.txtFileLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output File location:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkAutoChatChannel);
            this.groupBox2.Controls.Add(this.txtChatChannel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Controls.Add(this.txtHost);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Irc Server";
            // 
            // chkAutoChatChannel
            // 
            this.chkAutoChatChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoChatChannel.AutoSize = true;
            this.chkAutoChatChannel.Location = new System.Drawing.Point(227, 95);
            this.chkAutoChatChannel.Name = "chkAutoChatChannel";
            this.chkAutoChatChannel.Size = new System.Drawing.Size(121, 17);
            this.chkAutoChatChannel.TabIndex = 4;
            this.chkAutoChatChannel.Text = "Auto Chat Channel?";
            this.chkAutoChatChannel.UseVisualStyleBackColor = true;
            this.chkAutoChatChannel.CheckedChanged += new System.EventHandler(this.chkAutoChatChannel_CheckedChanged);
            // 
            // txtChatChannel
            // 
            this.txtChatChannel.Location = new System.Drawing.Point(9, 93);
            this.txtChatChannel.Name = "txtChatChannel";
            this.txtChatChannel.Size = new System.Drawing.Size(100, 20);
            this.txtChatChannel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chat Channel:";
            // 
            // txtPort
            // 
            this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPort.Location = new System.Drawing.Point(348, 41);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(75, 20);
            this.txtPort.TabIndex = 1;
            // 
            // txtHost
            // 
            this.txtHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHost.Location = new System.Drawing.Point(9, 41);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(333, 20);
            this.txtHost.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Host:";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(285, 445);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(366, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkEnableChatSound);
            this.groupBox3.Controls.Add(this.btnBrowseChatSound);
            this.groupBox3.Controls.Add(this.txtChatSoundLocation);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 112);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chat Notify";
            // 
            // chkEnableChatSound
            // 
            this.chkEnableChatSound.AutoSize = true;
            this.chkEnableChatSound.Location = new System.Drawing.Point(9, 76);
            this.chkEnableChatSound.Name = "chkEnableChatSound";
            this.chkEnableChatSound.Size = new System.Drawing.Size(124, 17);
            this.chkEnableChatSound.TabIndex = 3;
            this.chkEnableChatSound.Text = "Enable Chat Sound?";
            this.chkEnableChatSound.UseVisualStyleBackColor = true;
            // 
            // btnBrowseChatSound
            // 
            this.btnBrowseChatSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseChatSound.Location = new System.Drawing.Point(348, 39);
            this.btnBrowseChatSound.Name = "btnBrowseChatSound";
            this.btnBrowseChatSound.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseChatSound.TabIndex = 2;
            this.btnBrowseChatSound.Text = "Browse...";
            this.btnBrowseChatSound.UseVisualStyleBackColor = true;
            this.btnBrowseChatSound.Click += new System.EventHandler(this.btnBrowseChatSound_Click);
            // 
            // txtChatSoundLocation
            // 
            this.txtChatSoundLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChatSoundLocation.Location = new System.Drawing.Point(9, 41);
            this.txtChatSoundLocation.Name = "txtChatSoundLocation";
            this.txtChatSoundLocation.Size = new System.Drawing.Size(333, 20);
            this.txtChatSoundLocation.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sound Location:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 480);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Twitch Chat Overlay - Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLineLimit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTimeStamps;
        private System.Windows.Forms.NumericUpDown numLineLimit;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAutoChatChannel;
        private System.Windows.Forms.TextBox txtChatChannel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkEnableChatSound;
        private System.Windows.Forms.Button btnBrowseChatSound;
        private System.Windows.Forms.TextBox txtChatSoundLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMessageTime;
        private System.Windows.Forms.Label label7;
    }
}