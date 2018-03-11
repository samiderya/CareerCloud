using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_TabScrip : System.Web.UI.UserControl
{
    public event EventHandler AddClick;
    public event EventHandler EditClick;
    public event EventHandler DeleteClick;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        AddClick(this, EventArgs.Empty);
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        EditClick(this, EventArgs.Empty);
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        DeleteClick(this, EventArgs.Empty);
    }
}