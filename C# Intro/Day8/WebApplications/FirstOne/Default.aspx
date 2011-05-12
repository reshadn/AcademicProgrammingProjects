<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My First Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="lblMyLabel" style="font-size: x-large">
    
        This is a label<br />
    
    </div>
    <asp:Label ID="lblAnotherLabel" runat="server" Text="Label"></asp:Label>
    <p>
        Another Label</p>
    </form>
</body>
</html>
