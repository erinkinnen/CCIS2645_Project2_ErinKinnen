<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceEvent.aspx.cs" Inherits="CCIS2645_Project2_ErinKinnen.ServiceEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Service Event</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnClear" runat="server" style="z-index: 1; left: 200px; top: 214px;  width: 80px; position: absolute; " Text="Clear" OnClientClick="this.form.reset();return false;" />
            <asp:Button ID="btnSubmit" runat="server" style="z-index: 1; left: 320px; top: 214px; width: 80px; position: absolute" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Label ID="lblServiceEvent" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 10px; top: 15px; position: absolute; width: 1403px" Text="Service Event"></asp:Label>
            <asp:Label ID="lblEventDate" runat="server" style="z-index: 1; left: 115px; top: 45px; position: absolute" Text="Event Date:"></asp:Label>
            <asp:TextBox ID="txtEventDate" runat="server" OnLoad="Page_Load" style="z-index: 1; left: 200px; top: 45px; width: 175px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblClient" runat="server" style="z-index: 1; left: 115px; top: 75px; position: absolute" Text="*Client:"></asp:Label>
            <asp:DropDownList ID="ddlClient" runat="server" style="z-index: 1; left: 200px; top: 75px; position: absolute; height: 14px; width: 176px; right: 1049px">
            </asp:DropDownList>
            <asp:Label ID="lblContact" runat="server" style="z-index: 1; left: 115px; top: 105px; position: absolute" Text="*Contact:"></asp:Label>
            <asp:TextBox ID="txtContact" runat="server" style="z-index: 1; left: 200px; top: 105px;  width: 175px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblPhone" runat="server" style="z-index: 1; left: 115px; top: 135px; position: absolute" Text="*Phone:"></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 200px; top: 135px;  width: 175px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblRequired" runat="server" style="z-index: 1; left: 115px; top: 175px; position: absolute" Text="* indicates a required field" ForeColor="#CC3300" Font-Size="Smaller"></asp:Label>
            <asp:TextBox ID="txtError" runat="server" style="z-index: 1; left: 10px; top: 260px; position: absolute; width: 353px; height: 60px;" BorderStyle="None" Font-Size="Smaller" ForeColor="#CC3300"></asp:TextBox>
            <asp:Button ID="btnMain_ServiceEvent" runat="server" OnClick="btnMain_ServiceEvent_Click" style="z-index: 1; left: 645px; top: 290px; position: absolute" Text="Return to Main Menu" />

        </div>

    </form>
</body>
</html>
