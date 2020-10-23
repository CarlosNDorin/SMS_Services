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
    public partial class NewGroupForm : Form
    {
        Dictionary<string, PersonData> personsList;
        public NewGroupForm(Dictionary<string, PersonData> persons)
        {
            InitializeComponent();
            personsList = persons;
            foreach(KeyValuePair<string, PersonData> pair in persons)
            {
                PersonCmbox.Items.Add(pair.Key);
            }
            
        }

        private void cancelNewGroupBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGroupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (newGroupIdTxt.Text == "" )
                    MessageBox.Show("Need complete all field");
                else
                {
                   List<string> list= new List<string>();
                  ///ALSO HERE!
                    foreach(string s in PersonsList.Items)
                    {
                        list.Add(s);
                    }
                    if (Form1.server.Groups.CreateGroup(newGroupIdTxt.Text, list))
                    {
                        this.Close();
                    }
                   
                }
            }
            catch (Exception newGroup)
            {
                MessageBox.Show("Incorrect inputs ", "Error");
            }
        }

        private void NewGroupForm_Load(object sender, EventArgs e)
        {

        }

        private void newGroupAdd_Click(object sender, EventArgs e)
        {
            if(PersonCmbox.SelectedItem!=null)
                 PersonsList.Items.Add(PersonCmbox.SelectedItem);
        }

        private void newGroupDelete_Click(object sender, EventArgs e)
        {
            PersonsList.Items.Remove(PersonsList.SelectedItem);
        }
    }
}
