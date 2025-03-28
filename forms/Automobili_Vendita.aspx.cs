﻿using System;
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

            //CARICAMENTO DROPDOWNLIST CLIENTI
            AUTOMOBILI a = new AUTOMOBILI();
            //collagmento a DB
            ddlClienti.DataSource = a.AUTOMOBILI_ddlClienti();
            //indico come la ddl deve visualizzare i valori
            ddlClienti.DataValueField = "K_Cliente";
            ddlClienti.DataTextField = "NomeCognome";
            //aggiornamento ddl
            ddlClienti.DataBind();

            //dati automobile
            CaricaAutomobile();
            //dati griglie
            CaricaDati();
            //dati cliente
            CaricaCliente();

        }
    }
    protected void ddlClienti_SelectedIndexChanged(object sender, EventArgs e)
    {
        CaricaCliente();
    }

    protected void ddlAutomobili_SelectedIndexChanged(object sender, EventArgs e)
    {
        CaricaDati();
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
        //caricamento griglia dati auto
        AUTOMOBILI a = new AUTOMOBILI();
        a.K_Auto = int.Parse(ddlAutomobili.SelectedValue);
        griglia_automobili.DataSource = a.SelectVendita();
        griglia_automobili.DataBind();

        //caricmento griglia dati spese auto
        SPESE_AUTO sa = new SPESE_AUTO();
        sa.K_Auto = int.Parse(ddlAutomobili.SelectedValue);
        griglia_spese.DataSource = sa.SPESE_AUTO_SelezionaAutomobile();
        griglia_spese.DataBind();
    }


    protected void CaricaCliente()
    {
        AUTOMOBILI a = new AUTOMOBILI();
        a.K_Cliente_Vendita = int.Parse(ddlClienti.SelectedValue);
        DataTable DT = new DataTable();
        DT = a.DatiClienteVendita();

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



    protected void btnInserimentoDtai_Click(object sender, EventArgs e)
    {

        //CONTROLLI FORMALI

        //controllo che i campi non siano vuoti
        if (
           String.IsNullOrEmpty(txtPrezzoOfferto.Text) ||
           String.IsNullOrEmpty(txtPrezzoVendita.Text) ||
           String.IsNullOrEmpty(txtDataVendita.Text)
           )
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Campi obbligatori vuoti');", true);
            return;
        }


        //controllo che il prezzo offerto e il prezzo di vendita siano dati validi
        if (!Decimal.TryParse(txtPrezzoOfferto.Text, out _) || !Decimal.TryParse(txtPrezzoVendita.Text, out _))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert(Uno dei dati di Prezzo inseriti non é valido);", true);
            return;
        }

        //controllo che la data inserita sia valida come formato
        if (!DateTime.TryParse(txtDataVendita.Text, out _))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data non valida');", true);
            return;

        }
        //controllo che la data inserita non sia oltre la data corrente
        DateTime dataOdierna = DateTime.Now;




        if (DateTime.Parse(txtDataVendita.Text) > dataOdierna)
        {

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('La data inserita supera la data corrente');", true);
            return;
        }

        //controllo che la data inserita non sia precedente a quella di acquisto 
        DateTime dataAcquisto;
        decimal prezzoAcquisto;
        AUTOMOBILI a = new AUTOMOBILI();
        a.K_Auto = int.Parse(ddlAutomobili.SelectedValue);
        DataTable DT = new DataTable();
        DT = a.SelectVendita();
        dataAcquisto = DateTime.Parse(DT.Rows[0]["Data_Acquisto"].ToString());
        prezzoAcquisto = Decimal.Parse(DT.Rows[0]["Prezzo_Acquisto"].ToString());


        if (DateTime.Parse(txtDataVendita.Text) < dataAcquisto)
        {

            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('La data inserita supera quella di acquisto');", true);
            return;
        }

        //controllo che il prezzo offerto e il prezzo di vendita sia maggiore del prezzo di acquisto

        if ((Decimal.Parse(txtPrezzoOfferto.Text) < prezzoAcquisto) || (Decimal.Parse(txtPrezzoVendita.Text) < prezzoAcquisto))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Vietato vendere auto in perdita');", true);
            return;
        }


        //controllo che i dati numerici siano validi
        if (
            txtPrezzoOfferto.Text.Contains(" ") ||
            txtPrezzoVendita.Text.Contains(" ")
           )
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati numerici non validi);", true);
            return;

        }



        //INSERIMENTO IN DB


        a.Prezzo_Offerto = Decimal.Parse(txtPrezzoOfferto.Text);
        a.Prezzo_Vendita = Decimal.Parse(txtPrezzoVendita.Text);
        a.Data_Vendita = DateTime.Parse(txtDataVendita.Text);
        a.K_Cliente_Vendita = int.Parse(ddlClienti.SelectedValue);
        a.K_Auto = int.Parse(ddlAutomobili.SelectedValue);

        a.RegistrazioneVendita();


        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati di vendita aggiunti correttamente');", true);

        txtPrezzoOfferto.Text = "";
        txtPrezzoVendita.Text = "";
        txtDataVendita.Text = "";

      
    }


}