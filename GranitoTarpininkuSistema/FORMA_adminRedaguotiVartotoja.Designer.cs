namespace GranitoTarpininkuSistema
{
  partial class FORMA_adminRedaguotiVartotoja
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
      this.BTN_issaugoti = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.LBL_redVart = new System.Windows.Forms.Label();
      this.BTN_pakeistiSlaptazodi = new System.Windows.Forms.Button();
      this.BTN_atsaukti = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.dateTime_kadaSukurtas = new System.Windows.Forms.DateTimePicker();
      this.dateTime_paskutinisPrisijungimas = new System.Windows.Forms.DateTimePicker();
      this.numericUpDown_vartRole = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vartRole)).BeginInit();
      this.SuspendLayout();
      // 
      // BTN_issaugoti
      // 
      this.BTN_issaugoti.Location = new System.Drawing.Point(235, 109);
      this.BTN_issaugoti.Name = "BTN_issaugoti";
      this.BTN_issaugoti.Size = new System.Drawing.Size(107, 41);
      this.BTN_issaugoti.TabIndex = 0;
      this.BTN_issaugoti.Text = "Išsaugoti";
      this.BTN_issaugoti.UseVisualStyleBackColor = true;
      this.BTN_issaugoti.Click += new System.EventHandler(this.BTN_issaugoti_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(130, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Redaguojamas vartotojas:";
      // 
      // LBL_redVart
      // 
      this.LBL_redVart.AutoSize = true;
      this.LBL_redVart.Location = new System.Drawing.Point(148, 9);
      this.LBL_redVart.Name = "LBL_redVart";
      this.LBL_redVart.Size = new System.Drawing.Size(66, 13);
      this.LBL_redVart.TabIndex = 3;
      this.LBL_redVart.Text = "LBL_redVart";
      // 
      // BTN_pakeistiSlaptazodi
      // 
      this.BTN_pakeistiSlaptazodi.Location = new System.Drawing.Point(122, 109);
      this.BTN_pakeistiSlaptazodi.Name = "BTN_pakeistiSlaptazodi";
      this.BTN_pakeistiSlaptazodi.Size = new System.Drawing.Size(107, 41);
      this.BTN_pakeistiSlaptazodi.TabIndex = 4;
      this.BTN_pakeistiSlaptazodi.Text = "Pakeisti slaptažodį";
      this.BTN_pakeistiSlaptazodi.UseVisualStyleBackColor = true;
      this.BTN_pakeistiSlaptazodi.Click += new System.EventHandler(this.BTN_pakeistiSlaptazodi_Click);
      // 
      // BTN_atsaukti
      // 
      this.BTN_atsaukti.Location = new System.Drawing.Point(9, 109);
      this.BTN_atsaukti.Name = "BTN_atsaukti";
      this.BTN_atsaukti.Size = new System.Drawing.Size(107, 41);
      this.BTN_atsaukti.TabIndex = 5;
      this.BTN_atsaukti.Text = "Atšaukti";
      this.BTN_atsaukti.UseVisualStyleBackColor = true;
      this.BTN_atsaukti.Click += new System.EventHandler(this.BTN_atsaukti_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 33);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(69, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Vartotojo rolė";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 57);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(75, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Kada sukurtas";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 83);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(127, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Paskutinį kartą prisijungta";
      // 
      // dateTime_kadaSukurtas
      // 
      this.dateTime_kadaSukurtas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTime_kadaSukurtas.Location = new System.Drawing.Point(151, 57);
      this.dateTime_kadaSukurtas.Name = "dateTime_kadaSukurtas";
      this.dateTime_kadaSukurtas.Size = new System.Drawing.Size(125, 20);
      this.dateTime_kadaSukurtas.TabIndex = 9;
      // 
      // dateTime_paskutinisPrisijungimas
      // 
      this.dateTime_paskutinisPrisijungimas.Location = new System.Drawing.Point(151, 83);
      this.dateTime_paskutinisPrisijungimas.Name = "dateTime_paskutinisPrisijungimas";
      this.dateTime_paskutinisPrisijungimas.Size = new System.Drawing.Size(125, 20);
      this.dateTime_paskutinisPrisijungimas.TabIndex = 10;
      // 
      // numericUpDown_vartRole
      // 
      this.numericUpDown_vartRole.Location = new System.Drawing.Point(151, 31);
      this.numericUpDown_vartRole.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown_vartRole.Name = "numericUpDown_vartRole";
      this.numericUpDown_vartRole.Size = new System.Drawing.Size(63, 20);
      this.numericUpDown_vartRole.TabIndex = 13;
      // 
      // FORMA_adminRedaguotiVartotoja
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(354, 161);
      this.Controls.Add(this.numericUpDown_vartRole);
      this.Controls.Add(this.dateTime_paskutinisPrisijungimas);
      this.Controls.Add(this.dateTime_kadaSukurtas);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.BTN_atsaukti);
      this.Controls.Add(this.BTN_pakeistiSlaptazodi);
      this.Controls.Add(this.LBL_redVart);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.BTN_issaugoti);
      this.Name = "FORMA_adminRedaguotiVartotoja";
      this.Text = "FORMA_redaguotiVartotoja";
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vartRole)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BTN_issaugoti;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label LBL_redVart;
    private System.Windows.Forms.Button BTN_pakeistiSlaptazodi;
    private System.Windows.Forms.Button BTN_atsaukti;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DateTimePicker dateTime_kadaSukurtas;
    private System.Windows.Forms.DateTimePicker dateTime_paskutinisPrisijungimas;
    private System.Windows.Forms.NumericUpDown numericUpDown_vartRole;
  }
}