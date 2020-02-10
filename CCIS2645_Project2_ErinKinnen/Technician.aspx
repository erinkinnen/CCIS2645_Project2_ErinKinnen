<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Technician.aspx.cs" Inherits="CCIS2645_Project2_ErinKinnen.Technician" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Technician Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTechnicianManagement" runat="server" Text="Technician Management"></asp:Label>
            <asp:Label ID="lblTechnician" runat="server" style="z-index: 1; left: 115px; top: 45px; position: absolute" Text="Technician:"></asp:Label>
            <asp:DropDownList ID="ddlTechnician" runat="server" style="z-index: 1; left: 220px; top: 45px; width: 176px; position: absolute" AutoPostBack="True" OnSelectedIndexChanged="ddlTechnician_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            <asp:Button ID="btnAddNewTech" runat="server" style="z-index: 1; left: 415px; top: 45px; position: absolute" Text="Add New Technician" />
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 115px; top: 75px; position: absolute" Text="* First Name:"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 220px; top: 75px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblMiddleInitial" runat="server" style="z-index: 1; left: 115px; top: 105px; position: absolute" Text="Middle Initial:"></asp:Label>
            <asp:TextBox ID="txtMiddleInitial" runat="server" style="z-index: 1; left: 220px; top: 105px; width: 30px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 115px; top: 135px; position: absolute" Text="* Last Name:"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 220px; top: 135px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 115px; top: 165px; position: absolute" Text="Email:"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 220px; top: 165px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblDepartment" runat="server" style="z-index: 1; left: 115px; top: 195px; position: absolute" Text="Department:"></asp:Label>
            <asp:TextBox ID="txtDepartment" runat="server" style="z-index: 1; left: 220px; top: 195px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblPhone" runat="server" style="z-index: 1; left: 115px; top: 225px; position: absolute" Text="* Phone:"></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 220px; top: 225px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblHourlyRate" runat="server" style="z-index: 1; left: 115px; top: 255px; position: absolute" Text="*Hourly Rate:"></asp:Label>
            <asp:TextBox ID="txtHourlyRate" runat="server" style="z-index: 1; left: 220px; top: 255px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblRequired" runat="server" style="z-index: 1; left: 115px; top: 295px; position: absolute" Text="* indicates a required field" ForeColor="#CC3300" Font-Size="Smaller"></asp:Label>
            <asp:Button ID="btnClear" runat="server" style="z-index: 1; left: 200px; top: 334px;  width: 80px; position: absolute; right: 1176px;" Text="Clear" OnClientClick="this.form.reset();return false;" />
            <asp:Button ID="btnSubmit" runat="server" style="z-index: 1; left: 320px; top:334px; width: 80px; position: absolute" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:TextBox ID="txtError" runat="server" style="z-index: 1; left: 10px; top: 443px; position: absolute; width: 353px; height: 60px;" BorderStyle="None" Font-Size="Smaller" ForeColor="#CC3300"></asp:TextBox>
            <asp:Button ID="btnMain_Technician" runat="server" style="z-index: 1; left: 645px; top: 473px; position: absolute" Text="Return to Main Menu" OnClick="btnMain_Technician_Click" />


        </div>
    </form>
</body>
</html>
