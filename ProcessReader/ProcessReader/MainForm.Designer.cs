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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.tbControl = new System.Windows.Forms.TabControl();
      this.tbProcess = new System.Windows.Forms.TabPage();
      this.dtgProcess = new System.Windows.Forms.DataGridView();
      this.tbServices = new System.Windows.Forms.TabPage();
      this.dtgService = new System.Windows.Forms.DataGridView();
      this.tbInfo = new System.Windows.Forms.TabPage();
      this.rTxtInfoPC = new System.Windows.Forms.RichTextBox();
      this.BtnClose = new System.Windows.Forms.Button();
      this.ProcUpdate = new System.Windows.Forms.Timer(this.components);
      this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tbControl.SuspendLayout();
      this.tbProcess.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgProcess)).BeginInit();
      this.tbServices.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgService)).BeginInit();
      this.tbInfo.SuspendLayout();
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
            this.ProcessName,
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
      this.tbServices.Controls.Add(this.dtgService);
      this.tbServices.Location = new System.Drawing.Point(4, 27);
      this.tbServices.Name = "tbServices";
      this.tbServices.Padding = new System.Windows.Forms.Padding(3);
      this.tbServices.Size = new System.Drawing.Size(901, 535);
      this.tbServices.TabIndex = 1;
      this.tbServices.Text = "Services";
      this.tbServices.UseVisualStyleBackColor = true;
      // 
      // dtgService
      // 
      this.dtgService.AllowUserToAddRows = false;
      this.dtgService.AllowUserToDeleteRows = false;
      this.dtgService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dtgService.BackgroundColor = System.Drawing.Color.White;
      this.dtgService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName,
            this.Status,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
      this.dtgService.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgService.Location = new System.Drawing.Point(3, 3);
      this.dtgService.Name = "dtgService";
      this.dtgService.ReadOnly = true;
      this.dtgService.Size = new System.Drawing.Size(895, 529);
      this.dtgService.TabIndex = 4;
      // 
      // tbInfo
      // 
      this.tbInfo.Controls.Add(this.rTxtInfoPC);
      this.tbInfo.Location = new System.Drawing.Point(4, 27);
      this.tbInfo.Name = "tbInfo";
      this.tbInfo.Padding = new System.Windows.Forms.Padding(3);
      this.tbInfo.Size = new System.Drawing.Size(901, 535);
      this.tbInfo.TabIndex = 2;
      this.tbInfo.Text = "Info";
      this.tbInfo.UseVisualStyleBackColor = true;
      // 
      // rTxtInfoPC
      // 
      this.rTxtInfoPC.Location = new System.Drawing.Point(6, 6);
      this.rTxtInfoPC.Name = "rTxtInfoPC";
      this.rTxtInfoPC.Size = new System.Drawing.Size(889, 523);
      this.rTxtInfoPC.TabIndex = 0;
      this.rTxtInfoPC.Text = "";
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
      // ProcessName
      // 
      this.ProcessName.HeaderText = "Name";
      this.ProcessName.Name = "ProcessName";
      this.ProcessName.ReadOnly = true;
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
      // ServiceName
      // 
      this.ServiceName.HeaderText = "Name";
      this.ServiceName.Name = "ServiceName";
      this.ServiceName.ReadOnly = true;
      // 
      // Status
      // 
      this.Status.HeaderText = "Status";
      this.Status.Name = "Status";
      this.Status.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.HeaderText = "Service Type";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.HeaderText = "Start Type";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.tbControl.ResumeLayout(false);
      this.tbProcess.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgProcess)).EndInit();
      this.tbServices.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgService)).EndInit();
      this.tbInfo.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tbControl;
    private System.Windows.Forms.TabPage tbProcess;
    private System.Windows.Forms.TabPage tbServices;
    private System.Windows.Forms.TabPage tbInfo;
    private System.Windows.Forms.Button BtnClose; 
    private System.Windows.Forms.DataGridView dtgProcess;
    private System.Windows.Forms.Timer ProcUpdate;
    private System.Windows.Forms.DataGridView dtgService;
    private System.Windows.Forms.RichTextBox rTxtInfoPC;
    private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
    private System.Windows.Forms.DataGridViewTextBoxColumn PCID;
    private System.Windows.Forms.DataGridViewTextBoxColumn Memory;
    private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
    private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
  }
}

