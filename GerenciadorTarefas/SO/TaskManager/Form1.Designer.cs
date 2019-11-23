namespace Arquitetura
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelMemoriaTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMemoriaUtilizada = new System.Windows.Forms.Label();
            this.labelMemoriaDisponivel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMemoria = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarMemoria = new System.Windows.Forms.ProgressBar();
            this.labelCPU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.textBoxInformacoes = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.listViewProcessos = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Threads = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prioridade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Memoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonAtualizarServicos = new System.Windows.Forms.Button();
            this.listViewServicos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-5, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(373, 522);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelMemoriaTotal);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.labelMemoriaUtilizada);
            this.tabPage1.Controls.Add(this.labelMemoriaDisponivel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.labelMemoria);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.progressBarMemoria);
            this.tabPage1.Controls.Add(this.labelCPU);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.progressBarCPU);
            this.tabPage1.Controls.Add(this.textBoxInformacoes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(365, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelMemoriaTotal
            // 
            this.labelMemoriaTotal.AutoSize = true;
            this.labelMemoriaTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemoriaTotal.Location = new System.Drawing.Point(156, 107);
            this.labelMemoriaTotal.Name = "labelMemoriaTotal";
            this.labelMemoriaTotal.Size = new System.Drawing.Size(46, 14);
            this.labelMemoriaTotal.TabIndex = 26;
            this.labelMemoriaTotal.Text = "5,00 GB";
            this.labelMemoriaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(117, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 14);
            this.label7.TabIndex = 25;
            this.label7.Text = "Memória Total Utilizável";
            // 
            // labelMemoriaUtilizada
            // 
            this.labelMemoriaUtilizada.AutoSize = true;
            this.labelMemoriaUtilizada.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemoriaUtilizada.Location = new System.Drawing.Point(156, 66);
            this.labelMemoriaUtilizada.Name = "labelMemoriaUtilizada";
            this.labelMemoriaUtilizada.Size = new System.Drawing.Size(46, 14);
            this.labelMemoriaUtilizada.TabIndex = 24;
            this.labelMemoriaUtilizada.Text = "5,00 GB";
            this.labelMemoriaUtilizada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMemoriaDisponivel
            // 
            this.labelMemoriaDisponivel.AutoSize = true;
            this.labelMemoriaDisponivel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemoriaDisponivel.Location = new System.Drawing.Point(156, 29);
            this.labelMemoriaDisponivel.Name = "labelMemoriaDisponivel";
            this.labelMemoriaDisponivel.Size = new System.Drawing.Size(46, 14);
            this.labelMemoriaDisponivel.TabIndex = 23;
            this.labelMemoriaDisponivel.Text = "5,00 GB";
            this.labelMemoriaDisponivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 14);
            this.label4.TabIndex = 22;
            this.label4.Text = "Memória Utilizada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Memória Disponível";
            // 
            // labelMemoria
            // 
            this.labelMemoria.AutoSize = true;
            this.labelMemoria.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemoria.Location = new System.Drawing.Point(24, 29);
            this.labelMemoria.Name = "labelMemoria";
            this.labelMemoria.Size = new System.Drawing.Size(82, 34);
            this.labelMemoria.TabIndex = 20;
            this.labelMemoria.Text = "100%";
            this.labelMemoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Memória";
            // 
            // progressBarMemoria
            // 
            this.progressBarMemoria.Location = new System.Drawing.Point(6, 66);
            this.progressBarMemoria.Name = "progressBarMemoria";
            this.progressBarMemoria.Size = new System.Drawing.Size(105, 23);
            this.progressBarMemoria.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarMemoria.TabIndex = 18;
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPU.Location = new System.Drawing.Point(270, 29);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(82, 34);
            this.labelCPU.TabIndex = 17;
            this.labelCPU.Text = "100%";
            this.labelCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tempo de CPU";
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(252, 66);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(105, 23);
            this.progressBarCPU.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarCPU.TabIndex = 15;
            // 
            // textBoxInformacoes
            // 
            this.textBoxInformacoes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxInformacoes.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInformacoes.Location = new System.Drawing.Point(13, 124);
            this.textBoxInformacoes.Multiline = true;
            this.textBoxInformacoes.Name = "textBoxInformacoes";
            this.textBoxInformacoes.ReadOnly = true;
            this.textBoxInformacoes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInformacoes.Size = new System.Drawing.Size(339, 366);
            this.textBoxInformacoes.TabIndex = 14;
            this.textBoxInformacoes.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonAtualizar);
            this.tabPage2.Controls.Add(this.listViewProcessos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(365, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Processos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(146, 467);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 1;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // listViewProcessos
            // 
            this.listViewProcessos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nome,
            this.Threads,
            this.Prioridade,
            this.Memoria});
            this.listViewProcessos.FullRowSelect = true;
            this.listViewProcessos.GridLines = true;
            this.listViewProcessos.Location = new System.Drawing.Point(6, 6);
            this.listViewProcessos.Name = "listViewProcessos";
            this.listViewProcessos.Size = new System.Drawing.Size(353, 455);
            this.listViewProcessos.TabIndex = 0;
            this.listViewProcessos.UseCompatibleStateImageBehavior = false;
            this.listViewProcessos.View = System.Windows.Forms.View.Details;
            this.listViewProcessos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewProcessos_ColumnClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 94;
            // 
            // Threads
            // 
            this.Threads.Text = "Threads";
            this.Threads.Width = 55;
            // 
            // Prioridade
            // 
            this.Prioridade.Text = "Prioridade";
            // 
            // Memoria
            // 
            this.Memoria.Text = "Memória";
            this.Memoria.Width = 80;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonAtualizarServicos);
            this.tabPage3.Controls.Add(this.listViewServicos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(365, 496);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Serviços";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonAtualizarServicos
            // 
            this.buttonAtualizarServicos.Location = new System.Drawing.Point(146, 467);
            this.buttonAtualizarServicos.Name = "buttonAtualizarServicos";
            this.buttonAtualizarServicos.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizarServicos.TabIndex = 2;
            this.buttonAtualizarServicos.Text = "Atualizar";
            this.buttonAtualizarServicos.UseVisualStyleBackColor = true;
            this.buttonAtualizarServicos.Click += new System.EventHandler(this.buttonAtualizarServicos_Click);
            // 
            // listViewServicos
            // 
            this.listViewServicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewServicos.FullRowSelect = true;
            this.listViewServicos.GridLines = true;
            this.listViewServicos.Location = new System.Drawing.Point(6, 6);
            this.listViewServicos.Name = "listViewServicos";
            this.listViewServicos.Size = new System.Drawing.Size(353, 455);
            this.listViewServicos.TabIndex = 1;
            this.listViewServicos.UseCompatibleStateImageBehavior = false;
            this.listViewServicos.View = System.Windows.Forms.View.Details;
            this.listViewServicos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewServicos_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            this.columnHeader2.Width = 190;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(363, 514);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análise PC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelMemoriaTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMemoriaUtilizada;
        private System.Windows.Forms.Label labelMemoriaDisponivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMemoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBarMemoria;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.TextBox textBoxInformacoes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewProcessos;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Threads;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.ColumnHeader Prioridade;
        private System.Windows.Forms.ColumnHeader Memoria;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listViewServicos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonAtualizarServicos;
    }
}

