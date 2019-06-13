using System;


namespace WebServiceApp
{
    public partial class WebServiceForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       // SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ContinentEntities"].ConnectionString);
        protected void btnclick_Click(object sender, EventArgs e)
        {
            MyService.WebService webService = new MyService.WebService();
            lblmsg.Text = webService.GetContinent(txtCountry.Text);
        }
    }
}