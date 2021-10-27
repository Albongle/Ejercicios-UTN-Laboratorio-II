
namespace MiFormulario
{
    partial class MiFrm
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
            this.rchTextDatos = new System.Windows.Forms.RichTextBox();
            this.btnAccion = new System.Windows.Forms.Button();
            this.lstPersonas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rchTextDatos
            // 
            this.rchTextDatos.Location = new System.Drawing.Point(12, 9);
            this.rchTextDatos.Name = "rchTextDatos";
            this.rchTextDatos.Size = new System.Drawing.Size(332, 244);
            this.rchTextDatos.TabIndex = 0;
            this.rchTextDatos.Text = "";
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(395, 9);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(145, 53);
            this.btnAccion.TabIndex = 1;
            this.btnAccion.Text = "Accionar";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // lstPersonas
            // 
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.ItemHeight = 15;
            this.lstPersonas.Location = new System.Drawing.Point(580, 9);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(120, 244);
            this.lstPersonas.TabIndex = 2;
            // 
            // MiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 264);
            this.Controls.Add(this.lstPersonas);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.rchTextDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MiFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delegados";
            this.Load += new System.EventHandler(this.MiFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTextDatos;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.ListBox lstPersonas;
    }
}

