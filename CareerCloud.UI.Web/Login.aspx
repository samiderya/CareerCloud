<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CareerCloud.UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.10.2.js"></script>

    <script type="text/javascript"> 
   function ClientValidate(source, arguments)
   {
       var usr = arguments.charAt(0);
        if (isNaN(usr)) {

            alert("Number");
        }
        else {
            alert("Char");
        }
   }
</script>
</head>
<body class="row">
    <form id="form1" runat="server" class="col-md-12 col-lg-offset-4">

        <fieldset>
            <legend>Registration
            </legend>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                ShowSummary="false" />
            <div class="col-md-8">
                <asp:Label Text="User Name" runat="server" CssClass="col-md-4" Width="200"></asp:Label>
                <asp:TextBox ID="txtUserName" runat="server" Width="200" MaxLength="5"></asp:TextBox>
                <asp:RequiredFieldValidator ID="vldRequiredUserName" runat="server" ErrorMessage="User is rquired" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
             <%--   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="It must start with character" ValidationExpression="^[a-zA-Z]+\s[0-9]+$" ControlToValidate="txtUserName" Display="Dynamic"></asp:RegularExpressionValidator>--%>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtUserName" ClientValidationFunction="ClientValidate"></asp:CustomValidator>
            </div>
            <div class="col-md-8">
                <asp:Label Text="Password" runat="server" CssClass="col-md-4" Width="200"></asp:Label>
                <asp:TextBox ID="txtUserPassword" runat="server" Width="200" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rqrPassword" runat="server" ErrorMessage="Password is required" ControlToValidate="txtUserPassword"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-8" style="margin-bottom: 10px">
                <asp:Label Text="Confirm Password" runat="server" CssClass="col-md-4" Width="200"></asp:Label>
                <asp:TextBox ID="txtConfirmPassword" runat="server" Width="200" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rqrConfirmPass" runat="server" ErrorMessage="Re enter password" ControlToValidate="txtConfirmPassword"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="The password must be the same" ControlToCompare="txtUserPassword" ControlToValidate="txtConfirmPassword"></asp:CompareValidator>
            </div>
            <div class="col-md-8 col-lg-offset-1" >
                <asp:Button ID="btnLogin" Text="Register" runat="server" CssClass="btn btn-primary btn-block" Width="200" OnClick="btnLogin_Click" />
            </div>
        </fieldset>
    </form>
    <p>
</body>
</html>
