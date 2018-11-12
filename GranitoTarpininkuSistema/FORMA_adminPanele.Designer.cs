namespace GranitoTarpininkuSistema
{
  partial class FORMA_adminPanele
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
      this.LVIEW_kompuSarasas = new System.Windows.Forms.ListView();
      this.colHead_IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colHead_kompPav = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colHead_mac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.BTN_adminVartotojai = new System.Windows.Forms.Button();
      this.BTN_atnaujinti = new System.Windows.Forms.Button();
      this.BTN_aikstelesAtaskaita = new System.Windows.Forms.Button();
      this.BTN_Tasker = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // LVIEW_kompuSarasas
      // 
      this.LVIEW_kompuSarasas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHead_IP,
            this.colHead_kompPav,
            this.colHead_mac});
      this.LVIEW_kompuSarasas.Location = new System.Drawing.Point(59, 65);
      this.LVIEW_kompuSarasas.Name = "LVIEW_kompuSarasas";
      this.LVIEW_kompuSarasas.Size = new System.Drawing.Size(515, 256);
      this.LVIEW_kompuSarasas.TabIndex = 0;
      this.LVIEW_kompuSarasas.UseCompatibleStateImageBehavior = false;
      this.LVIEW_kompuSarasas.View = System.Windows.Forms.View.Details;
      // 
      // colHead_IP
      // 
      this.colHead_IP.Text = "IP adresas";
      this.colHead_IP.Width = 97;
      // 
      // colHead_kompPav
      // 
      this.colHead_kompPav.Text = "Kompiuterio pavadinimas";
      this.colHead_kompPav.Width = 129;
      // 
      // colHead_mac
      // 
      this.colHead_mac.Text = "MAC";
      this.colHead_mac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.colHead_mac.Width = 112;
      // 
      // BTN_adminVartotojai
      // 
      this.BTN_adminVartotojai.Location = new System.Drawing.Point(3, 6);
      this.BTN_adminVartotojai.Name = "BTN_adminVartotojai";
      this.BTN_adminVartotojai.Size = new System.Drawing.Size(103, 30);
      this.BTN_adminVartotojai.TabIndex = 1;
      this.BTN_adminVartotojai.Text = "Vartotojai";
      this.BTN_adminVartotojai.UseVisualStyleBackColor = true;
      this.BTN_adminVartotojai.Click += new System.EventHandler(this.BTN_adminVartotojai_Click_1);
      // 
      // BTN_atnaujinti
      // 
      this.BTN_atnaujinti.Location = new System.Drawing.Point(60, 335);
      this.BTN_atnaujinti.Name = "BTN_atnaujinti";
      this.BTN_atnaujinti.Size = new System.Drawing.Size(106, 25);
      this.BTN_atnaujinti.TabIndex = 2;
      this.BTN_atnaujinti.Text = "Atnaujinti";
      this.BTN_atnaujinti.UseVisualStyleBackColor = true;
      this.BTN_atnaujinti.Click += new System.EventHandler(this.BTN_atnaujinti_Click);
      // 
      // BTN_aikstelesAtaskaita
      // 
      this.BTN_aikstelesAtaskaita.Location = new System.Drawing.Point(112, 6);
      this.BTN_aikstelesAtaskaita.Name = "BTN_aikstelesAtaskaita";
      this.BTN_aikstelesAtaskaita.Size = new System.Drawing.Size(103, 30);
      this.BTN_aikstelesAtaskaita.TabIndex = 3;
      this.BTN_aikstelesAtaskaita.Text = "Aikštelės ataskaita";
      this.BTN_aikstelesAtaskaita.UseVisualStyleBackColor = true;
      this.BTN_aikstelesAtaskaita.Click += new System.EventHandler(this.BTN_aikstelesAtaskaita_Click);
      // 
      // BTN_Tasker
      // 
      this.BTN_Tasker.Location = new System.Drawing.Point(221, 6);
      this.BTN_Tasker.Name = "BTN_Tasker";
      this.BTN_Tasker.Size = new System.Drawing.Size(103, 30);
      this.BTN_Tasker.TabIndex = 4;
      this.BTN_Tasker.Text = "Užduotynas";
      this.BTN_Tasker.UseVisualStyleBackColor = true;
      this.BTN_Tasker.Click += new System.EventHandler(this.BTN_Tasker_Click);
      // 
      // FORMA_adminPanele
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BTN_Tasker);
      this.Controls.Add(this.BTN_aikstelesAtaskaita);
      this.Controls.Add(this.BTN_atnaujinti);
      this.Controls.Add(this.BTN_adminVartotojai);
      this.Controls.Add(this.LVIEW_kompuSarasas);
      this.Name = "FORMA_adminPanele";
      this.Text = "Admin panele";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView LVIEW_kompuSarasas;
    private System.Windows.Forms.ColumnHeader colHead_kompPav;
    private System.Windows.Forms.ColumnHeader colHead_mac;
    private System.Windows.Forms.Button BTN_adminVartotojai;
    private System.Windows.Forms.ColumnHeader colHead_IP;
    private System.Windows.Forms.Button BTN_atnaujinti;
    private System.Windows.Forms.Button BTN_aikstelesAtaskaita;
    private System.Windows.Forms.Button BTN_Tasker;
  }
}