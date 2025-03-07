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

    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        //dichairo variabile di strorage per la modello inserito
        string inserimentoModello = txtInserimento.Text.Trim();

        //dichiaro una variabile di storage per la marca (presa dal menù a tendina)
        string MarcaScelta = ddlMarche.SelectedValue;

        //controlo che l'utente abbia effettivamente scritto qualcosa
        if (String.IsNullOrEmpty(inserimentoModello))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati non validi');", true);
            return;
        }

        //controllo che non sia già presente la marca

        //connesione database
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = @"Data Source=DESKTOP-KM2T7UL\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true;";

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandType = CommandType.Text; //fai attenzione a questo, importante!


        //controllo se il modello non sia già presente
        cmd.CommandText = "select count(*) as [QUANTI] from MODELLI where MODELLO = '" + inserimentoModello + "' AND K_MARCA = '" + MarcaScelta + "'";
        SqlDataAdapter DA = new SqlDataAdapter();
        DA.SelectCommand = cmd;
        DataTable DT = new DataTable();
        DA.Fill(DT);

        if ((int)DT.Rows[0]["QUANTI"] == 1) //ricordarsi di mettre (int) davanti
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Modello già presente');", true);
            return;
        }

        //Inserimento modello con marca associata
        cmd.CommandText = "insert into MODELLI (MODELLO,K_MARCA) VALUES ('" + inserimentoModello + "','" + MarcaScelta + "')";

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        grigliaModelli.DataBind(); //aggiorna i valori della griglia

        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Modello aggiunto correttamente');", true);

        txtInserimento.Text = "";
    }
}