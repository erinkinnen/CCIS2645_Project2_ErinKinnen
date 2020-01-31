using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CCIS2645_Project2_ErinKinnen
{
    public partial class ServiceEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtEventDate.Text = DateTime.Now.ToString("MM-dd-yyyy");
            txtError.Text = "Error Message";
        }

        protected void btnMain_ServiceEvent_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}