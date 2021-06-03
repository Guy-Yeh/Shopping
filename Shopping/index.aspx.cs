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
            if (Request.Cookies["quantity"]== null)
                Response.Cookies["quantity"].Value = "0";

            if (Request.Cookies["cart"]!=null)
                Label1.Text = " 總金額：" + Request.Cookies["cart"].Value;
            else
                Label1.Text = " 總金額：" + "0";
            Label18.Text = Request.Cookies["quantity"].Value;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "白") 
            {
                Response.Cookies["buy"][$"{Request.Cookies["quantity"].Value}"] = "1";
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if(DropDownList1.SelectedValue== "紅")
            {
                Response.Cookies["buy"][$"{Request.Cookies["quantity"].Value}"] = "2";
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList1.SelectedValue == "綠")
            {
                Response.Cookies["buy"][$"{Request.Cookies["quantity"].Value}"] = "3";
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
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

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "領造型線T";
            Response.Redirect("product");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "袖滾配色t";
            Response.Redirect("product");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "剪裁T";
            Response.Redirect("product");
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "細肩露肩t";
            Response.Redirect("product");
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "胸抓摺衫";
            Response.Redirect("product");
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "格紋澎袖衫";
            Response.Redirect("product");
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "中抓摺雪紡衫";
            Response.Redirect("product");
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            Session["product"] = "滾邊寬袖衫";
            Response.Redirect("product");
        }
    }
}