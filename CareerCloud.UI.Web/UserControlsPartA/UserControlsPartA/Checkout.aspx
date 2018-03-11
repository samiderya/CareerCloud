<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Checkout.aspx.cs" Inherits="Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <user:AddressForm runat="server" ID="AddressFormBilling" />
            <user:AddressForm runat="server" ID="AddressFormShipping" />
            
            <asp:Button ID="btnSubmit" Text="Submit" 
                OnClick="btnSubmit_Click" runat="server" />

            <hr />
            <asp:Literal ID="ltlDataCollected" runat="server" />

        </div>
    </form>
</body>
</html>
