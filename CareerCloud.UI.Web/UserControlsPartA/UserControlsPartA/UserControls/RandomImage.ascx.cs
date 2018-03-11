using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
public partial class UserControls_RandomImage : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string imageToDisplay = GetRandomImage();
        imgRandom.ImageUrl = Path.Combine("~/Images/Birds", imageToDisplay);
        lblRandom.Text = imageToDisplay;
    }
    private string GetRandomImage()
    {
        Random rnd = new Random();
        string[] images = Directory.GetFiles(MapPath("~/Images/Birds"), "*.jpg");
        string imageToDisplay = images[rnd.Next(images.Length)];
        return Path.GetFileName(imageToDisplay);
    }
}