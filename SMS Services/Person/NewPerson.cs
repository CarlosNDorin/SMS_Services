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
    public partial class NewPerson : Form
    {
        public NewPerson()
        {
            InitializeComponent();
        }

        private void cancelNewAlarmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createNewAlarmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (newNameTxt.Text == "" || newPhoneTxt.Text == "" || newDescrTxt.Text == "")
                    MessageBox.Show("Need complete all field");
                else
                {
                    if (Form1.server.Persons.newPerson(newNameTxt.Text, newPhoneTxt.Text, newDescrTxt.Text))
                        this.Close();
                }
            }
            catch (Exception newAlarm)
            {
                MessageBox.Show("Incorrect inputs ", "Error");
            }
        }

        private void NewPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
