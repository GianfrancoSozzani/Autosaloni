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
	//seleziona chiave
	//doppio dipendente

}