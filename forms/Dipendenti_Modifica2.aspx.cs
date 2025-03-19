using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //dichiaro una variabile per storare il valore passato dll'altra pagina per k_dipendente
    static string chiave;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            // Popola la dropdown solo al primo caricamento della pagina
            // Aggiungi la voce "V"
            ddlRuoli.Items.Add(new ListItem("Venditore", "V")); // Testo visualizzato, Valore effettivo
            // Aggiungi la voce "R"
            ddlRuoli.Items.Add(new ListItem("Responsabile", "R")); // Testo visualizzato, Valore effettivo

            //chiave assumerà il valore c che ricevo dalla pagina Dipendenti_Modifica
            chiave = Request.QueryString["c"].ToString();

            //CARICAMENTO DROPDOWNLIST GENERALE
            SALONI s = new SALONI();
            ddlSaloni.DataSource = s.SelectAll();
            ddlSaloni.DataValueField = "K_Salone";
            ddlSaloni.DataTextField = "Nome_Salone";
            //indico come la ddl deve visualizzare i valori
            //aggiornamento ddl
            ddlSaloni.DataBind();

            //CARICO VALORI SELEZIONATI NELLA DDL(saloni) e nel TEXTBOX(Nome,Cognome) in base ai valori scelti nella pagina di partenza
            //collegamento database
            DIPENDENTI d = new DIPENDENTI();
            d.K_Dipendente = int.Parse(chiave);
            DataTable DT = new DataTable();
            DT = d.SelezionaChiave();
            //valore ddl (saloni)
            ddlSaloni.SelectedValue = DT.Rows[0]["K_Salone"].ToString();
            //valore ddl (ruoli)
            ddlRuoli.SelectedValue = DT.Rows[0]["Ruolo"].ToString();
            //valore in textbox (cognome)
            txtCognome.Text = DT.Rows[0]["Cognome"].ToString();
            //valore in textbox (nome)
            txtNome.Text = DT.Rows[0]["Nome"].ToString();
            //valore in textbox (codice fiscale)
            txtCodiceFiscale.Text = DT.Rows[0]["Codice_Fiscale"].ToString();

        }
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        //controlli formali

        //controllo che l'utente abbia effettivamante scritto qualcosa
        if (String.IsNullOrEmpty(txtCognome.Text) ||
            String.IsNullOrEmpty(txtNome.Text) ||
            String.IsNullOrEmpty(txtCodiceFiscale.Text))

        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati non validi');", true);
            return;
        }

        //Controllo il contenuto scritto dall'utente

        //dimensione Codice Fiscale corretta
        if (txtCodiceFiscale.Text.Length != 16)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('CAP non valido');", true);
            return;
        }

        //se il codice fiscale contiene spzai
        if (txtCodiceFiscale.Text.Contains(" "))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati alfanumerici non validi);", true);
            return;
        }

        //creare la datatable
        DIPENDENTI d = new DIPENDENTI();
        d.K_Dipendente = int.Parse(chiave);
        d.Codice_Fiscale = txtCodiceFiscale.Text;
        DataTable DT = new DataTable();
        DT = d.CheckRedundantRecords();

        if (DT.Rows.Count >0) //ricordarsi di mettre (int) davanti
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dipendente già presente');", true);
            return;
        }

        d.Cognome = txtCognome.Text.Trim();
        d.Nome = txtNome.Text.Trim();
        d.Ruolo = ddlRuoli.SelectedValue;
        d.K_Salone = int.Parse(ddlSaloni.SelectedValue);

        d.Modifica();

        //ritorno a Marche_Modifica
        Response.Redirect("Dipendenti_Modifica.aspx");
    }
}