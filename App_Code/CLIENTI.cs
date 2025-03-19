using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class CLIENTI
{
    //fields (attributes)
    public int K_Cliente;
    public string Cognome;
    public string Nome;
    public string Codice_Fiscale;
    public string Citta;
    public string Indirizzo;
    public string CAP;
    public string Provincia;
    public string Codice_Patente;
    public DateTime Data_di_Nascita;

    public CLIENTI()
    {
        
    }

    //lista
    public DataTable SelectAll()
    {
        DB db = new DB();
        db.query = "CLIENTI_SelectAll";
        return db.SQLselect();
    }

    //seleziona cliente
    public DataTable SelezionaCliente()
    {
        DB db = new DB();
        db.query = "CLIENTI_SelezionaCliente";
        db.cmd.Parameters.AddWithValue("@codice_fiscale", Codice_Fiscale);
        db.cmd.Parameters.AddWithValue("@codice_patente", Codice_Patente);
        return db.SQLselect();
    }
    
    //inserimento
    public void Inserimento()
    {
        DB db = new DB();
        db.query = "CLIENTI_Inserimento";
        db.cmd.Parameters.AddWithValue("@cognome", Cognome);
        db.cmd.Parameters.AddWithValue("@nome", Nome);
        db.cmd.Parameters.AddWithValue("@codice_fiscale", Codice_Fiscale);
        db.cmd.Parameters.AddWithValue("@citta", Citta);
        db.cmd.Parameters.AddWithValue("@provincia", Provincia);
        db.cmd.Parameters.AddWithValue("@indirizzo", Indirizzo);
        db.cmd.Parameters.AddWithValue("@cap", CAP);
        db.cmd.Parameters.AddWithValue("@codice_patente", Codice_Patente);
        db.cmd.Parameters.AddWithValue("@data_nascita", Data_di_Nascita);
        db.SQLCommand();
    }

    //seleziona chiave

    public DataTable SelezionaChiave()
    {
        DB db = new DB();
        db.query = "CLIENTI_SelezionaChiave";
        db.cmd.Parameters.AddWithValue("@chiave", K_Cliente);
        return db.SQLselect();
    }

    //doppi clienti 

    public DataTable CheckRedundantRecords()
    {
        DB db = new DB();
        db.query = "CLIENTI_CheckRedundantRecords";
        db.cmd.Parameters.AddWithValue("@chiave", K_Cliente);
        db.cmd.Parameters.AddWithValue("@codice_fiscale", Codice_Fiscale);
        db.cmd.Parameters.AddWithValue("@codice_patente", Codice_Patente);
        return db.SQLselect();
    }

    //modifica
    public void Modifica()
    {
        DB db = new DB();
        db.query = "CLIENTI_Update";
        db.cmd.Parameters.AddWithValue("@chiave", K_Cliente);
        db.cmd.Parameters.AddWithValue("@cognome", Cognome);
        db.cmd.Parameters.AddWithValue("@nome", Nome);
        db.cmd.Parameters.AddWithValue("@codice_fiscale", Codice_Fiscale);
        db.cmd.Parameters.AddWithValue("@citta", Citta);
        db.cmd.Parameters.AddWithValue("@provincia", Provincia);
        db.cmd.Parameters.AddWithValue("@indirizzo", Indirizzo);
        db.cmd.Parameters.AddWithValue("@cap", CAP);
        db.cmd.Parameters.AddWithValue("@codice_patente", Codice_Patente);
        db.cmd.Parameters.AddWithValue("@data_nascita", Data_di_Nascita);
        db.SQLCommand();
    }
}