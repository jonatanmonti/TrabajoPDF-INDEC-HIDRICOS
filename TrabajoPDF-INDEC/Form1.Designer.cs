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
            this.buttonPrimeraPagina = new System.Windows.Forms.Button();
            this.buttonUltimaPagina = new System.Windows.Forms.Button();
            this.maskedTextBoxPrimeraPagina = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxUltimaPagina = new System.Windows.Forms.MaskedTextBox();
            this.buttonPruebas = new System.Windows.Forms.Button();
            this.textBoxRutaTXT = new System.Windows.Forms.TextBox();
            this.labelRutaTXT = new System.Windows.Forms.Label();
            this.buttonRutaTXT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(164, 7);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(277, 29);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Extractor Datos INDEC";
            this.labelTitulo.UseWaitCursor = true;
            // 
            // labelRutaPdf
            // 
            this.labelRutaPdf.AutoSize = true;
            this.labelRutaPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRutaPdf.Location = new System.Drawing.Point(9, 39);
            this.labelRutaPdf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRutaPdf.Name = "labelRutaPdf";
            this.labelRutaPdf.Size = new System.Drawing.Size(167, 20);
            this.labelRutaPdf.TabIndex = 6;
            this.labelRutaPdf.Text = "Ingrese la ruta del pdf:";
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRuta.Location = new System.Drawing.Point(198, 40);
            this.textBoxRuta.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.ReadOnly = true;
            this.textBoxRuta.Size = new System.Drawing.Size(360, 23);
            this.textBoxRuta.TabIndex = 5;
            // 
            // buttonRutaPDF
            // 
            this.buttonRutaPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRutaPDF.Location = new System.Drawing.Point(9, 75);
            this.buttonRutaPDF.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRutaPDF.Name = "buttonRutaPDF";
            this.buttonRutaPDF.Size = new System.Drawing.Size(548, 43);
            this.buttonRutaPDF.TabIndex = 7;
            this.buttonRutaPDF.Text = "Buscar PDF";
            this.buttonRutaPDF.UseVisualStyleBackColor = true;
            this.buttonRutaPDF.Click += new System.EventHandler(this.buttonRutaPDF_Click);
            // 
            // buttontxt
            // 
            this.buttontxt.Enabled = false;
            this.buttontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontxt.Location = new System.Drawing.Point(9, 290);
            this.buttontxt.Margin = new System.Windows.Forms.Padding(2);
            this.buttontxt.Name = "buttontxt";
            this.buttontxt.Size = new System.Drawing.Size(548, 43);
            this.buttontxt.TabIndex = 8;
            this.buttontxt.Text = "Cuadro 1 ruta txt";
            this.buttontxt.UseVisualStyleBackColor = true;
            this.buttontxt.Click += new System.EventHandler(this.buttontxt_Click);
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.Enabled = false;
            this.buttonContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinuar.Location = new System.Drawing.Point(9, 338);
            this.buttonContinuar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(548, 43);
            this.buttonContinuar.TabIndex = 9;
            this.buttonContinuar.Text = "Cuadro 1 crear txt";
            this.buttonContinuar.UseVisualStyleBackColor = true;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // buttonPrimeraPagina
            // 
            this.buttonPrimeraPagina.Enabled = false;
            this.buttonPrimeraPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrimeraPagina.Location = new System.Drawing.Point(9, 123);
            this.buttonPrimeraPagina.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrimeraPagina.Name = "buttonPrimeraPagina";
            this.buttonPrimeraPagina.Size = new System.Drawing.Size(197, 43);
            this.buttonPrimeraPagina.TabIndex = 10;
            this.buttonPrimeraPagina.Text = "Cuadro 1 Inicio";
            this.buttonPrimeraPagina.UseVisualStyleBackColor = true;
            this.buttonPrimeraPagina.Click += new System.EventHandler(this.buttonPrimeraPagina_Click);
            // 
            // buttonUltimaPagina
            // 
            this.buttonUltimaPagina.Enabled = false;
            this.buttonUltimaPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUltimaPagina.Location = new System.Drawing.Point(9, 171);
            this.buttonUltimaPagina.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUltimaPagina.Name = "buttonUltimaPagina";
            this.buttonUltimaPagina.Size = new System.Drawing.Size(197, 43);
            this.buttonUltimaPagina.TabIndex = 11;
            this.buttonUltimaPagina.Text = "Cuadro 1 Fin";
            this.buttonUltimaPagina.UseVisualStyleBackColor = true;
            this.buttonUltimaPagina.Click += new System.EventHandler(this.buttonUltimaPagina_Click);
            // 
            // maskedTextBoxPrimeraPagina
            // 
            this.maskedTextBoxPrimeraPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPrimeraPagina.Location = new System.Drawing.Point(221, 135);
            this.maskedTextBoxPrimeraPagina.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxPrimeraPagina.Name = "maskedTextBoxPrimeraPagina";
            this.maskedTextBoxPrimeraPagina.Size = new System.Drawing.Size(130, 23);
            this.maskedTextBoxPrimeraPagina.TabIndex = 12;
            // 
            // maskedTextBoxUltimaPagina
            // 
            this.maskedTextBoxUltimaPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxUltimaPagina.Location = new System.Drawing.Point(221, 183);
            this.maskedTextBoxUltimaPagina.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxUltimaPagina.Name = "maskedTextBoxUltimaPagina";
            this.maskedTextBoxUltimaPagina.Size = new System.Drawing.Size(130, 23);
            this.maskedTextBoxUltimaPagina.TabIndex = 13;
            // 
            // buttonPruebas
            // 
            this.buttonPruebas.Enabled = false;
            this.buttonPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPruebas.Location = new System.Drawing.Point(572, 290);
            this.buttonPruebas.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPruebas.Name = "buttonPruebas";
            this.buttonPruebas.Size = new System.Drawing.Size(568, 43);
            this.buttonPruebas.TabIndex = 14;
            this.buttonPruebas.Text = "Agregar Valores";
            this.buttonPruebas.UseVisualStyleBackColor = true;
            this.buttonPruebas.Click += new System.EventHandler(this.buttonPruebas_Click);
            // 
            // textBoxRutaTXT
            // 
            this.textBoxRutaTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRutaTXT.Location = new System.Drawing.Point(198, 384);
            this.textBoxRutaTXT.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRutaTXT.Name = "textBoxRutaTXT";
            this.textBoxRutaTXT.ReadOnly = true;
            this.textBoxRutaTXT.Size = new System.Drawing.Size(360, 23);
            this.textBoxRutaTXT.TabIndex = 15;
            // 
            // labelRutaTXT
            // 
            this.labelRutaTXT.AutoSize = true;
            this.labelRutaTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRutaTXT.Location = new System.Drawing.Point(22, 384);
            this.labelRutaTXT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRutaTXT.Name = "labelRutaTXT";
            this.labelRutaTXT.Size = new System.Drawing.Size(167, 20);
            this.labelRutaTXT.TabIndex = 16;
            this.labelRutaTXT.Text = "Ingrese la ruta del pdf:";
            // 
            // buttonRutaTXT
            // 
            this.buttonRutaTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRutaTXT.Location = new System.Drawing.Point(9, 410);
            this.buttonRutaTXT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRutaTXT.Name = "buttonRutaTXT";
            this.buttonRutaTXT.Size = new System.Drawing.Size(548, 43);
            this.buttonRutaTXT.TabIndex = 17;
            this.buttonRutaTXT.Text = "Buscar TXT";
            this.buttonRutaTXT.UseVisualStyleBackColor = true;
            this.buttonRutaTXT.Click += new System.EventHandler(this.buttonRutaTXT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(572, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(568, 241);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 475);
            this.Controls.Add(this.dataGridView1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

