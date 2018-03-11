using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowTabStrip : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TabScrip_AddClick(object sender, EventArgs e)
    {
        lblOperation.Text = "Adding Record...";
    }

    protected void TabScrip_EditClick(object sender, EventArgs e)
    {
        lblOperation.Text = "Editing Record...";
    }

    protected void TabScrip_DeleteClick(object sender, EventArgs e)
    {
        lblOperation.Text = "Deleting Record...";
    }
}