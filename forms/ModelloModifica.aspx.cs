using System;
using System.Collections.Generic;
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
            database.query = "MODELLI_SelectAll";
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
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Seleziona un record');", true);
            return;
        }


        divmodifica.Visible = true;
        DB database = new DB();
        database.query = "MARCHE_SelectAll";
        ddlMarche.DataSource = database.SQLselect();
        ddlMarche.DataValueField = "K_Marca";
        ddlMarche.DataTextField = "Marca";
        ddlMarche.DataBind();

        database.query = "MODELLO_SelezionaChiave";
        database.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));

        DataTable DT = new DataTable();
        DT = database.SQLselect();
        txtModello.Text = DT.Rows[0]["Modello"].ToString();
        ddlMarche.SelectedValue = DT.Rows[0]["K_Marca"].ToString();
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtModello.Text))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Il campo Modello non può essere vuoto');", true);
            return;
        }

        DB db = new DB();
        db.query = "MODELLO_Controllo";
        db.cmd.Parameters.AddWithValue("@chiavemodello", int.Parse(chiave));
        db.cmd.Parameters.AddWithValue("@chiavemarca", int.Parse(ddlMarche.SelectedValue));
        db.cmd.Parameters.AddWithValue("@modello", txtModello.Text);
        DataTable DT = new DataTable();
        DT = db.SQLselect();

        if ((int)DT.Rows[0]["CONTROLLO"] == 1)
        {
            // Mostra un avviso e interrompe l'operazione
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Modello già presente');", true);
            return;
        }

        DB db2 = new DB();
        db2.query = "MODELLI_Update";
        db2.cmd.Parameters.AddWithValue("@chiavemodello", int.Parse(chiave));
        db2.cmd.Parameters.AddWithValue("@modello", txtModello.Text.Trim());
        db2.cmd.Parameters.AddWithValue("@chiavemarca", ddlMarche.SelectedValue);

        db2.SQLcommand();
        CaricaDati();
        divmodifica.Visible = false;
    }
}