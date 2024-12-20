using System;
using System.Web.UI;

public partial class index : Page
{
    protected void Page_Init(object sender, EventArgs e)
    {

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        string lingua = Request.QueryString["language"];
        string pagina = Request.QueryString["page"];
        string sound = Request.QueryString["sound"];
        string campaign = Request.QueryString["campaign"];
        string link = "https://www.happybody.site/happybody/index.aspx";
        string values = "";

        if (!String.IsNullOrEmpty(lingua) || !String.IsNullOrEmpty(pagina) || !String.IsNullOrEmpty(sound) || !String.IsNullOrEmpty(campaign))
        {
            values += "?";
            values = !String.IsNullOrEmpty(lingua) ? (values + "language=" + lingua) : (values);
            if (!String.IsNullOrEmpty(pagina)) values += "&";
            values = !String.IsNullOrEmpty(pagina) ? (values + "page=" + pagina) : (values);
            if (!String.IsNullOrEmpty(sound)) values += "&";
            values = !String.IsNullOrEmpty(sound) ? (values + "sound=" + sound) : (values);
            if (!String.IsNullOrEmpty(campaign)) values += "&";
            values = !String.IsNullOrEmpty(campaign) ? (values + "campaign=" + campaign) : (values);
        }

        link = link + values;

        Response.Redirect(link);
    }
}
