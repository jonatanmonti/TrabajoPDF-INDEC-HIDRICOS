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

        public RutaTXT rt = new RutaTXT();

        int contador = 0; int cuadro = 0;

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

            buttonPrimeraPagina.Enabled = true;
            
        }
        

        private void buttontxt_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                rt.GuardarArchivoTXT();
                buttonContinuar.Enabled = true;

                buttontxt.Text = "Cuadro 5 guardar txt";
                buttontxt.Enabled = false;
            }else if (contador == 1)
            {
                rt.GuardarArchivoTXT();
                buttonContinuar.Enabled = true;

                buttontxt.Text = "Cuadro 4 guardar txt";
                buttontxt.Enabled = false;
            }

            
        }

        public void FuncionBotonContinuar()
        {
            var pdfDocument = new PdfDocument(new PdfReader(textBoxRuta.Text));
            var strategy = new LocationTextExtractionStrategy();
            r.Text = string.Empty;
            StreamWriter file = new StreamWriter(rt.Archivo, true);
            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
            {

                if (r.PrimeraPagina == i && r.UltimaPagina >= i)
                {
                    var page = pdfDocument.GetPage(r.PrimeraPagina++);
                    r.Text = PdfTextExtractor.GetTextFromPage(page);
                    file.Write(r.Text);
                    Debug.WriteLine(r.Text);

                }

            }

            file.Close();
            file.Dispose();
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {

            if (contador == 0)
            {
                FuncionBotonContinuar();

                buttonContinuar.Text = "Cuadro 5 crear txt";
                buttonContinuar.Enabled = false;

                contador++;

                buttonPrimeraPagina.Enabled = true;
            }else if (contador == 1)
            {
                FuncionBotonContinuar();

                buttonContinuar.Text = "Cuadro 4 crear txt";
                buttonContinuar.Enabled = false;

                contador++;

                buttonPrimeraPagina.Enabled = true;
            }

            

        }

        private void buttonPrimeraPagina_Click(object sender, EventArgs e)
        {
            

            if(contador == 0)
            {
                r.PrimeraPagina = int.Parse(maskedTextBoxPrimeraPagina.Text);
                buttonUltimaPagina.Enabled = true;

                buttonPrimeraPagina.Text = "Cuadro 5 Inicio";
                buttonPrimeraPagina.Enabled = false;
            }else if(contador == 1)
            {
                r.PrimeraPagina = int.Parse(maskedTextBoxPrimeraPagina.Text);
                buttonUltimaPagina.Enabled = true;

                buttonPrimeraPagina.Text = "Cuadro 4 Inicio";
                buttonPrimeraPagina.Enabled = false;
            }
        }

        private void buttonUltimaPagina_Click(object sender, EventArgs e)
        {

            if(contador == 0)
            {
                r.UltimaPagina = int.Parse(maskedTextBoxUltimaPagina.Text);
                buttontxt.Enabled = true;

                buttonUltimaPagina.Text = "Cuadro 5 Fin";
                buttonUltimaPagina.Enabled = false;
            }else if (contador == 1)
            {
                r.UltimaPagina = int.Parse(maskedTextBoxUltimaPagina.Text);
                buttontxt.Enabled = true;

                buttonUltimaPagina.Text = "Cuadro 4 Fin";
                buttonUltimaPagina.Enabled = false;
            }
            
        }

        private void buttonPruebas_Click(object sender, EventArgs e)
        {
            StreamReader LeerLineas = File.OpenText(textBoxRutaTXT.Text);
            
            if (cuadro == 1)
            {
                while (!LeerLineas.EndOfStream)
                {
                    rt.Linea = LeerLineas.ReadLine();
                    if (++rt.NumeroLinea == 27)
                    {
                        Debug.WriteLine(rt.Linea);
                        break;

                    }
                }

                while (!LeerLineas.EndOfStream)
                {
                    rt.Linea = LeerLineas.ReadLine();
                    if (++rt.NumeroLinea == 40)
                    {
                        Debug.WriteLine(rt.Linea);
                        break;
                    }
                }

                rt.NumeroLinea = 0;
            }
            
            if (cuadro == 2)
            {
                while (!LeerLineas.EndOfStream)
                {
                    rt.Linea = LeerLineas.ReadLine();
                    if (++rt.NumeroLinea == 16)
                    {
                        Debug.WriteLine(rt.Linea);
                        break;
                    }
                }

                while (!LeerLineas.EndOfStream)
                {
                    rt.Linea = LeerLineas.ReadLine();
                    if (++rt.NumeroLinea == 39)
                    {
                        Debug.WriteLine(rt.Linea);
                        break;
                    }
                }

                while (!LeerLineas.EndOfStream)
                {
                    rt.Linea = LeerLineas.ReadLine();
                    if (++rt.NumeroLinea == 45)
                    {
                        Debug.WriteLine(rt.Linea);
                        break;
                    }
                }
            }

        }

        private void buttonRutaTXT_Click(object sender, EventArgs e)
        {
            rt.ObtenerRutaTXT();

            textBoxRutaTXT.Text = rt.RutaArchivoTXT;

            cuadro++;
        }
    }
}
