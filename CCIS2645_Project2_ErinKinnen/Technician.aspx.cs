using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

namespace CCIS2645_Project2_ErinKinnen
{
    public partial class Technician : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtError.Text = "Error Message";
            if(!IsPostBack)
            {
                txtError.Text = "";
                LoadTechnicians();
            }
        }

        protected void btnMain_Technician_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void LoadTechnicians()
        {
            DataSet dsData;

            dsData = clsDatabase.GetTechnicianList();
            if (dsData == null)
            {
                txtError.Text = "Error retrieving Technician List- dsData is NULL";
            }
            else if (dsData.Tables.Count < 1)
            {
                txtError.Text = "Error retrieving Technician List- dsData is < 1";
                dsData.Dispose();
            }
            else
            {
                ddlTechnician.DataSource = dsData.Tables[0];
                ddlTechnician.DataTextField = "Technician";
                ddlTechnician.DataValueField = "TechnicianID";
                ddlTechnician.DataBind();

                dsData.Dispose();
            }
        }

        private void DisplayTechnician(String strProdID)
        {
            DataSet dsData;

            dsData = clsDatabase.GetTechnicianByID(strProdID);
            if(dsData == null)
            {
                txtError.Text = "Error retrieving Technician";
            }
            else if (dsData.Tables.Count < 1)
            {
                txtError.Text = "Error retrieving Technician";
                dsData.Dispose();
            }
            else
            {
                if(dsData.Tables[0].Rows[0]["Technician"]== DBNull.Value)
                {
                    txtFirstName.Text = dsData.Tables[0].Rows[0]["FirstName"].ToString();
                    txtLastName.Text = dsData.Tables[0].Rows[0]["LastName"].ToString();
                }

                //if(dsData.Tables[0].Rows[0]["ProductHS"]==DBNull.Value)
                //{
                //    rdoHW.Checked = false;
                //    rdoSW.Checked = false;
                //}
                //else
                //{
                //    if(dsData.Tables[0].Rows[0]["Manufacturer"] == DBNull.Value
                //        {
                //        txtManufacturer.Text = "";
                //    })
                //}
            }
        }

        protected void ddlTechnician_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayTechnician(ddlTechnician.SelectedValue.ToString());
        }
    }
}