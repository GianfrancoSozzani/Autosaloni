using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            MARCHE m = new MARCHE();
            ddlMarche.DataSource = m.SelectAll();
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
            CaricaResponsabili();

            //CARICAMENTO DROPDOWNLIST VENDITORI
            CaricaVenditori();
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
        AUTOMOBILI a = new AUTOMOBILI();
        griglia.DataSource = a.SelectAll();
        griglia.DataBind();
    }
    protected void ddlMarche_SelectedIndexChanged(object sender, EventArgs e)
    {
        CaricaModelli();
    }

    protected void ddlSaloni_SelectedIndexChanged(object sender, EventArgs e)
    {
        CaricaResponsabili();
        CaricaVenditori();
    }

    protected void CaricaModelli()
    {
        //CARICAMENTO DROPDOWNLIST GENERALE
        //collagmento a DB
        AUTOMOBILI a = new AUTOMOBILI();
        a.K_Marca = int.Parse(ddlMarche.SelectedValue);
        ddlModelli.DataSource = a.AUTOMOBILI_ddlModelli();
        //indico come la ddl deve visualizzare i valori
        ddlModelli.DataValueField = "K_Modello";
        ddlModelli.DataTextField = "Modello";
        //aggiornamento ddl
        ddlModelli.DataBind();
    }

    protected void CaricaResponsabili()
    {
        //CARICAMENTO DROPDOWNLIST GENERALE
        //collagmento a DB
        DB r = new DB();
        //eseguo query
        r.query = "DIPENDENTI_ResponsabiliSalone";
        r.cmd.Parameters.AddWithValue("@salone", ddlSaloni.SelectedValue);
        DataTable DT = new DataTable();
        DT = r.SQLselect();
        ddlResponsabile.DataSource = DT;
        //indico come la ddl deve visualizzare i valori
        ddlResponsabile.DataValueField = "K_Dipendente";
        ddlResponsabile.DataTextField = "NomeCognome";
        //aggiornamento ddl
        ddlResponsabile.DataBind();
    }

    protected void CaricaVenditori()
    {
        //CARICAMENTO DROPDOWNLIST GENERALE
        //collagmento a DB
        DB r = new DB();
        //eseguo query
        r.query = "DIPENDENTI_VenditoriSalone";
        r.cmd.Parameters.AddWithValue("@salone", ddlSaloni.SelectedValue);
        DataTable DT = new DataTable();
        DT = r.SQLselect();
        ddlVenditore.DataSource = DT;
        //indico come la ddl deve visualizzare i valori
        ddlVenditore.DataValueField = "K_Dipendente";
        ddlVenditore.DataTextField = "NomeCognome";
        //aggiornamento ddl
        ddlVenditore.DataBind();
    }




    protected void btnInserimento_Click(object sender, EventArgs e)
    {
        DateTime Day;

        //controllo campi vuoti
        if (
            String.IsNullOrEmpty(txtDataAcquisto.Text) ||
            String.IsNullOrEmpty(txtPrezzoAcquisto.Text) ||
            String.IsNullOrEmpty(txtTelaio.Text) ||
            String.IsNullOrEmpty(txtKM.Text)
            )
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Campi obbligatori vuoti');", true);
            return;
        }

        //controllo che la data inserita sia valida come formato
        if (DateTime.TryParse(txtDataAcquisto.Text, out Day) && !String.IsNullOrEmpty(txtDataAcquisto.Text))
        {
            Day = Day.Date;

        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data non valida');", true);
            return;
        }
        //controllo che la data inserita non sia oltre la data corrente
        DateTime dataOdierna = DateTime.Now;

        if (Day > dataOdierna)
        {

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('La data inserita supera la data corrente ');", true);
            return;
        }

        //controllo che il telaio sia valido
        if (txtTelaio.Text.Length != 17)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('VIN');", true);
            return;
        }

        if (
           txtTelaio.Text.Contains(" ") ||
           (txtTarga.Text.Contains(" ") && !String.IsNullOrEmpty(txtTarga.Text))
          )
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati alfanumerici non validi);", true);
            return;

        }


        //CONTROLLLO CHE L'AUTO NON SIA GIà REGISTRATA
        //collagmento a DB
        DB c = new DB();
        //eseguo query
        c.query = "AUTOMOBILI_ControlloDuplicati";
        c.cmd.Parameters.AddWithValue("@vin", txtTelaio.Text.Trim());
        DataTable DT = new DataTable();
        DT = c.SQLselect();

        if ((int)DT.Rows[0]["QUANTI"] == 1) //ricordarsi di mettre (int) davanti
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Automobile già registrata');", true);
            return;
        }


        DB db = new DB();
        //eseguo query
        db.query = "AUTOMOBILI_Inserimento";
        db.cmd.Parameters.AddWithValue("@modello", ddlModelli.SelectedValue);
        db.cmd.Parameters.AddWithValue("@stato", ddlStato.SelectedValue);
        db.cmd.Parameters.AddWithValue("@data_acquisto", txtDataAcquisto.Text);
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

        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Automobile registrata correttamente');", true);

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
