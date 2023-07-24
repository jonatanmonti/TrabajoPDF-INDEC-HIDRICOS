using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoPDF_INDEC
{
    public class ObraSieteItem : ObraCincoItem
    {

		private float hormigon;

		public float Hormigon
		{
			get { return hormigon; }
			set { hormigon = value; }
		}

		private float acero;

		public float Acero
		{
			get { return acero; }
			set { acero = value; }
		}


	}
}