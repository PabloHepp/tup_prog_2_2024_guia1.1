namespace Ejercicio2Basquet
{
    partial class AgregarJug
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
            this.tbNombreJug = new System.Windows.Forms.TextBox();
            this.tbNroCamiseta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAceptarJug = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numSimples = new System.Windows.Forms.NumericUpDown();
            this.numDobles = new System.Windows.Forms.NumericUpDown();
            this.numTriples = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSimples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDobles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriples)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombreJug
            // 
            this.tbNombreJug.Location = new System.Drawing.Point(105, 36);
            this.tbNombreJug.Name = "tbNombreJug";
            this.tbNombreJug.Size = new System.Drawing.Size(100, 20);
            this.tbNombreJug.TabIndex = 0;
            // 
            // tbNroCamiseta
            // 
            this.tbNroCamiseta.Location = new System.Drawing.Point(105, 62);
            this.tbNroCamiseta.Name = "tbNroCamiseta";
            this.tbNroCamiseta.Size = new System.Drawing.Size(100, 20);
            this.tbNroCamiseta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nº Camiseta";
            // 
            // btAceptarJug
            // 
            this.btAceptarJug.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptarJug.Location = new System.Drawing.Point(105, 198);
            this.btAceptarJug.Name = "btAceptarJug";
            this.btAceptarJug.Size = new System.Drawing.Size(100, 23);
            this.btAceptarJug.TabIndex = 4;
            this.btAceptarJug.Text = "Aceptar";
            this.btAceptarJug.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Simples";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dobles";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Triples";
            // 
            // numSimples
            // 
            this.numSimples.Location = new System.Drawing.Point(108, 104);
            this.numSimples.Name = "numSimples";
            this.numSimples.Size = new System.Drawing.Size(97, 20);
            this.numSimples.TabIndex = 8;
            // 
            // numDobles
            // 
            this.numDobles.Location = new System.Drawing.Point(108, 135);
            this.numDobles.Name = "numDobles";
            this.numDobles.Size = new System.Drawing.Size(97, 20);
            this.numDobles.TabIndex = 9;
            // 
            // numTriples
            // 
            this.numTriples.Location = new System.Drawing.Point(108, 164);
            this.numTriples.Name = "numTriples";
            this.numTriples.Size = new System.Drawing.Size(97, 20);
            this.numTriples.TabIndex = 10;
            // 
            // AgregarJug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 270);
            this.Controls.Add(this.numTriples);
            this.Controls.Add(this.numDobles);
            this.Controls.Add(this.numSimples);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAceptarJug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNroCamiseta);
            this.Controls.Add(this.tbNombreJug);
            this.Name = "AgregarJug";
            this.Text = "AgregarJug";
            ((System.ComponentModel.ISupportInitialize)(this.numSimples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDobles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriples)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAceptarJug;
        public System.Windows.Forms.TextBox tbNombreJug;
        public System.Windows.Forms.TextBox tbNroCamiseta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown numSimples;
        public System.Windows.Forms.NumericUpDown numDobles;
        public System.Windows.Forms.NumericUpDown numTriples;
    }
}