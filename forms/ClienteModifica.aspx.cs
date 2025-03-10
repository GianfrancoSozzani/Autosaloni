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

        // Assegna la sorgente dati alla griglia (ad esempio una GridView, DataGrid, ecc.)
        // Chiamiamo il metodo SQLselect() per recuperare i dati dal database e impostarli come DataSource

        // 'db' è un'istanza della classe DB che contiene il metodo SQLselect()
        // SQLselect() esegue una query SQL sul database e restituisce i risultati in un DataTable
        // In pratica, la query definita nell'oggetto 'db' viene eseguita, e i dati recuperati vengono immagazzinati in un DataTable

        // 'griglia' è il controllo UI che visualizzerà i dati (come una GridView, DataGrid, ecc.)
        // Assegniamo il risultato di SQLselect() come DataSource per il controllo griglia

        // Dopo che questa operazione è completata, la griglia sarà popolata con i dati restituiti dalla query SQL
     

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

        if ((String.IsNullOrEmpty(txtCognome.Text)) || (String.IsNullOrEmpty(txtNome.Text)) || (String.IsNullOrEmpty(txtIndirizzo.Text)))

        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('I campi Cognome, Nome e Indirizzo non possono essere vuoti');", true);
            return;
        }

        DB db = new DB();
        db.query = "CLIENTE_Controllo";
        db.cmd.Parameters.AddWithValue("@cognome", txtCognome.Text);
        db.cmd.Parameters.AddWithValue("@nome", txtNome.Text);
        db.cmd.Parameters.AddWithValue("@indirizzo", txtIndirizzo.Text);
        DataTable DT = new DataTable();
        DT = db.SQLselect();

        if ((int)DT.Rows[0]["CONTROLLO"] == 1)
        {
            // Mostra un avviso e interrompe l'operazione
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Cliente già presente');", true);
            return;
        }

        DB db2 = new DB();
        db2.query = "CLIENTI_Update";
        db2.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));
        db2.cmd.Parameters.AddWithValue("@cognome", txtCognome.Text.Trim());
        db2.cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
        db2.cmd.Parameters.AddWithValue("@codicefiscale", txtCodFis.Text);
        db2.cmd.Parameters.AddWithValue("@indirizzo", txtIndirizzo.Text.Trim());
        db2.cmd.Parameters.AddWithValue("@cap", txtCap.Text);
        db2.cmd.Parameters.AddWithValue("@citta", txtCitta.Text.Trim());
        db2.cmd.Parameters.AddWithValue("@provincia", txtProvincia.Text);
        db2.cmd.Parameters.AddWithValue("@codicepatente", txtCodPat.Text);
        db2.cmd.Parameters.AddWithValue("@datanascita", txtDataNascita.Text);
       

        db.SQLcommand();
        CaricaDati();
        divmodifica.Visible = false;
    }
}