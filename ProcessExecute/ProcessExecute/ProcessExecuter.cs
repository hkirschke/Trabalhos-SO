using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessExecute
{
  public class ProcessExecuter
  {
    private int _timeToKillProc;
    private Process _process;
    public int TimeToKillProc { get => _timeToKillProc; set => _timeToKillProc = value; }
    public Process Process { get => _process; set => _process = value; }

    public void Execute(string pathExec, string strTimeKill)
    {
      Process = Process.Start(pathExec);
      if (int.TryParse(strTimeKill, out int killTime))
      {
        Thread.Sleep(killTime);
        Process.Kill();
      }
    }
    public void Execute(string pathExec)
    {
      Process = Process.Start(pathExec);
    }
  }
}
