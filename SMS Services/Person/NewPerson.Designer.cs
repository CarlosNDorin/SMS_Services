namespace SMS_Services
{
    partial class NewPerson
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
            this.newNameTxt = new System.Windows.Forms.TextBox();
            this.newPersonLabel = new System.Windows.Forms.Label();
            this.newDescrTxt = new System.Windows.Forms.TextBox();
            this.newPhoneTxt = new System.Windows.Forms.TextBox();
            this.NewDescLabel = new System.Windows.Forms.Label();
            this.newPhoneLabel = new System.Windows.Forms.Label();
            this.cancelNewAlarmBtn = new System.Windows.Forms.Button();
            this.createNewAlarmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newNameTxt
            // 
            this.newNameTxt.Location = new System.Drawing.Point(73, 12);
            this.newNameTxt.Name = "newNameTxt";
            this.newNameTxt.Size = new System.Drawing.Size(129, 20);
            this.newNameTxt.TabIndex = 1;
            // 
            // newPersonLabel
            // 
            this.newPersonLabel.AutoSize = true;
            this.newPersonLabel.Location = new System.Drawing.Point(4, 15);
            this.newPersonLabel.Name = "newPersonLabel";
            this.newPersonLabel.Size = new System.Drawing.Size(38, 13);
            this.newPersonLabel.TabIndex = 18;
            this.newPersonLabel.Text = "Name:";
            // 
            // newDescrTxt
            // 
            this.newDescrTxt.Location = new System.Drawing.Point(73, 64);
            this.newDescrTxt.Name = "newDescrTxt";
            this.newDescrTxt.Size = new System.Drawing.Size(280, 20);
            this.newDescrTxt.TabIndex = 3;
            // 
            // newPhoneTxt
            // 
            this.newPhoneTxt.Location = new System.Drawing.Point(73, 38);
            this.newPhoneTxt.Name = "newPhoneTxt";
            this.newPhoneTxt.Size = new System.Drawing.Size(129, 20);
            this.newPhoneTxt.TabIndex = 2;
            // 
            // NewDescLabel
            // 
            this.NewDescLabel.AutoSize = true;
            this.NewDescLabel.Location = new System.Drawing.Point(4, 67);
            this.NewDescLabel.Name = "NewDescLabel";
            this.NewDescLabel.Size = new System.Drawing.Size(63, 13);
            this.NewDescLabel.TabIndex = 14;
            this.NewDescLabel.Text = "Description:";
            // 
            // newPhoneLabel
            // 
            this.newPhoneLabel.AutoSize = true;
            this.newPhoneLabel.Location = new System.Drawing.Point(4, 41);
            this.newPhoneLabel.Name = "newPhoneLabel";
            this.newPhoneLabel.Size = new System.Drawing.Size(41, 13);
            this.newPhoneLabel.TabIndex = 13;
            this.newPhoneLabel.Text = "Phone:";
            // 
            // cancelNewAlarmBtn
            // 
            this.cancelNewAlarmBtn.Location = new System.Drawing.Point(244, 90);
            this.cancelNewAlarmBtn.Name = "cancelNewAlarmBtn";
            this.cancelNewAlarmBtn.Size = new System.Drawing.Size(109, 30);
            this.cancelNewAlarmBtn.TabIndex = 5;
            this.cancelNewAlarmBtn.Text = "Cancel";
            this.cancelNewAlarmBtn.UseVisualStyleBackColor = true;
            this.cancelNewAlarmBtn.Click += new System.EventHandler(this.cancelNewAlarmBtn_Click);
            // 
            // createNewAlarmBtn
            // 
            this.createNewAlarmBtn.Location = new System.Drawing.Point(73, 90);
            this.createNewAlarmBtn.Name = "createNewAlarmBtn";
            this.createNewAlarmBtn.Size = new System.Drawing.Size(109, 30);
            this.createNewAlarmBtn.TabIndex = 4;
            this.createNewAlarmBtn.Text = "Ok";
            this.createNewAlarmBtn.UseVisualStyleBackColor = true;
            this.createNewAlarmBtn.Click += new System.EventHandler(this.createNewAlarmBtn_Click);
            // 
            // NewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 133);
            this.Controls.Add(this.newNameTxt);
            this.Controls.Add(this.newPersonLabel);
            this.Controls.Add(this.newDescrTxt);
            this.Controls.Add(this.newPhoneTxt);
            this.Controls.Add(this.NewDescLabel);
            this.Controls.Add(this.newPhoneLabel);
            this.Controls.Add(this.cancelNewAlarmBtn);
            this.Controls.Add(this.createNewAlarmBtn);
            this.Name = "NewPerson";
            this.Text = "NewPerson";
            this.Load += new System.EventHandler(this.NewPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newNameTxt;
        private System.Windows.Forms.Label newPersonLabel;
        private System.Windows.Forms.TextBox newDescrTxt;
        private System.Windows.Forms.TextBox newPhoneTxt;
        private System.Windows.Forms.Label NewDescLabel;
        private System.Windows.Forms.Label newPhoneLabel;
        private System.Windows.Forms.Button cancelNewAlarmBtn;
        private System.Windows.Forms.Button createNewAlarmBtn;
    }
}