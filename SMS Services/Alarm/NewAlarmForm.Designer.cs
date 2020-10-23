namespace SMS_Services
{
    partial class NewAlarmForm
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
            this.createNewAlarmBtn = new System.Windows.Forms.Button();
            this.cancelNewAlarmBtn = new System.Windows.Forms.Button();
            this.newAlarmIdLbl = new System.Windows.Forms.Label();
            this.newAlarmTextLabel = new System.Windows.Forms.Label();
            this.NewAlarmGroup = new System.Windows.Forms.Label();
            this.newAlarmIDtxt = new System.Windows.Forms.TextBox();
            this.newAlarmTextTxt = new System.Windows.Forms.TextBox();
            this.newAlarmDefTextTxt = new System.Windows.Forms.TextBox();
            this.newAlarmDefTextLabel = new System.Windows.Forms.Label();
            this.groupCmbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // createNewAlarmBtn
            // 
            this.createNewAlarmBtn.Location = new System.Drawing.Point(15, 134);
            this.createNewAlarmBtn.Name = "createNewAlarmBtn";
            this.createNewAlarmBtn.Size = new System.Drawing.Size(109, 30);
            this.createNewAlarmBtn.TabIndex = 5;
            this.createNewAlarmBtn.Text = "Ok";
            this.createNewAlarmBtn.UseVisualStyleBackColor = true;
            this.createNewAlarmBtn.Click += new System.EventHandler(this.createNewAlarmBtn_Click);
            // 
            // cancelNewAlarmBtn
            // 
            this.cancelNewAlarmBtn.Location = new System.Drawing.Point(190, 134);
            this.cancelNewAlarmBtn.Name = "cancelNewAlarmBtn";
            this.cancelNewAlarmBtn.Size = new System.Drawing.Size(109, 30);
            this.cancelNewAlarmBtn.TabIndex = 6;
            this.cancelNewAlarmBtn.Text = "Cancel";
            this.cancelNewAlarmBtn.UseVisualStyleBackColor = true;
            this.cancelNewAlarmBtn.Click += new System.EventHandler(this.cancelNewAlarmBtn_Click);
            // 
            // newAlarmIdLbl
            // 
            this.newAlarmIdLbl.AutoSize = true;
            this.newAlarmIdLbl.Location = new System.Drawing.Point(12, 29);
            this.newAlarmIdLbl.Name = "newAlarmIdLbl";
            this.newAlarmIdLbl.Size = new System.Drawing.Size(21, 13);
            this.newAlarmIdLbl.TabIndex = 2;
            this.newAlarmIdLbl.Text = "ID:";
            // 
            // newAlarmTextLabel
            // 
            this.newAlarmTextLabel.AutoSize = true;
            this.newAlarmTextLabel.Location = new System.Drawing.Point(12, 81);
            this.newAlarmTextLabel.Name = "newAlarmTextLabel";
            this.newAlarmTextLabel.Size = new System.Drawing.Size(31, 13);
            this.newAlarmTextLabel.TabIndex = 3;
            this.newAlarmTextLabel.Text = "Text:";
            // 
            // NewAlarmGroup
            // 
            this.NewAlarmGroup.AutoSize = true;
            this.NewAlarmGroup.Location = new System.Drawing.Point(11, 107);
            this.NewAlarmGroup.Name = "NewAlarmGroup";
            this.NewAlarmGroup.Size = new System.Drawing.Size(39, 13);
            this.NewAlarmGroup.TabIndex = 4;
            this.NewAlarmGroup.Text = "Group:";
            // 
            // newAlarmIDtxt
            // 
            this.newAlarmIDtxt.Location = new System.Drawing.Point(58, 26);
            this.newAlarmIDtxt.Name = "newAlarmIDtxt";
            this.newAlarmIDtxt.Size = new System.Drawing.Size(241, 20);
            this.newAlarmIDtxt.TabIndex = 1;
            // 
            // newAlarmTextTxt
            // 
            this.newAlarmTextTxt.Location = new System.Drawing.Point(58, 78);
            this.newAlarmTextTxt.Name = "newAlarmTextTxt";
            this.newAlarmTextTxt.Size = new System.Drawing.Size(241, 20);
            this.newAlarmTextTxt.TabIndex = 3;
            // 
            // newAlarmDefTextTxt
            // 
            this.newAlarmDefTextTxt.Location = new System.Drawing.Point(58, 52);
            this.newAlarmDefTextTxt.Name = "newAlarmDefTextTxt";
            this.newAlarmDefTextTxt.Size = new System.Drawing.Size(241, 20);
            this.newAlarmDefTextTxt.TabIndex = 2;
            // 
            // newAlarmDefTextLabel
            // 
            this.newAlarmDefTextLabel.AutoSize = true;
            this.newAlarmDefTextLabel.Location = new System.Drawing.Point(12, 55);
            this.newAlarmDefTextLabel.Name = "newAlarmDefTextLabel";
            this.newAlarmDefTextLabel.Size = new System.Drawing.Size(38, 13);
            this.newAlarmDefTextLabel.TabIndex = 8;
            this.newAlarmDefTextLabel.Text = "Name:";
            // 
            // groupCmbox
            // 
            this.groupCmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupCmbox.FormattingEnabled = true;
            this.groupCmbox.Location = new System.Drawing.Point(58, 104);
            this.groupCmbox.Name = "groupCmbox";
            this.groupCmbox.Size = new System.Drawing.Size(121, 21);
            this.groupCmbox.TabIndex = 4;
            // 
            // NewAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 173);
            this.Controls.Add(this.groupCmbox);
            this.Controls.Add(this.newAlarmDefTextTxt);
            this.Controls.Add(this.newAlarmDefTextLabel);
            this.Controls.Add(this.newAlarmTextTxt);
            this.Controls.Add(this.newAlarmIDtxt);
            this.Controls.Add(this.NewAlarmGroup);
            this.Controls.Add(this.newAlarmTextLabel);
            this.Controls.Add(this.newAlarmIdLbl);
            this.Controls.Add(this.cancelNewAlarmBtn);
            this.Controls.Add(this.createNewAlarmBtn);
            this.Name = "NewAlarmForm";
            this.Text = "New Alarm";
            this.Load += new System.EventHandler(this.NewAlarmForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNewAlarmBtn;
        private System.Windows.Forms.Button cancelNewAlarmBtn;
        private System.Windows.Forms.Label newAlarmIdLbl;
        private System.Windows.Forms.Label newAlarmTextLabel;
        private System.Windows.Forms.Label NewAlarmGroup;
        private System.Windows.Forms.TextBox newAlarmIDtxt;
        private System.Windows.Forms.TextBox newAlarmTextTxt;
        private System.Windows.Forms.TextBox newAlarmDefTextTxt;
        private System.Windows.Forms.Label newAlarmDefTextLabel;
        private System.Windows.Forms.ComboBox groupCmbox;
    }
}