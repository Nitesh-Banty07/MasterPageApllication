using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MasterPagetech
{
    public partial class Login : System.Web.UI.Page
    {    
       
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["userEmail"]!=null)
                {
                    Response.Redirect("Customers.aspx");
                }
            }catch(Exception ex)
            {
                lblLoginError.Text = ex.Message;
            }
           
        }

        protected void UserAuth(object sender, EventArgs e)
        {
            AuthUser Auth = new AuthUser();
            try
            {   
                Auth.UserEmail = TxtEmail.Text;
                Auth.userPass = TxtPassword.Text;
                string conString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand comd = new SqlCommand("SP_ValidateUserCredentail", connection);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.AddWithValue("@email", Auth.UserEmail);
                comd.Parameters.AddWithValue("@password", Auth.userPass);
                int count = (int)comd.ExecuteScalar();
                connection.Close();
                if (count > 0)
                {
                    Session["userEmail"] = Auth.UserEmail;
                    Response.Redirect("Customers.aspx");
                }
                else
                {
                    ViewState["isEmail"] = TxtEmail.Text;
                    LblMassege.Text = "wrong password";
                    TxtEmail.Text = string.Empty;
                    TxtPassword.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void BtnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (ViewState["isEmail"] != null)
                    TxtEmail.Text = ViewState["isEmail"].ToString();
            }catch(Exception ex)
            {
                lblLoginError.Text=ex.Message;
            }
        }
    }
}