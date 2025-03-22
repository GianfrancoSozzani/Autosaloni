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
            AUTOMOBILI a = new AUTOMOBILI();
            ddlClientiAcquisto.DataSource = a.AUTOMOBILI_ddlClienti();
            //indico come la ddl deve visualizzare i valori
            ddlClientiAcquisto.DataValueField = "K_Cliente";
            ddlClientiAcquisto.DataTextField = "NomeCognome";
            //aggiornamento ddl
            ddlClientiAcquisto.DataBind();

            //CARICAMENTO DROPDOWNLIST SALONI
            //collagmento a DB
            SALONI s = new SALONI();
            //eseguo query
            ddlSaloni.DataSource = s.SelectAll();
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
        AUTOMOBILI a = new AUTOMOBILI();
        a.K_Salone = int.Parse(ddlSaloni.SelectedValue);
        ddlResponsabile.DataSource = a.AUTOMOBILI_ddlResponabiliSalone();
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
        AUTOMOBILI a = new AUTOMOBILI();
        a.K_Salone = int.Parse(ddlSaloni.SelectedValue);
        ddlVenditore.DataSource = a.AUTOMOBILI_ddlVenditoriSalone();
        //indico come la ddl deve visualizzare i valori
        ddlVenditore.DataValueField = "K_Dipendente";
        ddlVenditore.DataTextField = "NomeCognome";
        //aggiornamento ddl
        ddlVenditore.DataBind();
    }

    protected void btnInserimento_Click(object sender, EventArgs e)
    {
        //controllo se i campi obbligatori sono vuoti
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

        //controllose dll hanno valori vuoti es. si è registrata una marca ma non si è ancora registrato un modello
        //oppure si è registrato un salone ma bisogna ancora asumere il personale 

        if (
            (!int.TryParse(ddlModelli.SelectedValue, out _)) || 
            (!int.TryParse(ddlResponsabile.SelectedValue, out _)) ||
            (!int.TryParse(ddlVenditore.SelectedValue, out _))
            )
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Campi obbligatori vuoti');", true);
            return;
        }


        //controllo che la data inserita sia valida come formato
        if (!DateTime.TryParse(txtDataAcquisto.Text, out _) && !String.IsNullOrEmpty(txtDataAcquisto.Text))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data non valida');", true);
            return;

        }
        //controllo che la data inserita non sia oltre la data corrente
        DateTime dataOdierna = DateTime.Now;

        if (DateTime.Parse(txtDataAcquisto.Text) > dataOdierna)
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
           txtKM.Text.Contains(" ") ||
           txtPrezzoAcquisto.Text.Contains(" ") ||
           (txtTarga.Text.Contains(" ") && !String.IsNullOrEmpty(txtTarga.Text))
          )
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati alfanumerici non validi);", true);
            return;

        }
        //controllo che il prezzo di acquisto sia valido
        if (!Decimal.TryParse(txtPrezzoAcquisto.Text, out _))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert(Il dato Prezzo d'acquisto inserito non é valido);", true);
            return;
        }

        //controllo che il chilometraggio sia valido
        if (!int.TryParse(txtKM.Text, out _))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert(Il dato Chilometraggio inserito non é valido);", true);
            return;
        }

        //CONTROLLLO CHE L'AUTO NON SIA GIà REGISTRATA
        //collagmento a DB
        AUTOMOBILI a = new AUTOMOBILI();
        a.Telaio = txtTelaio.Text;
        DataTable DT = new DataTable();
        DT = a.AUTOMOBILI_SelezionaAutomobile();

        if (DT.Rows.Count > 0) //ricordarsi di mettre (int) davanti
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Automobile già registrata');", true);
            return;
        }

        a.K_Modello = int.Parse(ddlModelli.SelectedValue);
        a.Stato = ddlStato.SelectedValue;
        a.Data_Acquisto = DateTime.Parse(txtDataAcquisto.Text);
        a.K_Cliente_Acquisto = int.Parse(ddlClientiAcquisto.SelectedValue);
        a.Prezzo_Acquisto = Decimal.Parse(txtPrezzoAcquisto.Text.Trim());
        a.K_Salone = int.Parse(ddlSaloni.SelectedValue);
        a.K_Responsabile = int.Parse(ddlResponsabile.SelectedValue);
        a.K_Venditore = int.Parse(ddlVenditore.SelectedValue);
        a.Alimentazione = ddlAlimentazione.SelectedValue;
        a.Colore = txtColori.Text.Trim();
        a.KM = int.Parse(txtKM.Text);
        a.Cambio = ddlCambio.SelectedValue;
        a.Targa = txtTarga.Text;
        a.Telaio = txtTelaio.Text;
        a.Condizione = txtCondizioni.Text.Trim();
        a.Optional = txtOptional.Text.Trim();

        a.Inserimento();

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




    protected void btnVendita_Click(object sender, EventArgs e)
    {
        //controllo se l'utente non ha selezionato nulla
        if (griglia.SelectedIndex == -1)
        {
            //in caso gli si rilascia un alert di erro
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Non hai selezionato nulla');", true);
            return;
        }

        //dichiaro una variabile per storare il valore di K_Salone
        // e gli dico che selezionando un record la variabile chiave assume il valore di k_Salone del recor selezionato
        string chiave = griglia.SelectedValue.ToString();
        //passare il dato chaive alla pagina per la modifica
        //inviare l'utente alla pagina di modifica
        Response.Redirect("Automobili_Vendita.aspx" + "?c=" + chiave);
    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        part3.Visible = true;
    }

    protected void griglia_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //tolgo visibiltà a K_Auto
        e.Row.Cells[1].Visible = false;
    }
}
