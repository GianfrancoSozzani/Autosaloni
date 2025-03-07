using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_MarcaModifica : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Get the selected row.
        GridViewRow row = griglia.SelectedRow;

        // Check if a row is actually selected.
        if (row != null)
        {
            // Extract the "Marca" value from the selected row.
            //  The index of the Marca column depends on your GridView's Columns definition.
            //  In your case, Marca is the *second* BoundField (index 1).  K_Marca is index 0.
            string marca = row.Cells[2].Text; // Cells[0] is the select button, Cells[1] is K_Marca. Cells[2] is Marca

            // Update the Label's text with the selected Marca.
            Label1.Text = "Marca Selezionata: " + marca;

            //OPTIONAL:  Update the textbox as well.
            TextBox1.Text = marca;
        }
    }
}