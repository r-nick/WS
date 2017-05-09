<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestAPI.aspx.cs" Inherits="TestPremiumAPI" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtLocation" runat="server" TextMode="SingleLine" placeholder="Location"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnLocationSearchPremium" runat="server" 
            Text="Location Search" onclick="btnLocationSearchPremium_Click" 
            Width="275px" />
        <br />
        <br />
        <asp:TextBox ID="txtOutput" runat="server" TextMode="MultiLine" Width="500px" Height="500px" placeholder="Output"></asp:TextBox>
    </div>
    </form>
</body>
</html>
