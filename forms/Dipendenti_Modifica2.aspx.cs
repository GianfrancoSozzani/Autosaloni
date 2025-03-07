using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
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
            //collagmento a DB
            DB database = new DB();
            //eseguo query
            database.query = "SALONI_SelectAll";
            ddlSaloni.DataSource = database.SQLselect();
            //indico come la ddl deve visualizzare i valori

            //aggiornamento ddl
            ddlSaloni.DataBind();

            //CARICO VALORI SELEZIONATI NELLA DDL(marca) e nel TEXTBOX(modello) in base ai valori scelti nella pagina di partenza
            //collegamento database
            DB stampdatabase = new DB();
            //gli passo la query che stampera i valori dalla tabella MODELLI in base alla chiave
            stampdatabase.query = "Modello_SelezionaChiave";
            stampdatabase.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));
            DataTable DT = new DataTable();
            DT = stampdatabase.SQLselect();
            //valore dddl (marca)
            ddlSaloni.SelectedValue = DT.Rows[0]["K_Marca"].ToString();
            //valore in textbox (modello)
            txtNome.Text = DT.Rows[0]["Nome"].ToString();

        }
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {

    }
}