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
    public partial class EditAlarmForm : Form
    {
        AlarmElement alarmElement;
        int id;
        public Dictionary<string, List<string>> group;
        public EditAlarmForm(AlarmElement editAlarmForm, int Id, Dictionary<string, List<string>> groups)
        {
            InitializeComponent();
            alarmElement = editAlarmForm;
            id = Id;
            foreach (KeyValuePair<string, List<string>> pair in groups)
            {
                groupCmbox.Items.Add(pair.Key);
            }
            group = groups;

        }

        private void EditAlarmForm_Load(object sender, EventArgs e)
        {
            editAlarmIDtxt.Text = id.ToString();
            editAlarmTextTxt.Text = alarmElement.alarmText;
            editAlarmDefTextTxt.Text = alarmElement.alarmDef;
            var testing = groupCmbox.Items.IndexOf(alarmElement.group);
            groupCmbox.SelectedIndex = testing;
        }

        private void cancelEditAlarmBtn_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void editAlarmBtn_Click(object sender, EventArgs e)
        {
            if (editAlarmIDtxt.Text == "" || editAlarmTextTxt.Text == "" ||  editAlarmDefTextTxt.Text =="")
                MessageBox.Show("Need complete all field");
            else
            {
                try
                {
                    Form1.server.AlarmHandler.setAlarm(int.Parse(editAlarmIDtxt.Text), id, editAlarmTextTxt.Text, groupCmbox.SelectedItem.ToString(), editAlarmDefTextTxt.Text);
                    Form1.updateAlarm = true;
                    this.Close();
                }
               catch(Exception editAlarm)
                {
                    MessageBox.Show("Input Error", "Error");
                }
                
            }
        }
    }
}
