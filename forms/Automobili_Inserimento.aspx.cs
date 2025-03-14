using System;
using System.Data;
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

            //CARICAMENTO DROPDOWNLIST RESPONSABILI
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

        }
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
}