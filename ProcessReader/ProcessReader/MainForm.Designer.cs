namespace ProcessReader
{
  partial class MainForm
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
      this.tbControl = new System.Windows.Forms.TabControl();
      this.tbProcess = new System.Windows.Forms.TabPage();
      this.dtgProcess = new System.Windows.Forms.DataGridView();
      this.tbServices = new System.Windows.Forms.TabPage();
      this.dtgServices = new System.Windows.Forms.DataGridView();
      this.tbInfo = new System.Windows.Forms.TabPage();
      this.BtnClose = new System.Windows.Forms.Button();
      this.ProcUpdate = new System.Windows.Forms.Timer(this.components);
      this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tbControl.SuspendLayout();
      this.tbProcess.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgProcess)).BeginInit();
      this.tbServices.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgServices)).BeginInit();
      this.SuspendLayout();
      // 
      // tbControl
      // 
      this.tbControl.Controls.Add(this.tbProcess);
      this.tbControl.Controls.Add(this.tbServices);
      this.tbControl.Controls.Add(this.tbInfo);
      this.tbControl.Cursor = System.Windows.Forms.Cursors.Default;
      this.tbControl.Location = new System.Drawing.Point(12, 12);
      this.tbControl.Multiline = true;
      this.tbControl.Name = "tbControl";
      this.tbControl.SelectedIndex = 0;
      this.tbControl.Size = new System.Drawing.Size(909, 566);
      this.tbControl.TabIndex = 0;
      // 
      // tbProcess
      // 
      this.tbProcess.BackColor = System.Drawing.Color.White;
      this.tbProcess.Controls.Add(this.dtgProcess);
      this.tbProcess.Location = new System.Drawing.Point(4, 27);
      this.tbProcess.Name = "tbProcess";
      this.tbProcess.Padding = new System.Windows.Forms.Padding(3);
      this.tbProcess.Size = new System.Drawing.Size(901, 535);
      this.tbProcess.TabIndex = 0;
      this.tbProcess.Text = "Processes";
      // 
      // dtgProcess
      // 
      this.dtgProcess.AllowUserToAddRows = false;
      this.dtgProcess.AllowUserToDeleteRows = false;
      this.dtgProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dtgProcess.BackgroundColor = System.Drawing.Color.White;
      this.dtgProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.PCID,
            this.Memory});
      this.dtgProcess.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgProcess.Location = new System.Drawing.Point(3, 3);
      this.dtgProcess.Name = "dtgProcess";
      this.dtgProcess.ReadOnly = true;
      this.dtgProcess.Size = new System.Drawing.Size(895, 529);
      this.dtgProcess.TabIndex = 3;
      // 
      // tbServices
      // 
      this.tbServices.Controls.Add(this.dtgServices);
      this.tbServices.Location = new System.Drawing.Point(4, 27);
      this.tbServices.Name = "tbServices";
      this.tbServices.Padding = new System.Windows.Forms.Padding(3);
      this.tbServices.Size = new System.Drawing.Size(901, 535);
      this.tbServices.TabIndex = 1;
      this.tbServices.Text = "Services";
      this.tbServices.UseVisualStyleBackColor = true;
      // 
      // dtgServices
      // 
      this.dtgServices.AllowUserToAddRows = false;
      this.dtgServices.AllowUserToDeleteRows = false;
      this.dtgServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dtgServices.BackgroundColor = System.Drawing.Color.White;
      this.dtgServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgServices.Location = new System.Drawing.Point(-4, -2);
      this.dtgServices.Name = "dtgServices";
      this.dtgServices.ReadOnly = true;
      this.dtgServices.Size = new System.Drawing.Size(909, 539);
      this.dtgServices.TabIndex = 2;
      // 
      // tbInfo
      // 
      this.tbInfo.Location = new System.Drawing.Point(4, 27);
      this.tbInfo.Name = "tbInfo";
      this.tbInfo.Padding = new System.Windows.Forms.Padding(3);
      this.tbInfo.Size = new System.Drawing.Size(901, 535);
      this.tbInfo.TabIndex = 2;
      this.tbInfo.Text = "Info";
      this.tbInfo.UseVisualStyleBackColor = true;
      // 
      // BtnClose
      // 
      this.BtnClose.BackColor = System.Drawing.SystemColors.Highlight;
      this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.BtnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.BtnClose.Location = new System.Drawing.Point(814, 594);
      this.BtnClose.Name = "BtnClose";
      this.BtnClose.Size = new System.Drawing.Size(107, 31);
      this.BtnClose.TabIndex = 1;
      this.BtnClose.Text = "Close";
      this.BtnClose.UseVisualStyleBackColor = false;
      this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
      // 
      // ProcUpdate
      // 
      this.ProcUpdate.Enabled = true;
      this.ProcUpdate.Interval = 5000;
      // 
      // Name
      // 
      this.Name.HeaderText = "Name";
      this.Name.Name = "Name";
      this.Name.ReadOnly = true;
      // 
      // PCID
      // 
      this.PCID.HeaderText = "PCID";
      this.PCID.Name = "PCID";
      this.PCID.ReadOnly = true;
      // 
      // Memory
      // 
      this.Memory.HeaderText = "Physical Memory";
      this.Memory.Name = "Memory";
      this.Memory.ReadOnly = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.SystemColors.ControlLight;
      this.ClientSize = new System.Drawing.Size(942, 637);
      this.ControlBox = false;
      this.Controls.Add(this.BtnClose);
      this.Controls.Add(this.tbControl);
      this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      //this.Name = "MainForm";
      this.tbControl.ResumeLayout(false);
      this.tbProcess.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgProcess)).EndInit();
      this.tbServices.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgServices)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tbControl;
    private System.Windows.Forms.TabPage tbProcess;
    private System.Windows.Forms.TabPage tbServices;
    private System.Windows.Forms.TabPage tbInfo;
    private System.Windows.Forms.Button BtnClose;
    private System.Windows.Forms.DataGridView dtgServices;
    private System.Windows.Forms.DataGridView dtgProcess;
    private System.Windows.Forms.Timer ProcUpdate;
    private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    private System.Windows.Forms.DataGridViewTextBoxColumn PCID;
    private System.Windows.Forms.DataGridViewTextBoxColumn Memory;
  }
}

