namespace GranitoTarpininkuSistema
{
  partial class FORMA_TaskerPridetiUzduoti
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.LBL_Aprasymas = new System.Windows.Forms.Label();
      this.TXTBX_aprasymas = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.TXTBX_komentarai = new System.Windows.Forms.TextBox();
      this.BTN_Issaugoti = new System.Windows.Forms.Button();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.CMBBX_skirta = new System.Windows.Forms.ComboBox();
      this.BTN_Uzdaryti = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(19, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Atlikti iki:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(19, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Skirta:";
      // 
      // LBL_Aprasymas
      // 
      this.LBL_Aprasymas.AutoSize = true;
      this.LBL_Aprasymas.Location = new System.Drawing.Point(12, 67);
      this.LBL_Aprasymas.Name = "LBL_Aprasymas";
      this.LBL_Aprasymas.Size = new System.Drawing.Size(58, 13);
      this.LBL_Aprasymas.TabIndex = 4;
      this.LBL_Aprasymas.Text = "Aprašymas";
      // 
      // TXTBX_aprasymas
      // 
      this.TXTBX_aprasymas.Location = new System.Drawing.Point(74, 66);
      this.TXTBX_aprasymas.Multiline = true;
      this.TXTBX_aprasymas.Name = "TXTBX_aprasymas";
      this.TXTBX_aprasymas.Size = new System.Drawing.Size(329, 106);
      this.TXTBX_aprasymas.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 181);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(60, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Komentarai";
      // 
      // TXTBX_komentarai
      // 
      this.TXTBX_komentarai.Location = new System.Drawing.Point(74, 178);
      this.TXTBX_komentarai.Multiline = true;
      this.TXTBX_komentarai.Name = "TXTBX_komentarai";
      this.TXTBX_komentarai.Size = new System.Drawing.Size(244, 96);
      this.TXTBX_komentarai.TabIndex = 7;
      // 
      // BTN_Issaugoti
      // 
      this.BTN_Issaugoti.Location = new System.Drawing.Point(325, 180);
      this.BTN_Issaugoti.Name = "BTN_Issaugoti";
      this.BTN_Issaugoti.Size = new System.Drawing.Size(77, 44);
      this.BTN_Issaugoti.TabIndex = 8;
      this.BTN_Issaugoti.Text = "Išsaugoti";
      this.BTN_Issaugoti.UseVisualStyleBackColor = true;
      this.BTN_Issaugoti.Click += new System.EventHandler(this.BTN_Issaugoti_Click);
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(74, 6);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(88, 20);
      this.dateTimePicker1.TabIndex = 14;
      // 
      // CMBBX_skirta
      // 
      this.CMBBX_skirta.FormattingEnabled = true;
      this.CMBBX_skirta.Location = new System.Drawing.Point(74, 32);
      this.CMBBX_skirta.Name = "CMBBX_skirta";
      this.CMBBX_skirta.Size = new System.Drawing.Size(114, 21);
      this.CMBBX_skirta.TabIndex = 15;
      // 
      // BTN_Uzdaryti
      // 
      this.BTN_Uzdaryti.Location = new System.Drawing.Point(325, 230);
      this.BTN_Uzdaryti.Name = "BTN_Uzdaryti";
      this.BTN_Uzdaryti.Size = new System.Drawing.Size(77, 44);
      this.BTN_Uzdaryti.TabIndex = 9;
      this.BTN_Uzdaryti.Text = "Uždaryti";
      this.BTN_Uzdaryti.UseVisualStyleBackColor = true;
      this.BTN_Uzdaryti.Click += new System.EventHandler(this.BTN_UzbaigtiUzduoti_Click);
      // 
      // FORMA_TaskerPridetiUzduoti
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(415, 283);
      this.Controls.Add(this.CMBBX_skirta);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.BTN_Uzdaryti);
      this.Controls.Add(this.BTN_Issaugoti);
      this.Controls.Add(this.TXTBX_komentarai);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.TXTBX_aprasymas);
      this.Controls.Add(this.LBL_Aprasymas);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "FORMA_TaskerPridetiUzduoti";
      this.Text = "pridetiUzduoti";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label LBL_Aprasymas;
    private System.Windows.Forms.TextBox TXTBX_aprasymas;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox TXTBX_komentarai;
    private System.Windows.Forms.Button BTN_Issaugoti;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.ComboBox CMBBX_skirta;
    private System.Windows.Forms.Button BTN_Uzdaryti;
  }
}