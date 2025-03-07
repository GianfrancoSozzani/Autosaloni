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

    protected void btnInserimento_Click(object sender, EventArgs e)
    {
        //dichairo variabile di strorage per la modello inserito
        string inserimentoNome = txtNome.Text.Trim();
        string inserimentoIndirizzo = txtIndirizzo.Text.Trim();
        string inserimentoCitta = txtCittà.Text.Trim();
        string inserimentoCAP = txtCAP.Text;
        string inserimentoProvincia = txtProvincia.Text;





        //controlo che l'utente abbia effettivamente scritto qualcosa
        if (String.IsNullOrEmpty(inserimentoNome) ||
            String.IsNullOrEmpty(inserimentoIndirizzo) ||
            String.IsNullOrEmpty(inserimentoCitta) ||
            String.IsNullOrEmpty(inserimentoCAP) ||
            String.IsNullOrEmpty(inserimentoProvincia))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati non validi');", true);
            return;
        }

        if (inserimentoCAP.Length != 5)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('CAP non valido');", true);
            return;
        }
        if (inserimentoProvincia.Length != 2)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('provincia non valida');", true);
            return;
        }
        if ( inserimentoCAP.Contains(" ") || inserimentoProvincia.Contains(" "))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Dati alfanumerici non validi);", true);
            return;
        }

        //controllo che non sia già presente un autosalone con nome, città e indirizzo uguale

        //connesione database
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = @"Data Source=DESKTOP-KM2T7UL\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true;";

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandType = CommandType.Text; //fai attenzione a questo, importante!


        //controllo se l'autosalone non sia già presente
        cmd.CommandText = "select count(*) as [QUANTI] from SALONI where NOME_SALONE= '" + inserimentoNome + "' AND CITTA = '" + inserimentoCitta + "'";
        SqlDataAdapter DA = new SqlDataAdapter();
        DA.SelectCommand = cmd;
        DataTable DT = new DataTable();
        DA.Fill(DT);

        if ((int)DT.Rows[0]["QUANTI"] == 1) //ricordarsi di mettre (int) davanti
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Autosalone già presente allo stesso indirizzo in questa città');", true);
            return;
        }

        //Inserimento autosalone 
        cmd.CommandText = "insert into SALONI (NOME_SALONE,INDIRIZZO,CAP,CITTA,PROVINCIA) VALUES ('" + inserimentoNome + "','" + inserimentoIndirizzo + "','" + inserimentoCAP + "','" + inserimentoCitta + "','" + inserimentoProvincia + "')";

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        grigliaAutosaloni.DataBind(); //aggiorna i valori della griglia

        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Autosaloni Inserito Correttamente');", true);

        //svuoto i campi per un nuovo inserimento


        txtNome.Text = "";
        txtIndirizzo.Text = "";
        txtCittà.Text = "";
        txtCAP.Text = "";
        txtProvincia.Text = "";
    }
}