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
        if (!IsPostBack)
        {
            chiave = Request.QueryString["c"].ToString();
            
            //caricamento griglia spese
            CaricaDati();
            CaricaDatiCliente();
        }
    }

    protected void CaricaDati()
    {
        SPESE_AUTO sa = new SPESE_AUTO();
        sa.K_Auto = int.Parse(chiave);
        griglia_spese.DataSource = sa.SPESE_AUTO_SelezionaAutomobile();
        griglia_spese.DataBind();
    }

    protected void CaricaDatiCliente()
    {
        SPESE_AUTO sa = new SPESE_AUTO();
        sa.K_Auto = int.Parse(chiave);
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
}