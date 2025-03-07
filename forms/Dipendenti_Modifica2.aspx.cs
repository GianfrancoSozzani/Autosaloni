﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //dichiaro una variabile per storare il valore passato dll'altra pagina per k_dipendente
    static string chiave;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            // Popola la dropdown solo al primo caricamento della pagina
            // Aggiungi la voce "V"
            ddlRuoli.Items.Add(new ListItem("Venditore", "V")); // Testo visualizzato, Valore effettivo
            // Aggiungi la voce "R"
            ddlRuoli.Items.Add(new ListItem("Responsabile", "R")); // Testo visualizzato, Valore effettivo

            //chiave assumerà il valore c che ricevo dalla pagina Dipendenti_Modifica
            chiave = Request.QueryString["c"].ToString();

            //CARICAMENTO DROPDOWNLIST GENERALE
            //collagmento a DB
            DB database = new DB();
            //eseguo query
            database.query = "SALONI_SelectAll";
            ddlSaloni.DataSource = database.SQLselect();
            ddlSaloni.DataValueField = "K_Salone";
            ddlSaloni.DataTextField = "Nome_Salone";
            //indico come la ddl deve visualizzare i valori

            //aggiornamento ddl
            ddlSaloni.DataBind();

            //CARICO VALORI SELEZIONATI NELLA DDL(saloni) e nel TEXTBOX(Nome,Cognome) in base ai valori scelti nella pagina di partenza
            //collegamento database
            DB stampdatabase = new DB();
            //gli passo la query che stampera i valori dalla tabella MODELLI in base alla chiave
            stampdatabase.query = "DIPENDENTI_SelezionaChiave";
            stampdatabase.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));
            DataTable DT = new DataTable();
            DT = stampdatabase.SQLselect();
            //valore ddl (saloni)
            ddlSaloni.SelectedValue = DT.Rows[0]["K_Salone"].ToString();
            //valore ddl (ruoli)
            ddlRuoli.SelectedValue = DT.Rows[0]["Ruolo"].ToString();
            //valore in textbox (cognome)
            txtCognome.Text = DT.Rows[0]["Cognome"].ToString();
            //valore in textbox (nome)
            txtNome.Text = DT.Rows[0]["Nome"].ToString();

        }
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        //controlli formali

        //controllo che l'utente abbia effettivamante scritto qualcosa

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        //collegamento al database
        DB x = new DB();
        //passare la query con il valore del parametro desiderato per indicargli dove fare la modifica (SQL where)
        x.query = "DIPENDENTI_Update";
        x.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));
        x.cmd.Parameters.AddWithValue("@cognome", txtCognome.Text.Trim());
        x.cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
        x.cmd.Parameters.AddWithValue("@ruolo", ddlRuoli.SelectedValue);
        x.cmd.Parameters.AddWithValue("@salone", ddlSaloni.SelectedValue);
        //eseguo il comando di update
        x.SQLCommand();

        //ritorno a Marche_Modifica
        Response.Redirect("Dipendenti_Modifica.aspx");
    }
}