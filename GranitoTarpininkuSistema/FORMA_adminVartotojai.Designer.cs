namespace GranitoTarpininkuSistema
{
  partial class FORMA_adminVartotojai
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
      this.LSTVW_vartotojai = new System.Windows.Forms.ListView();
      this.colHead_Vart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colHead_kadaSukurtas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colHead_paskutinisPrisijungimas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colHead_userRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.BTN_adminVart_Istrinti = new System.Windows.Forms.Button();
      this.BTN_adminVart_Prideti = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // LSTVW_vartotojai
      // 
      this.LSTVW_vartotojai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHead_Vart,
            this.colHead_kadaSukurtas,
            this.colHead_paskutinisPrisijungimas,
            this.colHead_userRole});
      this.LSTVW_vartotojai.FullRowSelect = true;
      this.LSTVW_vartotojai.GridLines = true;
      this.LSTVW_vartotojai.Location = new System.Drawing.Point(46, 47);
      this.LSTVW_vartotojai.MultiSelect = false;
      this.LSTVW_vartotojai.Name = "LSTVW_vartotojai";
      this.LSTVW_vartotojai.Size = new System.Drawing.Size(501, 236);
      this.LSTVW_vartotojai.Sorting = System.Windows.Forms.SortOrder.Ascending;
      this.LSTVW_vartotojai.TabIndex = 0;
      this.LSTVW_vartotojai.UseCompatibleStateImageBehavior = false;
      this.LSTVW_vartotojai.View = System.Windows.Forms.View.Details;
      this.LSTVW_vartotojai.ItemActivate += new System.EventHandler(this.LSTVW_vartotojai_ItemActivate);
      // 
      // colHead_Vart
      // 
      this.colHead_Vart.Text = "Vartotojas";
      this.colHead_Vart.Width = 100;
      // 
      // colHead_kadaSukurtas
      // 
      this.colHead_kadaSukurtas.Text = "Sukurtas";
      this.colHead_kadaSukurtas.Width = 130;
      // 
      // colHead_paskutinisPrisijungimas
      // 
      this.colHead_paskutinisPrisijungimas.Text = "Paskutinis prisijungimas";
      this.colHead_paskutinisPrisijungimas.Width = 130;
      // 
      // colHead_userRole
      // 
      this.colHead_userRole.Text = "Admin/Vartotojas";
      this.colHead_userRole.Width = 100;
      // 
      // BTN_adminVart_Istrinti
      // 
      this.BTN_adminVart_Istrinti.Location = new System.Drawing.Point(46, 289);
      this.BTN_adminVart_Istrinti.Name = "BTN_adminVart_Istrinti";
      this.BTN_adminVart_Istrinti.Size = new System.Drawing.Size(132, 31);
      this.BTN_adminVart_Istrinti.TabIndex = 1;
      this.BTN_adminVart_Istrinti.Text = "Istrinti";
      this.BTN_adminVart_Istrinti.UseVisualStyleBackColor = true;
      this.BTN_adminVart_Istrinti.Click += new System.EventHandler(this.BTN_adminVart_Istrinti_Click);
      // 
      // BTN_adminVart_Prideti
      // 
      this.BTN_adminVart_Prideti.Location = new System.Drawing.Point(415, 289);
      this.BTN_adminVart_Prideti.Name = "BTN_adminVart_Prideti";
      this.BTN_adminVart_Prideti.Size = new System.Drawing.Size(132, 31);
      this.BTN_adminVart_Prideti.TabIndex = 2;
      this.BTN_adminVart_Prideti.Text = "Pridėti";
      this.BTN_adminVart_Prideti.UseVisualStyleBackColor = true;
      this.BTN_adminVart_Prideti.Click += new System.EventHandler(this.BTN_adminVart_Prideti_Click);
      // 
      // FORMA_adminVartotojai
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BTN_adminVart_Prideti);
      this.Controls.Add(this.BTN_adminVart_Istrinti);
      this.Controls.Add(this.LSTVW_vartotojai);
      this.Name = "FORMA_adminVartotojai";
      this.Text = "Vartotojai";
      this.Activated += new System.EventHandler(this.adminVartotojai_Activated);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView LSTVW_vartotojai;
    private System.Windows.Forms.Button BTN_adminVart_Istrinti;
    private System.Windows.Forms.Button BTN_adminVart_Prideti;
    private System.Windows.Forms.ColumnHeader colHead_Vart;
    private System.Windows.Forms.ColumnHeader colHead_kadaSukurtas;
    private System.Windows.Forms.ColumnHeader colHead_paskutinisPrisijungimas;
    private System.Windows.Forms.ColumnHeader colHead_userRole;
  }
}