<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>First Web Form</title>
    <style type="text/css">
        #Text1
        {
            width: 177px;
        }
        #btnRun
        {
            width: 72px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="First Web Form"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="dataDropDownList" runat="server" Height="24px" 
            Width="151px">
            <asp:ListItem>Apples</asp:ListItem>
            <asp:ListItem>Bananas</asp:ListItem>
            <asp:ListItem>Oranges</asp:ListItem>
            <asp:ListItem>Pears</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Name:         
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <br />
                &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRunStd" runat="server" onclick="btnRunStd_Click" Text="Run" 
            Width="107px" Height="22px" />
        <br />
        <br />
        Results:
        <asp:Label ID="lblResults" runat="server" BorderStyle="None" Height="22px" 
            Width="254px"></asp:Label>
    
    </div>
    </form>
</body>
</html>
