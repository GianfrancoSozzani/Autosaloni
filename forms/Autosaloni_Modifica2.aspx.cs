using System;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    //dichiaro una variabile per storare il valore passato dll'altra pagina per k_salone
    static string chiave;
    int provaCAP;
    protected void Page_Load(object sender, EventArgs e)
    {
        //metto un !postback per eviatre che quando l'utente clicca aggiorna rimanga in memoria il valore caricato all'apertura
        //della pagina e non quello riscritto ex novo per la modifica
        if (!IsPostBack)
        {
            //chiave assumerà il valore c che ricevo dalla pagina Autosaloni_Modifica
            chiave = Request.QueryString["c"].ToString();

            //inserisco la marca selezionata nell'altra pagina (cioè in base a c) dentro il textbox

            //collegarmi al database
            SALONI s = new SALONI();
            s.K_Salone = int.Parse(chiave);
            //creare la datatable
            DataTable DT = new DataTable();
            DT = s.SelezionaChiave();
            //riempio il textbox
            txtSalone.Text = DT.Rows[0]["Nome_Salone"].ToString();
            txtIndirizzo.Text = DT.Rows[0]["Indirizzo"].ToString();
            txtCAP.Text = DT.Rows[0]["CAP"].ToString();
            txtCitta.Text = DT.Rows[0]["Citta"].ToString();
            txtProvincia.Text = DT.Rows[0]["Provincia"].ToString();


        }
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        //controllo che l'utente abbia effettivamente scritto qualcosa
        if (String.IsNullOrEmpty(txtSalone.Text) ||
            String.IsNullOrEmpty(txtIndirizzo.Text) ||
            String.IsNullOrEmpty(txtCAP.Text) ||
            String.IsNullOrEmpty(txtCitta.Text) ||
            String.IsNullOrEmpty(txtProvincia.Text))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati non validi');", true);
            return;
        }
        //Controllo il contenuto scritto dall'utente

        //dimensione CAP

        if (!int.TryParse(txtCAP.Text, out provaCAP))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('CAP non valido');", true);
            return;

        }

        if (txtCAP.Text.Length != 5)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('CAP non valido');", true);
            return;
        }
        //dimesione Provincia
        if (txtProvincia.Text.Length != 2)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('provincia non valida');", true);
            return;
        }
        //se Provincia o CAP presentano spazi
        if (txtCAP.Text.Contains(" ") || txtProvincia.Text.Contains(" "))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati alfanumerici non validi);", true);
            return;
        }

        //controllo che non ci sia un autosalone con nome uguale
        SALONI s = new SALONI();
        s.K_Salone = int.Parse(chiave);
        s.Nome_Salone = txtSalone.Text.Trim();
        s.Indirizzo = txtIndirizzo.Text.Trim();
        s.CAP = txtCAP.Text;
        s.Citta = txtCitta.Text.Trim();
        s.Provincia = txtProvincia.Text;
        //creare la datatable
        DataTable DT = new DataTable();
        DT = s.CheckRedundantRecords();

        if (DT.Rows.Count > 0) //ricordarsi di mettre (int) davanti
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Autosalone già presente');", true);
            return;
        }

        //collegamento al database
        s.Modifica();

        //ritorno a Marche_Modifica
        Response.Redirect("Autosaloni_Modifica.aspx");
    }
}