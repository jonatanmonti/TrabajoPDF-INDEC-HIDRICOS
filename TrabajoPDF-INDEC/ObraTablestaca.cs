using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoPDF_INDEC
{
    public class ObraTablestaca : ObraCincoItem //Esta clase Hereda de ObraCincoItem y es para la unica obra que solo usa tablestacado
    {

        private float tablestaca; //Item Tablestaca

        public float Tablestaca
        {
            get { return tablestaca; }
            set { tablestaca = value; }
        }

    }
}