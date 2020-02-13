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
                txtError.Text = "Error retrieving Technician List";
            }
            else if (dsData.Tables.Count < 1)
            {
                txtError.Text = "Error retrieving Technician List";
                dsData.Dispose();
            }
            else
            {
                ddlTechnician.DataSource = dsData.Tables[0];
                ddlTechnician.DataTextField = "TechName";
                ddlTechnician.DataValueField = "TechnicianID";
                ddlTechnician.DataBind();

                ddlTechnician.Items.Insert(0, new ListItem("-- TECHNICIAN --"));
                dsData.Dispose();
            }
        }

        private void DisplayTechnician(String strTechID)
        {
            DataSet dsData;

            dsData = clsDatabase.GetTechnicianByID(strTechID);
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
                if(dsData.Tables[0].Rows[0]["FName"]== DBNull.Value)
                {
                    txtFirstName.Text = "";
                }
                else
                {
                    txtFirstName.Text = dsData.Tables[0].Rows[0]["FName"].ToString();
                }
                if (dsData.Tables[0].Rows[0]["LName"] == DBNull.Value)
                {
                    txtLastName.Text = "";
                }
                else
                {
                    txtLastName.Text = dsData.Tables[0].Rows[0]["LName"].ToString();
                }
                if (dsData.Tables[0].Rows[0]["MInit"] == DBNull.Value)
                {
                    txtMiddleInitial.Text = "";
                }
                else
                {
                    txtMiddleInitial.Text = dsData.Tables[0].Rows[0]["MInit"].ToString();
                }
                if (dsData.Tables[0].Rows[0]["Email"] == DBNull.Value)
                {
                    txtEmail.Text = "";
                }
                else
                {
                    txtEmail.Text = dsData.Tables[0].Rows[0]["Email"].ToString();
                }
                if (dsData.Tables[0].Rows[0]["Dept"] == DBNull.Value)
                {
                    txtDepartment.Text = "";
                }
                else
                {
                    txtDepartment.Text = dsData.Tables[0].Rows[0]["Dept"].ToString();
                }
                if (dsData.Tables[0].Rows[0]["Phone"] == DBNull.Value)
                {
                    txtPhone.Text = "";
                }
                else
                {
                    txtPhone.Text = dsData.Tables[0].Rows[0]["Phone"].ToString();
                }
                if (dsData.Tables[0].Rows[0]["HRate"] == DBNull.Value)
                {
                    txtHourlyRate.Text = "";
                }
                else
                {
                    txtHourlyRate.Text = dsData.Tables[0].Rows[0]["HRate"].ToString();
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

        protected void btnAddNewTech_Click(object sender, EventArgs e)
        {
            ddlTechnician.Enabled = false;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMiddleInitial.Text = "";
            txtEmail.Text = "";
            txtDepartment.Text = "";
            txtPhone.Text = "";
            txtHourlyRate.Text = "";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ddlTechnician.Enabled = true;
            txtLastName.Text = "";
            LoadTechnicians();
        }
    }
}