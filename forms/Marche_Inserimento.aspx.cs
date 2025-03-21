﻿using System;
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
        CaricaDati();
    }



    protected void btnSalva_Click(object sender, EventArgs e)
    {
        //dichairo variabile di strorage per la marca inserita
        string inserimentoMarca = txtInserimento.Text.Trim();
        //controlo che l'utente abbia effettivamente scritto qualcosa
        if (String.IsNullOrEmpty(inserimentoMarca))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati non validi');", true);
            return;
        }

        MARCHE m = new MARCHE();
        m.Marca = inserimentoMarca;
        DataTable DT = new DataTable();
        DT = m.SelezionaMarca();

        //controllo che non sia già presente la marca
        if (DT.Rows.Count != 0) 
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Marca già presente');", true);
            return;
        }

        //se non è presente inserimento
        m.Inserimento();

        //aggiorna i valori della griglia
        //forzo il ricaricamento della griglia in questo caso (vedasi Marche_Modifica)
        CaricaDati();
        //avviso l'utente che la registrazione è avvenuta correttamente
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Marca inserita correttamente');", true);

        //svuot il textbox per procedere ad un nuvo inserimento
        txtInserimento.Text = "";

    }


    protected void CaricaDati()
    {
        MARCHE m = new MARCHE();
        grigliaMarche.DataSource = m.SelectAll();
        grigliaMarche.DataBind();

    }

    protected void grigliaMarche_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //tolgo visibilità a k_marca
        e.Row.Cells[0].Visible = false;
    }
}
