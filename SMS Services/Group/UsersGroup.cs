using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Services
{
    public class UsersGroup
    {
        public Dictionary<string, List<string>> Groups = new Dictionary<string, List<string>>();

        public bool CreateGroup(string id, List<string> Names)
        {
            if (Groups.ContainsKey(id))
            {
                MessageBox.Show("ID Already exist", "Error");
                return false;
            }
            else
            {
                Groups.Add(id, Names);
                return true;
            }
        }

        public void DeleteGroup(string id)
        {
            if (!Groups.ContainsKey(id))
            {
                throw new NotSupportedException("The Group Not Exist");
            }

            Groups.Remove(id);
        }

        public List<String> GetGroup(string id)
        {
            if (!Groups.ContainsKey(id))
            {
                return null;
            }
            return Groups[id];
        }

        public void setGroup(string id, string old, List<string> people)
        {
            if (!Groups.ContainsKey(old))
            {
                throw new NotSupportedException("The Group Not Exist");
            }

            if (Groups.ContainsKey(old))
            {
                DeleteGroup(old);
                if (Groups.ContainsKey(id))
                {
                    DeleteGroup(id);
                }
                CreateGroup(id, people);
            }
            else
            {
                CreateGroup(id, people);
                DeleteGroup(id);
            }            
        }

        public Dictionary<string, List<string>> GetDic()
        {
            return Groups;
        }

        public void SetDic(Dictionary<string, List<string>> Dic)
        {
            Groups = Dic;
        }
    }
}

