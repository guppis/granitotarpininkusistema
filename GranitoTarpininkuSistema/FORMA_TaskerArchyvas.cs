using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GranitoTarpininkuSistema
{
  public partial class FORMA_TaskerArchyvas : Form
  {
    public FORMA_TaskerArchyvas()
    {
      InitializeComponent();
      WindowState = FormWindowState.Maximized;
      populateTasks();
    }

    private void populateTasks()
    {
      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;
      using (var sqlcon = new SqlConnection(connString))
      {
        try
        {
          sqlcon.Open();
          var query = "Select * from [uzduotys] where ArBaigta = 'True'";
          var command = new SqlCommand(query, sqlcon);
          var dataAdapter = new SqlDataAdapter(command);
          var dt = new DataTable();
          dataAdapter.Fill(dt);
          taskerList.DataSource = dt;
        }
        catch (Exception exception)
        {
          MessageBox.Show(exception.Message);
        }
      }
    }

    private void taskerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      var uzduotiesID = taskerList.CurrentRow.Cells[0].Value;
      var atidarytiUzduoti = new FORMA_TaskerAtidarytiUzduoti((int)uzduotiesID);
      atidarytiUzduoti.ShowDialog();
    }
  }
}
