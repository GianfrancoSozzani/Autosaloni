using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class DIPENDENTI
{
	public int K_Dipendente;
	public string Cognome;
	public string Nome;
	public string Ruolo;
	public string K_Salone;
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
	
	//lista
	//modifica
	//seleziona chiave
	//doppio dipendente
}