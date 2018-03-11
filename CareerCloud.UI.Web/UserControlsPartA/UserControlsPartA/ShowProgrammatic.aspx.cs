using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (rbAnimals.Checked == true)
            RandomImageWithProperty.ImageFolderPath = "~/Images/Animals";
        else if (rbBirds.Checked == true)
            RandomImageWithProperty.ImageFolderPath = "~/Images/Birds";
    }
}