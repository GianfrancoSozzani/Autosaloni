using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
        string giorno_di_nascita = txtDataNascita.Text.Trim();



     
        //dichiaro una variabile di tipo data (concetto temporale)

        DateTime bornDay;



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
        if (DateTime.TryParse(giorno_di_nascita, out bornDay) && !String.IsNullOrEmpty(giorno_di_nascita))
        {
            bornDay = bornDay.Date;
           
        }
        else
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

        //controllo che il cliente non sia già presente

        //connesione database
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = @"Data Source=DESKTOP-KM2T7UL\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true;";

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandType = CommandType.Text; //fai attenzione a questo, importante!

        cmd.CommandText = "select count(*) as [QUANTI] from CLIENTI where Codice_Fiscale = '" + codice_fiscale_cliente + "' AND Data_di_Nascita = '" + giorno_di_nascita + "'";
        SqlDataAdapter DA = new SqlDataAdapter();
        DA.SelectCommand = cmd;
        DataTable DT = new DataTable();
        DA.Fill(DT);

        if ((int)DT.Rows[0]["QUANTI"] == 1) //ricordarsi di mettre (int) davanti
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Cliente già registrato');", true);
            return;
        }

        //verifico che non ci siano patenti già registrate

        cmd.CommandText = "select count(*) as [QUANTIpatente] from CLIENTI where Codice_Patente = '" + codice_patente_cliente + "'";
        SqlDataAdapter DApatente = new SqlDataAdapter();
        DApatente.SelectCommand = cmd;
        DataTable DTpatente = new DataTable();
        DApatente.Fill(DTpatente);


        if ((int)DTpatente.Rows[0]["QUANTIpatente"] == 1) //ricordarsi di mettre (int) davanti
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Codice patente già presente');", true);
            return;
        }

        //registro il cliente

        cmd.CommandText = "insert into CLIENTI (COGNOME,NOME,CITTA,CODICE_FISCALE,INDIRIZZO,CAP,PROVINCIA,CODICE_PATENTE,DATA_DI_NASCITA)" +
            " VALUES ('" + cognome_cliente + "','" + nome_cliente + "','" + citta_cliente + "', '" + codice_fiscale_cliente + "', '" + indirizzo_cliente + "', '" + CAP_cliente + "', '" + provincia + "', '" + codice_patente_cliente + "', '" + giorno_di_nascita + "')";

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        grigliaClienti.DataBind(); //aggiorna i valori della griglia

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
    }
}