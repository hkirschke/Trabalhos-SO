using System;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace Arquitetura
{
  public partial class FormLoad : Form
  {
    public string texto;

    public FormLoad()
    {
      InitializeComponent();
      this.Visible = true;
      progressBarCarregamento.Step = 1;
      texto = "\t   INFORMAÇÕES DO PROCESSADOR\r\n\r\n";
      texto += "Nome: " + Getcomponent("Win32_Processor", "Name") + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Descrição: " + Getcomponent("Win32_Processor", "Description") + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Fabricante: " + Getcomponent("Win32_Processor", "Manufacturer") + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Quantidade de núcelos: " + Getcomponent("Win32_Processor", "NumberOfCores") + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Quantidade de processadores lógicos: " + Getcomponent("Win32_Processor", "NumberOfLogicalProcessors") + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Arquitetura: " + GetArquitetura(Getcomponent("Win32_Processor", "Architecture")) + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Tamanho de endereçamento: " + Getcomponent("Win32_Processor", "AddressWidth") + " bits" + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Velocidade de clock máxima: " + Getcomponent("Win32_Processor", "MaxClockSpeed") + " MHz" + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Velocidade de clock atual: " + Getcomponent("Win32_Processor", "CurrentClockSpeed") + " MHz" + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Tensão atual: " + Getcomponent("Win32_Processor", "CurrentVoltage") + " volts" + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "ID do dispositivo: " + Getcomponent("Win32_Processor", "DeviceID") + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "ID do processador: 0x" + Getcomponent("Win32_Processor", "ProcessorId") + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Tamanho da Cache L2: " + Getcomponent("Win32_Processor", "L2CacheSize") + " kilobytes" + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Tamanho da Cache L3: " + Getcomponent("Win32_Processor", "L3CacheSize") + " kilobytes" + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Porcentagem da média de carregamento: " + Getcomponent("Win32_Processor", "LoadPercentage") + "%" + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Tipo de processador: " + GetTipoProcessador(Getcomponent("Win32_Processor", "ProcessorType")) + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Socket designado: " + Getcomponent("Win32_Processor", "SocketDesignation") + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Nome do sistema interno: " + Getcomponent("Win32_Processor", "SystemName") + "\r\n";
      progressBarCarregamento.PerformStep();
      texto += "Status: " + Getcomponent("Win32_Processor", "Status") + "\r\n";
      progressBarCarregamento.PerformStep();


      texto += "\r\n    INFORMAÇÕES DAS UNIDADE DE DISCO/PARTIÇÕES";
      DriveInfo[] drives = DriveInfo.GetDrives();

      foreach (DriveInfo drive in drives)
      {
        try
        {
          texto += "\r\n\r\nDisco: " + drive.Name + "\r\n";
          texto += "Tipo: " + drive.DriveType + "\r\n";
          texto += "Nome: " + drive.VolumeLabel + "\r\n";
          texto += "Sistema de arquivos: " + drive.DriveFormat + "\r\n";
          texto += "Espaço livre utilizável: " + ((drive.AvailableFreeSpace / Math.Pow(2, 30)).ToString("0.00") + " GB" + "\r\n");
          texto += "Espaço total livre: " + ((drive.TotalFreeSpace / Math.Pow(2, 30)).ToString("0.00") + " GB" + "\r\n");
          texto += "Espaço total usado: " + (((drive.TotalSize - drive.TotalFreeSpace) / Math.Pow(2, 30)).ToString("0.00") + " GB" + "\r\n");
          texto += "Espaço total: " + ((drive.TotalSize / Math.Pow(2, 30)).ToString("0.00") + " GB" + "\r\n");
        }
        catch { }
      }

      progressBarCarregamento.PerformStep();
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

    private static string GetArquitetura(string numero)
    {
      if (numero.Equals("0"))
        return "x86";
      else if (numero.Equals("1"))
        return "MIPS";
      else if (numero.Equals("2"))
        return "Alpha";
      else if (numero.Equals("3"))
        return "PowerPC";
      else if (numero.Equals("5"))
        return "ARM";
      else if (numero.Equals("6"))
        return "ia64";
      else
        return "x64";
    }

    private static string GetTipoProcessador(string numero)
    {
      if (numero.Equals("1"))
        return "Outro";
      else if (numero.Equals("2"))
        return "Desconhecido";
      else if (numero.Equals("3"))
        return "Processador Central";
      else if (numero.Equals("4"))
        return "Processador matemático";
      else if (numero.Equals("5"))
        return "Processador DSP";
      else
        return "Processador de vídeo";
    }
  }
}
