namespace GranitoTarpininkuSistema
{
  partial class FORMA_TaskerArchyvas
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.taskerList = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.taskerList)).BeginInit();
      this.SuspendLayout();
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
      this.taskerList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.taskerList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
      this.taskerList.Location = new System.Drawing.Point(0, 0);
      this.taskerList.MultiSelect = false;
      this.taskerList.Name = "taskerList";
      this.taskerList.ReadOnly = true;
      this.taskerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.taskerList.Size = new System.Drawing.Size(643, 319);
      this.taskerList.TabIndex = 12;
      this.taskerList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskerList_CellDoubleClick);
      // 
      // FORMA_TaskerArchyvas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(643, 319);
      this.Controls.Add(this.taskerList);
      this.Name = "FORMA_TaskerArchyvas";
      this.Text = "FORMA_TaskerArchyvas";
      ((System.ComponentModel.ISupportInitialize)(this.taskerList)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView taskerList;
  }
}