using System;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //controllo su utente in session
        if (String.IsNullOrEmpty(Session["USR"] as string))
        {
            Response.Redirect("Login.aspx");
        }
    }
}
