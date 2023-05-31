using System;
using System.Collections.Generic;
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

        public string ObtenerRuta()
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = OpenFileDialog.FileName;
            }

            return rutaArchivo;
        }

    }
}