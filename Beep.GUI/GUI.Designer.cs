namespace Beep.GUI
{
    partial class GUI
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
            this.btnBeepar = new System.Windows.Forms.Button();
            this.numFrequencia = new System.Windows.Forms.NumericUpDown();
            this.lblFrequencia = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.numDuracao = new System.Windows.Forms.NumericUpDown();
            this.chkSegurar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFrequencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBeepar
            // 
            this.btnBeepar.Location = new System.Drawing.Point(12, 52);
            this.btnBeepar.Name = "btnBeepar";
            this.btnBeepar.Size = new System.Drawing.Size(145, 23);
            this.btnBeepar.TabIndex = 0;
            this.btnBeepar.Text = "Beepar";
            this.btnBeepar.UseVisualStyleBackColor = true;
            this.btnBeepar.Click += new System.EventHandler(this.Beepar);
            // 
            // numFrequencia
            // 
            this.numFrequencia.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numFrequencia.Location = new System.Drawing.Point(12, 27);
            this.numFrequencia.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numFrequencia.Minimum = new decimal(new int[] {
            37,
            0,
            0,
            0});
            this.numFrequencia.Name = "numFrequencia";
            this.numFrequencia.Size = new System.Drawing.Size(91, 23);
            this.numFrequencia.TabIndex = 1;
            this.numFrequencia.Value = new decimal(new int[] {
            37,
            0,
            0,
            0});
            // 
            // lblFrequencia
            // 
            this.lblFrequencia.AutoSize = true;
            this.lblFrequencia.Location = new System.Drawing.Point(12, 9);
            this.lblFrequencia.Name = "lblFrequencia";
            this.lblFrequencia.Size = new System.Drawing.Size(90, 15);
            this.lblFrequencia.TabIndex = 2;
            this.lblFrequencia.Text = "Frequência (Hz)";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(109, 9);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(78, 15);
            this.lblDuracao.TabIndex = 3;
            this.lblDuracao.Text = "Duração (ms)";
            // 
            // numDuracao
            // 
            this.numDuracao.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDuracao.Location = new System.Drawing.Point(109, 27);
            this.numDuracao.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numDuracao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuracao.Name = "numDuracao";
            this.numDuracao.Size = new System.Drawing.Size(120, 23);
            this.numDuracao.TabIndex = 4;
            this.numDuracao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkSegurar
            // 
            this.chkSegurar.AutoSize = true;
            this.chkSegurar.Location = new System.Drawing.Point(163, 55);
            this.chkSegurar.Name = "chkSegurar";
            this.chkSegurar.Size = new System.Drawing.Size(66, 19);
            this.chkSegurar.TabIndex = 5;
            this.chkSegurar.Text = "Segurar";
            this.chkSegurar.UseVisualStyleBackColor = true;
            this.chkSegurar.CheckedChanged += new System.EventHandler(this.AlternarFuncionalidadeBotao);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 86);
            this.Controls.Add(this.btnBeepar);
            this.Controls.Add(this.chkSegurar);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.numDuracao);
            this.Controls.Add(this.numFrequencia);
            this.Controls.Add(this.lblFrequencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "Beep";
            ((System.ComponentModel.ISupportInitialize)(this.numFrequencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeepar;
        private System.Windows.Forms.NumericUpDown numFrequencia;
        private System.Windows.Forms.Label lblFrequencia;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.NumericUpDown numDuracao;
        private System.Windows.Forms.CheckBox chkSegurar;
    }
}