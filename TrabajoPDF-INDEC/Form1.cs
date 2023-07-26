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

        public RutaPDF r = new RutaPDF(); //objeto de la clase RutaPDF

        public RutaTXT rt = new RutaTXT(); //objeto de la clase RutaTXT

        int contador = 0, cuadro = 0, EleccionObra;

        double ViejoCostoFinanciero, NuevoCostoFinanciero, PonderacionCostoFinanciero = 0.03, total, PonderacionTotal;

        string numero1 = "", numero2 = "";

        public ObraSieteItem ObraSieteItem = new ObraSieteItem();

        public ObraTablestaca ObraTablestaca = new ObraTablestaca();

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

                buttontxt.Text = "Cuadro 3 guardar txt";
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

                buttonContinuar.Text = "Cuadro 3 crear txt";
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

                buttonPrimeraPagina.Text = "Cuadro 3 Inicio";
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

                buttonUltimaPagina.Text = "Cuadro 3 Fin";
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

            if (cuadro == 1) //cuadro 1
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
                    if(EleccionObra == 1 || EleccionObra == 3)
                    {
                        double variacion = double.Parse(trozos[19]) / double.Parse(trozos[18]);
                        double ponderacion = 0.09;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("asfaltos, combustibles y lubricantes", ponderacion, trozos[18], trozos[19], variacion, IndiceVariacionResultante);
                        
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + PonderacionCostoFinanciero;
                        PonderacionTotal = PonderacionTotal + ponderacion;

                    }
                    else if(EleccionObra == 2 || EleccionObra == 5)
                    {
                        double variacion = double.Parse(trozos[19]) / double.Parse(trozos[18]);
                        double ponderacion = 0.34;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("asfaltos, combustibles y lubricantes", ponderacion, trozos[18], trozos[19], variacion, IndiceVariacionResultante);
                        double variacionFinanciera = NuevoCostoFinanciero / ViejoCostoFinanciero;
                        double IndiceVariacionResultanteFinanciera = ponderacion * variacionFinanciera;
                        dataGridView1.Rows.Add("Costo Financiero", PonderacionCostoFinanciero, ViejoCostoFinanciero, NuevoCostoFinanciero, variacionFinanciera, IndiceVariacionResultanteFinanciera);
                        total = total + IndiceVariacionResultanteFinanciera;
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + PonderacionCostoFinanciero;
                        PonderacionTotal = PonderacionTotal + ponderacion;

                    }
                    else if (EleccionObra == 4)
                    {
                        double variacion = double.Parse(trozos[19]) / double.Parse(trozos[18]);
                        double ponderacion = 0.10;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("asfaltos, combustibles y lubricantes", ponderacion, trozos[18], trozos[19], variacion, IndiceVariacionResultante);
                        double variacionFinanciera = NuevoCostoFinanciero / ViejoCostoFinanciero;
                        double IndiceVariacionResultanteFinanciera = ponderacion * variacionFinanciera;
                        dataGridView1.Rows.Add("Costo Financiero", PonderacionCostoFinanciero, ViejoCostoFinanciero, NuevoCostoFinanciero, variacionFinanciera, IndiceVariacionResultanteFinanciera);
                        total = total + IndiceVariacionResultanteFinanciera;
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + PonderacionCostoFinanciero;
                        PonderacionTotal = PonderacionTotal + ponderacion;
                    }
                }
                else if (rt.NumeroLinea == 40)
                {
                    if (EleccionObra == 1 || EleccionObra == 3)
                    {
                        double variacion = double.Parse(trozos[16]) / double.Parse(trozos[15]);
                        double ponderacion = 0.15;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("Equipo - Amortizacion de equipos", ponderacion, trozos[15], trozos[16], variacion, IndiceVariacionResultante);
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + ponderacion;
                    }
                    else if (EleccionObra == 2 || EleccionObra == 5)
                    {
                        double variacion = double.Parse(trozos[16]) / double.Parse(trozos[15]);
                        double ponderacion = 0.35;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("Equipo - Amortizacion de equipos", ponderacion, trozos[15], trozos[16], variacion, IndiceVariacionResultante);
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + ponderacion;
                    }
                    else if(EleccionObra == 4)
                    {
                        double variacion = double.Parse(trozos[16]) / double.Parse(trozos[15]);
                        double ponderacion = 0.10;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("Equipo - Amortizacion de equipos", ponderacion, trozos[15], trozos[16], variacion, IndiceVariacionResultante);
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + ponderacion;
                    }
                }

            }
            else if(cuadro == 2) //cuadro 5
            {
                if (rt.NumeroLinea == 16)
                {
                    if (EleccionObra == 1)
                    {
                        double variacion = double.Parse(trozos[16]) / double.Parse(trozos[15]);
                        double ponderacion = 0.24;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("Mano de obra", ponderacion, trozos[15], trozos[16], variacion, IndiceVariacionResultante);
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + ponderacion;
                    }
                    else if(EleccionObra == 2 || EleccionObra == 4 || EleccionObra == 5)
                    {
                        double variacion = double.Parse(trozos[16]) / double.Parse(trozos[15]);
                        double ponderacion = 0.20;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("Mano de obra", ponderacion, trozos[15], trozos[16], variacion, IndiceVariacionResultante);
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + ponderacion;
                    }
                    else if(EleccionObra == 3)
                    {
                        double variacion = double.Parse(trozos[16]) / double.Parse(trozos[15]);
                        double ponderacion = 0.30;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("Mano de obra", ponderacion, trozos[15], trozos[16], variacion, IndiceVariacionResultante);
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + ponderacion;
                    }

                }
                else if (rt.NumeroLinea == 39)
                {
                    if (EleccionObra == 1 || EleccionObra == 2 || EleccionObra == 3)
                    {
                        double variacion = double.Parse(trozos[16]) / double.Parse(trozos[15]);
                        double ponderacion = 0.08;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("Gastos Generales", ponderacion, trozos[15], trozos[16], variacion, IndiceVariacionResultante);
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + ponderacion;
                    }
                    else if(EleccionObra == 4 || EleccionObra==5)
                    {
                        double variacion = double.Parse(trozos[16]) / double.Parse(trozos[15]);
                        double ponderacion = 0.15;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("Gastos Generales", ponderacion, trozos[15], trozos[16], variacion, IndiceVariacionResultante);
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + ponderacion;
                    }
                }
                else if (rt.NumeroLinea == 45)
                {
                    if (EleccionObra == 1)
                    {
                        double variacion = double.Parse(trozos[16]) / double.Parse(trozos[15]);
                        double ponderacion = 0.30;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("Hormigon", ponderacion, trozos[15], trozos[16], variacion, IndiceVariacionResultante);
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + ponderacion;
                    }
                    else if (EleccionObra == 3)
                    {
                        double variacion = double.Parse(trozos[16]) / double.Parse(trozos[15]);
                        double ponderacion = 0.22;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("Hormigon", ponderacion, trozos[15], trozos[16], variacion, IndiceVariacionResultante);
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + ponderacion;
                    }
                    else if(EleccionObra == 4)
                    {
                        double variacion = double.Parse(trozos[16]) / double.Parse(trozos[15]);
                        double ponderacion = 0.12;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("Hormigon", ponderacion, trozos[15], trozos[16], variacion, IndiceVariacionResultante);
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + ponderacion;
                    }
                }
            }else if (cuadro == 3) //cuadro 4
            {

                if(rt.NumeroLinea == 20)
                {
                    numero1 = trozos[2].ToString();
                }else if (rt.NumeroLinea == 21)
                {
                    numero2 = trozos[2].ToString();

                    if (EleccionObra == 1)
                    {
                        double variacion = double.Parse(numero2) / double.Parse(numero1);
                        double ponderacion = 0.11;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("Acero", ponderacion, numero1, numero2, variacion, IndiceVariacionResultante);
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + ponderacion;
                    }
                    else if (EleccionObra == 3)
                    {
                        double variacion = double.Parse(numero2) / double.Parse(numero1);
                        double ponderacion = 0.13;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("Acero", ponderacion, numero1, numero2, variacion, IndiceVariacionResultante);
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + ponderacion;
                    }
                }
            }else if (cuadro == 4) //cuadro 3
            {
                if (rt.NumeroLinea == 24)
                {
                    if (EleccionObra == 4)
                    {
                        double variacion = double.Parse(trozos[19]) / double.Parse(trozos[18]);
                        double ponderacion = 0.30;
                        double IndiceVariacionResultante;
                        IndiceVariacionResultante = ponderacion * variacion;
                        dataGridView1.Rows.Add("Hierros y aceros en formas basicas", ponderacion, trozos[18], trozos[19], variacion, IndiceVariacionResultante);
                        total = total + IndiceVariacionResultante;
                        PonderacionTotal = PonderacionTotal + ponderacion;
                    }
                }
            }

        }

        private void buttonPruebas_Click(object sender, EventArgs e)
        {
            
            radioButtonDesaguesPluviales.Enabled = false;
            radioButtonExcavacionCanal.Enabled = false;
            radioButtonPresas.Enabled = false;
            radioButtonDefensaCostera.Enabled = false;
            radioButtonDefensaPoblacion.Enabled = false;

            StreamReader LeerLineas = File.OpenText(textBoxRutaTXT.Text);

            if (cuadro == 1) //if para validar en que cuadro estamos \\cuadro 1
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
            }else if (cuadro == 2) //if para validar en que cuadro estamos \\cuadro 5
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
            else if (cuadro == 3) //cuadro 4
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
                rt.NumeroLinea = 0;
            }else if (cuadro == 4) //cuadro 3
            {
                while (!LeerLineas.EndOfStream) //while que recorre el cuadro por linea hasta el final del archivo
                {
                    rt.Linea = LeerLineas.ReadLine();

                    if (++rt.NumeroLinea == 24) //if para obtener la linea especifica dentro del archivo de texto
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

        private void radioButtonDesaguesPluviales_CheckedChanged(object sender, EventArgs e)
        {
            EleccionObra = 1;
        }

        private void radioButtonExcavacionCanal_CheckedChanged(object sender, EventArgs e)
        {
            EleccionObra = 2;
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Total", PonderacionTotal, "", "", "", total);
            buttonExportarExcel.Enabled = true;
        }

        private void radioButtonPresas_CheckedChanged(object sender, EventArgs e)
        {
            EleccionObra = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevoCostoFinanciero = double.Parse(maskedNuevoCostoFinanciero.Text);
            button2.Enabled = false;
        }

        private void radioButtonDefensaCostera_CheckedChanged(object sender, EventArgs e)
        {
            EleccionObra = 4;
        }

        private void radioButtonDefensaPoblacion_CheckedChanged(object sender, EventArgs e)
        {
            EleccionObra = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViejoCostoFinanciero = double.Parse(maskedViejoCostoFinanciero.Text);
            button1.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
