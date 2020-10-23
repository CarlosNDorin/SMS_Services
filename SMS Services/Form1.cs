using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;

namespace SMS_Services
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        public static HttpAsyncServer server = new HttpAsyncServer();
        
        public void StartServerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                server.Server(localIPTxtBox.Text, clientBox.Text);
                server.RunServer();
                StartServerBtn.BackColor = Color.Green;
                server.user = txtUser.Text;
                server.password = txtPass.Text;
                
            }
            catch(Exception exempt)
            {
                alarmTxtBox.Text = exempt.Message;
            }
        }
        public void StopServerBtn_Click(object sender, EventArgs e)
        {
            if (server.GetStatus())
            {
                server.stop();
                StartServerBtn.BackColor = Color.LightGray;
            }
        }
        public string GetIP()
        {
            return localIPTxtBox.Text;
        }
        public HttpAsyncServer GetServerData()
        {
            return server;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize Alarm Table
            tableAlarm.Columns.Add("Id", typeof(int));
            tableAlarm.Columns.Add("Group", typeof(string));
            tableAlarm.Columns.Add("Alarm", typeof(string));
            tableAlarm.Columns.Add("Text", typeof(string));
            AlarmListDGW.DataSource = tableAlarm;
            AlarmListDGW.Columns[0].Width = 30;
            AlarmListDGW.Columns[1].Width = 60;
            AlarmListDGW.Columns[2].Width = 100;
            AlarmListDGW.Columns[3].Width = 300;
            //Initialize Group 
            tableGroup.Columns.Add("Group", typeof(string));
            tableGroup.Columns.Add("Names", typeof(string));
            GroupListDGW.DataSource = tableGroup;
            GroupListDGW.Columns[0].Width = 60;
            GroupListDGW.Columns[1].Width = 300;
            //Initialize Person
            tablePerson.Columns.Add("Name", typeof(string));
            tablePerson.Columns.Add("Phone", typeof(string));
            tablePerson.Columns.Add("Description", typeof(string));
            PersonsGDW.DataSource = tablePerson;
            PersonsGDW.Columns[0].Width = 60;
            PersonsGDW.Columns[1].Width = 60;
            PersonsGDW.Columns[2].Width = 250;
            //Load Backup if Exist
            Restore();

            //Run the server
            try
            {
              /*  server.Server(localIPTxtBox.Text, clientBox.Text);
                server.RunServer();
                StartServerBtn.BackColor = Color.Green;*/
            }
            catch (Exception exempt)
            {
                alarmTxtBox.Text = exempt.Message;
            }
        }


        //Alarms
        public DataTable tableAlarm = new DataTable();
        public int amountOfAlarms = 0;
        public static bool updateAlarm = false;

        public void newAlarmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                NewAlarmForm newAlarmForm = new NewAlarmForm(server.Groups.GetDic());
                newAlarmForm.Show();
            }
            catch(Exception newAlarmE)
            {
                MessageBox.Show(newAlarmE.Message);
            }
        }
        private void deleteAlarmBtn_Click(object sender, EventArgs e)
        {
            if (server.AlarmHandler.AlarmList.Count() > 0)
            {
                if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    GroupListDGW.Rows[GroupListDGW.CurrentRow.Index].Cells[0].Value.ToString();
                    int value = (int)AlarmListDGW.Rows[AlarmListDGW.CurrentRow.Index].Cells[0].Value;
                    server.AlarmHandler.deleteAlarm(value);

                }
            }
        }
        private void editAlarm_Click(object sender, EventArgs e)
        {
            if (server.AlarmHandler.AlarmList.Count() > 0)
            {
                AlarmElement alarmSelected = server.AlarmHandler.GetAlarm((int)AlarmListDGW.Rows[AlarmListDGW.CurrentRow.Index].Cells[0].Value);
                EditAlarmForm newEditForm = new EditAlarmForm(alarmSelected, (int)AlarmListDGW.Rows[AlarmListDGW.CurrentRow.Index].Cells[0].Value, server.Groups.GetDic());
                newEditForm.Show();
            }
        }
        public void updateAlarmGrid()
        {
            tableAlarm.Clear();

            foreach (KeyValuePair<int, AlarmElement> pair in server.AlarmHandler.AlarmList)
            {
                tableAlarm.Rows.Add(pair.Key, pair.Value.group,pair.Value.alarmDef, pair.Value.alarmText);
            }
            AlarmListDGW.DataSource = tableAlarm;
        }




        //Group
        public DataTable tableGroup = new DataTable();
        public int amountOfGroups = 0;
        public static bool updateGroup = false;
        
        private void newGroupBtn_Click(object sender, EventArgs e)
        {
            NewGroupForm newGroupForm = new NewGroupForm(server.Persons.getPersonsLists());
            newGroupForm.Show();
        }
        private void deleteGroupBtn_Click(object sender, EventArgs e)
        {
            if (server.Groups.Groups.Count() > 0)
            {
                if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string value = GroupListDGW.Rows[GroupListDGW.CurrentRow.Index].Cells[0].Value.ToString();
                    server.Groups.DeleteGroup(value);
                }
            }
        }
        private void editGroupBtn_Click(object sender, EventArgs e)
        {
            if (server.Groups.Groups.Count() > 0)
            {
                string id = GroupListDGW.Rows[GroupListDGW.CurrentRow.Index].Cells[0].Value.ToString();
                List<string> peopleList = server.Groups.GetGroup(id);
                EditGroupForm editGroupForm = new EditGroupForm(id, peopleList, server.Persons.getPersonsLists());
                editGroupForm.Show();
            }
        }
        public void updatGroupGrid()
        {
           
            tableGroup.Clear();
            string value = string.Empty;
            foreach (KeyValuePair<string, List<string>> pair in server.Groups.Groups)
            {
                
                foreach (string p in pair.Value)
                {
                    value += p + "  /  ";
                }
              value =  value.Remove(value.Length - 3, 3);
                tableGroup.Rows.Add(pair.Key, value);
                value = "";
            }
            GroupListDGW.DataSource = tableGroup;
        }


        //Person
        public DataTable tablePerson = new DataTable();
        public int amountOfPeople = 0;
        public static bool updatePeople = false;

        private void newPersonbtn_Click(object sender, EventArgs e)
        {
            NewPerson newPerson = new NewPerson();
            newPerson.Show();
        }
        private void deletePersonbtn_Click(object sender, EventArgs e)
        {
            if (server.Persons.persons.Count() > 0 )
            {
                if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string value = PersonsGDW.Rows[PersonsGDW.CurrentRow.Index].Cells[0].Value.ToString();
                    server.Persons.deletePerson(value);
                }
            }
        }
        private void editPersonbtn_Click(object sender, EventArgs e)
        {
            
            if (server.Persons.persons.Count() > 0)
            {
                string id = PersonsGDW.Rows[PersonsGDW.CurrentRow.Index].Cells[0].Value.ToString();
                PersonData personData = server.Persons.GetPersons(id);
                EditPerson editPerson = new EditPerson(id, personData);
                editPerson.Show();
            }
        }
        public void updatePersonGrid()
        {
            tablePerson.Clear();

            foreach (KeyValuePair<string,PersonData> pair in server.Persons.persons)
            {
                tablePerson.Rows.Add(pair.Key, pair.Value.Phone,pair.Value.Description);
            }
            PersonsGDW.DataSource = tablePerson;
        }

        //General
        private void CheckChanges_Tick(object sender, EventArgs e)
        {
            if(amountOfAlarms!= server.AlarmHandler.getAlarmList().Count || updateAlarm)
            {
                updateAlarmGrid();
                amountOfAlarms = server.AlarmHandler.getAlarmList().Count;
                updateAlarm = false;
            }
            if (amountOfGroups != server.Groups.GetDic().Count || updateGroup)
            {
                updatGroupGrid();
                amountOfGroups = server.Groups.GetDic().Count;
                updateGroup = false;
            }
            if (amountOfPeople != server.Persons.getPersonsLists().Count || updatePeople)
            {
                updatePersonGrid();
                amountOfPeople = server.Persons.getPersonsLists().Count;
                updatePeople = false;
            }
        }
        private void Restore()
        {
            if (File.Exists(Environment.CurrentDirectory + "\\Persons"))
            {
                string persons = @File.ReadAllText(Environment.CurrentDirectory + "\\Persons");
                Dictionary<string, PersonData> dicPersons = JsonConvert.DeserializeObject<Dictionary<string, PersonData>>(persons);
                server.Persons.setPersonsLists(dicPersons);
            }

            if (File.Exists(Environment.CurrentDirectory + "\\Groups"))
            {
                string group = @File.ReadAllText(Environment.CurrentDirectory + "\\Groups");
                Dictionary<string, List<string>> dicGroup = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(group);
                server.Groups.SetDic(dicGroup);
            }

            if (File.Exists(Environment.CurrentDirectory + "\\Alarms"))
            {
                string alarm = @File.ReadAllText(Environment.CurrentDirectory + "\\Alarms");
                Dictionary<int, AlarmElement> dicAlarm = JsonConvert.DeserializeObject<Dictionary<int, AlarmElement>>(alarm);
                server.AlarmHandler.setAlarmlist(dicAlarm);
            }
        }
        private void Backup_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;

            saveFileDialog.FileName = "Persons";
            string personsSave = saveFileDialog.FileName;
            saveFileDialog.FileName = "Groups";
            string groupSave = saveFileDialog.FileName;
            saveFileDialog.FileName = "Alarms";
            string alarmSave = saveFileDialog.FileName;
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "csv";

            File.WriteAllText(personsSave, JsonConvert.SerializeObject(server.Persons.getPersonsLists()));
            File.WriteAllText(groupSave, JsonConvert.SerializeObject(server.Groups.GetDic()));
            File.WriteAllText(alarmSave, JsonConvert.SerializeObject(server.AlarmHandler.getAlarmList()));


        }
        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            Restore();
        }
    }
    
}
		
