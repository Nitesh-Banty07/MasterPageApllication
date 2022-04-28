using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
namespace MasterPagetech
{
    public partial class Customers : System.Web.UI.Page
    {
        string conString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        { 
            try
            {
                if (Session["userEmail"] == null)
                {
                    Response.Redirect("login.aspx");
                }
                if (!IsPostBack)
                {
                    GetCustomersList();
                }
               
            }catch(Exception ex)
            {
                lblCustomerError.Text = ex.Message;
            }        
        }
        void GetCustomersList()
        {
            try
            {
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand command = new SqlCommand("Sb_ShowCustomersList", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }catch(Exception ex)
            {
                Response.Write(ex);
            }
            
        }

        protected void BtnSerch_Click(object sender, EventArgs e)
        {
            if (TxtSerch.Text != string.Empty)
            {

                try
                {
                    GridView2.Visible = true;
                    GridView1.Visible = false;
                    SqlConnection connection = new SqlConnection(conString);
                    connection.Open();
                    SqlCommand command = new SqlCommand("Sb_SerchCustomers", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@firstname", TxtSerch.Text);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    sd.Fill(dt);
                    connection.Close();
                    GridView2.DataSource = dt;
                    GridView2.DataBind();
                }
                catch (Exception ex)
                {
                    lblCustomerError.Text = ex.Message;

                }
            }
           
        }
        protected void PageIndexChange(object sender,GridViewPageEventArgs e)
        {
            try
            {
                GridView1.PageIndex = e.NewPageIndex;
                this.GetCustomersList();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView2, "Select$" + e.Row.RowIndex);
                    e.Row.ToolTip = "Click to select this row.";
                }
            }
            catch(Exception ex)
            {
                lblCustomerError.Text = ex.Message;
            }
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                foreach (GridViewRow row in GridView2.Rows)
                {
                    if (row.RowIndex == GridView2.SelectedIndex)
                    {
                        Response.Redirect("CustomerDeteail.aspx?id=" + row.Cells[0].Text.Trim() + "&FirstName=" + row.Cells[1].Text.Trim() + "&LastName=" + row.Cells[2].Text.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                lblCustomerError.Text = ex.Message;
            }
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                TxtSerch.Text = string.Empty;
                GridView2.Visible = false;
                GridView1.Visible = true;
                GetCustomersList();
            }
            catch(Exception ex)
            {
                lblCustomerError.Text = ex.Message;
            }
        }
    }
}