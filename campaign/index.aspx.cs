using System;
using System.Web.UI;

public partial class index : Page
{
    protected void Page_Init(object sender, EventArgs e)
    {

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Redirect("https://www.happybody.site/campaign/index.aspx");
    }
}
