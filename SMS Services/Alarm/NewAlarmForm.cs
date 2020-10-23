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
    public partial class NewAlarmForm : Form
    {
        public Dictionary<string, List<string>> group;
        public NewAlarmForm(Dictionary<string, List<string>> groups)
        {
            InitializeComponent();
            foreach (KeyValuePair< string, List < string >> pair in groups)
            {
                groupCmbox.Items.Add(pair.Key);
            }
            group = groups;
        }

        private void cancelNewAlarmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createNewAlarmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (newAlarmIDtxt.Text == "" || newAlarmTextTxt.Text == "" || newAlarmDefTextTxt.Text=="")
                    MessageBox.Show("Need complete all field");
                else
                {
                    if(Form1.server.AlarmHandler.newAlarm(int.Parse(newAlarmIDtxt.Text), newAlarmTextTxt.Text, groupCmbox.SelectedItem.ToString(),newAlarmDefTextTxt.Text))
                        this.Close();
                }
            }
            catch(Exception newAlarm)
            {
                MessageBox.Show("Incorrect inputs ","Error");
            }
        }

        private void NewAlarmForm_Load(object sender, EventArgs e)
        {

        }
    }
}
