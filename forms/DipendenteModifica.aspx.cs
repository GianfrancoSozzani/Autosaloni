﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Default2 : System.Web.UI.Page
{
    static string chiave;
    protected void Page_Load(object sender, EventArgs e)
    {

        CaricaDati();

        if (!IsPostBack) // Popola la dropdown solo al primo caricamento della pagina
        {
            // Aggiungi la voce "V"
            ddlRuolo.Items.Add(new ListItem("Venditore", "V")); // Testo visualizzato, Valore effettivo

            // Aggiungi la voce "R"
            ddlRuolo.Items.Add(new ListItem("Responsabile", "R")); // Testo visualizzato, Valore effettivo

            // Facoltativo: Aggiungere una voce predefinita (es. "Seleziona ruolo")
            //ddlRuolo.Items.Insert(0, new ListItem("Seleziona Ruolo", "")); // Inserisce all'inizio
        }
    }

    protected void CaricaDati()
    {
        DB database = new DB();
        database.query = "DIPENDENTI_SelectAll";
        griglia.DataSource = database.SQLselect();
        griglia.DataBind();
    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        chiave = griglia.SelectedValue.ToString();
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        if (griglia.SelectedIndex == -1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Seleziona un record');", true);
            return;
        }

        divmodifica.Visible = true;
        DB database = new DB();
        database.query = "DIPENDENTE_SelezionaChiave";
        database.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));

        DataTable DT = new DataTable();
        DT = database.SQLselect();
        txtCognome.Text = DT.Rows[0]["Cognome"].ToString();
        txtNome.Text = DT.Rows[0]["Nome"].ToString();
        ddlRuolo.SelectedValue = DT.Rows[0]["Ruolo"].ToString();

    }



    protected void btnSalva_Click(object sender, EventArgs e)
    {
        if ((String.IsNullOrEmpty(txtCognome.Text)) || (String.IsNullOrEmpty(txtNome.Text)))

        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('I campi Cognome e Nome non possono essere vuoti');", true);
            return;
        }

        DB db = new DB();
        db.query = "DIPENDENTE_Controllo";
        db.cmd.Parameters.AddWithValue("@cognome", txtCognome.Text);
        db.cmd.Parameters.AddWithValue("@nome", txtNome.Text);
        DataTable DT = new DataTable();
        DT = db.SQLselect();

        if ((int)DT.Rows[0]["CONTROLLO"] == 1)
        {
            // Mostra un avviso e interrompe l'operazione
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dipendente già presente');", true);
            return;
        }

        DB db2 = new DB();
        db2.query = "DIPENDENTI_Update";
        db2.cmd.Parameters.AddWithValue("@chiave", int.Parse(chiave));
        db2.cmd.Parameters.AddWithValue("@cognome", txtCognome.Text.Trim());
        db2.cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
        db2.cmd.Parameters.AddWithValue("@ruolo", ddlRuolo.SelectedValue);

        db2.SQLcommand();
        CaricaDati();
        divmodifica.Visible = false;
    }
}