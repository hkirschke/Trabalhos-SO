namespace Barbeiro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxBarbearia = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelClientes = new System.Windows.Forms.Label();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonParar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarbearia)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBarbearia
            // 
            this.pictureBoxBarbearia.Image = global::Barbeiro.Properties.Resources.Barbearia;
            this.pictureBoxBarbearia.Location = new System.Drawing.Point(137, 12);
            this.pictureBoxBarbearia.Name = "pictureBoxBarbearia";
            this.pictureBoxBarbearia.Size = new System.Drawing.Size(179, 338);
            this.pictureBoxBarbearia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBarbearia.TabIndex = 0;
            this.pictureBoxBarbearia.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes:";
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientes.Location = new System.Drawing.Point(57, 100);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(18, 19);
            this.labelClientes.TabIndex = 2;
            this.labelClientes.Text = "0";
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(26, 276);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(75, 23);
            this.buttonIniciar.TabIndex = 3;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // buttonParar
            // 
            this.buttonParar.Location = new System.Drawing.Point(26, 327);
            this.buttonParar.Name = "buttonParar";
            this.buttonParar.Size = new System.Drawing.Size(75, 23);
            this.buttonParar.TabIndex = 4;
            this.buttonParar.Text = "Parar";
            this.buttonParar.UseVisualStyleBackColor = true;
            this.buttonParar.Click += new System.EventHandler(this.buttonParar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 362);
            this.Controls.Add(this.buttonParar);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxBarbearia);
            this.Name = "Form1";
            this.Text = "Barbeiro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarbearia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBarbearia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonParar;
    }
}

