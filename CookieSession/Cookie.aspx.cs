using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieSession
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSet_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("MyCook");//初使化并设置Cookie的名称
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(0, 0, 1, 0, 0);//过期时间为1分钟
            cookie.Expires = dt.Add(ts);//设置过期时间
            cookie.Values.Add("userid", "userid_value");
            cookie.Values.Add("userid2", "userid2_value2");
            Response.AppendCookie(cookie);
        }
         
        protected void btnGet_Click(object sender, EventArgs e)
        {
            // HttpCookie cokie = new HttpCookie("MyCook");//初使化
            if (Request.Cookies["MyCook"] != null)
            {
                //Response.Write("Cookie中键值为userid的值:" + Request.Cookies["MyCook"]["userid"]);//整行
                //Response.Write("Cookie中键值为userid2的值" + Request.Cookies["MyCook"]["userid2"]);
                Response.Write(Request.Cookies["MyCook"].Value);//输出全部的值
            }
        }
    }
}