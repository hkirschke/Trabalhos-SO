using System.IO;
using System.Linq;
using System.Management;
using System.Text;

namespace ProcessReader
{
  public static class InfoPC
  {
    public static StringBuilder LoadInfo()
    {
      StringBuilder stringBuilder = new StringBuilder();
      ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");

      ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");

      stringBuilder.AppendLine("          Informações Processador");

      foreach (ManagementObject obj in myProcessorObject.Get().OfType<ManagementObject>())
      {
        stringBuilder.AppendLine($"Name  -  {obj["Name"]}");
        stringBuilder.AppendLine($"DeviceID  -  {obj["DeviceID"]}");
        stringBuilder.AppendLine($"Manufacturer  -  {obj["Manufacturer"]}");
        stringBuilder.AppendLine($"Current Clock Speed  -  { obj["CurrentClockSpeed"]}");
        stringBuilder.AppendLine($"Caption  -  {obj["Caption"]}");
        stringBuilder.AppendLine($"Number Of Cores  -  {obj["NumberOfCores"]}");
        stringBuilder.AppendLine($"Number Of EnabledCore  -  {obj["NumberOfEnabledCore"]}");
        stringBuilder.AppendLine($"Number Of LogicalProcessors  -  {obj["NumberOfLogicalProcessors"]}");
      }

      stringBuilder.AppendLine();
      stringBuilder.AppendLine("          Informações Placa de Video ");
      foreach (ManagementObject obj in myVideoObject.Get().OfType<ManagementObject>())
      {
        stringBuilder.AppendLine($"Name  -  {obj["Name"]}");
        stringBuilder.AppendLine($"Status  -  { obj["Status"]}");
        stringBuilder.AppendLine($"DeviceID  -  {obj["DeviceID"]}");
        stringBuilder.AppendLine($"AdapterDACType  -  {obj["AdapterDACType"]}");
        stringBuilder.AppendLine($"DriverVersion  -  {obj["DriverVersion"]}");
        stringBuilder.AppendLine($"VideoProcessor  -  { obj["VideoProcessor"]}");
      }

      stringBuilder.AppendLine();

      DriveInfo[] allDrives = DriveInfo.GetDrives();

      foreach (DriveInfo d in allDrives)
      {
        stringBuilder.AppendLine($"         Drive {d.Name}");
        stringBuilder.AppendLine($"Drive type: {d.DriveType}");
        if (d.IsReady)
        {
          stringBuilder.AppendLine($"Volume label: { d.VolumeLabel}");
          stringBuilder.AppendLine($"File system: {d.DriveFormat}");
          stringBuilder.AppendLine($"Available space to current user:{ Utils.GetSize(d.AvailableFreeSpace)}"); 
          stringBuilder.AppendLine($"Total available space:          {  Utils.GetSize(d.TotalFreeSpace)}"); 
          stringBuilder.AppendLine($"Total size of drive:            { Utils.GetSize(d.TotalSize)} ");
          stringBuilder.AppendLine($"Root directory:            { d.RootDirectory,12}");
        }
        stringBuilder.AppendLine();
      }
      return stringBuilder;
    }
  }
}
