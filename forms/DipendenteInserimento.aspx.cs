using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack) // Popola la dropdown solo al primo caricamento della pagina
        {
            // Aggiungi la voce "V"
            ddlRuolo.Items.Add(new ListItem("Venditore", "V")); // Testo visualizzato, Valore effettivo

            // Aggiungi la voce "R"
            ddlRuolo.Items.Add(new ListItem("Responsabile", "R")); // Testo visualizzato, Valore effettivo

            // Facoltativo: Aggiungere una voce predefinita (es. "Seleziona ruolo")
            ddlRuolo.Items.Insert(0, new ListItem("Seleziona Ruolo", "")); // Inserisce all'inizio
        }
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        string COGNOME = txtCognome.Text.Trim();
        string NOME = txtNome.Text.Trim();
        string RUOLO = ddlRuolo.SelectedValue;

        // connessione al database
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = "Data Source = DESKTOP-0E2GJI9\\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true";



        SqlCommand cmd = new SqlCommand();
        // query di selezione
        // interrompo la stringa inserisco variabile c#
        cmd.CommandText = "select count (*) as [CONTROLLO] from DIPENDENTI where COGNOME ='" +COGNOME+ "' AND NOME = '"+NOME+"'";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = conn;

        SqlDataAdapter DA = new SqlDataAdapter();
        DA.SelectCommand = cmd;

        DataTable DT = new DataTable();

        DA.Fill(DT);

        if ((int)DT.Rows[0]["CONTROLLO"] == 1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dipendente già presente');", true);
            return;


        }

        cmd.CommandText = "insert into DIPENDENTI (Cognome, Nome, Ruolo) values ('" + COGNOME+ "','"+NOME+"', '"+RUOLO+"')";
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        griglia.DataBind();
    }
}