using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static string chiave;
    protected void Page_Load(object sender, EventArgs e)
    {

        //MECCANISMO PER PASSARE A CLIENTI INSERIMENTO E TORNARE INDIETRO SENZA PERDERE LA CHIAVE PASSATA DA AUTOMOBILI INSERIMENTO
        
        //Se l'utente accede alla pagina con un parametro c nell'URL,
        //il valore di c viene assegnato a chiave e salvato nella sessione.

        //Se l'utente accede alla pagina senza il parametro c, ma la sessione contiene già un valore per passaggio,
        //allora chiave verrà impostato su quel valore.


        if (!IsPostBack)
        {
            //chiave assumerà il valore c che ricevo dalla pagina Automobili_Modifica
            if (Request.QueryString["c"] != null)
            {
                chiave = Request.QueryString["c"].ToString();
                Session["passaggio"] = chiave;
            }

            else if (Session["passaggio"] != null)
            {
                chiave = Session["passaggio"].ToString();
            }

            CaricaDati();
        }
    }

    protected void CaricaDati()
    {
        AUTOMOBILI a = new AUTOMOBILI();
        a.K_Auto = int.Parse(chiave);
        griglia_automobili.DataSource = a.SelectVendita();
        griglia_automobili.DataBind();

        SPESE_AUTO sa = new SPESE_AUTO();
        sa.K_Auto = int.Parse(chiave);
        griglia_spese.DataSource = sa.SPESE_AUTO_SelezionaAutomobile();
        griglia_spese.DataBind();

        //CARICAMENTO DROPDOWNLIST CLIENTI
        //collagmento a DB
        ddlClienti.DataSource = a.AUTOMOBILI_ddlClienti();
        //indico come la ddl deve visualizzare i valori
        ddlClienti.DataValueField = "K_Cliente";
        ddlClienti.DataTextField = "NomeCognome";
        //aggiornamento ddl
        ddlClienti.DataBind();
    }

    protected void btnClienteNuovo_Click(object sender, EventArgs e)
    {
        string passaggio = chiave;
        //passare il dato chaive alla pagina per la modifica
        //inviare l'utente alla pagina di modifica
        Response.Redirect("Clienti_Modifica2.aspx" + "?c=" + passaggio);
    }
}