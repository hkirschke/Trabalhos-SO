using System;
using System.Windows.Forms;

namespace Arquitetura
{
  static class Program
  {  
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      FormLoad f = new FormLoad();
      string texto = f.texto;
      f.Close();
      Application.Run(new Form1(texto));
    }
  }
}
