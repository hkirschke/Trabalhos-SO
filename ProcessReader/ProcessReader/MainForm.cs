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
      //LoadInfoProcess();
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
        dtgProcess.Rows.Add(proc.ProcessName, proc.Id, GetSize(proc.WorkingSet64));
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

    private static string GetSize(double byteCount)
    {
      string size = "0 Bytes";
      if (byteCount >= 1073741824.0)
        size = string.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
      else if (byteCount >= 1048576.0)
        size = string.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
      else if (byteCount >= 1024.0)
        size = string.Format("{0:##.##}", byteCount / 1024.0) + " KB";
      else if (byteCount > 0 && byteCount < 1024.0)
        size = byteCount.ToString() + " Bytes";

      return size;
    }
  }
}
