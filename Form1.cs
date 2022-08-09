using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Graph;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using Newtonsoft.Json.Linq;

namespace AzureADConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // var accessToken = lObjoktaToken.access_token;
            var tt = Task.Run(() => GetNewAccessTokenAsync());
            tt.Wait();
          object obj=  JsonConvert.SerializeObject(tt.Result);
         TokenResponse TR=   JsonConvert.DeserializeObject<TokenResponse>(tt.Result);
            txtUsers.Text = TR.access_token;
            var ttGroup = Task.Run(() => GetAzureADGroups(TR.access_token));
            ttGroup.Wait();
           string str  =JsonConvert.SerializeObject(ttGroup.Result, Formatting.Indented);
            txtGroups.Text = Environment.NewLine + str;

            
        }

       
        private async Task<string> GetNewAccessTokenAsync()
        {

            var postMessage = new Dictionary<string, string>
        {
                {"client_id", "Your Client id"},
                {"client_secret","Your client secret" },
                {"scope","User.Read" },
               
                {"grant_type", "password"},
                {"username", "username"},
                {"password", "password"}

        };

            var request = new HttpRequestMessage(HttpMethod.Post, "https://login.microsoftonline.com/5df723e9-d46f-4e7a-869d-5ea5c151094b/oauth2/v2.0/token")
            {
                Content = new FormUrlEncodedContent(postMessage)
            };
          
            
          
             var client1 = new HttpClient();
            var response = await client1.PostAsync("https://login.microsoftonline.com/5df723e9-d46f-4e7a-869d-5ea5c151094b/oauth2/v2.0/token", new FormUrlEncodedContent(postMessage));

            // return response.ReasonPhrase;
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync();
                //var newToken = JsonConvert.DeserializeObject<OktaToken>(json);
                //newToken.ExpiresAt = DateTime.UtcNow.AddSeconds(_token.ExpiresIn);

                return json.Result;
            }
            return "";
            // throw new ApplicationException("Unable to retrieve access token");
        }
        private async Task<string> GetAzureADGroups(string accesstoken)
        {

            var client1 = new HttpClient();
            client1.DefaultRequestHeaders.Add("Authorization", "Bearer " + accesstoken);
            var response = await client1.GetAsync("https://graph.microsoft.com/v1.0/groups");

            // return response.ReasonPhrase;
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync();
                //var newToken = JsonConvert.DeserializeObject<OktaToken>(json);
                //newToken.ExpiresAt = DateTime.UtcNow.AddSeconds(_token.ExpiresIn);

                return json.Result;
            }
            return "";
            // throw new ApplicationException("Unable to retrieve access token");
        }

        private async Task<string> GetMembersInGroup(string accesstoken,string group)
        {

            var client1 = new HttpClient();
            client1.DefaultRequestHeaders.Add("Authorization", "Bearer " + accesstoken);
            var response = await client1.GetAsync("https://graph.microsoft.com/v1.0/groups/"+ group + "/members");

            // return response.ReasonPhrase;
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync();
                return json.Result;
            }
            return "";
        }
        private void btnGetGroups_Click(object sender, EventArgs e)
        {
            var tt = Task.Run(() => GetNewAccessTokenAsync());
            tt.Wait();
            object obj = JsonConvert.SerializeObject(tt.Result);
            TokenResponse TR = JsonConvert.DeserializeObject<TokenResponse>(tt.Result);
            var ttGroupMembers = Task.Run(() => GetMembersInGroup(txtGroupname.Text, TR.access_token));
            ttGroupMembers.Wait();
        }
    }
    public class TokenRequest
    {
        public string client_id { get; set; }
        public string client_secret { get; set; }
        public string scope { get; set; }
        public string grant_type { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        
    }

    public class TokenResponse
    {
        public string token_type { get; set; }
        public string scope { get; set; }
        public string expires_in { get; set; }
        public string ext_expires_in { get; set; }
        public string access_token { get; set; }
       
    }
}
