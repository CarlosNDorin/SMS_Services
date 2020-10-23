namespace SMS_Services
{
    partial class EditPerson
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
            this.editNameTxt = new System.Windows.Forms.TextBox();
            this.editPersonLabel = new System.Windows.Forms.Label();
            this.editDescrTxt = new System.Windows.Forms.TextBox();
            this.editPhoneTxt = new System.Windows.Forms.TextBox();
            this.editDescLabel = new System.Windows.Forms.Label();
            this.editPhoneLabel = new System.Windows.Forms.Label();
            this.canceleditBtn = new System.Windows.Forms.Button();
            this.createeditBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editNameTxt
            // 
            this.editNameTxt.Location = new System.Drawing.Point(77, 6);
            this.editNameTxt.Name = "editNameTxt";
            this.editNameTxt.Size = new System.Drawing.Size(129, 20);
            this.editNameTxt.TabIndex = 1;
            // 
            // editPersonLabel
            // 
            this.editPersonLabel.AutoSize = true;
            this.editPersonLabel.Location = new System.Drawing.Point(8, 9);
            this.editPersonLabel.Name = "editPersonLabel";
            this.editPersonLabel.Size = new System.Drawing.Size(38, 13);
            this.editPersonLabel.TabIndex = 26;
            this.editPersonLabel.Text = "Name:";
            // 
            // editDescrTxt
            // 
            this.editDescrTxt.Location = new System.Drawing.Point(77, 58);
            this.editDescrTxt.Name = "editDescrTxt";
            this.editDescrTxt.Size = new System.Drawing.Size(280, 20);
            this.editDescrTxt.TabIndex = 3;
            // 
            // editPhoneTxt
            // 
            this.editPhoneTxt.Location = new System.Drawing.Point(77, 32);
            this.editPhoneTxt.Name = "editPhoneTxt";
            this.editPhoneTxt.Size = new System.Drawing.Size(129, 20);
            this.editPhoneTxt.TabIndex = 2;
            // 
            // editDescLabel
            // 
            this.editDescLabel.AutoSize = true;
            this.editDescLabel.Location = new System.Drawing.Point(8, 61);
            this.editDescLabel.Name = "editDescLabel";
            this.editDescLabel.Size = new System.Drawing.Size(63, 13);
            this.editDescLabel.TabIndex = 23;
            this.editDescLabel.Text = "Description:";
            // 
            // editPhoneLabel
            // 
            this.editPhoneLabel.AutoSize = true;
            this.editPhoneLabel.Location = new System.Drawing.Point(8, 35);
            this.editPhoneLabel.Name = "editPhoneLabel";
            this.editPhoneLabel.Size = new System.Drawing.Size(41, 13);
            this.editPhoneLabel.TabIndex = 22;
            this.editPhoneLabel.Text = "Phone:";
            // 
            // canceleditBtn
            // 
            this.canceleditBtn.Location = new System.Drawing.Point(248, 84);
            this.canceleditBtn.Name = "canceleditBtn";
            this.canceleditBtn.Size = new System.Drawing.Size(109, 30);
            this.canceleditBtn.TabIndex = 5;
            this.canceleditBtn.Text = "Cancel";
            this.canceleditBtn.UseVisualStyleBackColor = true;
            this.canceleditBtn.Click += new System.EventHandler(this.canceleditBtn_Click);
            // 
            // createeditBtn
            // 
            this.createeditBtn.Location = new System.Drawing.Point(77, 84);
            this.createeditBtn.Name = "createeditBtn";
            this.createeditBtn.Size = new System.Drawing.Size(109, 30);
            this.createeditBtn.TabIndex = 4;
            this.createeditBtn.Text = "Ok";
            this.createeditBtn.UseVisualStyleBackColor = true;
            this.createeditBtn.Click += new System.EventHandler(this.createeditBtn_Click);
            // 
            // EditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 121);
            this.Controls.Add(this.editNameTxt);
            this.Controls.Add(this.editPersonLabel);
            this.Controls.Add(this.editDescrTxt);
            this.Controls.Add(this.editPhoneTxt);
            this.Controls.Add(this.editDescLabel);
            this.Controls.Add(this.editPhoneLabel);
            this.Controls.Add(this.canceleditBtn);
            this.Controls.Add(this.createeditBtn);
            this.Name = "EditPerson";
            this.Text = "EditPerson";
            this.Load += new System.EventHandler(this.EditPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editNameTxt;
        private System.Windows.Forms.Label editPersonLabel;
        private System.Windows.Forms.TextBox editDescrTxt;
        private System.Windows.Forms.TextBox editPhoneTxt;
        private System.Windows.Forms.Label editDescLabel;
        private System.Windows.Forms.Label editPhoneLabel;
        private System.Windows.Forms.Button canceleditBtn;
        private System.Windows.Forms.Button createeditBtn;
    }
}