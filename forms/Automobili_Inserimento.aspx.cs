using System;
using System.Collections.Generic;
using System.Data;
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

    protected void btnInserimento_Click(object sender, EventArgs e)
    {

    }

    protected void CaricaDati()
    {
        DB database = new DB();
        database.query = "AUTOMOBILI_SelectAll";
        griglia.DataSource = database.SQLselect();
        griglia.DataBind();


       


    }

    protected void griglia_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_SelectResp_ClienteVendita";
        DataTable DT = new DataTable();
        DT = db.SQLselect();


        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            // Assuming you want to add a custom value based on some logic
            string customValue = DT.Rows[0]["Cognome_Responsabile"].ToString(); // Replace with your logic

            // Find the Label control in the TemplateField
            Label lblCustomValue = (Label)e.Row.FindControl("Cognome_Responsabile");
            if (lblCustomValue != null)
            {
                lblCustomValue.Text = customValue;
            }
        }
    }
}