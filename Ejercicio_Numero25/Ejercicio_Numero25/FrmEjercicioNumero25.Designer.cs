
namespace Ejercicio_Numero25
{
    partial class FrmEjercicioNumero25
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
            this.lblBinarioDecimal = new System.Windows.Forms.Label();
            this.lblDecimalBinario = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtResultadoBinario = new System.Windows.Forms.TextBox();
            this.txtResultadoDecimal = new System.Windows.Forms.TextBox();
            this.btnBinarioADecimal = new System.Windows.Forms.Button();
            this.btnDecimalABinario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBinarioDecimal
            // 
            this.lblBinarioDecimal.AutoSize = true;
            this.lblBinarioDecimal.Location = new System.Drawing.Point(31, 45);
            this.lblBinarioDecimal.Name = "lblBinarioDecimal";
            this.lblBinarioDecimal.Size = new System.Drawing.Size(95, 13);
            this.lblBinarioDecimal.TabIndex = 0;
            this.lblBinarioDecimal.Text = "Binario a Decimal: ";
            // 
            // lblDecimalBinario
            // 
            this.lblDecimalBinario.AutoSize = true;
            this.lblDecimalBinario.Location = new System.Drawing.Point(31, 76);
            this.lblDecimalBinario.Name = "lblDecimalBinario";
            this.lblDecimalBinario.Size = new System.Drawing.Size(92, 13);
            this.lblDecimalBinario.TabIndex = 1;
            this.lblDecimalBinario.Text = "Decimal a Binario:";
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(132, 38);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(100, 20);
            this.txtBinario.TabIndex = 2;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(132, 73);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 3;
            // 
            // txtResultadoBinario
            // 
            this.txtResultadoBinario.Enabled = false;
            this.txtResultadoBinario.Location = new System.Drawing.Point(378, 73);
            this.txtResultadoBinario.Name = "txtResultadoBinario";
            this.txtResultadoBinario.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoBinario.TabIndex = 4;
            // 
            // txtResultadoDecimal
            // 
            this.txtResultadoDecimal.Enabled = false;
            this.txtResultadoDecimal.Location = new System.Drawing.Point(378, 38);
            this.txtResultadoDecimal.Name = "txtResultadoDecimal";
            this.txtResultadoDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoDecimal.TabIndex = 5;
            // 
            // btnBinarioADecimal
            // 
            this.btnBinarioADecimal.Location = new System.Drawing.Point(269, 38);
            this.btnBinarioADecimal.Name = "btnBinarioADecimal";
            this.btnBinarioADecimal.Size = new System.Drawing.Size(75, 23);
            this.btnBinarioADecimal.TabIndex = 6;
            this.btnBinarioADecimal.Text = "->";
            this.btnBinarioADecimal.UseVisualStyleBackColor = true;
            this.btnBinarioADecimal.Click += new System.EventHandler(this.btnBinarioADecimal_Click);
            // 
            // btnDecimalABinario
            // 
            this.btnDecimalABinario.Location = new System.Drawing.Point(269, 71);
            this.btnDecimalABinario.Name = "btnDecimalABinario";
            this.btnDecimalABinario.Size = new System.Drawing.Size(75, 23);
            this.btnDecimalABinario.TabIndex = 7;
            this.btnDecimalABinario.Text = "->";
            this.btnDecimalABinario.UseVisualStyleBackColor = true;
            this.btnDecimalABinario.Click += new System.EventHandler(this.btnDecimalABinario_Click);
            // 
            // FrmEjercicioNumero25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 111);
            this.Controls.Add(this.btnDecimalABinario);
            this.Controls.Add(this.btnBinarioADecimal);
            this.Controls.Add(this.txtResultadoDecimal);
            this.Controls.Add(this.txtResultadoBinario);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.lblDecimalBinario);
            this.Controls.Add(this.lblBinarioDecimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEjercicioNumero25";
            this.Text = "Conversor Numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinarioDecimal;
        private System.Windows.Forms.Label lblDecimalBinario;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtResultadoBinario;
        private System.Windows.Forms.TextBox txtResultadoDecimal;
        private System.Windows.Forms.Button btnBinarioADecimal;
        private System.Windows.Forms.Button btnDecimalABinario;
    }
}

