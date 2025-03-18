using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class SALONI
{
	public int K_Salone;
	public string Nome_Salone;
	public string Indirizzo;
	public string CAP;
	public string Citta;
	public string Provincia;

	public SALONI()
	{

	}

	//inserimento
	public void Inserimento()
	{
		DB db = new DB();
		db.query = "SALONI_Inserimento";
		db.cmd.Parameters.AddWithValue("@nome_salone", Nome_Salone);
		db.cmd.Parameters.AddWithValue("@indirizzo", Indirizzo);
		db.cmd.Parameters.AddWithValue("@cap", CAP);
		db.cmd.Parameters.AddWithValue("@citta", Citta);
		db.cmd.Parameters.AddWithValue("@provincia", Provincia);
		db.SQLCommand();
	}
	//lista
	public DataTable SelectAll()
	{
		DB db = new DB();
		db.query = "SALONI_SelectAll";
		return db.SQLselect();

	}

	//seleziona nome
	public DataTable SelezionaSalone()
	{
		DB db = new DB();
		db.query = "SALONI_SelezionaSalone";
		db.cmd.Parameters.AddWithValue("@nome_salone", Nome_Salone);
		return db.SQLselect();
	}

	//modifica
	public void Modifica()
	{
		DB db = new DB();
		db.query = "SALONI_Update";
        db.cmd.Parameters.AddWithValue("@chiave", K_Salone);
        db.cmd.Parameters.AddWithValue("@nome_salone", Nome_Salone);
        db.cmd.Parameters.AddWithValue("@indirizzo", Indirizzo);
        db.cmd.Parameters.AddWithValue("@cap", CAP);
        db.cmd.Parameters.AddWithValue("@citta", Citta);
        db.cmd.Parameters.AddWithValue("@provincia", Provincia);
		db.SQLCommand();

    }
	//seleziona chiave
	public DataTable SelezionaChiave()
	{
		DB db = new DB();
		db.query = "SALONI_SelezionaChiave";
		db.cmd.Parameters.AddWithValue("@chiave", K_Salone);
		return db.SQLselect();
	}
	//verifico salone già esistente (modifica)

	public DataTable CheckRedundantRecords()
	{
		DB db = new DB();
		db.query = "SALONI_CheckRedundantRecords";
		db.cmd.Parameters.AddWithValue("@chiave", K_Salone);
		db.cmd.Parameters.AddWithValue("@nome_salone", Nome_Salone);
		db.cmd.Parameters.AddWithValue("@indirizzo", Indirizzo);
		db.cmd.Parameters.AddWithValue("@cap", CAP);
		db.cmd.Parameters.AddWithValue("@citta", Citta);
		db.cmd.Parameters.AddWithValue("@provincia", Provincia);
		return db.SQLselect();

	}
}