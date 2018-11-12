using System;
using System.Windows.Forms;

namespace GranitoTarpininkuSistema
{
  public partial class FORMA_User : Form
  {
    public FORMA_User()
    {
      InitializeComponent();
      Text = Global.GlobalVar;
    }

    private void BTN_Tasker_Click(object sender, EventArgs e)
    {
      var tasker = new FORMA_TaskerMain();
      Hide();
      tasker.Show();
    }

    private void BTN_keistiSlaptazodi_Click(object sender, EventArgs e)
    {
      var keistiSlaptazodi = new FORMA_keistiSlaptazodi(Text);
      keistiSlaptazodi.Show();
    }
  }
}