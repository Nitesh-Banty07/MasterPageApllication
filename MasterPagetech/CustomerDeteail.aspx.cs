using System;

namespace MasterPagetech
{
    public partial class CustomerDeteail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string id = Request.QueryString["Id"];
                string firstName = Request.QueryString["FirstName"];
                string lastName = Request.QueryString["LastName"];
                LblId.Text = id.ToString();
                LblFirstName.Text = firstName.ToString();
                LblLastName.Text = lastName.ToString();
            }catch(Exception ex)
            {
                lblCustDetError.Text = ex.Message;
            }

        }
    }
}