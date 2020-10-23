namespace SMS_Services
{
    partial class EditGroupForm
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
            this.editGroupDelete = new System.Windows.Forms.Button();
            this.editGroupAdd = new System.Windows.Forms.Button();
            this.PersonsList = new System.Windows.Forms.ListBox();
            this.PersonCmbox = new System.Windows.Forms.ComboBox();
            this.editGroupIdTxt = new System.Windows.Forms.TextBox();
            this.editGroupLabel = new System.Windows.Forms.Label();
            this.editPersonLabel = new System.Windows.Forms.Label();
            this.canceleditGroupBtn = new System.Windows.Forms.Button();
            this.editGroupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editGroupDelete
            // 
            this.editGroupDelete.Location = new System.Drawing.Point(51, 107);
            this.editGroupDelete.Name = "editGroupDelete";
            this.editGroupDelete.Size = new System.Drawing.Size(109, 30);
            this.editGroupDelete.TabIndex = 4;
            this.editGroupDelete.Text = "Remove";
            this.editGroupDelete.UseVisualStyleBackColor = true;
            this.editGroupDelete.Click += new System.EventHandler(this.editGroupDelete_Click);
            // 
            // editGroupAdd
            // 
            this.editGroupAdd.Location = new System.Drawing.Point(51, 71);
            this.editGroupAdd.Name = "editGroupAdd";
            this.editGroupAdd.Size = new System.Drawing.Size(109, 30);
            this.editGroupAdd.TabIndex = 3;
            this.editGroupAdd.Text = "Add";
            this.editGroupAdd.UseVisualStyleBackColor = true;
            this.editGroupAdd.Click += new System.EventHandler(this.editGroupAdd_Click);
            // 
            // PersonsList
            // 
            this.PersonsList.FormattingEnabled = true;
            this.PersonsList.Location = new System.Drawing.Point(187, 44);
            this.PersonsList.Name = "PersonsList";
            this.PersonsList.Size = new System.Drawing.Size(164, 134);
            this.PersonsList.TabIndex = 34;
            // 
            // PersonCmbox
            // 
            this.PersonCmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonCmbox.FormattingEnabled = true;
            this.PersonCmbox.Location = new System.Drawing.Point(50, 44);
            this.PersonCmbox.Name = "PersonCmbox";
            this.PersonCmbox.Size = new System.Drawing.Size(121, 21);
            this.PersonCmbox.TabIndex = 2;
            // 
            // editGroupIdTxt
            // 
            this.editGroupIdTxt.Location = new System.Drawing.Point(51, 7);
            this.editGroupIdTxt.Name = "editGroupIdTxt";
            this.editGroupIdTxt.Size = new System.Drawing.Size(120, 20);
            this.editGroupIdTxt.TabIndex = 1;
            // 
            // editGroupLabel
            // 
            this.editGroupLabel.AutoSize = true;
            this.editGroupLabel.Location = new System.Drawing.Point(5, 10);
            this.editGroupLabel.Name = "editGroupLabel";
            this.editGroupLabel.Size = new System.Drawing.Size(39, 13);
            this.editGroupLabel.TabIndex = 31;
            this.editGroupLabel.Text = "Group:";
            // 
            // editPersonLabel
            // 
            this.editPersonLabel.AutoSize = true;
            this.editPersonLabel.Location = new System.Drawing.Point(5, 44);
            this.editPersonLabel.Name = "editPersonLabel";
            this.editPersonLabel.Size = new System.Drawing.Size(43, 13);
            this.editPersonLabel.TabIndex = 30;
            this.editPersonLabel.Text = "Person:";
            // 
            // canceleditGroupBtn
            // 
            this.canceleditGroupBtn.Location = new System.Drawing.Point(187, 184);
            this.canceleditGroupBtn.Name = "canceleditGroupBtn";
            this.canceleditGroupBtn.Size = new System.Drawing.Size(109, 30);
            this.canceleditGroupBtn.TabIndex = 6;
            this.canceleditGroupBtn.Text = "Cancel";
            this.canceleditGroupBtn.UseVisualStyleBackColor = true;
            this.canceleditGroupBtn.Click += new System.EventHandler(this.canceleditGroupBtn_Click_1);
            // 
            // editGroupBtn
            // 
            this.editGroupBtn.Location = new System.Drawing.Point(50, 184);
            this.editGroupBtn.Name = "editGroupBtn";
            this.editGroupBtn.Size = new System.Drawing.Size(109, 30);
            this.editGroupBtn.TabIndex = 5;
            this.editGroupBtn.Text = "Ok";
            this.editGroupBtn.UseVisualStyleBackColor = true;
            this.editGroupBtn.Click += new System.EventHandler(this.editGroupBtn_Click_1);
            // 
            // EditGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 226);
            this.Controls.Add(this.editGroupDelete);
            this.Controls.Add(this.editGroupAdd);
            this.Controls.Add(this.PersonsList);
            this.Controls.Add(this.PersonCmbox);
            this.Controls.Add(this.editGroupIdTxt);
            this.Controls.Add(this.editGroupLabel);
            this.Controls.Add(this.editPersonLabel);
            this.Controls.Add(this.canceleditGroupBtn);
            this.Controls.Add(this.editGroupBtn);
            this.Name = "EditGroupForm";
            this.Text = "EditGroupForm";
            this.Load += new System.EventHandler(this.EditGroupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editGroupDelete;
        private System.Windows.Forms.Button editGroupAdd;
        private System.Windows.Forms.ListBox PersonsList;
        private System.Windows.Forms.ComboBox PersonCmbox;
        private System.Windows.Forms.TextBox editGroupIdTxt;
        private System.Windows.Forms.Label editGroupLabel;
        private System.Windows.Forms.Label editPersonLabel;
        private System.Windows.Forms.Button canceleditGroupBtn;
        private System.Windows.Forms.Button editGroupBtn;
    }
}