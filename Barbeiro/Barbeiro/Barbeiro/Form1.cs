using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Barbeiro
{
  public partial class Form1 : Form
  {
    int cont;
    Random random = new Random();
    Thread fila;
    Stack<Thread> clientes = new Stack<Thread>();
    object barbeiro = new object();
    public Form1()
    {
      InitializeComponent();
      pictureBoxBarbearia.BackColor = Color.DarkBlue;
      cont = 0;
    }

    private void ChegaCliente()
    {
      while (true)
      {
        Thread.Sleep(random.Next(2000, 5000));
        cont++;
        if (labelClientes.InvokeRequired)
          labelClientes.BeginInvoke((MethodInvoker)delegate
         {
           labelClientes.Text = cont.ToString();
         });
        clientes.Push(new Thread(AcaoBarbeiro));
        clientes.Peek().Start();
      }
    }

    private void AcaoBarbeiro()
    {
      lock (barbeiro)
      {
        pictureBoxBarbearia.BackColor = Color.Yellow;
        Thread.Sleep(3000);
        cont--;
        if (labelClientes.InvokeRequired)
          labelClientes.BeginInvoke((MethodInvoker)delegate
          {
            labelClientes.Text = cont.ToString();
          });
      }
      if (cont == 0)
        pictureBoxBarbearia.BackColor = Color.DarkBlue;
    }

    private void buttonIniciar_Click(object sender, EventArgs e)
    {
      cont = 0;
      labelClientes.Text = (0).ToString();
      if (fila != null && fila.IsAlive) fila.Abort();
      while (clientes.Count > 0)
        clientes.Pop().Abort();
      pictureBoxBarbearia.BackColor = Color.DarkBlue;
      fila = new Thread(ChegaCliente);
      fila.Start();
    }

    private void buttonParar_Click(object sender, EventArgs e)
    {
      if (fila != null && fila.IsAlive) fila.Abort();
      while (clientes.Count > 0)
        clientes.Pop().Abort();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (fila != null && fila.IsAlive) fila.Abort();
      while (clientes.Count > 0)
        clientes.Pop().Abort();
    }
  }
}
