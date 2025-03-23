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
            if (Request.QueryString["c"] != null)
            {
                chiave = Request.QueryString["c"].ToString();
                Session["passaggio"] = chiave;
            }

            else if (Session["passaggio"] != null)
            {
                chiave = Session["passaggio"].ToString();
            }

            //caricamento elenco generale delle marche
            MARCHE m = new MARCHE();
            ddlMarche.DataSource = m.SelectAll();
            ddlMarche.DataValueField = "K_Marca";
            ddlMarche.DataTextField = "Marca";
            ddlMarche.DataBind();

            //caricamento marca automobile selezionata per la modifica
            AUTOMOBILI a = new AUTOMOBILI();
            a.K_Auto = int.Parse(chiave);
            DataTable DT = new DataTable();
            DT = a.SelezionaMarcaAutomobile();
            ddlMarche.SelectedValue = DT.Rows[0]["K_Marca"].ToString();

            //caricamento elenco modelli della marca selezionata
            CaricaModelli();

            //caricamento elenco dei saloni
            SALONI s = new SALONI();
            ddlSaloni.DataSource = s.SelectAll();
            ddlSaloni.DataValueField = "K_Salone";
            ddlSaloni.DataTextField = "Nome_Salone";
            ddlSaloni.DataBind();




            // caricamneto elenco stato
            // Aggiungi la voce "N"
            ddlStato.Items.Add(new ListItem("Nuova", "N")); // Testo visualizzato, Valore effettivo
            // Aggiungi la voce "U"
            ddlStato.Items.Add(new ListItem("Usata", "U")); // Testo visualizzato, Valore effettivo


            // caricamento lista carburanti

            ddlAlimentazione.Items.Add(new ListItem("benzina", "benzina")); // Testo visualizzato, Valore effettivo
            ddlAlimentazione.Items.Add(new ListItem("gasolio", "gasolio")); // Testo visualizzato, Valore effettivo
            ddlAlimentazione.Items.Add(new ListItem("ibrido-benzina", "ibrido-benzina")); // Testo visualizzato, Valore effettivo
            ddlAlimentazione.Items.Add(new ListItem("ibrido-gasolio", "ibrido-gasolio")); // Testo visualizzato, Valore effettivo
            ddlAlimentazione.Items.Add(new ListItem("idrogeno", "idrogeno")); // Testo visualizzato, Valore effettivo
            ddlAlimentazione.Items.Add(new ListItem("elettrico", "elettrico")); // Testo visualizzato, Valore effettivo
            ddlAlimentazione.Items.Add(new ListItem("metano", "metano")); // Testo visualizzato, Valore effettivo

            //caricamento  lista cambi

            ddlCambio.Items.Add(new ListItem("automatico", "automatico")); // Testo visualizzato, Valore effettivo
            ddlCambio.Items.Add(new ListItem("manuale", "manuale")); // Testo visualizzato, Valore effettivo
            ddlCambio.Items.Add(new ListItem("sequenzale", "sequenzale")); // Testo visualizzato, Valore effettivo


            //caricamento dati automobile dalla tabella automobili
            DataTable dt_auto = new DataTable();
            dt_auto = a.SelezionaDatiAutomobile();
            ddlModelli.SelectedValue = dt_auto.Rows[0]["K_Modello"].ToString();
            ddlStato.SelectedValue = dt_auto.Rows[0]["Stato"].ToString();
            txtDataAcquisto.Text = dt_auto.Rows[0]["Data_Acquisto"].ToString();
            txtPrezzoAcquisto.Text = dt_auto.Rows[0]["Prezzo_Acquisto"].ToString();
            ddlSaloni.SelectedValue = dt_auto.Rows[0]["K_Salone"].ToString();
            ddlAlimentazione.SelectedValue = dt_auto.Rows[0]["Alimentazione"].ToString();
            txtColori.Text = dt_auto.Rows[0]["Colore"].ToString();
            txtKM.Text = dt_auto.Rows[0]["KM"].ToString();
            ddlCambio.SelectedValue = dt_auto.Rows[0]["Cambio"].ToString();
            txtTarga.Text = dt_auto.Rows[0]["Targa"].ToString();
            txtTelaio.Text = dt_auto.Rows[0]["Telaio"].ToString();
            txtCondizioni.Text = dt_auto.Rows[0]["Condizione"].ToString();
            txtOptional.Text = dt_auto.Rows[0]["Optional"].ToString();

            //caricamento elenco responsabili del salone
            CaricaResponsabili();

            //caricamneto resp auto
            DataTable dt_resp = new DataTable();
            dt_resp = a.ddlResponsabiliModifica();
            ddlResponsabile.SelectedValue = dt_resp.Rows[0]["K_Dipendente"].ToString();

            //caricamento elenco venditori del salone
            CaricaVenditori();

            //caricamneto venditori auto
            DataTable dt_seller = new DataTable();
            dt_seller = a.ddlVeditoriModifica();
            ddlVenditore.SelectedValue = dt_seller.Rows[0]["K_Dipendente"].ToString();

        }
    }
    protected void ddlMarche_SelectedIndexChanged(object sender, EventArgs e)
    {
        CaricaModelli();
    }
    protected void ddlSaloni_SelectedIndexChanged(object sender, EventArgs e)
    {
        CaricaResponsabili();
        CaricaVenditori();
    }
    protected void CaricaModelli()
    {
        //CARICAMENTO DROPDOWNLIST GENERALE
        //collagmento a DB
        AUTOMOBILI a = new AUTOMOBILI();
        a.K_Marca = int.Parse(ddlMarche.SelectedValue);
        ddlModelli.DataSource = a.AUTOMOBILI_ddlModelli();
        //indico come la ddl deve visualizzare i valori
        ddlModelli.DataValueField = "K_Modello";
        ddlModelli.DataTextField = "Modello";
        //aggiornamento ddl
        ddlModelli.DataBind();
    }

    protected void CaricaResponsabili()
    {
        //CARICAMENTO DROPDOWNLIST GENERALE
        //collagmento a DB
        AUTOMOBILI a = new AUTOMOBILI();
        a.K_Salone = int.Parse(ddlSaloni.SelectedValue);
        ddlResponsabile.DataSource = a.AUTOMOBILI_ddlResponabiliSalone();
        //indico come la ddl deve visualizzare i valori
        ddlResponsabile.DataValueField = "K_Dipendente";
        ddlResponsabile.DataTextField = "NomeCognome";
        //aggiornamento ddl
        ddlResponsabile.DataBind();
    }

    protected void CaricaVenditori()
    {
        //CARICAMENTO DROPDOWNLIST GENERALE
        //collagmento a DB
        AUTOMOBILI a = new AUTOMOBILI();
        a.K_Salone = int.Parse(ddlSaloni.SelectedValue);
        ddlVenditore.DataSource = a.AUTOMOBILI_ddlVenditoriSalone();
        //indico come la ddl deve visualizzare i valori
        ddlVenditore.DataValueField = "K_Dipendente";
        ddlVenditore.DataTextField = "NomeCognome";
        //aggiornamento ddl
        ddlVenditore.DataBind();
    }





}