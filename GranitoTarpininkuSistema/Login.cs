using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GranitoTarpininkuSistema
{
  namespace Login
  {
    internal class Login
    {
      //intialise  
      public Login(string user, string pass)
      {
        Username = user;
        Userpassword = pass;
      }

      //decalare properties 
      public string Username { get; set; }

      public string Userpassword { get; set; }

      //validate string 
      private bool StringValidator(string input)
      {
        var pattern = "[^a-zA-Z]";
        if (Regex.IsMatch(input, pattern))
          return true;
        return false;
      }

      //validate password 
      private bool PasswordValidator(string input)
      {
        // 1 mazoji raide, 1 didzioji, bent 1 skaicius, tarp 6 ir 15
        if (Regex.IsMatch(input, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{6,15}$"))
          return true;
        return false;
      }

      //clear user inputs 
      private void ClearTexts(string user, string pass)
      {
        user = string.Empty;
        pass = string.Empty;
      }

      //method to check if eligible to be logged in 
      internal bool IsLoggedIn(string user, string pass)
      {
        //check user name empty 
        if (string.IsNullOrEmpty(user))
        {
          MessageBox.Show("Įveskite prisijungimo vardą");
          return false;
        }
        //check user name is valid type 

        if (StringValidator(user))
        {
          MessageBox.Show("Prisijungimo vardas gali būti tik tekstas");
          ClearTexts(user, pass);
          return false;
        }
        //check password is empty 

        if (string.IsNullOrEmpty(pass))
        {
          MessageBox.Show("Įveskite slaptažodį!");
          return false;
        }
        //check password is valid

        if (PasswordValidator(pass))
          return true;
        //check user name is or password is correct 

        if (Username != user || Userpassword != pass)
        {
          MessageBox.Show("Prisijungimo vardas arba slaptažodis yra neteisingas!");
          ClearTexts(user, pass);
          return false;
        }

        return true;
      }
    }
  }
}