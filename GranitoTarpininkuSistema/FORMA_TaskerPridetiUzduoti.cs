using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GranitoTarpininkuSistema
{
  public partial class FORMA_TaskerPridetiUzduoti : Form
  {
    public FORMA_TaskerPridetiUzduoti()
    {
      InitializeComponent();
      Text = Global.GlobalVar;
      dateTimePicker1.Value = DateTime.Today;
      supildytiNaudotojus();
    }

    private void supildytiNaudotojus()
    {
      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;
      using (var sqlcon = new SqlConnection(connString))
      {
        try
        {
          var query = "SELECT [username] FROM [userPass] ORDER BY [id]";
          var dataAdapter = new SqlDataAdapter(query, sqlcon);
          sqlcon.Open();
          var dataSet = new DataSet();
          dataAdapter.Fill(dataSet, "userPass");
          CMBBX_skirta.DisplayMember = "username";
          CMBBX_skirta.ValueMember = "username";
          CMBBX_skirta.DataSource = dataSet.Tables["userPass"];
        }
        catch (Exception ex)
        {
          MessageBox.Show("Klaida.");
        }
      }
    }

    private void BTN_Issaugoti_Click(object sender, EventArgs e)
    {
      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;
      using (var sqlcon = new SqlConnection(connString))
      {
        try
        {
          sqlcon.Open();
          var query =
            "INSERT INTO [uzduotys] (atliktiiki,skirta,aprasymas,komentarai,uzduotiSukure,sukurimoData,arbaigta) VALUES (@atliktiiki,@skirta,@aprasymas,@komentarai,@uzduotiSukure,@sukurimoData,@arbaigta)";
          var comm = new SqlCommand(query, sqlcon);
          comm.Parameters.AddWithValue("@atliktiiki", dateTimePicker1.Value);
          comm.Parameters.AddWithValue("@skirta", CMBBX_skirta.Text);
          comm.Parameters.AddWithValue("@aprasymas", TXTBX_aprasymas.Text);
          comm.Parameters.AddWithValue("@komentarai", TXTBX_komentarai.Text);
          comm.Parameters.AddWithValue("@uzduotiSukure", Text);
          comm.Parameters.AddWithValue("@sukurimoData", DateTime.Today);
          comm.Parameters.AddWithValue("@arBaigta", false);
          comm.ExecuteNonQuery();
        }
        catch (Exception ee)
        {
          MessageBox.Show("Klaida. " + ee.Message);
        }
      }
      MessageBox.Show("Užduotis sėkmingai pridėta");
    }

    private void BTN_UzbaigtiUzduoti_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}