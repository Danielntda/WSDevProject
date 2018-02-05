using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportsRelatedWebApplication
{
    public partial class RunClac : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button4_Click(string type, double time, double distance, double pace)
        {
            if (txtDist == null)
            {
                distance = time / pace;
            }

        }

        protected void Button2_Click(string type, double time, double distance, double pace)
        {
            if (txtTime == null)
            {
                time = pace * distance;
                
            }
        }

        protected void Button3_Click(string type, double time, double distance, double pace)
        {
            if(txtPace == null)
            {
                pace = time / distance;
            }
        }
    }
}