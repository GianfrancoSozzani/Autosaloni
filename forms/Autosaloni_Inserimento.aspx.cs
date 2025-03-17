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
        Caricadati();
    }

    protected void btnInserimento_Click(object sender, EventArgs e)
    {
        //dichairo variabile di strorage per la modello inserito
        string inserimentoNome = txtNome.Text.Trim();
        string inserimentoIndirizzo = txtIndirizzo.Text.Trim();
        string inserimentoCitta = txtCittà.Text.Trim();
        string inserimentoCAP = txtCAP.Text;
        string inserimentoProvincia = txtProvincia.Text;
        int provaCAP;





        //controlo che l'utente abbia effettivamente scritto qualcosa
        if (String.IsNullOrEmpty(inserimentoNome) ||
            String.IsNullOrEmpty(inserimentoIndirizzo) ||
            String.IsNullOrEmpty(inserimentoCitta) ||
            String.IsNullOrEmpty(inserimentoCAP) ||
            String.IsNullOrEmpty(inserimentoProvincia))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati non validi');", true);
            return;
        }

        if (inserimentoCAP.Length != 5)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('CAP non valido');", true);
            return;
        }
        if (inserimentoProvincia.Length != 2)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('provincia non valida');", true);
            return;
        }


        if (!int.TryParse(inserimentoCAP, out provaCAP))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('CAP non valido');", true);
            return;
        }

        if (inserimentoCAP.Contains(" ") || inserimentoProvincia.Contains(" "))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati alfanumerici non validi);", true);
            return;
        }

        //controllo che non sia già presente un autosalone uguale

        SALONI s = new SALONI();
        s.Nome_Salone = inserimentoNome;
        DataTable DT = new DataTable();
        DT = s.SelezionaSalone();


        if (DT.Rows.Count > 0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Autosalone già presente allo stesso indirizzo in questa città');", true);
            return;
        }
        
        s.Indirizzo = inserimentoIndirizzo;
        s.Citta = inserimentoCitta;
        s.CAP = inserimentoCAP;
        s.Provincia = inserimentoProvincia;
        s.Inserimento();


        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Autosaloni Inserito Correttamente');", true);

        //svuoto i campi per un nuovo inserimento
        txtNome.Text = "";
        txtIndirizzo.Text = "";
        txtCittà.Text = "";
        txtCAP.Text = "";
        txtProvincia.Text = "";
        //rcarico la griglia aggiornata
        Caricadati();
    }

    protected void griglia_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //tolgo visibiltà a K_Salone
        e.Row.Cells[0].Visible = false;
    }

    protected void Caricadati()
    {
        SALONI s = new SALONI();
        griglia.DataSource = s.SelectAll();
        griglia.DataBind();
    }
}