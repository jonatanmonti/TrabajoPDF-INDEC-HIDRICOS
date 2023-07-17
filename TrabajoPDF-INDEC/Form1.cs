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
using Microsoft.Extensions.Options;
using Microsoft.Office.Interop.Excel;
using objExcel = Microsoft.Office.Interop.Excel;

namespace TrabajoPDF_INDEC
{
    partial class Form1 : Form
    {

        public RutaPDF r = new RutaPDF();

        public RutaTXT rt = new RutaTXT();

        int contador = 0; int cuadro = 0;

        string numero1 = "", numero2 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRutaPDF_Click(object sender, EventArgs e) //boton para buscar la ruta del pdf
        {
            r.ObtenerRuta(); //funcion para obtener la ruta

            textBoxRuta.Text = r.RutaArchivo; //guardamos la direccion de la ruta en el textbox

            buttonPrimeraPagina.Enabled = true;

        }


        private void buttontxt_Click(object sender, EventArgs e)
        {
            if (contador == 0) //if para validar que cuadro estamos guardando (empezando por el cuadro 1, siguiendo el 5 y por ultimo el 4)
            {
                rt.GuardarArchivoTXT(); //funcion para guardar el archivo de texto
                buttonContinuar.Enabled = true;

                buttontxt.Text = "Cuadro 5 guardar txt";
                buttontxt.Enabled = false;
            } else if (contador == 1)
            {
                rt.GuardarArchivoTXT(); //funcion para guardar el archivo de texto
                buttonContinuar.Enabled = true;

                buttontxt.Text = "Cuadro 4 guardar txt";
                buttontxt.Enabled = false;
            } else if (contador == 2)
            {
                rt.GuardarArchivoTXT(); //funcion para guardar el archivo de texto
                buttonContinuar.Enabled = true;

                buttontxt.Text = "Cuadro 2 guardar txt";
                buttontxt.Enabled = false;
            }else if (contador == 3)
            {
                rt.GuardarArchivoTXT(); //funcion para guardar el archivo de texto
                buttonContinuar.Enabled = true;
                buttontxt.Enabled = false;
            }

        }

        public void FuncionBotonContinuar() //funcion para obtener el contenido del pdf y escribirlo en archivos txt
        {
            var pdfDocument = new PdfDocument(new PdfReader(textBoxRuta.Text));
            var strategy = new LocationTextExtractionStrategy();
            r.Text = string.Empty;
            StreamWriter file = new StreamWriter(rt.Archivo, true);
            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++) //for para obtener la cantidad de paginas
            {

                if (r.PrimeraPagina == i && r.UltimaPagina >= i) //if para obtener las paginas especificadas
                {
                    var page = pdfDocument.GetPage(r.PrimeraPagina++); //obtiene el numero de pagina dentro del pdf
                    r.Text = PdfTextExtractor.GetTextFromPage(page); //obtiene el texto dentro del pdf
                    file.Write(r.Text); //escribe las lineas de codigo dentro de los archivos de texto
                    Debug.WriteLine(r.Text);

                }

            }

            file.Close();
            file.Dispose();
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {

            if (contador == 0) //if para validar en que cuadro estamos
            {
                FuncionBotonContinuar(); //funcion para obtener el contenido del pdf y escribirlo en archivos txt

                buttonContinuar.Text = "Cuadro 5 crear txt";
                buttonContinuar.Enabled = false;

                contador++;

                buttonPrimeraPagina.Enabled = true;
            } else if (contador == 1)
            {
                FuncionBotonContinuar(); //funcion para obtener el contenido del pdf y escribirlo en archivos txt

                buttonContinuar.Text = "Cuadro 4 crear txt";
                buttonContinuar.Enabled = false;

                contador++;

                buttonPrimeraPagina.Enabled = true;
            } else if (contador == 2)
            {
                FuncionBotonContinuar(); //funcion para obtener el contenido del pdf y escribirlo en archivos txt

                buttonContinuar.Text = "Cuadro 2 crear txt";
                buttonContinuar.Enabled = false;

                contador++;

                buttonPrimeraPagina.Enabled = true;

            }else if (contador == 3)
            {
                FuncionBotonContinuar(); //funcion para obtener el contenido del pdf y escribirlo en archivos txt
                buttonContinuar.Enabled = false;
                buttonPrimeraPagina.Enabled = true;
            }

        }

