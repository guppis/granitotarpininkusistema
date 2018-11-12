using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GranitoTarpininkuSistema
{
  internal class atnaujintiPrisijungima
  {
    private string user;

    public void paskutinisPrisijungimas(string useris)
    {
      user = useris;
      atnaujinti();
    }

    private void atnaujinti()
    {
      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;
      using (var sqlcon = new SqlConnection(connString))
      {
        try
        {
          sqlcon.Open();
          var query = "UPDATE [userPass] SET [paskutinisPrisijungimas] = '" + DateTime.Now +
                      "'where username = '" + user + "'";
          var sda = new SqlCommand(query, sqlcon);
          sda.ExecuteNonQuery();
        }
        catch (Exception klaida)
        {
          MessageBox.Show(klaida.ToString());
        }
      }
    }
  }
}