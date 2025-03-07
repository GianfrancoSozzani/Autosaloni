using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // popolo la griglia
        CaricaDati();
    }

    protected void CaricaDati()
    {

        {
            DB database = new DB();
            database.query = "MODELLI_SelectAll";
            griglia.DataSource = database.SQLselect();
            griglia.DataBind();
        }
    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}