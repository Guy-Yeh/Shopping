using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping
{
    public partial class index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cart");

            if (Request.Cookies["cart"]!=null)
                Label1.Text = " 總金額：" + Request.Cookies["cart"].Value;
            else
                Label1.Text = " 總金額：" + "0";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label3.Text)).ToString();
            Label1.Text =" 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label5.Text)).ToString();
            Label1.Text = " 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label7.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label9.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label11.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label13.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label15.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label17.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Cookies["cart"].Value = "0";
            Response.Redirect("index");
        }
    }
}