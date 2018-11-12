namespace GranitoTarpininkuSistema
{
  partial class FORMA_Prisijungimas
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.TXTBX_prisijungimoVardas = new System.Windows.Forms.TextBox();
      this.TXTBX_slaptazodis = new System.Windows.Forms.TextBox();
      this.LBL_prisijungimoVardas = new System.Windows.Forms.Label();
      this.LBL_slaptazodis = new System.Windows.Forms.Label();
      this.BTN_prisijungti = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // TXTBX_prisijungimoVardas
      // 
      this.TXTBX_prisijungimoVardas.Location = new System.Drawing.Point(179, 68);
      this.TXTBX_prisijungimoVardas.Name = "TXTBX_prisijungimoVardas";
      this.TXTBX_prisijungimoVardas.Size = new System.Drawing.Size(120, 20);
      this.TXTBX_prisijungimoVardas.TabIndex = 0;
      // 
      // TXTBX_slaptazodis
      // 
      this.TXTBX_slaptazodis.Location = new System.Drawing.Point(179, 94);
      this.TXTBX_slaptazodis.Name = "TXTBX_slaptazodis";
      this.TXTBX_slaptazodis.PasswordChar = '*';
      this.TXTBX_slaptazodis.Size = new System.Drawing.Size(120, 20);
      this.TXTBX_slaptazodis.TabIndex = 1;
      this.TXTBX_slaptazodis.UseSystemPasswordChar = true;
      // 
      // LBL_prisijungimoVardas
      // 
      this.LBL_prisijungimoVardas.AutoSize = true;
      this.LBL_prisijungimoVardas.Location = new System.Drawing.Point(73, 74);
      this.LBL_prisijungimoVardas.Name = "LBL_prisijungimoVardas";
      this.LBL_prisijungimoVardas.Size = new System.Drawing.Size(97, 13);
      this.LBL_prisijungimoVardas.TabIndex = 2;
      this.LBL_prisijungimoVardas.Text = "Prisijungimo vardas";
      // 
      // LBL_slaptazodis
      // 
      this.LBL_slaptazodis.AutoSize = true;
      this.LBL_slaptazodis.Location = new System.Drawing.Point(73, 97);
      this.LBL_slaptazodis.Name = "LBL_slaptazodis";
      this.LBL_slaptazodis.Size = new System.Drawing.Size(61, 13);
      this.LBL_slaptazodis.TabIndex = 3;
      this.LBL_slaptazodis.Text = "Slaptazodis";
      // 
      // BTN_prisijungti
      // 
      this.BTN_prisijungti.Location = new System.Drawing.Point(140, 140);
      this.BTN_prisijungti.Name = "BTN_prisijungti";
      this.BTN_prisijungti.Size = new System.Drawing.Size(100, 30);
      this.BTN_prisijungti.TabIndex = 4;
      this.BTN_prisijungti.Text = "Prisijungti";
      this.BTN_prisijungti.UseVisualStyleBackColor = true;
      this.BTN_prisijungti.Click += new System.EventHandler(this.BTN_prisijungti_Click);
      // 
      // FORMA_Prisijungimas
      // 
      this.AcceptButton = this.BTN_prisijungti;
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.Green;
      this.ClientSize = new System.Drawing.Size(380, 257);
      this.Controls.Add(this.BTN_prisijungti);
      this.Controls.Add(this.LBL_slaptazodis);
      this.Controls.Add(this.LBL_prisijungimoVardas);
      this.Controls.Add(this.TXTBX_slaptazodis);
      this.Controls.Add(this.TXTBX_prisijungimoVardas);
      this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FORMA_Prisijungimas";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Prisijungimas";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox TXTBX_prisijungimoVardas;
    private System.Windows.Forms.TextBox TXTBX_slaptazodis;
    private System.Windows.Forms.Label LBL_prisijungimoVardas;
    private System.Windows.Forms.Label LBL_slaptazodis;
    private System.Windows.Forms.Button BTN_prisijungti;
  }
}

