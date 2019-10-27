using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Windows.Forms;

namespace ProcessReader
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      LoadInfoServices();
      LoadInfoProcess();
      LoadInfoPC();
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Do you want to close?", "Close Program", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
        this.Close();
    }
    /// <summary>
    /// Carrega as grades com a informações de cada
    /// </summary>
    private void LoadInfoProcess()
    {
      Process[] processes = Process.GetProcesses();
      foreach (var proc in processes)
      {
        dtgProcess.Rows.Add(proc.ProcessName, proc.Id, Utils.GetSize(proc.WorkingSet64));
      }
    }

    private void LoadInfoServices()
    {
      ServiceController[] services = ServiceController.GetServices();
      foreach (var serv in services)
      {
        dtgService.Rows.Add(serv.DisplayName, serv.Status, serv.ServiceType, serv.StartType);
      }
    }

    private void LoadInfoPC()
    {
      rTxtInfoPC.Text = InfoPC.LoadInfo().ToString();
    }

  }
}
