
namespace Ejercicio_Numero67
{
    partial class MiTermporizador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.nupdwIntervalo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupdwIntervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTiempo.Location = new System.Drawing.Point(267, 40);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(204, 65);
            this.lblTiempo.TabIndex = 0;
            this.lblTiempo.Text = "00:00:00";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(215, 93);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // nupdwIntervalo
            // 
            this.nupdwIntervalo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nupdwIntervalo.Location = new System.Drawing.Point(12, 121);
            this.nupdwIntervalo.Name = "nupdwIntervalo";
            this.nupdwIntervalo.Size = new System.Drawing.Size(215, 47);
            this.nupdwIntervalo.TabIndex = 2;
            this.nupdwIntervalo.ValueChanged += new System.EventHandler(this.nupdwIntervalo_ValueChanged);
            // 
            // MiTermporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 202);
            this.Controls.Add(this.nupdwIntervalo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblTiempo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MiTermporizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temporizador";
            ((System.ComponentModel.ISupportInitialize)(this.nupdwIntervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.NumericUpDown nupdwIntervalo;
    }
}

