using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // richiamo la funzione di popolamento dati
        CaricaDati();
    }

    protected void CaricaDati()
    {
        // popolo la mia griglia con i dati dell'autosalone
        DB db = new DB();
        db.query = "SALONI_SelectAll";
        griglia.DataSource = db.SQLselect();
        griglia.DataBind();

    }



    protected void btnModifica_Click(object sender, EventArgs e)
    {
        // evento click del bottone modifica

        // controllo se è stato selezionato un record
        if (griglia.SelectedIndex == -1)
        {
            // faccio comparire un alert di avviso
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Seleziona un record');", true);
            return;
        }

        // recupero la chiave del record selezionato
        string chiave = griglia.SelectedValue.ToString();
        // reindirizzo alla pagina di modifica passando la chiave come parametro
        Response.Redirect("AutosaloniModifica2.aspx" + "?c=" + chiave);
    }
}