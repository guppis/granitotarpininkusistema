using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GranitoTarpininkuSistema
{
  public partial class FORMA_keistiSlaptazodi : Form
  {
    public FORMA_keistiSlaptazodi(string user)
    {
      InitializeComponent();
      Text = user;
    }

    private void BTN_issaugoti_Click(object sender, EventArgs e)
    {
      issaugotiSlaptazodi();
    }

    private void BTN_uzdaryti_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void issaugotiSlaptazodi()
    {
      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;
      using (var sqlcon = new SqlConnection(connString))
      {
        sqlcon.Open();

        var query = "Select [password] from [userPass] where username = '" + Text + "'";
        var sda = new SqlDataAdapter(query, sqlcon);
        var dtbl = new DataTable();

        sda.Fill(dtbl);
        if (dtbl.Rows.Count == 1)
        {
          var savedPasswordHash = dtbl.Rows[0].ItemArray[0].ToString();
          //turn it into bytes
          var hashBytes = Convert.FromBase64String(savedPasswordHash);
          //take the salt out of the string
          var salt = new byte[16];
          Array.Copy(hashBytes, 0, salt, 0, 16);
          //hash the user inputted PW with the salt
          var pbkdf2 = new Rfc2898DeriveBytes(TXTBX_senasSlaptazodis.Text, salt, 10000);
          //put the damn thing in a byte vector.. instead of a string. why? why is this necessary?
          var hash = pbkdf2.GetBytes(20);
          //oh, this is why
          //compare results! letter by letter!
          //starting from 17 cause 0-16 are the salt
          var ok = 1;
          for (var i = 0; i < 20; i++)
            if (hashBytes[i + 16] != hash[i])
              ok = 0;
          if (ok == 1) atnaujintiSlaptazodi();
        }
        else
        {
          MessageBox.Show("Neteisingas senas slaptažodis!");
        }
      }
    }

    private bool validatePass(string input)
    {
      // 1 mazoji raide, 1 didzioji, bent 1 skaicius, tarp 6 ir 15
      if (Regex.IsMatch(input, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{6,15}$"))
        return true;
      return false;
    }


    private void atnaujintiSlaptazodi()
    {
      if (TXTBX_naujasSlaptazodis.Text == TXTBX_pakartotinaiNaujas.Text)
      {
        if (validatePass(TXTBX_naujasSlaptazodis.Text))
        {
          var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;

          using (var sqlcon = new SqlConnection(connString))
          {
            sqlcon.Open();
            //hashing and stuff
            //make a new byte array
            byte[] salt;
            /*generate salt*/
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            /*hash and salt it using PBKDF2*/
            var pbkdf2 = new Rfc2898DeriveBytes(TXTBX_naujasSlaptazodis.Text, salt, 10000);
            //place the string in the byte array (thats waht getbytes does)
            var hash = pbkdf2.GetBytes(20);
            //make new byte array where to store the hashed password+salt
            //why 36? cause 20 are for the hash and 16 for the salt
            var hashBytes = new byte[36];
            //place the god damn things where they belong
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            //now, convert our fancy byte array to a string so i can put it in the db

            var savedPasswordHash = Convert.ToBase64String(hashBytes);
            var commString =
              "UPDATE [userPass] SET [password] = '" + savedPasswordHash + "'where username = '" + Text + "'";
            using (var comm = new SqlCommand(commString, sqlcon))
            {
             comm.ExecuteNonQuery();
            }
            MessageBox.Show("Slaptažodis pakeistas!");
          }
        }
        else
        {
          MessageBox.Show(
            "Slaptažodyje turi būti: 1 mažoji raidė, 1 didžioji raidė ir bent 1 skaicius. Slaptažodis turi susidaryti iš 6-15 simbolių");
        }
      }
      else
      {
        MessageBox.Show("Nesutampa naujas slaptažodis!");
      }
    }
  }
}