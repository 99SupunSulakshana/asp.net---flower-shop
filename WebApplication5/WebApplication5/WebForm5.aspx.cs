using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication5
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=DESKTOP-T9V5RSF;Initial Catalog=BlueLotus;Integrated Security=True";
            con.Open();
            if (!Page.IsPostBack)
            {
                DataShow();
            }
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            if (Text1.Text=="" || Text2.Text=="" || Text3.Text ==""|| Text7.Text=="")
            {
                Label1.Text = "PLEASE INSERT VALID DATA";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else 
            {
                dt = new DataTable();
                cmd.CommandText = "Insert into Orders(Name,Id,Country,Company,Flower,Buckets,Email,Act)values('" + Text1.Text.ToString() + "','" + Text2.Text.ToString() + "','" + Text3.Text.ToString() + "','" + Text4.Text.ToString() + "','" + Text5.Text.ToString() + "','" + Text6.Text.ToString() + "','" + Text7.Text.ToString() + "','" + Text8.Text.ToString() + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                Label1.Text = "DATA ADDED SUCCESSFULLY";
                Label1.ForeColor = System.Drawing.Color.Green;
                DataShow();
            }
        }
        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * From Orders ";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds); 
            cmd.ExecuteNonQuery();
            GridViews.DataSource = ds;
            GridViews.DataBind();
            con.Close();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            if (Text1.Text == "") 
            {
                Label1.Text = "PLEASE INSERT SELECTED VALUE";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else {
                dt = new DataTable();
                cmd.CommandText = "Update Orders set Id='" + Text2.Text.ToString() + "',Country='" + Text3.Text.ToString() + "',Company='" + Text4.Text.ToString() + "',Flower='" + Text5.Text.ToString() + "',Buckets='" + Text6.Text.ToString() + "',Email='" + Text7.Text.ToString() + "',Act='" + Text8.Text.ToString() + "' where Name='" + Text1.Text.ToString() + "'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                Label1.Text = "YOUR DETAILS UPDATED SUCCESSFULLY";
                Label1.ForeColor = System.Drawing.Color.Green;
                DataShow(); 
            }
           
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            if (Text1.Text == "")
            {
                Label1.Text = "PLEASE INSERT SELECTED VALUE";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {

                dt = new DataTable();
                cmd.CommandText = "Delete from Orders where Name='" + Text1.Text.ToString() + "'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                Label1.Text = "YOUR DETAILS DELETED SUCCESSFULLY";
                Label1.ForeColor = System.Drawing.Color.Red;
                DataShow();
            }
        }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            Text1.Text = "";
            Text2.Text = "";
            Text3.Text = "";
            Text4.Text = "";
            Text5.Text = "";
            Text6.Text = "";
            Text7.Text = "";
            Text8.Text = "";
         


        }
    }
}