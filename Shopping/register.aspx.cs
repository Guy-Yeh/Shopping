using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Drawing;

namespace Shopping
{
    public partial class register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [Obsolete]
        protected void registerButton_Click(object sender, EventArgs e)
        {
            verificationText.Text = (string)Session["ValidateNum"];
            //Response.Redirect("loging");
        }

        protected void loginLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("loging");
        }

        protected void registerLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("register");
        }
    }
}