using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Default2 : System.Web.UI.Page
{
     static string chiave;
    protected void Page_Load(object sender, EventArgs e)

    {
        // popolo la griglia
        CaricaDati();

    }

    protected void CaricaDati()
    {
        
        {
            DB database = new DB();
            database.query = "MARCHE_SelectAll";
            griglia.DataSource = database.SQLselect();
            griglia.DataBind();
        }
    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        chiave = griglia.SelectedValue.ToString();

       

    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        if (griglia.SelectedIndex == -1)
        {
            return;
        }

        divmodifica.Visible = true;
        DB database = new DB();
        database.query = "MARCHE_SelezionaChiave";
        database.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));

        DataTable DT = new DataTable();
        DT = database.SQLselect();
        txtMarca.Text = DT.Rows[0]["Marca"].ToString();




    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        

        DB database = new DB();
        database.query = "MARCHE_Update";
        database.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));
        database.cmd.Parameters.AddWithValue("@marca", txtMarca.Text);

        database.SQLcommand();
        CaricaDati();
        divmodifica.Visible = false;
    }
}