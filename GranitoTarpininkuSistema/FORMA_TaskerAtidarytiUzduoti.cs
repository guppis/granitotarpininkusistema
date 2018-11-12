using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GranitoTarpininkuSistema
{
  public partial class FORMA_TaskerAtidarytiUzduoti : Form
  {
    public FORMA_TaskerAtidarytiUzduoti(int id)
    {
      InitializeComponent();
      Text = id.ToString();
      supildytiNaudotojus();
      supildytiInfo(id);
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
    private void supildytiInfo(int id)
    {
      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;
      using (var sqlcon = new SqlConnection(connString))
      {
        try
        {
          var query = "SELECT * FROM [uzduotys] WHERE [id] = '" + id + "'";
          var dataAdapter = new SqlDataAdapter(query, sqlcon);
          sqlcon.Open();
          DataTable uzduotis = new DataTable();
          dataAdapter.Fill(uzduotis);
          dateTimePicker1.Value = (DateTime) uzduotis.Rows[0].ItemArray[1];
          CMBBX_skirta.Text = uzduotis.Rows[0].ItemArray[2].ToString();
          TXTBX_aprasymas.Text = uzduotis.Rows[0].ItemArray[3].ToString();
          TXTBX_komentarai.Text = uzduotis.Rows[0].ItemArray[4].ToString();
          if ((bool)(uzduotis.Rows[0].ItemArray[9]) == false)
          {
            LBL_uzduotiBaige.Visible = false;
            LBL_kasBaige.Visible = false;
            LBL_baigimoData.Visible = false;
            LBL_kadaBaige.Visible = false;
          }
          else
          {
            LBL_kadaBaige.Text = uzduotis.Rows[0].ItemArray[7].ToString();
            LBL_kasBaige.Text = uzduotis.Rows[0].ItemArray[8].ToString();
          }


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
            "UPDATE [uzduotys] SET AtliktiIki = @atliktiiki, Skirta = @skirta, Aprasymas = @aprasymas, Komentarai = @komentarai WHERE [id] = '" + Text  + "'";
          var comm = new SqlCommand(query, sqlcon);
          comm.Parameters.AddWithValue("@atliktiiki", dateTimePicker1.Value);
          comm.Parameters.AddWithValue("@skirta", CMBBX_skirta.Text);
          comm.Parameters.AddWithValue("@aprasymas", TXTBX_aprasymas.Text);
          comm.Parameters.AddWithValue("@komentarai", TXTBX_komentarai.Text);
          comm.ExecuteNonQuery();
        }
        catch (Exception ee)
        {
          MessageBox.Show("Klaida. " + ee.Message);
        }
      }
      MessageBox.Show("Užduotis sėkmingai redaguota!");
      Close();
    }

    private void BTN_UzbaigtiUzduoti_Click(object sender, EventArgs e)
    {
      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;
      using (var sqlcon = new SqlConnection(connString))
      {
        try
        {
          sqlcon.Open();
          var query =
            "UPDATE [uzduotys] SET AtliktiIki = @atliktiiki, Skirta = @skirta, Aprasymas = @aprasymas, Komentarai = @komentarai, BaigimoData = @baigimodata, UzduotiBaige = @uzduotibaige, ArBaigta = @arbaigta WHERE [id] = '" + Text + "'";
          var comm = new SqlCommand(query, sqlcon);
          comm.Parameters.AddWithValue("@atliktiiki", dateTimePicker1.Value);
          comm.Parameters.AddWithValue("@skirta", CMBBX_skirta.Text);
          comm.Parameters.AddWithValue("@aprasymas", TXTBX_aprasymas.Text);
          comm.Parameters.AddWithValue("@komentarai", TXTBX_komentarai.Text);
          comm.Parameters.AddWithValue("@baigimodata", DateTime.Now);
          comm.Parameters.AddWithValue("@uzduotibaige", Global.GlobalVar);
          comm.Parameters.AddWithValue("@arbaigta", true);
          comm.ExecuteNonQuery();
        }
        catch (Exception ee)
        {
          MessageBox.Show("Klaida. " + ee.Message);
        }
      }
      MessageBox.Show("Užduotis sėkmingai baigta!");
      Close();
    }
  }
}