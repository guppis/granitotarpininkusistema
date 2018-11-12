namespace GranitoTarpininkuSistema
{
  partial class FORMA_ataskaituDeklarantai
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
      this.BTN_israsyti = new System.Windows.Forms.Button();
      this.BTN_atsaukti = new System.Windows.Forms.Button();
      this.dgview_deklarantai = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgview_deklarantai)).BeginInit();
      this.SuspendLayout();
      // 
      // BTN_israsyti
      // 
      this.BTN_israsyti.Location = new System.Drawing.Point(418, 0);
      this.BTN_israsyti.Name = "BTN_israsyti";
      this.BTN_israsyti.Size = new System.Drawing.Size(89, 52);
      this.BTN_israsyti.TabIndex = 1;
      this.BTN_israsyti.Text = "Išrašyti";
      this.BTN_israsyti.UseVisualStyleBackColor = true;
      this.BTN_israsyti.Click += new System.EventHandler(this.BTN_israsyti_Click);
      // 
      // BTN_atsaukti
      // 
      this.BTN_atsaukti.Location = new System.Drawing.Point(418, 237);
      this.BTN_atsaukti.Name = "BTN_atsaukti";
      this.BTN_atsaukti.Size = new System.Drawing.Size(89, 52);
      this.BTN_atsaukti.TabIndex = 2;
      this.BTN_atsaukti.Text = "Atšaukti";
      this.BTN_atsaukti.UseVisualStyleBackColor = true;
      // 
      // dgview_deklarantai
      // 
      this.dgview_deklarantai.AllowUserToAddRows = false;
      this.dgview_deklarantai.AllowUserToDeleteRows = false;
      this.dgview_deklarantai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgview_deklarantai.Dock = System.Windows.Forms.DockStyle.Left;
      this.dgview_deklarantai.Location = new System.Drawing.Point(0, 0);
      this.dgview_deklarantai.Name = "dgview_deklarantai";
      this.dgview_deklarantai.ReadOnly = true;
      this.dgview_deklarantai.Size = new System.Drawing.Size(415, 296);
      this.dgview_deklarantai.TabIndex = 3;
      this.dgview_deklarantai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_deklarantai_CellContentClick);
      // 
      // FORMA_ataskaituDeklarantai
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(527, 296);
      this.Controls.Add(this.dgview_deklarantai);
      this.Controls.Add(this.BTN_atsaukti);
      this.Controls.Add(this.BTN_israsyti);
      this.Name = "FORMA_ataskaituDeklarantai";
      this.Text = "Sąskaitų išrašymas";
      this.Load += new System.EventHandler(this.FORMA_ataskaituDeklarantai_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgview_deklarantai)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button BTN_israsyti;
    private System.Windows.Forms.Button BTN_atsaukti;
    private System.Windows.Forms.DataGridView dgview_deklarantai;
  }
}