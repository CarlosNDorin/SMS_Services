namespace SMS_Services
{
    partial class NewGroupForm
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
            this.newGroupIdTxt = new System.Windows.Forms.TextBox();
            this.newGroupLabel = new System.Windows.Forms.Label();
            this.newPersonLabel = new System.Windows.Forms.Label();
            this.cancelNewGroupBtn = new System.Windows.Forms.Button();
            this.newGroupBtn = new System.Windows.Forms.Button();
            this.PersonCmbox = new System.Windows.Forms.ComboBox();
            this.PersonsList = new System.Windows.Forms.ListBox();
            this.newGroupAdd = new System.Windows.Forms.Button();
            this.newGroupDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newGroupIdTxt
            // 
            this.newGroupIdTxt.Location = new System.Drawing.Point(54, 6);
            this.newGroupIdTxt.Name = "newGroupIdTxt";
            this.newGroupIdTxt.Size = new System.Drawing.Size(120, 20);
            this.newGroupIdTxt.TabIndex = 23;
            // 
            // newGroupLabel
            // 
            this.newGroupLabel.AutoSize = true;
            this.newGroupLabel.Location = new System.Drawing.Point(8, 9);
            this.newGroupLabel.Name = "newGroupLabel";
            this.newGroupLabel.Size = new System.Drawing.Size(39, 13);
            this.newGroupLabel.TabIndex = 20;
            this.newGroupLabel.Text = "Group:";
            // 
            // newPersonLabel
            // 
            this.newPersonLabel.AutoSize = true;
            this.newPersonLabel.Location = new System.Drawing.Point(8, 43);
            this.newPersonLabel.Name = "newPersonLabel";
            this.newPersonLabel.Size = new System.Drawing.Size(43, 13);
            this.newPersonLabel.TabIndex = 19;
            this.newPersonLabel.Text = "Person:";
            // 
            // cancelNewGroupBtn
            // 
            this.cancelNewGroupBtn.Location = new System.Drawing.Point(190, 183);
            this.cancelNewGroupBtn.Name = "cancelNewGroupBtn";
            this.cancelNewGroupBtn.Size = new System.Drawing.Size(109, 30);
            this.cancelNewGroupBtn.TabIndex = 17;
            this.cancelNewGroupBtn.Text = "Cancel";
            this.cancelNewGroupBtn.UseVisualStyleBackColor = true;
            this.cancelNewGroupBtn.Click += new System.EventHandler(this.cancelNewGroupBtn_Click);
            // 
            // newGroupBtn
            // 
            this.newGroupBtn.Location = new System.Drawing.Point(53, 183);
            this.newGroupBtn.Name = "newGroupBtn";
            this.newGroupBtn.Size = new System.Drawing.Size(109, 30);
            this.newGroupBtn.TabIndex = 16;
            this.newGroupBtn.Text = "Ok";
            this.newGroupBtn.UseVisualStyleBackColor = true;
            this.newGroupBtn.Click += new System.EventHandler(this.newGroupBtn_Click);
            // 
            // PersonCmbox
            // 
            this.PersonCmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonCmbox.FormattingEnabled = true;
            this.PersonCmbox.Location = new System.Drawing.Point(53, 43);
            this.PersonCmbox.Name = "PersonCmbox";
            this.PersonCmbox.Size = new System.Drawing.Size(121, 21);
            this.PersonCmbox.TabIndex = 24;
            // 
            // PersonsList
            // 
            this.PersonsList.FormattingEnabled = true;
            this.PersonsList.Location = new System.Drawing.Point(190, 43);
            this.PersonsList.Name = "PersonsList";
            this.PersonsList.Size = new System.Drawing.Size(164, 134);
            this.PersonsList.TabIndex = 25;
            // 
            // newGroupAdd
            // 
            this.newGroupAdd.Location = new System.Drawing.Point(54, 70);
            this.newGroupAdd.Name = "newGroupAdd";
            this.newGroupAdd.Size = new System.Drawing.Size(109, 30);
            this.newGroupAdd.TabIndex = 26;
            this.newGroupAdd.Text = "Add";
            this.newGroupAdd.UseVisualStyleBackColor = true;
            this.newGroupAdd.Click += new System.EventHandler(this.newGroupAdd_Click);
            // 
            // newGroupDelete
            // 
            this.newGroupDelete.Location = new System.Drawing.Point(54, 106);
            this.newGroupDelete.Name = "newGroupDelete";
            this.newGroupDelete.Size = new System.Drawing.Size(109, 30);
            this.newGroupDelete.TabIndex = 27;
            this.newGroupDelete.Text = "Remove";
            this.newGroupDelete.UseVisualStyleBackColor = true;
            this.newGroupDelete.Click += new System.EventHandler(this.newGroupDelete_Click);
            // 
            // NewGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 224);
            this.Controls.Add(this.newGroupDelete);
            this.Controls.Add(this.newGroupAdd);
            this.Controls.Add(this.PersonsList);
            this.Controls.Add(this.PersonCmbox);
            this.Controls.Add(this.newGroupIdTxt);
            this.Controls.Add(this.newGroupLabel);
            this.Controls.Add(this.newPersonLabel);
            this.Controls.Add(this.cancelNewGroupBtn);
            this.Controls.Add(this.newGroupBtn);
            this.Name = "NewGroupForm";
            this.Text = "New Group";
            this.Load += new System.EventHandler(this.NewGroupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newGroupIdTxt;
        private System.Windows.Forms.Label newGroupLabel;
        private System.Windows.Forms.Label newPersonLabel;
        private System.Windows.Forms.Button cancelNewGroupBtn;
        private System.Windows.Forms.Button newGroupBtn;
        private System.Windows.Forms.ComboBox PersonCmbox;
        private System.Windows.Forms.ListBox PersonsList;
        private System.Windows.Forms.Button newGroupAdd;
        private System.Windows.Forms.Button newGroupDelete;
    }
}