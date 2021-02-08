
namespace CentralitaFormulario
{
    partial class FrmLlamador
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
            this.grpBoxPanel = new System.Windows.Forms.GroupBox();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNroDestino = new System.Windows.Forms.TextBox();
            this.txtNroOrigen = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.grpBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxPanel
            // 
            this.grpBoxPanel.Controls.Add(this.btnNumeral);
            this.grpBoxPanel.Controls.Add(this.btn0);
            this.grpBoxPanel.Controls.Add(this.btnAsterisco);
            this.grpBoxPanel.Controls.Add(this.btn9);
            this.grpBoxPanel.Controls.Add(this.btn8);
            this.grpBoxPanel.Controls.Add(this.btn7);
            this.grpBoxPanel.Controls.Add(this.btn6);
            this.grpBoxPanel.Controls.Add(this.btn5);
            this.grpBoxPanel.Controls.Add(this.btn4);
            this.grpBoxPanel.Controls.Add(this.btn3);
            this.grpBoxPanel.Controls.Add(this.btn2);
            this.grpBoxPanel.Controls.Add(this.btn1);
            this.grpBoxPanel.Location = new System.Drawing.Point(12, 58);
            this.grpBoxPanel.Name = "grpBoxPanel";
            this.grpBoxPanel.Size = new System.Drawing.Size(179, 171);
            this.grpBoxPanel.TabIndex = 1;
            this.grpBoxPanel.TabStop = false;
            this.grpBoxPanel.Text = "Panel";
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(197, 70);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(181, 31);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(197, 107);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(181, 33);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtNroDestino
            // 
            this.txtNroDestino.Enabled = false;
            this.txtNroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDestino.Location = new System.Drawing.Point(12, 12);
            this.txtNroDestino.Name = "txtNroDestino";
            this.txtNroDestino.Size = new System.Drawing.Size(366, 31);
            this.txtNroDestino.TabIndex = 0;
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroDestino.TextChanged += new System.EventHandler(this.txtNroDestino_TextChanged);
            // 
            // txtNroOrigen
            // 
            this.txtNroOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroOrigen.Location = new System.Drawing.Point(197, 146);
            this.txtNroOrigen.Name = "txtNroOrigen";
            this.txtNroOrigen.Size = new System.Drawing.Size(181, 26);
            this.txtNroOrigen.TabIndex = 4;
            this.txtNroOrigen.Text = "Nro Origen";
            this.txtNroOrigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroOrigen_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(195, 196);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 33);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbFranja
            // 
            this.cmbFranja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Location = new System.Drawing.Point(10, 244);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(366, 37);
            this.cmbFranja.TabIndex = 6;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 19);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(31, 31);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(43, 19);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(31, 31);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(80, 19);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(31, 31);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 56);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(31, 31);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(43, 56);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(31, 31);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(80, 56);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(31, 31);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(6, 93);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(31, 31);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(43, 93);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(31, 31);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(80, 93);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(31, 31);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(6, 130);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(31, 31);
            this.btnAsterisco.TabIndex = 16;
            this.btnAsterisco.Text = "*";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            this.btnAsterisco.Click += new System.EventHandler(this.btnAsterisco_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(43, 130);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(31, 31);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(80, 130);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(31, 31);
            this.btnNumeral.TabIndex = 18;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            this.btnNumeral.Click += new System.EventHandler(this.btnNumeral_Click);
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 291);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNroOrigen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.grpBoxPanel);
            this.Controls.Add(this.txtNroDestino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLlamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Llamador";
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.grpBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxPanel;
        private System.Windows.Forms.Button btnNumeral;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAsterisco;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNroDestino;
        private System.Windows.Forms.TextBox txtNroOrigen;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbFranja;
    }
}