using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_AddressForm : System.Web.UI.UserControl
{
    public string Title
    {
        get { return ltlTitle.Text; }
        set { ltlTitle.Text = value; }
    }

    public string Address
    {
        get { return txtAddress.Text; }
        set { txtAddress.Text = value; }
    }

    public string City
    {
        get { return txtCity.Text; }
        set { txtCity.Text = value; }
    }

    public string Zip
    {
        get { return txtZip.Text; }
        set { txtZip.Text = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}