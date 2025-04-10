using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogApp.Blog
{
    public partial class CreateBlog : System.Web.UI.Page
    {

        string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BlogApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection=True;";
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtContent_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into AddBlog (Category, Author, Title, Content, Image) values (@category, @author, @title, @content, @image)", con);
            cmd.Parameters.AddWithValue("@category", txtCategory.Text);
            cmd.Parameters.AddWithValue("@author", txtAuthor.Text);
            cmd.Parameters.AddWithValue("@title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@content", txtContent.Text);
            string strImage = System.IO.Path.GetFileName(image.PostedFile.FileName);
            cmd.Parameters.AddWithValue("@image", strImage);
            cmd.ExecuteNonQuery();
            lblMessage.Text = "Blog Created Successfully";
            con.Close();
            image.PostedFile.SaveAs(Server.MapPath("~/images/") + strImage);

            txtCategory.Text = null;
            txtAuthor.Text = null;
            txtTitle.Text = null;
            txtContent.Text = null;
        }
    }
}