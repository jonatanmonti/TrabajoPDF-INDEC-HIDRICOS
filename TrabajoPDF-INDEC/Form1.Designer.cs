namespace TrabajoPDF_INDEC
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
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(216, 42);
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
            this.labelRutaPdf.Location = new System.Drawing.Point(26, 132);
            this.labelRutaPdf.Name = "labelRutaPdf";
            this.labelRutaPdf.Size = new System.Drawing.Size(204, 25);
            this.labelRutaPdf.TabIndex = 6;
            this.labelRutaPdf.Text = "Ingrese la ruta del pdf:";
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRuta.Location = new System.Drawing.Point(264, 133);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(579, 26);
            this.textBoxRuta.TabIndex = 5;
            // 
            // buttonRutaPDF
            // 
            this.buttonRutaPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRutaPDF.Location = new System.Drawing.Point(12, 242);
            this.buttonRutaPDF.Name = "buttonRutaPDF";
            this.buttonRutaPDF.Size = new System.Drawing.Size(831, 53);
            this.buttonRutaPDF.TabIndex = 7;
            this.buttonRutaPDF.Text = "Buscar PDF";
            this.buttonRutaPDF.UseVisualStyleBackColor = true;
            this.buttonRutaPDF.Click += new System.EventHandler(this.buttonRutaPDF_Click);
            // 
            // buttontxt
            // 
            this.buttontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontxt.Location = new System.Drawing.Point(12, 301);
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
            this.buttonContinuar.Location = new System.Drawing.Point(12, 360);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(831, 53);
            this.buttonContinuar.TabIndex = 9;
            this.buttonContinuar.Text = "Continuar";
            this.buttonContinuar.UseVisualStyleBackColor = true;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 472);
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
    }
}

