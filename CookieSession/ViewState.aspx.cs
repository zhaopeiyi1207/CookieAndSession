using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieSession
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSet_Click(object sender, EventArgs e)
        {
            ViewState["a"] = "abc";
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            var a = ViewState["a"];
           
            labShow.Text = a.ToString();  
        }
    }
}