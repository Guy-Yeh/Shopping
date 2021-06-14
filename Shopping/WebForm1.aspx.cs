using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.IO;
using System.Windows;

namespace Shopping
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ProductsConnectionString"].ConnectionString;

        public object DataGridViewAutoSizeColumnsMode { get; private set; }
        public object DataGridViewAutoSizeRowsMode { get; private set; }
        public object DataGridViewAutoSizeColumnMode { get; private set; }

        /*rivate byte[] GetPhotoToBytes(string photoPath)
        {
            byte[] bytes;

            using (System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(photoPath))
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                bytes = new byte[(int)ms.Length];
                ms.Position = 0;
                ms.Read(bytes, 0, (int)ms.Length);
                ms.Flush();
            }

            return bytes;
        }*/
        protected void Page_Load(object sender, EventArgs e)
        {



            //SqlConnection connection = new SqlConnection(s_data);
            //string sql = $"select * from Products where category= N'白'";
            //SqlCommand command = new SqlCommand(sql, connection);
            //connection.Open();
            //SqlDataReader read = command.ExecuteReader();

            //DataTable dt = new DataTable();
            //dt.Columns.Add("ID");
            //dt.Columns.Add("productName");
            ////DataColumn picture = new DataColumn();
            ////picture = new DataColumn("picture");
            //dt.Columns.Add("picture");
            //dt.Columns.Add("category");
            //dt.Columns.Add("inventory");
            //dt.Columns.Add("price");
            //dt.Columns.Add("initdate");

            //while (read.Read())
            //{
            //    DataRow row = dt.NewRow();
            //    row["ID"] = read[0];
            //    row["productName"] = read[1];
            //    //row["picture"] = ResolveUrl($"{read[2]}");
            //    row["picture"] = read[2];
            //    row["category"] = read[3];
            //    row["inventory"] = read[4];
            //    row["price"] = read[5];
            //    row["initdate"] = read[6];
            //    dt.Rows.Add(row);
            //}
            //GridView2.DataSource = dt;
            //GridView2.DataBind();
            //connection.Close();


            /*DataTable dt = new DataTable();
            DataColumn dc = new DataColumn();
            dt.Columns.Add(dc);
            dc = new DataColumn("img");
            dt.Columns.Add(dc);

            DataRow dr = dt.NewRow();
            dr[0] = "11111111111111111";
            dr[1] = ResolveUrl("~/images/衣服/281901701-領造型線T/S__77931623.jpg");
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr[0] = "22222222222222222";
            dr[1] = ResolveUrl("~/images/衣服/281901701-領造型線T/S__77931623.jpg");
            dt.Rows.Add(dr);

            GridView2.DataSource = dt;
            GridView2.DataBind();*/

            //DataTable dt = new DataTable();
            //Table dt = new Table();

            #region
            /*DataColumn ID = new DataColumn();
            ID.ColumnName = "ID";
            DataColumn productName = new DataColumn();
            productName.ColumnName = "productName";
            DataColumn picture = new DataColumn();
            picture.ColumnName = "picture";
            DataColumn category = new DataColumn();
            category.ColumnName = "category";
            DataColumn inventory = new DataColumn();
            inventory.ColumnName = "inventory";
            DataColumn price = new DataColumn();
            price.ColumnName = "price";
            DataColumn initdate = new DataColumn();
            initdate.ColumnName = "initdate";*/

            /*
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("productName");
            dt.Columns.Add("picture", typeof(byte[])); //
            dt.Columns.Add("category");
            dt.Columns.Add("inventory");
            dt.Columns.Add("price");
            dt.Columns.Add("initdate");*/
            #endregion
            //while (read.Read())
            //{
            //DataRow row = dt.NewRow();
            /*TableRow row = new TableRow();
            TableCell c0 = new TableCell();
            c0.Controls.Add(new LiteralControl($"{read[0].ToString()}"));
            row.Cells.Add(c0);
            TableCell c1 = new TableCell();
            c1.Controls.Add(new LiteralControl($"{read[1].ToString()}"));
            row.Cells.Add(c1);

            TableCell c2 = new TableCell();
            image.ImageUrl = $"{read[2].ToString()}";
            c2.Controls.Add(image);
            row.Cells.Add(c2);
            TableCell c3 = new TableCell();
            c3.Controls.Add(new LiteralControl($"{read[3].ToString()}"));
            row.Cells.Add(c3);
            TableCell c4 = new TableCell();
            c4.Controls.Add(new LiteralControl($"{read[4].ToString()}"));
            row.Cells.Add(c4);
            TableCell c5 = new TableCell();
            c5.Controls.Add(new LiteralControl($"{read[5].ToString()}"));
            row.Cells.Add(c5);
            TableCell c6 = new TableCell();
            c6.Controls.Add(new LiteralControl($"{read[6].ToString()}"));
            row.Cells.Add(c6);*/

            /*Image image = new Image();
            image.Height = 120;
            image.Width = 100;

            DataRow row = dt.NewRow();
            row["ID"] = read[0];
            row["productName"] = read[1];
            row["picture"] = File.ReadAllBytes($"{read[2]}");
            row["category"] = read[3];
            row["inventory"] = read[4];
            row["price"] = read[5];
            row["initdate"] = read[6];
            dt.Rows.Add(row);*/

            //}
            /*
            GridView1.DataSource = dt;
            GridView1.DataBind();
            connection.Close(); */


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer/CustomerDetail");
            //123
            //if (FileUpload1.PostedFile != null)
            //{
            //    //檢查副檔名 to do

            //    // File was sent
            //    HttpPostedFile myFile = FileUpload1.PostedFile;

            //    // Get size of uploaded file
            //    int nFileLen = myFile.ContentLength;

            //    if (FileUpload1.HasFile && nFileLen > 0)
            //    {
            //        string imgPath = Server.MapPath("/images/FileUpload/" + DateTime.Now.ToString("yyyy_MM_dd_hhmmss_sss") + ".jpg");
            //        FileUpload1.SaveAs(imgPath);
            //        Label8.Text = imgPath;
            //        MessageBox.Show("上傳成功");
            //    }
            //    else
            //    {
            //        MessageBox.Show("請選擇圖片檔案");
            //    }

            //}
            //else
            //{
            //    // No file
            //    MessageBox.Show("請選擇圖片檔案");
            //}
        }
    }
}