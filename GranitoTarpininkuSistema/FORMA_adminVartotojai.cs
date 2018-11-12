using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace GranitoTarpininkuSistema
{
  public partial class FORMA_adminVartotojai : Form
  {
    public FORMA_adminVartotojai()
    {
      InitializeComponent();
      this.Text = Global.GlobalVar;
      populateList();
    }

    private void BTN_adminVart_Prideti_Click(object sender, EventArgs e)
    {
      var prideti = new FORMA_adminVartotojaiPridejimas();
      prideti.Show();
    }

    public void populateList()
    {
      LSTVW_vartotojai.Items.Clear();
      LSTVW_vartotojai.View = View.Details;

      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;
      using (var sqlcon = new SqlConnection(connString))
      {
        sqlcon.Open();
        var ada = new SqlDataAdapter("select username,kadaSukurtas,paskutinisPrisijungimas,userRole from [userPass]",
          sqlcon);
        var dt = new DataTable();
        ada.Fill(dt);

        foreach (DataRow row in dt.Rows)
          try
          {


            var r = new ListViewItem(row.ItemArray.Select((i,index) =>
            {
              if (index == 1) return ((DateTime) i).ToShortDateString();
              return i.ToString();
            }).ToArray());
            LSTVW_vartotojai.Items.Add(r);
          }
          catch (Exception klaida)
          {
            MessageBox.Show(klaida.ToString());
          }
      }
     }


    private void BTN_adminVart_Istrinti_Click(object sender, EventArgs e)
    {
      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;

      using (var sqlcon = new SqlConnection(connString))
      {
        sqlcon.Open();
        foreach (int i in LSTVW_vartotojai.SelectedIndices)
        {
          var deleteUsername = LSTVW_vartotojai.Items[i].Text;
          LSTVW_vartotojai.Items.Remove(LSTVW_vartotojai.Items[i]);
          var del = "delete from userPass where username ='" + deleteUsername + "'";
          var sda = new SqlCommand(del, sqlcon);
          sda.ExecuteNonQuery();
        }
      }
    }

    private void adminVartotojai_Activated(object sender, EventArgs e)
    {
      populateList();
    }


    private void LSTVW_vartotojai_ItemActivate(object sender, EventArgs e)
    {
      var user = LSTVW_vartotojai.FocusedItem.Text;
      var forma = new FORMA_adminRedaguotiVartotoja(user);
      forma.ShowDialog();
    }
  }
}