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

            if (!IsPostBack)
            {
                txtError.Text = "";
                LoadTechnicians();
                btnUpdate.Enabled = false;
                btnAdd.Enabled = false;
                btnRemove.Enabled = false;
            }
        }

 //METHODS
        private Boolean FormValidation()
        {
            Boolean blnOk = true;
            String strValMessage = "";
            //txtError.Text = "";

            if(txtFirstName.Text.Trim().Length < 1)
            {
                blnOk = false;
                strValMessage += "First Name is required ";
            }
            if (txtLastName.Text.Trim().Length < 1)
            {
                blnOk = false;
                strValMessage += "Last Name is required ";
            }
            if (String.IsNullOrWhiteSpace(txtPhone.Text))
            {
                blnOk = false;
                strValMessage += "whitespacePhone number is required ";
            }
            else
            {
                Int64 intPhone;

                if(txtPhone.Text.Length != 10)
                {
                    strValMessage += "lessthan10Phone number must be 10 digits ";
                }
                if(!Int64.TryParse(txtPhone.Text, out intPhone))
                {
                    blnOk = false;
                    strValMessage += "numberPhone number must be numeric ";
                }
            }
            if (txtHourlyRate.Text.Trim().Length < 1)
            {
                blnOk = false;
                strValMessage += "Hourly rate is required ";
            }

            txtError.Text = strValMessage;
            return blnOk;
        }
        private void ClearForm()
        {
            txtFirstName.Text = "";
            txtMiddleInitial.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtDepartment.Text = "";
            txtPhone.Text = "";
            txtHourlyRate.Text = "";

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
                ddlTechnician.SelectedIndex = 0;
                dsData.Dispose();
            }
        }
        private void DisplayTechnician(String strTechID)
        {
            DataSet dsData;

            dsData = clsDatabase.GetTechnicianByID(strTechID);
            if (dsData == null)
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
                if (dsData.Tables[0].Rows[0]["FName"] == DBNull.Value)
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

            }
        }
        protected void ddlTechnician_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayTechnician(ddlTechnician.SelectedValue.ToString());
            btnUpdate.Enabled = true;
            btnRemove.Enabled = true;
        }


        //BUTTONS
        protected void btnMain_Technician_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
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
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Int32 intRetValue;
            //String strHS;

            txtError.Text = "";

            if (FormValidation())
            {
                //** Updating a Technician
                intRetValue = clsDatabase.UpdateTechnician(Convert.ToInt32(ddlTechnician.SelectedValue), txtLastName.Text.Trim(), txtFirstName.Text.Trim(), txtMiddleInitial.Text.Trim(), txtEmail.Text.Trim(), txtDepartment.Text.Trim(), txtPhone.Text.Trim(), txtHourlyRate.Text.Trim());

                if (intRetValue == 0)
                {
                    LoadTechnicians(); // Reload the Drop Down List
                    txtError.Text = "Technician updated";
                    ClearForm();
                }
                else
                {

                    txtError.Text = "Error updating Technician";
                }
            }

            btnUpdate.Enabled = false;
            btnClear.Enabled = true;
            btnRemove.Enabled = false;
            btnCancel.Enabled = true;
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Int32 intRetValue;
            String strHS;

            if (FormValidation())
            {
                intRetValue = clsDatabase.InsertTechnician(txtLastName.Text.Trim(), txtFirstName.Text.Trim(), txtMiddleInitial.Text.Trim(), txtEmail.Text.Trim(), txtDepartment.Text.Trim(), txtPhone.Text.Trim(), txtHourlyRate.Text.Trim());

                if (intRetValue == 0)
                {
                    LoadTechnicians();

                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtMiddleInitial.Text = "";
                    txtPhone.Text = "";
                    txtHourlyRate.Text = "";
                    txtDepartment.Text = "";
                    txtEmail.Text = "";

                    txtError.Text = "Techncian Added";
                    btnAdd.Enabled = false;
                }
                else
                {
                    txtError.Text = "Error inserting new technician";
                }
            }

            btnAddNewTech.Enabled = true;
            ddlTechnician.Enabled = true;
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ddlTechnician.Enabled = true;
            ddlTechnician.SelectedIndex = 0;
            ClearForm();
        }
        protected void btnRemove_Click(object sender, EventArgs e)
        {
            Int32 intRetCode;

            intRetCode = clsDatabase.DeleteTechnician(Int32.Parse(ddlTechnician.SelectedValue));

            if (intRetCode == 0)
            {
                LoadTechnicians();
                ClearForm();

                txtError.Text = "Technician successfully deleted";
            }
            else
            {
                txtError.Text = "Unable to remove technician";
            }
        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtError.Text = "Clear Clicked";
            ddlTechnician.Enabled = true;
            ddlTechnician.SelectedIndex = 0;
            DisplayTechnician(ddlTechnician.SelectedValue.ToString());
            ClearForm();

        }
    }
}