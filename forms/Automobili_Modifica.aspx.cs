using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CaricaDati();
    }
    protected void CaricaDati()
    {
        AUTOMOBILI a = new AUTOMOBILI();
        griglia.DataSource = a.SelectAll();
        griglia.DataBind();
    }




    protected void griglia_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //tolgo visibiltà a K_Auto
        e.Row.Cells[1].Visible = false;
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        if (griglia.SelectedIndex == -1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Non hai selezionato nulla');", true);
            return;
        }

        string chiave = griglia.SelectedValue.ToString();
        Response.Redirect("Automobili_Modifica2.aspx" + "?c=" + chiave);
    }
}