        private void buttonPrimeraPagina_Click(object sender, EventArgs e)
        {

            if (contador == 0)
            {
                r.PrimeraPagina = int.Parse(maskedTextBoxPrimeraPagina.Text); //le pedimos al usuario la pagina donde inicia el cuadro
                buttonUltimaPagina.Enabled = true;

                buttonPrimeraPagina.Text = "Cuadro 5 Inicio";
                buttonPrimeraPagina.Enabled = false;
            } else if (contador == 1)
            {
                r.PrimeraPagina = int.Parse(maskedTextBoxPrimeraPagina.Text); //le pedimos al usuario la pagina donde inicia el cuadro
                buttonUltimaPagina.Enabled = true;

                buttonPrimeraPagina.Text = "Cuadro 4 Inicio";
                buttonPrimeraPagina.Enabled = false;
            }
            else if (contador == 2)
            {
                r.PrimeraPagina = int.Parse(maskedTextBoxPrimeraPagina.Text); //le pedimos al usuario la pagina donde inicia el cuadro
                buttonUltimaPagina.Enabled = true;

                buttonPrimeraPagina.Text = "Cuadro 2 Inicio";
                buttonPrimeraPagina.Enabled = false;
            }else if (contador == 3)
            {
                r.PrimeraPagina = int.Parse(maskedTextBoxPrimeraPagina.Text); //le pedimos al usuario la pagina donde inicia el cuadro
                buttonUltimaPagina.Enabled = true;
                buttonPrimeraPagina.Enabled = false;
            }
        }

        private void buttonUltimaPagina_Click(object sender, EventArgs e)
        {

            if (contador == 0) //if para validar en que cuadro estamos
            {
                r.UltimaPagina = int.Parse(maskedTextBoxUltimaPagina.Text); //le pedimos al usuario la pagina donde finaliza el cuadro
                buttontxt.Enabled = true;

                buttonUltimaPagina.Text = "Cuadro 5 Fin";
                buttonUltimaPagina.Enabled = false;
            } else if (contador == 1)
            {
                r.UltimaPagina = int.Parse(maskedTextBoxUltimaPagina.Text); //le pedimos al usuario la pagina donde finaliza el cuadro
                buttontxt.Enabled = true;

                buttonUltimaPagina.Text = "Cuadro 4 Fin";
                buttonUltimaPagina.Enabled = false;
            }
            else if (contador == 2)
            {
                r.UltimaPagina = int.Parse(maskedTextBoxUltimaPagina.Text); //le pedimos al usuario la pagina donde finaliza el cuadro
                buttontxt.Enabled = true;

                buttonUltimaPagina.Text = "Cuadro 2 Fin";
                buttonUltimaPagina.Enabled = false;
            }else if (contador == 3)
            {
                r.UltimaPagina = int.Parse(maskedTextBoxUltimaPagina.Text); //le pedimos al usuario la pagina donde finaliza el cuadro
                buttontxt.Enabled = true;
                buttonUltimaPagina.Enabled = false;
            }

        }
        
        private void Parsear() //funcion para parsear los archivos de texto
        {
            string[] trozos = rt.Linea.Split(' '); //asignamos que el separador es el espacio vacio
            trozos = trozos.ToList().Where(x => !string.IsNullOrEmpty(x)).ToArray(); //esto sirve para indicar que todo espacio vacio extra no nos moleste
            int i = 0;
            Debug.WriteLine(rt.Linea);
            dataGridView1.AllowUserToAddRows = false;
            
            while (i < trozos.Length)
            {
                Debug.WriteLine("[" + trozos[i] + "]");
                i++;
            }

            if (cuadro == 1)
            {

                if (rt.NumeroLinea == 13)
                {
                    dataGridView1.ColumnCount = 6;
                    dataGridView1.Columns[0].HeaderText = "Insumos";
                    dataGridView1.Columns[1].HeaderText = "ponderacion";
                    dataGridView1.Columns[2].HeaderText = trozos[12];
                    dataGridView1.Columns[3].HeaderText = trozos[13];
                    dataGridView1.Columns[4].HeaderText = "variacion";
                    dataGridView1.Columns[5].HeaderText = "indice de variacion resultante";
                }
                else if(rt.NumeroLinea == 27)
                {
                    double resultado = double.Parse(trozos[19]) / double.Parse(trozos[18]);    
                    dataGridView1.Rows.Add("asfaltos, combustibles y lubricantes","",trozos[18],trozos[19],resultado, "");
                    //dataGridView1.Rows.RemoveAt(0);
                }else if (rt.NumeroLinea == 40)
                {
                    double resultado = double.Parse(trozos[16]) / double.Parse(trozos[15]);
                    dataGridView1.Rows.Add("Equipo - Amortizacion de equipos", "", trozos[15], trozos[16], resultado, "");
                }

            }
            else if(cuadro == 2)
            {
                if (rt.NumeroLinea == 16)
                {

                    double resultado = double.Parse(trozos[16]) / double.Parse(trozos[15]);
                    dataGridView1.Rows.Add("Mano de obra", "", trozos[15], trozos[16], resultado, "");

                }
                else if (rt.NumeroLinea == 39)
                {

                    double resultado = double.Parse(trozos[16]) / double.Parse(trozos[15]);
                    dataGridView1.Rows.Add("Gastos Generales", "", trozos[15], trozos[16], resultado, "");

                }
                else if (rt.NumeroLinea == 45)
                {

                    double resultado = double.Parse(trozos[16]) / double.Parse(trozos[15]);
                    dataGridView1.Rows.Add("Hormigon", "", trozos[15], trozos[16], resultado, "");

                }
            }else if (cuadro == 3)
            {

                if(rt.NumeroLinea == 20)
                {
                    numero1 = trozos[2].ToString();
                }else if (rt.NumeroLinea == 21)
                {
                    numero2 = trozos[2].ToString();
                    double resultado = double.Parse(numero2) / double.Parse(numero1);
                    dataGridView1.Rows.Add("Acero", "", numero1, numero2, resultado, "");
                }
            }

        }

