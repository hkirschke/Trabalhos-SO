using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProcessReader
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      LoadInfo();
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Do you want to close?", "Close Program", MessageBoxButtons.OKCancel) == DialogResult.OK)
        this.Close();
    }
    /// <summary>
    /// Carrega as grades com a informações de cada
    /// </summary>
    private void LoadInfo()
    {
      Process[] processes = Process.GetProcesses();
      foreach (var proc in processes)
      {
        dtgProcess.Rows.Add(proc.ProcessName,proc.Id, GetSize(proc.WorkingSet64));
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
