using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Services
{
    class HttpPost
    {
        public void SendSMS(RestClient restClient,string Phone,string AlarmText,string user, string password)
        {
           
            string json = JsonConvert.SerializeObject(new {phones = Phone, data = AlarmText  });
            restClient.Authenticator = new SimpleAuthenticator("username", user, "password", password);// new HttpBasicAuthenticator("USER","PASS");
            restClient.PreAuthenticate = true;
            
            // restClient.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
            // restClient.AddDefaultHeader("Content-Type", "application/json");
            //restClient.AddDefaultHeader("Authorization", "basic username:password"); // add passwords in the gui
            // restClient.Authenticator = new SimpleAuthenticator("username", "foo", "password", "bar"); perhaps this way?

            //  var restRequest = new RestRequest("/upload?filesize=" + json.Length + "&routeID=" + routeID, Method.POST);
            var restRequest = new RestRequest("/sendit/api/sms", Method.POST);
            
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddHeader("Authorization", "basic username:password");
            restRequest.AddJsonBody(json);
                      
            var response = restClient.Execute(restRequest);
           // return response.Content;
        }
    }
}
