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
    public partial class EditPerson : Form
    {
        PersonData personData;
        string name;
        public EditPerson(string Name, PersonData PersonData)
        {
            InitializeComponent();
            name = Name;
            personData = PersonData;
        }

        private void EditPerson_Load(object sender, EventArgs e)
        {
            editNameTxt.Text = name;
            editPhoneTxt.Text = personData.Phone;
            editDescrTxt.Text = personData.Description;
        }
        private void canceleditBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createeditBtn_Click(object sender, EventArgs e)
        {
            if (editNameTxt.Text == "" || editDescrTxt.Text == "" || editPhoneTxt.Text == "")
                MessageBox.Show("Need complete all field");
            else
            {
                try
                {
                    Form1.server.Persons.setPerson(editNameTxt.Text, name, editPhoneTxt.Text, editDescrTxt.Text);
                    Form1.updatePeople = true;
                    this.Close();
                }
                catch (Exception editAlarm)
                {
                    MessageBox.Show("Input Error", "Error");
                }
            }
        }
    }
}
