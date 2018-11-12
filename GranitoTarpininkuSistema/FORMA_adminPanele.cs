using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace GranitoTarpininkuSistema
{
  public partial class FORMA_adminPanele : Form
  {
    public FORMA_adminPanele()
    {
      InitializeComponent();
      Text = Global.GlobalVar;
    }

    private static string NetworkGateway()
    {
      string ip = null;

      foreach (var f in NetworkInterface.GetAllNetworkInterfaces())
        if (f.OperationalStatus == OperationalStatus.Up)
          foreach (var d in f.GetIPProperties().GatewayAddresses)
            ip = d.Address.ToString();

      return ip;
    }

    public void Ping_all()
    {
      var gate_ip = NetworkGateway();

      //Extracting and pinging all other ip's.
      var array = gate_ip.Split('.');

      for (var i = 2; i <= 255; i++)
      {
        var ping_var = array[0] + "." + array[1] + "." + array[2] + "." + i;

        //time in milliseconds           
        Ping(ping_var, 4, 4000);
      }
    }

    public void Ping(string host, int attempts, int timeout)
    {
      for (var i = 0; i < attempts; i++)
        new Thread(delegate()
        {
          try
          {
            var ping = new Ping();
            ping.PingCompleted += PingCompleted;
            ping.SendAsync(host, timeout, host);
          }
          catch
          {
            // Do nothing and let it try again until the attempts are exausted.
            // Exceptions are thrown for normal ping failurs like address lookup
            // failed.  For this reason we are supressing errors.
          }
        }).Start();
    }

    private void PingCompleted(object sender, PingCompletedEventArgs e)
    {
      var ip = (string) e.UserState;
      if (e.Reply != null && e.Reply.Status == IPStatus.Success)
      {
        var hostname = GetHostName(ip);
        var macaddres = GetMacAddress(ip);
        var arr = new string[3];

        //store all three parameters to be shown on ListView
        arr[0] = ip;
        arr[1] = hostname;
        arr[2] = macaddres;

        // Logic for Ping Reply Success
        ListViewItem item;
        if (InvokeRequired)
          Invoke(new Action(() =>
          {
            item = new ListViewItem(arr);
            if (!LVIEW_kompuSarasas.Items.Contains(item))
              LVIEW_kompuSarasas.Items.Add(item); // TODO addina tuos pacius kompus
          }));
      }
    }

    public string GetHostName(string ipAddress)
    {
      try
      {
        var entry = Dns.GetHostEntry(ipAddress);
        if (entry != null) return entry.HostName;
      }
      catch (SocketException)
      {
        // MessageBox.Show(e.Message.ToString());
      }

      return null;
    }


    //Get MAC address
    public string GetMacAddress(string ipAddress)
    {
      string macAddress;
      var Process = new Process();
      Process.StartInfo.FileName = "arp";
      Process.StartInfo.Arguments = "-a " + ipAddress;
      Process.StartInfo.UseShellExecute = false;
      Process.StartInfo.RedirectStandardOutput = true;
      Process.StartInfo.CreateNoWindow = true;
      Process.Start();
      var strOutput = Process.StandardOutput.ReadToEnd();
      var substrings = strOutput.Split('-');
      if (substrings.Length >= 8)
      {
        macAddress = substrings[3].Substring(Math.Max(0, substrings[3].Length - 2))
                     + "-" + substrings[4] + "-" + substrings[5] + "-" + substrings[6]
                     + "-" + substrings[7] + "-"
                     + substrings[8].Substring(0, 2);
        return macAddress;
      }

      return "OWN Machine";
    }

    private void BTN_atnaujinti_Click(object sender, EventArgs e)
    {
      Ping_all();
    }

    private void BTN_aikstelesAtaskaita_Click(object sender, EventArgs e)
    {
      var ataskaita = new FORMA_ataskaituDatos();
      ataskaita.Show();
    }

    private void BTN_Tasker_Click(object sender, EventArgs e)
    {
      var tasker = new FORMA_TaskerMain();
      Hide();
      tasker.Show();
    }

    private void BTN_adminVartotojai_Click_1(object sender, EventArgs e)
    {
      var vartotojai = new FORMA_adminVartotojai();
      vartotojai.Show();
    }
  }
}