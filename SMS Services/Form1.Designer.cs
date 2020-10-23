namespace SMS_Services
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartServerBtn = new System.Windows.Forms.Button();
            this.StopServerBtn = new System.Windows.Forms.Button();
            this.alarmTxtBox = new System.Windows.Forms.TextBox();
            this.localIPTxtBox = new System.Windows.Forms.TextBox();
            this.newAlarmBtn = new System.Windows.Forms.Button();
            this.AlarmListDGW = new System.Windows.Forms.DataGridView();
            this.CheckChanges = new System.Windows.Forms.Timer(this.components);
            this.deleteAlarmBtn = new System.Windows.Forms.Button();
            this.editAlarm = new System.Windows.Forms.Button();
            this.alarmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editGroupBtn = new System.Windows.Forms.Button();
            this.deleteGroupBtn = new System.Windows.Forms.Button();
            this.newGroupBtn = new System.Windows.Forms.Button();
            this.GroupListDGW = new System.Windows.Forms.DataGridView();
            this.PersonsGDW = new System.Windows.Forms.DataGridView();
            this.editPersonbtn = new System.Windows.Forms.Button();
            this.deletePersonbtn = new System.Windows.Forms.Button();
            this.newPersonbtn = new System.Windows.Forms.Button();
            this.Backup = new System.Windows.Forms.Button();
            this.RestoreBtn = new System.Windows.Forms.Button();
            this.clientBox = new System.Windows.Forms.TextBox();
            this.clientDiag = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmListDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupListDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonsGDW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartServerBtn
            // 
            this.StartServerBtn.BackColor = System.Drawing.Color.LightGray;
            this.StartServerBtn.Location = new System.Drawing.Point(12, 33);
            this.StartServerBtn.Name = "StartServerBtn";
            this.StartServerBtn.Size = new System.Drawing.Size(101, 41);
            this.StartServerBtn.TabIndex = 0;
            this.StartServerBtn.Text = "Start Server";
            this.StartServerBtn.UseVisualStyleBackColor = false;
            this.StartServerBtn.Click += new System.EventHandler(this.StartServerBtn_Click);
            // 
            // StopServerBtn
            // 
            this.StopServerBtn.BackColor = System.Drawing.Color.LightGray;
            this.StopServerBtn.Location = new System.Drawing.Point(210, 33);
            this.StopServerBtn.Name = "StopServerBtn";
            this.StopServerBtn.Size = new System.Drawing.Size(101, 41);
            this.StopServerBtn.TabIndex = 1;
            this.StopServerBtn.Text = "Stop Server";
            this.StopServerBtn.UseVisualStyleBackColor = false;
            this.StopServerBtn.Click += new System.EventHandler(this.StopServerBtn_Click);
            // 
            // alarmTxtBox
            // 
            this.alarmTxtBox.Location = new System.Drawing.Point(12, 106);
            this.alarmTxtBox.Multiline = true;
            this.alarmTxtBox.Name = "alarmTxtBox";
            this.alarmTxtBox.Size = new System.Drawing.Size(299, 65);
            this.alarmTxtBox.TabIndex = 2;
            // 
            // localIPTxtBox
            // 
            this.localIPTxtBox.Location = new System.Drawing.Point(12, 80);
            this.localIPTxtBox.Name = "localIPTxtBox";
            this.localIPTxtBox.Size = new System.Drawing.Size(299, 20);
            this.localIPTxtBox.TabIndex = 3;
            // 
            // newAlarmBtn
            // 
            this.newAlarmBtn.Location = new System.Drawing.Point(328, 426);
            this.newAlarmBtn.Name = "newAlarmBtn";
            this.newAlarmBtn.Size = new System.Drawing.Size(130, 23);
            this.newAlarmBtn.TabIndex = 6;
            this.newAlarmBtn.Text = "New Alarm";
            this.newAlarmBtn.UseVisualStyleBackColor = true;
            this.newAlarmBtn.Click += new System.EventHandler(this.newAlarmBtn_Click);
            // 
            // AlarmListDGW
            // 
            this.AlarmListDGW.AllowUserToAddRows = false;
            this.AlarmListDGW.AllowUserToDeleteRows = false;
            this.AlarmListDGW.AllowUserToOrderColumns = true;
            this.AlarmListDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlarmListDGW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlarmListDGW.Location = new System.Drawing.Point(328, 106);
            this.AlarmListDGW.MultiSelect = false;
            this.AlarmListDGW.Name = "AlarmListDGW";
            this.AlarmListDGW.ReadOnly = true;
            this.AlarmListDGW.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AlarmListDGW.Size = new System.Drawing.Size(453, 314);
            this.AlarmListDGW.TabIndex = 8;
            // 
            // CheckChanges
            // 
            this.CheckChanges.Enabled = true;
            this.CheckChanges.Tick += new System.EventHandler(this.CheckChanges_Tick);
            // 
            // deleteAlarmBtn
            // 
            this.deleteAlarmBtn.Location = new System.Drawing.Point(490, 426);
            this.deleteAlarmBtn.Name = "deleteAlarmBtn";
            this.deleteAlarmBtn.Size = new System.Drawing.Size(130, 23);
            this.deleteAlarmBtn.TabIndex = 9;
            this.deleteAlarmBtn.Text = "Delete Alarm";
            this.deleteAlarmBtn.UseVisualStyleBackColor = true;
            this.deleteAlarmBtn.Click += new System.EventHandler(this.deleteAlarmBtn_Click);
            // 
            // editAlarm
            // 
            this.editAlarm.Location = new System.Drawing.Point(651, 426);
            this.editAlarm.Name = "editAlarm";
            this.editAlarm.Size = new System.Drawing.Size(130, 23);
            this.editAlarm.TabIndex = 10;
            this.editAlarm.Text = "Edit Alarm";
            this.editAlarm.UseVisualStyleBackColor = true;
            this.editAlarm.Click += new System.EventHandler(this.editAlarm_Click);
            // 
            // editGroupBtn
            // 
            this.editGroupBtn.Location = new System.Drawing.Point(1110, 426);
            this.editGroupBtn.Name = "editGroupBtn";
            this.editGroupBtn.Size = new System.Drawing.Size(130, 23);
            this.editGroupBtn.TabIndex = 13;
            this.editGroupBtn.Text = "Edit Group";
            this.editGroupBtn.UseVisualStyleBackColor = true;
            this.editGroupBtn.Click += new System.EventHandler(this.editGroupBtn_Click);
            // 
            // deleteGroupBtn
            // 
            this.deleteGroupBtn.Location = new System.Drawing.Point(949, 426);
            this.deleteGroupBtn.Name = "deleteGroupBtn";
            this.deleteGroupBtn.Size = new System.Drawing.Size(130, 23);
            this.deleteGroupBtn.TabIndex = 12;
            this.deleteGroupBtn.Text = "Delete Group";
            this.deleteGroupBtn.UseVisualStyleBackColor = true;
            this.deleteGroupBtn.Click += new System.EventHandler(this.deleteGroupBtn_Click);
            // 
            // newGroupBtn
            // 
            this.newGroupBtn.Location = new System.Drawing.Point(787, 426);
            this.newGroupBtn.Name = "newGroupBtn";
            this.newGroupBtn.Size = new System.Drawing.Size(130, 23);
            this.newGroupBtn.TabIndex = 11;
            this.newGroupBtn.Text = "New Group";
            this.newGroupBtn.UseVisualStyleBackColor = true;
            this.newGroupBtn.Click += new System.EventHandler(this.newGroupBtn_Click);
            // 
            // GroupListDGW
            // 
            this.GroupListDGW.AllowUserToAddRows = false;
            this.GroupListDGW.AllowUserToDeleteRows = false;
            this.GroupListDGW.AllowUserToOrderColumns = true;
            this.GroupListDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupListDGW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GroupListDGW.Location = new System.Drawing.Point(787, 106);
            this.GroupListDGW.MultiSelect = false;
            this.GroupListDGW.Name = "GroupListDGW";
            this.GroupListDGW.ReadOnly = true;
            this.GroupListDGW.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GroupListDGW.Size = new System.Drawing.Size(453, 314);
            this.GroupListDGW.TabIndex = 14;
            // 
            // PersonsGDW
            // 
            this.PersonsGDW.AllowUserToAddRows = false;
            this.PersonsGDW.AllowUserToDeleteRows = false;
            this.PersonsGDW.AllowUserToOrderColumns = true;
            this.PersonsGDW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonsGDW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PersonsGDW.Location = new System.Drawing.Point(1246, 106);
            this.PersonsGDW.MultiSelect = false;
            this.PersonsGDW.Name = "PersonsGDW";
            this.PersonsGDW.ReadOnly = true;
            this.PersonsGDW.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PersonsGDW.Size = new System.Drawing.Size(453, 314);
            this.PersonsGDW.TabIndex = 18;
            // 
            // editPersonbtn
            // 
            this.editPersonbtn.Location = new System.Drawing.Point(1569, 426);
            this.editPersonbtn.Name = "editPersonbtn";
            this.editPersonbtn.Size = new System.Drawing.Size(130, 23);
            this.editPersonbtn.TabIndex = 17;
            this.editPersonbtn.Text = "Edit Person";
            this.editPersonbtn.UseVisualStyleBackColor = true;
            this.editPersonbtn.Click += new System.EventHandler(this.editPersonbtn_Click);
            // 
            // deletePersonbtn
            // 
            this.deletePersonbtn.Location = new System.Drawing.Point(1408, 426);
            this.deletePersonbtn.Name = "deletePersonbtn";
            this.deletePersonbtn.Size = new System.Drawing.Size(130, 23);
            this.deletePersonbtn.TabIndex = 16;
            this.deletePersonbtn.Text = "Delete Person";
            this.deletePersonbtn.UseVisualStyleBackColor = true;
            this.deletePersonbtn.Click += new System.EventHandler(this.deletePersonbtn_Click);
            // 
            // newPersonbtn
            // 
            this.newPersonbtn.Location = new System.Drawing.Point(1246, 426);
            this.newPersonbtn.Name = "newPersonbtn";
            this.newPersonbtn.Size = new System.Drawing.Size(130, 23);
            this.newPersonbtn.TabIndex = 15;
            this.newPersonbtn.Text = "New Person";
            this.newPersonbtn.UseVisualStyleBackColor = true;
            this.newPersonbtn.Click += new System.EventHandler(this.newPersonbtn_Click);
            // 
            // Backup
            // 
            this.Backup.Location = new System.Drawing.Point(12, 530);
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(130, 23);
            this.Backup.TabIndex = 19;
            this.Backup.Text = "Backup";
            this.Backup.UseVisualStyleBackColor = true;
            this.Backup.Click += new System.EventHandler(this.Backup_Click);
            // 
            // RestoreBtn
            // 
            this.RestoreBtn.Location = new System.Drawing.Point(12, 559);
            this.RestoreBtn.Name = "RestoreBtn";
            this.RestoreBtn.Size = new System.Drawing.Size(130, 23);
            this.RestoreBtn.TabIndex = 20;
            this.RestoreBtn.Text = "Restore";
            this.RestoreBtn.UseVisualStyleBackColor = true;
            this.RestoreBtn.Click += new System.EventHandler(this.RestoreBtn_Click);
            // 
            // clientBox
            // 
            this.clientBox.Location = new System.Drawing.Point(12, 329);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(299, 20);
            this.clientBox.TabIndex = 22;
            // 
            // clientDiag
            // 
            this.clientDiag.Location = new System.Drawing.Point(12, 355);
            this.clientDiag.Multiline = true;
            this.clientDiag.Name = "clientDiag";
            this.clientDiag.Size = new System.Drawing.Size(299, 65);
            this.clientDiag.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 468);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(449, 468);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 114);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(13, 426);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 25;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(119, 426);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Send SMS To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1551, 726);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.clientDiag);
            this.Controls.Add(this.RestoreBtn);
            this.Controls.Add(this.Backup);
            this.Controls.Add(this.PersonsGDW);
            this.Controls.Add(this.editPersonbtn);
            this.Controls.Add(this.deletePersonbtn);
            this.Controls.Add(this.newPersonbtn);
            this.Controls.Add(this.GroupListDGW);
            this.Controls.Add(this.editGroupBtn);
            this.Controls.Add(this.deleteGroupBtn);
            this.Controls.Add(this.newGroupBtn);
            this.Controls.Add(this.editAlarm);
            this.Controls.Add(this.deleteAlarmBtn);
            this.Controls.Add(this.AlarmListDGW);
            this.Controls.Add(this.newAlarmBtn);
            this.Controls.Add(this.localIPTxtBox);
            this.Controls.Add(this.alarmTxtBox);
            this.Controls.Add(this.StopServerBtn);
            this.Controls.Add(this.StartServerBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AlarmToSMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlarmListDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupListDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonsGDW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartServerBtn;
        private System.Windows.Forms.Button StopServerBtn;
        private System.Windows.Forms.TextBox alarmTxtBox;
        private System.Windows.Forms.TextBox localIPTxtBox;
        private System.Windows.Forms.Button newAlarmBtn;
        private System.Windows.Forms.BindingSource alarmBindingSource;
 
        private System.Windows.Forms.BindingSource alarmListBindingSource;
        public System.Windows.Forms.DataGridView AlarmListDGW;
        private System.Windows.Forms.Timer CheckChanges;
        private System.Windows.Forms.Button deleteAlarmBtn;
        private System.Windows.Forms.Button editAlarm;
        private System.Windows.Forms.Button editGroupBtn;
        private System.Windows.Forms.Button deleteGroupBtn;
        private System.Windows.Forms.Button newGroupBtn;
        public System.Windows.Forms.DataGridView GroupListDGW;
        public System.Windows.Forms.DataGridView PersonsGDW;
        private System.Windows.Forms.Button editPersonbtn;
        private System.Windows.Forms.Button deletePersonbtn;
        private System.Windows.Forms.Button newPersonbtn;
        private System.Windows.Forms.Button Backup;
        private System.Windows.Forms.Button RestoreBtn;
        private System.Windows.Forms.TextBox clientBox;
        private System.Windows.Forms.TextBox clientDiag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

