using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMS_Services
{
    
        public class HttpAsyncServer
        {
            private string listenedAddresses;
            private string postAdresses; 
            static private bool isWorked;
            private HttpListener listener;
            private RestClient restClient;
            private HttpPost Post;
            public Alarm AlarmHandler = new Alarm();
            public UsersGroup Groups = new UsersGroup();
            public Person Persons = new Person();
            public string user;
            public string password;
            public void Server(string listenedAddresses, string postAddresses)
            {
            if (isWorked)
                throw new Exception("server alredy started");
                this.listenedAddresses = listenedAddresses;
                this.postAdresses = postAddresses;
            }
            public bool GetStatus()
            {
            if (listener.IsListening)
                return true;
            else
                return false;
            }
         

            private void Run()
            {
            //Run Start the HTTP SERVER LISTNER
            try 
            {
                listener = new HttpListener();
                if(listenedAddresses != string.Empty)
                {
                    listener.Prefixes.Add(listenedAddresses + "/");
                    listener.Start();
                }
                else
                {
                    isWorked = false;
                }
            }
            catch(Exception listenerException)
            {
                stop();
                
            }
            //Start the HTTP CLIENT
            try
            {
                if (postAdresses != string.Empty)
                {
                    restClient = new RestClient(postAdresses);
                    Post = new HttpPost();
                }
            }
            catch (Exception restClientException)
            {
                stop();
                throw new Exception(restClientException.Message);
            }
           
            //EVERYTHING IS OK!
            while (isWorked)
            {
                string responseString = "";
                byte[] buffer;
                try
                {
                   
                  
                    System.IO.Stream output;
                    //WAIT FOR GETTING VALUES
                    var context = listener.GetContext();

                    //Get values

                        string[] request = context.Request.RawUrl.Remove(0,1).Split(',');
                        string requestId = request[0];
                        string valueOfReq = request[1];
                        int idAlarm = int.Parse(requestId);

                        AlarmElement Alarm = AlarmHandler.GetAlarm(idAlarm);
                    if (Alarm != null)
                    {
                        List<string> PhonesNumbers = new List<string>();
                        List<string> personList = Groups.GetGroup(Alarm.group);
                        if (personList != null)
                        {

                            foreach (string p in personList)
                            {
                                string phoneNumber = Persons.GetPersons(p).Phone;
                                PhonesNumbers.Add(phoneNumber);
                            }

                            if (PhonesNumbers != null)
                            {
                                string textToSend = Alarm.alarmText.Replace("$", valueOfReq);
                                //Send SMS
                                foreach (string Phone in PhonesNumbers)
                                {
                                    Post.SendSMS(restClient, Phone, textToSend, user, password);
                                }
                                responseString = "AOK";
                                buffer = Encoding.UTF8.GetBytes(responseString);
                                context.Response.ContentLength64 = buffer.Length;
                                output = context.Response.OutputStream;
                                output.Write(buffer, 0, buffer.Length);
                                output.Close();
                            }
                            else
                            {
                                responseString = "NOK";
                                buffer = Encoding.UTF8.GetBytes(responseString);
                                context.Response.ContentLength64 = buffer.Length;
                                output = context.Response.OutputStream;
                                output.Write(buffer, 0, buffer.Length);
                                output.Close();
                            }
                        }
                        else
                        {
                            responseString = "NOK";
                            buffer = Encoding.UTF8.GetBytes(responseString);
                            context.Response.ContentLength64 = buffer.Length;
                            output = context.Response.OutputStream;
                            output.Write(buffer, 0, buffer.Length);
                            output.Close();
                        }
                    }
                    else
                    {
                        responseString = "NOK";
                        buffer = Encoding.UTF8.GetBytes(responseString);
                        context.Response.ContentLength64 = buffer.Length;
                        output = context.Response.OutputStream;
                        output.Write(buffer, 0, buffer.Length);
                        output.Close();
                    }
                }
                catch (Exception)
                {
                    
                    //stop();//NEED TO CLOSE PORT AND DISPLAY IT!, I DONT NEED TO CLOSE THE PORT IF THERE IS A NOT FOUND PROBLEM!
                }
            }
                stop();
            }

            public void stop()
            {
                isWorked = false;
            if(listener.IsListening)
                listener.Stop();
            }


            public void RunServer()
            {
                if (isWorked)
                    throw new Exception("server alredy started");

                isWorked = true;

                Thread serverThread = new Thread(new ThreadStart(Run));
                serverThread.Start();
            }

        }
    
}
