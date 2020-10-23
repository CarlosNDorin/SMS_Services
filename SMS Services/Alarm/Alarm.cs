using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Services
{
   public class Alarm
    {
        public Dictionary<int, AlarmElement> AlarmList = new Dictionary<int, AlarmElement>();

        public bool newAlarm(int id, string alrmText, string grp, string alrmDf)
        {
            if (AlarmList.ContainsKey(id))
            {
                MessageBox.Show("ID Already exist", "Error");
                return false;
            }
            else
            {
                AlarmList.Add(id, new AlarmElement { alarmText = alrmText, group = grp, alarmDef = alrmDf });
                return true;
            }
        }

        public void deleteAlarm(int id)
        {
            if (!AlarmList.ContainsKey(id))
            {
                throw new NotSupportedException("The Alarm Not Exist");
            }
            AlarmList.Remove(id);
        }

        public AlarmElement GetAlarm(int id)
        {
            if (!AlarmList.ContainsKey(id))
            {
                return null;
            }
            return AlarmList[id];
        }


        public void setAlarm(int id,int old, string alrmText, string grp,string alrmDf)
        {
            if (!AlarmList.ContainsKey(old))
            {
                throw new NotSupportedException("The Alarm Not Exist");
            }
            if (AlarmList.ContainsKey(old))
            {
                deleteAlarm(old);
                if(AlarmList.ContainsKey(id))
                {
                    deleteAlarm(id);
                }
                newAlarm(id, alrmText, grp, alrmDf);
            }
            else
            {
                newAlarm(id, alrmText, grp, alrmDf);
                deleteAlarm(old);
            }
        }

        public Dictionary<int, AlarmElement> getAlarmList()
        {
            return AlarmList;
        }

        public void setAlarmlist(Dictionary<int, AlarmElement> AlrmList)
        {
            AlarmList = AlrmList;
        }

       
        
    }
    
    public class AlarmElement
    {
       public string alarmText;
       public string alarmDef;
       public string group;
    }



}
