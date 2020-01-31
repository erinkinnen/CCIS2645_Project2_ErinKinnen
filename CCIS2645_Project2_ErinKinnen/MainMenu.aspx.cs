using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CCIS2645_Project2_ErinKinnen
{
    public partial class MainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnServiceEvent_Click(object sender, EventArgs e)
        {
            Response.Redirect("ServiceEvent.aspx");
        }
        protected void btnProblemResolution_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProblemResolution.aspx");
        }
        protected void btnReports_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reports.aspx");
        }

        protected void btnManageTechnicians_Click(object sender, EventArgs e)
        {
            Response.Redirect("Technician.aspx");
        }



    }
}