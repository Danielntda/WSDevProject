using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;

namespace SportsRelatedWebApplication.SoapApi
{
    /// <summary>
    /// Summary description for SoapAPI
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SoapAPI : System.Web.Services.WebService
    {

        [WebMethod]
        public double RunningPaceCalculation(string type, double time, double distance, double pace)
        {
            if (type == "calculateTime")
                return pace * distance;
            else if (type == "calculateDistance")
                return time / pace;
            else if (type == "calculatePace")
                return time / distance;
            else return 0;
        }

        [WebMethod]
        public double MileKmConversion(string type, double distance)
        {
            if (type == "KMToMile")
                return distance / 1.60934;
            else if (type == "MileToKM")
                return distance * 1.60934;
            else
                return 0;
        }
        [WebMethod]
        public double HeartRateZone()
        {
            return 0;
        }
        [WebMethod]
        public string footballData()
        {
            var webRequest = (HttpWebRequest)WebRequest.Create("https://api.football-data.org/v1/competitions");
            var webResponse = (HttpWebResponse)webRequest.GetResponse();

            StreamReader sr = new StreamReader(webResponse.GetResponseStream());
            string resString = sr.ReadToEnd();

            return resString;
        }
        [WebMethod]
        public string footballFixture(string ID)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create("https://api.football-data.org/v1/competitions/"+ ID+ "/fixtures");
            var webResponse = (HttpWebResponse)webRequest.GetResponse();

            StreamReader sr = new StreamReader(webResponse.GetResponseStream());
            string resString = sr.ReadToEnd();

            return resString;
        }
    }

}
