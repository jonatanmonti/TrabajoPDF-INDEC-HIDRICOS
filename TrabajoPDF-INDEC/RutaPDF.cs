using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrabajoPDF_INDEC
{
    public class RutaPDF
    {

        public Form1 f = new Form1();

        private string rutaArchivo;

        public string RutaArchivo
        {
            get { return rutaArchivo; }
            set { rutaArchivo = value; }
        }

        private int primeraPagina;

        public int PrimeraPagina
        {
            get { return primeraPagina; }
            set { primeraPagina = value; }
        }

        private int ultimaPagina;

        public int UltimaPagina
        {
            get { return ultimaPagina; }
            set { ultimaPagina = value; }
        }


        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }


        public string ObtenerRuta() //esta funcion se utiliza para obtener la rtua donde se encuentra el pdf
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = OpenFileDialog.FileName;
            }

            f.textBoxRuta.Text = rutaArchivo; //guardamos la direccion de la ruta en el textbox
            f.buttonPrimeraPagina.Enabled = true;

            return rutaArchivo;
        }

    }
}