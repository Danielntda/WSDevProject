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
        [WebMethod(Description = "(double pace,double distance)")]
        public double calculateTime(double pace, double distance)
        {
            return pace * distance;
        }
        [WebMethod(Description = "(double pace, double time)")]
        public double calculateDistance(double pace, double time)
        {
            return time / pace;
        }
        [WebMethod(Description ="double time, double distace")]
        public double calculatePace(double time, double distance)
        {
            return time / distance;
        }

        [WebMethod(Description = "MileKmConversion(bool type(0=KM To Mile, 1=Mile To KM), double distance)")]
        public double MileKmConversion(bool type, double distance)
        {
            if (type == false)
                return distance / 1.60934;
            else if (type == true)
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
