using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //dichiaro una variabile per storare il valore passato dll'altra pagina per k_cliente
    static string chiave;
    int provaCAP;
    protected void Page_Load(object sender, EventArgs e)
    {
        //metto un !postback per eviatre che quando l'utente clicca aggiorna rimanga in memoria il valore caricato all'apertura
        //della pagina e non quello riscritto ex novo per la modifica
        if (!IsPostBack)
        {
            //chiave assumerà il valore c che ricevo dalla pagina Clienti_Modifica
            chiave = Request.QueryString["c"].ToString();

            //inserisco la marca selezionata nell'altra pagina (cioè in base a c) dentro il textbox

            //collegarmi al database
            CLIENTI c = new CLIENTI();
            c.K_Cliente = int.Parse(chiave);
            //creare la datatable
            DataTable DT = new DataTable();
            DT = c.SelezionaChiave();
            //riempio il textbox
            txtCognome.Text = DT.Rows[0]["Cognome"].ToString();
            txtNome.Text = DT.Rows[0]["Nome"].ToString();
            txtCodiceFiscale.Text = DT.Rows[0]["Codice_Fiscale"].ToString();
            txtCitta.Text = DT.Rows[0]["Citta"].ToString();
            txtProvincia.Text = DT.Rows[0]["Provincia"].ToString();
            txtIndirizzo.Text = DT.Rows[0]["Indirizzo"].ToString();
            txtCAP.Text = DT.Rows[0]["CAP"].ToString();
            txtPatente.Text = DT.Rows[0]["Codice_Patente"].ToString();
            txtDataNascita.Text = DT.Rows[0]["Data_di_Nascita"].ToString();
        }
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        //controlli formali

        //controlo che l'utente abbia effettivamente scritto qualcosa
        if (String.IsNullOrEmpty(txtCognome.Text) ||
            String.IsNullOrEmpty(txtNome.Text) ||
            String.IsNullOrEmpty(txtCodiceFiscale.Text) ||
            String.IsNullOrEmpty(txtPatente.Text) ||
            String.IsNullOrEmpty(txtDataNascita.Text)
            )
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati Mancanti');", true);
            return;
        }

        //controllo che il codice fiscale e la patente siano completi (16 e 10 simboli alfanumerici)
        if (txtCodiceFiscale.Text.Length != 16)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Codice Fiscale non valido');", true);
            return;
        }
        if (txtPatente.Text.Length != 10)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Codice Patente non valido');", true);
            return;
        }

        //controllo che il CAP o la provincia siano scritti correttamente come formato nel caso non li si aggiorni a vuoto
        if (!int.TryParse(txtCAP.Text, out provaCAP))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('CAP non valido');", true);
            return;

        }


        if (txtCAP.Text.Length != 5 && !String.IsNullOrEmpty(txtCAP.Text))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('CAP non valido');", true);
            return;
        }
        if (txtProvincia.Text.Length != 2 && !String.IsNullOrEmpty(txtProvincia.Text))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('provincia non valida');", true);
            return;
        }

        //controllo che non ci siano dentro sapzi nei campi alfanumerici
        if (
            txtCodiceFiscale.Text.Contains(" ") ||
            txtPatente.Text.Contains(" ") ||
            (txtCAP.Text.Contains(" ") && !String.IsNullOrEmpty(txtCAP.Text)) ||
            (txtProvincia.Text.Contains(" ") && !String.IsNullOrEmpty(txtProvincia.Text))
           )
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati alfanumerici non validi);", true);
            return;
        }

        //controllo che la data inserita sia valida come formato e la converto nel formato senza orario come in sql server (yyyy-mm-dd)
        if (!DateTime.TryParse(txtDataNascita.Text, out _) && !String.IsNullOrEmpty(txtDataNascita.Text))
        {

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data non valida');", true);
            return;
        }

        //controllo che la data inserita non sia oltre la data corrente
        DateTime dataOdierna = DateTime.Now;

        if (DateTime.Parse(txtDataNascita.Text) > dataOdierna)
        {

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('La data inserita supera la data corrente ');", true);
            return;
        }

        //controllo che il cliente abbi al maggiore età
        //periodo di tempo uguale alla differenza
        TimeSpan ts = dataOdierna - DateTime.Parse(txtDataNascita.Text);

        if (ts.TotalDays < (18 * 365))
        {

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Il cliente non è legalmente idoneo alla guida');", true);
            return;
        }

        //controllo che non ci siano clienti doppi 
        CLIENTI c = new CLIENTI();
        c.K_Cliente = int.Parse(chiave);
        c.Codice_Fiscale = txtCodiceFiscale.Text;
        c.Codice_Patente = txtPatente.Text;

        //creare la datatable
        DataTable DT = new DataTable();
        DT = c.CheckRedundantRecords();

        if (DT.Rows.Count >0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Cliente già presente');", true);
            return;
        }

        //Update

        //collegamento al database
        c.Cognome = txtCognome.Text.Trim();
        c.Nome = txtNome.Text.Trim();
        c.Citta = txtCitta.Text.Trim();
        c.CAP = txtCAP.Text;
        c.Provincia = txtProvincia.Text;
        c.Indirizzo = txtIndirizzo.Text.Trim();
        c.Data_di_Nascita = DateTime.Parse(txtDataNascita.Text.Trim());

        c.Modifica();
 

        //ritorno a Marche_Modifica
        Response.Redirect("Clienti_Modifica.aspx");
    }
}