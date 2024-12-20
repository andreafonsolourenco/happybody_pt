using System;
using System.Web.UI;
using System.Configuration;
using System.Data;
using System.Text;
using System.Data.SqlClient;

public partial class welcome : Page
{
    string language = "";

    protected void Page_Init(object sender, EventArgs e)
    {

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            language = Request.QueryString["language"];
        }
        catch (Exception exc)
        {
            language = "FR";
        }

        string link = "https://www.happybody.site/happybody/welcome.aspx?language=" + language;

        Response.Redirect(link);
    }
}
