using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GranitoTarpininkuSistema
{
  public partial class FORMA_TaskerMain : Form
  {
    private int kiekAsmeniniu { get; set; }
    private int perSiandien { get; set; }
    private int kiekSeniauUzduociu { get; set; }
    private int kiekDabarUzduociu { get; set; }

    public FORMA_TaskerMain()
    {
      InitializeComponent();
      Text = Global.GlobalVar;
      LentelesNustatymai();
      populateTasks();
      balloonAsmenines();
      naujuTimer();
      darbuTimer();
    }

    private void LentelesNustatymai()
    {
      taskerList.AutoGenerateColumns = false;
      taskerList.ColumnCount = 5;
      taskerList.Columns[0].HeaderText = "Atlikti iki";
      taskerList.Columns[0].DataPropertyName = "AtliktiIki";
      taskerList.Columns[1].HeaderText = "Skirta";
      taskerList.Columns[1].DataPropertyName = "Skirta";
      taskerList.Columns[2].HeaderText = "Aprasymas";
      taskerList.Columns[2].DataPropertyName = "Aprasymas";
      taskerList.Columns[3].DataPropertyName = "Id";
      taskerList.Columns[3].HeaderText = "id";
      taskerList.Columns[3].Visible = false;
      taskerList.Columns[4].DataPropertyName = "AtliktiIki";
      taskerList.Columns[4].HeaderText = "AtliktiIki";
      taskerList.Columns[4].Visible = false;
    }

    private void populateTasks()
    {
      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;
      using (var sqlcon = new SqlConnection(connString))
      {
        try
        {
          sqlcon.Open();
          var query = "Select id,AtliktiIki,Skirta,Aprasymas,Komentarai,ArBaigta " +
                      "from [uzduotys] " +
                      "where ([Skirta] = " +
                      "'Visiems' " +
                      "OR [Skirta] = '" + Text + "') " +
                      "AND [ArBaigta] = " + "'False'";
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
      foreach (DataGridViewRow uzduotis in taskerList.Rows)
      {
        DateTime dt;
        DateTime.TryParse(uzduotis.Cells[0].EditedFormattedValue.ToString(), out dt);
        int rezultatas = DateTime.Compare(dt, DateTime.Today);
        if (rezultatas < 0)
        {
          uzduotis.DefaultCellStyle.BackColor = Color.Red;
        }
      }
    }

    private void BTN_Prideti_Click(object sender, EventArgs e)
    {
      var pridetiUzduoti = new FORMA_TaskerPridetiUzduoti();
      pridetiUzduoti.ShowDialog();
    }

    private void BTN_Archyvas_Click(object sender, EventArgs e)
    {
      var archyvas = new FORMA_TaskerArchyvas();
      archyvas.ShowDialog();
    }

    private void TaskerMain_Activated(object sender, EventArgs e)
    {
      populateTasks();
    }

    private void FORMA_TaskerMain_Resize(object sender, EventArgs e)
    {
      if (this.WindowState == FormWindowState.Minimized)
      {
        Hide();
        notifyIcon1.Visible = true;
      }
    }

    private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      Show();
      this.WindowState = FormWindowState.Normal;
      notifyIcon1.Visible = false;
    }

    private void FORMA_TaskerMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        e.Cancel = true;
        Hide();
        notifyIcon1.Visible = true;
    }

    private void FORMA_TaskerMain_Load(object sender, EventArgs e)
    {
      naujuTimer();
      darbuTimer();
    }

    private void naujuTimer()
    {
      Timer naujosUzd = new Timer();
      naujosUzd.Interval = (5 * 60 * 1000); // 5 mins
      naujosUzd.Tick += new EventHandler(nauju_Tick);
      naujosUzd.Start();
    }

    private void darbuTimer()
    {
      Timer asmenines = new Timer();
      asmenines.Interval = (30 * 60 * 1000); // 30 mins 
      asmenines.Tick += new EventHandler(darbu_Tick);
      asmenines.Start();
    }

    private void nauju_Tick(object sender, EventArgs e)
    {
      balloonDarbu();
    }

    private void darbu_Tick(object sender, EventArgs e)
    {
      balloonAsmenines();
    }

    private void skaiciuotiDarbus()
    {
      foreach (DataGridViewRow row in taskerList.Rows)
      {
        if (row.Cells[1].Value.ToString() == Global.GlobalVar)
        {
          kiekAsmeniniu++;
        }
        if (DateTime.Equals(row.Cells[4].Value, DateTime.Today))
        {
          perSiandien++;
        }
      }

    }
    
    private void balloonAsmenines()
    {
      skaiciuotiDarbus();
      if (kiekAsmeniniu > 0 || perSiandien > 0)
      { 
      notifyIcon1.BalloonTipText = kiekAsmeniniu.ToString();
      notifyIcon1.ShowBalloonTip(5000);
      }
      darbuTimer();
    }

    private void balloonDarbu()
    {
      kiekSeniauUzduociu = taskerList.Rows.Count;
      populateTasks();
      kiekDabarUzduociu = taskerList.Rows.Count;
      if (kiekSeniauUzduociu < kiekDabarUzduociu)
      {
        notifyIcon1.BalloonTipText = kiekDabarUzduociu.ToString();
        notifyIcon1.ShowBalloonTip(5000); 
      }
      naujuTimer();
    }

    private void taskerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      var uzduotiesID = taskerList.CurrentRow.Cells[3].Value;
      var atidarytiUzduoti = new FORMA_TaskerAtidarytiUzduoti((int)uzduotiesID);
      atidarytiUzduoti.ShowDialog();
    }
  }
}