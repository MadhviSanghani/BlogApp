using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static BlogApp.Blog.Food;

namespace BlogApp.Blog
{
    public partial class Food : System.Web.UI.Page
    {
        //protected Repeater repeaterData; // Ensure this is declared
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<DataRowInfo> data = DisplayDetailsFromDatabase();
                repeaterData.DataSource = data;
                repeaterData.DataBind();
            }
        }

        protected void repeaterData_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        private List<DataRowInfo> DisplayDetailsFromDatabase()
        {
            List<DataRowInfo> data = new List<DataRowInfo>();
            string con = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BlogApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection=True;";
            string query = "SELECT Title, Author, Image, Content FROM AddBlog where Category='Food'";

            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataRowInfo row = new DataRowInfo();
                            row.Title = reader["Title"].ToString();
                            row.Author = reader["Author"].ToString();
                            row.Image = reader["Image"].ToString();
                            row.Content = reader["Content"].ToString();
                            data.Add(row);
                        }
                    }
                }
            }
            return data;
        }

        public class DataRowInfo
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Image { get; set; }
            public string Content { get; set; }
        }
    }
}