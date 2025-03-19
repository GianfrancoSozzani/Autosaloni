using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Runtime.InteropServices.ComTypes;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CaricaDati();
    }

    protected void btnInserimento_Click(object sender, EventArgs e)
    {
        //dichiaro le variabili di storahe per l'inserimento dei dati del cliente
        string cognome_cliente = txtCognome.Text.Trim();
        string nome_cliente = txtNome.Text.Trim();
        string citta_cliente = txtCitta.Text.Trim();
        string codice_fiscale_cliente = txtCodiceFiscale.Text;
        string indirizzo_cliente = txtIndirizzo.Text.Trim();
        string CAP_cliente = txtCAP.Text;
        string provincia = txtProvincia.Text;
        string codice_patente_cliente = txtPatente.Text;
        string giorno_di_nascita = txtDataNascita.Text;

        //controlo che l'utente abbia effettivamente scritto qualcosa
        if (String.IsNullOrEmpty(cognome_cliente) ||
            String.IsNullOrEmpty(nome_cliente) ||
            String.IsNullOrEmpty(citta_cliente) ||
            String.IsNullOrEmpty(codice_fiscale_cliente) ||
            String.IsNullOrEmpty(CAP_cliente) ||
            String.IsNullOrEmpty(provincia) ||
            String.IsNullOrEmpty(codice_patente_cliente) ||
            String.IsNullOrEmpty(giorno_di_nascita)
            )
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati Mancanti');", true);
            return;
        }

        //controllo che la data inserita sia valida come formato e la converto nel formato senza orario come in sql server (yyyy-mm-dd)
        if (!DateTime.TryParse(giorno_di_nascita, out _) && !String.IsNullOrEmpty(giorno_di_nascita))
        {

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data non valida');", true);
            return;
        }
        //controllo che il codice fiscale e la patente siano completi (16 e 10 simboli alfanumerici)
        if (codice_fiscale_cliente.Length != 16)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Codice Fiscale non valido');", true);
            return;
        }
        if (codice_patente_cliente.Length != 10)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Codice Patente non valido');", true);
            return;
        }
        if (!int.TryParse(CAP_cliente, out _))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('CAP non valido');", true);
            return;

        }

        if (CAP_cliente.Length != 5)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('CAP non valido');", true);
            return;
        }
        if (provincia.Length != 2)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('provincia non valida');", true);
            return;
        }


        if (codice_fiscale_cliente.Contains(" ") || codice_patente_cliente.Contains(" ") || CAP_cliente.Contains(" ") || provincia.Contains(" "))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati alfanumerici non validi);", true);
            return;
        }

        //controllo che la data inserita non sia oltre la data corrente
        DateTime dataOdierna = DateTime.Now;

        if (DateTime.Parse(giorno_di_nascita) > dataOdierna)
        {

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('La data inserita supera la data corrente ');", true);
            return;
        }

        //controllo che il cliente abbi al maggiore età
        //periodo di tempo uguale alla differenza
        TimeSpan ts =  dataOdierna - DateTime.Parse(giorno_di_nascita) ;

        if (ts.TotalDays < (18 * 365))
        {

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Il cliente non è legalmente idoneo alla guida');", true);
            return;
        }

        //controllo che il cliente non sia già presente

        //controllo che non ci siano clienti già registrati
        CLIENTI c = new CLIENTI();
        c.Codice_Fiscale = codice_fiscale_cliente;
        c.Codice_Patente = codice_patente_cliente;
        //creare la datatable
        DataTable DT = new DataTable();
        DT = c.SelezionaCliente();

        if (DT.Rows.Count > 0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Cliente già registrato');", true);
            return;
        }

        //registro il cliente

        c.Cognome = cognome_cliente;
        c.Nome = nome_cliente;
        c.Citta = citta_cliente;
        c.CAP = CAP_cliente;
        c.Provincia = provincia;
        c.Indirizzo = indirizzo_cliente;
        c.Data_di_Nascita = DateTime.Parse(giorno_di_nascita);

        c.Inserimento();


        //messaggio di conferma registrazione

        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Cliente registarto correttamente');", true);


        //svuoto campi di inserimento

        txtCognome.Text = "";
        txtNome.Text = "";
        txtCitta.Text = "";
        txtCodiceFiscale.Text = "";
        txtIndirizzo.Text = "";
        txtCAP.Text = "";
        txtProvincia.Text = "";
        txtPatente.Text = "";
        txtDataNascita.Text = "";

        //ricarico la tabella
        CaricaDati();
    }

    protected void griglia_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //tolgo visibiltà a K_Cliente
        e.Row.Cells[0].Visible = false;
    }

    protected void CaricaDati()
    {
        CLIENTI c = new CLIENTI();
        griglia.DataSource = c.SelectAll();
        griglia.DataBind();
    }
}