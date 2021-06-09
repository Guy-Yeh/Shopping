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
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie usecookie = new HttpCookie("buy");
            if (DropDownList1.SelectedValue == "白") 
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "1");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if(DropDownList1.SelectedValue== "紅")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "2");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList1.SelectedValue == "綠")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "3");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label3.Text)).ToString();
            Label1.Text =" 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie usecookie = new HttpCookie("buy");
            if (DropDownList2.SelectedValue == "黑")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "4");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList2.SelectedValue == "白")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "5");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList2.SelectedValue == "綠")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "6");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList2.SelectedValue == "橘")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "7");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label5.Text)).ToString();
            Label1.Text = " 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie usecookie = new HttpCookie("buy");
            if (DropDownList3.SelectedValue == "白")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "8");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList3.SelectedValue == "灰")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "9");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList3.SelectedValue == "杏")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "10");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList3.SelectedValue == "咖啡")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "11");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList3.SelectedValue == "黑")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "12");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label7.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            HttpCookie usecookie = new HttpCookie("buy");
            if (DropDownList4.SelectedValue == "紅")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "13");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList4.SelectedValue == "綠")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "14");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList4.SelectedValue == "黑")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "15");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList4.SelectedValue == "白")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "16");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label9.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            HttpCookie usecookie = new HttpCookie("buy");
            if (DropDownList5.SelectedValue == "粉")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "17");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList5.SelectedValue == "灰")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "18");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList5.SelectedValue == "黑")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "19");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label11.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            HttpCookie usecookie = new HttpCookie("buy");
            if (DropDownList6.SelectedValue == "黑")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "20");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList6.SelectedValue == "紅")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "21");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label13.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            HttpCookie usecookie = new HttpCookie("buy");
            if (DropDownList7.SelectedValue == "杏")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "25");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList7.SelectedValue == "白")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "26");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList7.SelectedValue == "紅")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "27");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label15.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            HttpCookie usecookie = new HttpCookie("buy");
            if (DropDownList8.SelectedValue == "白")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "22");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList8.SelectedValue == "黑")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "23");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            else if (DropDownList8.SelectedValue == "粉")
            {
                if (Request.Cookies["buy"] != null)
                    usecookie.Values.Add(Request.Cookies["buy"].Values);
                usecookie.Values.Add($"{Request.Cookies["quantity"].Value}", "24");
                Response.AppendCookie(usecookie);
                Response.Cookies["quantity"].Value = $"{Convert.ToInt32(Request.Cookies["quantity"].Value) + 1}";
            }
            Response.Cookies["cart"].Value = (Convert.ToInt32(Request.Cookies["cart"].Value) + Convert.ToInt32(Label17.Text)).ToString();
            Label2.Text = " 總金額：" + Request.Cookies["cart"].Value;
            Response.Redirect("index");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["buy"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-2);
                Response.Cookies.Set(cookie);
            }
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

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("shoppingcar");
        }
    }
}