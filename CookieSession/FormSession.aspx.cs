using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieSession
{
    public partial class FormSession : System.Web.UI.Page
    {
        private string _a;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSet_Click(object sender, EventArgs e)
        {
            _a = "ABC";
            lbInfo.Text = _a;
            Session["a"] = _a;
            lbSession.Text = Session["a"].ToString();
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            lbInfo.Text = _a;
            lbSession.Text = Session["a"].ToString();
        }
    }
}