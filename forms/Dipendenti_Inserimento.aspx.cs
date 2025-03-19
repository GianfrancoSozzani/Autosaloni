using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Caricadati();

        if (!IsPostBack)
        {
            // Popola la dropdown solo al primo caricamento della pagina
            // Aggiungi la voce "V"
            ddlRuoli.Items.Add(new ListItem("Venditore", "V")); // Testo visualizzato, Valore effettivo
            // Aggiungi la voce "R"
            ddlRuoli.Items.Add(new ListItem("Responsabile", "R")); // Testo visualizzato, Valore effettivo

            //CARICAMENTO DROPDOWNLIST GENERALE

            //saloni
            //collagmento a DB
            SALONI s = new SALONI();
            //eseguo query
            ddlSaloni.DataSource = s.SelectAll();
            ddlSaloni.DataValueField = "K_Salone";
            ddlSaloni.DataTextField = "Nome_Salone";
            ddlSaloni.DataBind();

        }
    }

    protected void btnInserimento_Click(object sender, EventArgs e)
    {
        //dichiaro le variabili di storage per i campi da inserire manualmente
        string cognomeDipendente = txtCognome.Text.Trim();
        string nomeDipendente = txtNome.Text.Trim();
        string codiceFiscale = txtCodiceFiscale.Text;


        //controlo che l'utente abbia effettivamente scritto qualcosa
        if (String.IsNullOrEmpty(cognomeDipendente) ||
            String.IsNullOrEmpty(nomeDipendente) ||
            String.IsNullOrEmpty(codiceFiscale)
            )
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati non validi');", true);
            return;
        }

        //controllo che il codice fiscale sia stato inserito correttamente
        if (txtCodiceFiscale.Text.Length != 16)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Codice Fiscale non valido');", true);
            return;
        }
        if (txtCodiceFiscale.Text.Contains(" "))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati alfanumerici non validi);", true);
            return;
        }




        //controllo che non ci siano dipendenti già registrati
        DIPENDENTI d = new DIPENDENTI();
        d.Cognome = txtCognome.Text.Trim();
        d.Codice_Fiscale = txtCodiceFiscale.Text;

    

        //creare la datatable
        DataTable DT = new DataTable();
        DT = d.SelezionaDipendente();

        if (DT.Rows.Count >0) //ricordarsi di mettre (int) davanti
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dipendente già presente');", true);
            return;
        }

        d.Nome = txtNome.Text.Trim();
        d.Ruolo = ddlRuoli.SelectedValue;
        d.K_Salone = int.Parse(ddlSaloni.SelectedValue);
        //Inserimento dipendente con autosalone associato
        //collegamento al database
        d.Inserimento();

        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dipendente registrato correttamente');", true);

        //svuoto campi di inserimento
        txtNome.Text = "";
        txtCognome.Text = "";
        txtCodiceFiscale.Text = "";
        //ricarico la griglia
        Caricadati();


    }

    protected void Caricadati()
    {
       DIPENDENTI d = new DIPENDENTI();
        griglia.DataSource = d.SelectAll();
        griglia.DataBind();
    }

    protected void griglia_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //tolgo visibiltà a K_Dipendente
        e.Row.Cells[0].Visible = false;
        //tolgo la visibilità a K_Salone
        e.Row.Cells[1].Visible = false;
    }
}