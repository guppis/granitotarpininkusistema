using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GranitoTarpininkuSistema
{
  public partial class FORMA_Prisijungimas : Form
  {
    public FORMA_Prisijungimas()
    {
      InitializeComponent();
    }

    private void BTN_prisijungti_Click(object sender, EventArgs e)
    {
      var user = TXTBX_prisijungimoVardas.Text;
      var pass = TXTBX_slaptazodis.Text;
      var login = new Login.Login(user, pass);
      //check if eligible to be logged in 
      if (login.IsLoggedIn(user, pass))
      {
        var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;
        using (var sqlcon = new SqlConnection(connString))
        {
          sqlcon.Open();

          var query = "Select * from [userPass] where username = '" + user + "'";
          var sda = new SqlDataAdapter(query, sqlcon);
          var dtbl = new DataTable();

          sda.Fill(dtbl);
          if (dtbl.Rows.Count == 1)
          {
            var userRole = Convert.ToInt32(dtbl.Rows[0].ItemArray[2]);
            var savedPasswordHash = dtbl.Rows[0][1].ToString();
            //turn it into bytes
            var hashBytes = Convert.FromBase64String(savedPasswordHash);
            //take the salt out of the string
            var salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            //hash the user inputted PW with the salt
            var pbkdf2 = new Rfc2898DeriveBytes(TXTBX_slaptazodis.Text, salt, 10000);
            //put the damn thing in a byte vector.. instead of a string. why? why is this necessary?
            var hash = pbkdf2.GetBytes(20);
            //oh, this is why
            //compare results! letter by letter!
            //starting from 17 cause 0-16 are the salt
            var ok = 1;
            for (var i = 0; i < 20; i++)
              if (hashBytes[i + 16] != hash[i])
                ok = 0;
            if (ok == 1)
            {
              if (userRole == 0)
              {
                Global.GlobalVar = user;
                var atnaujinam = new atnaujintiPrisijungima();
                atnaujinam.paskutinisPrisijungimas(user);
                var adminPanel = new FORMA_adminPanele();
                Hide();
                adminPanel.ShowDialog();
              }
              else
              {
                Global.GlobalVar = user;
                var userPanel = new FORMA_User();
                var atnaujinam = new atnaujintiPrisijungima();
                atnaujinam.paskutinisPrisijungimas(user);
                Hide();
                userPanel.ShowDialog();
              }
            }
            else
            {
              MessageBox.Show("Neteisingas vartotojas ar slaptažodis!");
            }
          }
          else
          {
            MessageBox.Show("Neteisingas vartotojas ar slaptažodis!");
          }
        }
      }
    }
  }
}