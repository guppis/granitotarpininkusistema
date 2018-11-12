namespace GranitoTarpininkuSistema
{
  partial class FORMA_TaskerMain
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORMA_TaskerMain));
      this.BTN_Prideti = new System.Windows.Forms.Button();
      this.BTN_Archyvas = new System.Windows.Forms.Button();
      this.taskerList = new System.Windows.Forms.DataGridView();
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.taskerList)).BeginInit();
      this.SuspendLayout();
      // 
      // BTN_Prideti
      // 
      this.BTN_Prideti.Location = new System.Drawing.Point(5, 9);
      this.BTN_Prideti.Name = "BTN_Prideti";
      this.BTN_Prideti.Size = new System.Drawing.Size(99, 33);
      this.BTN_Prideti.TabIndex = 0;
      this.BTN_Prideti.Text = "Pridėti užduotį";
      this.BTN_Prideti.UseVisualStyleBackColor = true;
      this.BTN_Prideti.Click += new System.EventHandler(this.BTN_Prideti_Click);
      // 
      // BTN_Archyvas
      // 
      this.BTN_Archyvas.Location = new System.Drawing.Point(110, 9);
      this.BTN_Archyvas.Name = "BTN_Archyvas";
      this.BTN_Archyvas.Size = new System.Drawing.Size(99, 33);
      this.BTN_Archyvas.TabIndex = 1;
      this.BTN_Archyvas.Text = "Archyvas";
      this.BTN_Archyvas.UseVisualStyleBackColor = true;
      this.BTN_Archyvas.Click += new System.EventHandler(this.BTN_Archyvas_Click);
      // 
      // taskerList
      // 
      this.taskerList.AllowUserToAddRows = false;
      this.taskerList.AllowUserToDeleteRows = false;
      this.taskerList.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.taskerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.taskerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.taskerList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
      this.taskerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.taskerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.taskerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.taskerList.Cursor = System.Windows.Forms.Cursors.Default;
      this.taskerList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.taskerList.Location = new System.Drawing.Point(5, 48);
      this.taskerList.MultiSelect = false;
      this.taskerList.Name = "taskerList";
      this.taskerList.ReadOnly = true;
      this.taskerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.taskerList.Size = new System.Drawing.Size(698, 296);
      this.taskerList.TabIndex = 11;
      this.taskerList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskerList_CellDoubleClick);
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      this.notifyIcon1.BalloonTipTitle = "Nepamirštam užduočių";
      this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
      this.notifyIcon1.Text = "Užduotynas";
      this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
      // 
      // FORMA_TaskerMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(715, 356);
      this.Controls.Add(this.taskerList);
      this.Controls.Add(this.BTN_Archyvas);
      this.Controls.Add(this.BTN_Prideti);
      this.Name = "FORMA_TaskerMain";
      this.Text = "TaskerMain";
      this.Activated += new System.EventHandler(this.TaskerMain_Activated);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORMA_TaskerMain_FormClosing);
      this.Load += new System.EventHandler(this.FORMA_TaskerMain_Load);
      this.Resize += new System.EventHandler(this.FORMA_TaskerMain_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.taskerList)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button BTN_Prideti;
    private System.Windows.Forms.Button BTN_Archyvas;
    private System.Windows.Forms.DataGridView taskerList;
    private System.Windows.Forms.NotifyIcon notifyIcon1;
  }
}