        private void buttonPruebas_Click(object sender, EventArgs e)
        {
            
            StreamReader LeerLineas = File.OpenText(textBoxRutaTXT.Text);

            if (cuadro == 1) //if para validar en que cuadro estamos
            {
                while (!LeerLineas.EndOfStream) //while que recorre el cuadro por linea hasta el final del archivo
                {
                    rt.Linea = LeerLineas.ReadLine();
                    
                    if (++rt.NumeroLinea == 13) //if para obtener la linea especifica dentro del archivo de texto
                    {
                        Parsear(); //funcion para parsear los archivos de texto

                        //dataGridView1.Rows.Add();

                        break;

                    }
                }

                while (!LeerLineas.EndOfStream) //while que recorre el cuadro por linea hasta el final del archivo
                {
                    rt.Linea = LeerLineas.ReadLine();
                    
                    if (++rt.NumeroLinea == 27) //if para obtener la linea especifica dentro del archivo de texto
                    {
                        Parsear(); //funcion para parsear los archivos de texto

                        break;
                    }
                }

                while (!LeerLineas.EndOfStream) //while que recorre el cuadro por linea hasta el final del archivo
                {
                    rt.Linea = LeerLineas.ReadLine();

                    if (++rt.NumeroLinea == 40) //if para obtener la linea especifica dentro del archivo de texto
                    {
                        Parsear(); //funcion para parsear los archivos de texto

                        break;
                    }
                }

                rt.NumeroLinea = 0;
            }else if (cuadro == 2) //if para validar en que cuadro estamos
            {
                while (!LeerLineas.EndOfStream) //while que recorre el cuadro por linea hasta el final del archivo
                {
                    rt.Linea = LeerLineas.ReadLine();
                    
                    if (++rt.NumeroLinea == 16) //if para obtener la linea especifica dentro del archivo de texto
                    {
                        Parsear(); //funcion para parsear los archivos de texto

                        break;
                    }
                }

                while (!LeerLineas.EndOfStream) //while que recorre el cuadro por linea hasta el final del archivo
                {
                    rt.Linea = LeerLineas.ReadLine();
                    
                    if (++rt.NumeroLinea == 39) //if para obtener la linea especifica dentro del archivo de texto
                    {
                        Parsear(); //funcion para parsear los archivos de texto

                        break;
                    }
                }

                while (!LeerLineas.EndOfStream) //while que recorre el cuadro por linea hasta el final del archivo
                {
                    rt.Linea = LeerLineas.ReadLine();
                    
                    if (++rt.NumeroLinea == 45) //if para obtener la linea especifica dentro del archivo de texto
                    {
                        Parsear(); //funcion para parsear los archivos de texto

                        break;
                    }
                }
                rt.NumeroLinea = 0;
            }
            else if (cuadro == 3)
            {
                while (!LeerLineas.EndOfStream) //while que recorre el cuadro por linea hasta el final del archivo
                {
                    rt.Linea = LeerLineas.ReadLine();

                    if (++rt.NumeroLinea == 20) //if para obtener la linea especifica dentro del archivo de texto
                    {
                        Parsear(); //funcion para parsear los archivos de texto

                        break;
                    }
                }

                while (!LeerLineas.EndOfStream) //while que recorre el cuadro por linea hasta el final del archivo
                {
                    rt.Linea = LeerLineas.ReadLine();

                    if (++rt.NumeroLinea == 21) //if para obtener la linea especifica dentro del archivo de texto
                    {
                        Parsear(); //funcion para parsear los archivos de texto

                        break;
                    }
                }
            }

            buttonPruebas.Enabled = false;
            buttonRutaTXT.Enabled = true;

        }

        private void buttonRutaTXT_Click(object sender, EventArgs e) //boton para obtener la ruta del archivo de texto que queremos analizar
        {
            rt.ObtenerRutaTXT(); //funcion para obtener la ruta donde se encuentran guardados los archivos de texto

            textBoxRutaTXT.Text = rt.RutaArchivoTXT; //guardamos la direccion de la ruta en el textbox

            cuadro++;
            buttonRutaTXT.Enabled = false;
            buttonPruebas.Enabled=true;
        }

        private void buttonExportarExcel_Click(object sender, EventArgs e)
        {
            objExcel.Application application = new objExcel.Application();
            Workbook objLibro = application.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet objHoja = (Worksheet)application.ActiveSheet;

            application.Visible = true;

            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                objHoja.Cells[1, columna.Index + 1] = columna.HeaderText;
                foreach(DataGridViewRow fila in dataGridView1.Rows)
                {
                    objHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
