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
            txtPrezzoOfferto.Text = dt_auto.Rows[0]["Prezzo_Offerto"].ToString();
            txtPrezzoVendita.Text = dt_auto.Rows[0]["Prezzo_Vendita"].ToString();
            txtDataVendita.Text = dt_auto.Rows[0]["Data_Vendita"].ToString();

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
            
            //caricamneto lista clienti acquisto
            ddlClientiAcquisto.DataSource = a.AUTOMOBILI_ddlClienti();
            ddlClientiAcquisto.DataValueField = "K_Cliente";
            ddlClientiAcquisto.DataTextField = "NomeCognome";
            ddlClientiAcquisto.DataBind();

            //caricamento cliente acquisto auto
            DataTable dt_clientiA = new DataTable();
            dt_clientiA = a.ddlClienteAcquistoModifica();
            ddlClientiAcquisto.SelectedValue = dt_clientiA.Rows[0]["K_Cliente"].ToString();

            //caricamneto lista clienti vendita
            ddlClientiVendita.DataSource = a.AUTOMOBILI_ddlClienti();
            ddlClientiVendita.DataValueField = "K_Cliente";
            ddlClientiVendita.DataTextField = "NomeCognome";
            ddlClientiVendita.DataBind();

            //caricamento cliente vendita auto
            DataTable dt_clientiV = new DataTable();
            dt_clientiV = a.ddlClienteVenditaModifica();
            ddlClientiVendita.SelectedValue = dt_clientiV.Rows[0]["K_Cliente"].ToString();

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






    protected void btnModifica_Click(object sender, EventArgs e)
    {
        //controllo se i campi obbligatori sono vuoti
        if (
            String.IsNullOrEmpty(txtDataAcquisto.Text) ||
            String.IsNullOrEmpty(txtPrezzoAcquisto.Text) ||
            String.IsNullOrEmpty(txtTelaio.Text) ||
            String.IsNullOrEmpty(txtKM.Text) ||
            String.IsNullOrEmpty(txtPrezzoOfferto.Text) ||
            String.IsNullOrEmpty(txtPrezzoVendita.Text) ||
            String.IsNullOrEmpty(txtDataVendita.Text)
           )
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Campi obbligatori vuoti');", true);
            return;
        }

        //controllose dll hanno valori vuoti es. si è registrata una marca ma non si è ancora registrato un modello
        //oppure si è registrato un salone ma bisogna ancora asumere il personale 

        if (
            (!int.TryParse(ddlModelli.SelectedValue, out _)) ||
            (!int.TryParse(ddlResponsabile.SelectedValue, out _)) ||
            (!int.TryParse(ddlVenditore.SelectedValue, out _))
            )
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Campi obbligatori vuoti');", true);
            return;
        }


        //controllo che la data d'acquisto inserita sia valida come formato
        if (!DateTime.TryParse(txtDataAcquisto.Text, out _) && !String.IsNullOrEmpty(txtDataAcquisto.Text))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data di acquisto non valida');", true);
            return;

        }
        //controllo che la data inserita non sia oltre la data corrente
        DateTime dataOdierna = DateTime.Now;

        if (DateTime.Parse(txtDataAcquisto.Text) > dataOdierna)
        {

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('La data d'acquisto inserita supera la data corrente ');", true);
            return;
        }

        //controllo che il telaio sia valido
        if (txtTelaio.Text.Length != 17)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('VIN');", true);
            return;
        }

        if (
           txtTelaio.Text.Contains(" ") ||
           txtKM.Text.Contains(" ") ||
           txtPrezzoAcquisto.Text.Contains(" ") ||
           (txtTarga.Text.Contains(" ") && !String.IsNullOrEmpty(txtTarga.Text) ||
           txtPrezzoOfferto.Text.Contains(" ") ||
           txtPrezzoVendita.Text.Contains(" ")

           )
          )
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati alfanumerici non validi);", true);
            return;

        }
        //controllo che il prezzo di acquisto sia valido
        if (!Decimal.TryParse(txtPrezzoAcquisto.Text, out _))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert(Il dato Prezzo d'acquisto inserito non é valido);", true);
            return;
        }

        //controllo che il chilometraggio sia valido
        if (!int.TryParse(txtKM.Text, out _))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert(Il dato Chilometraggio inserito non é valido);", true);
            return;
        }

        //controllo che il prezzo offerto e il prezzo di vendita siano dati validi
        if (!Decimal.TryParse(txtPrezzoOfferto.Text, out _) || !Decimal.TryParse(txtPrezzoVendita.Text, out _))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert(Uno dei dati di Prezzo relativi alla vendita inseriti non é valido);", true);
            return;
        }

        //controllo che la data inserita sia valida come formato
        if (!DateTime.TryParse(txtDataVendita.Text, out _))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data di vendita non valida');", true);
            return;

        }
        //controllo che la data di vendita non superi quella corrente
        if (DateTime.Parse(txtDataVendita.Text) > dataOdierna)
        {

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('La data di venditainserita supera la data corrente');", true);
            return;
        }
        //controllo che la data di vendita non sia precedente a quella di acquisto 

        if (DateTime.Parse(txtDataVendita.Text) < DateTime.Parse(txtDataAcquisto.Text))
        {

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('La data inserita supera quella di acquisto');", true);
            return;
        }

        //controllose dll hanno valori vuoti es. si è registrata una marca ma non si è ancora registrato un modello
        //oppure si è registrato un salone ma bisogna ancora asumere il personale 

        if (
            (!int.TryParse(ddlModelli.SelectedValue, out _)) ||
            (!int.TryParse(ddlResponsabile.SelectedValue, out _)) ||
            (!int.TryParse(ddlVenditore.SelectedValue, out _))
            )
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Campi obbligatori vuoti');", true);
            return;
        }

        //controllo che il prezzo offerto e il prezzo di vendita sia maggiore del prezzo di acquisto

        if ((Decimal.Parse(txtPrezzoOfferto.Text) > Decimal.Parse(txtPrezzoAcquisto.Text)) || (Decimal.Parse(txtPrezzoVendita.Text) > Decimal.Parse(txtPrezzoAcquisto.Text)))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Vietato vendere auto in perdita');", true);
            return;
        }


        //controllo di non star inserendo un duplicato di un automobile
        //CONTROLLLO CHE L'AUTO NON SIA GIà REGISTRATA
        //collagmento a DB
        AUTOMOBILI a = new AUTOMOBILI();
        a.K_Auto = int.Parse(chiave);
        DataTable DT = new DataTable();
        DT = a.SelezionaChiave();

        if (DT.Rows.Count > 0) //ricordarsi di mettre (int) davanti
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Automobile già registrata');", true);
            return;
        }


        //modifica

        a.K_Modello = int.Parse(ddlModelli.SelectedValue);
        a.Stato = ddlStato.SelectedValue;
        a.Data_Acquisto = DateTime.Parse(txtDataAcquisto.Text);
        a.K_Cliente_Acquisto = int.Parse(ddlClientiAcquisto.SelectedValue);
        a.Prezzo_Acquisto = Decimal.Parse(txtPrezzoAcquisto.Text);
        a.K_Salone = int.Parse(ddlSaloni.SelectedValue);
        a.K_Responsabile = int.Parse(ddlResponsabile.SelectedValue);
        a.K_Venditore = int.Parse(ddlVenditore.SelectedValue);
        a.Alimentazione = ddlAlimentazione.SelectedValue;
        a.Colore = txtColori.Text.Trim();
        a.KM = int.Parse(txtKM.Text);
        a.Cambio = ddlCambio.SelectedValue;
        a.Targa = txtTarga.Text;
        a.Telaio = txtTelaio.Text;
        a.Condizione = txtCondizioni.Text.Trim();
        a.Optional = txtOptional.Text.Trim();
        a.Prezzo_Offerto = Decimal.Parse(txtPrezzoOfferto.Text);
        a.Prezzo_Vendita = Decimal.Parse(txtPrezzoVendita.Text);
        a.Data_Acquisto = DateTime.Parse(txtDataVendita.Text);
        a.K_Cliente_Vendita = int.Parse(ddlClientiVendita.SelectedValue);

        a.Modifica();

        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Automobile Modificata Correttamente');", true);

        Response.Redirect("Automobili_Modifica.aspx");

    }
}