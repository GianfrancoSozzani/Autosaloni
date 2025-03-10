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
            txtCap.Text = DT.Rows[0]["CAP"].ToString();
            txtCitta.Text = DT.Rows[0]["Citta"].ToString();
            txtProvincia.Text = DT.Rows[0]["Provincia"].ToString();
        }

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        if ((String.IsNullOrEmpty(txtSalone.Text)) || (String.IsNullOrEmpty(txtCitta.Text)))
            
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('I campi Nome Salone e Città non possono essere vuoti');", true);
            return;
        }

        DB db = new DB();
        db.query = "SALONE_Controllo";
        db.cmd.Parameters.AddWithValue("@nomesalone", txtSalone.Text);
        db.cmd.Parameters.AddWithValue("@citta", txtCitta.Text);
        DataTable DT = new DataTable();
        DT = db.SQLselect();

        if ((int)DT.Rows[0]["CONTROLLO"] == 1)
        {
            // Mostra un avviso e interrompe l'operazione
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Salone già presente');", true);
            return;
        }


        DB db2 = new DB();
        db2.query = "SALONI_Update";
        db2.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));
        db2.cmd.Parameters.AddWithValue("@nomesalone", txtSalone.Text.Trim());
        db2.cmd.Parameters.AddWithValue("@indirizzo", txtIndirizzo.Text.Trim());
        db2.cmd.Parameters.AddWithValue("@cap", txtCap.Text);
        db2.cmd.Parameters.AddWithValue("@citta", txtCitta.Text.Trim());
        db2.cmd.Parameters.AddWithValue("@provincia", txtProvincia.Text);
        db2.SQLcommand();
        Response.Redirect("AutosaloniModifica.aspx");


    }
}