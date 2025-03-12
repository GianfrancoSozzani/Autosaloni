using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class DBConfig
{
    private string connectionString;
    public DBConfig()
	{
        // Modifica questa stringa con i tuoi parametri locali
        connectionString = "Data Source=DESKTOP-KM2T7UL\\SQLEXPRESS;Initial Catalog=AUTOSALONI;Integrated Security=True;Encrypt=False";
    }

    public string GetConnectionString()
    {
        return connectionString;
    }
}