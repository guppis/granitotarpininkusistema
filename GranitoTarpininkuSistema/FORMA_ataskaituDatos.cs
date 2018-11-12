using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace GranitoTarpininkuSistema
{
  public partial class FORMA_ataskaituDatos : Form
  {
    public FORMA_ataskaituDatos()
    {
      InitializeComponent();
      Text = Global.GlobalVar;
    }

    private void prisijungimas(string dataNuo, string dataIki)
    {
      istrintiArchyva();
      var o = new FirefoxOptions();
      o.AddArgument("-headless");
       
      IWebDriver driver = new FirefoxDriver(o);
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      driver.Url = "http://www.tarpininkai.eu/vartai/";
      driver.FindElement(By.Id("edt_login")).SendKeys("admin");
      //driver.FindElement(By.Id("edt_password")).SendKeys(""); slaptazodis
      driver.FindElement(By.Id("btn_submit1")).Submit();

      driver.Url = "http://www.tarpininkai.eu/vartai/control.php?page=reportbydeclarants";
      driver.FindElement(By.Id("edt_datefrom")).SendKeys(dataNuo);
      driver.FindElement(By.Id("edt_dateto")).SendKeys(dataIki);
      driver.FindElement(By.Id("btn_bydeclarants")).Submit();
      driver.SwitchTo().Window(driver.WindowHandles.Last());


      var visasLangas = driver.FindElement(By.XPath("/ html / body / table[2] / tbody"));
      var rows = visasLangas.FindElements(By.TagName("tr"));
      foreach (var row in rows)
      {
          var elementas = row.FindElements(By.TagName("td"));
        if (elementas.Count > 0)
        {
          var dek = elementas[0].Text;
          var visoTmp = elementas[1].Text.Split('/');
          var vD = Convert.ToInt32(visoTmp[0]);
          var vN = Convert.ToInt32(visoTmp[1]);
          var apmoketaTmp = elementas[2].Text.Split('/');
          var aD = Convert.ToInt32(apmoketaTmp[0]);
          var aN = Convert.ToInt32(apmoketaTmp[1]);
          if (aD > 0 || aN > 0) supildytiDeklarantus(dek, vD, vN, aD, aN);
        }
      }

      var arRasomSask = MessageBox.Show("Ar išrašyti sąskaitas?", "Išrašom", MessageBoxButtons.YesNo);
      if (arRasomSask == DialogResult.Yes)
      {
        var deklarantai = new FORMA_ataskaituDeklarantai();
        deklarantai.ShowDialog();
      }
      else if (arRasomSask == DialogResult.No) Close();

    }
    
    private void supildytiDeklarantus(string deklarantas, int visoDienu, int visoNaktu, int apmokamaDienu,
      int apmokamaNaktu)
    {
      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;
      using (var sqlcon = new SqlConnection(connString))
      {
        sqlcon.Open();
        var commString =
          "INSERT INTO [ataskaitaAiksteles](deklarantas,visoDienu,visoNaktu,apmokamaDienu,apmokamaNaktu) VALUES (@deklarantas,@visoDienu,@visoNaktu,@apmokamaDienu,@apmokamaNaktu)";
        using (var comm = new SqlCommand(commString, sqlcon))
        {
          comm.Parameters.AddWithValue("@deklarantas", deklarantas);
          comm.Parameters.AddWithValue("@visoDienu", visoDienu);
          comm.Parameters.AddWithValue("@visoNaktu", visoNaktu);
          comm.Parameters.AddWithValue("@apmokamaDienu", apmokamaDienu);
          comm.Parameters.AddWithValue("@apmokamaNaktu", apmokamaNaktu);
          comm.ExecuteNonQuery();
        }
      }
    }

    private void istrintiArchyva()
    {
      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;
      using (var sqlcon = new SqlConnection(connString))
      {
        sqlcon.Open();
        var commString = @"DELETE FROM [ataskaitaAiksteles]";
        using (var comm = new SqlCommand(commString, sqlcon))
        {
          comm.ExecuteNonQuery();
        }
      }
    }


    private void BTN_patvirtinti_Click(object sender, EventArgs e)
    {
      var dataNuo = dateTime_pradzia.Value.ToString("yyyy-MM-dd hh:mm");
      var dataIki = dateTime_pabaiga.Value.ToString("yyyy-MM-dd hh:mm");
      prisijungimas(dataNuo, dataIki);
    }
  }
}