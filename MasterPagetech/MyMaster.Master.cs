using System;

namespace MasterPagetech
{
    public partial class MyMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userEmail"]!= null)
            {
                try
                {
                    PhNotLoggedIn.Visible = false;
                    PhLoggedIn.Visible = true;
                    LblHomeTitel.Text = Session["userEmail"].ToString();
                }
                catch(Exception ex)
                {
                    LblWarning.Text = ex.Message;
                }
                 
            }
            else
            {
                try
                {
                    LblHomeTitel.Text = "Guest Mode";
                }
                catch (Exception ex)
                {
                    LblHomeTitel.Text = ex.Message;
                }
            }

        }
       
        protected void Log_in_out(object sender, EventArgs e)
        {
            if (Session["userEmail"] == null)
                Response.Redirect("Login.aspx");
            else
            {
                try
                {
                    Session.Abandon();
                    Session.Clear();
                    Response.Redirect("Login.aspx");
                }catch(Exception ex)
                {
                    LblWarning.Text=ex.Message;

                }

            }
        }
       
    }
}