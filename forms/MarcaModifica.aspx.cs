// Importazione delle librerie necessarie per il funzionamento della pagina web
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Dichiarazione della classe che rappresenta la pagina web ASP.NET
public partial class Forms_Default2 : System.Web.UI.Page
{
    // Dichiarazione di una variabile statica per memorizzare la chiave selezionata nella griglia
    // ⚠️ Problema: essendo statica, il valore viene condiviso tra tutti gli utenti che accedono alla pagina.
    static string chiave;

    // Metodo eseguito automaticamente quando la pagina viene caricata
    protected void Page_Load(object sender, EventArgs e)
    {
        // Se la pagina NON è un postback (cioè è il primo caricamento), popola la griglia con i dati
        if (!IsPostBack)
        {
            CaricaDati();
        }
    }

    // Metodo per caricare i dati nella griglia dalla base di dati
    protected void CaricaDati()
    {
        // Creazione di un'istanza della classe DB per interagire con il database
        DB database = new DB();

        // Definizione della query (probabilmente è il nome di una stored procedure)
        database.query = "MARCHE_SelectAll";

        // Esecuzione della query e associazione dei risultati alla griglia
        griglia.DataSource = database.SQLselect();

        // Aggiornamento della griglia con i nuovi dati
        griglia.DataBind();
    }

    // Evento attivato quando l'utente seleziona una riga della griglia
    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Assegna alla variabile chiave il valore della chiave primaria della riga selezionata
        // ⚠️ Problema: Se la griglia non ha dati selezionati, può generare un errore.
        chiave = griglia.SelectedValue.ToString();
    }

    // Evento attivato quando l'utente clicca sul pulsante "Modifica"
    protected void btnModifica_Click(object sender, EventArgs e)
    {
        // Se nessuna riga è stata selezionata, esce dalla funzione
        if (griglia.SelectedIndex == -1)
        {
            return;
        }

        // Rende visibile il div per la modifica
        divmodifica.Visible = true;

        // Creazione di un'istanza della classe DB
        DB database = new DB();

        // Imposta la query per selezionare un singolo record tramite chiave
        database.query = "MARCA_SelezionaChiave";

        // ⚠️ Problema: `chiave` potrebbe essere null o non valida
        // Aggiunge il valore della chiave come parametro della query
        database.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));

        // Creazione di una tabella dati per salvare il risultato della query
        DataTable DT = new DataTable();

        // Esecuzione della query e memorizzazione del risultato nella DataTable
        DT = database.SQLselect();

        // ⚠️ Problema: Se la query non restituisce risultati, questa riga genererà un errore
        // Assegna il valore della colonna "Marca" al campo di testo
        txtMarca.Text = DT.Rows[0]["Marca"].ToString();
    }

    // Evento attivato quando l'utente clicca sul pulsante "Salva"
    protected void btnSalva_Click(object sender, EventArgs e)
    {
        // Se il campo di testo "Marca" è vuoto, mostra un avviso e interrompe l'operazione
        if (String.IsNullOrEmpty(txtMarca.Text))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Il campo Marca non può essere vuoto');", true);
            return;
        }

        // Creazione di un'istanza della classe DB
        DB db = new DB();

        // Imposta la query per controllare se il valore inserito è già presente nel database
        db.query = "MARCA_Controllo";

        // Aggiunge il valore del campo di testo come parametro della query
        db.cmd.Parameters.AddWithValue("@marca", txtMarca.Text);

        // Creazione di una tabella dati per memorizzare il risultato della query
        DataTable DT = new DataTable();

        // Esecuzione della query e memorizzazione del risultato nella DataTable
        DT = db.SQLselect();

        // ⚠️ Problema: Se la query non restituisce righe, questa riga genererà un errore
        // Se la colonna "CONTROLLO" è uguale a 1, significa che il valore non è valido
        if ((int)DT.Rows[0]["CONTROLLO"] == 1)
        {
            // Mostra un avviso e interrompe l'operazione
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Marca già presente');", true);
            return;
        }

        // Creazione di una nuova istanza della classe DB per l'aggiornamento
        DB database = new DB();

        // Imposta la query per aggiornare il record
        database.query = "MARCHE_Update";

        // Aggiunge i parametri necessari per l'aggiornamento
        database.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));
        database.cmd.Parameters.AddWithValue("@marca", txtMarca.Text.Trim());

        // Esegue il comando di aggiornamento
        database.SQLcommand();

        // Ricarica i dati nella griglia per riflettere le modifiche
        CaricaDati();

        // Nasconde il div di modifica
        divmodifica.Visible = false;
    }
}
