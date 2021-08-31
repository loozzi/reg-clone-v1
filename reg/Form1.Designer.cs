namespace reg
{
    partial class mainGui
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainGui));
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_exportData = new System.Windows.Forms.Button();
            this.rtb_listAccount = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cb_randomPassword = new System.Windows.Forms.CheckBox();
            this.tb_passwordDefault = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rd_yes = new System.Windows.Forms.RadioButton();
            this.rd_no = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rd_none = new System.Windows.Forms.RadioButton();
            this.rd_warp = new System.Windows.Forms.RadioButton();
            this.rd_proxy = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtg_listProxy = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms_listProxy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.f_clipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.f_file = new System.Windows.Forms.ToolStripMenuItem();
            this.dlt_row = new System.Windows.Forms.ToolStripMenuItem();
            this.dlt_all = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_getListDevice = new System.Windows.Forms.Button();
            this.dtg_listDevice = new System.Windows.Forms.DataGridView();
            this.deviceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selected_device = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_reset = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listProxy)).BeginInit();
            this.cms_listProxy.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_start.Location = new System.Drawing.Point(697, 318);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(168, 128);
            this.btn_start.TabIndex = 10;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_exportData);
            this.groupBox7.Controls.Add(this.rtb_listAccount);
            this.groupBox7.Location = new System.Drawing.Point(203, 318);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(488, 189);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Danh Sách Tài Khoản";
            // 
            // btn_exportData
            // 
            this.btn_exportData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportData.ForeColor = System.Drawing.Color.Aqua;
            this.btn_exportData.Location = new System.Drawing.Point(457, 19);
            this.btn_exportData.Name = "btn_exportData";
            this.btn_exportData.Size = new System.Drawing.Size(25, 162);
            this.btn_exportData.TabIndex = 1;
            this.btn_exportData.Text = "EXPORT";
            this.btn_exportData.UseVisualStyleBackColor = true;
            this.btn_exportData.Click += new System.EventHandler(this.btn_exportData_Click);
            // 
            // rtb_listAccount
            // 
            this.rtb_listAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_listAccount.Location = new System.Drawing.Point(6, 19);
            this.rtb_listAccount.Name = "rtb_listAccount";
            this.rtb_listAccount.Size = new System.Drawing.Size(445, 162);
            this.rtb_listAccount.TabIndex = 0;
            this.rtb_listAccount.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(11, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 189);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CÀI ĐẶT";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cb_randomPassword);
            this.groupBox6.Controls.Add(this.tb_passwordDefault);
            this.groupBox6.Location = new System.Drawing.Point(8, 114);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(171, 67);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "MẬT KHẨU";
            // 
            // cb_randomPassword
            // 
            this.cb_randomPassword.AutoSize = true;
            this.cb_randomPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_randomPassword.Location = new System.Drawing.Point(7, 44);
            this.cb_randomPassword.Name = "cb_randomPassword";
            this.cb_randomPassword.Size = new System.Drawing.Size(66, 17);
            this.cb_randomPassword.TabIndex = 1;
            this.cb_randomPassword.Text = "Random";
            this.cb_randomPassword.UseVisualStyleBackColor = true;
            // 
            // tb_passwordDefault
            // 
            this.tb_passwordDefault.Location = new System.Drawing.Point(7, 20);
            this.tb_passwordDefault.Name = "tb_passwordDefault";
            this.tb_passwordDefault.Size = new System.Drawing.Size(158, 20);
            this.tb_passwordDefault.TabIndex = 0;
            this.tb_passwordDefault.Text = "nguyenquangthao";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rd_yes);
            this.groupBox5.Controls.Add(this.rd_no);
            this.groupBox5.Location = new System.Drawing.Point(94, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(85, 89);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Verify";
            // 
            // rd_yes
            // 
            this.rd_yes.AutoSize = true;
            this.rd_yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_yes.Location = new System.Drawing.Point(6, 55);
            this.rd_yes.Name = "rd_yes";
            this.rd_yes.Size = new System.Drawing.Size(38, 17);
            this.rd_yes.TabIndex = 1;
            this.rd_yes.TabStop = true;
            this.rd_yes.Text = "Có";
            this.rd_yes.UseVisualStyleBackColor = true;
            // 
            // rd_no
            // 
            this.rd_no.AutoSize = true;
            this.rd_no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_no.Location = new System.Drawing.Point(6, 32);
            this.rd_no.Name = "rd_no";
            this.rd_no.Size = new System.Drawing.Size(56, 17);
            this.rd_no.TabIndex = 0;
            this.rd_no.TabStop = true;
            this.rd_no.Text = "Không";
            this.rd_no.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rd_none);
            this.groupBox4.Controls.Add(this.rd_warp);
            this.groupBox4.Controls.Add(this.rd_proxy);
            this.groupBox4.Location = new System.Drawing.Point(8, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(80, 89);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mạng";
            // 
            // rd_none
            // 
            this.rd_none.AutoSize = true;
            this.rd_none.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_none.Location = new System.Drawing.Point(6, 65);
            this.rd_none.Name = "rd_none";
            this.rd_none.Size = new System.Drawing.Size(51, 17);
            this.rd_none.TabIndex = 2;
            this.rd_none.TabStop = true;
            this.rd_none.Text = "None";
            this.rd_none.UseVisualStyleBackColor = true;
            // 
            // rd_warp
            // 
            this.rd_warp.AutoSize = true;
            this.rd_warp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_warp.Location = new System.Drawing.Point(6, 42);
            this.rd_warp.Name = "rd_warp";
            this.rd_warp.Size = new System.Drawing.Size(51, 17);
            this.rd_warp.TabIndex = 1;
            this.rd_warp.TabStop = true;
            this.rd_warp.Text = "Warp";
            this.rd_warp.UseVisualStyleBackColor = true;
            // 
            // rd_proxy
            // 
            this.rd_proxy.AutoSize = true;
            this.rd_proxy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_proxy.Location = new System.Drawing.Point(6, 19);
            this.rd_proxy.Name = "rd_proxy";
            this.rd_proxy.Size = new System.Drawing.Size(51, 17);
            this.rd_proxy.TabIndex = 0;
            this.rd_proxy.TabStop = true;
            this.rd_proxy.Text = "Proxy";
            this.rd_proxy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtg_listProxy);
            this.groupBox2.Location = new System.Drawing.Point(203, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 300);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Proxy";
            // 
            // dtg_listProxy
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_listProxy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_listProxy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listProxy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.host,
            this.port,
            this.username,
            this.password,
            this.status});
            this.dtg_listProxy.ContextMenuStrip = this.cms_listProxy;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_listProxy.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_listProxy.Location = new System.Drawing.Point(6, 20);
            this.dtg_listProxy.Name = "dtg_listProxy";
            this.dtg_listProxy.RowHeadersVisible = false;
            this.dtg_listProxy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_listProxy.Size = new System.Drawing.Size(647, 274);
            this.dtg_listProxy.TabIndex = 0;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 50;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 50;
            // 
            // host
            // 
            this.host.HeaderText = "HOST";
            this.host.MinimumWidth = 125;
            this.host.Name = "host";
            this.host.Width = 125;
            // 
            // port
            // 
            this.port.HeaderText = "PORT";
            this.port.MinimumWidth = 75;
            this.port.Name = "port";
            this.port.Width = 75;
            // 
            // username
            // 
            this.username.HeaderText = "USERNAME";
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.HeaderText = "PASSWORD";
            this.password.Name = "password";
            // 
            // status
            // 
            this.status.HeaderText = "STATUS";
            this.status.MinimumWidth = 175;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 175;
            // 
            // cms_listProxy
            // 
            this.cms_listProxy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.f_clipboard,
            this.f_file,
            this.dlt_row,
            this.dlt_all});
            this.cms_listProxy.Name = "cms_listProxy";
            this.cms_listProxy.Size = new System.Drawing.Size(214, 92);
            this.cms_listProxy.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cms_listProxy_ItemClicked);
            // 
            // f_clipboard
            // 
            this.f_clipboard.Name = "f_clipboard";
            this.f_clipboard.Size = new System.Drawing.Size(213, 22);
            this.f_clipboard.Text = "Add Proxy from Clipboard";
            // 
            // f_file
            // 
            this.f_file.Name = "f_file";
            this.f_file.Size = new System.Drawing.Size(213, 22);
            this.f_file.Text = "Add Proxy from File";
            // 
            // dlt_row
            // 
            this.dlt_row.Name = "dlt_row";
            this.dlt_row.Size = new System.Drawing.Size(213, 22);
            this.dlt_row.Text = "Delete Row";
            // 
            // dlt_all
            // 
            this.dlt_all.Name = "dlt_all";
            this.dlt_all.Size = new System.Drawing.Size(213, 22);
            this.dlt_all.Text = "Delete All";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_getListDevice);
            this.groupBox1.Controls.Add(this.dtg_listDevice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 300);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List device";
            // 
            // btn_getListDevice
            // 
            this.btn_getListDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_getListDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getListDevice.ForeColor = System.Drawing.Color.Coral;
            this.btn_getListDevice.Location = new System.Drawing.Point(7, 259);
            this.btn_getListDevice.Name = "btn_getListDevice";
            this.btn_getListDevice.Size = new System.Drawing.Size(169, 35);
            this.btn_getListDevice.TabIndex = 1;
            this.btn_getListDevice.Text = "GET LIST DEVICE";
            this.btn_getListDevice.UseVisualStyleBackColor = true;
            this.btn_getListDevice.Click += new System.EventHandler(this.btn_getListDevice_Click);
            // 
            // dtg_listDevice
            // 
            this.dtg_listDevice.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_listDevice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_listDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deviceid,
            this.selected_device});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_listDevice.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_listDevice.Location = new System.Drawing.Point(7, 20);
            this.dtg_listDevice.Name = "dtg_listDevice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_listDevice.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_listDevice.RowHeadersVisible = false;
            this.dtg_listDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_listDevice.Size = new System.Drawing.Size(169, 232);
            this.dtg_listDevice.TabIndex = 0;
            // 
            // deviceid
            // 
            this.deviceid.HeaderText = "Device ID";
            this.deviceid.Name = "deviceid";
            this.deviceid.ReadOnly = true;
            // 
            // selected_device
            // 
            this.selected_device.HeaderText = "Sellect";
            this.selected_device.MinimumWidth = 50;
            this.selected_device.Name = "selected_device";
            this.selected_device.Width = 50;
            // 
            // btn_reset
            // 
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.Enabled = false;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_reset.Location = new System.Drawing.Point(697, 452);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(166, 55);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "SETTING";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // mainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 515);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(891, 538);
            this.Name = "mainGui";
            this.Text = "Auto Reg Clone Facebook Verify/Noveri | 1.1.2 - 23/7/2021 | Loozzi | Flames Team";
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listProxy)).EndInit();
            this.cms_listProxy.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listDevice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox rtb_listAccount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cb_randomPassword;
        private System.Windows.Forms.TextBox tb_passwordDefault;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rd_yes;
        private System.Windows.Forms.RadioButton rd_no;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rd_warp;
        private System.Windows.Forms.RadioButton rd_proxy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtg_listProxy;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn host;
        private System.Windows.Forms.DataGridViewTextBoxColumn port;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.ContextMenuStrip cms_listProxy;
        private System.Windows.Forms.ToolStripMenuItem f_clipboard;
        private System.Windows.Forms.ToolStripMenuItem f_file;
        private System.Windows.Forms.ToolStripMenuItem dlt_row;
        private System.Windows.Forms.ToolStripMenuItem dlt_all;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_getListDevice;
        private System.Windows.Forms.DataGridView dtg_listDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected_device;
        private System.Windows.Forms.Button btn_exportData;
        private System.Windows.Forms.RadioButton rd_none;
        private System.Windows.Forms.Button btn_reset;
    }
}

