using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Default2 : System.Web.UI.Page
{
    // dichiaro la variabile
    static string chiave;
    protected void Page_Load(object sender, EventArgs e)
    {
        // recupero la chiave come parametro
        chiave = Request.QueryString["c"].ToString();

        // dico di non ricaricare la pagine
        if (!IsPostBack)
        {
            DB db = new DB();
            db.query = "SALONE_SelezionaChiave";
            db.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));
            DataTable DT = new DataTable();
            DT = db.SQLselect();
            txtSalone.Text = DT.Rows[0]["Nome_Salone"].ToString();
            txtIndirizzo.Text = DT.Rows[0]["Indirizzo"].ToString();
            txtCAP.Text = DT.Rows[0]["CAP"].ToString();
            txtCitta.Text = DT.Rows[0]["Citta"].ToString();
            txtProvincia.Text = DT.Rows[0]["Provincia"].ToString();
        }

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        DB db = new DB();
        db.query = "SALONI_Update";
        db.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));
        db.cmd.Parameters.AddWithValue("@nomesalone", txtSalone.Text.Trim());
        db.cmd.Parameters.AddWithValue("@indirizzo", txtIndirizzo.Text.Trim());
        db.cmd.Parameters.AddWithValue("@cap", txtCAP.Text);
        db.cmd.Parameters.AddWithValue("@citta", txtCitta.Text.Trim());
        db.cmd.Parameters.AddWithValue("@provincia", txtProvincia.Text);
        db.SQLcommand();
        Response.Redirect("AutosaloniModifica.aspx");


    }
}