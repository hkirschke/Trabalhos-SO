using System;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Threading;
using System.ServiceProcess;
using System.Xml.Linq;

namespace Arquitetura
{
  public partial class Form1 : Form
  {
    PerformanceCounter ramCounter = new PerformanceCounter("Process", "Working Set", "_Total");
    PerformanceCounter ramCounterAvailable = new PerformanceCounter("Memory", "Available MBytes");
    PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
    ServiceController[] servicos = ServiceController.GetServices();
    Process[] processos = Process.GetProcesses();
    Thread listarProcessos;
    Thread listarServicos;


    double memoriaTotal = 0;

    public Form1(string texto)
    {
      InitializeComponent();

      textBoxInformacoes.Text = texto;
      memoriaTotal = double.Parse(Getcomponent("Win32_ComputerSystem", "TotalPhysicalMemory")) / Math.Pow(2, 30);
      labelMemoriaTotal.Text = memoriaTotal.ToString("0.00") + " GB";
      timer.Enabled = true;
      timer.Tick += Timer_Tick;
      listarProcessos = new Thread(ListaProcessos);
      listarProcessos.Start();
      listarServicos = new Thread(ListarServicos);
      listarServicos.Start();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      double cpu = cpuCounter.NextValue();
      double ramDisponivel = ramCounterAvailable.NextValue();
      double ramUtilizada = ramCounter.NextValue();

      labelCPU.Text = cpu.ToString("0") + "%";
      progressBarCPU.Value = (int)cpu;
      labelMemoriaDisponivel.Text = (ramDisponivel / Math.Pow(2, 10)).ToString("0.00") + " GB";
      labelMemoriaUtilizada.Text = (ramUtilizada / Math.Pow(2, 30)).ToString("0.00") + " GB";

      labelMemoria.Text = (int)((ramUtilizada / Math.Pow(2, 30) * 100) / memoriaTotal) + " %";
      progressBarMemoria.Value = (int)((ramUtilizada / Math.Pow(2, 30) * 100) / memoriaTotal);
    }

    public static string Getcomponent(string componente, string info)
    {
      ManagementObjectSearcher mos = new ManagementObjectSearcher(@"root\CIMV2", "SELECT  * FROM " + componente);
      foreach (ManagementObject mj in mos.Get())
      {
        return Convert.ToString(mj[info]);
      }
      return null;
    }

    private void ListaProcessos()
    {
      if (listViewProcessos.InvokeRequired)
        listViewProcessos.BeginInvoke((MethodInvoker)delegate
        {
          listViewProcessos.Items.Clear();
          for (int i = 0; i < processos.Length; i++)
          {
            listViewProcessos.Items.Add(
                        new ListViewItem(new string[5] {
                                processos[i].Id.ToString(),
                                processos[i].ProcessName,
                                processos[i].Threads.Count.ToString(),
                                processos[i].BasePriority.ToString(),
                                (processos[i].PagedMemorySize64/1000).ToString() + " K"
                    }
                        ));
          }
        });
    }

    private void buttonAtualizar_Click(object sender, EventArgs e)
    {
      Process[] processos = Process.GetProcesses();
      if (listarProcessos.IsAlive)
        listarProcessos.Abort();
      listarProcessos = new Thread(ListaProcessos);
      listarProcessos.Start();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void ListarServicos()
    {
      if (listViewServicos.InvokeRequired)
        listViewServicos.BeginInvoke((MethodInvoker)delegate
       {
         listViewServicos.Items.Clear();
         for (int i = 0; i < servicos.Length; i++)
         {
           listViewServicos.Items.Add(new ListViewItem(new string[3]
                   {
                           servicos[i].ServiceName,
                           servicos[i].DisplayName,
                           servicos[i].Status.ToString()
               }));
         }
       });
    }

    private void buttonAtualizarServicos_Click(object sender, EventArgs e)
    {
      ServiceController[] servicos = ServiceController.GetServices();
      if (listarServicos.IsAlive)
        listarServicos.Abort();
      listarServicos = new Thread(ListarServicos);
      listarServicos.Start();
    }

    private void listViewProcessos_ColumnClick(object sender, ColumnClickEventArgs e)
    {

      QuickSort(0, processos.Length - 1, e.Column, 0);

      if (listarProcessos.IsAlive)
        listarProcessos.Abort();
      listarProcessos = new Thread(ListaProcessos);
      listarProcessos.Start();
    }

    private void QuickSort(int inicio, int fim, int coluna, int tipo) //tipo = 0 -> Process | tipo = 1 -> Service
    {
      int part;
      if (inicio < fim)
      {
        if (tipo == 0)
        {
          part = particaoProcess(inicio, fim, coluna);
          QuickSort(inicio, part - 1, coluna, tipo);
          QuickSort(part + 1, fim, coluna, tipo);
        }
        else
        {
          part = particaoService(inicio, fim, coluna);
          QuickSort(inicio, part - 1, coluna, tipo);
          QuickSort(part + 1, fim, coluna, tipo);
        }
      }
    }

    private int particaoProcess(int inicio, int fim, int coluna)
    {
      Process pivot = processos[fim];
      Process aux;
      int part = inicio - 1;
      for (int i = inicio; i < fim; i++)
      {
        if ((coluna == 0 && processos[i].Id.CompareTo(pivot.Id) == -1) ||
            (coluna == 1 && processos[i].ProcessName.CompareTo(pivot.ProcessName) == -1) ||
            (coluna == 2 && processos[i].Threads.Count.CompareTo(pivot.Threads.Count) == -1) ||
            (coluna == 3 && processos[i].BasePriority.CompareTo(pivot.BasePriority) == -1) ||
            (coluna == 4 && processos[i].PagedMemorySize64.CompareTo(pivot.PagedMemorySize64) == -1))
        {
          part = part + 1;
          aux = processos[part];
          processos[part] = processos[i];
          processos[i] = aux;
        }
      }
      aux = processos[part + 1];
      processos[part + 1] = processos[fim];
      processos[fim] = aux;
      return part + 1;
    }

    private int particaoService(int inicio, int fim, int coluna)
    {
      ServiceController pivot = servicos[fim];
      ServiceController aux;
      int part = inicio - 1;
      for (int i = inicio; i < fim; i++)
      {
        if ((coluna == 0 && servicos[i].ServiceName.CompareTo(pivot.ServiceName) == -1) ||
            (coluna == 1 && servicos[i].DisplayName.CompareTo(pivot.DisplayName) == -1) ||
            (coluna == 2 && servicos[i].Status.CompareTo(pivot.Status) == -1))
        {
          part = part + 1;
          aux = servicos[part];
          servicos[part] = servicos[i];
          servicos[i] = aux;
        }
      }
      aux = servicos[part + 1];
      servicos[part + 1] = servicos[fim];
      servicos[fim] = aux;
      return part + 1;
    }

    private void listViewServicos_ColumnClick(object sender, ColumnClickEventArgs e)
    {
      QuickSort(0, servicos.Length - 1, e.Column, 1);

      if (listarServicos.IsAlive)
        listarServicos.Abort();
      listarServicos = new Thread(ListarServicos);
      listarServicos.Start();
    }
  }
}
