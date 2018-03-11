using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CareerCloud.UI.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(IsValidate())
            {

            }
        }

        private bool IsValidate()
        {
            string userName = txtUserName.Text;
            string userPass = txtUserPassword.Text;
            return true;
        }
    }
}