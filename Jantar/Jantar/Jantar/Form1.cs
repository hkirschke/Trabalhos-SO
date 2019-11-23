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

namespace Jantar
{
    public partial class Form1 : Form
    { 
        PictureBox[] filosos = new PictureBox[5];
        PictureBox[] pratos = new PictureBox[5];
        PictureBox[] garfos = new PictureBox[5];
        Random random = new Random();
        Thread[] processos = new Thread[5];
        Semaphore[] recursos = new Semaphore[5];
        
        public Form1()
        {
            InitializeComponent();

            filosos[0] = pictureBoxFilosofo1;
            filosos[1] = pictureBoxFilosofo2;
            filosos[2] = pictureBoxFilosofo3;
            filosos[3] = pictureBoxFilosofo4;
            filosos[4] = pictureBoxFilosofo5;

            pratos[0] = pictureBoxPrato1;
            pratos[1] = pictureBoxPrato2;
            pratos[2] = pictureBoxPrato3;
            pratos[3] = pictureBoxPrato4;
            pratos[4] = pictureBoxPrato5;

            garfos[0] = pictureBoxGarfo1;
            garfos[1] = pictureBoxGarfo2;
            garfos[2] = pictureBoxGarfo3;
            garfos[3] = pictureBoxGarfo4;
            garfos[4] = pictureBoxGarfo5;

            for (int i = 0; i < filosos.Length; i++)
            {
                filosos[i].BackColor = Color.DarkRed;
            }
        }

        private void Comer (int n)
        {
            if (n == 0)
            {
                recursos[4].WaitOne();
                recursos[0].WaitOne();
                garfos[4].BackColor = Color.DarkBlue;
                garfos[0].BackColor = Color.DarkBlue;
            }
            else
            {
                recursos[n - 1].WaitOne();
                recursos[n].WaitOne();
                garfos[n - 1].BackColor = Color.DarkBlue;
                garfos[n].BackColor = Color.DarkBlue;
            }
            
            filosos[n].BackColor = Color.DarkBlue;
            pratos[n].BackColor = Color.DarkBlue;
            Thread.Sleep(random.Next(1000, 2000));
        }

        private void Pensar (int n)
        {
            if (n == 0)
            {
                garfos[4].BackColor = Color.Transparent;
                garfos[0].BackColor = Color.Transparent;
                recursos[4].Release();
                recursos[0].Release();
            }
            else
            {
                garfos[n - 1].BackColor = Color.Transparent;
                garfos[n].BackColor = Color.Transparent;
                recursos[n - 1].Release();
                recursos[n].Release();
            }
            
            filosos[n].BackColor = Color.DarkGreen;
            pratos[n].BackColor = Color.Transparent;
            Thread.Sleep(random.Next(1000, 2000));
        }

        private void Faminto (int n)
        {
            filosos[n].BackColor = Color.DarkRed;
        }
        
        private void AcaoFilosofo (int n)
        {
            while (true)
            {
                Comer(n);
                Pensar(n);
                Faminto(n);
            }
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < filosos.Length; i++)
            {
                filosos[i].BackColor = Color.DarkRed;
                pratos[i].BackColor = Color.Transparent;
                garfos[i].BackColor = Color.Transparent;
            }
            for (int i = 0; i < recursos.Length; i++)
                recursos[i] = new Semaphore(1, 1);

            processos[0] = new Thread(() => AcaoFilosofo(0));
            processos[1] = new Thread(() => AcaoFilosofo(1));
            processos[2] = new Thread(() => AcaoFilosofo(2));
            processos[3] = new Thread(() => AcaoFilosofo(3));
            processos[4] = new Thread(() => AcaoFilosofo(4));

            for (int i = 0; i < processos.Length; i++)
                processos[i].Start();
        }

        private void buttonParar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < processos.Length; i++)
            {
                if (processos[i].IsAlive) processos[i].Abort();
                recursos[i].Close();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < processos.Length; i++)
            {
                if (processos[i].IsAlive) processos[i].Abort();
                recursos[i].Close();
            }
        }
    }
}
