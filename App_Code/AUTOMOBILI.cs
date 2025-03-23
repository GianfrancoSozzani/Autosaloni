using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class AUTOMOBILI
{
    public int K_Auto;
    public int K_Modello;
    public string Stato;
    public DateTime Data_Acquisto;
    public int K_Cliente_Acquisto;
    public decimal Prezzo_Acquisto;
    public int K_Salone;
    public int K_Responsabile;
    public int K_Venditore;
    public string Alimentazione;
    public string Colore;
    public int KM;
    public string Cambio;
    public string Targa;
    public string Telaio;
    public string Condizione;
    public string Optional;
    public decimal Prezzo_Offerto;
    public decimal Prezzo_Vendita;
    public DateTime Data_Vendita;
    public int K_Cliente_Vendita;
    public int K_Marca;

    public AUTOMOBILI()
    {

    }

    //lista
    public DataTable SelectAll()
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_SelectAll";
        return db.SQLselect();
    }

    //ddl
    public DataTable AUTOMOBILI_ddlModelli()
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_ddlModelli";
        db.cmd.Parameters.AddWithValue("@marca", K_Marca);
        return db.SQLselect();
    }

    public DataTable AUTOMOBILI_ddlClienti()
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_ddlClienti";
        return db.SQLselect();
    }

    public DataTable AUTOMOBILI_ddlResponabiliSalone()
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_ddlResponsabiliSalone";
        db.cmd.Parameters.AddWithValue("@salone", K_Salone);
        return db.SQLselect();
    }

    public DataTable AUTOMOBILI_ddlVenditoriSalone()
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_ddlVenditoriSalone";
        db.cmd.Parameters.AddWithValue("@salone", K_Salone);
        return db.SQLselect();
    }

    //seleziona_automobile

    public DataTable AUTOMOBILI_SelezionaAutomobile()
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_SelezionaAutomobile";
        db.cmd.Parameters.AddWithValue("@vin", Telaio);
        return db.SQLselect();
    }

    //inserimento
    public void Inserimento()
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_Inserimento";
        db.cmd.Parameters.AddWithValue("@modello", K_Modello);
        db.cmd.Parameters.AddWithValue("@stato", Stato);
        db.cmd.Parameters.AddWithValue("@data_acquisto", Data_Acquisto);
        db.cmd.Parameters.AddWithValue("@cliente_acquisto", K_Cliente_Acquisto);
        db.cmd.Parameters.AddWithValue("@prezzo_acquisto", Prezzo_Acquisto);
        db.cmd.Parameters.AddWithValue("@salone", K_Salone);
        db.cmd.Parameters.AddWithValue("@responsabile", K_Responsabile);
        db.cmd.Parameters.AddWithValue("@venditore", K_Venditore);
        db.cmd.Parameters.AddWithValue("@alimentazione", Alimentazione);
        db.cmd.Parameters.AddWithValue("@colore", Colore);
        db.cmd.Parameters.AddWithValue("@km", KM);
        db.cmd.Parameters.AddWithValue("@cambio", Cambio);
        db.cmd.Parameters.AddWithValue("@targa", Targa);
        db.cmd.Parameters.AddWithValue("@vin", Telaio);
        db.cmd.Parameters.AddWithValue("@condizione", Condizione);
        db.cmd.Parameters.AddWithValue("@optional", Optional);
        db.SQLCommand();
    }

    //lista pagina vendita
    public DataTable SelectVendita()
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_SelezionaAutomobileVendita";
        db.cmd.Parameters.AddWithValue("@chiave", K_Auto);
        return db.SQLselect();
    }


    //dati cliente vendita
    public DataTable DatiClienteVendita()
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_DatiClienteVendita";
        db.cmd.Parameters.AddWithValue("@cliente", K_Cliente_Vendita);
        return db.SQLselect();
    }

    /// <summary>
    /// la query permette già la modifica in qaunto necessitando di un where é già un update (modifica inizialmente dati null)
    /// </summary>
    //inserimento dati vendita
    public void RegistrazioneVendita()
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_RiempimentoDatiVendita";
        db.cmd.Parameters.AddWithValue("@prezzo_offerto", Prezzo_Offerto);
        db.cmd.Parameters.AddWithValue("@prezzo_vendita", Prezzo_Vendita);
        db.cmd.Parameters.AddWithValue("@data_vendita", Data_Vendita);
        db.cmd.Parameters.AddWithValue("@cliente", K_Cliente_Vendita);
        db.cmd.Parameters.AddWithValue("@chiave", K_Auto);
        db.SQLCommand();
    }
    /// <summary>
    /// la query permette di selezioanare la marca in base al modello dell'auto selezionato nella pagina precedente
    /// </summary>
    //selezione della marca relativa all'automobile selezionata

    public DataTable SelezionaMarcaAutomobile()
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_SelezionaMarcaAutomobile";
        db.cmd.Parameters.AddWithValue("@chiave", K_Auto);
        return db.SQLselect();
    }


    public DataTable SelezionaDatiAutomobile()
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_SelezionaDatiAutomobile";
        db.cmd.Parameters.AddWithValue("@chiave", K_Auto);
        return db.SQLselect();
    }


    public DataTable ddlResponsabiliModifica()
    {
        DB db = new DB();
        db.query = "AUTOMOBILI_ddlResponsabiliModifica";
        db.cmd.Parameters.AddWithValue("@chiave", K_Auto);
        return db.SQLselect();
    }
}