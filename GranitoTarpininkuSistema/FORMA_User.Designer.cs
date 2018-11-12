namespace GranitoTarpininkuSistema
{
  partial class FORMA_User
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
      this.BTN_Tasker = new System.Windows.Forms.Button();
      this.BTN_keistiSlaptazodi = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BTN_Tasker
      // 
      this.BTN_Tasker.Location = new System.Drawing.Point(12, 12);
      this.BTN_Tasker.Name = "BTN_Tasker";
      this.BTN_Tasker.Size = new System.Drawing.Size(103, 30);
      this.BTN_Tasker.TabIndex = 5;
      this.BTN_Tasker.Text = "Užduotynas";
      this.BTN_Tasker.UseVisualStyleBackColor = true;
      this.BTN_Tasker.Click += new System.EventHandler(this.BTN_Tasker_Click);
      // 
      // BTN_keistiSlaptazodi
      // 
      this.BTN_keistiSlaptazodi.Location = new System.Drawing.Point(276, 12);
      this.BTN_keistiSlaptazodi.Name = "BTN_keistiSlaptazodi";
      this.BTN_keistiSlaptazodi.Size = new System.Drawing.Size(103, 30);
      this.BTN_keistiSlaptazodi.TabIndex = 6;
      this.BTN_keistiSlaptazodi.Text = "Keisti slaptažodį";
      this.BTN_keistiSlaptazodi.UseVisualStyleBackColor = true;
      this.BTN_keistiSlaptazodi.Click += new System.EventHandler(this.BTN_keistiSlaptazodi_Click);
      // 
      // User
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(391, 338);
      this.Controls.Add(this.BTN_keistiSlaptazodi);
      this.Controls.Add(this.BTN_Tasker);
      this.Name = "User";
      this.Text = "User";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button BTN_Tasker;
    private System.Windows.Forms.Button BTN_keistiSlaptazodi;
  }
}