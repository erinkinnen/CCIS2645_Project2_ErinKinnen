using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CCIS2645_Project2_ErinKinnen
{
    public partial class Technician : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtError.Text = "Error Message";
        }

        protected void btnMain_Technician_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}