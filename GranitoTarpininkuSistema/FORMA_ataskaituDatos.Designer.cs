namespace GranitoTarpininkuSistema
{
  partial class FORMA_ataskaituDatos
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
      this.BTN_patvirtinti = new System.Windows.Forms.Button();
      this.dateTime_pabaiga = new System.Windows.Forms.DateTimePicker();
      this.dateTime_pradzia = new System.Windows.Forms.DateTimePicker();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // BTN_patvirtinti
      // 
      this.BTN_patvirtinti.Location = new System.Drawing.Point(64, 149);
      this.BTN_patvirtinti.Name = "BTN_patvirtinti";
      this.BTN_patvirtinti.Size = new System.Drawing.Size(148, 35);
      this.BTN_patvirtinti.TabIndex = 0;
      this.BTN_patvirtinti.Text = "Patvirtinti";
      this.BTN_patvirtinti.UseVisualStyleBackColor = true;
      this.BTN_patvirtinti.Click += new System.EventHandler(this.BTN_patvirtinti_Click);
      // 
      // dateTime_pabaiga
      // 
      this.dateTime_pabaiga.Location = new System.Drawing.Point(64, 87);
      this.dateTime_pabaiga.Name = "dateTime_pabaiga";
      this.dateTime_pabaiga.Size = new System.Drawing.Size(200, 20);
      this.dateTime_pabaiga.TabIndex = 2;
      // 
      // dateTime_pradzia
      // 
      this.dateTime_pradzia.Location = new System.Drawing.Point(64, 34);
      this.dateTime_pradzia.Name = "dateTime_pradzia";
      this.dateTime_pradzia.Size = new System.Drawing.Size(200, 20);
      this.dateTime_pradzia.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(31, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(27, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Nuo";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(40, 87);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(18, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Iki";
      // 
      // ataskaituDatos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(300, 208);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dateTime_pabaiga);
      this.Controls.Add(this.dateTime_pradzia);
      this.Controls.Add(this.BTN_patvirtinti);
      this.Name = "ataskaituDatos";
      this.Text = "Generuoti ataskaitą";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BTN_patvirtinti;
    private System.Windows.Forms.DateTimePicker dateTime_pabaiga;
    private System.Windows.Forms.DateTimePicker dateTime_pradzia;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}