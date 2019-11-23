namespace Arquitetura
{
    partial class FormLoad
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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarCarregamento = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carregando informações...";
            // 
            // progressBarCarregamento
            // 
            this.progressBarCarregamento.Location = new System.Drawing.Point(12, 61);
            this.progressBarCarregamento.Maximum = 20;
            this.progressBarCarregamento.Name = "progressBarCarregamento";
            this.progressBarCarregamento.Size = new System.Drawing.Size(271, 23);
            this.progressBarCarregamento.TabIndex = 1;
            // 
            // FormCarregamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 104);
            this.Controls.Add(this.progressBarCarregamento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCarregamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCarregamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarCarregamento;
    }
}