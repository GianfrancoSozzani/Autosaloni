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
        CaricaDati();
    }

    private void CaricaDati()
    {
        DB db = new DB();
        db.query = "CLIENTI_SelectAll";
        griglia.DataSource = db.SQLselect();
        griglia.DataBind();

    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        chiave = griglia.SelectedValue.ToString();
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        if(griglia.SelectedIndex == -1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Seleziona un record');", true);
            return;
        }

        divmodifica.Visible = true;
        DB database = new DB();
        database.query = "CLIENTE_SelezionaChiave";
        database.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));

        DataTable DT = new DataTable();
        DT = database.SQLselect();
        txtCognome.Text = DT.Rows[0]["Cognome"].ToString();
        txtNome.Text = DT.Rows[0]["Nome"].ToString();
        txtCodFis.Text = DT.Rows[0]["Codice_Fiscale"].ToString();
        txtIndirizzo.Text = DT.Rows[0]["Indirizzo"].ToString();
        txtCap.Text = DT.Rows[0]["CAP"].ToString();
        txtCitta.Text = DT.Rows[0]["Citta"].ToString();
        txtProvincia.Text = DT.Rows[0]["Provincia"].ToString();
        txtCodPat.Text = DT.Rows[0]["Codice_Patente"].ToString();
        txtDataNascita.Text = DT.Rows[0]["Data_di_Nascita"].ToString();
        

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        DB db = new DB();
        db.query = "CLIENTI_Update";
        db.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));
        db.cmd.Parameters.AddWithValue("@cognome", txtCognome.Text.Trim());
        db.cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
        db.cmd.Parameters.AddWithValue("@codicefiscale", txtCodFis.Text);
        db.cmd.Parameters.AddWithValue("@indirizzo", txtIndirizzo.Text.Trim());
        db.cmd.Parameters.AddWithValue("@cap", txtCap.Text);
        db.cmd.Parameters.AddWithValue("@citta", txtCitta.Text.Trim());
        db.cmd.Parameters.AddWithValue("@provincia", txtProvincia.Text);
        db.cmd.Parameters.AddWithValue("@codicepatente", txtCodPat.Text);
        db.cmd.Parameters.AddWithValue("@datanascita", txtDataNascita.Text);
       

        db.SQLcommand();
        CaricaDati();
        divmodifica.Visible = false;
    }
}