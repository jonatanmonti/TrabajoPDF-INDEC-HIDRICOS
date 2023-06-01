using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace TrabajoPDF_INDEC
{
    public partial class Form1 : Form
    {

        public RutaPDF r = new RutaPDF();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRutaPDF_Click(object sender, EventArgs e)
        {
            r.ObtenerRuta();

            textBoxRuta.Text = r.RutaArchivo;

            
            buttontxt.Enabled = true;
        }

        string archivo;

        private void buttontxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog.FileName))
                {

                }

                archivo = saveFileDialog.FileName;
            }

            buttonContinuar.Enabled = true;
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            var pdfDocument = new PdfDocument(new PdfReader(textBoxRuta.Text));
            var strategy = new LocationTextExtractionStrategy();
            string text = string.Empty;
            StreamWriter file = new StreamWriter(archivo, true);
            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
            {
                var page = pdfDocument.GetPage(i);
                text = PdfTextExtractor.GetTextFromPage(page);
                file.Write(text);
                Debug.WriteLine(text);
            }

            file.Close();
            file.Dispose();
        }
    }
}
