using System;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    //dichiarazione della variabile contente la chiave
    static string chiave;
    protected void Page_Load(object sender, EventArgs e)
    {
        //metto un !postback per evitare che quando l'utente clicca aggiorna rimanga in memoria il valore caricato all'apertura
        //della pagina e non quello riscritto ex novo per la modifica


        //aggiorno la pagina solo al primo caricamento
        if (!IsPostBack)
        {
            //chiave assumerà il valore c che ricevo dalla pagina Modelli_Modifica
            chiave = Request.QueryString["c"].ToString();

            //CARICAMENTO DROPDOWNLIST GENERALE
            //collagmento a DB
            MARCHE m = new MARCHE();
            //eseguo query
            ddlMarche.DataSource = m.SelectAll();
            //indico come la ddl deve visualizzare i valori
            ddlMarche.DataValueField = "K_Marca";
            ddlMarche.DataTextField = "Marca";
            //aggiornamento ddl
            ddlMarche.DataBind();

            //CARICO VALORI SELEZIONATI NELLA DDL(marca) e nel TEXTBOX(modello) in base ai valori scelti nella pagina di partenza
            //collegamento database
            MODELLI mod = new MODELLI();
            mod.K_Modello = int.Parse(chiave);
            DataTable DT = new DataTable();
            DT = mod.SelezionaChiave();
            //valore dddl (marca)
            ddlMarche.SelectedValue = DT.Rows[0]["K_Marca"].ToString();
            //valore in textbox (modello)
            txtModello.Text = DT.Rows[0]["Modello"].ToString();
        }
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        //controlli formali

        //controllo che l'utente abbia inserito un dato nei modelli
        if (String.IsNullOrEmpty(txtModello.Text))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati non validi');", true);
            return;
        }

        //controllo che il modello non sia già presente nel database 
        MODELLI m = new MODELLI();
        //creare la datatable
        m.K_Modello = int.Parse(chiave);
        m.K_Marca = int.Parse(ddlMarche.SelectedValue);
        m.Modello = txtModello.Text;
        DataTable DT = new DataTable();
        DT = m.CheckRedundantRecords();

        if (DT.Rows.Count > 0) //ricordarsi di mettre (int) davanti
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Modello già presente');", true);
            return;
        }

        //UPDATE
        m.Modifica();
     
        //ritorno alla pagina Modelli_Modifica
        Response.Redirect("Modelli_Modifica.aspx");
    }
}