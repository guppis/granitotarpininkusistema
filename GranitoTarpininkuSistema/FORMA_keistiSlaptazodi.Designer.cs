namespace GranitoTarpininkuSistema
{
  partial class FORMA_keistiSlaptazodi
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
      this.BTN_uzdaryti = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.BTN_issaugoti = new System.Windows.Forms.Button();
      this.TXTBX_senasSlaptazodis = new System.Windows.Forms.TextBox();
      this.TXTBX_naujasSlaptazodis = new System.Windows.Forms.TextBox();
      this.TXTBX_pakartotinaiNaujas = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // BTN_uzdaryti
      // 
      this.BTN_uzdaryti.Location = new System.Drawing.Point(51, 101);
      this.BTN_uzdaryti.Name = "BTN_uzdaryti";
      this.BTN_uzdaryti.Size = new System.Drawing.Size(97, 35);
      this.BTN_uzdaryti.TabIndex = 0;
      this.BTN_uzdaryti.Text = "Uždaryti";
      this.BTN_uzdaryti.UseVisualStyleBackColor = true;
      this.BTN_uzdaryti.Click += new System.EventHandler(this.BTN_uzdaryti_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(92, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Senas slaptazodis";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(22, 37);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(95, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Naujas slaptazodis";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(22, 64);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(128, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Pakartoti naują slaptažodį";
      // 
      // BTN_issaugoti
      // 
      this.BTN_issaugoti.Location = new System.Drawing.Point(227, 101);
      this.BTN_issaugoti.Name = "BTN_issaugoti";
      this.BTN_issaugoti.Size = new System.Drawing.Size(97, 35);
      this.BTN_issaugoti.TabIndex = 4;
      this.BTN_issaugoti.Text = "Išsaugoti";
      this.BTN_issaugoti.UseVisualStyleBackColor = true;
      this.BTN_issaugoti.Click += new System.EventHandler(this.BTN_issaugoti_Click);
      // 
      // TXTBX_senasSlaptazodis
      // 
      this.TXTBX_senasSlaptazodis.Location = new System.Drawing.Point(196, 4);
      this.TXTBX_senasSlaptazodis.Name = "TXTBX_senasSlaptazodis";
      this.TXTBX_senasSlaptazodis.PasswordChar = '*';
      this.TXTBX_senasSlaptazodis.Size = new System.Drawing.Size(178, 20);
      this.TXTBX_senasSlaptazodis.TabIndex = 5;
      // 
      // TXTBX_naujasSlaptazodis
      // 
      this.TXTBX_naujasSlaptazodis.Location = new System.Drawing.Point(196, 30);
      this.TXTBX_naujasSlaptazodis.Name = "TXTBX_naujasSlaptazodis";
      this.TXTBX_naujasSlaptazodis.PasswordChar = '*';
      this.TXTBX_naujasSlaptazodis.Size = new System.Drawing.Size(178, 20);
      this.TXTBX_naujasSlaptazodis.TabIndex = 6;
      // 
      // TXTBX_pakartotinaiNaujas
      // 
      this.TXTBX_pakartotinaiNaujas.Location = new System.Drawing.Point(196, 57);
      this.TXTBX_pakartotinaiNaujas.Name = "TXTBX_pakartotinaiNaujas";
      this.TXTBX_pakartotinaiNaujas.PasswordChar = '*';
      this.TXTBX_pakartotinaiNaujas.Size = new System.Drawing.Size(178, 20);
      this.TXTBX_pakartotinaiNaujas.TabIndex = 7;
      // 
      // FORMA_keistiSlaptazodi
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(380, 159);
      this.Controls.Add(this.TXTBX_pakartotinaiNaujas);
      this.Controls.Add(this.TXTBX_naujasSlaptazodis);
      this.Controls.Add(this.TXTBX_senasSlaptazodis);
      this.Controls.Add(this.BTN_issaugoti);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.BTN_uzdaryti);
      this.Name = "FORMA_keistiSlaptazodi";
      this.Text = "keistiSlaptazodi";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BTN_uzdaryti;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button BTN_issaugoti;
    private System.Windows.Forms.TextBox TXTBX_senasSlaptazodis;
    private System.Windows.Forms.TextBox TXTBX_naujasSlaptazodis;
    private System.Windows.Forms.TextBox TXTBX_pakartotinaiNaujas;
  }
}