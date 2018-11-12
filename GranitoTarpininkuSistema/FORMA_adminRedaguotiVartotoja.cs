using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GranitoTarpininkuSistema
{
  public partial class FORMA_adminRedaguotiVartotoja : Form
  {
    private void issaugotiInfo()
    {
      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;
      using (var sqlcon = new SqlConnection(connString))
      {
        try
        {
          sqlcon.Open();
          var commString =
            "UPDATE [userPass] SET [userRole] = '" + numericUpDown_vartRole.Value + "', [kadaSukurtas] = '" + dateTime_kadaSukurtas.Value + "', [paskutinisPrisijungimas] = '" + dateTime_paskutinisPrisijungimas.Value + "'where username = '" + LBL_redVart.Text + "'";
          using (var comm = new SqlCommand(commString, sqlcon))
          {
            comm.ExecuteNonQuery();
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Klaida.");
        }
      }
    }

    private void pildytiInfo()
    {
      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;
      using (var sqlcon = new SqlConnection(connString))
      {
        try
        {
          var query = "Select * from [userPass] where username = '" + LBL_redVart.Text + "'";
          var dataAdapter = new SqlDataAdapter(query, sqlcon);
          sqlcon.Open();
          var dataTable = new DataTable();
          dataAdapter.Fill(dataTable);
          DataRow row = dataTable.Rows[0];
          dateTime_kadaSukurtas.Value = (DateTime) row.ItemArray[4];
          dateTime_paskutinisPrisijungimas.Value = (DateTime) row.ItemArray[5];
          numericUpDown_vartRole.Value = Convert.ToDecimal(row.ItemArray[2]) ;
        }
        catch (Exception ex)
        {
          MessageBox.Show("Klaida.");
        }
      }
    }

    public FORMA_adminRedaguotiVartotoja(string username)
    {
      InitializeComponent();
      LBL_redVart.Text = username;
      Text = Global.GlobalVar;
      pildytiInfo();
    }

    private void BTN_pakeistiSlaptazodi_Click(object sender, EventArgs e)
    {
      var pakeisti = new FORMA_keistiSlaptazodi(LBL_redVart.Text);
      pakeisti.Show();
    }

    private void BTN_atsaukti_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void BTN_issaugoti_Click(object sender, EventArgs e)
    {
      issaugotiInfo();
      Close();
    }
  }
}
