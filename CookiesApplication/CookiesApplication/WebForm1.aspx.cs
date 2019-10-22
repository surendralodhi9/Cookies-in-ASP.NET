using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSend1_Click(object sender, EventArgs e)
        {

            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie["Name"] = textName.Text;
            cookie["Email"] = textEmail.Text;

            cookie.Expires = DateTime.Now.AddDays(30);

            Response.Cookies.Add(cookie);
            Response.Redirect("WebForm2.aspx");
        }
    }
}