using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Services
{
    public partial class EditGroupForm : Form
    {
        private string Id;
        Dictionary<string, PersonData> personsList;

        public EditGroupForm(string id, List<string> personDatas, Dictionary<string, PersonData> persons)
        {
            InitializeComponent();
            Id = id;
            personsList = persons;
            foreach (KeyValuePair<string, PersonData> pair in persons)
            {
                PersonCmbox.Items.Add(pair.Key);
            }
            foreach(string p in personDatas)
            {
                PersonsList.Items.Add(p);
            }
            
        }

        private void cancelEditGroupBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditGroupForm_Load(object sender, EventArgs e)
        {
            editGroupIdTxt.Text = Id;
           
        }

        private void editGroupBtn_Click_1(object sender, EventArgs e)
        {
            if (editGroupIdTxt.Text == "")
                MessageBox.Show("Need complete all field");
            else
            {
                ///Here is my problem 
                ///If I do a string list and then search for the user
                ///What happend if the user name change?
                /*
                List<PersonData> list = new List<PersonData>();
                foreach (string s in PersonsList.Items)
                {
                    list.Add(Form1.server.Persons.GetPersons(s));
                }
                Form1.server.Groups.setGroup(editGroupIdTxt.Text, Id, list);
                Form1.updateGroup = true;
                this.Close();
                */

                List<string> list = new List<string>();
                foreach(string s in PersonsList.Items)
                {
                    list.Add(s);
                    Form1.server.Groups.setGroup(editGroupIdTxt.Text, Id, list);
                    Form1.updateGroup = true;
                    this.Close();
                }
            }
        }

        private void canceleditGroupBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editGroupAdd_Click(object sender, EventArgs e)
        {
            if (PersonCmbox.SelectedItem != null)
                PersonsList.Items.Add(PersonCmbox.SelectedItem);
        }

        private void editGroupDelete_Click(object sender, EventArgs e)
        {
            PersonsList.Items.Remove(PersonsList.SelectedItem);
        }
    }
}
