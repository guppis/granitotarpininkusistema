using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GranitoTarpininkuSistema
{
  public partial class FORMA_ataskaituDeklarantai : Form
  {
   

    public FORMA_ataskaituDeklarantai()
    { 
      InitializeComponent();
      LentelesNustatymai();
      uzpildytiLentele();
    }

    private void LentelesNustatymai()
    {
      dgview_deklarantai.AutoGenerateColumns = false;
      dgview_deklarantai.ColumnCount = 3;
      dgview_deklarantai.Columns[0].HeaderText = "Deklarantas";
      dgview_deklarantai.Columns[0].DataPropertyName = "deklarantas";
      dgview_deklarantai.Columns[1].HeaderText = "Apmokama dienų";
      dgview_deklarantai.Columns[1].DataPropertyName = "apmokamaDienu";
      dgview_deklarantai.Columns[2].HeaderText = "Apmokama naktų";
      dgview_deklarantai.Columns[2].DataPropertyName = "apmokamaNaktu";
      DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
      checkColumn.Name = "X";
      checkColumn.HeaderText = "X";
      checkColumn.Width = 50;
      checkColumn.ReadOnly = false;
      checkColumn.FillWeight = 10;
      checkColumn.TrueValue = true;
      checkColumn.FalseValue = false;
      checkColumn.ValueType = typeof(bool);
      dgview_deklarantai.Columns.Add(checkColumn);
      
    }

    private void uzpildytiLentele()
    {
      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;
      DataTable dt = new DataTable();

      using (var sqlcon = new SqlConnection(connString))
      {
        sqlcon.Open();
        var commString = @"SELECT deklarantas,apmokamaDienu,apmokamaNaktu FROM [ataskaitaAiksteles]";
        using (var comm = new SqlCommand(commString, sqlcon))
        {
          SqlDataAdapter sda = new SqlDataAdapter(comm);
          sda.Fill(dt);
          dt.Columns.Add("check", typeof(bool));
          dt.Columns["check"].DefaultValue = true;
          dgview_deklarantai.DataSource = dt;
          comm.ExecuteNonQuery();
        }
      }
    }

    private void dgview_deklarantai_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      dgview_deklarantai.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !(bool)dgview_deklarantai.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
    }

    private void FORMA_ataskaituDeklarantai_Load(object sender, EventArgs e)
    {
      foreach (DataGridViewRow row in dgview_deklarantai.Rows)
      {
        row.Cells[3].Value = true;
      }
    }

    private void BTN_israsyti_Click(object sender, EventArgs e)
    {
      var list = new List<Tuple<string, int, int>>();
      var checkedRows = from DataGridViewRow r in dgview_deklarantai.Rows
                        where Convert.ToBoolean(r.Cells[3].Value) == true
                        select r;
      foreach (var row in checkedRows)
      {
        list.Add(new Tuple<string, int, int>(row.Cells[0].Value.ToString(), (int)row.Cells[1].Value, (int)row.Cells[2].Value));
      }

      foreach (var item in list)
      {

      }
    }
  }
}
