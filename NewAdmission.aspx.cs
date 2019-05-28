using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {

        static string GetConneectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            return connectionString;
        }
        static SqlConnection GetConnection()
        {
            return new SqlConnection(GetConneectionString());
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack )
            {
                FillState();
                AffiliatedBoard();
                zonal();
            }
            
            
        }

        void FillState()
        {
            using (SqlConnection con = new SqlConnection("data source=LAPTOP-FBF5J7NV;initial catalog=gic; integrated security=true"))
            {
                using (SqlCommand com = new SqlCommand("Select * from state", con))
                {
                    con.Open();
                    SqlDataReader read = com.ExecuteReader();
                    DropDownList1.DataSource = read;
                    DropDownList1.DataTextField = "StateName";
                    DropDownList1.DataValueField = "Sid";
                    DropDownList1.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    string sqlQuery = "insert into School(SchoolName,Address,CityId,StateName,AffiliatedBoard,PinCode,ContactNumber,DateOfRegistration,ZonalId) values(@SchoolName,@Address,@CityId,@StateName,@AffiliatedBoard,@PinCode,@ContactNumber,@DateOfResignation,@ZonalId)";
                    com.Connection = con;
                    com.CommandText = sqlQuery;
                    com.Parameters.AddWithValue("@SchoolName", (TextBox1.Text));
                    com.Parameters.AddWithValue("@Address", TextBox2.Text);
                    com.Parameters.AddWithValue("@CityId", DropDownList2.SelectedValue);
                    com.Parameters.AddWithValue("@stateName", DropDownList1.SelectedValue);
                    com.Parameters.AddWithValue("@AffiliatedBoard", DropDownList3.SelectedValue);
                    com.Parameters.AddWithValue("@PinCode", Convert.ToInt32(TextBox6.Text));
                    com.Parameters.AddWithValue("@ContactNumber", TextBox7.Text);
                    com.Parameters.AddWithValue("@DateOfResignation", TextBox8.Text);
                    com.Parameters.AddWithValue("@ZonalId", DropDownList4.SelectedValue);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    Response.Write("Record Inserted");
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCity();
        }
        void FillCity()
        {
            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand com = new SqlCommand("Select * from city where sid=@sid", con))
                {

                    com.Parameters.AddWithValue("@sid", DropDownList1.SelectedValue);

                    con.Open();
                    SqlDataReader read = com.ExecuteReader();
                    DropDownList2.DataSource = read;
                    DropDownList2.DataTextField = "CityName";
                    DropDownList2.DataValueField = "CityId";
                    DropDownList2.DataBind();
                    con.Close();


                }
            }
        }
        void AffiliatedBoard()
        {
            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand com = new SqlCommand("Select * from AffiliatedBoard", con))
                {


                    con.Open();
                    SqlDataReader read = com.ExecuteReader();
                    DropDownList3.DataSource = read;
                    DropDownList3.DataTextField = "BoardName";
                    DropDownList3.DataValueField = "AffiliatedId";
                    DropDownList3.DataBind();
                    con.Close();


                }
            }
        }

        void zonal()
        {
            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand com = new SqlCommand("Select * from Zonal", con))
                {

                    //com.Parameters.AddWithValue("@ZonalId", DropDownList4.SelectedValue);

                    con.Open();
                    SqlDataReader read = com.ExecuteReader();
                    DropDownList4.DataSource = read;
                    DropDownList4.DataTextField = "ZoneName";
                    DropDownList4.DataValueField = "ZonalId";
                    DropDownList4.DataBind();
                    con.Close();


                }
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}

    