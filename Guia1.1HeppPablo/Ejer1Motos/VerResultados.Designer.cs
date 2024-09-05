namespace Ejer1Motos
{
    partial class VerResultados
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
            this.listBResultados = new System.Windows.Forms.ListBox();
            this.btCerrarVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultados";
            // 
            // listBResultados
            // 
            this.listBResultados.FormattingEnabled = true;
            this.listBResultados.Location = new System.Drawing.Point(12, 46);
            this.listBResultados.Name = "listBResultados";
            this.listBResultados.Size = new System.Drawing.Size(431, 173);
            this.listBResultados.TabIndex = 1;
            // 
            // btCerrarVer
            // 
            this.btCerrarVer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btCerrarVer.Location = new System.Drawing.Point(203, 226);
            this.btCerrarVer.Name = "btCerrarVer";
            this.btCerrarVer.Size = new System.Drawing.Size(115, 39);
            this.btCerrarVer.TabIndex = 2;
            this.btCerrarVer.Text = "Cerrar";
            this.btCerrarVer.UseVisualStyleBackColor = true;
            // 
            // VerResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 277);
            this.Controls.Add(this.btCerrarVer);
            this.Controls.Add(this.listBResultados);
            this.Controls.Add(this.label1);
            this.Name = "VerResultados";
            this.Text = "VerResultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBResultados;
        public System.Windows.Forms.Button btCerrarVer;
    }
}