using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesApplication
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpCookie cookie = Request.Cookies["UserInfo"];

            if(cookie!=null)
            {

                showName.Text = cookie["Name"];
                showEmail.Text = cookie["Email"];
            }
        }
    }
}