<%@ Control Language="C#" AutoEventWireup="true"
    CodeFile="AddressForm.ascx.cs" Inherits="UserControls_AddressForm" %>

<fieldset>
    <legend>
        <asp:Literal ID="ltlTitle" Text="Address Form" runat="server" />
    </legend>

    <div>
        <asp:Label ID="lblAddress" Text="Address:"
            AssociatedControlID="txtAddress" runat="server" />
        <asp:TextBox ID="txtAddress" runat="server" />
        <asp:RequiredFieldValidator ID="reqAddress" Text="(required)"
            ControlToValidate="txtAddress" runat="server" />

        <br />
        <asp:Label ID="lblCity" Text="City:"
            AssociatedControlID="txtCity" runat="server" />
        <asp:TextBox ID="txtCity" runat="server" />
        <asp:RequiredFieldValidator ID="reqCity" Text="(required)"
            ControlToValidate="txtCity" runat="server" />

        <br />
        <asp:Label ID="lblZip" Text="Zip:"
            AssociatedControlID="txtZip" runat="server" />
        <asp:TextBox ID="txtZip" runat="server" />
        <asp:RequiredFieldValidator ID="reqZip" Text="(required)"
            ControlToValidate="txtZip" runat="server" />


    </div>

</fieldset>
