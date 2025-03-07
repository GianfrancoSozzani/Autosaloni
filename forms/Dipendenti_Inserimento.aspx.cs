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
        if (!IsPostBack) // Popola la dropdown solo al primo caricamento della pagina
        {
            // Aggiungi la voce "V"
            ddlRuoli.Items.Add(new ListItem("Venditore", "V")); // Testo visualizzato, Valore effettivo

            // Aggiungi la voce "R"
            ddlRuoli.Items.Add(new ListItem("Responsabile", "R")); // Testo visualizzato, Valore effettivo

            // Facoltativo: Aggiungere una voce predefinita (es. "Seleziona ruolo")
            // ddlRuolo.Items.Insert(0, new ListItem("Seleziona Ruolo", "")); // Inserisce all'inizio
        }
    }

    protected void btnInserimento_Click(object sender, EventArgs e)
    {
        //dichiaro le variabili di storage per i menù a tendina per recuperare K_Autosalone e il Ruolo
        string autosaloneScelto = ddlAutosaloni.SelectedValue;
        string ruoloScelto = ddlRuoli.SelectedValue;
        //dichiaro le variabili di storage per i campi da inserire manualmente
        string cognomeDipendente = txtCognome.Text.Trim();
        string nomeDipendente = txtNome.Text.Trim();


        //controlo che l'utente abbia effettivamente scritto qualcosa
        if (String.IsNullOrEmpty(cognomeDipendente) || String.IsNullOrEmpty(nomeDipendente))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati non validi');", true);
            return;
        }

        //controllo che non sia già presente il dipendente

        //connesione database
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = @"Data Source=DESKTOP-KM2T7UL\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true;";

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandType = CommandType.Text; //fai attenzione a questo, importante!


        //controllo se il modello non sia già presente
        cmd.CommandText = "select count(*) as [QUANTI] from DIPENDENTI where COGNOME = '" + cognomeDipendente + "' AND NOME = '" + nomeDipendente + "' AND RUOLO = '" + ruoloScelto + "' AND K_SALONE = '" + autosaloneScelto + "'";
        SqlDataAdapter DA = new SqlDataAdapter();
        DA.SelectCommand = cmd;
        DataTable DT = new DataTable();
        DA.Fill(DT);

        if ((int)DT.Rows[0]["QUANTI"] == 1) //ricordarsi di mettre (int) davanti
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dipendente già registrato');", true);
            return;
        }

        //Inserimento dipendente con autosalone associato
        cmd.CommandText = "insert into DIPENDENTI (COGNOME,NOME,RUOLO,K_SALONE) VALUES ('" + cognomeDipendente + "','" + nomeDipendente + "','" + ruoloScelto + "', '" + autosaloneScelto + "')";

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        grigliaDipendenti.DataBind(); //aggiorna i valori della griglia

        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dipendente Inserito Correttamente');", true);


        //svuoto campi di inserimento

        txtNome.Text = "";
        txtCognome.Text = "";
    }
}