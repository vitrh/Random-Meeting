using System;
using System.Collections.Generic;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using RestSharp;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace GeneratorLibrary
{
    /// <summary>
    /// https://marketplace.zoom.us/docs/api-reference/zoom-api/meetings/meetingcreate
    /// Creates a Zoom Meeting Link with the Zoom API
    /// </summary>
    public class LinkGenerator
    {
        // For own use - change the API Secret & API Key here
        const string apiSecret = "4f6ex4I9zLJ0TvmRQXKMJOik62dZaLtIHazl"; // change apiSecret here.
        const string apiKey = "mXD65UJ-QvKMoQUGupdKJw"; // change apiKey here
        RestClient client = new RestClient("https://api.zoom.us/v2/users/thong44.tt@googlemail.com/meetings"); // vinh client

        // RestClient client = new RestClient("https://api.zoom.us/v2/users/schwarz.christopher1996@gmail.com/meetings"); // christopher client
        JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
        /// <summary>
        /// Generates Zoom Meeting Links with the Zoom API.
        /// </summary>
        /// <param name="thema">The Meeting Topic/Name</param>
        /// <param name="date">When should the Meeting start? - Schema(no spaces): 'yyyy-mm-dd T HH:mm:ss' </param>
        /// <param name="durationtime">Duration of the Meeting - 15/30/45 minutes.</param>
        public string generateLink(Meeting _meeting, string durationtime)
        {
            ///Authentication

            string dateToString = _meeting.DateStart.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");

            var token = tokenHandler.CreateToken(TokenDescriptor(apiKey, 60, apiSecret));
            var tokenString = tokenHandler.WriteToken(token);

            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;

            // Request Body, gives the request the given objects
            request.AddJsonBody(new { 
                topic = _meeting.Description,
                type = 2,
                start_time = dateToString,
                duration = durationtime,
                timezone = "Europe/Berlin",
                settings = new { 
                    join_before_host = true,
                    jbh_time = 5 ,
                  
                } 
            });
        

            // meta, key = authorization ,value = bearer token// sicherheit
            request.AddHeader("authorization", String.Format("Bearer {0}", tokenString));
             
           
            IRestResponse restResponse = client.Execute(request);

            var jObject = JObject.Parse(restResponse.Content);

            string meetingId = Uri.EscapeUriString((string)jObject["id"]);

            
            return (string)jObject["join_url"] + InviteText(meetingId);
            // (string)jObject["id"]
            // (string)jObject["join_url"]
        }
        /// <summary>
        /// Return the invite text of the Zoom Meeting
        /// </summary>
        /// <param name="meetingId">Meeting ID of the Zoom Meeting</param>
        /// <returns></returns>
        public string InviteText(string meetingId)
        {
            var token = tokenHandler.CreateToken(TokenDescriptor(apiKey, 60, apiSecret));
            var tokenString = tokenHandler.WriteToken(token);

            var getClient = new RestClient($"https://api.zoom.us/v2/meetings/{meetingId}/invitation");
            var getRequest = new RestRequest(Method.GET);
            getRequest.RequestFormat = DataFormat.Json;
            getRequest.AddHeader("authorization", String.Format("Bearer {0}", tokenString));

            IRestResponse getResponse = getClient.Execute(getRequest);
            var jObject2 = JObject.Parse(getResponse.Content);

            string invitationText = (string)jObject2["invitation"];

            // Split the string on line breaks.
            List<string> texte = invitationText.Split(new string[] { ".\r\n\r" }, StringSplitOptions.None).ToList();

            texte.RemoveAt(0);


            return texte[0];


        }
        /// <summary>
        /// creates a Security Token
        /// </summary>
        /// <param name="issuer">Api-Key -> who created and signed this token</param>
        /// <param name="expires">Time when the JWT-Token should expire in seconds</param>
        /// <param name="apiSecret"> Api Secret </param>
        /// <returns></returns>
        public SecurityTokenDescriptor TokenDescriptor(string issuer, int expires, string apiSecret)
        {
            byte[] symmetricKey = Encoding.ASCII.GetBytes(apiSecret);
            DateTime now = DateTime.UtcNow;
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = issuer,
                Expires = now.AddSeconds(expires),
                // SigningCredentials = Ruft die Anmeldeinformationen für die Signierung des Tokens ab oder legt diese fest
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(symmetricKey), SecurityAlgorithms.HmacSha256), // 
            };

            return tokenDescriptor;
        }
        
    }
}
