namespace Ejer1Motos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbValorFab = new System.Windows.Forms.TextBox();
            this.numModelo = new System.Windows.Forms.NumericUpDown();
            this.numAño = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTasa = new System.Windows.Forms.TextBox();
            this.tbVida = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAño)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo (año)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año a calcular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor de Fabricación $";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(145, 28);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 4;
            // 
            // tbValorFab
            // 
            this.tbValorFab.Location = new System.Drawing.Point(145, 161);
            this.tbValorFab.Name = "tbValorFab";
            this.tbValorFab.Size = new System.Drawing.Size(100, 20);
            this.tbValorFab.TabIndex = 5;
            // 
            // numModelo
            // 
            this.numModelo.Location = new System.Drawing.Point(145, 69);
            this.numModelo.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numModelo.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numModelo.Name = "numModelo";
            this.numModelo.Size = new System.Drawing.Size(100, 20);
            this.numModelo.TabIndex = 6;
            this.numModelo.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.numModelo.ValueChanged += new System.EventHandler(this.numModelo_ValueChanged);
            // 
            // numAño
            // 
            this.numAño.Location = new System.Drawing.Point(145, 115);
            this.numAño.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numAño.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numAño.Name = "numAño";
            this.numAño.Size = new System.Drawing.Size(100, 20);
            this.numAño.TabIndex = 7;
            this.numAño.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tasa de depreciación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vida Util (Años)";
            // 
            // tbTasa
            // 
            this.tbTasa.Location = new System.Drawing.Point(452, 28);
            this.tbTasa.Name = "tbTasa";
            this.tbTasa.Size = new System.Drawing.Size(100, 20);
            this.tbTasa.TabIndex = 10;
            // 
            // tbVida
            // 
            this.tbVida.Location = new System.Drawing.Point(452, 74);
            this.tbVida.Name = "tbVida";
            this.tbVida.Size = new System.Drawing.Size(100, 20);
            this.tbVida.TabIndex = 11;
            // 
            // btCalcular
            // 
            this.btCalcular.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btCalcular.Location = new System.Drawing.Point(145, 264);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(100, 44);
            this.btCalcular.TabIndex = 12;
            this.btCalcular.Text = "Calcular Costo";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCerrar.Location = new System.Drawing.Point(339, 264);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(92, 44);
            this.btCerrar.TabIndex = 13;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 372);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.tbVida);
            this.Controls.Add(this.tbTasa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numAño);
            this.Controls.Add(this.numModelo);
            this.Controls.Add(this.tbValorFab);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btCalcular;
        public System.Windows.Forms.Button btCerrar;
        public System.Windows.Forms.NumericUpDown numAño;
        public System.Windows.Forms.TextBox tbMarca;
        public System.Windows.Forms.TextBox tbValorFab;
        public System.Windows.Forms.TextBox tbTasa;
        public System.Windows.Forms.TextBox tbVida;
        public System.Windows.Forms.NumericUpDown numModelo;
    }
}

