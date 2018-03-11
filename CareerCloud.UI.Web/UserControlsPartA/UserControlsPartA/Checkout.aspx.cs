using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Checkout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AddressFormBilling.Title = "Billing Address :";
        AddressFormShipping.Title = "Shipping Address :";
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ltlDataCollected.Text = "<br />Billing Address: " + AddressFormBilling.Address;
        ltlDataCollected.Text += "<br />Billing City: " + AddressFormBilling.City;
        ltlDataCollected.Text += "<br />Billing Zip: " + AddressFormBilling.Zip;
        
        ltlDataCollected.Text += "<br /><br />";

        ltlDataCollected.Text += "<br />Shipping Address: " + AddressFormShipping.Address;
        ltlDataCollected.Text += "<br />Shipping City: " + AddressFormShipping.City;
        ltlDataCollected.Text += "<br />Shipping Zip: " + AddressFormShipping.Zip;
        
    }
}