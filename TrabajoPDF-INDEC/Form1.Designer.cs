﻿namespace TrabajoPDF_INDEC
{
    partial class Form1
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelRutaPdf = new System.Windows.Forms.Label();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.buttonRutaPDF = new System.Windows.Forms.Button();
            this.buttontxt = new System.Windows.Forms.Button();
            this.buttonContinuar = new System.Windows.Forms.Button();
            this.buttonPrimeraPagina = new System.Windows.Forms.Button();
            this.buttonUltimaPagina = new System.Windows.Forms.Button();
            this.maskedTextBoxPrimeraPagina = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxUltimaPagina = new System.Windows.Forms.MaskedTextBox();
            this.buttonPruebas = new System.Windows.Forms.Button();
            this.textBoxRutaTXT = new System.Windows.Forms.TextBox();
            this.labelRutaTXT = new System.Windows.Forms.Label();
            this.buttonRutaTXT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(218, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(350, 37);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Extractor Datos INDEC";
            this.labelTitulo.UseWaitCursor = true;
            // 
            // labelRutaPdf
            // 
            this.labelRutaPdf.AutoSize = true;
            this.labelRutaPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRutaPdf.Location = new System.Drawing.Point(12, 48);
            this.labelRutaPdf.Name = "labelRutaPdf";
            this.labelRutaPdf.Size = new System.Drawing.Size(204, 25);
            this.labelRutaPdf.TabIndex = 6;
            this.labelRutaPdf.Text = "Ingrese la ruta del pdf:";
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRuta.Location = new System.Drawing.Point(264, 49);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.ReadOnly = true;
            this.textBoxRuta.Size = new System.Drawing.Size(579, 26);
            this.textBoxRuta.TabIndex = 5;
            // 
            // buttonRutaPDF
            // 
            this.buttonRutaPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRutaPDF.Location = new System.Drawing.Point(12, 92);
            this.buttonRutaPDF.Name = "buttonRutaPDF";
            this.buttonRutaPDF.Size = new System.Drawing.Size(831, 53);
            this.buttonRutaPDF.TabIndex = 7;
            this.buttonRutaPDF.Text = "Buscar PDF";
            this.buttonRutaPDF.UseVisualStyleBackColor = true;
            this.buttonRutaPDF.Click += new System.EventHandler(this.buttonRutaPDF_Click);
            // 
            // buttontxt
            // 
            this.buttontxt.Enabled = false;
            this.buttontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontxt.Location = new System.Drawing.Point(12, 269);
            this.buttontxt.Name = "buttontxt";
            this.buttontxt.Size = new System.Drawing.Size(831, 53);
            this.buttontxt.TabIndex = 8;
            this.buttontxt.Text = "Guardar archivo txt";
            this.buttontxt.UseVisualStyleBackColor = true;
            this.buttontxt.Click += new System.EventHandler(this.buttontxt_Click);
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.Enabled = false;
            this.buttonContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinuar.Location = new System.Drawing.Point(12, 328);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(831, 53);
            this.buttonContinuar.TabIndex = 9;
            this.buttonContinuar.Text = "Continuar";
            this.buttonContinuar.UseVisualStyleBackColor = true;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // buttonPrimeraPagina
            // 
            this.buttonPrimeraPagina.Enabled = false;
            this.buttonPrimeraPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrimeraPagina.Location = new System.Drawing.Point(12, 151);
            this.buttonPrimeraPagina.Name = "buttonPrimeraPagina";
            this.buttonPrimeraPagina.Size = new System.Drawing.Size(263, 53);
            this.buttonPrimeraPagina.TabIndex = 10;
            this.buttonPrimeraPagina.Text = "Primera pagina a analizar";
            this.buttonPrimeraPagina.UseVisualStyleBackColor = true;
            this.buttonPrimeraPagina.Click += new System.EventHandler(this.buttonPrimeraPagina_Click);
            // 
            // buttonUltimaPagina
            // 
            this.buttonUltimaPagina.Enabled = false;
            this.buttonUltimaPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUltimaPagina.Location = new System.Drawing.Point(12, 210);
            this.buttonUltimaPagina.Name = "buttonUltimaPagina";
            this.buttonUltimaPagina.Size = new System.Drawing.Size(263, 53);
            this.buttonUltimaPagina.TabIndex = 11;
            this.buttonUltimaPagina.Text = "Ultima pagina a analizar";
            this.buttonUltimaPagina.UseVisualStyleBackColor = true;
            this.buttonUltimaPagina.Click += new System.EventHandler(this.buttonUltimaPagina_Click);
            // 
            // maskedTextBoxPrimeraPagina
            // 
            this.maskedTextBoxPrimeraPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPrimeraPagina.Location = new System.Drawing.Point(295, 166);
            this.maskedTextBoxPrimeraPagina.Name = "maskedTextBoxPrimeraPagina";
            this.maskedTextBoxPrimeraPagina.Size = new System.Drawing.Size(172, 26);
            this.maskedTextBoxPrimeraPagina.TabIndex = 12;
            // 
            // maskedTextBoxUltimaPagina
            // 
            this.maskedTextBoxUltimaPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxUltimaPagina.Location = new System.Drawing.Point(295, 225);
            this.maskedTextBoxUltimaPagina.Name = "maskedTextBoxUltimaPagina";
            this.maskedTextBoxUltimaPagina.Size = new System.Drawing.Size(172, 26);
            this.maskedTextBoxUltimaPagina.TabIndex = 13;
            // 
            // buttonPruebas
            // 
            this.buttonPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPruebas.Location = new System.Drawing.Point(554, 151);
            this.buttonPruebas.Name = "buttonPruebas";
            this.buttonPruebas.Size = new System.Drawing.Size(289, 53);
            this.buttonPruebas.TabIndex = 14;
            this.buttonPruebas.Text = "pruebas";
            this.buttonPruebas.UseVisualStyleBackColor = true;
            this.buttonPruebas.Click += new System.EventHandler(this.buttonPruebas_Click);
            // 
            // textBoxRutaTXT
            // 
            this.textBoxRutaTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRutaTXT.Location = new System.Drawing.Point(264, 387);
            this.textBoxRutaTXT.Name = "textBoxRutaTXT";
            this.textBoxRutaTXT.ReadOnly = true;
            this.textBoxRutaTXT.Size = new System.Drawing.Size(579, 26);
            this.textBoxRutaTXT.TabIndex = 15;
            // 
            // labelRutaTXT
            // 
            this.labelRutaTXT.AutoSize = true;
            this.labelRutaTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRutaTXT.Location = new System.Drawing.Point(31, 388);
            this.labelRutaTXT.Name = "labelRutaTXT";
            this.labelRutaTXT.Size = new System.Drawing.Size(204, 25);
            this.labelRutaTXT.TabIndex = 16;
            this.labelRutaTXT.Text = "Ingrese la ruta del pdf:";
            // 
            // buttonRutaTXT
            // 
            this.buttonRutaTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRutaTXT.Location = new System.Drawing.Point(12, 416);
            this.buttonRutaTXT.Name = "buttonRutaTXT";
            this.buttonRutaTXT.Size = new System.Drawing.Size(831, 53);
            this.buttonRutaTXT.TabIndex = 17;
            this.buttonRutaTXT.Text = "Buscar TXT";
            this.buttonRutaTXT.UseVisualStyleBackColor = true;
            this.buttonRutaTXT.Click += new System.EventHandler(this.buttonRutaTXT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 484);
            this.Controls.Add(this.buttonRutaTXT);
            this.Controls.Add(this.labelRutaTXT);
            this.Controls.Add(this.textBoxRutaTXT);
            this.Controls.Add(this.buttonPruebas);
            this.Controls.Add(this.maskedTextBoxUltimaPagina);
            this.Controls.Add(this.maskedTextBoxPrimeraPagina);
            this.Controls.Add(this.buttonUltimaPagina);
            this.Controls.Add(this.buttonPrimeraPagina);
            this.Controls.Add(this.buttonContinuar);
            this.Controls.Add(this.buttontxt);
            this.Controls.Add(this.buttonRutaPDF);
            this.Controls.Add(this.labelRutaPdf);
            this.Controls.Add(this.textBoxRuta);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelRutaPdf;
        private System.Windows.Forms.TextBox textBoxRuta;
        private System.Windows.Forms.Button buttonRutaPDF;
        private System.Windows.Forms.Button buttontxt;
        private System.Windows.Forms.Button buttonContinuar;
        private System.Windows.Forms.Button buttonPrimeraPagina;
        private System.Windows.Forms.Button buttonUltimaPagina;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrimeraPagina;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxUltimaPagina;
        private System.Windows.Forms.Button buttonPruebas;
        private System.Windows.Forms.TextBox textBoxRutaTXT;
        private System.Windows.Forms.Label labelRutaTXT;
        private System.Windows.Forms.Button buttonRutaTXT;
    }
}

