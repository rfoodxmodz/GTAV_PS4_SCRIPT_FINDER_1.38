namespace GTAV_PS4_SCRIPT_FINDER
{
    partial class Form1
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
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ip = new System.Windows.Forms.Label();
            this.textIp = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dumpScript = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.scr_name = new System.Windows.Forms.TextBox();
            this.scriptCheck = new System.Windows.Forms.Button();
            this._s_codesize = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._r_codesize = new System.Windows.Forms.Label();
            this._r_staticcount = new System.Windows.Forms.Label();
            this._s_staticcount = new System.Windows.Forms.Label();
            this._r_globalscount = new System.Windows.Forms.Label();
            this._s_globalscount = new System.Windows.Forms.Label();
            this._r_nativescount = new System.Windows.Forms.Label();
            this._s_nativescount = new System.Windows.Forms.Label();
            this._r_scrAddr = new System.Windows.Forms.Label();
            this._s_scrAddr = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(107, 20);
            this.toolStripStatusLabel2.Text = "Not connected";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(626, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 20);
            this.toolStripStatusLabel1.Text = "Connection:";
            // 
            // ip
            // 
            this.ip.AutoSize = true;
            this.ip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ip.Location = new System.Drawing.Point(28, 28);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(50, 17);
            this.ip.TabIndex = 2;
            this.ip.Text = "PS4 IP";
            // 
            // textIp
            // 
            this.textIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIp.Location = new System.Drawing.Point(88, 23);
            this.textIp.Multiline = true;
            this.textIp.Name = "textIp";
            this.textIp.Size = new System.Drawing.Size(186, 27);
            this.textIp.TabIndex = 1;
            this.textIp.Tag = "PS4 IP";
            this.textIp.Text = "192.168.1.";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(15, 54);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(156, 26);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "connect And attach";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ip);
            this.groupBox2.Controls.Add(this.textIp);
            this.groupBox2.Controls.Add(this.connectBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 90);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 380);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(15, 21);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(542, 353);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.dumpScript);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.scriptCheck);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(534, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Script Finder";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dumpScript
            // 
            this.dumpScript.Location = new System.Drawing.Point(141, 115);
            this.dumpScript.Name = "dumpScript";
            this.dumpScript.Size = new System.Drawing.Size(96, 31);
            this.dumpScript.TabIndex = 6;
            this.dumpScript.Text = "dump";
            this.dumpScript.UseVisualStyleBackColor = true;
            this.dumpScript.Click += new System.EventHandler(this.dumpScript_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.scr_name);
            this.groupBox4.Location = new System.Drawing.Point(33, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(478, 71);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "enter script name (without .osc)";
            // 
            // scr_name
            // 
            this.scr_name.Location = new System.Drawing.Point(20, 30);
            this.scr_name.Multiline = true;
            this.scr_name.Name = "scr_name";
            this.scr_name.Size = new System.Drawing.Size(266, 26);
            this.scr_name.TabIndex = 0;
            this.scr_name.Text = "ingamehud";
            // 
            // scriptCheck
            // 
            this.scriptCheck.Location = new System.Drawing.Point(39, 115);
            this.scriptCheck.Name = "scriptCheck";
            this.scriptCheck.Size = new System.Drawing.Size(96, 31);
            this.scriptCheck.TabIndex = 4;
            this.scriptCheck.Text = "find/check";
            this.scriptCheck.UseVisualStyleBackColor = true;
            this.scriptCheck.Click += new System.EventHandler(this.scriptCheck_Click);
            // 
            // _s_codesize
            // 
            this._s_codesize.AutoSize = true;
            this._s_codesize.Location = new System.Drawing.Point(18, 32);
            this._s_codesize.Name = "_s_codesize";
            this._s_codesize.Size = new System.Drawing.Size(72, 17);
            this._s_codesize.TabIndex = 7;
            this._s_codesize.Text = "CodeSize:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._r_scrAddr);
            this.groupBox3.Controls.Add(this._s_scrAddr);
            this.groupBox3.Controls.Add(this._r_nativescount);
            this.groupBox3.Controls.Add(this._s_nativescount);
            this.groupBox3.Controls.Add(this._r_globalscount);
            this.groupBox3.Controls.Add(this._s_globalscount);
            this.groupBox3.Controls.Add(this._r_staticcount);
            this.groupBox3.Controls.Add(this._s_staticcount);
            this.groupBox3.Controls.Add(this._r_codesize);
            this.groupBox3.Controls.Add(this._s_codesize);
            this.groupBox3.Location = new System.Drawing.Point(33, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 122);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Script Info:";
            // 
            // _r_codesize
            // 
            this._r_codesize.AutoSize = true;
            this._r_codesize.Location = new System.Drawing.Point(96, 32);
            this._r_codesize.Name = "_r_codesize";
            this._r_codesize.Size = new System.Drawing.Size(31, 17);
            this._r_codesize.TabIndex = 8;
            this._r_codesize.Text = "N/A";
            // 
            // _r_staticcount
            // 
            this._r_staticcount.AutoSize = true;
            this._r_staticcount.Location = new System.Drawing.Point(351, 61);
            this._r_staticcount.Name = "_r_staticcount";
            this._r_staticcount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._r_staticcount.Size = new System.Drawing.Size(31, 17);
            this._r_staticcount.TabIndex = 12;
            this._r_staticcount.Text = "N/A";
            // 
            // _s_staticcount
            // 
            this._s_staticcount.AutoSize = true;
            this._s_staticcount.Location = new System.Drawing.Point(257, 61);
            this._s_staticcount.Name = "_s_staticcount";
            this._s_staticcount.Size = new System.Drawing.Size(88, 17);
            this._s_staticcount.TabIndex = 11;
            this._s_staticcount.Text = "Static Count:";
            // 
            // _r_globalscount
            // 
            this._r_globalscount.AutoSize = true;
            this._r_globalscount.Location = new System.Drawing.Point(122, 61);
            this._r_globalscount.Name = "_r_globalscount";
            this._r_globalscount.Size = new System.Drawing.Size(31, 17);
            this._r_globalscount.TabIndex = 14;
            this._r_globalscount.Text = "N/A";
            // 
            // _s_globalscount
            // 
            this._s_globalscount.AutoSize = true;
            this._s_globalscount.Location = new System.Drawing.Point(18, 61);
            this._s_globalscount.Name = "_s_globalscount";
            this._s_globalscount.Size = new System.Drawing.Size(101, 17);
            this._s_globalscount.TabIndex = 13;
            this._s_globalscount.Text = "Globals Count:";
            // 
            // _r_nativescount
            // 
            this._r_nativescount.AutoSize = true;
            this._r_nativescount.Location = new System.Drawing.Point(363, 32);
            this._r_nativescount.Name = "_r_nativescount";
            this._r_nativescount.Size = new System.Drawing.Size(31, 17);
            this._r_nativescount.TabIndex = 16;
            this._r_nativescount.Text = "N/A";
            // 
            // _s_nativescount
            // 
            this._s_nativescount.AutoSize = true;
            this._s_nativescount.Location = new System.Drawing.Point(257, 32);
            this._s_nativescount.Name = "_s_nativescount";
            this._s_nativescount.Size = new System.Drawing.Size(100, 17);
            this._s_nativescount.TabIndex = 15;
            this._s_nativescount.Text = "Natives Count:";
            // 
            // _r_scrAddr
            // 
            this._r_scrAddr.AutoSize = true;
            this._r_scrAddr.Location = new System.Drawing.Point(128, 90);
            this._r_scrAddr.Name = "_r_scrAddr";
            this._r_scrAddr.Size = new System.Drawing.Size(31, 17);
            this._r_scrAddr.TabIndex = 18;
            this._r_scrAddr.Text = "N/A";
            // 
            // _s_scrAddr
            // 
            this._s_scrAddr.AutoSize = true;
            this._s_scrAddr.Location = new System.Drawing.Point(18, 90);
            this._s_scrAddr.Name = "_s_scrAddr";
            this._s_scrAddr.Size = new System.Drawing.Size(104, 17);
            this._s_scrAddr.TabIndex = 17;
            this._s_scrAddr.Text = "Script Address:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 518);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "GTA V PS4 Sctipt Finder v1.38 by rfoodxmodz";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label ip;
        private System.Windows.Forms.TextBox textIp;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button dumpScript;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox scr_name;
        private System.Windows.Forms.Button scriptCheck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label _r_nativescount;
        private System.Windows.Forms.Label _s_nativescount;
        private System.Windows.Forms.Label _r_globalscount;
        private System.Windows.Forms.Label _s_globalscount;
        private System.Windows.Forms.Label _r_staticcount;
        private System.Windows.Forms.Label _s_staticcount;
        private System.Windows.Forms.Label _r_codesize;
        private System.Windows.Forms.Label _s_codesize;
        private System.Windows.Forms.Label _r_scrAddr;
        private System.Windows.Forms.Label _s_scrAddr;
    }
}

