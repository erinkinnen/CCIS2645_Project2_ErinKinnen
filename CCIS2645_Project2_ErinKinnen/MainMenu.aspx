<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="CCIS2645_Project2_ErinKinnen.MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblMainMenu" runat="server" Text="Main Menu"></asp:Label>

            <asp:Button ID="btnServiceEvent" runat="server" OnClick="btnServiceEvent_Click" style="z-index: 1; left: 165px; top: 70px; width: 250px; position: absolute" Text="Service Event" />
            <p>
            &nbsp;
            </p>
            <asp:Button ID="btnProblemResolution" runat="server" style="z-index: 1; left: 165px; top: 100px; width: 250px; position: absolute" Text="Problem Resolution" OnClick="btnProblemResolution_Click" />
             <p>
            &nbsp;
            </p>
            <asp:Button ID="btnReports" runat="server" style="z-index: 1; left: 165px; top: 130px; width: 250px; position: absolute" Text="Reports" OnClick="btnReports_Click" />
            <p>
            &nbsp;
            </p>
            <asp:Button ID="btnManageTechnicians" runat="server" style="z-index: 1; left: 165px; top: 160px; width: 250px; position: absolute" Text="Manage Technicians" OnClick="btnManageTechnicians_Click" />
            <asp:TextBox ID="txtError" runat="server" style="z-index: 1; left: 10px; top: 443px; position: absolute; width: 353px; height: 60px;" BorderStyle="None" Font-Size="Smaller" ForeColor="#CC3300"></asp:TextBox>
        </div>
    </form>
</body>
</html>
