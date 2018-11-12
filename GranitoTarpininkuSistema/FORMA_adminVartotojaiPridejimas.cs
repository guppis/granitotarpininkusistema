using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GranitoTarpininkuSistema
{
  public partial class FORMA_adminVartotojaiPridejimas : Form
  {
    public FORMA_adminVartotojaiPridejimas()
    {
      InitializeComponent();
      Text = Global.GlobalVar;
    }

    private void BTN_prideti_Click(object sender, EventArgs e)
    {
      var connString = ConfigurationManager.ConnectionStrings["Granito"].ConnectionString;

      using (var sqlcon = new SqlConnection(connString))
      {
        sqlcon.Open();
        var query = "Select * from [userPass] Where username = '" + TXTBX_prideti_prisijungimoVardas.Text + "'";

        var sda = new SqlDataAdapter(query, sqlcon);
        var dtbl = new DataTable();
        sda.Fill(dtbl);

        if (dtbl.Rows.Count > 0)
        {
          MessageBox.Show("Vartotojo vardas jau egzistuoja!");
        }
        else
        {
          var commString =
            "INSERT INTO [userPass](username,password,userRole) VALUES (@username,@password,@userRole)";

          //hashing and stuff
          //make a new byte array
          byte[] salt;
          /*generate salt*/
          new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
          /*hash and salt it using PBKDF2*/
          var pbkdf2 = new Rfc2898DeriveBytes(TXTBX_prideti_slaptazodis.Text, salt, 10000);
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
          using (var comm = new SqlCommand(commString, sqlcon))
          {
            comm.Parameters.AddWithValue("@username", TXTBX_prideti_prisijungimoVardas.Text);
            comm.Parameters.AddWithValue("@password", savedPasswordHash);
            if (CHKBX_arAdmin.Checked) comm.Parameters.AddWithValue("@userRole", "0");
            else if (!CHKBX_arAdmin.Checked) comm.Parameters.AddWithValue("@userRole", "1");
            comm.ExecuteNonQuery();
          }

          MessageBox.Show("Registracija pavyko!");
        }
      }
    }
  }
}