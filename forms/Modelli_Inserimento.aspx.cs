using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static string inserimentoModello;
    protected void Page_Load(object sender, EventArgs e)
    {
        CaricaDati();
        if (!IsPostBack)
        {
            //CARICAMENTO DROPDOWNLIST GENERALE
            //collagmento a DB
            MARCHE m = new MARCHE();
            //eseguo query
            ddlMarca.DataSource = m.SelectAll();
            //indico come la ddl deve visualizzare i valori
            ddlMarca.DataValueField = "K_Marca";
            ddlMarca.DataTextField = "Marca";
            //aggiornamento ddl
            ddlMarca.DataBind();
        }
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        //controlo che l'utente abbia effettivamente scritto qualcosa
        if (String.IsNullOrEmpty(txtInserimento.Text))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati non validi');", true);
            return;
        }

        //controllo che non sia già presente lo stesso modello

        MODELLI m = new MODELLI();
     
        m.Modello = txtInserimento.Text.Trim();
        m.K_Marca = int.Parse(ddlMarca.SelectedValue);
        DataTable DT = new DataTable();
        DT = m.SelezionaModello();

        //controllo che non sia già presente la marca
        if (DT.Rows.Count != 0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Marca già presente');", true);
            return;
        }

        //se non è presente inserimento
        m.Inserimento();
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Modello aggiunto correttamente');", true);

        txtInserimento.Text = "";
        CaricaDati();
    }

    protected void griglia_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //tolgo visibiltà a k_modello e K_marca
        e.Row.Cells[0].Visible = false;
        e.Row.Cells[1].Visible = false;
    }

    protected void CaricaDati()
    {
        //Connessione al DB e selezione con la query dei dati con cui riempire la tabella

        //connetterci al database
        MODELLI m = new MODELLI();
        DataTable DT = new DataTable();
        m.SelectAll();
        //aggiorno la griglia
        griglia.DataBind();

    }
}