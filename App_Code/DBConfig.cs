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
        connectionString = "Data Source = DESKTOP-705G4DM\\SQLEXPRESS; Initial Catalog=AUTOSALONI; Integrated Security=true";
    }

    public string GetConnectionString()
    {
        return connectionString;
    }
}