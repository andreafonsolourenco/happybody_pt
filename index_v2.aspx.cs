using System;
using System.Web.UI;

public partial class index_v2 : Page
{
    protected void Page_Init(object sender, EventArgs e)
    {

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Redirect("https://www.happybody.site/index_v2.aspx");
    }
}
