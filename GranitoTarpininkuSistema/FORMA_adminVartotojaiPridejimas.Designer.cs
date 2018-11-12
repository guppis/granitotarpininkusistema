namespace GranitoTarpininkuSistema
{
  partial class FORMA_adminVartotojaiPridejimas
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
      this.LBL_prideti_prisijungimoVardas = new System.Windows.Forms.Label();
      this.LBL_prideti_slaptazodis = new System.Windows.Forms.Label();
      this.TXTBX_prideti_prisijungimoVardas = new System.Windows.Forms.TextBox();
      this.TXTBX_prideti_slaptazodis = new System.Windows.Forms.TextBox();
      this.CHKBX_arAdmin = new System.Windows.Forms.CheckBox();
      this.BTN_prideti = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // LBL_prideti_prisijungimoVardas
      // 
      this.LBL_prideti_prisijungimoVardas.AutoSize = true;
      this.LBL_prideti_prisijungimoVardas.Location = new System.Drawing.Point(23, 35);
      this.LBL_prideti_prisijungimoVardas.Name = "LBL_prideti_prisijungimoVardas";
      this.LBL_prideti_prisijungimoVardas.Size = new System.Drawing.Size(97, 13);
      this.LBL_prideti_prisijungimoVardas.TabIndex = 0;
      this.LBL_prideti_prisijungimoVardas.Text = "Prisijungimo vardas";
      this.LBL_prideti_prisijungimoVardas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // LBL_prideti_slaptazodis
      // 
      this.LBL_prideti_slaptazodis.AutoSize = true;
      this.LBL_prideti_slaptazodis.Location = new System.Drawing.Point(23, 63);
      this.LBL_prideti_slaptazodis.Name = "LBL_prideti_slaptazodis";
      this.LBL_prideti_slaptazodis.Size = new System.Drawing.Size(61, 13);
      this.LBL_prideti_slaptazodis.TabIndex = 1;
      this.LBL_prideti_slaptazodis.Text = "Slaptazodis";
      this.LBL_prideti_slaptazodis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // TXTBX_prideti_prisijungimoVardas
      // 
      this.TXTBX_prideti_prisijungimoVardas.Location = new System.Drawing.Point(126, 32);
      this.TXTBX_prideti_prisijungimoVardas.Name = "TXTBX_prideti_prisijungimoVardas";
      this.TXTBX_prideti_prisijungimoVardas.Size = new System.Drawing.Size(142, 20);
      this.TXTBX_prideti_prisijungimoVardas.TabIndex = 2;
      // 
      // TXTBX_prideti_slaptazodis
      // 
      this.TXTBX_prideti_slaptazodis.Location = new System.Drawing.Point(126, 60);
      this.TXTBX_prideti_slaptazodis.Name = "TXTBX_prideti_slaptazodis";
      this.TXTBX_prideti_slaptazodis.Size = new System.Drawing.Size(142, 20);
      this.TXTBX_prideti_slaptazodis.TabIndex = 3;
      // 
      // CHKBX_arAdmin
      // 
      this.CHKBX_arAdmin.AutoSize = true;
      this.CHKBX_arAdmin.Location = new System.Drawing.Point(126, 86);
      this.CHKBX_arAdmin.Name = "CHKBX_arAdmin";
      this.CHKBX_arAdmin.Size = new System.Drawing.Size(99, 17);
      this.CHKBX_arAdmin.TabIndex = 4;
      this.CHKBX_arAdmin.Text = "Administratorius";
      this.CHKBX_arAdmin.UseVisualStyleBackColor = true;
      // 
      // BTN_prideti
      // 
      this.BTN_prideti.Location = new System.Drawing.Point(126, 109);
      this.BTN_prideti.Name = "BTN_prideti";
      this.BTN_prideti.Size = new System.Drawing.Size(101, 26);
      this.BTN_prideti.TabIndex = 5;
      this.BTN_prideti.Text = "Pridėti";
      this.BTN_prideti.UseVisualStyleBackColor = true;
      this.BTN_prideti.Click += new System.EventHandler(this.BTN_prideti_Click);
      // 
      // adminVartotojaiPridejimas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(319, 187);
      this.Controls.Add(this.BTN_prideti);
      this.Controls.Add(this.CHKBX_arAdmin);
      this.Controls.Add(this.TXTBX_prideti_slaptazodis);
      this.Controls.Add(this.TXTBX_prideti_prisijungimoVardas);
      this.Controls.Add(this.LBL_prideti_slaptazodis);
      this.Controls.Add(this.LBL_prideti_prisijungimoVardas);
      this.Name = "adminVartotojaiPridejimas";
      this.Text = "Pridėti vartotoją";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LBL_prideti_prisijungimoVardas;
    private System.Windows.Forms.Label LBL_prideti_slaptazodis;
    private System.Windows.Forms.TextBox TXTBX_prideti_prisijungimoVardas;
    private System.Windows.Forms.TextBox TXTBX_prideti_slaptazodis;
    private System.Windows.Forms.CheckBox CHKBX_arAdmin;
    private System.Windows.Forms.Button BTN_prideti;
  }
}