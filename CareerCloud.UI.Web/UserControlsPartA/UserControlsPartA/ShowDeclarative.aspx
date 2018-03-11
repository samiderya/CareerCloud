<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowDeclarative.aspx.cs" Inherits="ShowDeclarative" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <user:RandomImageWithProperty 
            runat="server" ID="RandomImageWithProperty"
            ImageFolderPath="~/Images/Birds" />
    </div>
    </form>
</body>
</html>
