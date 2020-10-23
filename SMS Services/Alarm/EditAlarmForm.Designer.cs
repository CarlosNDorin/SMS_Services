namespace SMS_Services
{
    partial class EditAlarmForm
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
            this.editAlarmTextTxt = new System.Windows.Forms.TextBox();
            this.editAlarmIDtxt = new System.Windows.Forms.TextBox();
            this.editAlarmGroup = new System.Windows.Forms.Label();
            this.editAlarmTextLabel = new System.Windows.Forms.Label();
            this.editAlarmIdLbl = new System.Windows.Forms.Label();
            this.cancelEditAlarmBtn = new System.Windows.Forms.Button();
            this.editAlarmBtn = new System.Windows.Forms.Button();
            this.editAlarmDefTextTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupCmbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // editAlarmTextTxt
            // 
            this.editAlarmTextTxt.Location = new System.Drawing.Point(52, 59);
            this.editAlarmTextTxt.Name = "editAlarmTextTxt";
            this.editAlarmTextTxt.Size = new System.Drawing.Size(241, 20);
            this.editAlarmTextTxt.TabIndex = 3;
            // 
            // editAlarmIDtxt
            // 
            this.editAlarmIDtxt.Location = new System.Drawing.Point(52, 7);
            this.editAlarmIDtxt.Name = "editAlarmIDtxt";
            this.editAlarmIDtxt.Size = new System.Drawing.Size(241, 20);
            this.editAlarmIDtxt.TabIndex = 1;
            // 
            // editAlarmGroup
            // 
            this.editAlarmGroup.AutoSize = true;
            this.editAlarmGroup.Location = new System.Drawing.Point(6, 88);
            this.editAlarmGroup.Name = "editAlarmGroup";
            this.editAlarmGroup.Size = new System.Drawing.Size(39, 13);
            this.editAlarmGroup.TabIndex = 12;
            this.editAlarmGroup.Text = "Group:";
            // 
            // editAlarmTextLabel
            // 
            this.editAlarmTextLabel.AutoSize = true;
            this.editAlarmTextLabel.Location = new System.Drawing.Point(6, 62);
            this.editAlarmTextLabel.Name = "editAlarmTextLabel";
            this.editAlarmTextLabel.Size = new System.Drawing.Size(31, 13);
            this.editAlarmTextLabel.TabIndex = 11;
            this.editAlarmTextLabel.Text = "Text:";
            // 
            // editAlarmIdLbl
            // 
            this.editAlarmIdLbl.AutoSize = true;
            this.editAlarmIdLbl.Location = new System.Drawing.Point(6, 10);
            this.editAlarmIdLbl.Name = "editAlarmIdLbl";
            this.editAlarmIdLbl.Size = new System.Drawing.Size(21, 13);
            this.editAlarmIdLbl.TabIndex = 10;
            this.editAlarmIdLbl.Text = "ID:";
            // 
            // cancelEditAlarmBtn
            // 
            this.cancelEditAlarmBtn.Location = new System.Drawing.Point(184, 111);
            this.cancelEditAlarmBtn.Name = "cancelEditAlarmBtn";
            this.cancelEditAlarmBtn.Size = new System.Drawing.Size(109, 30);
            this.cancelEditAlarmBtn.TabIndex = 6;
            this.cancelEditAlarmBtn.Text = "Cancel";
            this.cancelEditAlarmBtn.UseVisualStyleBackColor = true;
            this.cancelEditAlarmBtn.Click += new System.EventHandler(this.cancelEditAlarmBtn_Click);
            // 
            // editAlarmBtn
            // 
            this.editAlarmBtn.Location = new System.Drawing.Point(9, 111);
            this.editAlarmBtn.Name = "editAlarmBtn";
            this.editAlarmBtn.Size = new System.Drawing.Size(109, 30);
            this.editAlarmBtn.TabIndex = 5;
            this.editAlarmBtn.Text = "Ok";
            this.editAlarmBtn.UseVisualStyleBackColor = true;
            this.editAlarmBtn.Click += new System.EventHandler(this.editAlarmBtn_Click);
            // 
            // editAlarmDefTextTxt
            // 
            this.editAlarmDefTextTxt.Location = new System.Drawing.Point(52, 33);
            this.editAlarmDefTextTxt.Name = "editAlarmDefTextTxt";
            this.editAlarmDefTextTxt.Size = new System.Drawing.Size(241, 20);
            this.editAlarmDefTextTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name:";
            // 
            // groupCmbox
            // 
            this.groupCmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupCmbox.FormattingEnabled = true;
            this.groupCmbox.Location = new System.Drawing.Point(51, 85);
            this.groupCmbox.Name = "groupCmbox";
            this.groupCmbox.Size = new System.Drawing.Size(121, 21);
            this.groupCmbox.TabIndex = 4;
            // 
            // EditAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 152);
            this.Controls.Add(this.groupCmbox);
            this.Controls.Add(this.editAlarmDefTextTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editAlarmTextTxt);
            this.Controls.Add(this.editAlarmIDtxt);
            this.Controls.Add(this.editAlarmGroup);
            this.Controls.Add(this.editAlarmTextLabel);
            this.Controls.Add(this.editAlarmIdLbl);
            this.Controls.Add(this.cancelEditAlarmBtn);
            this.Controls.Add(this.editAlarmBtn);
            this.Name = "EditAlarmForm";
            this.Text = "EditAlarmForm";
            this.Load += new System.EventHandler(this.EditAlarmForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox editAlarmTextTxt;
        private System.Windows.Forms.TextBox editAlarmIDtxt;
        private System.Windows.Forms.Label editAlarmGroup;
        private System.Windows.Forms.Label editAlarmTextLabel;
        private System.Windows.Forms.Label editAlarmIdLbl;
        private System.Windows.Forms.Button cancelEditAlarmBtn;
        private System.Windows.Forms.Button editAlarmBtn;
        private System.Windows.Forms.TextBox editAlarmDefTextTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox groupCmbox;
    }
}