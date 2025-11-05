namespace SP02
{
    partial class frmBoletos
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
            this.lblDistancia = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.Distancia = new System.Windows.Forms.Label();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tabBoletos = new System.Windows.Forms.TabControl();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.tabConsultas = new System.Windows.Forms.TabPage();
            this.lstBoletosTotales = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.tabBoletos.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            this.tabConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(6, 9);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(132, 24);
            this.lblDistancia.TabIndex = 0;
            this.lblDistancia.Text = "Distancia (km):";
            this.lblDistancia.Click += new System.EventHandler(this.lblDistancia_Click);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(241, 9);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(120, 20);
            this.txtDistancia.TabIndex = 1;
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDistancia_TextChanged);
            this.txtDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistancia_KeyPress);
            // 
            // Distancia
            // 
            this.Distancia.AutoSize = true;
            this.Distancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distancia.Location = new System.Drawing.Point(6, 54);
            this.Distancia.Name = "Distancia";
            this.Distancia.Size = new System.Drawing.Size(207, 24);
            this.Distancia.TabIndex = 2;
            this.Distancia.Text = "Días de estancia (1–30):";
            this.Distancia.Click += new System.EventHandler(this.Distancia_Click);
            // 
            // nudDias
            // 
            this.nudDias.Location = new System.Drawing.Point(241, 59);
            this.nudDias.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(120, 20);
            this.nudDias.TabIndex = 3;
            this.nudDias.TabStop = false;
            this.nudDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(63, 104);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(241, 104);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tabBoletos
            // 
            this.tabBoletos.Controls.Add(this.tabRegistro);
            this.tabBoletos.Controls.Add(this.tabConsultas);
            this.tabBoletos.Location = new System.Drawing.Point(12, 12);
            this.tabBoletos.Name = "tabBoletos";
            this.tabBoletos.SelectedIndex = 0;
            this.tabBoletos.Size = new System.Drawing.Size(432, 170);
            this.tabBoletos.TabIndex = 6;
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.Distancia);
            this.tabRegistro.Controls.Add(this.btnLimpiar);
            this.tabRegistro.Controls.Add(this.lblDistancia);
            this.tabRegistro.Controls.Add(this.btnCalcular);
            this.tabRegistro.Controls.Add(this.txtDistancia);
            this.tabRegistro.Controls.Add(this.nudDias);
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(424, 136);
            this.tabRegistro.TabIndex = 0;
            this.tabRegistro.Text = "Càlculo boletos";
            this.tabRegistro.UseVisualStyleBackColor = true;
            // 
            // tabConsultas
            // 
            this.tabConsultas.Controls.Add(this.lstBoletosTotales);
            this.tabConsultas.Location = new System.Drawing.Point(4, 22);
            this.tabConsultas.Name = "tabConsultas";
            this.tabConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultas.Size = new System.Drawing.Size(424, 144);
            this.tabConsultas.TabIndex = 1;
            this.tabConsultas.Text = "Consultas";
            this.tabConsultas.UseVisualStyleBackColor = true;
            // 
            // lstBoletosTotales
            // 
            this.lstBoletosTotales.FormattingEnabled = true;
            this.lstBoletosTotales.Location = new System.Drawing.Point(7, 4);
            this.lstBoletosTotales.Name = "lstBoletosTotales";
            this.lstBoletosTotales.Size = new System.Drawing.Size(411, 134);
            this.lstBoletosTotales.TabIndex = 0;
            this.lstBoletosTotales.SelectedIndexChanged += new System.EventHandler(this.lstBoletosTotales_SelectedIndexChanged);
            // 
            // frmBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 223);
            this.Controls.Add(this.tabBoletos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBoletos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de boletos de tren";
            this.Load += new System.EventHandler(this.frmBoletos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.tabBoletos.ResumeLayout(false);
            this.tabRegistro.ResumeLayout(false);
            this.tabRegistro.PerformLayout();
            this.tabConsultas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label Distancia;
        private System.Windows.Forms.NumericUpDown nudDias;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TabControl tabBoletos;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.TabPage tabConsultas;
        private System.Windows.Forms.ListBox lstBoletosTotales;
    }
}