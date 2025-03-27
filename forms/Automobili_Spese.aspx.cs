using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //automobile
            CaricaAutomobile();
            //caricamento dati automobile
            CaricaDatiAutombile();
            //caricamento griglia spese
            CaricaDati();
            //caricamento dati cliente
            CaricaDatiCliente();
        }
    }


    protected void CaricaAutomobile()
    {
        AUTOMOBILI a = new AUTOMOBILI();
        ddlAutomobili.DataSource = a.ddlAutomobiliVendita();
        ddlAutomobili.DataValueField = "K_Auto";
        ddlAutomobili.DataTextField = "MarcaModello";
        ddlAutomobili.DataBind();
    }

    protected void CaricaDati()
    {
        SPESE_AUTO sa = new SPESE_AUTO();
        sa.K_Auto = int.Parse(ddlAutomobili.SelectedValue);
        griglia_spese.DataSource = sa.SPESE_AUTO_SelezionaAutomobile();
        griglia_spese.DataBind();
    }

    protected void CaricaDatiCliente()
    {
        SPESE_AUTO sa = new SPESE_AUTO();
        sa.K_Auto = int.Parse(ddlAutomobili.SelectedValue);
        DataTable DT = new DataTable();
        DT = sa.DatiCliente();
        txtCognome.Text = DT.Rows[0]["Cognome"].ToString();
        txtNome.Text = DT.Rows[0]["Nome"].ToString();
        txtCodiceFiscale.Text = DT.Rows[0]["Codice_Fiscale"].ToString();
        txtCitta.Text = DT.Rows[0]["Citta"].ToString();
        txtIndirizzo.Text = DT.Rows[0]["Indirizzo"].ToString();
        txtCAP.Text = DT.Rows[0]["CAP"].ToString();
        txtProvincia.Text = DT.Rows[0]["Provincia"].ToString();
        txtPatente.Text = DT.Rows[0]["Codice_Patente"].ToString();
        txtDataNascita.Text = DT.Rows[0]["Data_di_Nascita"].ToString();
    }

    protected void CaricaDatiAutombile()
    {
        SPESE_AUTO sa = new SPESE_AUTO();
        sa.K_Auto = int.Parse(ddlAutomobili.SelectedValue);
        DataTable DT = new DataTable();
        DT = sa.SelezionaDatiAutomobile();
        txtMarca.Text = DT.Rows[0]["Marca"].ToString();
        txtMarca.Text = DT.Rows[0]["Modello"].ToString();
        txtStato.Text = DT.Rows[0]["Stato"].ToString();
        txtData_Acquisto.Text = DT.Rows[0]["Data_Acquisto"].ToString();
        txtPrezzoAcquisto.Text = DT.Rows[0]["Prezzo_Acquisto"].ToString();
        txtNomeSalone.Text = DT.Rows[0]["Nome_Salone"].ToString();
        txtCognomeResponsabile.Text = DT.Rows[0]["Cognome_Responsabile"].ToString();
        txtNomeResponsabile.Text = DT.Rows[0]["Nome_Responsabile"].ToString();
        txtCognomeVenditore.Text = DT.Rows[0]["Cognome_Venditore"].ToString();
        txtNomeVenditore.Text = DT.Rows[0]["Nome_Venditore"].ToString();
        txtAlimentazione.Text = DT.Rows[0]["Alimentazione"].ToString();
        txtColori.Text = DT.Rows[0]["Colore"].ToString();
        txtKM.Text = DT.Rows[0]["KM"].ToString();
        txtCambio.Text = DT.Rows[0]["Cambio"].ToString();
        txtTarga.Text = DT.Rows[0]["Targa"].ToString();
        txtTelaio.Text = DT.Rows[0]["Telaio"].ToString();
        txtCondizioni.Text = DT.Rows[0]["Condizione"].ToString();
        txtCondizioni.Text = DT.Rows[0]["Optional"].ToString();

    }

    protected void ddlAutomobili_SelectedIndexChanged(object sender, EventArgs e)
    {
        CaricaDati();
        CaricaDatiCliente();
    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        if (!Decimal.TryParse(txtImportoInserimento.Text, out _))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert(Uno dei dati di Prezzo inseriti non é valido);", true);
            return;
        }

        if (txtImportoInserimento.Text.Contains(" "))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati numerici non validi);", true);
            return;
        }

        //inserimento
        SPESE_AUTO sa = new SPESE_AUTO();
        sa.K_Auto = int.Parse(ddlAutomobili.SelectedValue);
        sa.Spesa = txtSpesaInserimento.Text.Trim();
        sa.Importo = Decimal.Parse(txtImportoInserimento.Text);
        sa.Inserimento();
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Spesa aggiunta correttamente');", true);

        txtSpesaInserimento.Text = "";
        txtImportoInserimento.Text = "";

        CaricaDati();

    }
    protected void griglia_spese_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (griglia_spese.SelectedIndex == -1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Non hai selezionato nulla');", true);
            return;
        }

        SPESE_AUTO sa = new SPESE_AUTO();
        sa.K_Spesa = int.Parse(griglia_spese.SelectedValue.ToString());
        DataTable dt = new DataTable();
        dt = sa.SelezionaSpesa();
        txtSpesaModifica.Text = dt.Rows[0]["Spesa"].ToString();
        txtImportoModifica.Text = dt.Rows[0]["Importo"].ToString();
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        if (!Decimal.TryParse(txtImportoModifica.Text, out _))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert(Uno dei dati di Prezzo inseriti non é valido);", true);
            return;
        }

        if (txtImportoModifica.Text.Contains(" "))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati numerici non validi);", true);
            return;
        }

        SPESE_AUTO sa = new SPESE_AUTO();
        sa.K_Spesa = int.Parse(griglia_spese.SelectedValue.ToString());
        sa.Spesa = txtSpesaModifica.Text.Trim();
        sa.Importo = Decimal.Parse(txtImportoModifica.Text);
        sa.Modifica();

        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Spesa modificata correttamente');", true);

        txtSpesaModifica.Text = "";
        txtImportoModifica.Text = "";

        CaricaDati();
    }

}

