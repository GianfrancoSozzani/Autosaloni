using System;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    //dichiaro una variabile per storare il valore passato dll'altra pagina per k_marca
    static string chiave;
    protected void Page_Load(object sender, EventArgs e)
    {
        //metto un !postback per eviatre che quando l'utente clicca aggiorna rimanga in memoria il vlaore caricato all'apertura
        //della pagina e non quello riscritto ex novo per la modifica
        if (!IsPostBack)
        {
            //chiave assumerà il valore c che ricevo dalla pagina Marche_Modifica
            chiave = Request.QueryString["c"].ToString();

            //inserisco la marca selezionata nell'altra pagina (cioè in base a c) dentro il textbox

            //collegarmi al database
            MARCHE m = new MARCHE();
            //gli passo la query
            m.K_Marca = int.Parse(chiave);
            DataTable DT = new DataTable();
            DT = m.SelezionaChiave();
            //riempio il textbox
            txtAggiorna.Text = DT.Rows[0]["Marca"].ToString();

        }

    }

    protected void btnAggiorna_Click(object sender, EventArgs e)
    {
        //CONTROLLI FORMALI

        //controllo che l'utente abbia inserito un dato
        if (String.IsNullOrEmpty(txtAggiorna.Text))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati non validi');", true);
            return;
        }

        //controllo che la marca inserita non sia già presente nel database


        //creare la datatable
        MARCHE m = new MARCHE();
        m.Marca = txtAggiorna.Text;
        m.K_Marca = int.Parse(chiave);
        DataTable DT = new DataTable();
        DT = m.CheckRedundantRecords();
        if (DT.Rows.Count != 0) //ricordarsi di mettre (int) davanti
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Marca già presente');", true);
            return;
        }
        m.Modifica();
        //ritorno a Marche_Modifica
        Response.Redirect("Marche_Modifica.aspx");
    }
}