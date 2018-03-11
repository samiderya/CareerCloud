<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowRandomImage.aspx.cs" Inherits="ShowRandomImage" %>


<%@ Register Src="~/UserControls/RandomImage.ascx" 
    TagPrefix="uc1" TagName="RandomImage" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:RandomImage runat="server" ID="RandomImage" />
    </div>
    </form>
</body>
</html>
