<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowTabStrip.aspx.cs" Inherits="ShowTabStrip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <user:TabScrip runat="server" ID="TabScrip"
                OnAddClick="TabScrip_AddClick"
                OnEditClick="TabScrip_EditClick"
                OnDeleteClick="TabScrip_DeleteClick" />
            <hr />
            <asp:Label ID="lblOperation" runat="server" />
        </div>
    </form>
</body>
</html>
