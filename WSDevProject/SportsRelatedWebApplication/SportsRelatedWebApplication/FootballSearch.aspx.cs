using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportsRelatedWebApplication.SoapWS;
using System.Web.Script.Serialization;


namespace SportsRelatedWebApplication
{
    public partial class FootballSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       
            if (!IsPostBack)
            {
                SoapAPI sa = new SoapAPI();
                string fd = sa.footballData();

                JavaScriptSerializer json = new JavaScriptSerializer();

                result[] list = json.Deserialize<result[]>(fd);

                GridView1.DataSource = list;
                GridView1.DataBind();
            }

        }
        public class result
        {
            public string caption { get; set; }
            public string league { get; set; }
        }

        protected void BtnFixture_Click(object sender, EventArgs e)
        {
            SoapAPI sa = new SoapAPI();
            string fd = sa.footballFixture("444");

            JavaScriptSerializer json2 = new JavaScriptSerializer();
            fixtureresult list2 = json2.Deserialize<fixtureresult>(fd);

            GridView2.DataSource = list2.fixtures;
            GridView2.DataBind();
            TextBox1.Text = fd;
        }
        public class fixtureresult
        {
            public fixture[] fixtures;
        }

        public class fixture
        {
            public string date { get; set; }
            public string status { get; set; }
            public string matchday { get; set; }
            public string homeTeamName { get; set; }
            public string awayTeamName { get; set; }
        }
    }
    
}