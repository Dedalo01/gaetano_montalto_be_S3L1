using System;
using System.Configuration;

namespace webAppAspNet
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Clicked_Btn(object sender, EventArgs e)
        {
            name.Text = ConfigurationManager.AppSettings["firstName"];
            surname.Text = ConfigurationManager.AppSettings["lastName"];
        }
    }
}