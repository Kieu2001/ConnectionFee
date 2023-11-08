using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using System.Data;

public partial class _Default : Page
{
    string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.144.13.7)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SID=ee)));User Id=VM;Password=Oracle12321";
    ReportDocument crystalReport = new ReportDocument();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void VTL_A_1_Click(object sender, EventArgs e)
    {
        string sqlQuery = "SELECT * FROM ";

        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(sqlQuery, connection))
                {
                     
                    using (OracleDataReader reader = command.ExecuteReader())
                    {

                        DataSet ds = new DataSet();

                    }
                }
                connection.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}