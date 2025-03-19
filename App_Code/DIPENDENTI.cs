using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class DIPENDENTI
{
	public int K_Dipendente;
	public string Cognome;
	public string Nome;
	public string Ruolo;
	public int K_Salone;
	public string Codice_Fiscale;
	public DIPENDENTI()
	{

	}
	//inserimento
	public void Inserimento()
	{
		DB db = new DB();
		db.query = "DIPENDENTI_Inserimento";
		db.cmd.Parameters.AddWithValue("@cognome", Cognome);
		db.cmd.Parameters.AddWithValue("@nome", Nome);
		db.cmd.Parameters.AddWithValue("@ruolo", Ruolo);
		db.cmd.Parameters.AddWithValue("@salone", K_Salone);
		db.cmd.Parameters.AddWithValue("@codice_fiscale", Codice_Fiscale);
		db.SQLCommand();
	}
	//selezione dipendente per salone, ruolo, cognome, codice_fiscale
	public DataTable SelezionaDipendente()
	{
		DB db = new DB();
		db.query = "DIPENDENTI_SelezionaDipendente";
        db.cmd.Parameters.AddWithValue("@codice_fiscale", Codice_Fiscale);
		return db.SQLselect();

    }
	//lista
	public DataTable SelectAll()
	{
		DB db = new DB();
		db.query = "DIPENDENTI_SelectAll";
		return db.SQLselect();

    }
	//modifica
	public void Modifica()
	{
		DB db = new DB();
		db.query = "DIPENDENTI_Update";
        db.cmd.Parameters.AddWithValue("@chiave", K_Dipendente);
        db.cmd.Parameters.AddWithValue("@cognome", Cognome);
        db.cmd.Parameters.AddWithValue("@nome", Nome);
        db.cmd.Parameters.AddWithValue("@ruolo", Ruolo);
        db.cmd.Parameters.AddWithValue("@salone", K_Salone);
        db.cmd.Parameters.AddWithValue("@codice_fiscale", Codice_Fiscale);
        db.SQLCommand();
    }
	
	//seleziona chiave
	public DataTable SelezionaChiave()
	{
		DB db = new DB();
		db.query = "DIPENDENTI_SelezionaChiave";
        db.cmd.Parameters.AddWithValue("@chiave", K_Dipendente);
		return db.SQLselect();
    }

	//doppio dipendente
	public DataTable CheckRedundantRecords()
	{
		DB db = new DB();
		db.query = "DIPENDENTI_CheckRedundantRecords";
        db.cmd.Parameters.AddWithValue("@codice_fiscale", Codice_Fiscale);
        db.cmd.Parameters.AddWithValue("@chiave", K_Dipendente);
		return db.SQLselect();
    }

}