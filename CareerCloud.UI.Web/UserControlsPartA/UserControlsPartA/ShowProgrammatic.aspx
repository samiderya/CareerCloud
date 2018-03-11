<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowProgrammatic.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="rbBirds" Text="Birds" GroupName="ImageType"
                runat="server" Checked="true" AutoPostBack="true"  />

            <asp:RadioButton ID="rbAnimals" Text="Animals" GroupName="ImageType"
                runat="server" AutoPostBack="true" />

            <user:RandomImageWithProperty
                runat="server" ID="RandomImageWithProperty" />
        </div>
    </form>
</body>
</html>
