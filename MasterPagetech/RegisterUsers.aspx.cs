using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace MasterPagetech
{
    public partial class RegisterUsers : System.Web.UI.Page
    {
       
        string conString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void BtnRegister_Click(object sender, EventArgs e)
        {
        Customer user = new Customer();
           
            try
            {
                
                user.gender= RdMale.Checked ? RdMale.Text : RdFemale.Text;
                user.fname = TxtFname.Text;
                user.lname = TxtLname.Text;
                user.email = TxtEmail.Text;
                user.password = TxtPassword.Text;
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertCustomers", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter firstname = cmd.Parameters.Add("@firstname", SqlDbType.VarChar);
                firstname.Value = user.fname;
                SqlParameter lastname = cmd.Parameters.Add("@lastname", SqlDbType.VarChar);
                lastname.Value = user.lname;
                SqlParameter u_email = cmd.Parameters.Add("@email", SqlDbType.VarChar);
                u_email.Value = user.email;
                SqlParameter u_password = cmd.Parameters.Add("@customerpassword", SqlDbType.VarChar);
                u_password.Value = user.password;
                SqlParameter u_gender = cmd.Parameters.Add("@gender", SqlDbType.VarChar);
                u_gender.Value = user.gender;
                cmd.ExecuteNonQuery();
                connection.Close();
                TxtFname.Text = string.Empty;
                TxtLname.Text = string.Empty;
                TxtEmail.Text = string.Empty;
                TxtPassword.Text = string.Empty;
                TxtConfirmPass.Text = string.Empty;
                RdMale.Checked = false;
                RdFemale.Checked = false;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('succesfully inserted data');", true);
            }
            catch (Exception ex)
            {
                lblRegisterError.Text = ex.Message;


            }

        }

        
    }
}