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
        if (!IsPostBack)
        {
            //CARICAMENTO DROPDOWNLIST MARCHE
            //collagmento a DB
            DB database = new DB();
            //eseguo query
            database.query = "Marche_SelectAll";
            ddlMarche.DataSource = database.SQLselect();
            //indico come la ddl deve visualizzare i valori
            ddlMarche.DataValueField = "K_Marca";
            ddlMarche.DataTextField = "Marca";
            //aggiornamento ddl
            ddlMarche.DataBind();

            //ddl modelli
            CaricaModelli();


            // Popola la dropdown solo al primo caricamento della pagina
            // Aggiungi la voce "N"
            ddlStato.Items.Add(new ListItem("Nuova", "N")); // Testo visualizzato, Valore effettivo
            // Aggiungi la voce "U"
            ddlStato.Items.Add(new ListItem("Usata", "U")); // Testo visualizzato, Valore effettivo

            //CARICAMENTO DROPDOWNLIST CLIENTIACQUISTO
            //collagmento a DB
            DB db = new DB();
            //eseguo query
            db.query = "CLIENTI_DatiAnagraficiClienteAcquisto";
            ddlClientiAcquisto.DataSource = db.SQLselect();
            //indico come la ddl deve visualizzare i valori
            ddlClientiAcquisto.DataValueField = "K_Cliente";
            ddlClientiAcquisto.DataTextField = "NomeCognome";
            //aggiornamento ddl
            ddlClientiAcquisto.DataBind();

            //CARICAMENTO DROPDOWNLIST SALONI
            //collagmento a DB
            DB x = new DB();
            //eseguo query
            x.query = "SALONI_SelectAll";
            ddlSaloni.DataSource = x.SQLselect();
            //indico come la ddl deve visualizzare i valori
            ddlSaloni.DataValueField = "K_Salone";
            ddlSaloni.DataTextField = "Nome_Salone";
            //aggiornamento ddl
            ddlSaloni.DataBind();

            //CARICAMENTO DROPDOWNLIST RESPONSABILI
            //collagmento a DB
            DB database2 = new DB();
            //eseguo query
            database2.query = "DIPENDENTI_ResponsabiliDatiAnagrafici";
            ddlResponsabile.DataSource = database2.SQLselect();
            //indico come la ddl deve visualizzare i valor
            ddlResponsabile.DataValueField = "K_Dipendente";
            ddlResponsabile.DataTextField = "NomeCognome";
            //aggiornamento ddl
            ddlResponsabile.DataBind();

            //CARICAMENTO DROPDOWNLIST VEBDITORI
            //collagmento a DB
            DB database3 = new DB();
            //eseguo query
            database3.query = "DIPENDENTI_VenditoriDatiAnagrafici";
            ddlVenditore.DataSource = database3.SQLselect();
            //indico come la ddl deve visualizzare i valor
            ddlVenditore.DataValueField = "K_Dipendente";
            ddlVenditore.DataTextField = "NomeCognome";
            //aggiornamento ddl
            ddlVenditore.DataBind();

            // lista carburanti
            
            ddlAlimentazione.Items.Add(new ListItem("benzina", "benzina")); // Testo visualizzato, Valore effettivo
            ddlAlimentazione.Items.Add(new ListItem("gasolio", "gasolio")); // Testo visualizzato, Valore effettivo
            ddlAlimentazione.Items.Add(new ListItem("ibrido-benzina", "ibrido-benzina")); // Testo visualizzato, Valore effettivo
            ddlAlimentazione.Items.Add(new ListItem("ibrido-gasolio", "ibrido-gasolio")); // Testo visualizzato, Valore effettivo
            ddlAlimentazione.Items.Add(new ListItem("idrogeno", "idrogeno")); // Testo visualizzato, Valore effettivo
            ddlAlimentazione.Items.Add(new ListItem("elettrico", "elettrico")); // Testo visualizzato, Valore effettivo
            ddlAlimentazione.Items.Add(new ListItem("metano", "metano")); // Testo visualizzato, Valore effettivo

            // lista cambi

            ddlCambio.Items.Add(new ListItem("automatico", "automatico")); // Testo visualizzato, Valore effettivo
            ddlCambio.Items.Add(new ListItem("manuale", "manuale")); // Testo visualizzato, Valore effettivo
            ddlCambio.Items.Add(new ListItem("sequenzale", "sequenzale")); // Testo visualizzato, Valore effettivo

        }
    }
    protected void CaricaDati()
    {
        DB database = new DB();
        database.query = "AUTOMOBILI_SelectAll";
        griglia.DataSource = database.SQLselect();
        griglia.DataBind();
       
    }
    protected void ddlMarche_SelectedIndexChanged(object sender, EventArgs e)
    {
        CaricaModelli();
    }

    protected void CaricaModelli()
    {
        //CARICAMENTO DROPDOWNLIST GENERALE
        //collagmento a DB
        DB db = new DB();
        //eseguo query
        db.query = "MODELLI_Selectddl";
        db.cmd.Parameters.AddWithValue("@marca", ddlMarche.SelectedValue);
        DataTable DT = new DataTable();
        DT = db.SQLselect();
        ddlModelli.DataSource = DT;
        //indico come la ddl deve visualizzare i valori
        ddlModelli.DataValueField = "K_Modello";
        ddlModelli.DataTextField = "Modello";
        //aggiornamento ddl
        ddlModelli.DataBind();
    }
    protected void btnInserimento_Click(object sender, EventArgs e)
    {
        DB db = new DB();
        //eseguo query
        db.query = "AUTOMOBILI_Inserimento";
        db.cmd.Parameters.AddWithValue("@modello", ddlModelli.SelectedValue);
        db.cmd.Parameters.AddWithValue("@stato", ddlStato.SelectedValue);
        db.cmd.Parameters.AddWithValue("@data_acquisto", DateTime.Parse(txtDataAcquisto.Text));
        db.cmd.Parameters.AddWithValue("@cliente_acquisto", ddlClientiAcquisto.SelectedValue);
        db.cmd.Parameters.AddWithValue("@prezzo_acquisto", Decimal.Parse(txtPrezzoAcquisto.Text.Trim()));
        db.cmd.Parameters.AddWithValue("@salone", ddlSaloni.SelectedValue);
        db.cmd.Parameters.AddWithValue("@responsabile", ddlResponsabile.SelectedValue);
        db.cmd.Parameters.AddWithValue("@venditore", ddlVenditore.SelectedValue);
        db.cmd.Parameters.AddWithValue("@alimentazione", ddlAlimentazione.SelectedValue);
        db.cmd.Parameters.AddWithValue("@colore", txtColori.Text.Trim());
        db.cmd.Parameters.AddWithValue("@km", int.Parse(txtKM.Text.Trim()));
        db.cmd.Parameters.AddWithValue("@cambio", ddlCambio.SelectedValue);
        db.cmd.Parameters.AddWithValue("@targa", txtTarga.Text.Trim());
        db.cmd.Parameters.AddWithValue("@telaio", txtTelaio.Text.Trim());
        db.cmd.Parameters.AddWithValue("@condizione", txtCondizioni.Text.Trim());
        db.cmd.Parameters.AddWithValue("@optional", txtOptional.Text.Trim());

        //eseguo il comando di update
        db.SQLCommand();

        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Automobiloe registrata correttamente');", true);

        //svuoto campi di inserimento
        txtDataAcquisto.Text = "";
        txtPrezzoAcquisto.Text = "";
        txtColori.Text = "";
        txtTarga.Text = "";
        txtTelaio.Text = "";
        txtCondizioni.Text = "";
        txtOptional.Text = "";
        //ricarico la griglia
        CaricaDati();

    }
}