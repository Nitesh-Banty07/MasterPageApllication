using System;

namespace MasterPagetech
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userEmail"] != null)
            {
                try
                {
                    Session.Abandon();
                    Response.Redirect("Login.aspx");
                }catch(Exception ex)
                {
                   lblLogutError.Text=ex.Message;
                }
            }
        }
    }
}