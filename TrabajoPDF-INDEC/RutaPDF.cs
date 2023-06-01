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

        private string archivo;

        public string Archivo
        {
            get { return archivo; }
            set { archivo = value; }
        }

        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }


        public string ObtenerRuta()
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = OpenFileDialog.FileName;
            }

            return rutaArchivo;
        }

        public string GuardarArchivoTXT()
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog.FileName))
                {

                }

                archivo = saveFileDialog.FileName;
            }
            return archivo;
        }

    }
}